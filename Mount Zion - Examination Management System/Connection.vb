Imports System.Data.SqlClient



Module Connection

    Public dtCustomers As New DataTable
    Public RegulationData As New List(Of String)
    Public ProgramData As New List(Of String)
    Public CourseData As New List(Of String)
    Public CategoryValue As String

    Public Function ReadFromDatabase(ByVal SQL As String) As DataTable
        Dim dtReturn As New DataTable
        Try
            'Open the connection using the connection string
            Using conn As New Microsoft.Data.SqlClient.SqlConnection(Main.cstring)
                conn.Open()

                Using cmd As New Microsoft.Data.SqlClient.SqlCommand()
                    cmd.Connection = conn
                    cmd.CommandText = SQL
                    Dim da As New Microsoft.Data.SqlClient.SqlDataAdapter(cmd)
                    da.Fill(dtReturn)

                End Using


            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try


        'Return the result data set
        Return dtReturn
    End Function













End Module
