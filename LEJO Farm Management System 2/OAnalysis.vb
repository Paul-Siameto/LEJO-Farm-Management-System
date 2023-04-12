Public Class OAnalysis

    Private Sub Btnproduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnproduction.Click
        Me.Hide()
        OProduction.Show()

    End Sub

    Private Sub Btnanalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnbk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbk.Click
        Me.Hide()
        OBook_Keeping.Show()

    End Sub

    Private Sub OAnalysis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Lejo_DB_2DataSet.Book_keeping' table. You can move, or remove it, as needed.
        Me.Book_keepingTableAdapter.Fill(Me.Lejo_DB_2DataSet.Book_keeping)
        'TODO: This line of code loads data into the 'Lejo_DB_2DataSet.Production' table. You can move, or remove it, as needed.
        Me.ProductionTableAdapter.Fill(Me.Lejo_DB_2DataSet.Production)

    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub
End Class