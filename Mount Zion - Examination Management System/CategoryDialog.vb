Public Class CategoryDialog
    Private Sub CategoryDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryCombox.Text = "OP"

    End Sub

    Private Sub CategoryCombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryCombox.SelectedIndexChanged
        CategoryValue = Me.CategoryCombox.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class