Public Class Form1
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Dim StrFirstName As String
        Dim StrLastName As String
        Dim StrEmail As String

        StrFirstName = TxtBoxFirstName.Text
        StrLastName = TxtBoxLastName.Text
        StrEmail = TxtBoxEmailID.Text

        MessageBox.Show("Hello " & StrFirstName & " " & StrLastName & ", your email id is: " & StrEmail)


    End Sub
End Class
