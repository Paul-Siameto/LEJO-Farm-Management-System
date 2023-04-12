<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Owners
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
        Dim Owner_NumberLabel As System.Windows.Forms.Label
        Dim Owner_IDLabel As System.Windows.Forms.Label
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Mobile_NumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Owners))
        Me.Lejo_DB_2DataSet = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSet()
        Me.OwnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OwnerTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.OwnerTableAdapter()
        Me.TableAdapterManager = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager()
        Me.OwnerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OwnerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Owner_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Owner_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.OwnerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Owner_NumberLabel = New System.Windows.Forms.Label()
        Owner_IDLabel = New System.Windows.Forms.Label()
        Full_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Mobile_NumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OwnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OwnerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OwnerBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.OwnerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Owner_NumberLabel
        '
        Owner_NumberLabel.AutoSize = True
        Owner_NumberLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Owner_NumberLabel.Location = New System.Drawing.Point(13, 74)
        Owner_NumberLabel.Name = "Owner_NumberLabel"
        Owner_NumberLabel.Size = New System.Drawing.Size(110, 16)
        Owner_NumberLabel.TabIndex = 1
        Owner_NumberLabel.Text = "Owner Number:"
        '
        'Owner_IDLabel
        '
        Owner_IDLabel.AutoSize = True
        Owner_IDLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Owner_IDLabel.Location = New System.Drawing.Point(13, 115)
        Owner_IDLabel.Name = "Owner_IDLabel"
        Owner_IDLabel.Size = New System.Drawing.Size(75, 16)
        Owner_IDLabel.TabIndex = 3
        Owner_IDLabel.Text = "Owner ID:"
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.Location = New System.Drawing.Point(13, 160)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(77, 16)
        Full_NameLabel.TabIndex = 5
        Full_NameLabel.Text = "Full Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(15, 204)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(60, 16)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'Mobile_NumberLabel
        '
        Mobile_NumberLabel.AutoSize = True
        Mobile_NumberLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NumberLabel.Location = New System.Drawing.Point(13, 248)
        Mobile_NumberLabel.Name = "Mobile_NumberLabel"
        Mobile_NumberLabel.Size = New System.Drawing.Size(109, 16)
        Mobile_NumberLabel.TabIndex = 9
        Mobile_NumberLabel.Text = "Mobile Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(15, 288)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(47, 16)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "Email:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(13, 333)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(66, 16)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "Address:"
        '
        'Lejo_DB_2DataSet
        '
        Me.Lejo_DB_2DataSet.DataSetName = "Lejo_DB_2DataSet"
        Me.Lejo_DB_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OwnerBindingSource
        '
        Me.OwnerBindingSource.DataMember = "Owner"
        Me.OwnerBindingSource.DataSource = Me.Lejo_DB_2DataSet
        '
        'OwnerTableAdapter
        '
        Me.OwnerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_keepingTableAdapter = Nothing
        Me.TableAdapterManager.FarmTableAdapter = Nothing
        Me.TableAdapterManager.OwnerTableAdapter = Me.OwnerTableAdapter
        Me.TableAdapterManager.ProductionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OwnerBindingNavigator
        '
        Me.OwnerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OwnerBindingNavigator.BindingSource = Me.OwnerBindingSource
        Me.OwnerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OwnerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OwnerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OwnerBindingNavigatorSaveItem})
        Me.OwnerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OwnerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OwnerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OwnerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OwnerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OwnerBindingNavigator.Name = "OwnerBindingNavigator"
        Me.OwnerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OwnerBindingNavigator.Size = New System.Drawing.Size(1090, 25)
        Me.OwnerBindingNavigator.TabIndex = 0
        Me.OwnerBindingNavigator.Text = "BindingNavigator1"
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
        'OwnerBindingNavigatorSaveItem
        '
        Me.OwnerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OwnerBindingNavigatorSaveItem.Image = CType(resources.GetObject("OwnerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OwnerBindingNavigatorSaveItem.Name = "OwnerBindingNavigatorSaveItem"
        Me.OwnerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OwnerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Owner_NumberTextBox
        '
        Me.Owner_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OwnerBindingSource, "Owner Number", True))
        Me.Owner_NumberTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Owner_NumberTextBox.Location = New System.Drawing.Point(128, 71)
        Me.Owner_NumberTextBox.Name = "Owner_NumberTextBox"
        Me.Owner_NumberTextBox.Size = New System.Drawing.Size(179, 23)
        Me.Owner_NumberTextBox.TabIndex = 2
        '
        'Owner_IDTextBox
        '
        Me.Owner_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OwnerBindingSource, "Owner ID", True))
        Me.Owner_IDTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Owner_IDTextBox.Location = New System.Drawing.Point(128, 112)
        Me.Owner_IDTextBox.Name = "Owner_IDTextBox"
        Me.Owner_IDTextBox.Size = New System.Drawing.Size(179, 23)
        Me.Owner_IDTextBox.TabIndex = 4
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OwnerBindingSource, "Full Name", True))
        Me.Full_NameTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(128, 157)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(179, 23)
        Me.Full_NameTextBox.TabIndex = 6
        '
        'Mobile_NumberTextBox
        '
        Me.Mobile_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OwnerBindingSource, "Mobile Number", True))
        Me.Mobile_NumberTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_NumberTextBox.Location = New System.Drawing.Point(128, 245)
        Me.Mobile_NumberTextBox.Name = "Mobile_NumberTextBox"
        Me.Mobile_NumberTextBox.Size = New System.Drawing.Size(179, 23)
        Me.Mobile_NumberTextBox.TabIndex = 10
        Me.Mobile_NumberTextBox.Text = "+254"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OwnerBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(128, 286)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(179, 23)
        Me.EmailTextBox.TabIndex = 12
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OwnerBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(128, 330)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(179, 23)
        Me.AddressTextBox.TabIndex = 14
        '
        'Btnback
        '
        Me.Btnback.BackColor = System.Drawing.Color.White
        Me.Btnback.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnback.Location = New System.Drawing.Point(166, 82)
        Me.Btnback.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(111, 43)
        Me.Btnback.TabIndex = 22
        Me.Btnback.Text = "Back"
        Me.Btnback.UseVisualStyleBackColor = False
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.White
        Me.Btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.Location = New System.Drawing.Point(166, 13)
        Me.Btnsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(111, 43)
        Me.Btnsave.TabIndex = 21
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Btndelete)
        Me.Panel1.Controls.Add(Me.Btnadd)
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Btnback)
        Me.Panel1.Location = New System.Drawing.Point(12, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 144)
        Me.Panel1.TabIndex = 23
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.White
        Me.Btndelete.FlatAppearance.BorderSize = 0
        Me.Btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btndelete.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(22, 82)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(119, 43)
        Me.Btndelete.TabIndex = 24
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.White
        Me.Btnadd.FlatAppearance.BorderSize = 0
        Me.Btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btnadd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.Location = New System.Drawing.Point(22, 13)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(119, 43)
        Me.Btnadd.TabIndex = 23
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'OwnerDataGridView
        '
        Me.OwnerDataGridView.AutoGenerateColumns = False
        Me.OwnerDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.OwnerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OwnerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.OwnerDataGridView.DataSource = Me.OwnerBindingSource
        Me.OwnerDataGridView.GridColor = System.Drawing.Color.Cornsilk
        Me.OwnerDataGridView.Location = New System.Drawing.Point(332, 71)
        Me.OwnerDataGridView.Name = "OwnerDataGridView"
        Me.OwnerDataGridView.Size = New System.Drawing.Size(737, 460)
        Me.OwnerDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Owner Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Owner Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Owner ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Owner ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Full Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Mobile Number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Mobile Number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OwnerBindingSource, "Gender", True))
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 204)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 24)
        Me.ComboBox1.TabIndex = 24
        '
        'Owners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(1090, 555)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.OwnerDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Owner_NumberLabel)
        Me.Controls.Add(Me.Owner_NumberTextBox)
        Me.Controls.Add(Owner_IDLabel)
        Me.Controls.Add(Me.Owner_IDTextBox)
        Me.Controls.Add(Full_NameLabel)
        Me.Controls.Add(Me.Full_NameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Mobile_NumberLabel)
        Me.Controls.Add(Me.Mobile_NumberTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.OwnerBindingNavigator)
        Me.Name = "Owners"
        Me.Text = "Owners"
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OwnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OwnerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OwnerBindingNavigator.ResumeLayout(False)
        Me.OwnerBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.OwnerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lejo_DB_2DataSet As LEJO_Farm_Management_System_2.Lejo_DB_2DataSet
    Friend WithEvents OwnerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OwnerTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.OwnerTableAdapter
    Friend WithEvents TableAdapterManager As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents OwnerBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents OwnerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Owner_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Owner_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Full_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mobile_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Btnback As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents OwnerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
