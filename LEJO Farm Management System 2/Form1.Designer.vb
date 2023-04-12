<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Lejo_DB_2DataSet = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSet()
        Me.BookKeepingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_keepingTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.Book_keepingTableAdapter()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookKeepingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.PaleGreen
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.BookKeepingBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(34, 22)
        Me.Chart1.Name = "Chart1"
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Production"
        Series1.XValueMember = "Sales"
        Series1.YValueMembers = "Farm Number"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(554, 300)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Lejo_DB_2DataSet
        '
        Me.Lejo_DB_2DataSet.DataSetName = "Lejo_DB_2DataSet"
        Me.Lejo_DB_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookKeepingBindingSource
        '
        Me.BookKeepingBindingSource.DataMember = "Book keeping"
        Me.BookKeepingBindingSource.DataSource = Me.Lejo_DB_2DataSet
        '
        'Book_keepingTableAdapter
        '
        Me.Book_keepingTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 358)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookKeepingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Lejo_DB_2DataSet As LEJO_Farm_Management_System_2.Lejo_DB_2DataSet
    Friend WithEvents BookKeepingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_keepingTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.Book_keepingTableAdapter
End Class
