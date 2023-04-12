Public Class Report
    Dim g, mg As Graphics
    Dim pt As Bitmap
    Private Sub Btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Main.Show()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim fond As New Font("Arial", 16, FontStyle.Regular)
        'e.Graphics.DrawString(t.Text, Font, Brushes.Black, 200, 200)
        e.Graphics.DrawImage(pt, 0, 0)

    End Sub

    Private Sub Btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PrintDialog1.Document = PrintDocument1
        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        'PrintDocument1.Print()

        'End If
        ' g = CreateGraphics()
        ' pt = New Bitmap(Size.Width, Size.Height, g)
        ' mg = Graphics.FromImage(pt)
        'mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        'PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PageSetupDialog1.Document = PrintDocument1
        'PageSetupDialog1.Document.DefaultPageSettings.Color = False
        'PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnprint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprint.Click
        g = CreateGraphics()
        pt = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(pt)
        mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub Btnback_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnback.Click
        Me.Hide()
        Main.Show()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.ShowDialog()
    End Sub
End Class