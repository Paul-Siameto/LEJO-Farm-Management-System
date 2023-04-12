<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Production
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
        Dim Farm_NumberLabel As System.Windows.Forms.Label
        Dim Farm_IDLabel As System.Windows.Forms.Label
        Dim Crop_NameLabel As System.Windows.Forms.Label
        Dim Harvest_Amount_Kgs_Label As System.Windows.Forms.Label
        Dim Harvest_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Production))
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
        Me.Farm_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Farm_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Crop_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Harvest_Amount_Kgs_TextBox = New System.Windows.Forms.TextBox()
        Me.Harvest_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProductionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Farm_NumberLabel = New System.Windows.Forms.Label()
        Farm_IDLabel = New System.Windows.Forms.Label()
        Crop_NameLabel = New System.Windows.Forms.Label()
        Harvest_Amount_Kgs_Label = New System.Windows.Forms.Label()
        Harvest_DateLabel = New System.Windows.Forms.Label()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductionBindingNavigator.SuspendLayout()
        CType(Me.ProductionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Farm_NumberLabel
        '
        Farm_NumberLabel.AutoSize = True
        Farm_NumberLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Farm_NumberLabel.Location = New System.Drawing.Point(27, 45)
        Farm_NumberLabel.Name = "Farm_NumberLabel"
        Farm_NumberLabel.Size = New System.Drawing.Size(99, 16)
        Farm_NumberLabel.TabIndex = 1
        Farm_NumberLabel.Text = "Farm Number:"
        '
        'Farm_IDLabel
        '
        Farm_IDLabel.AutoSize = True
        Farm_IDLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Farm_IDLabel.Location = New System.Drawing.Point(27, 88)
        Farm_IDLabel.Name = "Farm_IDLabel"
        Farm_IDLabel.Size = New System.Drawing.Size(64, 16)
        Farm_IDLabel.TabIndex = 3
        Farm_IDLabel.Text = "Farm ID:"
        '
        'Crop_NameLabel
        '
        Crop_NameLabel.AutoSize = True
        Crop_NameLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Crop_NameLabel.Location = New System.Drawing.Point(27, 129)
        Crop_NameLabel.Name = "Crop_NameLabel"
        Crop_NameLabel.Size = New System.Drawing.Size(85, 16)
        Crop_NameLabel.TabIndex = 5
        Crop_NameLabel.Text = "Crop Name:"
        '
        'Harvest_Amount_Kgs_Label
        '
        Harvest_Amount_Kgs_Label.AutoSize = True
        Harvest_Amount_Kgs_Label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Harvest_Amount_Kgs_Label.Location = New System.Drawing.Point(27, 170)
        Harvest_Amount_Kgs_Label.Name = "Harvest_Amount_Kgs_Label"
        Harvest_Amount_Kgs_Label.Size = New System.Drawing.Size(155, 16)
        Harvest_Amount_Kgs_Label.TabIndex = 7
        Harvest_Amount_Kgs_Label.Text = "Harvest Amount(Kgs):"
        '
        'Harvest_DateLabel
        '
        Harvest_DateLabel.AutoSize = True
        Harvest_DateLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Harvest_DateLabel.Location = New System.Drawing.Point(27, 215)
        Harvest_DateLabel.Name = "Harvest_DateLabel"
        Harvest_DateLabel.Size = New System.Drawing.Size(101, 16)
        Harvest_DateLabel.TabIndex = 9
        Harvest_DateLabel.Text = "Harvest Date:"
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
        Me.ProductionBindingNavigator.Size = New System.Drawing.Size(986, 25)
        Me.ProductionBindingNavigator.TabIndex = 0
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
        'Farm_NumberTextBox
        '
        Me.Farm_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductionBindingSource, "Farm Number", True))
        Me.Farm_NumberTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Farm_NumberTextBox.Location = New System.Drawing.Point(188, 45)
        Me.Farm_NumberTextBox.Name = "Farm_NumberTextBox"
        Me.Farm_NumberTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Farm_NumberTextBox.TabIndex = 2
        '
        'Farm_IDTextBox
        '
        Me.Farm_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductionBindingSource, "Farm ID", True))
        Me.Farm_IDTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Farm_IDTextBox.Location = New System.Drawing.Point(188, 88)
        Me.Farm_IDTextBox.Name = "Farm_IDTextBox"
        Me.Farm_IDTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Farm_IDTextBox.TabIndex = 4
        '
        'Crop_NameTextBox
        '
        Me.Crop_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductionBindingSource, "Crop Name", True))
        Me.Crop_NameTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Crop_NameTextBox.Location = New System.Drawing.Point(188, 129)
        Me.Crop_NameTextBox.Name = "Crop_NameTextBox"
        Me.Crop_NameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Crop_NameTextBox.TabIndex = 6
        '
        'Harvest_Amount_Kgs_TextBox
        '
        Me.Harvest_Amount_Kgs_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductionBindingSource, "Harvest Amount(Kgs)", True))
        Me.Harvest_Amount_Kgs_TextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harvest_Amount_Kgs_TextBox.Location = New System.Drawing.Point(188, 170)
        Me.Harvest_Amount_Kgs_TextBox.Name = "Harvest_Amount_Kgs_TextBox"
        Me.Harvest_Amount_Kgs_TextBox.Size = New System.Drawing.Size(200, 23)
        Me.Harvest_Amount_Kgs_TextBox.TabIndex = 8
        '
        'Harvest_DateDateTimePicker
        '
        Me.Harvest_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductionBindingSource, "Harvest Date", True))
        Me.Harvest_DateDateTimePicker.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harvest_DateDateTimePicker.Location = New System.Drawing.Point(188, 215)
        Me.Harvest_DateDateTimePicker.Name = "Harvest_DateDateTimePicker"
        Me.Harvest_DateDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.Harvest_DateDateTimePicker.TabIndex = 10
        '
        'ProductionDataGridView
        '
        Me.ProductionDataGridView.AutoGenerateColumns = False
        Me.ProductionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProductionDataGridView.DataSource = Me.ProductionBindingSource
        Me.ProductionDataGridView.Location = New System.Drawing.Point(410, 45)
        Me.ProductionDataGridView.Name = "ProductionDataGridView"
        Me.ProductionDataGridView.Size = New System.Drawing.Size(547, 373)
        Me.ProductionDataGridView.TabIndex = 11
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
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Btnadd)
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Btndelete)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 160)
        Me.Panel1.TabIndex = 20
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(211, 97)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 43)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.White
        Me.Btnadd.FlatAppearance.BorderSize = 0
        Me.Btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btnadd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.Location = New System.Drawing.Point(30, 28)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(138, 43)
        Me.Btnadd.TabIndex = 14
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.White
        Me.Btnsave.FlatAppearance.BorderSize = 0
        Me.Btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btnsave.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.Location = New System.Drawing.Point(211, 28)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(130, 43)
        Me.Btnsave.TabIndex = 15
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.White
        Me.Btndelete.FlatAppearance.BorderSize = 0
        Me.Btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btndelete.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(30, 97)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(138, 43)
        Me.Btndelete.TabIndex = 16
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Production
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(986, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProductionDataGridView)
        Me.Controls.Add(Farm_NumberLabel)
        Me.Controls.Add(Me.Farm_NumberTextBox)
        Me.Controls.Add(Farm_IDLabel)
        Me.Controls.Add(Me.Farm_IDTextBox)
        Me.Controls.Add(Crop_NameLabel)
        Me.Controls.Add(Me.Crop_NameTextBox)
        Me.Controls.Add(Harvest_Amount_Kgs_Label)
        Me.Controls.Add(Me.Harvest_Amount_Kgs_TextBox)
        Me.Controls.Add(Harvest_DateLabel)
        Me.Controls.Add(Me.Harvest_DateDateTimePicker)
        Me.Controls.Add(Me.ProductionBindingNavigator)
        Me.Name = "Production"
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
    Friend WithEvents Farm_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Farm_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Crop_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Harvest_Amount_Kgs_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Harvest_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProductionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
End Class
