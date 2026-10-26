Public Class frmMsgBox

    Private Sub btnMsgBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMsgBox.Click
        MsgBox("Hello World!")
        MsgBox("Are you nice?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question")
    End Sub

    Private Sub btnMessageBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMessageBox.Click
        MessageBox.Show("Hello Philippines")
        MessageBox.Show("Please compelte all entries", "Information", _
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub

End Class
