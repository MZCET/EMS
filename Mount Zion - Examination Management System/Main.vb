'Check Password Expiry
'Check Lockout


Imports System.Diagnostics.Eventing.Reader

Public Class Main
    Dim cb As New CodeBank
    Public cstring As String
    Public UID As Integer
    Public UName As String
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'cstring = "Server=103.207.1.91;Database=EMSDB;User Id=EMS;Password=EMS1234;Encrypt=False;"


        'Check SW Version
        'If cb.vercheck() = False Then
        'MsgBox("This version of software has expired. You need to upgrade to the latest version.", vbOKOnly + vbCritical, "Please upgrade the software.")
        'Me.Close()
        'End If

        'User Login
        'Dim LF As New Main_Login()
        'If LF.ShowDialog() = DialogResult.OK Then
        'If LF.Result = 0 Then
        'Me.Close()
        'End If
        'Else
        'Me.Close()
        'End If


    End Sub

    Private Sub ManageRegulationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageRegulationsToolStripMenuItem.Click
        Reg_Mgmt.ShowDialog()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        TestForm.ShowDialog()

    End Sub

    Private Sub ManageProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageProgramsToolStripMenuItem.Click
        Dim frm = New Reg_PrgCourses
        frm.Show()
        frm.MdiParent = Me

    End Sub

    Private Sub NewProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProfileToolStripMenuItem.Click
        Dim frm = New studentDetails_page1
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub RegulationManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegulationManagementToolStripMenuItem.Click

    End Sub
End Class