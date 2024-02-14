Public Class standardProcedures
    Public Shared Sub RoundButton(btn As Button)
        'TODO: Comment Code (And sort the commented line out)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.BorderColor = Color.FromArgb(191, 191, 191)
        btn.BackColor = Color.FromArgb(191, 191, 191)

        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()

        ' Rounding Geometry for top left corner
        radius.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        radius.AddLine(10, 0, btn.Width - 10, 0)

        ' Rounding Geometry for top right corner
        radius.AddArc(New Rectangle(btn.Width - 10, 0, 10, 10), -90, 90)
        'radius.AddLine(btnRound.Width, 29, btn.Width, btn.Height, -10)

        ' Rounding Geometry for bottom right corner
        radius.AddArc(New Rectangle(btn.Width - 10, btn.Height - 10, 10, 10), 0, 90)
        radius.AddLine(btn.Width - 10, btn.Height, 10, btn.Height)

        ' Rounding Geometry for bottom left corner
        radius.AddArc(New Rectangle(0, btn.Height - 10, 10, 10), 90, 90)
        radius.AddLine(0, btn.Height - 10, 0, 10)

        radius.CloseFigure()
        btn.Region = New Region(radius)

    End Sub
End Class
