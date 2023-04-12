Imports Microsoft.Data.SqlClient



Public Class ManageStudentCourse

    Public chkbox As CheckBox = New CheckBox()
    Public couchk As CheckBox = New CheckBox()
    Private Sub Regulationcombo()
        Dim con As SqlConnection = New SqlConnection(Main.cstring)
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("SELECT DISTINCT RegShortName from regulations", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        Regulationcombobox.DataSource = table
        Regulationcombobox.DisplayMember = "RegShortName"
        Regulationcombobox.ValueMember = "RegShortName"
        con.Close()
    End Sub
    Public Sub Departmentcombo()
        Dim con As SqlConnection = New SqlConnection(Main.cstring)
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select DISTINCT ProgramShortName from Program", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        Departmentcombobox.DataSource = table
        Departmentcombobox.DisplayMember = "ProgramShortName"
        Departmentcombobox.ValueMember = "ProgramShortName"
        con.Close()
    End Sub
    Public CourseData As String = "SELECT cou.CourseId as 'Course ID' , cou.CourseCode as 'Course Code',CourseTittle as 'Tittle',RegShortName as 'Regulation',cou.Category as 'Category',cou.Credits as 'Credits',cou.Status FROM Course as cou inner join regulations as regtab on regtab.RegulationId = cou.RegulationId order by CourseId "

    Public StudentData As String = "select sprno as 'SprNo', StudentName as 'Name',reg.RegShortName as 'Regulation',Year,Program As 'Program' from Studentdetails as stu inner join regulations as reg on reg.RegulationId = stu.RegulationId"
    Private Sub ManageStudentCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list(StudentData)
        coulist(CourseData)
        Regulationcombo()
        Departmentcombo()
    End Sub
    Public Sub list(query)
        Dim con As SqlConnection = New SqlConnection(Main.cstring)
        Dim command1 As New SqlCommand(query, con)
        Dim sda1 As New SqlDataAdapter(command1)
        Dim dt1 As New DataTable
        sda1.Fill(dt1)
        Students_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Students_List.DataSource = dt1
        Students_List.AllowUserToAddRows = False
        Students_List.AllowUserToDeleteRows = False
        Students_List.AllowUserToResizeColumns = False
        Students_List.Columns(0).Visible = True
        Students_List.ColumnHeadersVisible = True
        Students_List.ClearSelection()
        Students_List.Columns(1).Width = 80
        Students_List.Columns(2).Width = 150
        Students_List.Columns(3).Width = 85
        Students_List.Columns(4).Width = 70
        Students_List.Columns(5).Width = 90
        Dim h_location As Point = Students_List.GetCellDisplayRectangle(0, -1, True).Location
        chkbox.Location = New Point(h_location.X + 5, h_location.Y + 11)
        chkbox.Size = New Size(15, 15)
        chkbox.BackColor = Color.White
        AddHandler chkbox.Click, AddressOf chkbox_clicked
        Students_List.Controls.Add(chkbox)
        AddHandler Students_List.CellContentClick, AddressOf DataGridView1_Cellclick
    End Sub
    Public Sub coulist(query)
        Dim con As SqlConnection = New SqlConnection(Main.cstring)
        Dim command1 As New SqlCommand(query, con)
        Dim sda1 As New SqlDataAdapter(command1)
        Dim dt1 As New DataTable
        sda1.Fill(dt1)
        CourseGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        CourseGrid.DataSource = dt1
        CourseGrid.AllowUserToAddRows = False
        CourseGrid.AllowUserToDeleteRows = False
        CourseGrid.AllowUserToResizeColumns = False
        CourseGrid.Columns(0).Visible = True
        CourseGrid.ColumnHeadersVisible = True
        CourseGrid.ClearSelection()
        CourseGrid.Columns(1).Width = 80
        CourseGrid.Columns(2).Width = 100
        CourseGrid.Columns(3).Width = 345
        CourseGrid.Columns(4).Width = 70
        CourseGrid.Columns(5).Width = 90
        Dim h_location As Point = CourseGrid.GetCellDisplayRectangle(0, -1, True).Location
        couchk.Location = New Point(h_location.X + 5, h_location.Y + 11)
        couchk.Size = New Size(15, 15)
        couchk.BackColor = Color.White
        AddHandler couchk.Click, AddressOf couchk_clicked
        CourseGrid.Controls.Add(couchk)
        AddHandler CourseGrid.CellContentClick, AddressOf couchkDataGridView1_Cellclick
    End Sub
    Private Sub couchk_clicked(sender As Object, e As EventArgs)
        CourseGrid.EndEdit()
        For Each row As DataGridViewRow In CourseGrid.Rows
            Dim checkkbx As DataGridViewCheckBoxCell = (TryCast(row.Cells("cchk"), DataGridViewCheckBoxCell))
            checkkbx.Value = couchk.Checked
        Next
    End Sub
    Private Sub chkbox_clicked(sender As Object, e As EventArgs)
        Students_List.EndEdit()
        For Each row As DataGridViewRow In Students_List.Rows
            Dim check_bx As DataGridViewCheckBoxCell = (TryCast(row.Cells("chk"), DataGridViewCheckBoxCell))
            check_bx.Value = chkbox.Checked
        Next
    End Sub
    Private Sub couchkDataGridView1_Cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles CourseGrid.CellContentClick
        If e.RowIndex >= 0 Then
            Dim issChecked As Boolean = True
            For Each row As DataGridViewRow In CourseGrid.Rows
                If Convert.ToBoolean(row.Cells("cchk").EditedFormattedValue) = False Then
                    issChecked = False
                    Exit For
                End If

            Next
            couchk.Checked = issChecked
        End If
    End Sub
    Private Sub DataGridView1_Cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles Students_List.CellContentClick
        If e.RowIndex >= 0 Then
            Dim isChecked As Boolean = True
            For Each row As DataGridViewRow In Students_List.Rows
                If Convert.ToBoolean(row.Cells("chk").EditedFormattedValue) = False Then
                    isChecked = False
                    Exit For
                End If

            Next
            chkbox.Checked = isChecked
        End If
    End Sub

    Private Sub CourseGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles CourseGrid.CellFormatting
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then ' Replace 0 with the index of your checkbox column
                Dim row As DataGridViewRow = CourseGrid.Rows(e.RowIndex)
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

    Private Sub Students_List_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Students_List.CellFormatting
        Dim row As DataGridViewRow = Students_List.Rows(e.RowIndex)
        row.DefaultCellStyle.BackColor = Color.LightGreen
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class