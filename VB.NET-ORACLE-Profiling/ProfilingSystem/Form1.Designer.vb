<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtCourse = New TextBox()
        txtAddress = New TextBox()
        Label7 = New Label()
        txtContactNum = New TextBox()
        Label6 = New Label()
        txtAge = New TextBox()
        Label5 = New Label()
        dtpBirthday = New DateTimePicker()
        Label4 = New Label()
        rdbFemale = New RadioButton()
        rdbMale = New RadioButton()
        btnLoad = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        txtMiddleName = New TextBox()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        Label3 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        lblTotal = New Label()
        Label1 = New Label()
        txtSchoolAddress = New TextBox()
        Label11 = New Label()
        cbYear = New ComboBox()
        Label10 = New Label()
        cbSection = New ComboBox()
        DataGridView1 = New DataGridView()
        GroupBox2 = New GroupBox()
        Label9 = New Label()
        GroupBox1 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(32, 59)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(334, 27)
        txtCourse.TabIndex = 17
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(34, 330)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(456, 27)
        txtAddress.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 307)
        Label7.Name = "Label7"
        Label7.Size = New Size(62, 20)
        Label7.TabIndex = 14
        Label7.Text = "Address"
        ' 
        ' txtContactNum
        ' 
        txtContactNum.Location = New Point(34, 255)
        txtContactNum.Name = "txtContactNum"
        txtContactNum.Size = New Size(246, 27)
        txtContactNum.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 232)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 20)
        Label6.TabIndex = 12
        Label6.Text = "Contact #:"
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(353, 178)
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(125, 27)
        txtAge.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(353, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 20)
        Label5.TabIndex = 10
        Label5.Text = "Age"
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.CustomFormat = "yyyy-MMM-dd"
        dtpBirthday.Format = DateTimePickerFormat.Custom
        dtpBirthday.Location = New Point(30, 178)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(250, 27)
        dtpBirthday.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 8
        Label4.Text = "Birthday"
        ' 
        ' rdbFemale
        ' 
        rdbFemale.AutoSize = True
        rdbFemale.Location = New Point(138, 114)
        rdbFemale.Name = "rdbFemale"
        rdbFemale.Size = New Size(78, 24)
        rdbFemale.TabIndex = 7
        rdbFemale.TabStop = True
        rdbFemale.Text = "Female"
        rdbFemale.UseVisualStyleBackColor = True
        ' 
        ' rdbMale
        ' 
        rdbMale.AutoSize = True
        rdbMale.Location = New Point(32, 114)
        rdbMale.Name = "rdbMale"
        rdbMale.Size = New Size(63, 24)
        rdbMale.TabIndex = 6
        rdbMale.TabStop = True
        rdbMale.Text = "Male"
        rdbMale.UseVisualStyleBackColor = True
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(619, 17)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(105, 38)
        btnLoad.TabIndex = 29
        btnLoad.Text = "Load Data"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(413, 689)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(105, 38)
        btnClear.TabIndex = 28
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(286, 689)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(105, 38)
        btnDelete.TabIndex = 27
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(160, 689)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(105, 38)
        btnUpdate.TabIndex = 26
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(40, 689)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(105, 38)
        btnSave.TabIndex = 25
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(365, 68)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(125, 27)
        txtMiddleName.TabIndex = 5
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(189, 68)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(125, 27)
        txtFirstName.TabIndex = 4
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(30, 68)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(125, 27)
        txtLastName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(365, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 2
        Label3.Text = "Middle Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(28, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 20)
        Label8.TabIndex = 16
        Label8.Text = "Course:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(189, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 1
        Label2.Text = "First Name"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(623, 645)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(53, 20)
        lblTotal.TabIndex = 31
        lblTotal.Text = "Total:0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Last Name"
        ' 
        ' txtSchoolAddress
        ' 
        txtSchoolAddress.Location = New Point(28, 219)
        txtSchoolAddress.Multiline = True
        txtSchoolAddress.Name = "txtSchoolAddress"
        txtSchoolAddress.Size = New Size(456, 27)
        txtSchoolAddress.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(24, 196)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 20)
        Label11.TabIndex = 16
        Label11.Text = "School Address:"
        ' 
        ' cbYear
        ' 
        cbYear.FormattingEnabled = True
        cbYear.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        cbYear.Location = New Point(209, 147)
        cbYear.Name = "cbYear"
        cbYear.Size = New Size(151, 28)
        cbYear.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(209, 116)
        Label10.Name = "Label10"
        Label10.Size = New Size(40, 20)
        Label10.TabIndex = 20
        Label10.Text = "Year:"
        ' 
        ' cbSection
        ' 
        cbSection.FormattingEnabled = True
        cbSection.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G"})
        cbSection.Location = New Point(30, 147)
        cbSection.Name = "cbSection"
        cbSection.Size = New Size(151, 28)
        cbSection.TabIndex = 19
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(623, 71)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(519, 555)
        DataGridView1.TabIndex = 30
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtSchoolAddress)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(cbYear)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(cbSection)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(txtCourse)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Location = New Point(16, 410)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(566, 264)
        GroupBox2.TabIndex = 24
        GroupBox2.TabStop = False
        GroupBox2.Text = "School Information"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(32, 116)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 20)
        Label9.TabIndex = 18
        Label9.Text = "Section:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtContactNum)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(dtpBirthday)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(rdbFemale)
        GroupBox1.Controls.Add(rdbMale)
        GroupBox1.Controls.Add(txtMiddleName)
        GroupBox1.Controls.Add(txtFirstName)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(14, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(566, 382)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1156, 732)
        Controls.Add(btnLoad)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(lblTotal)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Profiling System"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtContactNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSchoolAddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbSection As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
