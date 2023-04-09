Imports Microsoft.Data.SqlClient

Public Class CodeBank

	Public Function vercheck() As Boolean
		vercheck = False
		Dim connectionString As String = Main.cstring
		Dim query As String = "SELECT Val1 FROM miscdata where header='FEVer'"

		Using connection As New SqlConnection(connectionString)
			Using command As New SqlCommand(query, connection)
				Dim adapter As New SqlDataAdapter(command)
				Dim dataSet As New DataSet()
				adapter.Fill(dataSet, "myTable")

				' Access data using the DataSet
				For Each row As DataRow In dataSet.Tables("myTable").Rows
					Dim ver As String = row.Field(Of String)("Val1")
					If ver = "1.0.1" Then vercheck = True
				Next
			End Using
		End Using
	End Function

	Public Sub ActivityLog(ModuleName As String, Activity As String, Description As String)
		Dim machineName As String = Environment.MachineName
		Dim connectionString As String = Main.cstring
		Dim query As String
		query = "insert into ActivityLog (Module,ActDate,UserID,Activity,Description,MachineName) values('" & ModuleName & "',GETDATE()," & Main.UID & ",'" & Activity & "','" & Description & "','" & machineName & " '); SELECT SCOPE_IDENTITY()"
		Using connection As New SqlConnection(Main.cstring)
			Using command As New SqlCommand(query, connection)
				connection.Open()
				Dim newID As Integer = Convert.ToInt32(command.ExecuteScalar())
				'				MessageBox.Show("New record ID: " & newID)
			End Using
		End Using
	End Sub

End Class
