<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accountManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_accountManager))
        Me.btn_back_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_accountManager_TITLE = New System.Windows.Forms.Label()
        Me.btn_searchStaff_process = New System.Windows.Forms.Button()
        Me.txt_firstName_search = New System.Windows.Forms.TextBox()
        Me.lbl_searchInstructions = New System.Windows.Forms.Label()
        Me.lbl_username_dynamic = New System.Windows.Forms.Label()
        Me.txt_firstName_inp = New System.Windows.Forms.TextBox()
        Me.txt_surname_inp = New System.Windows.Forms.TextBox()
        Me.txt_password_inp = New System.Windows.Forms.TextBox()
        Me.chkBox_showPassword = New System.Windows.Forms.CheckBox()
        Me.btn_saveDetails_process = New System.Windows.Forms.Button()
        Me.lbl_password_static = New System.Windows.Forms.Label()
        Me.lbl_surname_static = New System.Windows.Forms.Label()
        Me.lbl_firstName_static = New System.Windows.Forms.Label()
        Me.lbl_username_static = New System.Windows.Forms.Label()
        Me.btn_deleteAccount_process = New System.Windows.Forms.Button()
        Me.btn_createAccount_process = New System.Windows.Forms.Button()
        Me.btn_resetPassword_process = New System.Windows.Forms.Button()
        Me.chBox_isfullTimeStaff = New System.Windows.Forms.CheckBox()
        Me.chBox_isManager = New System.Windows.Forms.CheckBox()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back_redir
        '
        Me.btn_back_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_redir.Location = New System.Drawing.Point(44, 2)
        Me.btn_back_redir.Name = "btn_back_redir"
        Me.btn_back_redir.Size = New System.Drawing.Size(75, 38)
        Me.btn_back_redir.TabIndex = 0
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
        Me.img_blc_logo.TabIndex = 34
        Me.img_blc_logo.TabStop = False
        '
        'lbl_accountManager_TITLE
        '
        Me.lbl_accountManager_TITLE.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_accountManager_TITLE.Font = New System.Drawing.Font("Calibri", 27.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_accountManager_TITLE.Location = New System.Drawing.Point(0, 0)
        Me.lbl_accountManager_TITLE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_accountManager_TITLE.Name = "lbl_accountManager_TITLE"
        Me.lbl_accountManager_TITLE.Size = New System.Drawing.Size(684, 50)
        Me.lbl_accountManager_TITLE.TabIndex = 35
        Me.lbl_accountManager_TITLE.Text = "Account Manager"
        Me.lbl_accountManager_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_searchStaff_process
        '
        Me.btn_searchStaff_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_searchStaff_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchStaff_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_searchStaff_process.Location = New System.Drawing.Point(519, 52)
        Me.btn_searchStaff_process.Name = "btn_searchStaff_process"
        Me.btn_searchStaff_process.Size = New System.Drawing.Size(150, 32)
        Me.btn_searchStaff_process.TabIndex = 2
        Me.btn_searchStaff_process.Text = "SEARCH"
        Me.btn_searchStaff_process.UseVisualStyleBackColor = True
        '
        'txt_firstName_search
        '
        Me.txt_firstName_search.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_firstName_search.Location = New System.Drawing.Point(356, 53)
        Me.txt_firstName_search.Name = "txt_firstName_search"
        Me.txt_firstName_search.Size = New System.Drawing.Size(141, 32)
        Me.txt_firstName_search.TabIndex = 1
        '
        'lbl_searchInstructions
        '
        Me.lbl_searchInstructions.AutoSize = True
        Me.lbl_searchInstructions.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_searchInstructions.Location = New System.Drawing.Point(24, 50)
        Me.lbl_searchInstructions.Name = "lbl_searchInstructions"
        Me.lbl_searchInstructions.Size = New System.Drawing.Size(325, 48)
        Me.lbl_searchInstructions.TabIndex = 37
        Me.lbl_searchInstructions.Text = "Search for Staff Member (First Name):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type ""NEW"" to create a new user."
        '
        'lbl_username_dynamic
        '
        Me.lbl_username_dynamic.AutoSize = True
        Me.lbl_username_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username_dynamic.Location = New System.Drawing.Point(180, 116)
        Me.lbl_username_dynamic.Name = "lbl_username_dynamic"
        Me.lbl_username_dynamic.Size = New System.Drawing.Size(155, 24)
        Me.lbl_username_dynamic.TabIndex = 53
        Me.lbl_username_dynamic.Text = "<StaffUserName>"
        '
        'txt_firstName_inp
        '
        Me.txt_firstName_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_firstName_inp.Location = New System.Drawing.Point(184, 158)
        Me.txt_firstName_inp.Name = "txt_firstName_inp"
        Me.txt_firstName_inp.Size = New System.Drawing.Size(151, 32)
        Me.txt_firstName_inp.TabIndex = 3
        '
        'txt_surname_inp
        '
        Me.txt_surname_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_surname_inp.Location = New System.Drawing.Point(184, 213)
        Me.txt_surname_inp.Name = "txt_surname_inp"
        Me.txt_surname_inp.Size = New System.Drawing.Size(151, 32)
        Me.txt_surname_inp.TabIndex = 4
        '
        'txt_password_inp
        '
        Me.txt_password_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password_inp.Location = New System.Drawing.Point(184, 269)
        Me.txt_password_inp.Name = "txt_password_inp"
        Me.txt_password_inp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password_inp.Size = New System.Drawing.Size(151, 32)
        Me.txt_password_inp.TabIndex = 5
        '
        'chkBox_showPassword
        '
        Me.chkBox_showPassword.AutoSize = True
        Me.chkBox_showPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox_showPassword.Location = New System.Drawing.Point(359, 275)
        Me.chkBox_showPassword.Name = "chkBox_showPassword"
        Me.chkBox_showPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkBox_showPassword.Size = New System.Drawing.Size(66, 23)
        Me.chkBox_showPassword.TabIndex = 6
        Me.chkBox_showPassword.Text = ":Show"
        Me.chkBox_showPassword.UseVisualStyleBackColor = True
        '
        'btn_saveDetails_process
        '
        Me.btn_saveDetails_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveDetails_process.Location = New System.Drawing.Point(473, 95)
        Me.btn_saveDetails_process.Name = "btn_saveDetails_process"
        Me.btn_saveDetails_process.Size = New System.Drawing.Size(150, 65)
        Me.btn_saveDetails_process.TabIndex = 9
        Me.btn_saveDetails_process.Text = "Save Details"
        Me.btn_saveDetails_process.UseVisualStyleBackColor = True
        '
        'lbl_password_static
        '
        Me.lbl_password_static.AutoSize = True
        Me.lbl_password_static.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password_static.Location = New System.Drawing.Point(27, 272)
        Me.lbl_password_static.Name = "lbl_password_static"
        Me.lbl_password_static.Size = New System.Drawing.Size(94, 24)
        Me.lbl_password_static.TabIndex = 47
        Me.lbl_password_static.Text = "Password:"
        '
        'lbl_surname_static
        '
        Me.lbl_surname_static.AutoSize = True
        Me.lbl_surname_static.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_surname_static.Location = New System.Drawing.Point(27, 216)
        Me.lbl_surname_static.Name = "lbl_surname_static"
        Me.lbl_surname_static.Size = New System.Drawing.Size(102, 24)
        Me.lbl_surname_static.TabIndex = 46
        Me.lbl_surname_static.Text = "Last Name:"
        '
        'lbl_firstName_static
        '
        Me.lbl_firstName_static.AutoSize = True
        Me.lbl_firstName_static.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_firstName_static.Location = New System.Drawing.Point(27, 161)
        Me.lbl_firstName_static.Name = "lbl_firstName_static"
        Me.lbl_firstName_static.Size = New System.Drawing.Size(105, 24)
        Me.lbl_firstName_static.TabIndex = 45
        Me.lbl_firstName_static.Text = "First Name:"
        '
        'lbl_username_static
        '
        Me.lbl_username_static.AutoSize = True
        Me.lbl_username_static.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username_static.Location = New System.Drawing.Point(27, 116)
        Me.lbl_username_static.Name = "lbl_username_static"
        Me.lbl_username_static.Size = New System.Drawing.Size(100, 24)
        Me.lbl_username_static.TabIndex = 44
        Me.lbl_username_static.Text = "Username:"
        '
        'btn_deleteAccount_process
        '
        Me.btn_deleteAccount_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteAccount_process.ForeColor = System.Drawing.Color.Red
        Me.btn_deleteAccount_process.Location = New System.Drawing.Point(473, 236)
        Me.btn_deleteAccount_process.Name = "btn_deleteAccount_process"
        Me.btn_deleteAccount_process.Size = New System.Drawing.Size(150, 65)
        Me.btn_deleteAccount_process.TabIndex = 11
        Me.btn_deleteAccount_process.Text = "Delete Account"
        Me.btn_deleteAccount_process.UseVisualStyleBackColor = True
        '
        'btn_createAccount_process
        '
        Me.btn_createAccount_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_createAccount_process.Location = New System.Drawing.Point(473, 165)
        Me.btn_createAccount_process.Name = "btn_createAccount_process"
        Me.btn_createAccount_process.Size = New System.Drawing.Size(150, 65)
        Me.btn_createAccount_process.TabIndex = 10
        Me.btn_createAccount_process.Text = "Create Account"
        Me.btn_createAccount_process.UseVisualStyleBackColor = True
        '
        'btn_resetPassword_process
        '
        Me.btn_resetPassword_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resetPassword_process.Location = New System.Drawing.Point(473, 307)
        Me.btn_resetPassword_process.Name = "btn_resetPassword_process"
        Me.btn_resetPassword_process.Size = New System.Drawing.Size(150, 65)
        Me.btn_resetPassword_process.TabIndex = 12
        Me.btn_resetPassword_process.Text = "Reset Password"
        Me.btn_resetPassword_process.UseVisualStyleBackColor = True
        '
        'chBox_isfullTimeStaff
        '
        Me.chBox_isfullTimeStaff.AutoSize = True
        Me.chBox_isfullTimeStaff.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBox_isfullTimeStaff.Location = New System.Drawing.Point(28, 314)
        Me.chBox_isfullTimeStaff.Name = "chBox_isfullTimeStaff"
        Me.chBox_isfullTimeStaff.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chBox_isfullTimeStaff.Size = New System.Drawing.Size(316, 28)
        Me.chBox_isfullTimeStaff.TabIndex = 7
        Me.chBox_isfullTimeStaff.Text = "?Are they a full-time staff member"
        Me.chBox_isfullTimeStaff.UseVisualStyleBackColor = True
        '
        'chBox_isManager
        '
        Me.chBox_isManager.AutoSize = True
        Me.chBox_isManager.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBox_isManager.Location = New System.Drawing.Point(28, 348)
        Me.chBox_isManager.Name = "chBox_isManager"
        Me.chBox_isManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chBox_isManager.Size = New System.Drawing.Size(305, 28)
        Me.chBox_isManager.TabIndex = 8
        Me.chBox_isManager.Text = "?Are they a manager/duty officer"
        Me.chBox_isManager.UseVisualStyleBackColor = True
        '
        'frm_accountManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 386)
        Me.Controls.Add(Me.chBox_isManager)
        Me.Controls.Add(Me.chBox_isfullTimeStaff)
        Me.Controls.Add(Me.btn_resetPassword_process)
        Me.Controls.Add(Me.btn_createAccount_process)
        Me.Controls.Add(Me.btn_deleteAccount_process)
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
        Me.Controls.Add(Me.btn_searchStaff_process)
        Me.Controls.Add(Me.txt_firstName_search)
        Me.Controls.Add(Me.lbl_searchInstructions)
        Me.Controls.Add(Me.btn_back_redir)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Controls.Add(Me.lbl_accountManager_TITLE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_accountManager"
        Me.Text = "BLC Shift Manager (Account Manager)"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back_redir As Button
    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_accountManager_TITLE As Label
    Friend WithEvents btn_searchStaff_process As Button
    Friend WithEvents txt_firstName_search As TextBox
    Friend WithEvents lbl_searchInstructions As Label
    Friend WithEvents lbl_username_dynamic As Label
    Friend WithEvents txt_firstName_inp As TextBox
    Friend WithEvents txt_surname_inp As TextBox
    Friend WithEvents txt_password_inp As TextBox
    Friend WithEvents chkBox_showPassword As CheckBox
    Friend WithEvents btn_saveDetails_process As Button
    Friend WithEvents lbl_password_static As Label
    Friend WithEvents lbl_surname_static As Label
    Friend WithEvents lbl_firstName_static As Label
    Friend WithEvents lbl_username_static As Label
    Friend WithEvents btn_deleteAccount_process As Button
    Friend WithEvents btn_createAccount_process As Button
    Friend WithEvents btn_resetPassword_process As Button
    Friend WithEvents chBox_isfullTimeStaff As CheckBox
    Friend WithEvents chBox_isManager As CheckBox
End Class
