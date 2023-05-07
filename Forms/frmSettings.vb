Public Class frmSettings
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtZoom.TextChanged

    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbOrientation.SelectedIndex = 0
        cmbType.SelectedIndex = 0
    End Sub

    Private Sub butlose_Click(sender As Object, e As EventArgs) Handles butlose.Click
        Me.Close()

    End Sub
End Class