Public Class frmDateTime

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Label1.Text = Format(Now, "dddd")
        Label1.Text = Today.DayOfWeek.ToString
        'Label2.Text = Format(Now, "hh:mm:ss tt")
        Label2.Text = TimeOfDay.ToString("hh:mm:ss tt")
        'Label3.Text = Format(Now, "MMMM")
        Label3.Text = Today.ToString("MMMM")
        'Label4.Text = Format(Now, "dd")
        Label4.Text = Today.ToString("dd")
        'Label5.Text = Format(Now, "yyyy")
        Label5.Text = Today.Year
    End Sub

End Class
