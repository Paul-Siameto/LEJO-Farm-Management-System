Public Class MFarm

    Private Sub FarmBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FarmBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FarmBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lejo_DB_2DataSet)

    End Sub

    Private Sub MFarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lejo_DB_2DataSet.Farm' table. You can move, or remove it, as needed.
        Me.FarmTableAdapter.Fill(Me.Lejo_DB_2DataSet.Farm)

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

    Private Sub Btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnreport.Click
        Me.Hide()
        MReport.Show()

    End Sub

    Private Sub Btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogout.Click
        Me.Hide()
        Login.Show()

    End Sub
End Class