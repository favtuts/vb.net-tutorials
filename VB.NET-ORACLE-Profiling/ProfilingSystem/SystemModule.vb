Module SystemModule

    Public Function LoadStudentData() As List(Of StudentInfo)
        Dim list = New List(Of StudentInfo)

        Return list
    End Function

    ''' <summary>
    ''' Insert Student Record
    ''' </summary>
    ''' <param name="student"></param>
    ''' <returns></returns>
    Public Function Insert(ByVal student As StudentInfo) As Boolean
        Try
            Return True ' if successfully save in database
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module

Friend Class StudentInfo
    Property Id As Int64
    Property LastName As String
    Property FirstName As String
    Property MiddleName As String
    Property Gender As String
    Property Birthday As DateTime
    Property ContactNum As String
    Property Address As String
    Property Course As String
    Property Year As String
    Property Section As String
    Property SchoolAddress As String
    Property Created As DateTime
End Class


