Public Class OBook_Keeping

    Private Sub Book_keepingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Book_keepingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lejo_DB_2DataSet)

    End Sub


    Private Sub Book_keepingBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Book_keepingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lejo_DB_2DataSet)

    End Sub


    Private Sub Book_keepingBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book_keepingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Book_keepingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lejo_DB_2DataSet)

    End Sub

    Private Sub OBook_Keeping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lejo_DB_2DataSet.Book_keeping' table. You can move, or remove it, as needed.
        Me.Book_keepingTableAdapter.Fill(Me.Lejo_DB_2DataSet.Book_keeping)

    End Sub

    Private Sub Btnproduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnproduction.Click
        Me.Hide()
        OProduction.Show()

    End Sub

    Private Sub Btnanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnanalysis.Click
        Me.Hide()
        OAnalysis.Show()

    End Sub
End Class