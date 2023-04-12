<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Farms
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
        Dim Rec_NoLabel As System.Windows.Forms.Label
        Dim Farm_IdLabel As System.Windows.Forms.Label
        Dim Owner_IDLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Size_Acres_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Farms))
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
        Me.Rec_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Farm_IdTextBox = New System.Windows.Forms.TextBox()
        Me.Owner_IDTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Size_Acres_TextBox = New System.Windows.Forms.TextBox()
        Me.FarmDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Rec_NoLabel = New System.Windows.Forms.Label()
        Farm_IdLabel = New System.Windows.Forms.Label()
        Owner_IDLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Size_Acres_Label = New System.Windows.Forms.Label()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FarmBindingNavigator.SuspendLayout()
        CType(Me.FarmDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rec_NoLabel
        '
        Rec_NoLabel.AutoSize = True
        Rec_NoLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rec_NoLabel.Location = New System.Drawing.Point(25, 44)
        Rec_NoLabel.Name = "Rec_NoLabel"
        Rec_NoLabel.Size = New System.Drawing.Size(60, 16)
        Rec_NoLabel.TabIndex = 1
        Rec_NoLabel.Text = "Rec No:"
        '
        'Farm_IdLabel
        '
        Farm_IdLabel.AutoSize = True
        Farm_IdLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Farm_IdLabel.Location = New System.Drawing.Point(25, 89)
        Farm_IdLabel.Name = "Farm_IdLabel"
        Farm_IdLabel.Size = New System.Drawing.Size(63, 16)
        Farm_IdLabel.TabIndex = 3
        Farm_IdLabel.Text = "Farm Id:"
        '
        'Owner_IDLabel
        '
        Owner_IDLabel.AutoSize = True
        Owner_IDLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Owner_IDLabel.Location = New System.Drawing.Point(25, 136)
        Owner_IDLabel.Name = "Owner_IDLabel"
        Owner_IDLabel.Size = New System.Drawing.Size(75, 16)
        Owner_IDLabel.TabIndex = 5
        Owner_IDLabel.Text = "Owner ID:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(25, 184)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(70, 16)
        LocationLabel.TabIndex = 7
        LocationLabel.Text = "Location:"
        '
        'Size_Acres_Label
        '
        Size_Acres_Label.AutoSize = True
        Size_Acres_Label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Size_Acres_Label.Location = New System.Drawing.Point(25, 230)
        Size_Acres_Label.Name = "Size_Acres_Label"
        Size_Acres_Label.Size = New System.Drawing.Size(90, 16)
        Size_Acres_Label.TabIndex = 9
        Size_Acres_Label.Text = "Size(Acres):"
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
        Me.FarmBindingNavigator.Size = New System.Drawing.Size(904, 25)
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
        'Rec_NoTextBox
        '
        Me.Rec_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FarmBindingSource, "Rec No", True))
        Me.Rec_NoTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rec_NoTextBox.Location = New System.Drawing.Point(127, 41)
        Me.Rec_NoTextBox.Name = "Rec_NoTextBox"
        Me.Rec_NoTextBox.Size = New System.Drawing.Size(202, 23)
        Me.Rec_NoTextBox.TabIndex = 2
        '
        'Farm_IdTextBox
        '
        Me.Farm_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FarmBindingSource, "Farm Id", True))
        Me.Farm_IdTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Farm_IdTextBox.Location = New System.Drawing.Point(127, 86)
        Me.Farm_IdTextBox.Name = "Farm_IdTextBox"
        Me.Farm_IdTextBox.Size = New System.Drawing.Size(202, 23)
        Me.Farm_IdTextBox.TabIndex = 4
        '
        'Owner_IDTextBox
        '
        Me.Owner_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FarmBindingSource, "Owner ID", True))
        Me.Owner_IDTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Owner_IDTextBox.Location = New System.Drawing.Point(127, 133)
        Me.Owner_IDTextBox.Name = "Owner_IDTextBox"
        Me.Owner_IDTextBox.Size = New System.Drawing.Size(202, 23)
        Me.Owner_IDTextBox.TabIndex = 6
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FarmBindingSource, "Location", True))
        Me.LocationTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(127, 177)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(202, 23)
        Me.LocationTextBox.TabIndex = 8
        '
        'Size_Acres_TextBox
        '
        Me.Size_Acres_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FarmBindingSource, "Size(Acres)", True))
        Me.Size_Acres_TextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_Acres_TextBox.Location = New System.Drawing.Point(127, 227)
        Me.Size_Acres_TextBox.Name = "Size_Acres_TextBox"
        Me.Size_Acres_TextBox.Size = New System.Drawing.Size(202, 23)
        Me.Size_Acres_TextBox.TabIndex = 10
        '
        'FarmDataGridView
        '
        Me.FarmDataGridView.AutoGenerateColumns = False
        Me.FarmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FarmDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.FarmDataGridView.DataSource = Me.FarmBindingSource
        Me.FarmDataGridView.Location = New System.Drawing.Point(351, 41)
        Me.FarmDataGridView.Name = "FarmDataGridView"
        Me.FarmDataGridView.Size = New System.Drawing.Size(538, 390)
        Me.FarmDataGridView.TabIndex = 11
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
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Btnadd)
        Me.Panel1.Controls.Add(Me.Btndelete)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(28, 289)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 176)
        Me.Panel1.TabIndex = 22
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.White
        Me.Btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btnsave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.Location = New System.Drawing.Point(173, 30)
        Me.Btnsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(113, 42)
        Me.Btnsave.TabIndex = 15
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.White
        Me.Btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btnadd.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.Location = New System.Drawing.Point(21, 30)
        Me.Btnadd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(116, 42)
        Me.Btnadd.TabIndex = 14
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.White
        Me.Btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btndelete.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(21, 98)
        Me.Btndelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(116, 42)
        Me.Btndelete.TabIndex = 16
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(173, 98)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 42)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Farms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(904, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FarmDataGridView)
        Me.Controls.Add(Rec_NoLabel)
        Me.Controls.Add(Me.Rec_NoTextBox)
        Me.Controls.Add(Farm_IdLabel)
        Me.Controls.Add(Me.Farm_IdTextBox)
        Me.Controls.Add(Owner_IDLabel)
        Me.Controls.Add(Me.Owner_IDTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Size_Acres_Label)
        Me.Controls.Add(Me.Size_Acres_TextBox)
        Me.Controls.Add(Me.FarmBindingNavigator)
        Me.Name = "Farms"
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
    Friend WithEvents Rec_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Farm_IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Owner_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Size_Acres_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents FarmDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
