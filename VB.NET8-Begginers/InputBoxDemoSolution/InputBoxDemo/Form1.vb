Imports System.Text

Public Class Form1
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Dim StrFirstName As String
        Dim StrLastName As String
        Dim StrEmail As String
        Dim StrSelectedGame As String

        StrFirstName = TxtBoxFirstName.Text
        StrLastName = TxtBoxLastName.Text
        StrEmail = TxtBoxEmailID.Text

        Dim sb As StringBuilder
        sb = New StringBuilder
        For Each item As String In LstSelectedGames.Items
            sb.Append(item)
            sb.Append(",")
        Next
        sb.Remove(sb.Length - 1, 1)
        StrSelectedGame = sb.ToString()

        MessageBox.Show("Hello " & StrFirstName & " " & StrLastName & ", your email id is: " & StrEmail &
                        ", and you would like to play: " & StrSelectedGame
                        )

        'TxtBoxFirstName.Text = ""
        'TxtBoxLastName.Text = ""
        'TxtBoxEmailID.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (Not LstSelectedGames.Items.Contains(LstBoxSelectGames.SelectedItem)) Then
            LstSelectedGames.Items.Add(LstBoxSelectGames.SelectedItem)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LstSelectedGames.Items.Remove(LstSelectedGames.SelectedItem)
    End Sub
End Class
