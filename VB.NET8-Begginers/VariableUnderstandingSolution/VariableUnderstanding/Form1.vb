Public Class Form1


    Private Sub BtnVariable_Click(sender As Object, e As EventArgs) Handles BtnVariable.Click

        Dim FirstName As String
        Dim LastName As String
        FirstName = "Shane"
        LastName = "Van Tran"
        MessageBox.Show("Good morning " & FirstName & " " & LastName & ". How are you?")

        FirstName = "Ronald"
        LastName = "O'Sullivan"
        MessageBox.Show("Good morning " & FirstName & " " & LastName & ". How are you?")

    End Sub
End Class
