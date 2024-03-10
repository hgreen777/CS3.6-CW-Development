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
        Me.lst_allShifts = New System.Windows.Forms.ListView()
        Me.shiftID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.startTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.endTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.isTaken = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.takenBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_endTime = New System.Windows.Forms.Label()
        Me.lbl_startTime = New System.Windows.Forms.Label()
        Me.txt_startTime_inp = New System.Windows.Forms.TextBox()
        Me.txt_endTime_inp = New System.Windows.Forms.TextBox()
        Me.grp_shiftControl = New System.Windows.Forms.GroupBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.dtePicker_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_endDateTime_dynamic = New System.Windows.Forms.Label()
        Me.lbl_startDateTime_dynamic = New System.Windows.Forms.Label()
        Me.grp_selectedShift = New System.Windows.Forms.GroupBox()
        Me.lbl_takenBy_dynamic = New System.Windows.Forms.Label()
        Me.lbl_isTaken_dynamic = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_isTaken_static = New System.Windows.Forms.Label()
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
        Me.grp_allShifts.Size = New System.Drawing.Size(540, 436)
        Me.grp_allShifts.TabIndex = 22
        Me.grp_allShifts.TabStop = False
        Me.grp_allShifts.Text = "All Shifts:"
        '
        'lst_allShifts
        '
        Me.lst_allShifts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.shiftID, Me.startTime, Me.endTime, Me.isTaken, Me.takenBy})
        Me.lst_allShifts.FullRowSelect = True
        Me.lst_allShifts.HideSelection = False
        Me.lst_allShifts.Location = New System.Drawing.Point(6, 19)
        Me.lst_allShifts.Name = "lst_allShifts"
        Me.lst_allShifts.Size = New System.Drawing.Size(528, 411)
        Me.lst_allShifts.TabIndex = 10
        Me.lst_allShifts.UseCompatibleStateImageBehavior = False
        Me.lst_allShifts.View = System.Windows.Forms.View.Details
        '
        'shiftID
        '
        Me.shiftID.Text = "ShiftID"
        Me.shiftID.Width = 47
        '
        'startTime
        '
        Me.startTime.Text = "Start Time"
        Me.startTime.Width = 130
        '
        'endTime
        '
        Me.endTime.Text = "End Time"
        Me.endTime.Width = 130
        '
        'isTaken
        '
        Me.isTaken.Text = "Is Taken"
        Me.isTaken.Width = 87
        '
        'takenBy
        '
        Me.takenBy.Text = "Taken By"
        Me.takenBy.Width = 111
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
        Me.txt_startTime_inp.TabIndex = 2
        Me.txt_startTime_inp.Text = "HH:mm"
        '
        'txt_endTime_inp
        '
        Me.txt_endTime_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endTime_inp.Location = New System.Drawing.Point(155, 95)
        Me.txt_endTime_inp.Name = "txt_endTime_inp"
        Me.txt_endTime_inp.Size = New System.Drawing.Size(100, 32)
        Me.txt_endTime_inp.TabIndex = 3
        Me.txt_endTime_inp.Text = "HH:mm"
        '
        'grp_shiftControl
        '
        Me.grp_shiftControl.Controls.Add(Me.lbl_date)
        Me.grp_shiftControl.Controls.Add(Me.dtePicker_date)
        Me.grp_shiftControl.Controls.Add(Me.lbl_endTime)
        Me.grp_shiftControl.Controls.Add(Me.lbl_startTime)
        Me.grp_shiftControl.Controls.Add(Me.txt_startTime_inp)
        Me.grp_shiftControl.Controls.Add(Me.txt_endTime_inp)
        Me.grp_shiftControl.Location = New System.Drawing.Point(555, 249)
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
        'dtePicker_date
        '
        Me.dtePicker_date.Location = New System.Drawing.Point(139, 19)
        Me.dtePicker_date.MinDate = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.dtePicker_date.Name = "dtePicker_date"
        Me.dtePicker_date.Size = New System.Drawing.Size(137, 20)
        Me.dtePicker_date.TabIndex = 1
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
        Me.grp_selectedShift.Controls.Add(Me.lbl_takenBy_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.lbl_isTaken_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.Label1)
        Me.grp_selectedShift.Controls.Add(Me.lbl_isTaken_static)
        Me.grp_selectedShift.Controls.Add(Me.lbl_endDateTime_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.lbl_startDateTime_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.lbl_shiftID_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.lbl_endDateTime_static)
        Me.grp_selectedShift.Controls.Add(Me.lbl_startDateTime_static)
        Me.grp_selectedShift.Controls.Add(Me.lbl_shiftID_static)
        Me.grp_selectedShift.Location = New System.Drawing.Point(555, 53)
        Me.grp_selectedShift.Name = "grp_selectedShift"
        Me.grp_selectedShift.Size = New System.Drawing.Size(375, 190)
        Me.grp_selectedShift.TabIndex = 24
        Me.grp_selectedShift.TabStop = False
        Me.grp_selectedShift.Text = "Selected Shift:"
        '
        'lbl_takenBy_dynamic
        '
        Me.lbl_takenBy_dynamic.AutoSize = True
        Me.lbl_takenBy_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_takenBy_dynamic.Location = New System.Drawing.Point(151, 160)
        Me.lbl_takenBy_dynamic.Name = "lbl_takenBy_dynamic"
        Me.lbl_takenBy_dynamic.Size = New System.Drawing.Size(155, 24)
        Me.lbl_takenBy_dynamic.TabIndex = 13
        Me.lbl_takenBy_dynamic.Text = "<StaffUserName>"
        '
        'lbl_isTaken_dynamic
        '
        Me.lbl_isTaken_dynamic.AutoSize = True
        Me.lbl_isTaken_dynamic.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_isTaken_dynamic.Location = New System.Drawing.Point(151, 126)
        Me.lbl_isTaken_dynamic.Name = "lbl_isTaken_dynamic"
        Me.lbl_isTaken_dynamic.Size = New System.Drawing.Size(89, 24)
        Me.lbl_isTaken_dynamic.TabIndex = 12
        Me.lbl_isTaken_dynamic.Text = "<Yes/No>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Taken By:"
        '
        'lbl_isTaken_static
        '
        Me.lbl_isTaken_static.AutoSize = True
        Me.lbl_isTaken_static.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_isTaken_static.Location = New System.Drawing.Point(6, 126)
        Me.lbl_isTaken_static.Name = "lbl_isTaken_static"
        Me.lbl_isTaken_static.Size = New System.Drawing.Size(80, 24)
        Me.lbl_isTaken_static.TabIndex = 10
        Me.lbl_isTaken_static.Text = "Is Taken:"
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
        Me.btn_back_redir.TabIndex = 8
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
        Me.lbl_allShifts_TITLE.Size = New System.Drawing.Size(942, 50)
        Me.lbl_allShifts_TITLE.TabIndex = 20
        Me.lbl_allShifts_TITLE.Text = "All Shifts"
        Me.lbl_allShifts_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkbox_filterTaken
        '
        Me.chkbox_filterTaken.AutoSize = True
        Me.chkbox_filterTaken.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbox_filterTaken.Location = New System.Drawing.Point(718, 19)
        Me.chkbox_filterTaken.Name = "chkbox_filterTaken"
        Me.chkbox_filterTaken.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkbox_filterTaken.Size = New System.Drawing.Size(212, 28)
        Me.chkbox_filterTaken.TabIndex = 9
        Me.chkbox_filterTaken.Text = ":Filter out taken Shifts"
        Me.chkbox_filterTaken.UseVisualStyleBackColor = True
        '
        'btn_assignShift_redir
        '
        Me.btn_assignShift_redir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_assignShift_redir.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_assignShift_redir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_assignShift_redir.Location = New System.Drawing.Point(565, 392)
        Me.btn_assignShift_redir.Name = "btn_assignShift_redir"
        Me.btn_assignShift_redir.Size = New System.Drawing.Size(150, 42)
        Me.btn_assignShift_redir.TabIndex = 4
        Me.btn_assignShift_redir.Text = "Assign Shift"
        Me.btn_assignShift_redir.UseVisualStyleBackColor = True
        '
        'btn_editShift_process
        '
        Me.btn_editShift_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editShift_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editShift_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_editShift_process.Location = New System.Drawing.Point(766, 392)
        Me.btn_editShift_process.Name = "btn_editShift_process"
        Me.btn_editShift_process.Size = New System.Drawing.Size(150, 42)
        Me.btn_editShift_process.TabIndex = 6
        Me.btn_editShift_process.Text = "Edit Shift"
        Me.btn_editShift_process.UseVisualStyleBackColor = True
        '
        'btn_addShift_process
        '
        Me.btn_addShift_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_addShift_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addShift_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addShift_process.Location = New System.Drawing.Point(565, 440)
        Me.btn_addShift_process.Name = "btn_addShift_process"
        Me.btn_addShift_process.Size = New System.Drawing.Size(150, 42)
        Me.btn_addShift_process.TabIndex = 5
        Me.btn_addShift_process.Text = "Add Shift"
        Me.btn_addShift_process.UseVisualStyleBackColor = True
        '
        'btn_removeShift_process
        '
        Me.btn_removeShift_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_removeShift_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removeShift_process.ForeColor = System.Drawing.Color.Red
        Me.btn_removeShift_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_removeShift_process.Location = New System.Drawing.Point(766, 440)
        Me.btn_removeShift_process.Name = "btn_removeShift_process"
        Me.btn_removeShift_process.Size = New System.Drawing.Size(150, 42)
        Me.btn_removeShift_process.TabIndex = 7
        Me.btn_removeShift_process.Text = "Remove Shift"
        Me.btn_removeShift_process.UseVisualStyleBackColor = True
        '
        'frm_allShifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 494)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents dtePicker_date As DateTimePicker
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_assignShift_redir As Button
    Friend WithEvents btn_editShift_process As Button
    Friend WithEvents btn_addShift_process As Button
    Friend WithEvents btn_removeShift_process As Button
    Friend WithEvents lst_allShifts As ListView
    Friend WithEvents shiftID As ColumnHeader
    Friend WithEvents startTime As ColumnHeader
    Friend WithEvents endTime As ColumnHeader
    Friend WithEvents isTaken As ColumnHeader
    Friend WithEvents takenBy As ColumnHeader
    Friend WithEvents lbl_takenBy_dynamic As Label
    Friend WithEvents lbl_isTaken_dynamic As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_isTaken_static As Label
End Class
