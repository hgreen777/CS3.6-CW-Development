<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_takeShifts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_takeShifts))
        Me.btn_back_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_takeShifts_TITLE = New System.Windows.Forms.Label()
        Me.grp_suggestedShifts = New System.Windows.Forms.GroupBox()
        Me.lst_suggestedShifts = New System.Windows.Forms.ListView()
        Me.shiftID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.startTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.endTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grp_allAvailableShifts = New System.Windows.Forms.GroupBox()
        Me.lst_availableShifts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grp_selectedShift = New System.Windows.Forms.GroupBox()
        Me.lbl_endDateTime_dynamic = New System.Windows.Forms.Label()
        Me.lbl_startDateTime_dynamic = New System.Windows.Forms.Label()
        Me.lbl_shiftID_dynamic = New System.Windows.Forms.Label()
        Me.lbl_endDateTime_static = New System.Windows.Forms.Label()
        Me.lbl_startDateTime_static = New System.Windows.Forms.Label()
        Me.lbl_shiftID_static = New System.Windows.Forms.Label()
        Me.grp_changeShiftTimes = New System.Windows.Forms.GroupBox()
        Me.lbl_endTime = New System.Windows.Forms.Label()
        Me.lbl_startTime = New System.Windows.Forms.Label()
        Me.txt_startTime_inp = New System.Windows.Forms.TextBox()
        Me.txt_endTime_inp = New System.Windows.Forms.TextBox()
        Me.btn_takeShift_process = New System.Windows.Forms.Button()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_suggestedShifts.SuspendLayout()
        Me.grp_allAvailableShifts.SuspendLayout()
        Me.grp_selectedShift.SuspendLayout()
        Me.grp_changeShiftTimes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back_redir
        '
        Me.btn_back_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_redir.Location = New System.Drawing.Point(44, 2)
        Me.btn_back_redir.Name = "btn_back_redir"
        Me.btn_back_redir.Size = New System.Drawing.Size(75, 38)
        Me.btn_back_redir.TabIndex = 15
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
        Me.img_blc_logo.TabIndex = 13
        Me.img_blc_logo.TabStop = False
        '
        'lbl_takeShifts_TITLE
        '
        Me.lbl_takeShifts_TITLE.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_takeShifts_TITLE.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_takeShifts_TITLE.Location = New System.Drawing.Point(0, 0)
        Me.lbl_takeShifts_TITLE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_takeShifts_TITLE.Name = "lbl_takeShifts_TITLE"
        Me.lbl_takeShifts_TITLE.Size = New System.Drawing.Size(784, 50)
        Me.lbl_takeShifts_TITLE.TabIndex = 14
        Me.lbl_takeShifts_TITLE.Text = "Take Shifts"
        Me.lbl_takeShifts_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grp_suggestedShifts
        '
        Me.grp_suggestedShifts.Controls.Add(Me.lst_suggestedShifts)
        Me.grp_suggestedShifts.Location = New System.Drawing.Point(12, 53)
        Me.grp_suggestedShifts.Name = "grp_suggestedShifts"
        Me.grp_suggestedShifts.Size = New System.Drawing.Size(375, 152)
        Me.grp_suggestedShifts.TabIndex = 16
        Me.grp_suggestedShifts.TabStop = False
        Me.grp_suggestedShifts.Text = "Suggested Shifts:"
        '
        'lst_suggestedShifts
        '
        Me.lst_suggestedShifts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.shiftID, Me.startTime, Me.endTime})
        Me.lst_suggestedShifts.FullRowSelect = True
        Me.lst_suggestedShifts.HideSelection = False
        Me.lst_suggestedShifts.Location = New System.Drawing.Point(6, 19)
        Me.lst_suggestedShifts.Name = "lst_suggestedShifts"
        Me.lst_suggestedShifts.Size = New System.Drawing.Size(363, 127)
        Me.lst_suggestedShifts.TabIndex = 20
        Me.lst_suggestedShifts.UseCompatibleStateImageBehavior = False
        Me.lst_suggestedShifts.View = System.Windows.Forms.View.Details
        '
        'shiftID
        '
        Me.shiftID.Text = "ShiftID"
        Me.shiftID.Width = 80
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
        'grp_allAvailableShifts
        '
        Me.grp_allAvailableShifts.Controls.Add(Me.lst_availableShifts)
        Me.grp_allAvailableShifts.Location = New System.Drawing.Point(12, 211)
        Me.grp_allAvailableShifts.Name = "grp_allAvailableShifts"
        Me.grp_allAvailableShifts.Size = New System.Drawing.Size(375, 250)
        Me.grp_allAvailableShifts.TabIndex = 17
        Me.grp_allAvailableShifts.TabStop = False
        Me.grp_allAvailableShifts.Text = "All Available Shifts:"
        '
        'lst_availableShifts
        '
        Me.lst_availableShifts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lst_availableShifts.FullRowSelect = True
        Me.lst_availableShifts.HideSelection = False
        Me.lst_availableShifts.Location = New System.Drawing.Point(6, 19)
        Me.lst_availableShifts.Name = "lst_availableShifts"
        Me.lst_availableShifts.Size = New System.Drawing.Size(363, 225)
        Me.lst_availableShifts.TabIndex = 21
        Me.lst_availableShifts.UseCompatibleStateImageBehavior = False
        Me.lst_availableShifts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ShiftID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Start Time"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "End Time"
        Me.ColumnHeader3.Width = 130
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
        Me.grp_selectedShift.TabIndex = 18
        Me.grp_selectedShift.TabStop = False
        Me.grp_selectedShift.Text = "Selected Shift:"
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
        'grp_changeShiftTimes
        '
        Me.grp_changeShiftTimes.Controls.Add(Me.lbl_endTime)
        Me.grp_changeShiftTimes.Controls.Add(Me.lbl_startTime)
        Me.grp_changeShiftTimes.Controls.Add(Me.txt_startTime_inp)
        Me.grp_changeShiftTimes.Controls.Add(Me.txt_endTime_inp)
        Me.grp_changeShiftTimes.Location = New System.Drawing.Point(393, 190)
        Me.grp_changeShiftTimes.Name = "grp_changeShiftTimes"
        Me.grp_changeShiftTimes.Size = New System.Drawing.Size(375, 117)
        Me.grp_changeShiftTimes.TabIndex = 18
        Me.grp_changeShiftTimes.TabStop = False
        Me.grp_changeShiftTimes.Text = "Change Shift Times:"
        '
        'lbl_endTime
        '
        Me.lbl_endTime.AutoSize = True
        Me.lbl_endTime.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_endTime.Location = New System.Drawing.Point(6, 65)
        Me.lbl_endTime.Name = "lbl_endTime"
        Me.lbl_endTime.Size = New System.Drawing.Size(135, 24)
        Me.lbl_endTime.TabIndex = 3
        Me.lbl_endTime.Text = "New End Time:"
        '
        'lbl_startTime
        '
        Me.lbl_startTime.AutoSize = True
        Me.lbl_startTime.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lbl_startTime.Location = New System.Drawing.Point(6, 22)
        Me.lbl_startTime.Name = "lbl_startTime"
        Me.lbl_startTime.Size = New System.Drawing.Size(143, 24)
        Me.lbl_startTime.TabIndex = 2
        Me.lbl_startTime.Text = "New Start Time:"
        '
        'txt_startTime_inp
        '
        Me.txt_startTime_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_startTime_inp.Location = New System.Drawing.Point(155, 19)
        Me.txt_startTime_inp.Name = "txt_startTime_inp"
        Me.txt_startTime_inp.Size = New System.Drawing.Size(100, 32)
        Me.txt_startTime_inp.TabIndex = 1
        Me.txt_startTime_inp.Text = "HH:mm"
        '
        'txt_endTime_inp
        '
        Me.txt_endTime_inp.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endTime_inp.Location = New System.Drawing.Point(155, 62)
        Me.txt_endTime_inp.Name = "txt_endTime_inp"
        Me.txt_endTime_inp.Size = New System.Drawing.Size(100, 32)
        Me.txt_endTime_inp.TabIndex = 0
        Me.txt_endTime_inp.Text = "HH:mm"
        '
        'btn_takeShift_process
        '
        Me.btn_takeShift_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_takeShift_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_takeShift_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_takeShift_process.Location = New System.Drawing.Point(500, 350)
        Me.btn_takeShift_process.Name = "btn_takeShift_process"
        Me.btn_takeShift_process.Size = New System.Drawing.Size(150, 70)
        Me.btn_takeShift_process.TabIndex = 19
        Me.btn_takeShift_process.Text = "Take Shift"
        Me.btn_takeShift_process.UseVisualStyleBackColor = True
        '
        'frm_takeShifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 471)
        Me.Controls.Add(Me.btn_takeShift_process)
        Me.Controls.Add(Me.grp_changeShiftTimes)
        Me.Controls.Add(Me.grp_selectedShift)
        Me.Controls.Add(Me.grp_allAvailableShifts)
        Me.Controls.Add(Me.grp_suggestedShifts)
        Me.Controls.Add(Me.btn_back_redir)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Controls.Add(Me.lbl_takeShifts_TITLE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_takeShifts"
        Me.Text = "BLC Shift Manager (Take Shifts)"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_suggestedShifts.ResumeLayout(False)
        Me.grp_allAvailableShifts.ResumeLayout(False)
        Me.grp_selectedShift.ResumeLayout(False)
        Me.grp_selectedShift.PerformLayout()
        Me.grp_changeShiftTimes.ResumeLayout(False)
        Me.grp_changeShiftTimes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_back_redir As Button
    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_takeShifts_TITLE As Label
    Friend WithEvents grp_suggestedShifts As GroupBox
    Friend WithEvents grp_allAvailableShifts As GroupBox
    Friend WithEvents grp_selectedShift As GroupBox
    Friend WithEvents grp_changeShiftTimes As GroupBox
    Friend WithEvents btn_takeShift_process As Button
    Friend WithEvents txt_endTime_inp As TextBox
    Friend WithEvents lbl_endTime As Label
    Friend WithEvents lbl_startTime As Label
    Friend WithEvents txt_startTime_inp As TextBox
    Friend WithEvents lbl_endDateTime_dynamic As Label
    Friend WithEvents lbl_startDateTime_dynamic As Label
    Friend WithEvents lbl_shiftID_dynamic As Label
    Friend WithEvents lbl_endDateTime_static As Label
    Friend WithEvents lbl_startDateTime_static As Label
    Friend WithEvents lbl_shiftID_static As Label
    Friend WithEvents lst_suggestedShifts As ListView
    Friend WithEvents shiftID As ColumnHeader
    Friend WithEvents startTime As ColumnHeader
    Friend WithEvents endTime As ColumnHeader
    Friend WithEvents lst_availableShifts As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
