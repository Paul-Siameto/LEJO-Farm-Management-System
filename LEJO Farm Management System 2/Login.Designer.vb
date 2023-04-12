<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.Lblpassword = New System.Windows.Forms.Label()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnlogin
        '
        Me.Btnlogin.BackColor = System.Drawing.Color.LightGreen
        Me.Btnlogin.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogin.Location = New System.Drawing.Point(10, 144)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(103, 33)
        Me.Btnlogin.TabIndex = 0
        Me.Btnlogin.Text = "Login"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(7, 19)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(40, 16)
        Me.lblusername.TabIndex = 1
        Me.lblusername.Text = "User:"
        '
        'Lblpassword
        '
        Me.Lblpassword.AutoSize = True
        Me.Lblpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpassword.Location = New System.Drawing.Point(9, 76)
        Me.Lblpassword.Name = "Lblpassword"
        Me.Lblpassword.Size = New System.Drawing.Size(71, 16)
        Me.Lblpassword.TabIndex = 2
        Me.Lblpassword.Text = "Password:"
        '
        'Txtusername
        '
        Me.Txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusername.Location = New System.Drawing.Point(93, 12)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(139, 22)
        Me.Txtusername.TabIndex = 3
        '
        'Txtpassword
        '
        Me.Txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpassword.Location = New System.Drawing.Point(93, 73)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(139, 22)
        Me.Txtpassword.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(129, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.Txtpassword)
        Me.Panel1.Controls.Add(Me.lblusername)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Btnlogin)
        Me.Panel1.Controls.Add(Me.Lblpassword)
        Me.Panel1.Controls.Add(Me.Txtusername)
        Me.Panel1.Location = New System.Drawing.Point(238, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 187)
        Me.Panel1.TabIndex = 7
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(511, 286)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btnlogin As System.Windows.Forms.Button
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents Lblpassword As System.Windows.Forms.Label
    Friend WithEvents Txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
