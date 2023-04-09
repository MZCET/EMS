<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentDetails_page2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(studentDetails_page2))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        Label8 = New Label()
        Label4 = New Label()
        upload_handwritting = New Button()
        upload_sign = New Button()
        upload_photo = New Button()
        Label7 = New Label()
        prev_page2 = New Button()
        Label13 = New Label()
        Next_pg2 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = SystemColors.Control
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(prev_page2)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Next_pg2)
        Panel1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Panel1.Location = New Point(6, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1774, 886)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1360, 669)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(406, 116)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 60
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.EjY_lxhUcAAqCde__1_
        PictureBox1.Location = New Point(1465, 86)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(274, 296)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 59
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(upload_handwritting)
        Panel4.Controls.Add(upload_sign)
        Panel4.Controls.Add(upload_photo)
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(21, 86)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(589, 699)
        Panel4.TabIndex = 58
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 20)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 25)
        Label8.TabIndex = 52
        Label8.Text = "Photo (20kb) :"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 25)
        Label4.TabIndex = 54
        Label4.Text = "Handwriting (20kb) :"' 
        ' upload_handwritting
        ' 
        upload_handwritting.Location = New Point(325, 118)
        upload_handwritting.Name = "upload_handwritting"
        upload_handwritting.Size = New Size(242, 40)
        upload_handwritting.TabIndex = 57
        upload_handwritting.Text = "Upload Handwritting"
        upload_handwritting.UseVisualStyleBackColor = True
        ' 
        ' upload_sign
        ' 
        upload_sign.Location = New Point(325, 65)
        upload_sign.Name = "upload_sign"
        upload_sign.Size = New Size(242, 40)
        upload_sign.TabIndex = 56
        upload_sign.Text = "Upload Signature"
        upload_sign.UseVisualStyleBackColor = True
        ' 
        ' upload_photo
        ' 
        upload_photo.Location = New Point(325, 12)
        upload_photo.Name = "upload_photo"
        upload_photo.Size = New Size(242, 40)
        upload_photo.TabIndex = 55
        upload_photo.Text = "Upload Photo"
        upload_photo.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 73)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 25)
        Label7.TabIndex = 53
        Label7.Text = "Signature (20kb) :"' 
        ' prev_page2
        ' 
        prev_page2.Location = New Point(1407, 820)
        prev_page2.Name = "prev_page2"
        prev_page2.Size = New Size(124, 46)
        prev_page2.TabIndex = 49
        prev_page2.Text = "< Prev"
        prev_page2.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(21, 29)
        Label13.Name = "Label13"
        Label13.Size = New Size(152, 25)
        Label13.TabIndex = 29
        Label13.Text = "Student's Details :"' 
        ' Next_pg2
        ' 
        Next_pg2.Location = New Point(1615, 820)
        Next_pg2.Name = "Next_pg2"
        Next_pg2.Size = New Size(124, 46)
        Next_pg2.TabIndex = 26
        Next_pg2.Text = "Add"
        Next_pg2.UseVisualStyleBackColor = True
        ' 
        ' studentDetails_page2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1785, 893)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "studentDetails_page2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Page 2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents prev_page2 As Button
    Friend WithEvents Next_pg2 As Button
    Friend WithEvents name_of_d As ComboBox
    Friend WithEvents name_of_p As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents upload_photo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents upload_sign As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents upload_handwritting As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
End Class
