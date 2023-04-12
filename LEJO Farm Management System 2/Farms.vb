Public Class Farms

    Private Sub FarmBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FarmBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FarmBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lejo_DB_2DataSet)

    End Sub

    Private Sub Farm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lejo_DB_2DataSet.Farm' table. You can move, or remove it, as needed.
        Me.FarmTableAdapter.Fill(Me.Lejo_DB_2DataSet.Farm)

    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        FarmBindingSource.AddNew()

    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Try
            FarmBindingSource.EndEdit()
            FarmTableAdapter.Update(Lejo_DB_2DataSet)
            MsgBox("Successfully Saved")
        Catch
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        FarmBindingSource.RemoveCurrent()
        FarmTableAdapter.Update(Lejo_DB_2DataSet)
        MsgBox("Deleted Successfully")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Main.Show()

    End Sub
End Class