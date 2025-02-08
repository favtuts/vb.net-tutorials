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

    Private Sub BtnIPhone16Properties_Click(sender As Object, e As EventArgs) Handles BtnIPhone16Properties.Click

        Dim StrBrand As String
        Dim StrModel As String
        Dim IntBattery As Integer
        Dim DoubScreenSize As Double    '15->16 Digits
        Dim DecPrice As Decimal         '28->29 Digits Higher Precision
        Dim BoolAvailability As Boolean

        StrBrand = "Apple"
        StrModel = "iPhone 16"
        IntBattery = 4500
        DoubScreenSize = 6.7
        DecPrice = 799.99
        BoolAvailability = True

        MessageBox.Show(StrBrand & Environment.NewLine & StrModel & Environment.NewLine &
                        IntBattery & Environment.NewLine & DoubScreenSize & Environment.NewLine &
                        DecPrice & Environment.NewLine & BoolAvailability)

    End Sub

End Class
