Public Class frmConditions

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim FinGrd As Single

        Try
            FinGrd = CSng(txtFinalGrade.Text)

            If FinGrd >= 74.5 Then
                lblRemarks.Text = "Passed"
            Else
                lblRemarks.Text = "Failed"
            End If

        Catch MyError As Exception
            MessageBox.Show("Pls. enter valid data", "Invalid Data")
            txtFinalGrade.Text = ""
            txtFinalGrade.Focus()
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFinalGrade.Text = ""
        txtFinalGrade.Focus()
        lblRemarks.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim Response As Integer

        Response = MessageBox.Show("Close Program...", "Exit", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Response = DialogResult.Yes Then
            Close()
        End If
    End Sub

End Class
