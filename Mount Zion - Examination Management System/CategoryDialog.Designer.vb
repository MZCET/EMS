﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoryDialog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CategoryCombox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the ContactPeriods for the Course"
        '
        'CategoryCombox
        '
        Me.CategoryCombox.BackColor = System.Drawing.SystemColors.Window
        Me.CategoryCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryCombox.FormattingEnabled = True
        Me.CategoryCombox.Items.AddRange(New Object() {"OP", "HS"})
        Me.CategoryCombox.Location = New System.Drawing.Point(67, 71)
        Me.CategoryCombox.Name = "CategoryCombox"
        Me.CategoryCombox.Size = New System.Drawing.Size(213, 28)
        Me.CategoryCombox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(246, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CategoryDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 179)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CategoryCombox)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CategoryDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CategoryDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CategoryCombox As ComboBox
    Friend WithEvents Button1 As Button
End Class
