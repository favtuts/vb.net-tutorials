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
        LstBoxSelectGames = New ListBox()
        LstSelectedGames = New ListBox()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TxtBoxFirstName
        ' 
        TxtBoxFirstName.Location = New Point(165, 88)
        TxtBoxFirstName.Name = "TxtBoxFirstName"
        TxtBoxFirstName.Size = New Size(258, 27)
        TxtBoxFirstName.TabIndex = 0
        ' 
        ' TxtBoxLastName
        ' 
        TxtBoxLastName.Location = New Point(165, 135)
        TxtBoxLastName.Name = "TxtBoxLastName"
        TxtBoxLastName.Size = New Size(258, 27)
        TxtBoxLastName.TabIndex = 1
        ' 
        ' TxtBoxEmailID
        ' 
        TxtBoxEmailID.Location = New Point(165, 182)
        TxtBoxEmailID.Name = "TxtBoxEmailID"
        TxtBoxEmailID.Size = New Size(258, 27)
        TxtBoxEmailID.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 3
        Label1.Text = "First Name"
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(165, 237)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(135, 50)
        BtnSubmit.TabIndex = 4
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 5
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 6
        Label3.Text = "Email ID"
        ' 
        ' LstBoxSelectGames
        ' 
        LstBoxSelectGames.FormattingEnabled = True
        LstBoxSelectGames.Items.AddRange(New Object() {"Cricket", "Football", "Basketball", "Handball"})
        LstBoxSelectGames.Location = New Point(471, 103)
        LstBoxSelectGames.Name = "LstBoxSelectGames"
        LstBoxSelectGames.Size = New Size(150, 184)
        LstBoxSelectGames.TabIndex = 7
        ' 
        ' LstSelectedGames
        ' 
        LstSelectedGames.FormattingEnabled = True
        LstSelectedGames.Location = New Point(770, 103)
        LstSelectedGames.Name = "LstSelectedGames"
        LstSelectedGames.Size = New Size(150, 184)
        LstSelectedGames.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(485, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 9
        Label4.Text = "Select Games"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(780, 62)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 20)
        Label5.TabIndex = 10
        Label5.Text = "Selected Games"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(639, 142)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 37)
        Button1.TabIndex = 11
        Button1.Text = ">>"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(639, 211)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 37)
        Button2.TabIndex = 12
        Button2.Text = "<<"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(964, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(LstSelectedGames)
        Controls.Add(LstBoxSelectGames)
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
    Friend WithEvents LstBoxSelectGames As ListBox
    Friend WithEvents LstSelectedGames As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
