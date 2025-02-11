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
End Class