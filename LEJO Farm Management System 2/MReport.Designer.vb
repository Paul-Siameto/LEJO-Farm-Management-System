<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MReport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtharvestamount = New System.Windows.Forms.TextBox()
        Me.Lblfarmid = New System.Windows.Forms.Label()
        Me.Lblharvestamount = New System.Windows.Forms.Label()
        Me.txtTextBox = New System.Windows.Forms.TextBox()
        Me.Lblcrop = New System.Windows.Forms.Label()
        Me.Txtfarmid = New System.Windows.Forms.TextBox()
        Me.Txtharvestdate = New System.Windows.Forms.TextBox()
        Me.Txtcropname = New System.Windows.Forms.TextBox()
        Me.Txtsales = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtprofit = New System.Windows.Forms.TextBox()
        Me.Lblsales = New System.Windows.Forms.Label()
        Me.Lblprofits = New System.Windows.Forms.Label()
        Me.Btnprint = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnbk = New System.Windows.Forms.Button()
        Me.Btnfarms = New System.Windows.Forms.Button()
        Me.Btnproduction = New System.Windows.Forms.Button()
        Me.Btnanalysis = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(394, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Remarks"
        '
        'Txtharvestamount
        '
        Me.Txtharvestamount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtharvestamount.Location = New System.Drawing.Point(171, 214)
        Me.Txtharvestamount.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtharvestamount.Name = "Txtharvestamount"
        Me.Txtharvestamount.Size = New System.Drawing.Size(183, 23)
        Me.Txtharvestamount.TabIndex = 36
        '
        'Lblfarmid
        '
        Me.Lblfarmid.AutoSize = True
        Me.Lblfarmid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfarmid.Location = New System.Drawing.Point(28, 119)
        Me.Lblfarmid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblfarmid.Name = "Lblfarmid"
        Me.Lblfarmid.Size = New System.Drawing.Size(59, 16)
        Me.Lblfarmid.TabIndex = 32
        Me.Lblfarmid.Text = "Farm ID:"
        '
        'Lblharvestamount
        '
        Me.Lblharvestamount.AutoSize = True
        Me.Lblharvestamount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblharvestamount.Location = New System.Drawing.Point(28, 223)
        Me.Lblharvestamount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblharvestamount.Name = "Lblharvestamount"
        Me.Lblharvestamount.Size = New System.Drawing.Size(104, 16)
        Me.Lblharvestamount.TabIndex = 33
        Me.Lblharvestamount.Text = "Harvest Amount:"
        '
        'txtTextBox
        '
        Me.txtTextBox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTextBox.Location = New System.Drawing.Point(397, 190)
        Me.txtTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTextBox.Multiline = True
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.Size = New System.Drawing.Size(321, 222)
        Me.txtTextBox.TabIndex = 44
        '
        'Lblcrop
        '
        Me.Lblcrop.AutoSize = True
        Me.Lblcrop.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcrop.Location = New System.Drawing.Point(28, 168)
        Me.Lblcrop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcrop.Name = "Lblcrop"
        Me.Lblcrop.Size = New System.Drawing.Size(77, 16)
        Me.Lblcrop.TabIndex = 34
        Me.Lblcrop.Text = "Crop Name:"
        '
        'Txtfarmid
        '
        Me.Txtfarmid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfarmid.Location = New System.Drawing.Point(171, 112)
        Me.Txtfarmid.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtfarmid.Name = "Txtfarmid"
        Me.Txtfarmid.Size = New System.Drawing.Size(183, 23)
        Me.Txtfarmid.TabIndex = 35
        '
        'Txtharvestdate
        '
        Me.Txtharvestdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtharvestdate.Location = New System.Drawing.Point(171, 271)
        Me.Txtharvestdate.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtharvestdate.Name = "Txtharvestdate"
        Me.Txtharvestdate.Size = New System.Drawing.Size(183, 23)
        Me.Txtharvestdate.TabIndex = 43
        '
        'Txtcropname
        '
        Me.Txtcropname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcropname.Location = New System.Drawing.Point(171, 159)
        Me.Txtcropname.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtcropname.Name = "Txtcropname"
        Me.Txtcropname.Size = New System.Drawing.Size(183, 23)
        Me.Txtcropname.TabIndex = 37
        '
        'Txtsales
        '
        Me.Txtsales.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtsales.Location = New System.Drawing.Point(171, 330)
        Me.Txtsales.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtsales.Name = "Txtsales"
        Me.Txtsales.Size = New System.Drawing.Size(183, 23)
        Me.Txtsales.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 281)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Harvest Date:"
        '
        'Txtprofit
        '
        Me.Txtprofit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtprofit.Location = New System.Drawing.Point(171, 389)
        Me.Txtprofit.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtprofit.Name = "Txtprofit"
        Me.Txtprofit.Size = New System.Drawing.Size(183, 23)
        Me.Txtprofit.TabIndex = 41
        '
        'Lblsales
        '
        Me.Lblsales.AutoSize = True
        Me.Lblsales.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsales.Location = New System.Drawing.Point(28, 339)
        Me.Lblsales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblsales.Name = "Lblsales"
        Me.Lblsales.Size = New System.Drawing.Size(44, 16)
        Me.Lblsales.TabIndex = 39
        Me.Lblsales.Text = "Sales:"
        '
        'Lblprofits
        '
        Me.Lblprofits.AutoSize = True
        Me.Lblprofits.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblprofits.Location = New System.Drawing.Point(28, 396)
        Me.Lblprofits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblprofits.Name = "Lblprofits"
        Me.Lblprofits.Size = New System.Drawing.Size(49, 16)
        Me.Lblprofits.TabIndex = 40
        Me.Lblprofits.Text = "Profits:"
        '
        'Btnprint
        '
        Me.Btnprint.BackColor = System.Drawing.Color.White
        Me.Btnprint.FlatAppearance.BorderSize = 0
        Me.Btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.Btnprint.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprint.Location = New System.Drawing.Point(18, 293)
        Me.Btnprint.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnprint.Name = "Btnprint"
        Me.Btnprint.Size = New System.Drawing.Size(124, 47)
        Me.Btnprint.TabIndex = 47
        Me.Btnprint.Text = "Print"
        Me.Btnprint.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Btnbk)
        Me.Panel1.Controls.Add(Me.Btnfarms)
        Me.Panel1.Controls.Add(Me.Btnproduction)
        Me.Panel1.Controls.Add(Me.Btnanalysis)
        Me.Panel1.Controls.Add(Me.Btnprint)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(835, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 361)
        Me.Panel1.TabIndex = 51
        '
        'Btnbk
        '
        Me.Btnbk.BackColor = System.Drawing.Color.White
        Me.Btnbk.Location = New System.Drawing.Point(18, 156)
        Me.Btnbk.Name = "Btnbk"
        Me.Btnbk.Size = New System.Drawing.Size(124, 45)
        Me.Btnbk.TabIndex = 9
        Me.Btnbk.Text = "Book Keeping"
        Me.Btnbk.UseVisualStyleBackColor = False
        '
        'Btnfarms
        '
        Me.Btnfarms.BackColor = System.Drawing.Color.White
        Me.Btnfarms.Location = New System.Drawing.Point(16, 22)
        Me.Btnfarms.Name = "Btnfarms"
        Me.Btnfarms.Size = New System.Drawing.Size(124, 45)
        Me.Btnfarms.TabIndex = 8
        Me.Btnfarms.Text = "Farms"
        Me.Btnfarms.UseVisualStyleBackColor = False
        '
        'Btnproduction
        '
        Me.Btnproduction.BackColor = System.Drawing.Color.White
        Me.Btnproduction.Location = New System.Drawing.Point(18, 87)
        Me.Btnproduction.Name = "Btnproduction"
        Me.Btnproduction.Size = New System.Drawing.Size(124, 45)
        Me.Btnproduction.TabIndex = 4
        Me.Btnproduction.Text = "Production"
        Me.Btnproduction.UseVisualStyleBackColor = False
        '
        'Btnanalysis
        '
        Me.Btnanalysis.BackColor = System.Drawing.Color.White
        Me.Btnanalysis.Location = New System.Drawing.Point(18, 224)
        Me.Btnanalysis.Name = "Btnanalysis"
        Me.Btnanalysis.Size = New System.Drawing.Size(124, 45)
        Me.Btnanalysis.TabIndex = 5
        Me.Btnanalysis.Text = "Analysis"
        Me.Btnanalysis.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "REPORT"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Farm Number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(171, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 20)
        Me.TextBox1.TabIndex = 54
        '
        'MReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(1025, 512)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtharvestamount)
        Me.Controls.Add(Me.Lblfarmid)
        Me.Controls.Add(Me.Lblharvestamount)
        Me.Controls.Add(Me.txtTextBox)
        Me.Controls.Add(Me.Lblcrop)
        Me.Controls.Add(Me.Txtfarmid)
        Me.Controls.Add(Me.Txtharvestdate)
        Me.Controls.Add(Me.Txtcropname)
        Me.Controls.Add(Me.Txtsales)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtprofit)
        Me.Controls.Add(Me.Lblsales)
        Me.Controls.Add(Me.Lblprofits)
        Me.Name = "MReport"
        Me.Text = "Report"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtharvestamount As System.Windows.Forms.TextBox
    Friend WithEvents Lblfarmid As System.Windows.Forms.Label
    Friend WithEvents Lblharvestamount As System.Windows.Forms.Label
    Friend WithEvents txtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lblcrop As System.Windows.Forms.Label
    Friend WithEvents Txtfarmid As System.Windows.Forms.TextBox
    Friend WithEvents Txtharvestdate As System.Windows.Forms.TextBox
    Friend WithEvents Txtcropname As System.Windows.Forms.TextBox
    Friend WithEvents Txtsales As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtprofit As System.Windows.Forms.TextBox
    Friend WithEvents Lblsales As System.Windows.Forms.Label
    Friend WithEvents Lblprofits As System.Windows.Forms.Label
    Friend WithEvents Btnprint As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnfarms As System.Windows.Forms.Button
    Friend WithEvents Btnproduction As System.Windows.Forms.Button
    Friend WithEvents Btnanalysis As System.Windows.Forms.Button
    Friend WithEvents Btnbk As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
