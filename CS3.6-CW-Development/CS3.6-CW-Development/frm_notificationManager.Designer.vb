<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_notificationManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_notificationManager))
        Me.btn_back_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_notificationManager_TITLE = New System.Windows.Forms.Label()
        Me.btn_removeFromNotification_process = New System.Windows.Forms.Button()
        Me.btn_searchStaff_process = New System.Windows.Forms.Button()
        Me.btn_addAllStaff_process = New System.Windows.Forms.Button()
        Me.btn_sendNotification_process = New System.Windows.Forms.Button()
        Me.grp_notificationRecipients = New System.Windows.Forms.GroupBox()
        Me.lst_notificationRecipients = New System.Windows.Forms.ListBox()
        Me.grp_notificationContent = New System.Windows.Forms.GroupBox()
        Me.txt_notificationContent_inp = New System.Windows.Forms.TextBox()
        Me.grp_findStaff = New System.Windows.Forms.GroupBox()
        Me.lbl_searchInstructions = New System.Windows.Forms.Label()
        Me.txt_staffFirstName_inp = New System.Windows.Forms.TextBox()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_notificationRecipients.SuspendLayout()
        Me.grp_notificationContent.SuspendLayout()
        Me.grp_findStaff.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back_redir
        '
        Me.btn_back_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_redir.Location = New System.Drawing.Point(44, 2)
        Me.btn_back_redir.Name = "btn_back_redir"
        Me.btn_back_redir.Size = New System.Drawing.Size(75, 38)
        Me.btn_back_redir.TabIndex = 30
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
        Me.img_blc_logo.TabIndex = 28
        Me.img_blc_logo.TabStop = False
        '
        'lbl_notificationManager_TITLE
        '
        Me.lbl_notificationManager_TITLE.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_notificationManager_TITLE.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notificationManager_TITLE.Location = New System.Drawing.Point(0, 0)
        Me.lbl_notificationManager_TITLE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_notificationManager_TITLE.Name = "lbl_notificationManager_TITLE"
        Me.lbl_notificationManager_TITLE.Size = New System.Drawing.Size(784, 50)
        Me.lbl_notificationManager_TITLE.TabIndex = 29
        Me.lbl_notificationManager_TITLE.Text = "Notification Manager"
        Me.lbl_notificationManager_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_removeFromNotification_process
        '
        Me.btn_removeFromNotification_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_removeFromNotification_process.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removeFromNotification_process.ForeColor = System.Drawing.Color.Red
        Me.btn_removeFromNotification_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_removeFromNotification_process.Location = New System.Drawing.Point(12, 118)
        Me.btn_removeFromNotification_process.Name = "btn_removeFromNotification_process"
        Me.btn_removeFromNotification_process.Size = New System.Drawing.Size(190, 51)
        Me.btn_removeFromNotification_process.TabIndex = 31
        Me.btn_removeFromNotification_process.Text = "Remove from Notification"
        Me.btn_removeFromNotification_process.UseVisualStyleBackColor = True
        '
        'btn_searchStaff_process
        '
        Me.btn_searchStaff_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_searchStaff_process.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchStaff_process.ForeColor = System.Drawing.Color.Black
        Me.btn_searchStaff_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_searchStaff_process.Location = New System.Drawing.Point(306, 21)
        Me.btn_searchStaff_process.Name = "btn_searchStaff_process"
        Me.btn_searchStaff_process.Size = New System.Drawing.Size(75, 31)
        Me.btn_searchStaff_process.TabIndex = 33
        Me.btn_searchStaff_process.Text = "Add"
        Me.btn_searchStaff_process.UseVisualStyleBackColor = True
        '
        'btn_addAllStaff_process
        '
        Me.btn_addAllStaff_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_addAllStaff_process.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addAllStaff_process.ForeColor = System.Drawing.Color.Black
        Me.btn_addAllStaff_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addAllStaff_process.Location = New System.Drawing.Point(208, 118)
        Me.btn_addAllStaff_process.Name = "btn_addAllStaff_process"
        Me.btn_addAllStaff_process.Size = New System.Drawing.Size(189, 51)
        Me.btn_addAllStaff_process.TabIndex = 34
        Me.btn_addAllStaff_process.Text = "Add all staff to notification"
        Me.btn_addAllStaff_process.UseVisualStyleBackColor = True
        '
        'btn_sendNotification_process
        '
        Me.btn_sendNotification_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_sendNotification_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sendNotification_process.ForeColor = System.Drawing.Color.Black
        Me.btn_sendNotification_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sendNotification_process.Location = New System.Drawing.Point(499, 318)
        Me.btn_sendNotification_process.Name = "btn_sendNotification_process"
        Me.btn_sendNotification_process.Size = New System.Drawing.Size(185, 69)
        Me.btn_sendNotification_process.TabIndex = 35
        Me.btn_sendNotification_process.Text = "Send Notification"
        Me.btn_sendNotification_process.UseVisualStyleBackColor = True
        '
        'grp_notificationRecipients
        '
        Me.grp_notificationRecipients.Controls.Add(Me.lst_notificationRecipients)
        Me.grp_notificationRecipients.Location = New System.Drawing.Point(12, 175)
        Me.grp_notificationRecipients.Name = "grp_notificationRecipients"
        Me.grp_notificationRecipients.Size = New System.Drawing.Size(385, 224)
        Me.grp_notificationRecipients.TabIndex = 36
        Me.grp_notificationRecipients.TabStop = False
        Me.grp_notificationRecipients.Text = "Notification Recipients:"
        '
        'lst_notificationRecipients
        '
        Me.lst_notificationRecipients.FormattingEnabled = True
        Me.lst_notificationRecipients.Location = New System.Drawing.Point(6, 20)
        Me.lst_notificationRecipients.Name = "lst_notificationRecipients"
        Me.lst_notificationRecipients.Size = New System.Drawing.Size(373, 199)
        Me.lst_notificationRecipients.TabIndex = 0
        '
        'grp_notificationContent
        '
        Me.grp_notificationContent.Controls.Add(Me.txt_notificationContent_inp)
        Me.grp_notificationContent.Location = New System.Drawing.Point(414, 46)
        Me.grp_notificationContent.Name = "grp_notificationContent"
        Me.grp_notificationContent.Size = New System.Drawing.Size(363, 259)
        Me.grp_notificationContent.TabIndex = 37
        Me.grp_notificationContent.TabStop = False
        Me.grp_notificationContent.Text = "Notification Content:"
        '
        'txt_notificationContent_inp
        '
        Me.txt_notificationContent_inp.Location = New System.Drawing.Point(6, 20)
        Me.txt_notificationContent_inp.Multiline = True
        Me.txt_notificationContent_inp.Name = "txt_notificationContent_inp"
        Me.txt_notificationContent_inp.Size = New System.Drawing.Size(351, 233)
        Me.txt_notificationContent_inp.TabIndex = 0
        '
        'grp_findStaff
        '
        Me.grp_findStaff.Controls.Add(Me.lbl_searchInstructions)
        Me.grp_findStaff.Controls.Add(Me.txt_staffFirstName_inp)
        Me.grp_findStaff.Controls.Add(Me.btn_searchStaff_process)
        Me.grp_findStaff.Location = New System.Drawing.Point(12, 46)
        Me.grp_findStaff.Name = "grp_findStaff"
        Me.grp_findStaff.Size = New System.Drawing.Size(385, 66)
        Me.grp_findStaff.TabIndex = 38
        Me.grp_findStaff.TabStop = False
        Me.grp_findStaff.Text = "Find Staff Member:"
        '
        'lbl_searchInstructions
        '
        Me.lbl_searchInstructions.AutoSize = True
        Me.lbl_searchInstructions.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_searchInstructions.Location = New System.Drawing.Point(2, 17)
        Me.lbl_searchInstructions.Name = "lbl_searchInstructions"
        Me.lbl_searchInstructions.Size = New System.Drawing.Size(151, 38)
        Me.lbl_searchInstructions.TabIndex = 34
        Me.lbl_searchInstructions.Text = "Search Staff " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Member (First Name):"
        Me.lbl_searchInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_staffFirstName_inp
        '
        Me.txt_staffFirstName_inp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffFirstName_inp.Location = New System.Drawing.Point(159, 24)
        Me.txt_staffFirstName_inp.Name = "txt_staffFirstName_inp"
        Me.txt_staffFirstName_inp.Size = New System.Drawing.Size(141, 27)
        Me.txt_staffFirstName_inp.TabIndex = 0
        '
        'frm_notificationManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 406)
        Me.Controls.Add(Me.grp_findStaff)
        Me.Controls.Add(Me.grp_notificationContent)
        Me.Controls.Add(Me.grp_notificationRecipients)
        Me.Controls.Add(Me.btn_sendNotification_process)
        Me.Controls.Add(Me.btn_addAllStaff_process)
        Me.Controls.Add(Me.btn_removeFromNotification_process)
        Me.Controls.Add(Me.btn_back_redir)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Controls.Add(Me.lbl_notificationManager_TITLE)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_notificationManager"
        Me.Text = "BLC Shift Manager (Notification Manager)"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_notificationRecipients.ResumeLayout(False)
        Me.grp_notificationContent.ResumeLayout(False)
        Me.grp_notificationContent.PerformLayout()
        Me.grp_findStaff.ResumeLayout(False)
        Me.grp_findStaff.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_back_redir As Button
    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_notificationManager_TITLE As Label
    Friend WithEvents btn_removeFromNotification_process As Button
    Friend WithEvents btn_searchStaff_process As Button
    Friend WithEvents btn_addAllStaff_process As Button
    Friend WithEvents btn_sendNotification_process As Button
    Friend WithEvents grp_notificationRecipients As GroupBox
    Friend WithEvents lst_notificationRecipients As ListBox
    Friend WithEvents grp_notificationContent As GroupBox
    Friend WithEvents txt_notificationContent_inp As TextBox
    Friend WithEvents grp_findStaff As GroupBox
    Friend WithEvents lbl_searchInstructions As Label
    Friend WithEvents txt_staffFirstName_inp As TextBox
End Class
