Public Class Book_Keeping

    Private Sub Book_keepingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book_keepingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Book_keepingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Lejo_DB_2DataSet)

    End Sub

    Private Sub Book_Keeping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lejo_DB_2DataSet.Book_keeping' table. You can move, or remove it, as needed.
        Me.Book_keepingTableAdapter.Fill(Me.Lejo_DB_2DataSet.Book_keeping)

    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        Book_keepingBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncalc.Click
        Dim sales As Integer
        Dim expense As Integer
        Dim profit As Integer
        sales = SalesTextBox.Text
        expense = Total_ExpenseTextBox.Text
        profit = sales - expense
        Profit_Ksh_TextBox.Text = profit.ToString

    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Try
            Book_keepingBindingSource.EndEdit()
            Book_keepingTableAdapter.Update(Lejo_DB_2DataSet)
            MsgBox("Saved Successfully")
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        Book_keepingBindingSource.RemoveCurrent()
        Book_keepingTableAdapter.Update(Lejo_DB_2DataSet)
        MsgBox("Deleted Successfully")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnback.Click
        Me.Hide()
        Main.Show()
    End Sub
End Class