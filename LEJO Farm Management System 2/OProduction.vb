Public Class OProduction

    Private Sub ProductionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lejo_DB_2DataSet)

    End Sub

    Private Sub OProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lejo_DB_2DataSet.Production' table. You can move, or remove it, as needed.
        Me.ProductionTableAdapter.Fill(Me.Lejo_DB_2DataSet.Production)

    End Sub

    Private Sub Btnbk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbk.Click
        Me.Hide()
        OBook_Keeping.Show()

    End Sub

    Private Sub Btnanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnanalysis.Click
        Me.Hide()
        OAnalysis.Show()

    End Sub

    Private Sub Btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogout.Click
        Me.Hide()
        Login.Show()

    End Sub
End Class