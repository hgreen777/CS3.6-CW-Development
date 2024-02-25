<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_allShifts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_allShifts))
        Me.grp_allShifts = New System.Windows.Forms.GroupBox()
        Me.lst_allShifts = New System.Windows.Forms.ListBox()
        Me.lbl_endTime = New System.Windows.Forms.Label()
        Me.lbl_startTime = New System.Windows.Forms.Label()
        Me.txt_startTime_inp = New System.Windows.Forms.TextBox()
        Me.txt_endTime_inp = New System.Windows.Forms.TextBox()
        Me.grp_shiftControl = New System.Windows.Forms.GroupBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.lbl_endDateTime_dynamic = New System.Windows.Forms.Label()
        Me.lbl_startDateTime_dynamic = New System.Windows.Forms.Label()
        Me.grp_selectedShift = New System.Windows.Forms.GroupBox()
        Me.lbl_shiftID_dynamic = New System.Windows.Forms.Label()
        Me.lbl_endDateTime_static = New System.Windows.Forms.Label()
        Me.lbl_startDateTime_static = New System.Windows.Forms.Label()
        Me.lbl_shiftID_static = New System.Windows.Forms.Label()
        Me.btn_back_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_allShifts_TITLE = New System.Windows.Forms.Label()
        Me.chkbox_filterTaken = New System.Windows.Forms.CheckBox()
        Me.btn_assignShift_redir = New System.Windows.Forms.Button()
        Me.btn_editShift_process = New System.Windows.Forms.Button()
        Me.btn_addShift_process = New System.Windows.Forms.Button()
        Me.btn_removeShift_process = New System.Windows.Forms.Button()
        Me.grp_allShifts.SuspendLayout()
        Me.grp_shiftControl.SuspendLayout()
        Me.grp_selectedShift.SuspendLayout()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_allShifts
        '
        Me.grp_allShifts.Controls.Add(Me.lst_allShifts)
        Me.grp_allShifts.Location = New System.Drawing.Point(9, 46)
        Me.grp_allShifts.Name = "grp_allShifts"
        Me.grp_allShifts.Size = New System.Drawing.Size(375, 392)
        Me.grp_allShifts.TabIndex = 22
        Me.grp_allShifts.TabStop = False
        Me.grp_allShifts.Text = "All Shifts:"
        '
        'lst_allShifts
        '
        Me.lst_allShifts.FormattingEnabled = True
        Me.lst_allShifts.Location = New System.Drawing.Point(6, 19)
        Me.lst_allShifts.Name = "lst_allShifts"
        Me.lst_allShifts.Size = New System.Drawing.Size(363, 368)
        Me.lst_allShifts.TabIndex = 0
        '
        'lbl_endTime
        '
        Me.lbl_endTime.AutoSize = True
        Me.lbl_endTime.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_endTime.Location = New System.Drawing.Point(6, 98)
        Me.lbl_endTime.Name = "lbl_endTime"
        Me.lbl_endTime.Size = New System.Drawing.Size(93, 24)
        Me.lbl_endTime.TabIndex = 3
        Me.lbl_endTime.Text = "End Time:"
        '
        'lbl_startTime
        '
        Me.lbl_startTime.AutoSize = True
        Me.lbl_startTime.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_startTime.Location = New System.Drawing.Point(6, 55)
        Me.lbl_startTime.Name = "lbl_startTime"
        Me.lbl_startTime.Size = New System.Drawing.Size(101, 24)
        Me.lbl_startTime.TabIndex = 2
        Me.lbl_startTime.Text = "Start Time:"
        '
        'txt_startTime_inp
        '
        Me.txt_startTime_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_startTime_inp.Location = New System.Drawing.Point(155, 52)
        Me.txt_startTime_inp.Name = "txt_startTime_inp"
        Me.txt_startTime_inp.Size = New System.Drawing.Size(100, 32)
        Me.txt_startTime_inp.TabIndex = 1
        Me.txt_startTime_inp.Text = "HH:mm"
        '
        'txt_endTime_inp
        '
        Me.txt_endTime_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endTime_inp.Location = New System.Drawing.Point(155, 95)
        Me.txt_endTime_inp.Name = "txt_endTime_inp"
        Me.txt_endTime_inp.Size = New System.Drawing.Size(100, 32)
        Me.txt_endTime_inp.TabIndex = 0
        Me.txt_endTime_inp.Text = "HH:mm"
        '
        'grp_shiftControl
        '
        Me.grp_shiftControl.Controls.Add(Me.lbl_date)
        Me.grp_shiftControl.Controls.Add(Me.DatePicker)
        Me.grp_shiftControl.Controls.Add(Me.lbl_endTime)
        Me.grp_shiftControl.Controls.Add(Me.lbl_startTime)
        Me.grp_shiftControl.Controls.Add(Me.txt_startTime_inp)
        Me.grp_shiftControl.Controls.Add(Me.txt_endTime_inp)
        Me.grp_shiftControl.Location = New System.Drawing.Point(393, 193)
        Me.grp_shiftControl.Name = "grp_shiftControl"
        Me.grp_shiftControl.Size = New System.Drawing.Size(375, 137)
        Me.grp_shiftControl.TabIndex = 23
        Me.grp_shiftControl.TabStop = False
        Me.grp_shiftControl.Text = "Shift Control:"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_date.Location = New System.Drawing.Point(6, 17)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(54, 24)
        Me.lbl_date.TabIndex = 5
        Me.lbl_date.Text = "Date:"
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(139, 19)
        Me.DatePicker.MinDate = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(137, 20)
        Me.DatePicker.TabIndex = 4
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
        'grp_selectedShift
        '
        Me.grp_selectedShift.Controls.Add(Me.lbl_endDateTime_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.lbl_startDateTime_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.lbl_shiftID_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.lbl_endDateTime_static)
        Me.grp_selectedShift.Controls.Add(Me.lbl_startDateTime_static)
        Me.grp_selectedShift.Controls.Add(Me.lbl_shiftID_static)
        Me.grp_selectedShift.Location = New System.Drawing.Point(393, 53)
        Me.grp_selectedShift.Name = "grp_selectedShift"
        Me.grp_selectedShift.Size = New System.Drawing.Size(375, 125)
        Me.grp_selectedShift.TabIndex = 24
        Me.grp_selectedShift.TabStop = False
        Me.grp_selectedShift.Text = "Selected Shift:"
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
        'btn_back_redir
        '
        Me.btn_back_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_redir.Location = New System.Drawing.Point(44, 2)
        Me.btn_back_redir.Name = "btn_back_redir"
        Me.btn_back_redir.Size = New System.Drawing.Size(75, 38)
        Me.btn_back_redir.TabIndex = 21
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
        Me.img_blc_logo.TabIndex = 19
        Me.img_blc_logo.TabStop = False
        '
        'lbl_allShifts_TITLE
        '
        Me.lbl_allShifts_TITLE.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_allShifts_TITLE.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_allShifts_TITLE.Location = New System.Drawing.Point(0, 0)
        Me.lbl_allShifts_TITLE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_allShifts_TITLE.Name = "lbl_allShifts_TITLE"
        Me.lbl_allShifts_TITLE.Size = New System.Drawing.Size(800, 50)
        Me.lbl_allShifts_TITLE.TabIndex = 20
        Me.lbl_allShifts_TITLE.Text = "All Shifts"
        Me.lbl_allShifts_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkbox_filterTaken
        '
        Me.chkbox_filterTaken.AutoSize = True
        Me.chkbox_filterTaken.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbox_filterTaken.Location = New System.Drawing.Point(556, 18)
        Me.chkbox_filterTaken.Name = "chkbox_filterTaken"
        Me.chkbox_filterTaken.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkbox_filterTaken.Size = New System.Drawing.Size(212, 28)
        Me.chkbox_filterTaken.TabIndex = 25
        Me.chkbox_filterTaken.Text = ":Filter out taken Shifts"
        Me.chkbox_filterTaken.UseVisualStyleBackColor = True
        '
        'btn_assignShift_redir
        '
        Me.btn_assignShift_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_assignShift_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_assignShift_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_assignShift_redir.Location = New System.Drawing.Point(403, 336)
        Me.btn_assignShift_redir.Name = "btn_assignShift_redir"
        Me.btn_assignShift_redir.Size = New System.Drawing.Size(150, 42)
        Me.btn_assignShift_redir.TabIndex = 20
        Me.btn_assignShift_redir.Text = "Assign Shift"
        Me.btn_assignShift_redir.UseVisualStyleBackColor = True
        '
        'btn_editShift_process
        '
        Me.btn_editShift_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editShift_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editShift_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_editShift_process.Location = New System.Drawing.Point(604, 336)
        Me.btn_editShift_process.Name = "btn_editShift_process"
        Me.btn_editShift_process.Size = New System.Drawing.Size(150, 42)
        Me.btn_editShift_process.TabIndex = 26
        Me.btn_editShift_process.Text = "Edit Shift"
        Me.btn_editShift_process.UseVisualStyleBackColor = True
        '
        'btn_addShift_process
        '
        Me.btn_addShift_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_addShift_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addShift_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addShift_process.Location = New System.Drawing.Point(403, 384)
        Me.btn_addShift_process.Name = "btn_addShift_process"
        Me.btn_addShift_process.Size = New System.Drawing.Size(150, 42)
        Me.btn_addShift_process.TabIndex = 27
        Me.btn_addShift_process.Text = "Add Shift"
        Me.btn_addShift_process.UseVisualStyleBackColor = True
        '
        'btn_removeShift_process
        '
        Me.btn_removeShift_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_removeShift_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removeShift_process.ForeColor = System.Drawing.Color.Red
        Me.btn_removeShift_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_removeShift_process.Location = New System.Drawing.Point(604, 384)
        Me.btn_removeShift_process.Name = "btn_removeShift_process"
        Me.btn_removeShift_process.Size = New System.Drawing.Size(150, 42)
        Me.btn_removeShift_process.TabIndex = 28
        Me.btn_removeShift_process.Text = "Remove Shift"
        Me.btn_removeShift_process.UseVisualStyleBackColor = True
        '
        'frm_allShifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 451)
        Me.Controls.Add(Me.btn_removeShift_process)
        Me.Controls.Add(Me.btn_addShift_process)
        Me.Controls.Add(Me.btn_editShift_process)
        Me.Controls.Add(Me.btn_assignShift_redir)
        Me.Controls.Add(Me.chkbox_filterTaken)
        Me.Controls.Add(Me.grp_allShifts)
        Me.Controls.Add(Me.grp_shiftControl)
        Me.Controls.Add(Me.grp_selectedShift)
        Me.Controls.Add(Me.btn_back_redir)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Controls.Add(Me.lbl_allShifts_TITLE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_allShifts"
        Me.Text = "BLC Shift Manager (All Shifts)"
        Me.grp_allShifts.ResumeLayout(False)
        Me.grp_shiftControl.ResumeLayout(False)
        Me.grp_shiftControl.PerformLayout()
        Me.grp_selectedShift.ResumeLayout(False)
        Me.grp_selectedShift.PerformLayout()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_allShifts As GroupBox
    Friend WithEvents lst_allShifts As ListBox
    Friend WithEvents lbl_endTime As Label
    Friend WithEvents lbl_startTime As Label
    Friend WithEvents txt_startTime_inp As TextBox
    Friend WithEvents txt_endTime_inp As TextBox
    Friend WithEvents grp_shiftControl As GroupBox
    Friend WithEvents lbl_endDateTime_dynamic As Label
    Friend WithEvents lbl_startDateTime_dynamic As Label
    Friend WithEvents grp_selectedShift As GroupBox
    Friend WithEvents lbl_shiftID_dynamic As Label
    Friend WithEvents lbl_endDateTime_static As Label
    Friend WithEvents lbl_startDateTime_static As Label
    Friend WithEvents lbl_shiftID_static As Label
    Friend WithEvents btn_back_redir As Button
    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_allShifts_TITLE As Label
    Friend WithEvents chkbox_filterTaken As CheckBox
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_assignShift_redir As Button
    Friend WithEvents btn_editShift_process As Button
    Friend WithEvents btn_addShift_process As Button
    Friend WithEvents btn_removeShift_process As Button
End Class
