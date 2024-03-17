Imports System.Security.Cryptography
Imports System.Text

Public Class standardProcedures
    ' Assign shifts to full-time staff members.


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

    ' Producing a hash for a password
    Public Shared Function hashPassSHA256(ByVal pasword As String) As String
        Dim sha256 As New SHA256CryptoServiceProvider
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(pasword)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New System.Text.StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("x2"))
        Next
        Return stringBuilder.ToString()
    End Function

    Public Shared Function deHashPassSHA256(ByVal hashedPass As String) As String
    End Function

    'COMMENT
    Public Shared Function automaticShiftGeneration() As String '
        ' Decare a 2d array of strings to store the shift patterns
        Dim shiftPattern(,) As String = {{"06:00-14:00", "14:00-22:00"},     ' Monday Shifts
                                         {"06:00-14:00", "14:00-22:00"},     ' Tuesday Shifts
                                         {"06:00-14:00", "14:00-22:00"},     ' Wednesday Shifts
                                         {"06:00-14:00", "14:00-22:00"},     ' Thursday Shifts
                                         {"06:00-14:00", "14:00-21:30"},     ' Friday Shifts
                                         {"06:30-12:30", "12:30-18:30"},     ' Saturday Shifts
                                         {"07:00-15:00", "15:00-20:00"}}     ' Sunday Shifts

        Dim shifts(6, 3) As Shift
        Dim fullTimeStaff(3) As StaffMember
        Dim offset As Integer = 0 ' Offset for shift allocation soa staff member does now work the same shift every week (read from file)
        FileOpen(1, "offset.txt", OpenMode.Input)
        Input(1, offset)
        FileClose(1)

        offset = offset Mod 4
        ' Shift all items in the full time staff array by the offset (looping the staff at the end to the start)


        ' Get the current date and time
        Dim startDate As Date = Date.Now
        ' Set the start time to be the start of the day ie 00:00
        startDate = startDate.Date
        MsgBox(startDate.ToString())
        ' Add 2 weeks to the current date
        startDate = startDate.AddDays(14)
        ' Set the start date to the start of the week it is currently in
        startDate = startDate.AddDays(-(startDate.DayOfWeek - 1))

        ' Create a new shift
        Dim tmpShift As Shift

        ' For every day of the week
        For i = 0 To 6
            ' 2 shifts per day ie one early one late
            For j = 0 To 1
                ' So 2 staff work per slot
                For k = 0 To 1
                    tmpShift.shiftID = DataStructures.ShiftLL.nextAvailableID()
                    ' Set the start date of the shift to the current date of start date but set the time to the first time in the shift pattern
                    tmpShift.startTime = startDate.Add(TimeSpan.Parse(shiftPattern(i, j).Substring(0, 5)))
                    ' Set the end date of the shift to the current date of start date but set the time to the second time in the shift pattern
                    tmpShift.endTime = startDate.Add(TimeSpan.Parse(shiftPattern(i, j).Substring(6)))
                    ' Set the staff member to be the next available staff member
                    tmpShift.staffUserName = "HarrisonGreen0"
                    ' Set the shift type to be a full time shift
                    tmpShift.isTaken = False

                    MsgBox(tmpShift.startTime.ToString())
                    MsgBox(tmpShift.endTime.ToString())
                    shifts(i, (j + k)) = tmpShift
                Next
            Next
            startDate = startDate.AddDays(1)
        Next

        ' Get all the full-time staff
        Dim listOfStaff As List(Of String) = DataStructures.StaffHashTable.fullTimeStaff()
        ' Get the number of full-time staff
        Dim fullTimeStaffCount As Integer = listOfStaff.Count
        ' Calculate the number of shifts that need to be assigned - Full time staff should each have 40 hours over the week. Should not work more than 5 days in a row and should have 2 days off in a row and should not work longer then eight hours in a day.
        ' Use the number of full-time staff to calculate the number of shifts that need to be assigned and when they should be assigned given there are 4 shifts per day and 7 days in a week


        ' Update offset
        offset += 1
        FileOpen(1, "offset.txt", OpenMode.Output)
        Write(1, offset)
        FileClose(1)

        Return "Shifts have been generated"



    End Function

End Class




