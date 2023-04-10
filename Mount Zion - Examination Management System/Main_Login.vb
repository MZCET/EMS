Imports Microsoft.Data.SqlClient
Public Class Main_Login
    Dim Main = New Main
    Public Property Result As Integer


    Private Sub Main_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Result = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cb As New CodeBank
        Dim rows As Integer
        Dim connectionString As String = Main.cstring

        Dim query As String = "SELECT * FROM users where username = @Column1Value and password = @Column2Value and status=1"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Column1Value", TextBox1.Text)
                command.Parameters.AddWithValue("@Column2Value", TextBox2.Text)
                Dim adapter As New SqlDataAdapter(command)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "myTable")
                rows = dataSet.Tables("myTable").Rows.Count
                Main.UID = dataSet.Tables("myTable").Rows(0).Field(Of Integer)("UserID")
            End Using
        End Using


        If rows = 0 Then
            MsgBox("You cannot login. Incorrect Password.", vbOKOnly + vbInformation, "Incorrect Login Credentials.")
            cb.ActivityLog("Login", TextBox1.Text, "Failure")
            Me.Close()

        End If

        DialogResult = DialogResult.OK
        If rows = 1 Then

            'Update Login time
            query = "update users set LastLogin=GETDATE() where username = @Column1Value"
            Using connection As New SqlConnection(Main.cstring)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Column1Value", TextBox1.Text)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            Result = 1
            cb.ActivityLog("Login", TextBox1.Text, "Success")
        End If

        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class