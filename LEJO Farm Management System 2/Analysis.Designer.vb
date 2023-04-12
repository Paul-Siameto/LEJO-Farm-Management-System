<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Analysis
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lejo_DB_2DataSet = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSet()
        Me.ProductionTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.ProductionTableAdapter()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BookKeepingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_keepingTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.Book_keepingTableAdapter()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookKeepingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.ProductionBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
        Series1.BorderColor = System.Drawing.Color.Lime
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.LimeGreen
        Series1.Legend = "Legend1"
        Series1.Name = "Harvest"
        Series1.XValueMember = "Farm Number"
        Series1.YValueMembers = "Harvest Amount(Kgs)"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(799, 300)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Production"
        '
        'ProductionBindingSource
        '
        Me.ProductionBindingSource.DataMember = "Production"
        Me.ProductionBindingSource.DataSource = Me.Lejo_DB_2DataSet
        '
        'Lejo_DB_2DataSet
        '
        Me.Lejo_DB_2DataSet.DataSetName = "Lejo_DB_2DataSet"
        Me.Lejo_DB_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductionTableAdapter
        '
        Me.ProductionTableAdapter.ClearBeforeFill = True
        '
        'Btnback
        '
        Me.Btnback.BackColor = System.Drawing.Color.LemonChiffon
        Me.Btnback.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnback.Location = New System.Drawing.Point(712, 646)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(99, 33)
        Me.Btnback.TabIndex = 1
        Me.Btnback.Text = "Back"
        Me.Btnback.UseVisualStyleBackColor = False
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.DataSource = Me.BookKeepingBindingSource
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(43, 331)
        Me.Chart2.Name = "Chart2"
        Series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.Goldenrod
        Series2.Legend = "Legend1"
        Series2.Name = "Sales"
        Series2.XValueMember = "Farm Number"
        Series2.YValueMembers = "Sales"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(768, 287)
        Me.Chart2.TabIndex = 2
        Me.Chart2.Text = "Sales"
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
        'Analysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(827, 691)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Btnback)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Analysis"
        Me.Text = "Analysis"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookKeepingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Lejo_DB_2DataSet As LEJO_Farm_Management_System_2.Lejo_DB_2DataSet
    Friend WithEvents ProductionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductionTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.ProductionTableAdapter
    Friend WithEvents Btnback As System.Windows.Forms.Button
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents BookKeepingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_keepingTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.Book_keepingTableAdapter
End Class
