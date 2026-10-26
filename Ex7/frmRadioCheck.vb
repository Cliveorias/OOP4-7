Public Class frmRadioCheck

    Private Sub btnTestRdoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestRdoBtn.Click
        If rdoBSIT.Checked = True Then
            MessageBox.Show("Your course is: " + rdoBSIT.Text, "Radio Button")
        ElseIf rdoBSCS.Checked = True Then
            MessageBox.Show("Your course is: " + rdoBSCS.Text, "Radio Button")
        ElseIf rdoBSCpE.Checked = True Then
            MessageBox.Show("Your course is: " + rdoBSCpE.Text, "Radio Button")
        Else
            MessageBox.Show("No course selected...", "Radio Button")
        End If
    End Sub

    Private Sub btnTestChkBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestChkBox.Click
        Dim Subj As String = ""

        If chkCom.Checked Then
            Subj = Subj + chkCom.Text + vbNewLine
        End If

        If chkEng.Checked Then
            Subj = Subj + chkEng.Text + vbNewLine
        End If

        If chkFil.Checked Then
            Subj = Subj + chkFil.Text + vbNewLine
        End If

        If chkSci.Checked Then
            Subj = Subj + chkSci.Text + vbNewLine
        End If

        If chkMat.Checked Then
            Subj = Subj + chkMat.Text + vbNewLine
        End If

        MessageBox.Show("Your favorite subject/s is/are:" + vbNewLine + Subj, "Check Box")
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        'To clear radio buttons
        rdoBSIT.Checked = False
        rdoBSCS.Checked = False
        rdoBSCpE.Checked = False
        'To clear check boxes
        chkFil.Checked = False
        chkCom.Checked = False
        chkSci.Checked = False
        chkEng.Checked = False
        chkMat.Checked = False
    End Sub

End Class
