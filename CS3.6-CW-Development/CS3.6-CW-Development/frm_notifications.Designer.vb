<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_notifications
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_notifications))
        Me.btn_back_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_notifications_TITLE = New System.Windows.Forms.Label()
        Me.grp_notificationPreview = New System.Windows.Forms.GroupBox()
        Me.lsv_notificationPreview = New System.Windows.Forms.ListView()
        Me.notiID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.contentPreview = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sentDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grp_selectedNotification = New System.Windows.Forms.GroupBox()
        Me.txt_notificationContent_disp = New System.Windows.Forms.TextBox()
        Me.lbl_sentDate_dynamic = New System.Windows.Forms.Label()
        Me.lbl_sender_dynamic = New System.Windows.Forms.Label()
        Me.lbl_notificationID_dynamic = New System.Windows.Forms.Label()
        Me.lbl_sendDate_static = New System.Windows.Forms.Label()
        Me.lbl_sender_static = New System.Windows.Forms.Label()
        Me.lbl_notificationID_static = New System.Windows.Forms.Label()
        Me.btn_deleteNotification_process = New System.Windows.Forms.Button()
        Me.lbl_notificationInstance_hidden = New System.Windows.Forms.Label()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_notificationPreview.SuspendLayout()
        Me.grp_selectedNotification.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back_redir
        '
        Me.btn_back_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_redir.Location = New System.Drawing.Point(44, 2)
        Me.btn_back_redir.Name = "btn_back_redir"
        Me.btn_back_redir.Size = New System.Drawing.Size(75, 38)
        Me.btn_back_redir.TabIndex = 27
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
        Me.img_blc_logo.TabIndex = 25
        Me.img_blc_logo.TabStop = False
        '
        'lbl_notifications_TITLE
        '
        Me.lbl_notifications_TITLE.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_notifications_TITLE.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notifications_TITLE.Location = New System.Drawing.Point(0, 0)
        Me.lbl_notifications_TITLE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_notifications_TITLE.Name = "lbl_notifications_TITLE"
        Me.lbl_notifications_TITLE.Size = New System.Drawing.Size(784, 50)
        Me.lbl_notifications_TITLE.TabIndex = 26
        Me.lbl_notifications_TITLE.Text = "<StafffFirstName> Notifications"
        Me.lbl_notifications_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grp_notificationPreview
        '
        Me.grp_notificationPreview.Controls.Add(Me.lsv_notificationPreview)
        Me.grp_notificationPreview.Location = New System.Drawing.Point(12, 46)
        Me.grp_notificationPreview.Name = "grp_notificationPreview"
        Me.grp_notificationPreview.Size = New System.Drawing.Size(375, 392)
        Me.grp_notificationPreview.TabIndex = 28
        Me.grp_notificationPreview.TabStop = False
        Me.grp_notificationPreview.Text = "Notification Preview:"
        '
        'lsv_notificationPreview
        '
        Me.lsv_notificationPreview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.notiID, Me.contentPreview, Me.sender, Me.sentDate})
        Me.lsv_notificationPreview.FullRowSelect = True
        Me.lsv_notificationPreview.HideSelection = False
        Me.lsv_notificationPreview.Location = New System.Drawing.Point(6, 15)
        Me.lsv_notificationPreview.MultiSelect = False
        Me.lsv_notificationPreview.Name = "lsv_notificationPreview"
        Me.lsv_notificationPreview.Size = New System.Drawing.Size(363, 371)
        Me.lsv_notificationPreview.TabIndex = 1
        Me.lsv_notificationPreview.UseCompatibleStateImageBehavior = False
        Me.lsv_notificationPreview.View = System.Windows.Forms.View.Details
        '
        'notiID
        '
        Me.notiID.Text = "Notification ID"
        Me.notiID.Width = 83
        '
        'contentPreview
        '
        Me.contentPreview.Text = "Content Preview"
        Me.contentPreview.Width = 112
        '
        'sender
        '
        Me.sender.Text = "From"
        '
        'sentDate
        '
        Me.sentDate.Text = "Sent On"
        Me.sentDate.Width = 84
        '
        'grp_selectedNotification
        '
        Me.grp_selectedNotification.Controls.Add(Me.lbl_notificationInstance_hidden)
        Me.grp_selectedNotification.Controls.Add(Me.txt_notificationContent_disp)
        Me.grp_selectedNotification.Controls.Add(Me.lbl_sentDate_dynamic)
        Me.grp_selectedNotification.Controls.Add(Me.lbl_sender_dynamic)
        Me.grp_selectedNotification.Controls.Add(Me.lbl_notificationID_dynamic)
        Me.grp_selectedNotification.Controls.Add(Me.lbl_sendDate_static)
        Me.grp_selectedNotification.Controls.Add(Me.lbl_sender_static)
        Me.grp_selectedNotification.Controls.Add(Me.lbl_notificationID_static)
        Me.grp_selectedNotification.Location = New System.Drawing.Point(393, 46)
        Me.grp_selectedNotification.Name = "grp_selectedNotification"
        Me.grp_selectedNotification.Size = New System.Drawing.Size(375, 322)
        Me.grp_selectedNotification.TabIndex = 29
        Me.grp_selectedNotification.TabStop = False
        Me.grp_selectedNotification.Text = "Selected Notification:"
        '
        'txt_notificationContent_disp
        '
        Me.txt_notificationContent_disp.BackColor = System.Drawing.Color.White
        Me.txt_notificationContent_disp.Location = New System.Drawing.Point(10, 121)
        Me.txt_notificationContent_disp.Multiline = True
        Me.txt_notificationContent_disp.Name = "txt_notificationContent_disp"
        Me.txt_notificationContent_disp.ReadOnly = True
        Me.txt_notificationContent_disp.Size = New System.Drawing.Size(351, 189)
        Me.txt_notificationContent_disp.TabIndex = 10
        '
        'lbl_sentDate_dynamic
        '
        Me.lbl_sentDate_dynamic.AutoSize = True
        Me.lbl_sentDate_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_sentDate_dynamic.Location = New System.Drawing.Point(151, 88)
        Me.lbl_sentDate_dynamic.Name = "lbl_sentDate_dynamic"
        Me.lbl_sentDate_dynamic.Size = New System.Drawing.Size(210, 24)
        Me.lbl_sentDate_dynamic.TabIndex = 9
        Me.lbl_sentDate_dynamic.Text = "<DD/MM/YYYY HH:mm>"
        '
        'lbl_sender_dynamic
        '
        Me.lbl_sender_dynamic.AutoSize = True
        Me.lbl_sender_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_sender_dynamic.Location = New System.Drawing.Point(151, 53)
        Me.lbl_sender_dynamic.Name = "lbl_sender_dynamic"
        Me.lbl_sender_dynamic.Size = New System.Drawing.Size(153, 24)
        Me.lbl_sender_dynamic.TabIndex = 8
        Me.lbl_sender_dynamic.Text = "<StaffFirstName>"
        '
        'lbl_notificationID_dynamic
        '
        Me.lbl_notificationID_dynamic.AutoSize = True
        Me.lbl_notificationID_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_notificationID_dynamic.Location = New System.Drawing.Point(151, 19)
        Me.lbl_notificationID_dynamic.Name = "lbl_notificationID_dynamic"
        Me.lbl_notificationID_dynamic.Size = New System.Drawing.Size(144, 24)
        Me.lbl_notificationID_dynamic.TabIndex = 7
        Me.lbl_notificationID_dynamic.Text = "<NotificationID>"
        '
        'lbl_sendDate_static
        '
        Me.lbl_sendDate_static.AutoSize = True
        Me.lbl_sendDate_static.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_sendDate_static.Location = New System.Drawing.Point(6, 88)
        Me.lbl_sendDate_static.Name = "lbl_sendDate_static"
        Me.lbl_sendDate_static.Size = New System.Drawing.Size(96, 24)
        Me.lbl_sendDate_static.TabIndex = 6
        Me.lbl_sendDate_static.Text = "Sent Date:"
        '
        'lbl_sender_static
        '
        Me.lbl_sender_static.AutoSize = True
        Me.lbl_sender_static.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_sender_static.Location = New System.Drawing.Point(6, 53)
        Me.lbl_sender_static.Name = "lbl_sender_static"
        Me.lbl_sender_static.Size = New System.Drawing.Size(73, 24)
        Me.lbl_sender_static.TabIndex = 5
        Me.lbl_sender_static.Text = "Sender:"
        '
        'lbl_notificationID_static
        '
        Me.lbl_notificationID_static.AutoSize = True
        Me.lbl_notificationID_static.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_notificationID_static.Location = New System.Drawing.Point(6, 19)
        Me.lbl_notificationID_static.Name = "lbl_notificationID_static"
        Me.lbl_notificationID_static.Size = New System.Drawing.Size(134, 24)
        Me.lbl_notificationID_static.TabIndex = 4
        Me.lbl_notificationID_static.Text = "Notification ID:"
        '
        'btn_deleteNotification_process
        '
        Me.btn_deleteNotification_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_deleteNotification_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteNotification_process.ForeColor = System.Drawing.Color.Red
        Me.btn_deleteNotification_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_deleteNotification_process.Location = New System.Drawing.Point(491, 374)
        Me.btn_deleteNotification_process.Name = "btn_deleteNotification_process"
        Me.btn_deleteNotification_process.Size = New System.Drawing.Size(186, 50)
        Me.btn_deleteNotification_process.TabIndex = 30
        Me.btn_deleteNotification_process.Text = "Delete Notification"
        Me.btn_deleteNotification_process.UseVisualStyleBackColor = True
        '
        'lbl_notificationInstance_hidden
        '
        Me.lbl_notificationInstance_hidden.AutoSize = True
        Me.lbl_notificationInstance_hidden.Location = New System.Drawing.Point(217, 6)
        Me.lbl_notificationInstance_hidden.Name = "lbl_notificationInstance_hidden"
        Me.lbl_notificationInstance_hidden.Size = New System.Drawing.Size(158, 13)
        Me.lbl_notificationInstance_hidden.TabIndex = 11
        Me.lbl_notificationInstance_hidden.Text = "<HiddenNotificationInstanceID>"
        Me.lbl_notificationInstance_hidden.Visible = False
        '
        'frm_notifications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 451)
        Me.Controls.Add(Me.btn_deleteNotification_process)
        Me.Controls.Add(Me.grp_selectedNotification)
        Me.Controls.Add(Me.grp_notificationPreview)
        Me.Controls.Add(Me.btn_back_redir)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Controls.Add(Me.lbl_notifications_TITLE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_notifications"
        Me.Text = "BLC Shift Manager (Notifications)"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_notificationPreview.ResumeLayout(False)
        Me.grp_selectedNotification.ResumeLayout(False)
        Me.grp_selectedNotification.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_back_redir As Button
    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_notifications_TITLE As Label
    Friend WithEvents grp_notificationPreview As GroupBox
    Friend WithEvents grp_selectedNotification As GroupBox
    Friend WithEvents lbl_sentDate_dynamic As Label
    Friend WithEvents lbl_sender_dynamic As Label
    Friend WithEvents lbl_notificationID_dynamic As Label
    Friend WithEvents lbl_sendDate_static As Label
    Friend WithEvents lbl_sender_static As Label
    Friend WithEvents lbl_notificationID_static As Label
    Friend WithEvents txt_notificationContent_disp As TextBox
    Friend WithEvents btn_deleteNotification_process As Button
    Friend WithEvents lsv_notificationPreview As ListView
    Friend WithEvents notiID As ColumnHeader
    Friend WithEvents contentPreview As ColumnHeader
    Friend WithEvents sender As ColumnHeader
    Friend WithEvents sentDate As ColumnHeader
    Friend WithEvents lbl_notificationInstance_hidden As Label
End Class
