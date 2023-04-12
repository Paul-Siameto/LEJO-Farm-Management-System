<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Btnreport = New System.Windows.Forms.Button()
        Me.Btnlogout = New System.Windows.Forms.Button()
        Me.Btnanalysis = New System.Windows.Forms.Button()
        Me.Btnbk = New System.Windows.Forms.Button()
        Me.Btnproduction = New System.Windows.Forms.Button()
        Me.Btnfarm = New System.Windows.Forms.Button()
        Me.Btnprofile = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnreport
        '
        Me.Btnreport.BackColor = System.Drawing.Color.Snow
        Me.Btnreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnreport.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnreport.ForeColor = System.Drawing.Color.Black
        Me.Btnreport.Location = New System.Drawing.Point(204, 164)
        Me.Btnreport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnreport.Name = "Btnreport"
        Me.Btnreport.Size = New System.Drawing.Size(128, 41)
        Me.Btnreport.TabIndex = 5
        Me.Btnreport.Text = "Report"
        Me.Btnreport.UseVisualStyleBackColor = False
        '
        'Btnlogout
        '
        Me.Btnlogout.BackColor = System.Drawing.Color.Snow
        Me.Btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnlogout.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogout.Location = New System.Drawing.Point(204, 237)
        Me.Btnlogout.Name = "Btnlogout"
        Me.Btnlogout.Size = New System.Drawing.Size(128, 45)
        Me.Btnlogout.TabIndex = 2
        Me.Btnlogout.Text = "Log out"
        Me.Btnlogout.UseVisualStyleBackColor = False
        '
        'Btnanalysis
        '
        Me.Btnanalysis.BackColor = System.Drawing.Color.Snow
        Me.Btnanalysis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Btnanalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnanalysis.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnanalysis.ForeColor = System.Drawing.Color.Black
        Me.Btnanalysis.Location = New System.Drawing.Point(204, 98)
        Me.Btnanalysis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnanalysis.Name = "Btnanalysis"
        Me.Btnanalysis.Size = New System.Drawing.Size(128, 41)
        Me.Btnanalysis.TabIndex = 4
        Me.Btnanalysis.Text = "Analysis"
        Me.Btnanalysis.UseVisualStyleBackColor = False
        '
        'Btnbk
        '
        Me.Btnbk.BackColor = System.Drawing.Color.Snow
        Me.Btnbk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Btnbk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbk.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbk.ForeColor = System.Drawing.Color.Black
        Me.Btnbk.Location = New System.Drawing.Point(204, 28)
        Me.Btnbk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnbk.Name = "Btnbk"
        Me.Btnbk.Size = New System.Drawing.Size(128, 41)
        Me.Btnbk.TabIndex = 3
        Me.Btnbk.Text = "Book Keeping"
        Me.Btnbk.UseVisualStyleBackColor = False
        '
        'Btnproduction
        '
        Me.Btnproduction.BackColor = System.Drawing.Color.Snow
        Me.Btnproduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Btnproduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnproduction.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnproduction.ForeColor = System.Drawing.Color.Black
        Me.Btnproduction.Location = New System.Drawing.Point(18, 164)
        Me.Btnproduction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnproduction.Name = "Btnproduction"
        Me.Btnproduction.Size = New System.Drawing.Size(145, 41)
        Me.Btnproduction.TabIndex = 2
        Me.Btnproduction.Text = "Production"
        Me.Btnproduction.UseVisualStyleBackColor = False
        '
        'Btnfarm
        '
        Me.Btnfarm.BackColor = System.Drawing.Color.Snow
        Me.Btnfarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Btnfarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnfarm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfarm.ForeColor = System.Drawing.Color.Black
        Me.Btnfarm.Location = New System.Drawing.Point(18, 98)
        Me.Btnfarm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnfarm.Name = "Btnfarm"
        Me.Btnfarm.Size = New System.Drawing.Size(145, 41)
        Me.Btnfarm.TabIndex = 1
        Me.Btnfarm.Text = "Farm"
        Me.Btnfarm.UseVisualStyleBackColor = False
        '
        'Btnprofile
        '
        Me.Btnprofile.BackColor = System.Drawing.Color.Snow
        Me.Btnprofile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnprofile.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprofile.ForeColor = System.Drawing.Color.Black
        Me.Btnprofile.Location = New System.Drawing.Point(18, 223)
        Me.Btnprofile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnprofile.Name = "Btnprofile"
        Me.Btnprofile.Size = New System.Drawing.Size(145, 41)
        Me.Btnprofile.TabIndex = 0
        Me.Btnprofile.Text = "Owners Accounts"
        Me.Btnprofile.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Btnlogout)
        Me.Panel1.Controls.Add(Me.Btnreport)
        Me.Panel1.Controls.Add(Me.Btnprofile)
        Me.Panel1.Controls.Add(Me.Btnanalysis)
        Me.Panel1.Controls.Add(Me.Btnfarm)
        Me.Panel1.Controls.Add(Me.Btnproduction)
        Me.Panel1.Controls.Add(Me.Btnbk)
        Me.Panel1.Location = New System.Drawing.Point(461, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 307)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(46, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(881, 418)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Main"
        Me.Text = "Main"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btnreport As System.Windows.Forms.Button
    Friend WithEvents Btnanalysis As System.Windows.Forms.Button
    Friend WithEvents Btnbk As System.Windows.Forms.Button
    Friend WithEvents Btnproduction As System.Windows.Forms.Button
    Friend WithEvents Btnfarm As System.Windows.Forms.Button
    Friend WithEvents Btnprofile As System.Windows.Forms.Button
    Friend WithEvents Btnlogout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
