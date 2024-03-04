<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accountEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_accountEditor))
        Me.btn_back_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_accountEditor_TITLE = New System.Windows.Forms.Label()
        Me.lbl_username_static = New System.Windows.Forms.Label()
        Me.lbl_firstName_static = New System.Windows.Forms.Label()
        Me.lbl_surname_static = New System.Windows.Forms.Label()
        Me.lbl_password_static = New System.Windows.Forms.Label()
        Me.btn_saveDetails_process = New System.Windows.Forms.Button()
        Me.chkBox_showPassword = New System.Windows.Forms.CheckBox()
        Me.txt_password_inp = New System.Windows.Forms.TextBox()
        Me.txt_surname_inp = New System.Windows.Forms.TextBox()
        Me.txt_firstName_inp = New System.Windows.Forms.TextBox()
        Me.lbl_username_dynamic = New System.Windows.Forms.Label()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back_redir
        '
        Me.btn_back_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_redir.Location = New System.Drawing.Point(44, 2)
        Me.btn_back_redir.Name = "btn_back_redir"
        Me.btn_back_redir.Size = New System.Drawing.Size(75, 38)
        Me.btn_back_redir.TabIndex = 33
        Me.btn_back_redir.Text = "Back"
        Me.btn_back_redir.UseVisualStyleBackColor = True
        '
        'img_blc_logo
        '
        Me.img_blc_logo.Image = Global.CS3._6_CW_Development.My.Resources.Resources.blc_logo
        Me.img_blc_logo.Location = New System.Drawing.Point(0, 0)
        Me.img_blc_logo.Name = "img_blc_logo"
        Me.img_blc_logo.Size = New System.Drawing.Size(40, 40)
        Me.img_blc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_blc_logo.TabIndex = 31
        Me.img_blc_logo.TabStop = False
        '
        'lbl_accountEditor_TITLE
        '
        Me.lbl_accountEditor_TITLE.Font = New System.Drawing.Font("Calibri", 27.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_accountEditor_TITLE.Location = New System.Drawing.Point(118, 0)
        Me.lbl_accountEditor_TITLE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_accountEditor_TITLE.Name = "lbl_accountEditor_TITLE"
        Me.lbl_accountEditor_TITLE.Size = New System.Drawing.Size(519, 50)
        Me.lbl_accountEditor_TITLE.TabIndex = 32
        Me.lbl_accountEditor_TITLE.Text = "<StaffFirstName> Account Editor"
        Me.lbl_accountEditor_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_username_static
        '
        Me.lbl_username_static.AutoSize = True
        Me.lbl_username_static.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username_static.Location = New System.Drawing.Point(30, 63)
        Me.lbl_username_static.Name = "lbl_username_static"
        Me.lbl_username_static.Size = New System.Drawing.Size(100, 24)
        Me.lbl_username_static.TabIndex = 34
        Me.lbl_username_static.Text = "Username:"
        '
        'lbl_firstName_static
        '
        Me.lbl_firstName_static.AutoSize = True
        Me.lbl_firstName_static.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_firstName_static.Location = New System.Drawing.Point(30, 108)
        Me.lbl_firstName_static.Name = "lbl_firstName_static"
        Me.lbl_firstName_static.Size = New System.Drawing.Size(105, 24)
        Me.lbl_firstName_static.TabIndex = 35
        Me.lbl_firstName_static.Text = "First Name:"
        '
        'lbl_surname_static
        '
        Me.lbl_surname_static.AutoSize = True
        Me.lbl_surname_static.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_surname_static.Location = New System.Drawing.Point(28, 163)
        Me.lbl_surname_static.Name = "lbl_surname_static"
        Me.lbl_surname_static.Size = New System.Drawing.Size(102, 24)
        Me.lbl_surname_static.TabIndex = 36
        Me.lbl_surname_static.Text = "Last Name:"
        '
        'lbl_password_static
        '
        Me.lbl_password_static.AutoSize = True
        Me.lbl_password_static.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password_static.Location = New System.Drawing.Point(30, 219)
        Me.lbl_password_static.Name = "lbl_password_static"
        Me.lbl_password_static.Size = New System.Drawing.Size(94, 24)
        Me.lbl_password_static.TabIndex = 37
        Me.lbl_password_static.Text = "Password:"
        '
        'btn_saveDetails_process
        '
        Me.btn_saveDetails_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveDetails_process.Location = New System.Drawing.Point(462, 110)
        Me.btn_saveDetails_process.Name = "btn_saveDetails_process"
        Me.btn_saveDetails_process.Size = New System.Drawing.Size(150, 75)
        Me.btn_saveDetails_process.TabIndex = 38
        Me.btn_saveDetails_process.Text = "Save Details"
        Me.btn_saveDetails_process.UseVisualStyleBackColor = True
        '
        'chkBox_showPassword
        '
        Me.chkBox_showPassword.AutoSize = True
        Me.chkBox_showPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox_showPassword.Location = New System.Drawing.Point(359, 222)
        Me.chkBox_showPassword.Name = "chkBox_showPassword"
        Me.chkBox_showPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkBox_showPassword.Size = New System.Drawing.Size(66, 23)
        Me.chkBox_showPassword.TabIndex = 39
        Me.chkBox_showPassword.Text = ":Show"
        Me.chkBox_showPassword.UseVisualStyleBackColor = True
        '
        'txt_password_inp
        '
        Me.txt_password_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password_inp.Location = New System.Drawing.Point(184, 216)
        Me.txt_password_inp.Name = "txt_password_inp"
        Me.txt_password_inp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password_inp.Size = New System.Drawing.Size(151, 32)
        Me.txt_password_inp.TabIndex = 40
        '
        'txt_surname_inp
        '
        Me.txt_surname_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_surname_inp.Location = New System.Drawing.Point(184, 160)
        Me.txt_surname_inp.Name = "txt_surname_inp"
        Me.txt_surname_inp.Size = New System.Drawing.Size(151, 32)
        Me.txt_surname_inp.TabIndex = 41
        '
        'txt_firstName_inp
        '
        Me.txt_firstName_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_firstName_inp.Location = New System.Drawing.Point(184, 105)
        Me.txt_firstName_inp.Name = "txt_firstName_inp"
        Me.txt_firstName_inp.Size = New System.Drawing.Size(151, 32)
        Me.txt_firstName_inp.TabIndex = 42
        '
        'lbl_username_dynamic
        '
        Me.lbl_username_dynamic.AutoSize = True
        Me.lbl_username_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username_dynamic.Location = New System.Drawing.Point(180, 63)
        Me.lbl_username_dynamic.Name = "lbl_username_dynamic"
        Me.lbl_username_dynamic.Size = New System.Drawing.Size(155, 24)
        Me.lbl_username_dynamic.TabIndex = 43
        Me.lbl_username_dynamic.Text = "<StaffUserName>"
        '
        'frm_accountEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(637, 261)
        Me.Controls.Add(Me.lbl_username_dynamic)
        Me.Controls.Add(Me.txt_firstName_inp)
        Me.Controls.Add(Me.txt_surname_inp)
        Me.Controls.Add(Me.txt_password_inp)
        Me.Controls.Add(Me.chkBox_showPassword)
        Me.Controls.Add(Me.btn_saveDetails_process)
        Me.Controls.Add(Me.lbl_password_static)
        Me.Controls.Add(Me.lbl_surname_static)
        Me.Controls.Add(Me.lbl_firstName_static)
        Me.Controls.Add(Me.lbl_username_static)
        Me.Controls.Add(Me.btn_back_redir)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Controls.Add(Me.lbl_accountEditor_TITLE)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_accountEditor"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Text = "BLC Shift Manager (Account Editor)"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back_redir As Button
    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_accountEditor_TITLE As Label
    Friend WithEvents lbl_username_static As Label
    Friend WithEvents lbl_firstName_static As Label
    Friend WithEvents lbl_surname_static As Label
    Friend WithEvents lbl_password_static As Label
    Friend WithEvents btn_saveDetails_process As Button
    Friend WithEvents chkBox_showPassword As CheckBox
    Friend WithEvents txt_password_inp As TextBox
    Friend WithEvents txt_surname_inp As TextBox
    Friend WithEvents txt_firstName_inp As TextBox
    Friend WithEvents lbl_username_dynamic As Label
End Class
