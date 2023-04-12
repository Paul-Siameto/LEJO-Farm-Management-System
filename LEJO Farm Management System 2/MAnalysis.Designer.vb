<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAnalysis
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnfarms = New System.Windows.Forms.Button()
        Me.Btnbk = New System.Windows.Forms.Button()
        Me.Btnproduction = New System.Windows.Forms.Button()
        Me.Btnreport = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Lejo_DB_2DataSet = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSet()
        Me.ProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.ProductionTableAdapter()
        Me.BookKeepingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_keepingTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.Book_keepingTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookKeepingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Btnfarms)
        Me.Panel1.Controls.Add(Me.Btnbk)
        Me.Panel1.Controls.Add(Me.Btnproduction)
        Me.Panel1.Controls.Add(Me.Btnreport)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 79)
        Me.Panel1.TabIndex = 8
        '
        'Btnfarms
        '
        Me.Btnfarms.BackColor = System.Drawing.Color.White
        Me.Btnfarms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnfarms.Location = New System.Drawing.Point(553, 14)
        Me.Btnfarms.Name = "Btnfarms"
        Me.Btnfarms.Size = New System.Drawing.Size(124, 45)
        Me.Btnfarms.TabIndex = 7
        Me.Btnfarms.Text = "Farms"
        Me.Btnfarms.UseVisualStyleBackColor = False
        '
        'Btnbk
        '
        Me.Btnbk.BackColor = System.Drawing.Color.White
        Me.Btnbk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnbk.Location = New System.Drawing.Point(388, 14)
        Me.Btnbk.Name = "Btnbk"
        Me.Btnbk.Size = New System.Drawing.Size(124, 45)
        Me.Btnbk.TabIndex = 6
        Me.Btnbk.Text = "Book Keeping"
        Me.Btnbk.UseVisualStyleBackColor = False
        '
        'Btnproduction
        '
        Me.Btnproduction.BackColor = System.Drawing.Color.White
        Me.Btnproduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnproduction.Location = New System.Drawing.Point(30, 14)
        Me.Btnproduction.Name = "Btnproduction"
        Me.Btnproduction.Size = New System.Drawing.Size(130, 45)
        Me.Btnproduction.TabIndex = 4
        Me.Btnproduction.Text = "Production"
        Me.Btnproduction.UseVisualStyleBackColor = False
        '
        'Btnreport
        '
        Me.Btnreport.BackColor = System.Drawing.Color.White
        Me.Btnreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnreport.Location = New System.Drawing.Point(209, 14)
        Me.Btnreport.Name = "Btnreport"
        Me.Btnreport.Size = New System.Drawing.Size(124, 45)
        Me.Btnreport.TabIndex = 5
        Me.Btnreport.Text = "Report"
        Me.Btnreport.UseVisualStyleBackColor = False
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
        Me.Chart1.Location = New System.Drawing.Point(12, 128)
        Me.Chart1.Name = "Chart1"
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
        Series1.BorderColor = System.Drawing.Color.Green
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.LimeGreen
        Series1.Legend = "Legend1"
        Series1.Name = "Harvest"
        Series1.XValueMember = "Farm Number"
        Series1.YValueMembers = "Harvest Amount(Kgs)"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(767, 300)
        Me.Chart1.TabIndex = 9
        Me.Chart1.Text = "Production"
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
        Me.Chart2.Location = New System.Drawing.Point(11, 450)
        Me.Chart2.Name = "Chart2"
        Series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
        Series2.BorderColor = System.Drawing.Color.Sienna
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.Goldenrod
        Series2.Legend = "Legend1"
        Series2.Name = "Sales"
        Series2.XValueMember = "Farm Number"
        Series2.YValueMembers = "Sales"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(768, 287)
        Me.Chart2.TabIndex = 10
        Me.Chart2.Text = "Sales"
        '
        'Lejo_DB_2DataSet
        '
        Me.Lejo_DB_2DataSet.DataSetName = "Lejo_DB_2DataSet"
        Me.Lejo_DB_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductionBindingSource
        '
        Me.ProductionBindingSource.DataMember = "Production"
        Me.ProductionBindingSource.DataSource = Me.Lejo_DB_2DataSet
        '
        'ProductionTableAdapter
        '
        Me.ProductionTableAdapter.ClearBeforeFill = True
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
        'MAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(802, 749)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MAnalysis"
        Me.Text = "Analysis"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookKeepingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnbk As System.Windows.Forms.Button
    Friend WithEvents Btnproduction As System.Windows.Forms.Button
    Friend WithEvents Btnfarms As System.Windows.Forms.Button
    Friend WithEvents Btnreport As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Lejo_DB_2DataSet As LEJO_Farm_Management_System_2.Lejo_DB_2DataSet
    Friend WithEvents ProductionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductionTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.ProductionTableAdapter
    Friend WithEvents BookKeepingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_keepingTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.Book_keepingTableAdapter
End Class
