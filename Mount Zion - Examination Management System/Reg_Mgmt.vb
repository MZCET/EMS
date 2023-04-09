Imports System.Resources
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient
Imports Microsoft.IdentityModel.JsonWebTokens

Public Class Reg_Mgmt
	Private Sub Reg_Mgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		loadvals()
	End Sub
	Private Sub loadvals()
		ListView1.Clear()
		ListView1.View = View.Details
		ListView1.GridLines = True
		ListView1.FullRowSelect = True

		'Add column header
		ListView1.Columns.Add("Regulation ID", 100)
		ListView1.Columns.Add("Regulation Short Name", 70)
		ListView1.Columns.Add("Regulation Name", 70)
		ListView1.Columns.Add("Affiliated To", 70)
		ListView1.Columns.Add("Description", 70)
		ListView1.Columns.Add("Status", 70)


		Dim connectionString As String = Main.cstring
		Dim query As String = "SELECT * FROM regulations order by regulationID"

		Using connection As New SqlConnection(connectionString)
			Using command As New SqlCommand(query, connection)
				Dim adapter As New SqlDataAdapter(command)
				Dim dataSet As New DataSet()
				adapter.Fill(dataSet, "myTable")

				' Access data using the DataSet
				For Each row As DataRow In dataSet.Tables("myTable").Rows

					Dim column1Value As String = row.Field(Of Integer)("RegulationID")
					Dim column2Value As String = row.Field(Of String)("RegShortName")
					Dim column3Value As String = row.Field(Of String)("RegName")
					Dim column4Value As String = row.Field(Of String)("Description")
					Dim column5Value As String = row.Field(Of String)("AffiliatedTo")
					Dim column6Value As String = row.Field(Of Boolean)("Status")

					Dim item As New ListViewItem(column1Value)
					item.SubItems.Add(column2Value)
					item.SubItems.Add(column3Value)
					item.SubItems.Add(column5Value)
					item.SubItems.Add(column4Value)
					item.SubItems.Add(column6Value)
					If column6Value = "False" Then item.BackColor = Color.Pink Else item.BackColor = Color.LightGreen

					ListView1.Items.Add(item)

				Next
			End Using
		End Using
rrr:
		ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

	End Sub
	Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick


		Dim rowIndex As Integer = ListView1.SelectedItems(0).Index
		rowIndex = ListView1.Items(rowIndex).SubItems(0).Text
		Dim r As New Reg_Details(rowIndex)
		r.Show()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Dim RegShortName, RegName, Description, AffiliatedTo As String
		'		Dim RegShortName, RegName, Description, Status, CreateDate, CreatedBy, AffiliatedTo As String
		RegShortName = InputBox("Enter the Short Name for the Regulation", "Short Name")
		RegName = InputBox("Enter the Name for the Regulation - " & RegShortName, "Regulation Name")
		Description = InputBox("Enter the Description for the Regulation - " & RegName & "(" & RegShortName & ")", "Regulation Description")
		AffiliatedTo = InputBox("To which University is this Regulation affiliated to - " & RegName & "(" & RegShortName & ")?", "Affiliated To ....")

		Dim a As Integer
		Dim t As String
		t = "Please Confirm the details ..."
		t = t & vbCrLf & vbCrLf & "Regulation Short Name : " & RegShortName
		t = t & vbCrLf & "Regulation Name : " & RegName
		t = t & vbCrLf & "Description : " & Description
		t = t & vbCrLf & "Affiliated To : " & AffiliatedTo

		a = MsgBox(t, vbOKCancel, "Please Confirm ...")
		If a = vbOK Then
			Dim query As String = "INSERT INTO Regulations (RegShortName, RegName, Description, Status, CreateDate, CreatedBy, AffiliatedTo) VALUES (@F1, @F2,@F3,1,GETDATE(),@F4,@F5); SELECT SCOPE_IDENTITY()"

			Using connection As New SqlConnection(Main.cstring)
				Using command As New SqlCommand(query, connection)
					' Set parameter values
					command.Parameters.AddWithValue("@F1", RegShortName)
					command.Parameters.AddWithValue("@F2", RegName)
					command.Parameters.AddWithValue("@F3", Description)
					command.Parameters.AddWithValue("@F4", Main.UID)
					command.Parameters.AddWithValue("@F5", AffiliatedTo)
					connection.Open()
					Dim newID As Integer = Convert.ToInt32(command.ExecuteScalar())

					Dim CB As New CodeBank
					CB.ActivityLog("Regulations", "New - " & newID, "New Regulation Created")
				End Using
			End Using
		End If
		loadvals()

	End Sub

	Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Dim a, b As String
		a = InputBox("Enter the Regulation ID ...", "Regulation ID ???")

		Dim connectionString As String = Main.cstring
		Dim query As String = "SELECT * FROM regulations where regulationID=" & Val(a)

		Using connection As New SqlConnection(connectionString)
			Using command As New SqlCommand(query, connection)
				Dim adapter As New SqlDataAdapter(command)
				Dim dataSet As New DataSet()
				adapter.Fill(dataSet, "myTable")
				If dataSet.Tables("myTable").Rows.Count = 0 Then
					MsgBox("Incorrect Regulation ID", vbOKOnly, "Error")
					GoTo qq
				End If
				For Each row As DataRow In dataSet.Tables("myTable").Rows
					Dim column1Value As String = row.Field(Of Boolean)("Status")
					If column1Value = "True" Then
						b = MsgBox("Regulation : " & a & " is currently Active. Do you want to Deactivate it?", vbYesNo)
						If b = vbNo Then GoTo qq

						query = "update regulations set Status=0 where regulationID = " & a
						Dim command1 As New SqlCommand(query, connection)
						connection.Open()
						command1.ExecuteNonQuery()

					End If

					If column1Value = "False" Then
						b = MsgBox("Regulation : " & a & " is currently Inactive. Do you want to Activate it?", vbYesNo)
						If b = vbNo Then GoTo qq
						query = "update regulations set Status=1 where regulationID = " & a
						Dim command1 As New SqlCommand(query, connection)
						connection.Open()
						command1.ExecuteNonQuery()
					End If


				Next

			End Using

		End Using
qq:
		loadvals()

	End Sub
End Class