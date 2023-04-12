Public Class MReport
    Dim g, mg As Graphics
    Dim pt As Bitmap
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfarms.Click
        Me.Hide()
        MFarm.Show()

    End Sub

    Private Sub Btnproduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnproduction.Click
        Me.Hide()
        MProduction.Show()

    End Sub

    Private Sub Btnbk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbk.Click
        Me.Hide()
        MBook_Keeping.Show()

    End Sub

    Private Sub Btnanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnanalysis.Click
        Me.Hide()
        MAnalysis.Show()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(pt, 0, 0)

    End Sub

    Private Sub Btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprint.Click
        g = CreateGraphics()
        pt = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(pt)
        mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class