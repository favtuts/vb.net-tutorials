<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtBoxFirstName = New TextBox()
        TxtBoxLastName = New TextBox()
        TxtBoxEmailID = New TextBox()
        Label1 = New Label()
        BtnSubmit = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' TxtBoxFirstName
        ' 
        TxtBoxFirstName.Location = New Point(310, 120)
        TxtBoxFirstName.Name = "TxtBoxFirstName"
        TxtBoxFirstName.Size = New Size(375, 27)
        TxtBoxFirstName.TabIndex = 0
        ' 
        ' TxtBoxLastName
        ' 
        TxtBoxLastName.Location = New Point(310, 167)
        TxtBoxLastName.Name = "TxtBoxLastName"
        TxtBoxLastName.Size = New Size(375, 27)
        TxtBoxLastName.TabIndex = 1
        ' 
        ' TxtBoxEmailID
        ' 
        TxtBoxEmailID.Location = New Point(310, 214)
        TxtBoxEmailID.Name = "TxtBoxEmailID"
        TxtBoxEmailID.Size = New Size(375, 27)
        TxtBoxEmailID.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(116, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 3
        Label1.Text = "First Name"
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(310, 281)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(135, 50)
        BtnSubmit.TabIndex = 4
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(116, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 5
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(116, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 6
        Label3.Text = "Email ID"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnSubmit)
        Controls.Add(Label1)
        Controls.Add(TxtBoxEmailID)
        Controls.Add(TxtBoxLastName)
        Controls.Add(TxtBoxFirstName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtBoxFirstName As TextBox
    Friend WithEvents TxtBoxLastName As TextBox
    Friend WithEvents TxtBoxEmailID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
