<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStudentCourse
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
        GroupBox1 = New GroupBox()
        Regulationcombobox = New ComboBox()
        Label4 = New Label()
        Button5 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Departmentcombobox = New ComboBox()
        Label3 = New Label()
        Department = New ComboBox()
        Label2 = New Label()
        Year = New ComboBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Students_List = New DataGridView()
        chk = New DataGridViewCheckBoxColumn()
        GroupBox3 = New GroupBox()
        CourseGrid = New DataGridView()
        cchk = New DataGridViewCheckBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(Students_List, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(CourseGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Regulationcombobox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Departmentcombobox)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Department)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Year)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(15, 15)
        GroupBox1.Margin = New Padding(4, 4, 4, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 4, 4, 4)
        GroupBox1.Size = New Size(772, 274)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Manage Course"' 
        ' Regulationcombobox
        ' 
        Regulationcombobox.DropDownStyle = ComboBoxStyle.DropDownList
        Regulationcombobox.FormattingEnabled = True
        Regulationcombobox.Location = New Point(325, 59)
        Regulationcombobox.Margin = New Padding(4, 4, 4, 4)
        Regulationcombobox.Name = "Regulationcombobox"
        Regulationcombobox.Size = New Size(309, 33)
        Regulationcombobox.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(325, 29)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 25)
        Label4.TabIndex = 9
        Label4.Text = "Select Regulation "' 
        ' Button5
        ' 
        Button5.Location = New Point(634, 192)
        Button5.Margin = New Padding(4, 4, 4, 4)
        Button5.Name = "Button5"
        Button5.Size = New Size(132, 68)
        Button5.TabIndex = 8
        Button5.Text = "Cancel"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(484, 192)
        Button2.Margin = New Padding(4, 4, 4, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 68)
        Button2.TabIndex = 7
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(325, 221)
        Button1.Margin = New Padding(4, 4, 4, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 39)
        Button1.TabIndex = 6
        Button1.Text = "Show"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Departmentcombobox
        ' 
        Departmentcombobox.DropDownStyle = ComboBoxStyle.DropDownList
        Departmentcombobox.FormattingEnabled = True
        Departmentcombobox.Location = New Point(8, 221)
        Departmentcombobox.Margin = New Padding(4, 4, 4, 4)
        Departmentcombobox.Name = "Departmentcombobox"
        Departmentcombobox.Size = New Size(309, 33)
        Departmentcombobox.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 192)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 25)
        Label3.TabIndex = 4
        Label3.Text = "Select Department"' 
        ' Department
        ' 
        Department.DropDownStyle = ComboBoxStyle.DropDownList
        Department.FormattingEnabled = True
        Department.Items.AddRange(New Object() {"", "I", "II", "III", "IV"})
        Department.Location = New Point(8, 142)
        Department.Margin = New Padding(4, 4, 4, 4)
        Department.Name = "Department"
        Department.Size = New Size(309, 33)
        Department.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 114)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 2
        Label2.Text = "Select Year"' 
        ' Year
        ' 
        Year.DropDownStyle = ComboBoxStyle.DropDownList
        Year.FormattingEnabled = True
        Year.Items.AddRange(New Object() {"", "UG", "PG", "PHD"})
        Year.Location = New Point(8, 59)
        Year.Margin = New Padding(4, 4, 4, 4)
        Year.Name = "Year"
        Year.Size = New Size(309, 33)
        Year.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 30)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 25)
        Label1.TabIndex = 0
        Label1.Text = "Select Programe"' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Students_List)
        GroupBox2.Location = New Point(15, 296)
        GroupBox2.Margin = New Padding(4, 4, 4, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 4, 4, 4)
        GroupBox2.Size = New Size(772, 986)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Students"' 
        ' Students_List
        ' 
        Students_List.AllowUserToAddRows = False
        Students_List.AllowUserToDeleteRows = False
        Students_List.BackgroundColor = Color.White
        Students_List.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Students_List.ColumnHeadersHeight = 34
        Students_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Students_List.Columns.AddRange(New DataGridViewColumn() {chk})
        Students_List.Location = New Point(8, 31)
        Students_List.Margin = New Padding(2)
        Students_List.Name = "Students_List"
        Students_List.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Students_List.RowHeadersVisible = False
        Students_List.RowHeadersWidth = 62
        Students_List.RowTemplate.Height = 28
        Students_List.Size = New Size(759, 949)
        Students_List.TabIndex = 11
        ' 
        ' chk
        ' 
        chk.HeaderText = "     All"
        chk.MinimumWidth = 8
        chk.Name = "chk"
        chk.Width = 50
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CourseGrid)
        GroupBox3.Location = New Point(795, 15)
        GroupBox3.Margin = New Padding(4, 4, 4, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 4, 4, 4)
        GroupBox3.Size = New Size(1359, 1268)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Courses"' 
        ' CourseGrid
        ' 
        CourseGrid.AllowUserToAddRows = False
        CourseGrid.AllowUserToDeleteRows = False
        CourseGrid.BackgroundColor = Color.White
        CourseGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        CourseGrid.ColumnHeadersHeight = 34
        CourseGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        CourseGrid.Columns.AddRange(New DataGridViewColumn() {cchk})
        CourseGrid.Location = New Point(6, 30)
        CourseGrid.Margin = New Padding(2)
        CourseGrid.Name = "CourseGrid"
        CourseGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        CourseGrid.RowHeadersVisible = False
        CourseGrid.RowHeadersWidth = 62
        CourseGrid.RowTemplate.Height = 28
        CourseGrid.Size = New Size(1346, 1231)
        CourseGrid.TabIndex = 12
        ' 
        ' cchk
        ' 
        cchk.HeaderText = "All"
        cchk.MinimumWidth = 8
        cchk.Name = "cchk"
        cchk.Width = 50
        ' 
        ' ManageStudentCourse
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(4, 4, 4, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ManageStudentCourse"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MANAGE STUDENTS COURSES"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(Students_List, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(CourseGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Departmentcombobox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Department As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Year As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Students_List As DataGridView
    Friend WithEvents chk As DataGridViewCheckBoxColumn
    Friend WithEvents CourseGrid As DataGridView
    Friend WithEvents cchk As DataGridViewCheckBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Regulationcombobox As ComboBox
    Friend WithEvents Label4 As Label
End Class
