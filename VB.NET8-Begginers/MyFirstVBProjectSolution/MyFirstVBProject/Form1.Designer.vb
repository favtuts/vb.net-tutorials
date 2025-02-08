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
        btn_ShowMsg = New Button()
        SuspendLayout()
        ' 
        ' btn_ShowMsg
        ' 
        btn_ShowMsg.BackColor = Color.MediumSlateBlue
        btn_ShowMsg.Location = New Point(298, 187)
        btn_ShowMsg.Name = "btn_ShowMsg"
        btn_ShowMsg.Size = New Size(182, 83)
        btn_ShowMsg.TabIndex = 0
        btn_ShowMsg.Text = "Click Me"
        btn_ShowMsg.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_ShowMsg)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_ShowMsg As Button

End Class
