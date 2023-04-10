Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class TestForm
    Dim Main = New Main
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

        Dim query As String = "SELECT handwriting FROM student_info where id=5"

        Using connection As New SqlConnection("Server=103.207.1.91;Database=EMSDB;User Id=EMS;Password=EMS1234;Encrypt=False;")
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim fileData() As Byte = DirectCast(command.ExecuteScalar(), Byte())
                If fileData.Length > 0 Then
                    Using stream As New MemoryStream(fileData)
                        Dim img = Image.FromStream(stream)
                        PictureBox1.Image = img
                    End Using
                End If
            End Using

        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF"
        Dim result As DialogResult = openFileDialog1.ShowDialog()
        If result = DialogResult.OK Then

            Dim bytes As Byte() = File.ReadAllBytes(openFileDialog1.FileName)
            Dim query As String = "INSERT INTO my_table (Image) VALUES (@ImageData)"
            Using conn As New SqlConnection("Server=103.207.1.91;Database=EMSDB;User Id=EMS;Password=EMS1234;Encrypt=False;"), cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@ImageData", SqlDbType.VarBinary, -1).Value = bytes
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End If

    End Sub
End Class