﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.img_blc_logo = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'img_blc_logo
        '
        Me.img_blc_logo.Image = Global.CS3._6_CW_Development.My.Resources.Resources.blc_logo
        Me.img_blc_logo.Location = New System.Drawing.Point(64, 21)
        Me.img_blc_logo.Name = "img_blc_logo"
        Me.img_blc_logo.Size = New System.Drawing.Size(50, 50)
        Me.img_blc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_blc_logo.TabIndex = 1
        Me.img_blc_logo.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(143, 89)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 33)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Full"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.img_blc_logo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.img_blc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents img_blc_logo As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
End Class
