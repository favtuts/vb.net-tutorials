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
        BtnVariable = New Button()
        BtnIPhone16Properties = New Button()
        SuspendLayout()
        ' 
        ' BtnVariable
        ' 
        BtnVariable.Location = New Point(276, 93)
        BtnVariable.Name = "BtnVariable"
        BtnVariable.Size = New Size(185, 79)
        BtnVariable.TabIndex = 0
        BtnVariable.Text = "Variable Demo"
        BtnVariable.UseVisualStyleBackColor = True
        ' 
        ' BtnIPhone16Properties
        ' 
        BtnIPhone16Properties.Location = New Point(276, 224)
        BtnIPhone16Properties.Name = "BtnIPhone16Properties"
        BtnIPhone16Properties.Size = New Size(185, 88)
        BtnIPhone16Properties.TabIndex = 1
        BtnIPhone16Properties.Text = "iPhone 16 Properties"
        BtnIPhone16Properties.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnIPhone16Properties)
        Controls.Add(BtnVariable)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnVariable As Button
    Friend WithEvents BtnIPhone16Properties As Button

End Class
