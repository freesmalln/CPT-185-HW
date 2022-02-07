Public Class TechJobFair
    Private Sub DateAndLocation_Click(sender As Object, e As EventArgs) Handles DateAndLocation.Click
        ' Executed when the date and location button is pressed
        LabelDate.Visible = True
        LabelHall.Visible = True
        LabelRoom.Visible = True
        DateAndLocation.Enabled = False
    End Sub

    Private Sub ExitWin_Click(sender As Object, e As EventArgs) Handles ExitWin.Click
        ' Executed when the exit window button is pressed
        Close()
    End Sub
End Class
