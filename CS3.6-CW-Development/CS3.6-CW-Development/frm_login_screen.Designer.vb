<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login_screen
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
        Me.lbl_login_TITLE = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_username_inp = New System.Windows.Forms.TextBox()
        Me.txt_password_inp = New System.Windows.Forms.TextBox()
        Me.btn_login_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_login_TITLE
        '
        Me.lbl_login_TITLE.AutoSize = True
        Me.lbl_login_TITLE.Font = New System.Drawing.Font("Calibri", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_TITLE.Location = New System.Drawing.Point(150, 20)
        Me.lbl_login_TITLE.Name = "lbl_login_TITLE"
        Me.lbl_login_TITLE.Size = New System.Drawing.Size(352, 58)
        Me.lbl_login_TITLE.TabIndex = 3
        Me.lbl_login_TITLE.Text = "SHIFT MANAGER"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(120, 91)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(134, 33)
        Me.lbl_username.TabIndex = 4
        Me.lbl_username.Text = "Username:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(128, 141)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(126, 33)
        Me.lbl_password.TabIndex = 5
        Me.lbl_password.Text = "Password:"
        '
        'txt_username_inp
        '
        Me.txt_username_inp.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username_inp.Location = New System.Drawing.Point(260, 88)
        Me.txt_username_inp.Name = "txt_username_inp"
        Me.txt_username_inp.Size = New System.Drawing.Size(198, 40)
        Me.txt_username_inp.TabIndex = 6
        '
        'txt_password_inp
        '
        Me.txt_password_inp.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password_inp.Location = New System.Drawing.Point(260, 140)
        Me.txt_password_inp.Name = "txt_password_inp"
        Me.txt_password_inp.Size = New System.Drawing.Size(198, 40)
        Me.txt_password_inp.TabIndex = 7
        '
        'btn_login_redir
        '
        Me.btn_login_redir.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_login_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_redir.Location = New System.Drawing.Point(245, 201)
        Me.btn_login_redir.Name = "btn_login_redir"
        Me.btn_login_redir.Size = New System.Drawing.Size(75, 34)
        Me.btn_login_redir.TabIndex = 8
        Me.btn_login_redir.Text = "LOGIN"
        Me.btn_login_redir.UseVisualStyleBackColor = False
        '
        'img_blc_logo
        '
        Me.img_blc_logo.Image = Global.CS3._6_CW_Development.My.Resources.Resources.blc_logo
        Me.img_blc_logo.Location = New System.Drawing.Point(100, 20)
        Me.img_blc_logo.Name = "img_blc_logo"
        Me.img_blc_logo.Size = New System.Drawing.Size(50, 50)
        Me.img_blc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_blc_logo.TabIndex = 2
        Me.img_blc_logo.TabStop = False
        '
        'frm_login_screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.btn_login_redir)
        Me.Controls.Add(Me.txt_password_inp)
        Me.Controls.Add(Me.txt_username_inp)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.lbl_login_TITLE)
        Me.Controls.Add(Me.img_blc_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frm_login_screen"
        Me.Text = "BLC Shift Manager (Login Screen)"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_login_TITLE As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_username_inp As TextBox
    Friend WithEvents txt_password_inp As TextBox
    Friend WithEvents btn_login_redir As Button
End Class
