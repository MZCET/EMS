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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegulationManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageRegulationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCourseFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestionPaperManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.RegulationManagementToolStripMenuItem, Me.StudentManagementToolStripMenuItem, Me.QuestionPaperManagementToolStripMenuItem, Me.ResultsManagementToolStripMenuItem, Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1400, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RegulationManagementToolStripMenuItem
        '
        Me.RegulationManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageRegulationsToolStripMenuItem, Me.ManageProgramsToolStripMenuItem, Me.ManageCourseFileToolStripMenuItem})
        Me.RegulationManagementToolStripMenuItem.Name = "RegulationManagementToolStripMenuItem"
        Me.RegulationManagementToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.RegulationManagementToolStripMenuItem.Text = "Regulation Management"
        '
        'ManageRegulationsToolStripMenuItem
        '
        Me.ManageRegulationsToolStripMenuItem.Name = "ManageRegulationsToolStripMenuItem"
        Me.ManageRegulationsToolStripMenuItem.Size = New System.Drawing.Size(264, 26)
        Me.ManageRegulationsToolStripMenuItem.Text = "Manage Regulations"
        '
        'ManageProgramsToolStripMenuItem
        '
        Me.ManageProgramsToolStripMenuItem.Name = "ManageProgramsToolStripMenuItem"
        Me.ManageProgramsToolStripMenuItem.Size = New System.Drawing.Size(264, 26)
        Me.ManageProgramsToolStripMenuItem.Text = "Manage Program/Courses"
        '
        'ManageCourseFileToolStripMenuItem
        '
        Me.ManageCourseFileToolStripMenuItem.Name = "ManageCourseFileToolStripMenuItem"
        Me.ManageCourseFileToolStripMenuItem.Size = New System.Drawing.Size(264, 26)
        Me.ManageCourseFileToolStripMenuItem.Text = "Manage Courses File"
        '
        'StudentManagementToolStripMenuItem
        '
        Me.StudentManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageCoursesToolStripMenuItem, Me.AddStudentToolStripMenuItem})
        Me.StudentManagementToolStripMenuItem.Name = "StudentManagementToolStripMenuItem"
        Me.StudentManagementToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.StudentManagementToolStripMenuItem.Text = "Student Management"
        '
        'ManageCoursesToolStripMenuItem
        '
        Me.ManageCoursesToolStripMenuItem.Name = "ManageCoursesToolStripMenuItem"
        Me.ManageCoursesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ManageCoursesToolStripMenuItem.Text = "Manage Courses"
        '
        'QuestionPaperManagementToolStripMenuItem
        '
        Me.QuestionPaperManagementToolStripMenuItem.Name = "QuestionPaperManagementToolStripMenuItem"
        Me.QuestionPaperManagementToolStripMenuItem.Size = New System.Drawing.Size(215, 24)
        Me.QuestionPaperManagementToolStripMenuItem.Text = "Question Paper Management"
        '
        'ResultsManagementToolStripMenuItem
        '
        Me.ResultsManagementToolStripMenuItem.Name = "ResultsManagementToolStripMenuItem"
        Me.ResultsManagementToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.ResultsManagementToolStripMenuItem.Text = "Results Management"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 735)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Main"
        Me.Text = "Mount Zion - Examination Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
