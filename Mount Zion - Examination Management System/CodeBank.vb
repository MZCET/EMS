Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Data.SqlClient

Public Class CodeBank

	Public Function vercheck() As Boolean
		Try
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
		Catch ex As Exception
			MsgBox("Make Sure Your Internet Or Update Your Software")
		End Try
		Return vercheck
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



	Public Function pick_file()
		Dim openFileDialog1 As New OpenFileDialog()
		openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF"
		If openFileDialog1.ShowDialog() = DialogResult.OK Then
			Dim fileInfo As New FileInfo(openFileDialog1.FileName)
			Dim fileSizeKB As Long = fileInfo.Length / 1024
			If fileSizeKB > 500 Then
				MessageBox.Show("File size limit exceeded (500KB). Please select a smaller file.")
			Else
				Dim fileName As String = openFileDialog1.FileName
				Return fileName
			End If
		End If
	End Function

	Public Function Add_list(query, combobox_name, column_name)
		Dim connectionString As String = Main.cstring
		Dim con As New SqlConnection(connectionString)
		con.Open()
		Dim command As New SqlCommand(query, con)
		Dim reader As SqlDataReader = command.ExecuteReader()
		While reader.Read()
			combobox_name.Items.Add(reader(column_name).ToString())
		End While
		reader.Close()
		con.Close()
	End Function

	Public Function IsValidEmail(ByVal email As String) As Boolean
		Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
		Dim regex As New Regex(pattern)
		Return regex.IsMatch(email)
	End Function
End Class


