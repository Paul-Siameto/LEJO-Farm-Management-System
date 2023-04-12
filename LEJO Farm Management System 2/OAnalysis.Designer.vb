<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OAnalysis
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Btnbk = New System.Windows.Forms.Button()
        Me.Btnproduction = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lejo_DB_2DataSet = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSet()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BookKeepingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.ProductionTableAdapter()
        Me.Book_keepingTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.Book_keepingTableAdapter()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookKeepingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnbk
        '
        Me.Btnbk.BackColor = System.Drawing.Color.White
        Me.Btnbk.Location = New System.Drawing.Point(221, 15)
        Me.Btnbk.Name = "Btnbk"
        Me.Btnbk.Size = New System.Drawing.Size(124, 45)
        Me.Btnbk.TabIndex = 6
        Me.Btnbk.Text = "Book Keeping"
        Me.Btnbk.UseVisualStyleBackColor = False
        '
        'Btnproduction
        '
        Me.Btnproduction.BackColor = System.Drawing.Color.White
        Me.Btnproduction.Location = New System.Drawing.Point(20, 15)
        Me.Btnproduction.Name = "Btnproduction"
        Me.Btnproduction.Size = New System.Drawing.Size(130, 45)
        Me.Btnproduction.TabIndex = 4
        Me.Btnproduction.Text = "Production"
        Me.Btnproduction.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Btnbk)
        Me.Panel1.Controls.Add(Me.Btnproduction)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(161, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 79)
        Me.Panel1.TabIndex = 7
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Me.Chart1.DataSource = Me.ProductionBindingSource
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(12, 108)
        Me.Chart1.Name = "Chart1"
        Series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
        Series3.BorderColor = System.Drawing.Color.Lime
        Series3.ChartArea = "ChartArea1"
        Series3.Color = System.Drawing.Color.LimeGreen
        Series3.Legend = "Legend1"
        Series3.Name = "Harvest"
        Series3.XValueMember = "Farm Number"
        Series3.YValueMembers = "Harvest Amount(Kgs)"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(799, 300)
        Me.Chart1.TabIndex = 8
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
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea4.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea4)
        Me.Chart2.DataSource = Me.BookKeepingBindingSource
        Legend4.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend4)
        Me.Chart2.Location = New System.Drawing.Point(12, 424)
        Me.Chart2.Name = "Chart2"
        Series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
        Series4.ChartArea = "ChartArea1"
        Series4.Color = System.Drawing.Color.Goldenrod
        Series4.Legend = "Legend1"
        Series4.Name = "Sales"
        Series4.XValueMember = "Farm Number"
        Series4.YValueMembers = "Sales"
        Me.Chart2.Series.Add(Series4)
        Me.Chart2.Size = New System.Drawing.Size(799, 287)
        Me.Chart2.TabIndex = 9
        Me.Chart2.Text = "Chart2"
        '
        'BookKeepingBindingSource
        '
        Me.BookKeepingBindingSource.DataMember = "Book keeping"
        Me.BookKeepingBindingSource.DataSource = Me.Lejo_DB_2DataSet
        '
        'ProductionTableAdapter
        '
        Me.ProductionTableAdapter.ClearBeforeFill = True
        '
        'Book_keepingTableAdapter
        '
        Me.Book_keepingTableAdapter.ClearBeforeFill = True
        '
        'Chart3
        '
        ChartArea5.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend5)
        Me.Chart3.Location = New System.Drawing.Point(20, 116)
        Me.Chart3.Name = "Chart3"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.Chart3.Series.Add(Series5)
        Me.Chart3.Size = New System.Drawing.Size(300, 300)
        Me.Chart3.TabIndex = 10
        Me.Chart3.Text = "Chart3"
        '
        'OAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(825, 733)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "OAnalysis"
        Me.Text = "Analysis"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookKeepingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btnbk As System.Windows.Forms.Button
    Friend WithEvents Btnproduction As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Lejo_DB_2DataSet As LEJO_Farm_Management_System_2.Lejo_DB_2DataSet
    Friend WithEvents ProductionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductionTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.ProductionTableAdapter
    Friend WithEvents BookKeepingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_keepingTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.Book_keepingTableAdapter
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
