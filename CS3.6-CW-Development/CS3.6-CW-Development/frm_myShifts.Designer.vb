<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_myShifts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_myShifts))
        Me.btn_back_redir = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_myShifts_TITLE = New System.Windows.Forms.Label()
        Me.grp_selectedShift = New System.Windows.Forms.GroupBox()
        Me.lbl_endDateTime_dynamic = New System.Windows.Forms.Label()
        Me.lbl_startDateTime_dynamic = New System.Windows.Forms.Label()
        Me.lbl_shiftID_dynamic = New System.Windows.Forms.Label()
        Me.lbl_endDateTime_static = New System.Windows.Forms.Label()
        Me.lbl_startDateTime_static = New System.Windows.Forms.Label()
        Me.lbl_shiftID_static = New System.Windows.Forms.Label()
        Me.lst_myShifts1 = New System.Windows.Forms.ListBox()
        Me.grp_myShifts = New System.Windows.Forms.GroupBox()
        Me.btn_removeShift_process = New System.Windows.Forms.Button()
        Me.lst_myShifts = New System.Windows.Forms.ListView()
        Me.shiftID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.startTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.endTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_selectedShift.SuspendLayout()
        Me.grp_myShifts.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_back_redir
        '
        Me.btn_back_redir.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_redir.Location = New System.Drawing.Point(44, 2)
        Me.btn_back_redir.Name = "btn_back_redir"
        Me.btn_back_redir.Size = New System.Drawing.Size(75, 38)
        Me.btn_back_redir.TabIndex = 18
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
        Me.img_blc_logo.TabIndex = 16
        Me.img_blc_logo.TabStop = False
        '
        'lbl_myShifts_TITLE
        '
        Me.lbl_myShifts_TITLE.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_myShifts_TITLE.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_myShifts_TITLE.Location = New System.Drawing.Point(0, 0)
        Me.lbl_myShifts_TITLE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_myShifts_TITLE.Name = "lbl_myShifts_TITLE"
        Me.lbl_myShifts_TITLE.Size = New System.Drawing.Size(784, 50)
        Me.lbl_myShifts_TITLE.TabIndex = 17
        Me.lbl_myShifts_TITLE.Text = "My Shifts"
        Me.lbl_myShifts_TITLE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grp_selectedShift
        '
        Me.grp_selectedShift.Controls.Add(Me.lbl_endDateTime_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.lbl_startDateTime_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.lbl_shiftID_dynamic)
        Me.grp_selectedShift.Controls.Add(Me.lbl_endDateTime_static)
        Me.grp_selectedShift.Controls.Add(Me.lbl_startDateTime_static)
        Me.grp_selectedShift.Controls.Add(Me.lbl_shiftID_static)
        Me.grp_selectedShift.Location = New System.Drawing.Point(400, 50)
        Me.grp_selectedShift.Name = "grp_selectedShift"
        Me.grp_selectedShift.Size = New System.Drawing.Size(375, 125)
        Me.grp_selectedShift.TabIndex = 19
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
        'lst_myShifts1
        '
        Me.lst_myShifts1.ColumnWidth = 100
        Me.lst_myShifts1.FormattingEnabled = True
        Me.lst_myShifts1.Location = New System.Drawing.Point(178, 240)
        Me.lst_myShifts1.MultiColumn = True
        Me.lst_myShifts1.Name = "lst_myShifts1"
        Me.lst_myShifts1.Size = New System.Drawing.Size(191, 82)
        Me.lst_myShifts1.TabIndex = 1
        '
        'grp_myShifts
        '
        Me.grp_myShifts.Controls.Add(Me.lst_myShifts)
        Me.grp_myShifts.Controls.Add(Me.lst_myShifts1)
        Me.grp_myShifts.Location = New System.Drawing.Point(10, 50)
        Me.grp_myShifts.Name = "grp_myShifts"
        Me.grp_myShifts.Size = New System.Drawing.Size(375, 330)
        Me.grp_myShifts.TabIndex = 18
        Me.grp_myShifts.TabStop = False
        Me.grp_myShifts.Text = "My Shifts:"
        '
        'btn_removeShift_process
        '
        Me.btn_removeShift_process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_removeShift_process.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removeShift_process.ForeColor = System.Drawing.Color.Red
        Me.btn_removeShift_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_removeShift_process.Location = New System.Drawing.Point(520, 230)
        Me.btn_removeShift_process.Name = "btn_removeShift_process"
        Me.btn_removeShift_process.Size = New System.Drawing.Size(150, 70)
        Me.btn_removeShift_process.TabIndex = 20
        Me.btn_removeShift_process.Text = "Remove Selected Shift"
        Me.btn_removeShift_process.UseVisualStyleBackColor = True
        '
        'lst_myShifts
        '
        Me.lst_myShifts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.shiftID, Me.startTime, Me.endTime})
        Me.lst_myShifts.HideSelection = False
        Me.lst_myShifts.Location = New System.Drawing.Point(6, 19)
        Me.lst_myShifts.Name = "lst_myShifts"
        Me.lst_myShifts.Size = New System.Drawing.Size(363, 215)
        Me.lst_myShifts.TabIndex = 2
        Me.lst_myShifts.UseCompatibleStateImageBehavior = False
        Me.lst_myShifts.View = System.Windows.Forms.View.Details
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
        'frm_myShifts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 391)
        Me.Controls.Add(Me.btn_removeShift_process)
        Me.Controls.Add(Me.grp_myShifts)
        Me.Controls.Add(Me.grp_selectedShift)
        Me.Controls.Add(Me.btn_back_redir)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Controls.Add(Me.lbl_myShifts_TITLE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_myShifts"
        Me.Text = "BLC Shift Manager (My Shifts)"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_selectedShift.ResumeLayout(False)
        Me.grp_selectedShift.PerformLayout()
        Me.grp_myShifts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_back_redir As Button
    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents lbl_myShifts_TITLE As Label
    Friend WithEvents grp_selectedShift As GroupBox
    Friend WithEvents lbl_endDateTime_dynamic As Label
    Friend WithEvents lbl_startDateTime_dynamic As Label
    Friend WithEvents lbl_shiftID_dynamic As Label
    Friend WithEvents lbl_endDateTime_static As Label
    Friend WithEvents lbl_startDateTime_static As Label
    Friend WithEvents lbl_shiftID_static As Label
    Friend WithEvents lst_myShifts1 As ListBox
    Friend WithEvents grp_myShifts As GroupBox
    Friend WithEvents btn_removeShift_process As Button
    Friend WithEvents lst_myShifts As ListView
    Friend WithEvents shiftID As ColumnHeader
    Friend WithEvents startTime As ColumnHeader
    Friend WithEvents endTime As ColumnHeader
End Class
