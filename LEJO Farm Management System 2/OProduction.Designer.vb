<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OProduction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OProduction))
        Me.Btnanalysis = New System.Windows.Forms.Button()
        Me.Btnbk = New System.Windows.Forms.Button()
        Me.Lejo_DB_2DataSet = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSet()
        Me.ProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.ProductionTableAdapter()
        Me.TableAdapterManager = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager()
        Me.ProductionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnlogout = New System.Windows.Forms.Button()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductionBindingNavigator.SuspendLayout()
        CType(Me.ProductionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnanalysis
        '
        Me.Btnanalysis.BackColor = System.Drawing.Color.White
        Me.Btnanalysis.Location = New System.Drawing.Point(16, 96)
        Me.Btnanalysis.Name = "Btnanalysis"
        Me.Btnanalysis.Size = New System.Drawing.Size(130, 45)
        Me.Btnanalysis.TabIndex = 2
        Me.Btnanalysis.Text = "Analysis"
        Me.Btnanalysis.UseVisualStyleBackColor = False
        '
        'Btnbk
        '
        Me.Btnbk.BackColor = System.Drawing.Color.White
        Me.Btnbk.Location = New System.Drawing.Point(16, 21)
        Me.Btnbk.Name = "Btnbk"
        Me.Btnbk.Size = New System.Drawing.Size(130, 45)
        Me.Btnbk.TabIndex = 3
        Me.Btnbk.Text = "Book Keeping"
        Me.Btnbk.UseVisualStyleBackColor = False
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_keepingTableAdapter = Nothing
        Me.TableAdapterManager.FarmTableAdapter = Nothing
        Me.TableAdapterManager.OwnerTableAdapter = Nothing
        Me.TableAdapterManager.ProductionTableAdapter = Me.ProductionTableAdapter
        Me.TableAdapterManager.UpdateOrder = LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductionBindingNavigator
        '
        Me.ProductionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductionBindingNavigator.BindingSource = Me.ProductionBindingSource
        Me.ProductionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductionBindingNavigatorSaveItem})
        Me.ProductionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductionBindingNavigator.Name = "ProductionBindingNavigator"
        Me.ProductionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductionBindingNavigator.Size = New System.Drawing.Size(810, 25)
        Me.ProductionBindingNavigator.TabIndex = 4
        Me.ProductionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductionBindingNavigatorSaveItem
        '
        Me.ProductionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductionBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductionBindingNavigatorSaveItem.Name = "ProductionBindingNavigatorSaveItem"
        Me.ProductionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductionDataGridView
        '
        Me.ProductionDataGridView.AutoGenerateColumns = False
        Me.ProductionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProductionDataGridView.DataSource = Me.ProductionBindingSource
        Me.ProductionDataGridView.Location = New System.Drawing.Point(23, 53)
        Me.ProductionDataGridView.Name = "ProductionDataGridView"
        Me.ProductionDataGridView.Size = New System.Drawing.Size(541, 313)
        Me.ProductionDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Farm Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Farm Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Farm ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Farm ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Crop Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Crop Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Harvest Amount(Kgs)"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Harvest Amount(Kgs)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Harvest Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Harvest Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Btnlogout)
        Me.Panel1.Controls.Add(Me.Btnbk)
        Me.Panel1.Controls.Add(Me.Btnanalysis)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(590, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 239)
        Me.Panel1.TabIndex = 5
        '
        'Btnlogout
        '
        Me.Btnlogout.BackColor = System.Drawing.Color.White
        Me.Btnlogout.Location = New System.Drawing.Point(16, 170)
        Me.Btnlogout.Name = "Btnlogout"
        Me.Btnlogout.Size = New System.Drawing.Size(130, 45)
        Me.Btnlogout.TabIndex = 4
        Me.Btnlogout.Text = "LogOut"
        Me.Btnlogout.UseVisualStyleBackColor = False
        '
        'OProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(810, 378)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProductionDataGridView)
        Me.Controls.Add(Me.ProductionBindingNavigator)
        Me.Name = "OProduction"
        Me.Text = "Production"
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductionBindingNavigator.ResumeLayout(False)
        Me.ProductionBindingNavigator.PerformLayout()
        CType(Me.ProductionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnanalysis As System.Windows.Forms.Button
    Friend WithEvents Btnbk As System.Windows.Forms.Button
    Friend WithEvents Lejo_DB_2DataSet As LEJO_Farm_Management_System_2.Lejo_DB_2DataSet
    Friend WithEvents ProductionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductionTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.ProductionTableAdapter
    Friend WithEvents TableAdapterManager As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnlogout As System.Windows.Forms.Button
End Class
