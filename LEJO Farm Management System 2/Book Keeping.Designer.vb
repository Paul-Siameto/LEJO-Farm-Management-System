<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_Keeping
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
        Dim Total_ExpenseLabel As System.Windows.Forms.Label
        Dim SalesLabel As System.Windows.Forms.Label
        Dim Profit_Ksh_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book_Keeping))
        Me.Lejo_DB_2DataSet = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSet()
        Me.Book_keepingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_keepingTableAdapter = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.Book_keepingTableAdapter()
        Me.TableAdapterManager = New LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager()
        Me.Book_keepingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Book_keepingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Farm_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Farm_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Total_ExpenseTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTextBox = New System.Windows.Forms.TextBox()
        Me.Profit_Ksh_TextBox = New System.Windows.Forms.TextBox()
        Me.Book_keepingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.Btncalc = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Farm_NumberLabel = New System.Windows.Forms.Label()
        Farm_IDLabel = New System.Windows.Forms.Label()
        Total_ExpenseLabel = New System.Windows.Forms.Label()
        SalesLabel = New System.Windows.Forms.Label()
        Profit_Ksh_Label = New System.Windows.Forms.Label()
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_keepingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_keepingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Book_keepingBindingNavigator.SuspendLayout()
        CType(Me.Book_keepingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Farm_NumberLabel
        '
        Farm_NumberLabel.AutoSize = True
        Farm_NumberLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Farm_NumberLabel.Location = New System.Drawing.Point(18, 51)
        Farm_NumberLabel.Name = "Farm_NumberLabel"
        Farm_NumberLabel.Size = New System.Drawing.Size(99, 16)
        Farm_NumberLabel.TabIndex = 1
        Farm_NumberLabel.Text = "Farm Number:"
        '
        'Farm_IDLabel
        '
        Farm_IDLabel.AutoSize = True
        Farm_IDLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Farm_IDLabel.Location = New System.Drawing.Point(18, 94)
        Farm_IDLabel.Name = "Farm_IDLabel"
        Farm_IDLabel.Size = New System.Drawing.Size(64, 16)
        Farm_IDLabel.TabIndex = 3
        Farm_IDLabel.Text = "Farm ID:"
        '
        'Total_ExpenseLabel
        '
        Total_ExpenseLabel.AutoSize = True
        Total_ExpenseLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_ExpenseLabel.Location = New System.Drawing.Point(18, 136)
        Total_ExpenseLabel.Name = "Total_ExpenseLabel"
        Total_ExpenseLabel.Size = New System.Drawing.Size(106, 16)
        Total_ExpenseLabel.TabIndex = 5
        Total_ExpenseLabel.Text = "Total Expense:"
        '
        'SalesLabel
        '
        SalesLabel.AutoSize = True
        SalesLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalesLabel.Location = New System.Drawing.Point(18, 174)
        SalesLabel.Name = "SalesLabel"
        SalesLabel.Size = New System.Drawing.Size(49, 16)
        SalesLabel.TabIndex = 7
        SalesLabel.Text = "Sales:"
        '
        'Profit_Ksh_Label
        '
        Profit_Ksh_Label.AutoSize = True
        Profit_Ksh_Label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Profit_Ksh_Label.Location = New System.Drawing.Point(18, 214)
        Profit_Ksh_Label.Name = "Profit_Ksh_Label"
        Profit_Ksh_Label.Size = New System.Drawing.Size(84, 16)
        Profit_Ksh_Label.TabIndex = 9
        Profit_Ksh_Label.Text = "Profit(Ksh):"
        '
        'Lejo_DB_2DataSet
        '
        Me.Lejo_DB_2DataSet.DataSetName = "Lejo_DB_2DataSet"
        Me.Lejo_DB_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Book_keepingBindingSource
        '
        Me.Book_keepingBindingSource.DataMember = "Book keeping"
        Me.Book_keepingBindingSource.DataSource = Me.Lejo_DB_2DataSet
        '
        'Book_keepingTableAdapter
        '
        Me.Book_keepingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Book_keepingTableAdapter = Me.Book_keepingTableAdapter
        Me.TableAdapterManager.FarmTableAdapter = Nothing
        Me.TableAdapterManager.OwnerTableAdapter = Nothing
        Me.TableAdapterManager.ProductionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Book_keepingBindingNavigator
        '
        Me.Book_keepingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Book_keepingBindingNavigator.BindingSource = Me.Book_keepingBindingSource
        Me.Book_keepingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Book_keepingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Book_keepingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Book_keepingBindingNavigatorSaveItem})
        Me.Book_keepingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Book_keepingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Book_keepingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Book_keepingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Book_keepingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Book_keepingBindingNavigator.Name = "Book_keepingBindingNavigator"
        Me.Book_keepingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Book_keepingBindingNavigator.Size = New System.Drawing.Size(966, 25)
        Me.Book_keepingBindingNavigator.TabIndex = 0
        Me.Book_keepingBindingNavigator.Text = "BindingNavigator1"
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
        'Book_keepingBindingNavigatorSaveItem
        '
        Me.Book_keepingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Book_keepingBindingNavigatorSaveItem.Image = CType(resources.GetObject("Book_keepingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Book_keepingBindingNavigatorSaveItem.Name = "Book_keepingBindingNavigatorSaveItem"
        Me.Book_keepingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Book_keepingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Farm_NumberTextBox
        '
        Me.Farm_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_keepingBindingSource, "Farm Number", True))
        Me.Farm_NumberTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Farm_NumberTextBox.Location = New System.Drawing.Point(145, 48)
        Me.Farm_NumberTextBox.Name = "Farm_NumberTextBox"
        Me.Farm_NumberTextBox.Size = New System.Drawing.Size(216, 23)
        Me.Farm_NumberTextBox.TabIndex = 2
        '
        'Farm_IDTextBox
        '
        Me.Farm_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_keepingBindingSource, "Farm ID", True))
        Me.Farm_IDTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Farm_IDTextBox.Location = New System.Drawing.Point(145, 91)
        Me.Farm_IDTextBox.Name = "Farm_IDTextBox"
        Me.Farm_IDTextBox.Size = New System.Drawing.Size(216, 23)
        Me.Farm_IDTextBox.TabIndex = 4
        '
        'Total_ExpenseTextBox
        '
        Me.Total_ExpenseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_keepingBindingSource, "Total Expense", True))
        Me.Total_ExpenseTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_ExpenseTextBox.Location = New System.Drawing.Point(145, 133)
        Me.Total_ExpenseTextBox.Name = "Total_ExpenseTextBox"
        Me.Total_ExpenseTextBox.Size = New System.Drawing.Size(216, 23)
        Me.Total_ExpenseTextBox.TabIndex = 6
        '
        'SalesTextBox
        '
        Me.SalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_keepingBindingSource, "Sales", True))
        Me.SalesTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesTextBox.Location = New System.Drawing.Point(145, 171)
        Me.SalesTextBox.Name = "SalesTextBox"
        Me.SalesTextBox.Size = New System.Drawing.Size(216, 23)
        Me.SalesTextBox.TabIndex = 8
        '
        'Profit_Ksh_TextBox
        '
        Me.Profit_Ksh_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_keepingBindingSource, "Profit(Ksh)", True))
        Me.Profit_Ksh_TextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profit_Ksh_TextBox.Location = New System.Drawing.Point(145, 211)
        Me.Profit_Ksh_TextBox.Name = "Profit_Ksh_TextBox"
        Me.Profit_Ksh_TextBox.Size = New System.Drawing.Size(216, 23)
        Me.Profit_Ksh_TextBox.TabIndex = 10
        '
        'Book_keepingDataGridView
        '
        Me.Book_keepingDataGridView.AutoGenerateColumns = False
        Me.Book_keepingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Book_keepingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Book_keepingDataGridView.DataSource = Me.Book_keepingBindingSource
        Me.Book_keepingDataGridView.Location = New System.Drawing.Point(409, 50)
        Me.Book_keepingDataGridView.Name = "Book_keepingDataGridView"
        Me.Book_keepingDataGridView.Size = New System.Drawing.Size(542, 365)
        Me.Book_keepingDataGridView.TabIndex = 11
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Total Expense"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Total Expense"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sales"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sales"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Profit(Ksh)"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Profit(Ksh)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Btnadd)
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Btnback)
        Me.Panel1.Controls.Add(Me.Btncalc)
        Me.Panel1.Controls.Add(Me.Btndelete)
        Me.Panel1.Location = New System.Drawing.Point(21, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 195)
        Me.Panel1.TabIndex = 16
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.White
        Me.Btnadd.FlatAppearance.BorderSize = 0
        Me.Btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnadd.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.Location = New System.Drawing.Point(19, 12)
        Me.Btnadd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(119, 50)
        Me.Btnadd.TabIndex = 9
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.White
        Me.Btnsave.FlatAppearance.BorderSize = 0
        Me.Btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnsave.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.Location = New System.Drawing.Point(19, 70)
        Me.Btnsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(119, 49)
        Me.Btnsave.TabIndex = 10
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Btnback
        '
        Me.Btnback.BackColor = System.Drawing.Color.White
        Me.Btnback.FlatAppearance.BorderSize = 0
        Me.Btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnback.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnback.Location = New System.Drawing.Point(19, 127)
        Me.Btnback.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(290, 50)
        Me.Btnback.TabIndex = 13
        Me.Btnback.Text = "Back"
        Me.Btnback.UseVisualStyleBackColor = False
        '
        'Btncalc
        '
        Me.Btncalc.BackColor = System.Drawing.Color.White
        Me.Btncalc.FlatAppearance.BorderSize = 0
        Me.Btncalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncalc.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncalc.Location = New System.Drawing.Point(187, 12)
        Me.Btncalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btncalc.Name = "Btncalc"
        Me.Btncalc.Size = New System.Drawing.Size(122, 49)
        Me.Btncalc.TabIndex = 14
        Me.Btncalc.Text = "Calculate"
        Me.Btncalc.UseVisualStyleBackColor = False
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.White
        Me.Btndelete.FlatAppearance.BorderSize = 0
        Me.Btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btndelete.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(187, 70)
        Me.Btndelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(122, 49)
        Me.Btndelete.TabIndex = 11
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Book_Keeping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(966, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Book_keepingDataGridView)
        Me.Controls.Add(Farm_NumberLabel)
        Me.Controls.Add(Me.Farm_NumberTextBox)
        Me.Controls.Add(Farm_IDLabel)
        Me.Controls.Add(Me.Farm_IDTextBox)
        Me.Controls.Add(Total_ExpenseLabel)
        Me.Controls.Add(Me.Total_ExpenseTextBox)
        Me.Controls.Add(SalesLabel)
        Me.Controls.Add(Me.SalesTextBox)
        Me.Controls.Add(Profit_Ksh_Label)
        Me.Controls.Add(Me.Profit_Ksh_TextBox)
        Me.Controls.Add(Me.Book_keepingBindingNavigator)
        Me.Name = "Book_Keeping"
        Me.Text = "Book_Keeping"
        CType(Me.Lejo_DB_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_keepingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_keepingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Book_keepingBindingNavigator.ResumeLayout(False)
        Me.Book_keepingBindingNavigator.PerformLayout()
        CType(Me.Book_keepingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lejo_DB_2DataSet As LEJO_Farm_Management_System_2.Lejo_DB_2DataSet
    Friend WithEvents Book_keepingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_keepingTableAdapter As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.Book_keepingTableAdapter
    Friend WithEvents TableAdapterManager As LEJO_Farm_Management_System_2.Lejo_DB_2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Book_keepingBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Book_keepingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Farm_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Farm_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_ExpenseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Profit_Ksh_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Book_keepingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Btnback As System.Windows.Forms.Button
    Friend WithEvents Btncalc As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
End Class
