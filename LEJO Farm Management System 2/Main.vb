Public Class Main

    Private Sub Btnprofile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprofile.Click
        Me.Hide()
        Owners.Show()

    End Sub

    Private Sub Btnfarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfarm.Click
        Me.Hide()
        Farms.Show()

    End Sub

    Private Sub Btnproduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnproduction.Click
        Me.Hide()
        Production.Show()

    End Sub

    Private Sub Btnbk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbk.Click
        Me.Hide()
        Book_Keeping.Show()

    End Sub

    Private Sub Btnanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnanalysis.Click
        Me.Hide()
        Analysis.Show()

    End Sub

    Private Sub Btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnreport.Click
        Me.Hide()
        Report.Show()

    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogout.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class