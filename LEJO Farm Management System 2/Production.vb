Public Class Production

    Private Sub ProductionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lejo_DB_2DataSet)

    End Sub

    Private Sub Production_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lejo_DB_2DataSet.Production' table. You can move, or remove it, as needed.
        Me.ProductionTableAdapter.Fill(Me.Lejo_DB_2DataSet.Production)

    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        ProductionBindingSource.AddNew()

    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Try
            ProductionBindingSource.EndEdit()
            ProductionTableAdapter.Update(Lejo_DB_2DataSet)
            MsgBox("Saved Successfully")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        ProductionBindingSource.RemoveCurrent()
        ProductionTableAdapter.Update(Lejo_DB_2DataSet)
        MsgBox("Deleted Successfully")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Main.Show()

    End Sub
End Class