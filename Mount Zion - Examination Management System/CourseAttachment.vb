Imports System.IO
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class CourseAttachment
    Private Sub CourseAttachment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CourseGridDataGet(ManageStudentCourse.CourseData)
        Regulationcombo()
    End Sub
    Private Sub Regulationcombo()
        Dim con As SqlConnection = New SqlConnection(Main.cstring)
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT RegShortName from regulations", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        Regcombobox.DataSource = table
        Regcombobox.DisplayMember = "RegShortName"
        Regcombobox.ValueMember = "RegShortName"
        con.Close()
    End Sub
    Public Sub CourseGridDataGet(query)
        Dim con As SqlConnection = New SqlConnection(Main.cstring)
        Dim command1 As New SqlCommand(query, con)
        Dim sda1 As New SqlDataAdapter(command1)
        Dim dt1 As New DataTable
        sda1.Fill(dt1)
        CourseDetailGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        CourseDetailGrid.DataSource = dt1
        CourseDetailGrid.AllowUserToAddRows = False
        CourseDetailGrid.AllowUserToDeleteRows = False
        CourseDetailGrid.AllowUserToResizeColumns = False
        CourseDetailGrid.ColumnHeadersVisible = True
        CourseDetailGrid.ClearSelection()
        CourseDetailGrid.Columns(0).Width = 73
        CourseDetailGrid.Columns(1).Width = 83
        CourseDetailGrid.Columns(2).Width = 345
        CourseDetailGrid.Columns(3).Width = 100
        CourseDetailGrid.Columns(4).Width = 70
        'CourseDetailGrid.Columns(5).Width = 90
    End Sub
    Private Sub CourseDetailGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CourseDetailGrid.CellClick
        CourseDetailGrid.MultiSelect = False
        If e.RowIndex >= 0 Then
            ' Select the entire row
            CourseDetailGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            CourseDetailGrid.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub CourseDetailGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles CourseDetailGrid.CellFormatting
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then ' Replace 0 with the index of your checkbox column
                Dim row As DataGridViewRow = CourseDetailGrid.Rows(e.RowIndex)
                Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("Status").Value)
                If isChecked Then
                    'row.DefaultCellStyle.ForeColor = Color.White
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    'row.DefaultCellStyle.ForeColor = Color.White
                    row.DefaultCellStyle.BackColor = Color.LightPink

                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub UploadFile()
        Try
    Dim openFileDialog As New OpenFileDialog()
    openFileDialog.Multiselect = False
    openFileDialog.Filter = "All files (*.*)|*.*"
    openFileDialog.Title = "Select file to upload"

    If openFileDialog.ShowDialog() = DialogResult.OK Then
        Dim fileData() As Byte = File.ReadAllBytes(openFileDialog.FileName)

        If fileData IsNot Nothing AndAlso fileData.Length > 0 Then
            Using connection As New SqlConnection(Main.cstring)
                connection.Open()

                        Dim query As String = "INSERT INTO LargeFiles (FileName, FileExtension, FileData, CreatedDate, CreatedBy) VALUES (@FileName, @FileExtension, @FileData, GETDATE(), @CreatedBy)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FileName", Path.GetFileNameWithoutExtension(openFileDialog.FileName))
                    command.Parameters.AddWithValue("@FileExtension", Path.GetExtension(openFileDialog.FileName))
                    command.Parameters.AddWithValue("@FileData", fileData)
                    command.Parameters.AddWithValue("@CreatedBy", Main.UID)
                            command.ExecuteNonQuery()
                            Dim newID As Integer = Convert.ToInt32(command.ExecuteScalar())
                            Dim CB As New CodeBank
                            CB.ActivityLog("FileUpload", "New - " & newID, "New File Created")
                        End Using
            End Using
            
            MessageBox.Show("Upload complete!")
        Else
            MessageBox.Show("Please select a file to upload.")
        End If
    End If
Catch ex As Exception
    MsgBox(ex.ToString)
End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UploadFile()

    End Sub
End Class