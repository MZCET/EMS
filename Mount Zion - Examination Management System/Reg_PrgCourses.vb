Imports Microsoft.Data.SqlClient

Public Class Reg_PrgCourses

    Private Sub Reg_PrgCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AllLoad()
    End Sub

    Private Sub AllLoad()
        loadreg()
        loadprgs()
        loadcourses()
    End Sub
    Private Sub loadreg()

        Try
            Dim query As String = "SELECT RegulationID as 'Regulation ID' ,RegShortName as 'Short Name', RegName as 'Regulation Name', Description as 'Description' , AffiliatedTo as 'Affiliated To' FROM Regulations order by regulationid"

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
            DataGridView1.Columns(2).Width = 250
            DataGridView1.Columns(3).Width = 250
            DataGridView1.Columns(4).Width = DataGridView1.Width - 760
            DataGridView1.CurrentCell = Nothing
            DataGridView1.ClearSelection()
        Catch ex As Exception

        End Try


    End Sub




    Private Sub loadprgs()
        Try
            Dim query As String = "SELECT protab.ProgramId as 'Program ID' , protab.ProgramShortName as 'Short Name',ProgramName as 'Program Name', RegName as 'Regulation Name' , AffiliatedTo as 'Affiliated To' FROM Program as protab inner join regulations as regtab on regtab.RegulationId = protab.RegulationId order by ProgramId"

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
            DataGridView2.Columns(1).Width = 100
            DataGridView2.Columns(2).Width = 250
            DataGridView2.Columns(3).Width = 250
            DataGridView2.Columns(4).Width = DataGridView2.Width - 760
            DataGridView2.CurrentCell = Nothing
            DataGridView2.ClearSelection()
        Catch ex As Exception

        End Try



    End Sub


    Private Sub loadcourses()
        Try
            Dim query As String = "SELECT cou.CourseId as 'Course ID' , cou.CourseCode as 'Course Code',CourseTittle as 'Tittle', RegName as 'Regulation Name' , AffiliatedTo as 'Affiliated To',cou.Category as 'Category',cou.ContactPeriods as 'Periods',cou.LH as 'LH',cou.TH as 'TH',cou.PH as 'PH',cou.Credits as 'Credits',cou.Maxmarks as 'Max Mark',cou.TheoryPassMark as 'Theory Pass Mark',cou.CPassMark as 'C Pass Mark' FROM Course as cou inner join regulations as regtab on regtab.RegulationId = cou.RegulationId order by CourseId"

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
            DataGridView3.Columns(13).Width = 100
            DataGridView3.CurrentCell = Nothing



            DataGridView3.ClearSelection()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(DataGridView1.CurrentCell.ColumnIndex)
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
        loadprgs()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        DataGridView2.ClearSelection()
        DataGridView2.CurrentCell = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(DataGridView2.CurrentCell.ColumnIndex)
        DataGridView2.Rows(DataGridView2.CurrentRow.Index).Selected = True
        loadreg()
    End Sub


    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        DataGridView3.ClearSelection()
        DataGridView3.CurrentCell = DataGridView3.Rows(DataGridView2.CurrentRow.Index).Cells(DataGridView2.CurrentCell.ColumnIndex)
        DataGridView2.Rows(DataGridView2.CurrentRow.Index).Selected = True
        loadreg()
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
                CourseTittle = InputBox("Enter the CourseTittle for the Course - " & CourseCode, " CourseTittle")
                Category = InputBox("Enter the Category  for the Course" & CourseCode, "Category")
                ContactPeriods = InputBox("Enter the ContactPeriods for the Course - " & CourseCode, "ContactPeriods")
                LH = InputBox("Enter the  LH for the Course - " & CourseCode, " LH")
                TH = InputBox("Enter the  TH for the Course - " & CourseCode, " TH")
                PH = InputBox("Enter the PH for the Course - " & CourseCode, "PH")
                Credits = InputBox("Enter the Credits for the Course - " & CourseCode, "Credits")
                Maxmarks = InputBox("Enter the Maxmarks for the Course - " & CourseCode, "Maxmarks")
                TheoryPassMark = InputBox("Enter the TheoryPassMark for the Course - " & CourseCode, "TheoryPassMark")
                CPassMark = InputBox("Enter the Name for the Course - " & CourseCode, "CPassMark")
                Dim a As Integer
                Dim t As String
                t = "Please Confirm the details ..."
                t = t & vbCrLf & vbCrLf & "CourseCode : " & CourseCode
                t = t & vbCrLf & "CourseTittle : " & CourseTittle
                t = t & vbCrLf & " Category : " & Category
                t = t & vbCrLf & " ContactPeriods : " & ContactPeriods
                t = t & vbCrLf & " LH : " & LH
                t = t & vbCrLf & " TH : " & TH
                t = t & vbCrLf & " PH : " & PH
                t = t & vbCrLf & " Credits : " & Credits
                t = t & vbCrLf & " Maxmarks : " & Maxmarks
                t = t & vbCrLf & " TheoryPassMark: " & TheoryPassMark
                t = t & vbCrLf & " CPassMark : " & CPassMark
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
End Class