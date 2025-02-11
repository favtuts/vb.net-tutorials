Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadData()
        Dim dbConResult = TestDatabaseConnection()
        If dbConResult.Success Then
            MessageBox.Show(dbConResult.Message, "SUCCESS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(dbConResult.Message, "WARNING",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadData()
    End Sub

    Private Sub LoadData()
        DataGridView1.DataSource = LoadStudentData()    'bind list into data source
        DataGridView1.Columns("Id").Visible = False     'hide this columnID
        lblTotal.Text = "Total: " & DataGridView1.Rows.Count
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleName.Clear()
        txtAddress.Clear()
        rdbMale.Checked = False
        rdbFemale.Checked = False
        dtpBirthday.ResetText()
        txtContactNum.Clear()
        txtCourse.Clear()
        cbSection.SelectedItem = 0
        cbYear.SelectedItem = 0
        txtSchoolAddress.Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim student = New StudentInfo()
        student.FirstName = txtFirstName.Text
        student.LastName = txtLastName.Text
        student.MiddleName = txtMiddleName.Text

        'Check if Male or Female is checked by user if not no gender selected
        If rdbMale.Checked Or rdbFemale.Checked Then
            If rdbMale.Checked Then
                student.Gender = "Male"
            Else
                student.Gender = "Female"
            End If
        Else
            'TODO: show message box please select gender
            MessageBox.Show("Please select gender.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return ' to not proceed bellow weewww
        End If

        student.Birthday = dtpBirthday.Value
        student.ContactNum = txtContactNum.Text
        student.Address = txtAddress.Text
        student.Course = txtCourse.Text
        student.Year = cbYear.Text
        student.Section = cbSection.Text
        student.SchoolAddress = txtSchoolAddress.Text
        student.Created = DateTime.Now()

        Try
            Dim result = Insert(student)
            If result Then
                LoadData() 'Refresh the DataGrid
                MessageBox.Show("Student Information successfully created.", "SUCCESS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Student Information FAILED to save see the exception bellow." +
                            Environment.NewLine + ex.ToString(), "WARNING",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Check if ther's is rows index selected
        If e.RowIndex < 0 Then Return

        Dim row = DataGridView1.Rows(e.RowIndex)
        'Global (StudentId) ID for student record
        StudentId = Convert.ToInt64(row.Cells("Id").Value)
        txtFirstName.Text = row.Cells("FirstName").Value.ToString()
        txtLastName.Text = row.Cells("LastName").Value.ToString()
        Dim gender = row.Cells("Gender").Value.ToString()

        rdbMale.Checked = gender = "Male"

        rdbFemale.Checked = Not gender = "Male" And Not gender = ""

        txtMiddleName.Text = row.Cells("MiddleName").Value.ToString()
        dtpBirthday.Value = Convert.ToDateTime(row.Cells("Birthday").Value.ToString())
        txtContactNum.Text = row.Cells("ContactNum").Value.ToString()
        txtAddress.Text = row.Cells("Address").Value.ToString()
        txtCourse.Text = row.Cells("Course").Value.ToString()
        txtSchoolAddress.Text = row.Cells("SchoolAddress").Value.ToString()
        Dim year = row.Cells("Year").Value.ToString()
        Dim section = row.Cells("Section").Value.ToString()
        cbSection.SelectedIndex = cbSection.FindStringExact(section)
        cbYear.SelectedIndex = cbYear.FindStringExact(year)
        txtAge.Text = CopmuteAge(dtpBirthday.Value)
        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Function CopmuteAge(ByVal bday As DateTime) As Int32

        Dim now = DateTime.Now
        'Subtract year to birthday
        Dim age = now.Year - bday.Year
        'check if the date of birth is not happening
        If bday.Month < now.Month Then
            'subtract 1
            age -= 1
        End If
        Return age

    End Function

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        txtAge.Text = CopmuteAge(dtpBirthday.Value)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If StudentId <= 0 Then
            MessageBox.Show("Please select student to delete.")
            Return
        End If

        Dim action = MessageBox.Show("Are you sure do you want to delete this data?", "CONFIRM ACTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If action = DialogResult.No Then
            Return
        End If
        Dim student = New StudentInfo()
        student.Id = StudentId

        Try
            Dim result = DeleteStudentInfo(student)
            If result Then
                LoadData()
                'Refresh the DataGrid 
                StudentId = 0
                MessageBox.Show("Student Information successfully DELETED.", "SUCCESS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Student Information FAILED to save see the exception below." +
                            Environment.NewLine + ex.ToString(), "WARNING",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If StudentId <= 0 Then
            MessageBox.Show("Please select student to update.")
            Return
        End If

        Dim student = New StudentInfo()
        student.Id = StudentId
        student.FirstName = txtFirstName.Text
        student.LastName = txtLastName.Text
        student.MiddleName = txtMiddleName.Text

        'Check if Male or Female is checked by user if not no gender selected
        If rdbMale.Checked Or rdbFemale.Checked Then
            If rdbMale.Checked Then
                student.Gender = "Male"
            Else
                student.Gender = "Female"
            End If
        Else
            'TODO: show message box please select gender
            MessageBox.Show("Please select gender.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return ' to not proceed below weewww
        End If

        student.Birthday = dtpBirthday.Value
        student.ContactNum = txtContactNum.Text
        student.Address = txtAddress.Text
        student.Course = txtCourse.Text
        student.Year = cbYear.Text
        student.Section = cbSection.Text
        student.SchoolAddress = txtSchoolAddress.Text
        student.Created = DateTime.Now
        Try
            Dim result = UpdateStudentInfo(student)
            If result Then
                LoadData()
                StudentId = 0
                'Refresh the DataGrid 
                MessageBox.Show("Student Information successfully UPDATED.", "SUCCESS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Student Information FAILED to save see the exception below." +
                            Environment.NewLine + ex.ToString(), "WARNING",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class