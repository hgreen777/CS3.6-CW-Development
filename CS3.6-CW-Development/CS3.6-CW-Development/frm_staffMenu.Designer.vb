<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffMenu
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
        Me.lbl_menu_TITLE = New System.Windows.Forms.Label()
        Me.btn_logout_redir = New System.Windows.Forms.Button()
        Me.btn_takeShifts_redir = New System.Windows.Forms.Button()
        Me.btn_myShifts_redir = New System.Windows.Forms.Button()
        Me.btn_notifications_redir = New System.Windows.Forms.Button()
        Me.btn_profile_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_menu_TITLE
        '
        Me.lbl_menu_TITLE.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_menu_TITLE.Font = New System.Drawing.Font("Calibri", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu_TITLE.Location = New System.Drawing.Point(0, 0)
        Me.lbl_menu_TITLE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_menu_TITLE.Name = "lbl_menu_TITLE"
        Me.lbl_menu_TITLE.Size = New System.Drawing.Size(724, 50)
        Me.lbl_menu_TITLE.TabIndex = 4
        Me.lbl_menu_TITLE.Text = "<StaffFirstName> Menu (Staff)"
        Me.lbl_menu_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_logout_redir
        '
        Me.btn_logout_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout_redir.Location = New System.Drawing.Point(46, 2)
        Me.btn_logout_redir.Name = "btn_logout_redir"
        Me.btn_logout_redir.Size = New System.Drawing.Size(75, 38)
        Me.btn_logout_redir.TabIndex = 5
        Me.btn_logout_redir.Text = "LOGOUT"
        Me.btn_logout_redir.UseVisualStyleBackColor = True
        '
        'btn_takeShifts_redir
        '
        Me.btn_takeShifts_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_takeShifts_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_takeShifts_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_takeShifts_redir.Location = New System.Drawing.Point(165, 80)
        Me.btn_takeShifts_redir.Name = "btn_takeShifts_redir"
        Me.btn_takeShifts_redir.Size = New System.Drawing.Size(150, 70)
        Me.btn_takeShifts_redir.TabIndex = 8
        Me.btn_takeShifts_redir.Text = "Take Shifts"
        Me.btn_takeShifts_redir.UseVisualStyleBackColor = True
        '
        'btn_myShifts_redir
        '
        Me.btn_myShifts_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_myShifts_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_myShifts_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_myShifts_redir.Location = New System.Drawing.Point(415, 80)
        Me.btn_myShifts_redir.Name = "btn_myShifts_redir"
        Me.btn_myShifts_redir.Size = New System.Drawing.Size(150, 70)
        Me.btn_myShifts_redir.TabIndex = 9
        Me.btn_myShifts_redir.Text = "My Shifts"
        Me.btn_myShifts_redir.UseVisualStyleBackColor = True
        '
        'btn_notifications_redir
        '
        Me.btn_notifications_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_notifications_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_notifications_redir.Image = Global.CS3._6_CW_Development.My.Resources.Resources.notification_icon
        Me.btn_notifications_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_notifications_redir.Location = New System.Drawing.Point(611, 43)
        Me.btn_notifications_redir.Name = "btn_notifications_redir"
        Me.btn_notifications_redir.Size = New System.Drawing.Size(111, 31)
        Me.btn_notifications_redir.TabIndex = 7
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
        Me.btn_profile_redir.Location = New System.Drawing.Point(648, 6)
        Me.btn_profile_redir.Name = "btn_profile_redir"
        Me.btn_profile_redir.Size = New System.Drawing.Size(74, 31)
        Me.btn_profile_redir.TabIndex = 6
        Me.btn_profile_redir.Text = "Profile"
        Me.btn_profile_redir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_profile_redir.UseVisualStyleBackColor = True
        '
        'img_blc_logo
        '
        Me.img_blc_logo.Image = Global.CS3._6_CW_Development.My.Resources.Resources.blc_logo
        Me.img_blc_logo.Location = New System.Drawing.Point(0, 0)
        Me.img_blc_logo.Name = "img_blc_logo"
        Me.img_blc_logo.Size = New System.Drawing.Size(40, 40)
        Me.img_blc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_blc_logo.TabIndex = 3
        Me.img_blc_logo.TabStop = False
        '
        'frm_staffMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(724, 181)
        Me.Controls.Add(Me.btn_myShifts_redir)
        Me.Controls.Add(Me.btn_takeShifts_redir)
        Me.Controls.Add(Me.btn_notifications_redir)
        Me.Controls.Add(Me.btn_profile_redir)
        Me.Controls.Add(Me.btn_logout_redir)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Controls.Add(Me.lbl_menu_TITLE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_staffMenu"
        Me.Text = "BLC Shift Manager (Staff Menu)"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_menu_TITLE As Label
    Friend WithEvents btn_logout_redir As Button
    Friend WithEvents btn_profile_redir As Button
    Friend WithEvents btn_notifications_redir As Button
    Friend WithEvents btn_takeShifts_redir As Button
    Friend WithEvents btn_myShifts_redir As Button
End Class
