<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MFarm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MFarm))
        Me.Lejo_DB_2DataSet = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSet()
        Me.FarmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.FarmTableAdapter()
        Me.TableAdapterManager = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager()
        Me.FarmBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FarmBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FarmDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnlogout = New System.Windows.Forms.Button()
        Me.Btnreport = New System.Windows.Forms.Button()
        Me.Btnproduction = New System.Windows.Forms.Button()
        Me.Btnanalysis = New System.Windows.Forms.Button()
        Me.Btnbk = New System.Windows.Forms.Button()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FarmBindingNavigator.SuspendLayout()
        CType(Me.FarmDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lejo_DB_2DataSet
        '
        Me.Lejo_DB_2DataSet.DataSetName = "Lejo_DB_2DataSet"
        Me.Lejo_DB_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FarmBindingSource
        '
        Me.FarmBindingSource.DataMember = "Farm"
        Me.FarmBindingSource.DataSource = Me.Lejo_DB_2DataSet
        '
        'FarmTableAdapter
        '
        Me.FarmTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_keepingTableAdapter = Nothing
        Me.TableAdapterManager.FarmTableAdapter = Me.FarmTableAdapter
        Me.TableAdapterManager.OwnerTableAdapter = Nothing
        Me.TableAdapterManager.ProductionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FarmBindingNavigator
        '
        Me.FarmBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FarmBindingNavigator.BindingSource = Me.FarmBindingSource
        Me.FarmBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FarmBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FarmBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FarmBindingNavigatorSaveItem})
        Me.FarmBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FarmBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FarmBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FarmBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FarmBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FarmBindingNavigator.Name = "FarmBindingNavigator"
        Me.FarmBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FarmBindingNavigator.Size = New System.Drawing.Size(779, 25)
        Me.FarmBindingNavigator.TabIndex = 0
        Me.FarmBindingNavigator.Text = "BindingNavigator1"
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
        'FarmBindingNavigatorSaveItem
        '
        Me.FarmBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FarmBindingNavigatorSaveItem.Image = CType(resources.GetObject("FarmBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FarmBindingNavigatorSaveItem.Name = "FarmBindingNavigatorSaveItem"
        Me.FarmBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FarmBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FarmDataGridView
        '
        Me.FarmDataGridView.AutoGenerateColumns = False
        Me.FarmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FarmDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.FarmDataGridView.DataSource = Me.FarmBindingSource
        Me.FarmDataGridView.Location = New System.Drawing.Point(12, 49)
        Me.FarmDataGridView.Name = "FarmDataGridView"
        Me.FarmDataGridView.Size = New System.Drawing.Size(540, 362)
        Me.FarmDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Rec No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Rec No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Farm Id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Farm Id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Owner ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Owner ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Size(Acres)"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Size(Acres)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Btnlogout)
        Me.Panel1.Controls.Add(Me.Btnreport)
        Me.Panel1.Controls.Add(Me.Btnproduction)
        Me.Panel1.Controls.Add(Me.Btnanalysis)
        Me.Panel1.Controls.Add(Me.Btnbk)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(571, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 362)
        Me.Panel1.TabIndex = 8
        '
        'Btnlogout
        '
        Me.Btnlogout.BackColor = System.Drawing.Color.White
        Me.Btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnlogout.Location = New System.Drawing.Point(27, 290)
        Me.Btnlogout.Name = "Btnlogout"
        Me.Btnlogout.Size = New System.Drawing.Size(130, 45)
        Me.Btnlogout.TabIndex = 8
        Me.Btnlogout.Text = "Log out"
        Me.Btnlogout.UseVisualStyleBackColor = False
        '
        'Btnreport
        '
        Me.Btnreport.BackColor = System.Drawing.Color.White
        Me.Btnreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnreport.Location = New System.Drawing.Point(27, 223)
        Me.Btnreport.Name = "Btnreport"
        Me.Btnreport.Size = New System.Drawing.Size(130, 45)
        Me.Btnreport.TabIndex = 7
        Me.Btnreport.Text = "Report"
        Me.Btnreport.UseVisualStyleBackColor = False
        '
        'Btnproduction
        '
        Me.Btnproduction.BackColor = System.Drawing.Color.White
        Me.Btnproduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnproduction.Location = New System.Drawing.Point(27, 14)
        Me.Btnproduction.Name = "Btnproduction"
        Me.Btnproduction.Size = New System.Drawing.Size(130, 45)
        Me.Btnproduction.TabIndex = 4
        Me.Btnproduction.Text = "Production"
        Me.Btnproduction.UseVisualStyleBackColor = False
        '
        'Btnanalysis
        '
        Me.Btnanalysis.BackColor = System.Drawing.Color.White
        Me.Btnanalysis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnanalysis.Location = New System.Drawing.Point(27, 153)
        Me.Btnanalysis.Name = "Btnanalysis"
        Me.Btnanalysis.Size = New System.Drawing.Size(130, 45)
        Me.Btnanalysis.TabIndex = 5
        Me.Btnanalysis.Text = "Analysis"
        Me.Btnanalysis.UseVisualStyleBackColor = False
        '
        'Btnbk
        '
        Me.Btnbk.BackColor = System.Drawing.Color.White
        Me.Btnbk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnbk.Location = New System.Drawing.Point(27, 84)
        Me.Btnbk.Name = "Btnbk"
        Me.Btnbk.Size = New System.Drawing.Size(130, 45)
        Me.Btnbk.TabIndex = 6
        Me.Btnbk.Text = "Book Keeping"
        Me.Btnbk.UseVisualStyleBackColor = False
        '
        'MFarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(779, 478)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FarmDataGridView)
        Me.Controls.Add(Me.FarmBindingNavigator)
        Me.Name = "MFarm"
        Me.Text = "Farms"
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FarmBindingNavigator.ResumeLayout(False)
        Me.FarmBindingNavigator.PerformLayout()
        CType(Me.FarmDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lejo_DB_2DataSet As LEJO_Farm_Management_System_2.Lejo_DB_2DataSet
    Friend WithEvents FarmBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FarmTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.FarmTableAdapter
    Friend WithEvents TableAdapterManager As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents FarmBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FarmBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FarmDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnproduction As System.Windows.Forms.Button
    Friend WithEvents Btnanalysis As System.Windows.Forms.Button
    Friend WithEvents Btnbk As System.Windows.Forms.Button
    Friend WithEvents Btnreport As System.Windows.Forms.Button
    Friend WithEvents Btnlogout As System.Windows.Forms.Button
End Class
