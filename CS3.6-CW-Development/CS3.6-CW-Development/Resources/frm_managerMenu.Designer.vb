<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_managerMenu
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
        Me.btn_myShifts_redir = New System.Windows.Forms.Button()
        Me.btn_takeShifts_redir = New System.Windows.Forms.Button()
        Me.btn_logout_redir = New System.Windows.Forms.Button()
        Me.lbl_menu_TITLE = New System.Windows.Forms.Label()
        Me.btn_notifications_redir = New System.Windows.Forms.Button()
        Me.btn_profile_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        Me.btn_allShifts_redir = New System.Windows.Forms.Button()
        Me.btn_editAcc_redir = New System.Windows.Forms.Button()
        Me.btn_sendNotis_redir = New System.Windows.Forms.Button()
        Me.btn_removeOldData_process = New System.Windows.Forms.Button()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_myShifts_redir
        '
        Me.btn_myShifts_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_myShifts_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_myShifts_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_myShifts_redir.Location = New System.Drawing.Point(423, 80)
        Me.btn_myShifts_redir.Name = "btn_myShifts_redir"
        Me.btn_myShifts_redir.Size = New System.Drawing.Size(150, 70)
        Me.btn_myShifts_redir.TabIndex = 16
        Me.btn_myShifts_redir.Text = "My Shifts"
        Me.btn_myShifts_redir.UseVisualStyleBackColor = True
        '
        'btn_takeShifts_redir
        '
        Me.btn_takeShifts_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_takeShifts_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_takeShifts_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_takeShifts_redir.Location = New System.Drawing.Point(175, 80)
        Me.btn_takeShifts_redir.Name = "btn_takeShifts_redir"
        Me.btn_takeShifts_redir.Size = New System.Drawing.Size(150, 70)
        Me.btn_takeShifts_redir.TabIndex = 15
        Me.btn_takeShifts_redir.Text = "Take Shifts"
        Me.btn_takeShifts_redir.UseVisualStyleBackColor = True
        '
        'btn_logout_redir
        '
        Me.btn_logout_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout_redir.Location = New System.Drawing.Point(44, 2)
        Me.btn_logout_redir.Name = "btn_logout_redir"
        Me.btn_logout_redir.Size = New System.Drawing.Size(75, 38)
        Me.btn_logout_redir.TabIndex = 12
        Me.btn_logout_redir.Text = "LOGOUT"
        Me.btn_logout_redir.UseVisualStyleBackColor = True
        '
        'lbl_menu_TITLE
        '
        Me.lbl_menu_TITLE.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_menu_TITLE.Font = New System.Drawing.Font("Calibri", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu_TITLE.Location = New System.Drawing.Point(0, 0)
        Me.lbl_menu_TITLE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_menu_TITLE.Name = "lbl_menu_TITLE"
        Me.lbl_menu_TITLE.Size = New System.Drawing.Size(724, 50)
        Me.lbl_menu_TITLE.TabIndex = 11
        Me.lbl_menu_TITLE.Text = "<StaffFirstName> Menu (Manager)"
        Me.lbl_menu_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_notifications_redir
        '
        Me.btn_notifications_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_notifications_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_notifications_redir.Image = Global.CS3._6_CW_Development.My.Resources.Resources.notification_icon
        Me.btn_notifications_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_notifications_redir.Location = New System.Drawing.Point(609, 43)
        Me.btn_notifications_redir.Name = "btn_notifications_redir"
        Me.btn_notifications_redir.Size = New System.Drawing.Size(111, 31)
        Me.btn_notifications_redir.TabIndex = 14
        Me.btn_notifications_redir.Text = "Notifications"
        Me.btn_notifications_redir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_notifications_redir.UseVisualStyleBackColor = True
        '
        'btn_profile_redir
        '
        Me.btn_profile_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_profile_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_profile_redir.Image = Global.CS3._6_CW_Development.My.Resources.Resources.profile_icon
        Me.btn_profile_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_profile_redir.Location = New System.Drawing.Point(646, 6)
        Me.btn_profile_redir.Name = "btn_profile_redir"
        Me.btn_profile_redir.Size = New System.Drawing.Size(74, 31)
        Me.btn_profile_redir.TabIndex = 13
        Me.btn_profile_redir.Text = "Profile"
        Me.btn_profile_redir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_profile_redir.UseVisualStyleBackColor = True
        '
        'img_blc_logo
        '
        Me.img_blc_logo.Image = Global.CS3._6_CW_Development.My.Resources.Resources.blc_logo
        Me.img_blc_logo.Location = New System.Drawing.Point(-2, 0)
        Me.img_blc_logo.Name = "img_blc_logo"
        Me.img_blc_logo.Size = New System.Drawing.Size(40, 40)
        Me.img_blc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_blc_logo.TabIndex = 10
        Me.img_blc_logo.TabStop = False
        '
        'btn_allShifts_redir
        '
        Me.btn_allShifts_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_allShifts_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_allShifts_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_allShifts_redir.Location = New System.Drawing.Point(295, 181)
        Me.btn_allShifts_redir.Name = "btn_allShifts_redir"
        Me.btn_allShifts_redir.Size = New System.Drawing.Size(150, 70)
        Me.btn_allShifts_redir.TabIndex = 17
        Me.btn_allShifts_redir.Text = "All Shifts"
        Me.btn_allShifts_redir.UseVisualStyleBackColor = True
        '
        'btn_editAcc_redir
        '
        Me.btn_editAcc_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editAcc_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editAcc_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_editAcc_redir.Location = New System.Drawing.Point(162, 257)
        Me.btn_editAcc_redir.Name = "btn_editAcc_redir"
        Me.btn_editAcc_redir.Size = New System.Drawing.Size(150, 70)
        Me.btn_editAcc_redir.TabIndex = 18
        Me.btn_editAcc_redir.Text = "Edit Accounts "
        Me.btn_editAcc_redir.UseVisualStyleBackColor = True
        '
        'btn_sendNotis_redir
        '
        Me.btn_sendNotis_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_sendNotis_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sendNotis_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sendNotis_redir.Location = New System.Drawing.Point(479, 257)
        Me.btn_sendNotis_redir.Name = "btn_sendNotis_redir"
        Me.btn_sendNotis_redir.Size = New System.Drawing.Size(150, 70)
        Me.btn_sendNotis_redir.TabIndex = 19
        Me.btn_sendNotis_redir.Text = "Send Notifications"
        Me.btn_sendNotis_redir.UseVisualStyleBackColor = True
        '
        'btn_removeOldData_process
        '
        Me.btn_removeOldData_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_removeOldData_process.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removeOldData_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_removeOldData_process.Location = New System.Drawing.Point(514, 394)
        Me.btn_removeOldData_process.Name = "btn_removeOldData_process"
        Me.btn_removeOldData_process.Size = New System.Drawing.Size(198, 44)
        Me.btn_removeOldData_process.TabIndex = 20
        Me.btn_removeOldData_process.Text = "Remove old Shifts and Notifications"
        Me.btn_removeOldData_process.UseVisualStyleBackColor = True
        '
        'frm_managerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 450)
        Me.Controls.Add(Me.btn_removeOldData_process)
        Me.Controls.Add(Me.btn_sendNotis_redir)
        Me.Controls.Add(Me.btn_editAcc_redir)
        Me.Controls.Add(Me.btn_allShifts_redir)
        Me.Controls.Add(Me.btn_myShifts_redir)
        Me.Controls.Add(Me.btn_takeShifts_redir)
        Me.Controls.Add(Me.btn_notifications_redir)
        Me.Controls.Add(Me.btn_profile_redir)
        Me.Controls.Add(Me.btn_logout_redir)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Controls.Add(Me.lbl_menu_TITLE)
        Me.Name = "frm_managerMenu"
        Me.Text = "BLC Shift Manager (Shift Manager Menu)"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_myShifts_redir As Button
    Friend WithEvents btn_takeShifts_redir As Button
    Friend WithEvents btn_notifications_redir As Button
    Friend WithEvents btn_profile_redir As Button
    Friend WithEvents btn_logout_redir As Button
    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_menu_TITLE As Label
    Friend WithEvents btn_allShifts_redir As Button
    Friend WithEvents btn_editAcc_redir As Button
    Friend WithEvents btn_sendNotis_redir As Button
    Friend WithEvents btn_removeOldData_process As Button
End Class
