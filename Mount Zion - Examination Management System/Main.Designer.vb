<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        ProgramToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        PdfToolStripMenuItem = New ToolStripMenuItem()
        RegulationManagementToolStripMenuItem = New ToolStripMenuItem()
        ManageRegulationsToolStripMenuItem = New ToolStripMenuItem()
        ManageProgramsToolStripMenuItem = New ToolStripMenuItem()
        ManageCourseFileToolStripMenuItem = New ToolStripMenuItem()
        StudentManagementToolStripMenuItem = New ToolStripMenuItem()
        ManageCoursesToolStripMenuItem = New ToolStripMenuItem()
        AddStudentToolStripMenuItem = New ToolStripMenuItem()
        QuestionPaperManagementToolStripMenuItem = New ToolStripMenuItem()
        ResultsManagementToolStripMenuItem = New ToolStripMenuItem()
        TestToolStripMenuItem = New ToolStripMenuItem()
        ViewStudentsToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ProgramToolStripMenuItem, RegulationManagementToolStripMenuItem, StudentManagementToolStripMenuItem, QuestionPaperManagementToolStripMenuItem, ResultsManagementToolStripMenuItem, TestToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 4, 0, 4)
        MenuStrip1.Size = New Size(1750, 37)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"' 
        ' ProgramToolStripMenuItem
        ' 
        ProgramToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem, PdfToolStripMenuItem})
        ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        ProgramToolStripMenuItem.Size = New Size(97, 29)
        ProgramToolStripMenuItem.Text = "Program"' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(142, 34)
        ExitToolStripMenuItem.Text = "Exit"' 
        ' PdfToolStripMenuItem
        ' 
        PdfToolStripMenuItem.Name = "PdfToolStripMenuItem"
        PdfToolStripMenuItem.Size = New Size(142, 34)
        PdfToolStripMenuItem.Text = "pdf"' 
        ' RegulationManagementToolStripMenuItem
        ' 
        RegulationManagementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ManageRegulationsToolStripMenuItem, ManageProgramsToolStripMenuItem, ManageCourseFileToolStripMenuItem})
        RegulationManagementToolStripMenuItem.Name = "RegulationManagementToolStripMenuItem"
        RegulationManagementToolStripMenuItem.Size = New Size(222, 29)
        RegulationManagementToolStripMenuItem.Text = "Regulation Management"' 
        ' ManageRegulationsToolStripMenuItem
        ' 
        ManageRegulationsToolStripMenuItem.Name = "ManageRegulationsToolStripMenuItem"
        ManageRegulationsToolStripMenuItem.Size = New Size(322, 34)
        ManageRegulationsToolStripMenuItem.Text = "Manage Regulations"' 
        ' ManageProgramsToolStripMenuItem
        ' 
        ManageProgramsToolStripMenuItem.Name = "ManageProgramsToolStripMenuItem"
        ManageProgramsToolStripMenuItem.Size = New Size(322, 34)
        ManageProgramsToolStripMenuItem.Text = "Manage Program/Courses"' 
        ' ManageCourseFileToolStripMenuItem
        ' 
        ManageCourseFileToolStripMenuItem.Name = "ManageCourseFileToolStripMenuItem"
        ManageCourseFileToolStripMenuItem.Size = New Size(322, 34)
        ManageCourseFileToolStripMenuItem.Text = "Manage Courses File"' 
        ' StudentManagementToolStripMenuItem
        ' 
        StudentManagementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ManageCoursesToolStripMenuItem, AddStudentToolStripMenuItem, ViewStudentsToolStripMenuItem})
        StudentManagementToolStripMenuItem.Name = "StudentManagementToolStripMenuItem"
        StudentManagementToolStripMenuItem.Size = New Size(199, 29)
        StudentManagementToolStripMenuItem.Text = "Student Management"' 
        ' ManageCoursesToolStripMenuItem
        ' 
        ManageCoursesToolStripMenuItem.Name = "ManageCoursesToolStripMenuItem"
        ManageCoursesToolStripMenuItem.Size = New Size(270, 34)
        ManageCoursesToolStripMenuItem.Text = "Manage Courses"' 
        ' AddStudentToolStripMenuItem
        ' 
        AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        AddStudentToolStripMenuItem.Size = New Size(270, 34)
        AddStudentToolStripMenuItem.Text = "Add Student"' 
        ' QuestionPaperManagementToolStripMenuItem
        ' 
        QuestionPaperManagementToolStripMenuItem.Name = "QuestionPaperManagementToolStripMenuItem"
        QuestionPaperManagementToolStripMenuItem.Size = New Size(259, 29)
        QuestionPaperManagementToolStripMenuItem.Text = "Question Paper Management"' 
        ' ResultsManagementToolStripMenuItem
        ' 
        ResultsManagementToolStripMenuItem.Name = "ResultsManagementToolStripMenuItem"
        ResultsManagementToolStripMenuItem.Size = New Size(193, 29)
        ResultsManagementToolStripMenuItem.Text = "Results Management"' 
        ' TestToolStripMenuItem
        ' 
        TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        TestToolStripMenuItem.Size = New Size(58, 29)
        TestToolStripMenuItem.Text = "Test"' 
        ' ViewStudentsToolStripMenuItem
        ' 
        ViewStudentsToolStripMenuItem.Name = "ViewStudentsToolStripMenuItem"
        ViewStudentsToolStripMenuItem.Size = New Size(270, 34)
        ViewStudentsToolStripMenuItem.Text = "View Students"' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1750, 919)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
        Name = "Main"
        Text = "Mount Zion - Examination Management System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegulationManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuestionPaperManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResultsManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageRegulationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageCoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageCourseFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PdfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStudentsToolStripMenuItem As ToolStripMenuItem
End Class
