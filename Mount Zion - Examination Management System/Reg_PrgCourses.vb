Imports Microsoft.Data.SqlClient

Public Class Reg_PrgCourses

    Private Sub Reg_PrgCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AllLoad()
        DataGridView1.CurrentCell = Nothing
        DataGridView2.CurrentCell = Nothing
        DataGridView3.CurrentCell = Nothing
        DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect
    End Sub

    Private Sub AllLoad()
        Try
            loadreg()
            loadprgs()
            loadcourses()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        Try


            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then ' Replace 0 with the index of your checkbox column
                Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
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

    Private Sub loadreg()

        Try
            Dim query As String = "SELECT RegulationID as 'Regulation ID' ,RegShortName as 'Short Name', RegName as 'Regulation Name', Description as 'Description' , AffiliatedTo as 'Affiliated To' ,Status as 'Status'FROM Regulations order by regulationid"

            Using connection As New SqlConnection(Main.cstring)
                Using command As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
            DataGridView1.Columns(0).Width = 120
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 200
            DataGridView1.Columns(4).Width = 300
            DataGridView1.Columns(5).Width = DataGridView1.Width - 875
            DataGridView1.CurrentCell = Nothing
            DataGridView1.ClearSelection()
        Catch ex As Exception

        End Try


    End Sub




    Private Sub loadprgs()
        Try
            Dim query As String = "SELECT protab.ProgramId as 'Program ID' , protab.ProgramShortName as 'Short Name',ProgramName as 'Program Name', RegShortName,protab.Status  FROM Program as protab inner join regulations as regtab on regtab.RegulationId = protab.RegulationId order by ProgramId"

            Using connection As New SqlConnection(Main.cstring)
                Using command As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    DataGridView2.DataSource = dataTable
                End Using
            End Using


            DataGridView2.Columns(0).Width = 120
            DataGridView2.Columns(1).Width = 150
            DataGridView2.Columns(2).Width = 300
            DataGridView2.Columns(3).Width = 150
            DataGridView2.Columns(4).Width = DataGridView2.Width - 790
            DataGridView2.CurrentCell = Nothing

            DataGridView2.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try



    End Sub


    Private Sub loadcourses()
        Try
            Dim query As String = "SELECT cou.CourseId as 'Course ID' , cou.CourseCode as 'Course Code',CourseTittle as 'Tittle',RegShortName,cou.Category as 'Category',cou.ContactPeriods as 'Periods',cou.LH as 'LecturerHour',cou.TH as 'TutorialHour',cou.PH as 'PraticalHour',cou.Credits as 'Credits',cou.Maxmarks as 'Max Mark',cou.TheoryPassMark as 'External Pass Mark',cou.CPassMark as 'Internal Pass Mark',cou.Status FROM Course as cou inner join regulations as regtab on regtab.RegulationId = cou.RegulationId order by CourseId"

            Using connection As New SqlConnection(Main.cstring)
                Using command As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    ' Bind the DataTable to the DataGridView
                    DataGridView3.DataSource = dataTable
                End Using
            End Using
            DataGridView3.Columns(0).Width = 100
            DataGridView3.Columns(1).Width = 100
            DataGridView3.Columns(2).Width = 250
            DataGridView3.Columns(3).Width = 120
            DataGridView3.Columns(4).Width = 200
            DataGridView3.Columns(5).Width = 100
            DataGridView3.Columns(6).Width = 100
            DataGridView3.Columns(7).Width = 100
            DataGridView3.Columns(8).Width = 100
            DataGridView3.Columns(9).Width = 100
            DataGridView3.Columns(10).Width = 100
            DataGridView3.Columns(11).Width = 100
            DataGridView3.Columns(12).Width = 100
            DataGridView3.CurrentCell = Nothing
            DataGridView3.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DataGridView1.MultiSelect = False

        If e.RowIndex >= 0 Then
            ' Select the entire row
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.Rows(e.RowIndex).Selected = True
        End If
        loadprgs()
        loadcourses()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim firstCellValue As Object = selectedRow.Cells(0).Value
                Dim ProgramName, ProgramShortName As String
                ProgramShortName = InputBox("Enter the Short Name for the Program", "Short Name")
                ProgramName = InputBox("Enter the Name for the Program - " & ProgramShortName, "Program Name")
                Dim a As Integer
                Dim t As String
                t = "Please Confirm the details ..."
                t = t & vbCrLf & vbCrLf & "Program Short Name : " & ProgramShortName
                t = t & vbCrLf & "Program Name : " & ProgramName
                a = MsgBox(t, vbOKCancel, "Please Confirm ...")
                If a = vbOK And ProgramName.Length <> 0 And ProgramName.Length <> 0 Then
                    Dim query As String = "INSERT INTO Program (ProgramShortName, ProgramName, RegulationId, CreatedBy, CreatedDate, Status ) VALUES (@F1, @F2,@F3,@F4,GETDATE(),1); SELECT SCOPE_IDENTITY()"

                    Using connection As New SqlConnection(Main.cstring)
                        Using command As New SqlCommand(query, connection)
                            ' Set parameter values
                            command.Parameters.AddWithValue("@F1", ProgramShortName)
                            command.Parameters.AddWithValue("@F2", ProgramName)
                            command.Parameters.AddWithValue("@F3", firstCellValue)
                            command.Parameters.AddWithValue("@F4", Main.UID)
                            connection.Open()
                            Dim newID As Integer = Convert.ToInt32(command.ExecuteScalar())
                            Dim CB As New CodeBank
                            CB.ActivityLog("Program", "New - " & newID, "New Program Created")
                        End Using
                    End Using
                    AllLoad()
                Else
                    MsgBox("Please Enter The Data!!")
                End If
            Else
                MsgBox("Please Select The Regulation!")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim firstCellValue As Object = selectedRow.Cells(0).Value
                Dim CourseCode, CourseTittle, Category, ContactPeriods, TH, LH, PH, Credits, Maxmarks, TheoryPassMark, CPassMark As String

                CourseCode = InputBox("Enter the CourseCode for the Course", "CourseCode")
                CourseTittle = InputBox("Enter the CourseName for the Course - " & CourseCode, " CourseName")
                CategoryDialog.ShowDialog()
                Category = CategoryValue
                Do Until IsNumeric(ContactPeriods)
                    ContactPeriods = InputBox("Enter the ContactPeriods for the Course - " & CourseCode, "ContactPeriods")
                    If Not IsNumeric(ContactPeriods) Then
                        MsgBox("Please enter a valid number for ContactPeriods", vbOKOnly, "Invalid input")
                    End If

                Loop
                Do Until IsNumeric(LH)
                    LH = InputBox("Enter the  LecturerHour for the Course - " & CourseCode, "LecturerHou")
                    If Not IsNumeric(LH) Then
                        MsgBox("Please enter a valid number for LecturerHour", vbOKOnly, "Invalid input")
                    End If
                Loop
                Do Until IsNumeric(TH)
                    TH = InputBox("Enter the  TutorialHour for the Course - " & CourseCode, "TutorialHour")
                    If Not IsNumeric(TH) Then
                        MsgBox("Please enter a valid number for TutorialHour", vbOKOnly, "Invalid input")
                    End If
                Loop

                Do Until IsNumeric(PH)
                    PH = InputBox("Enter the PraticalHour for the Course - " & CourseCode, "PraticalHour")
                    If Not IsNumeric(PH) Then
                        MsgBox("Please enter a valid number for PraticalHour", vbOKOnly, "Invalid input")
                    End If
                Loop

                Do Until IsNumeric(Credits)
                    Credits = InputBox("Enter the Credits for the Course - " & CourseCode, "Credits")
                    If Not IsNumeric(Credits) Then
                        MsgBox("Please enter a valid number for Credits", vbOKOnly, "Invalid input")
                    End If
                Loop

                Do Until Not IsNothing(Maxmarks) AndAlso IsNumeric(Maxmarks)
                    Maxmarks = InputBox("Enter the Maxmarks for the Course - " & CourseCode, "Maxmarks")
                    If Not IsNumeric(Maxmarks) Then
                        MsgBox("Please enter a valid number for Maxmarks", vbOKOnly, "Invalid input")
                    End If
                Loop
                Do Until IsNumeric(TheoryPassMark)
                    TheoryPassMark = InputBox("Enter the ExternalPassMark for the Course - " & CourseCode, "ExternalPassMark")
                    If Not IsNumeric(TheoryPassMark) Then
                        MsgBox("Please enter a valid number for ExternalPassMark", vbOKOnly, "Invalid input")

                    End If
                Loop
                Do Until IsNumeric(CPassMark)
                    CPassMark = InputBox("Enter the InternalPassMark for the Course - " & CourseCode, "InternalPassMark")
                    If Not IsNumeric(CPassMark) Then
                        MsgBox("Please enter a valid number for InternalPassMark", vbOKOnly, "Invalid input")

                    End If
                Loop

                Dim a As Integer
                Dim t As String
                t = "Please Confirm the details ..."
                t = t & vbCrLf & vbCrLf & "CourseCode : " & CourseCode
                t = t & vbCrLf & "CourseTittle : " & CourseTittle
                t = t & vbCrLf & "Category : " & Category
                t = t & vbCrLf & "ContactPeriods : " & ContactPeriods
                t = t & vbCrLf & "LecturerHour: " & LH
                t = t & vbCrLf & "TutorialHour : " & TH
                t = t & vbCrLf & "PraticalHour : " & PH
                t = t & vbCrLf & "Credits : " & Credits
                t = t & vbCrLf & "Maxmarks : " & Maxmarks
                t = t & vbCrLf & "ExternalPassMark: " & TheoryPassMark
                t = t & vbCrLf & "InternalPassMark : " & CPassMark
                a = MsgBox(t, vbOKCancel, "Please Confirm ...")
                If a = vbOK And CourseCode.Length <> 0 And CourseTittle.Length <> 0 And Category.Length <> 0 And ContactPeriods <> "" And LH <> "" And TH <> "" And PH <> "" And Credits <> "" And Maxmarks <> "" And TheoryPassMark <> "" And CPassMark <> "" Then
                    Dim query As String = "INSERT INTO Course (RegulationId,CourseCode,CourseTittle,Category,ContactPeriods,LH,TH,PH,Credits, CreatedBy, CreatedDate,Maxmarks,TheoryPassMark,CPassMark,Status ) VALUES (@F1, @F2,@F3,@F4,@F13,@F5,@F6,@F7,@F8,@F9,GETDATE(),@F10,@F11,@F12,1); SELECT SCOPE_IDENTITY()"

                    Using connection As New SqlConnection(Main.cstring)
                        Using command As New SqlCommand(query, connection)
                            ' Set parameter values
                            command.Parameters.AddWithValue("@F1", firstCellValue)
                            command.Parameters.AddWithValue("@F2", CourseCode)
                            command.Parameters.AddWithValue("@F3", CourseTittle)
                            command.Parameters.AddWithValue("@F4", Category)
                            command.Parameters.AddWithValue("@F13", Integer.Parse(ContactPeriods))
                            command.Parameters.AddWithValue("@F5", Integer.Parse(LH))
                            command.Parameters.AddWithValue("@F6", Integer.Parse(TH))
                            command.Parameters.AddWithValue("@F7", Integer.Parse(PH))
                            command.Parameters.AddWithValue("@F8", Integer.Parse(Credits))
                            command.Parameters.AddWithValue("@F9", Main.UID)
                            command.Parameters.AddWithValue("@F10", Integer.Parse(Maxmarks))
                            command.Parameters.AddWithValue("@F11", Integer.Parse(TheoryPassMark))
                            command.Parameters.AddWithValue("@F12", Integer.Parse(CPassMark))
                            connection.Open()
                            Dim newID As Integer = Convert.ToInt32(command.ExecuteScalar())
                            Dim CB As New CodeBank
                            CB.ActivityLog("Course", "New - " & newID, "New Course Created")
                        End Using
                    End Using
                    CategoryValue = ""
                    AllLoad()
                Else
                    MsgBox("Please Enter The Data!!")
                    CategoryValue = ""

                End If
            Else
                MsgBox("Please Select The Regulation!")
                CategoryValue = ""

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            CategoryValue = ""
        End Try
    End Sub



    Private Sub DataGridView3_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView3.CellFormatting
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then ' Replace 0 with the index of your checkbox column
                Dim row As DataGridViewRow = DataGridView3.Rows(e.RowIndex)
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

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then ' Replace 0 with the index of your checkbox column
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim ProgramId As String
            Do Until IsNumeric(ProgramId)
                ProgramId = InputBox("Enter the ProgramId for the Program - " & ProgramId, "ProgramId")
                If Not IsNumeric(ProgramId) Then
                    MsgBox("Please enter a valid number for ProgramId", vbOKOnly, "Invalid input")

                End If
            Loop
            If ProgramId.Length <> 0 Then
                Dim con As SqlConnection = New SqlConnection(Main.cstring)
                con.Open()
                Dim cmd3 As SqlCommand = New SqlCommand("select Status from Program where ProgramId= '" + ProgramId + "'", con)
                Dim myread3 As SqlDataReader
                myread3 = cmd3.ExecuteReader
                myread3.Read()
                Dim Status As String = myread3("Status")
                If Status = "True" Then
                    Dim a As Integer
                    Dim t As String
                    t = "Do you Want to Deactivate the Program??"
                    t = t & vbCrLf & vbCrLf & "ProgramId : " & ProgramId
                    a = MsgBox(t, vbOKCancel, "Please Confirm ...")
                    If a = vbOK Then
                        ReadFromDatabase("update Program SET Status= 0 where ProgramId='" + ProgramId + "' ")
                    End If
                    AllLoad()

                End If
                If Status = "False" Then
                    Dim a As Integer
                    Dim t As String
                    t = "Do you Want to Activate the Program??"
                    t = t & vbCrLf & vbCrLf & "ProgramId : " & ProgramId
                    a = MsgBox(t, vbOKCancel, "Please Confirm ...")
                    If a = vbOK Then
                        ReadFromDatabase("update Program SET Status= 1 where ProgramId='" + ProgramId + "' ")
                    End If
                    AllLoad()

                End If
            End If
        Catch ex As Exception
            MsgBox("data No Present")
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim CourseId As String
            Do Until IsNumeric(CourseId)
                CourseId = InputBox("Enter the CourseId for the Course - " & CourseId, "CourseId")
                If Not IsNumeric(CourseId) Then
                    MsgBox("Please enter a valid number for CourseId", vbOKOnly, "Invalid input")

                End If
            Loop
            If CourseId.Length <> 0 Then
                Dim con As SqlConnection = New SqlConnection(Main.cstring)
                con.Open()
                Dim cmd3 As SqlCommand = New SqlCommand("select Status from Course where CourseId= '" + CourseId + "'", con)
                Dim myread3 As SqlDataReader
                myread3 = cmd3.ExecuteReader
                myread3.Read()
                Dim Status As String = myread3("Status")
                If Status = "True" Then
                    Dim a As Integer
                    Dim t As String
                    t = "Do you Want to Deactivate the Course??"
                    t = t & vbCrLf & vbCrLf & "ProgramId : " & CourseId
                    a = MsgBox(t, vbOKCancel, "Please Confirm ...")
                    If a = vbOK Then
                        ReadFromDatabase("update Course SET Status = 0 where CourseId='" + CourseId + "' ")
                    End If
                    AllLoad()

                End If
                If Status = "False" Then
                    Dim a As Integer
                    Dim t As String
                    t = "Do you Want to Activate the Course??"
                    t = t & vbCrLf & vbCrLf & "CourseId : " & CourseId
                    a = MsgBox(t, vbOKCancel, "Please Confirm ...")
                    If a = vbOK Then
                        ReadFromDatabase("update Course SET Status = 1 where CourseId='" + CourseId + "' ")
                    End If
                    AllLoad()
                End If
            End If
        Catch ex As Exception
            MsgBox("data No Present")
        End Try

    End Sub



End Class