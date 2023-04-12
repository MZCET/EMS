<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseAttachment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CourseDetailGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Regcombobox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CourseDetailGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CourseDetailGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 1031)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Course Details"
        '
        'CourseDetailGrid
        '
        Me.CourseDetailGrid.AllowUserToAddRows = False
        Me.CourseDetailGrid.AllowUserToDeleteRows = False
        Me.CourseDetailGrid.BackgroundColor = System.Drawing.Color.White
        Me.CourseDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CourseDetailGrid.Location = New System.Drawing.Point(6, 26)
        Me.CourseDetailGrid.Name = "CourseDetailGrid"
        Me.CourseDetailGrid.ReadOnly = True
        Me.CourseDetailGrid.RowHeadersWidth = 51
        Me.CourseDetailGrid.RowTemplate.Height = 29
        Me.CourseDetailGrid.Size = New System.Drawing.Size(1062, 999)
        Me.CourseDetailGrid.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Regcombobox)
        Me.GroupBox2.Location = New System.Drawing.Point(1092, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 206)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Upload Panel"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(196, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 43)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Regulation"
        '
        'Regcombobox
        '
        Me.Regcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Regcombobox.FormattingEnabled = True
        Me.Regcombobox.Location = New System.Drawing.Point(6, 81)
        Me.Regcombobox.Name = "Regcombobox"
        Me.Regcombobox.Size = New System.Drawing.Size(252, 28)
        Me.Regcombobox.TabIndex = 0
        '
        'CourseAttachment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1412, 1055)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CourseAttachment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COURSE-ATTACHMENT"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CourseDetailGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CourseDetailGrid As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Regcombobox As ComboBox
End Class
