Public Class Owners

    Private Sub OwnerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OwnerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OwnerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lejo_DB_2DataSet)

    End Sub

    Private Sub Owner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lejo_DB_2DataSet.Owner' table. You can move, or remove it, as needed.
        Me.OwnerTableAdapter.Fill(Me.Lejo_DB_2DataSet.Owner)

    End Sub

    Private Sub Btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnback.Click
        Me.Hide()
        Main.Show()

    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Try
            OwnerBindingSource.EndEdit()
            OwnerTableAdapter.Update(Lejo_DB_2DataSet)
            MsgBox("Saved Successfully")
        Catch
            MsgBox("Error")
        End Try

    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        OwnerBindingSource.AddNew()

    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        OwnerBindingSource.RemoveCurrent()
        OwnerTableAdapter.Update(Lejo_DB_2DataSet)
        MsgBox("Deleted Successfully")
    End Sub
End Class