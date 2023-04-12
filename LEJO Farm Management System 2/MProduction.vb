Public Class MProduction

    Private Sub ProductionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lejo_DB_2DataSet)

    End Sub

    Private Sub MProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lejo_DB_2DataSet.Production' table. You can move, or remove it, as needed.
        Me.ProductionTableAdapter.Fill(Me.Lejo_DB_2DataSet.Production)

    End Sub

    Private Sub Btnfarms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfarms.Click
        Me.Hide()
        MFarm.Show()

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
End Class