<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label1 = New Label()
        Students_List = New DataGridView()
        chk = New DataGridViewCheckBoxColumn()
        gh = New Button()
        EnterpriseReport1 = New CrystalDecisions.Shared.EnterpriseReport()
        CType(Students_List, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(150, 310)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(402, 155)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(379, 69)
        Button2.Margin = New Padding(4, 5, 4, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(458, 159)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(779, 484)
        Button3.Margin = New Padding(4, 5, 4, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(362, 145)
        Button3.TabIndex = 2
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(74, 540)
        Button4.Margin = New Padding(4, 5, 4, 5)
        Button4.Name = "Button4"
        Button4.Size = New Size(162, 89)
        Button4.TabIndex = 3
        Button4.Text = "Upload File"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(246, 540)
        Button5.Margin = New Padding(4, 5, 4, 5)
        Button5.Name = "Button5"
        Button5.Size = New Size(162, 89)
        Button5.TabIndex = 4
        Button5.Text = "Download File"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(80, 40)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(155, 31)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(80, 81)
        TextBox2.Margin = New Padding(4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(155, 31)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(80, 122)
        TextBox3.Margin = New Padding(4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(155, 31)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(80, 164)
        TextBox4.Margin = New Padding(4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(155, 31)
        TextBox4.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(246, 44)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 9
        Label1.Text = "Label1"' 
        ' Students_List
        ' 
        Students_List.AllowUserToAddRows = False
        Students_List.AllowUserToDeleteRows = False
        Students_List.BackgroundColor = SystemColors.Control
        Students_List.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Students_List.ColumnHeadersHeight = 34
        Students_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Students_List.Columns.AddRange(New DataGridViewColumn() {chk})
        Students_List.Location = New Point(111, 224)
        Students_List.Margin = New Padding(2)
        Students_List.Name = "Students_List"
        Students_List.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Students_List.RowHeadersVisible = False
        Students_List.RowHeadersWidth = 62
        Students_List.RowTemplate.Height = 28
        Students_List.Size = New Size(921, 302)
        Students_List.TabIndex = 11
        ' 
        ' chk
        ' 
        chk.HeaderText = "     All"
        chk.MinimumWidth = 8
        chk.Name = "chk"
        chk.Width = 50
        ' 
        ' gh
        ' 
        gh.Location = New Point(895, 104)
        gh.Name = "gh"
        gh.Size = New Size(177, 91)
        gh.TabIndex = 12
        gh.Text = "gh"
        gh.UseVisualStyleBackColor = True
        ' 
        ' EnterpriseReport1
        ' 
        EnterpriseReport1.ApsServer = ""
        EnterpriseReport1.AuthenticationType = ""
        EnterpriseReport1.ObjectCUID = ""
        EnterpriseReport1.ObjectID = ""
        EnterpriseReport1.Password = ""
        EnterpriseReport1.ReportSource = Nothing
        EnterpriseReport1.Username = ""
        EnterpriseReport1.WebConnector = ""
        EnterpriseReport1.WebServiceUrl = ""' 
        ' TestForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 750)
        Controls.Add(gh)
        Controls.Add(Students_List)
        Controls.Add(Label1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "TestForm"
        Text = "TestForm"
        CType(Students_List, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Students_List As DataGridView
    Friend WithEvents chk As DataGridViewCheckBoxColumn
    Friend WithEvents gh As Button
    Friend WithEvents EnterpriseReport1 As CrystalDecisions.Shared.EnterpriseReport
End Class
