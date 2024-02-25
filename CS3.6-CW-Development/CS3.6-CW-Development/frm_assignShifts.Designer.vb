<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_assignShifts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_assignShifts))
        Me.btn_back_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_assignShifts_TITLE = New System.Windows.Forms.Label()
        Me.lbl_searchInstructions = New System.Windows.Forms.Label()
        Me.txt_firstName_search = New System.Windows.Forms.TextBox()
        Me.btn_searchStaff_process = New System.Windows.Forms.Button()
        Me.grp_shiftDetails = New System.Windows.Forms.GroupBox()
        Me.lbl_endDateTime_dynamic = New System.Windows.Forms.Label()
        Me.lbl_startDateTime_dynamic = New System.Windows.Forms.Label()
        Me.lbl_shiftID_dynamic = New System.Windows.Forms.Label()
        Me.lbl_endDateTime_static = New System.Windows.Forms.Label()
        Me.lbl_startDateTime_static = New System.Windows.Forms.Label()
        Me.lbl_shiftID_static = New System.Windows.Forms.Label()
        Me.grp_shiftControl = New System.Windows.Forms.GroupBox()
        Me.lbl_endTime = New System.Windows.Forms.Label()
        Me.lbl_startTime = New System.Windows.Forms.Label()
        Me.txt_startTime_inp = New System.Windows.Forms.TextBox()
        Me.txt_endTime_inp = New System.Windows.Forms.TextBox()
        Me.btn_assignShift_redir = New System.Windows.Forms.Button()
        Me.grp_staffDetails = New System.Windows.Forms.GroupBox()
        Me.lbl_staffFirstName_dynamic = New System.Windows.Forms.Label()
        Me.lbl_StaffUserName_dynamic = New System.Windows.Forms.Label()
        Me.lbl_staffFirstName_static = New System.Windows.Forms.Label()
        Me.lbl_staffUserName_static = New System.Windows.Forms.Label()
        Me.img_arrow = New System.Windows.Forms.PictureBox()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_shiftDetails.SuspendLayout()
        Me.grp_shiftControl.SuspendLayout()
        Me.grp_staffDetails.SuspendLayout()
        CType(Me.img_arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back_redir
        '
        Me.btn_back_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_redir.Location = New System.Drawing.Point(44, 2)
        Me.btn_back_redir.Name = "btn_back_redir"
        Me.btn_back_redir.Size = New System.Drawing.Size(75, 38)
        Me.btn_back_redir.TabIndex = 24
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
        Me.img_blc_logo.TabIndex = 22
        Me.img_blc_logo.TabStop = False
        '
        'lbl_assignShifts_TITLE
        '
        Me.lbl_assignShifts_TITLE.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_assignShifts_TITLE.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_assignShifts_TITLE.Location = New System.Drawing.Point(0, 0)
        Me.lbl_assignShifts_TITLE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_assignShifts_TITLE.Name = "lbl_assignShifts_TITLE"
        Me.lbl_assignShifts_TITLE.Size = New System.Drawing.Size(835, 50)
        Me.lbl_assignShifts_TITLE.TabIndex = 23
        Me.lbl_assignShifts_TITLE.Text = "Assign Shift"
        Me.lbl_assignShifts_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_searchInstructions
        '
        Me.lbl_searchInstructions.AutoSize = True
        Me.lbl_searchInstructions.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_searchInstructions.Location = New System.Drawing.Point(100, 55)
        Me.lbl_searchInstructions.Name = "lbl_searchInstructions"
        Me.lbl_searchInstructions.Size = New System.Drawing.Size(325, 24)
        Me.lbl_searchInstructions.TabIndex = 25
        Me.lbl_searchInstructions.Text = "Search for Staff Member (First Name):"
        '
        'txt_firstName_search
        '
        Me.txt_firstName_search.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_firstName_search.Location = New System.Drawing.Point(431, 52)
        Me.txt_firstName_search.Name = "txt_firstName_search"
        Me.txt_firstName_search.Size = New System.Drawing.Size(141, 32)
        Me.txt_firstName_search.TabIndex = 26
        '
        'btn_searchStaff_process
        '
        Me.btn_searchStaff_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_searchStaff_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchStaff_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_searchStaff_process.Location = New System.Drawing.Point(594, 51)
        Me.btn_searchStaff_process.Name = "btn_searchStaff_process"
        Me.btn_searchStaff_process.Size = New System.Drawing.Size(150, 32)
        Me.btn_searchStaff_process.TabIndex = 29
        Me.btn_searchStaff_process.Text = "SEARCH"
        Me.btn_searchStaff_process.UseVisualStyleBackColor = True
        '
        'grp_shiftDetails
        '
        Me.grp_shiftDetails.Controls.Add(Me.lbl_endDateTime_dynamic)
        Me.grp_shiftDetails.Controls.Add(Me.lbl_startDateTime_dynamic)
        Me.grp_shiftDetails.Controls.Add(Me.lbl_shiftID_dynamic)
        Me.grp_shiftDetails.Controls.Add(Me.lbl_endDateTime_static)
        Me.grp_shiftDetails.Controls.Add(Me.lbl_startDateTime_static)
        Me.grp_shiftDetails.Controls.Add(Me.lbl_shiftID_static)
        Me.grp_shiftDetails.Location = New System.Drawing.Point(12, 100)
        Me.grp_shiftDetails.Name = "grp_shiftDetails"
        Me.grp_shiftDetails.Size = New System.Drawing.Size(375, 125)
        Me.grp_shiftDetails.TabIndex = 30
        Me.grp_shiftDetails.TabStop = False
        Me.grp_shiftDetails.Text = "Shift Details:"
        '
        'lbl_endDateTime_dynamic
        '
        Me.lbl_endDateTime_dynamic.AutoSize = True
        Me.lbl_endDateTime_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_endDateTime_dynamic.Location = New System.Drawing.Point(151, 88)
        Me.lbl_endDateTime_dynamic.Name = "lbl_endDateTime_dynamic"
        Me.lbl_endDateTime_dynamic.Size = New System.Drawing.Size(210, 24)
        Me.lbl_endDateTime_dynamic.TabIndex = 9
        Me.lbl_endDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
        '
        'lbl_startDateTime_dynamic
        '
        Me.lbl_startDateTime_dynamic.AutoSize = True
        Me.lbl_startDateTime_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_startDateTime_dynamic.Location = New System.Drawing.Point(151, 53)
        Me.lbl_startDateTime_dynamic.Name = "lbl_startDateTime_dynamic"
        Me.lbl_startDateTime_dynamic.Size = New System.Drawing.Size(210, 24)
        Me.lbl_startDateTime_dynamic.TabIndex = 8
        Me.lbl_startDateTime_dynamic.Text = "<DD/MM/YYYY HH:mm>"
        '
        'lbl_shiftID_dynamic
        '
        Me.lbl_shiftID_dynamic.AutoSize = True
        Me.lbl_shiftID_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_shiftID_dynamic.Location = New System.Drawing.Point(151, 19)
        Me.lbl_shiftID_dynamic.Name = "lbl_shiftID_dynamic"
        Me.lbl_shiftID_dynamic.Size = New System.Drawing.Size(84, 24)
        Me.lbl_shiftID_dynamic.TabIndex = 7
        Me.lbl_shiftID_dynamic.Text = "<ShiftID>"
        '
        'lbl_endDateTime_static
        '
        Me.lbl_endDateTime_static.AutoSize = True
        Me.lbl_endDateTime_static.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_endDateTime_static.Location = New System.Drawing.Point(6, 88)
        Me.lbl_endDateTime_static.Name = "lbl_endDateTime_static"
        Me.lbl_endDateTime_static.Size = New System.Drawing.Size(140, 24)
        Me.lbl_endDateTime_static.TabIndex = 6
        Me.lbl_endDateTime_static.Text = "End Date/Time:"
        '
        'lbl_startDateTime_static
        '
        Me.lbl_startDateTime_static.AutoSize = True
        Me.lbl_startDateTime_static.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_startDateTime_static.Location = New System.Drawing.Point(6, 53)
        Me.lbl_startDateTime_static.Name = "lbl_startDateTime_static"
        Me.lbl_startDateTime_static.Size = New System.Drawing.Size(148, 24)
        Me.lbl_startDateTime_static.TabIndex = 5
        Me.lbl_startDateTime_static.Text = "Start Date/Time:"
        '
        'lbl_shiftID_static
        '
        Me.lbl_shiftID_static.AutoSize = True
        Me.lbl_shiftID_static.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_shiftID_static.Location = New System.Drawing.Point(6, 19)
        Me.lbl_shiftID_static.Name = "lbl_shiftID_static"
        Me.lbl_shiftID_static.Size = New System.Drawing.Size(69, 24)
        Me.lbl_shiftID_static.TabIndex = 4
        Me.lbl_shiftID_static.Text = "ShiftID:"
        '
        'grp_shiftControl
        '
        Me.grp_shiftControl.Controls.Add(Me.lbl_endTime)
        Me.grp_shiftControl.Controls.Add(Me.lbl_startTime)
        Me.grp_shiftControl.Controls.Add(Me.txt_startTime_inp)
        Me.grp_shiftControl.Controls.Add(Me.txt_endTime_inp)
        Me.grp_shiftControl.Location = New System.Drawing.Point(44, 243)
        Me.grp_shiftControl.Name = "grp_shiftControl"
        Me.grp_shiftControl.Size = New System.Drawing.Size(280, 102)
        Me.grp_shiftControl.TabIndex = 31
        Me.grp_shiftControl.TabStop = False
        Me.grp_shiftControl.Text = "Shift Control:"
        '
        'lbl_endTime
        '
        Me.lbl_endTime.AutoSize = True
        Me.lbl_endTime.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_endTime.Location = New System.Drawing.Point(6, 59)
        Me.lbl_endTime.Name = "lbl_endTime"
        Me.lbl_endTime.Size = New System.Drawing.Size(135, 24)
        Me.lbl_endTime.TabIndex = 3
        Me.lbl_endTime.Text = "New End Time:"
        '
        'lbl_startTime
        '
        Me.lbl_startTime.AutoSize = True
        Me.lbl_startTime.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_startTime.Location = New System.Drawing.Point(6, 16)
        Me.lbl_startTime.Name = "lbl_startTime"
        Me.lbl_startTime.Size = New System.Drawing.Size(143, 24)
        Me.lbl_startTime.TabIndex = 2
        Me.lbl_startTime.Text = "New Start Time:"
        '
        'txt_startTime_inp
        '
        Me.txt_startTime_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_startTime_inp.Location = New System.Drawing.Point(155, 13)
        Me.txt_startTime_inp.Name = "txt_startTime_inp"
        Me.txt_startTime_inp.Size = New System.Drawing.Size(100, 32)
        Me.txt_startTime_inp.TabIndex = 1
        Me.txt_startTime_inp.Text = "HH:mm"
        '
        'txt_endTime_inp
        '
        Me.txt_endTime_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endTime_inp.Location = New System.Drawing.Point(155, 56)
        Me.txt_endTime_inp.Name = "txt_endTime_inp"
        Me.txt_endTime_inp.Size = New System.Drawing.Size(100, 32)
        Me.txt_endTime_inp.TabIndex = 0
        Me.txt_endTime_inp.Text = "HH:mm"
        '
        'btn_assignShift_redir
        '
        Me.btn_assignShift_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_assignShift_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_assignShift_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_assignShift_redir.Location = New System.Drawing.Point(578, 259)
        Me.btn_assignShift_redir.Name = "btn_assignShift_redir"
        Me.btn_assignShift_redir.Size = New System.Drawing.Size(185, 72)
        Me.btn_assignShift_redir.TabIndex = 32
        Me.btn_assignShift_redir.Text = "Assign Shift"
        Me.btn_assignShift_redir.UseVisualStyleBackColor = True
        '
        'grp_staffDetails
        '
        Me.grp_staffDetails.Controls.Add(Me.lbl_staffFirstName_dynamic)
        Me.grp_staffDetails.Controls.Add(Me.lbl_StaffUserName_dynamic)
        Me.grp_staffDetails.Controls.Add(Me.lbl_staffFirstName_static)
        Me.grp_staffDetails.Controls.Add(Me.lbl_staffUserName_static)
        Me.grp_staffDetails.Location = New System.Drawing.Point(495, 128)
        Me.grp_staffDetails.Name = "grp_staffDetails"
        Me.grp_staffDetails.Size = New System.Drawing.Size(323, 84)
        Me.grp_staffDetails.TabIndex = 31
        Me.grp_staffDetails.TabStop = False
        Me.grp_staffDetails.Text = "Staff Details:"
        '
        'lbl_staffFirstName_dynamic
        '
        Me.lbl_staffFirstName_dynamic.AutoSize = True
        Me.lbl_staffFirstName_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_staffFirstName_dynamic.Location = New System.Drawing.Point(151, 53)
        Me.lbl_staffFirstName_dynamic.Name = "lbl_staffFirstName_dynamic"
        Me.lbl_staffFirstName_dynamic.Size = New System.Drawing.Size(153, 24)
        Me.lbl_staffFirstName_dynamic.TabIndex = 8
        Me.lbl_staffFirstName_dynamic.Text = "<StaffFirstName>"
        '
        'lbl_StaffUserName_dynamic
        '
        Me.lbl_StaffUserName_dynamic.AutoSize = True
        Me.lbl_StaffUserName_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_StaffUserName_dynamic.Location = New System.Drawing.Point(151, 19)
        Me.lbl_StaffUserName_dynamic.Name = "lbl_StaffUserName_dynamic"
        Me.lbl_StaffUserName_dynamic.Size = New System.Drawing.Size(155, 24)
        Me.lbl_StaffUserName_dynamic.TabIndex = 7
        Me.lbl_StaffUserName_dynamic.Text = "<StaffUserName>"
        '
        'lbl_staffFirstName_static
        '
        Me.lbl_staffFirstName_static.AutoSize = True
        Me.lbl_staffFirstName_static.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_staffFirstName_static.Location = New System.Drawing.Point(6, 53)
        Me.lbl_staffFirstName_static.Name = "lbl_staffFirstName_static"
        Me.lbl_staffFirstName_static.Size = New System.Drawing.Size(148, 24)
        Me.lbl_staffFirstName_static.TabIndex = 5
        Me.lbl_staffFirstName_static.Text = "Staff First Name:"
        '
        'lbl_staffUserName_static
        '
        Me.lbl_staffUserName_static.AutoSize = True
        Me.lbl_staffUserName_static.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_staffUserName_static.Location = New System.Drawing.Point(6, 19)
        Me.lbl_staffUserName_static.Name = "lbl_staffUserName_static"
        Me.lbl_staffUserName_static.Size = New System.Drawing.Size(145, 24)
        Me.lbl_staffUserName_static.TabIndex = 4
        Me.lbl_staffUserName_static.Text = "Staff UserName:"
        '
        'img_arrow
        '
        Me.img_arrow.Image = Global.CS3._6_CW_Development.My.Resources.Resources.img_arrow_2_
        Me.img_arrow.Location = New System.Drawing.Point(387, 153)
        Me.img_arrow.Name = "img_arrow"
        Me.img_arrow.Size = New System.Drawing.Size(102, 40)
        Me.img_arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_arrow.TabIndex = 33
        Me.img_arrow.TabStop = False
        '
        'frm_assignShifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 361)
        Me.Controls.Add(Me.img_arrow)
        Me.Controls.Add(Me.grp_staffDetails)
        Me.Controls.Add(Me.btn_assignShift_redir)
        Me.Controls.Add(Me.grp_shiftControl)
        Me.Controls.Add(Me.grp_shiftDetails)
        Me.Controls.Add(Me.btn_searchStaff_process)
        Me.Controls.Add(Me.txt_firstName_search)
        Me.Controls.Add(Me.lbl_searchInstructions)
        Me.Controls.Add(Me.btn_back_redir)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Controls.Add(Me.lbl_assignShifts_TITLE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_assignShifts"
        Me.Text = "BLC Shift Manager (Assign Shift)"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_shiftDetails.ResumeLayout(False)
        Me.grp_shiftDetails.PerformLayout()
        Me.grp_shiftControl.ResumeLayout(False)
        Me.grp_shiftControl.PerformLayout()
        Me.grp_staffDetails.ResumeLayout(False)
        Me.grp_staffDetails.PerformLayout()
        CType(Me.img_arrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back_redir As Button
    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_assignShifts_TITLE As Label
    Friend WithEvents lbl_searchInstructions As Label
    Friend WithEvents txt_firstName_search As TextBox
    Friend WithEvents btn_searchStaff_process As Button
    Friend WithEvents grp_shiftDetails As GroupBox
    Friend WithEvents lbl_endDateTime_dynamic As Label
    Friend WithEvents lbl_startDateTime_dynamic As Label
    Friend WithEvents lbl_shiftID_dynamic As Label
    Friend WithEvents lbl_endDateTime_static As Label
    Friend WithEvents lbl_startDateTime_static As Label
    Friend WithEvents lbl_shiftID_static As Label
    Friend WithEvents grp_shiftControl As GroupBox
    Friend WithEvents lbl_endTime As Label
    Friend WithEvents lbl_startTime As Label
    Friend WithEvents txt_startTime_inp As TextBox
    Friend WithEvents txt_endTime_inp As TextBox
    Friend WithEvents btn_assignShift_redir As Button
    Friend WithEvents grp_staffDetails As GroupBox
    Friend WithEvents lbl_staffFirstName_dynamic As Label
    Friend WithEvents lbl_StaffUserName_dynamic As Label
    Friend WithEvents lbl_staffFirstName_static As Label
    Friend WithEvents lbl_staffUserName_static As Label
    Friend WithEvents img_arrow As PictureBox
End Class
