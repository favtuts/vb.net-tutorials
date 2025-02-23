Imports System.Data.Common
Imports System.Data.Odbc
Imports Windows.Win32.System

Module SystemModule
    Property ConnString As String = "DSN=XE21DNS;Uid=USERDB;Pwd=PASSWORD;"
    'Property ConnString As String = "Driver={Oracle in instantclient_23_7};DBQ=XE21;Uid=USERDB;Pwd=PASSWORD;"
    Property StudentId As Int64
    Public Function TestDatabaseConnection() As ReturnResult
        Dim result = New ReturnResult()
        Try
            Using connection As New OdbcConnection(ConnString)
                connection.Open()
                result.Success = True
                result.Code = 1
                result.Message = "Oracle Database Connection successful! "
            End Using
        Catch ex As Exception
            result.Success = False
            result.Code = -1
            result.Message = "Oracle Database Connection Error: " & ex.Message
        End Try

        Return result
    End Function

    Public Function LoadStudentData() As List(Of StudentInfo)
        Dim list = New List(Of StudentInfo)

        Dim query = "SELECT * FROM StudentInfo"

        '1. Initialize the SqlConnection string
        Using con = New OdbcConnection(ConnString)
            '2. Initialize the SqlCommand
            Using cmd = New OdbcCommand(query, con)
                '3. open the connection
                con.Open()
                '4. Execute the data reader
                Using reader = cmd.ExecuteReader()

                    'If reader.Read() Then 'this will read only one column
                    If reader.HasRows Then 'check if there is rows to read
                        While reader.Read()
                            Dim student = New StudentInfo()
                            student.Id = Convert.ToInt32(reader("Id").ToString())
                            student.LastName = reader("LastName").ToString()
                            student.FirstName = reader("FirstName").ToString()
                            student.MiddleName = reader("MiddleName").ToString()
                            student.Gender = reader("Gender").ToString()
                            student.Birthday = Convert.ToDateTime(reader("Birthday").ToString())
                            student.ContactNum = reader("ContactNumber").ToString()
                            student.Address = reader("Address").ToString()
                            student.Course = reader("Course").ToString()
                            student.Year = reader("Year").ToString()
                            student.Section = reader("Section").ToString()
                            student.SchoolAddress = reader("SchoolAddress").ToString()
                            student.Created = Convert.ToDateTime(reader("Created").ToString())
                            'Add the student to list
                            list.Add(student)
                        End While
                    End If
                End Using
            End Using
        End Using

        Return list
    End Function

    ''' <summary>
    ''' Insert Student Record
    ''' </summary>
    ''' <param name="student"></param>
    ''' <returns></returns>
    Public Function Insert(ByVal student As StudentInfo) As Boolean
        Dim query = "INSERT INTO StudentInfo (LastName,FirstName,MiddleName,Gender,Birthday,ContactNumber,Address,Course,Year,Section,SchoolAddress,Created) VALUES (? , ? , ? , ? , ? , ? , ? , ? , ? , ? , ? , ?)"
        Try
            '1. Initialize the SqlConnection string
            Using con As New OdbcConnection(ConnString)
                'Dim command As New OdbcCommand("INSERT INTO employees (employee_id, first_name, last_name) VALUES (:employee_id, :first_name, :last_name)", connection)
                '2. Initialize the SqlCommand

                Using cmd As New OdbcCommand(query, con)
                    '3. Create Command Parameter to avoid sql injection                    
                    cmd.Parameters.Add(New OdbcParameter("@LastName", student.LastName))
                    cmd.Parameters.Add(New OdbcParameter("@FirstName", student.FirstName))
                    cmd.Parameters.Add(New OdbcParameter("@MiddleName", student.MiddleName))
                    cmd.Parameters.Add(New OdbcParameter("@Gender", student.Gender))
                    cmd.Parameters.Add(New OdbcParameter("@Birthday", student.Birthday))
                    cmd.Parameters.Add(New OdbcParameter("@ContactNum", student.ContactNum))
                    cmd.Parameters.Add(New OdbcParameter("@Address", student.Address))
                    cmd.Parameters.Add(New OdbcParameter("@Course", student.Course))
                    cmd.Parameters.Add(New OdbcParameter("@Year", student.Year))
                    cmd.Parameters.Add(New OdbcParameter("@Section", student.Section))
                    cmd.Parameters.Add(New OdbcParameter("@SchoolAddress", student.SchoolAddress))
                    cmd.Parameters.Add(New OdbcParameter("@Created", student.Created))
                    '4. open the connection
                    con.Open()
                    'Execute non query to insert data
                    cmd.ExecuteNonQuery()
                    Return True ' if successfully save in database
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Update Student Record
    ''' </summary>
    ''' <returns></returns>
    Public Function UpdateStudentInfo(ByVal student As StudentInfo) As Boolean
        Dim query = "UPDATE StudentInfo  SET LastName= ? ,FirstName= ? ,MiddleName= ? ,Gender= ? ,Birthday= ? ,ContactNumber= ? ,Address= ? ,Course= ? ,Year= ? ,Section= ? ,SchoolAddress= ? ,Created= ? WHERE Id= ? "
        Try

            '1. Initialize the SqlConnection string
            Using con = New OdbcConnection(ConnString)
                '2. Initialize the SqlCommand
                Using cmd = New OdbcCommand(query, con)
                    '3. Create Command Parameter to avoid sql injection
                    cmd.Parameters.Add(New OdbcParameter("@LastName", student.LastName))
                    cmd.Parameters.Add(New OdbcParameter("@FirstName", student.FirstName))
                    cmd.Parameters.Add(New OdbcParameter("@MiddleName", student.MiddleName))
                    cmd.Parameters.Add(New OdbcParameter("@Gender", student.Gender))
                    cmd.Parameters.Add(New OdbcParameter("@Birthday", student.Birthday))
                    cmd.Parameters.Add(New OdbcParameter("@ContactNum", student.ContactNum))
                    cmd.Parameters.Add(New OdbcParameter("@Address", student.Address))
                    cmd.Parameters.Add(New OdbcParameter("@Course", student.Course))
                    cmd.Parameters.Add(New OdbcParameter("@Year", student.Year))
                    cmd.Parameters.Add(New OdbcParameter("@Section", student.Section))
                    cmd.Parameters.Add(New OdbcParameter("@SchoolAddress", student.SchoolAddress))
                    cmd.Parameters.Add(New OdbcParameter("@Created", student.Created))
                    cmd.Parameters.Add(New OdbcParameter("@Id", student.Id))
                    '4. open the connection
                    con.Open()
                    'Execute non query to insert data
                    cmd.ExecuteNonQuery()
                    Return True ' if successfully save in database
                End Using
            End Using

        Catch ex As Exception
            Throw
        End Try

    End Function


    ''' <summary>
    ''' Delete Student Record
    ''' </summary>
    ''' <param name="student"></param>
    ''' <returns></returns>
    Public Function DeleteStudentInfo(ByVal student As StudentInfo) As Boolean
        Dim query = "DELETE FROM StudentInfo WHERE Id= ? "
        Try

            '1. Initialize the SqlConnection string
            Using con = New OdbcConnection(ConnString)
                '2. Initialize the SqlCommand
                Using cmd = New OdbcCommand(query, con)
                    '3. Create Command Parameter to avoid sql injection
                    cmd.Parameters.Add(New OdbcParameter("@Id", student.Id))
                    '4. open the connection
                    con.Open()
                    'Execute non query to insert data
                    cmd.ExecuteNonQuery()
                    Return True ' if successfully save in database
                End Using
            End Using

        Catch ex As Exception
            Throw
        End Try

        Return False
    End Function

End Module

Friend Class ReturnResult
    Property Success As Boolean
    Property Code As Int32
    Property Message As String
End Class

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


