Imports System.IO
Imports Microsoft.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class TestForm





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "INSERT INTO users (UserName, Password,FullName,Status,CreatedBy,CreateDate,PasswordExpiry,DoesPasswordExpire) VALUES (@UserName, @Password,@FullName,0,@CreatedBy,GETDATE(),GETDATE()-1,1)"

        Using connection As New SqlConnection(Main.cstring)
            Using command As New SqlCommand(query, connection)
                ' Set parameter values
                command.Parameters.AddWithValue("@UserName", 123)
                command.Parameters.AddWithValue("@Password", 123)
                command.Parameters.AddWithValue("@FullName", 123)
                command.Parameters.AddWithValue("@CreatedBy", 123)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As New CodeBank
        c.ActivityLog(1, 2, 3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim machineName As String = Environment.MachineName
        MessageBox.Show("Machine name: " & machineName)
    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim query As String = "INSERT INTO LargeFiles (FileName, FileExtension, FileData, CreateDate, CreatedBy) VALUES (@FileName, @FileExtension, @FileData,GETDATE(), @CreatedBy)"

        ' Read the file into a byte array
        Dim fileData() As Byte = File.ReadAllBytes("C:\audio.log")

        Using connection As New SqlConnection(Main.cstring)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@FileName", "audio")
                command.Parameters.AddWithValue("@FileExtension", "txt")
                command.Parameters.AddWithValue("@FileData", fileData)
                command.Parameters.AddWithValue("@CreatedBy", Main.UID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim query As String = "SELECT FileData FROM LargeFiles WHERE FileID=1"

        Using connection As New SqlConnection(Main.cstring)
            Using command As New SqlCommand(query, connection)
                connection.Open()

                Dim fileData() As Byte = DirectCast(command.ExecuteScalar(), Byte())
                File.WriteAllBytes("C:\temp\file.ext", fileData)
            End Using
        End Using
    End Sub

    Private Sub gh_Click(sender As Object, e As EventArgs) Handles gh.Click
        Dim queryString As String = "SELECT photo from student_info where id=2"

        Using connection As New SqlConnection(Main.cstring)
            Dim command As New SqlCommand(queryString, connection)
            connection.Open()
            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim byteData As Byte() = DirectCast(reader("photo"), Byte())
                        Dim imageStream As New MemoryStream(byteData)
                        Dim img As Image = Image.FromStream(imageStream)
                        Try
                            img.Save("D:\image.jpg", Imaging.ImageFormat.Jpeg)
                        Catch ex As Exception
                            MessageBox.Show("Error saving image: " & ex.Message)
                        End Try
                    End While
                Else
                    Console.WriteLine("No rows found.")
                End If
            End Using
        End Using
    End Sub


End Class