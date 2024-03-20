Imports System.Security.Cryptography
Imports System.Text

Public Class standardProcedures
    ' Assign shifts to full-time staff members.


    Public Shared Sub RoundButton(btn As Button)
        'TODO: Comment Code (And sort the commented line out)
        ' Edit button properties to make it consistent
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.BorderColor = Color.FromArgb(191, 191, 191)
        btn.BackColor = Color.FromArgb(191, 191, 191)

        ' Create a new graphics path to store the rounded edges of the button
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
        'Improv,ments not actually how it works. if MORE THEN 4 STAFF MEMBERS 1 HAS WEEK OFF - many drawbbacks to implementation
        ' Last/Quick implementation to finish development so documentation is completed in time. - Therefore not efficient.

        ' Decare a 2d array of strings to store the shift patterns
        Dim shiftPattern(,) As String = {{"06:00-14:00", "06:00-14:00", "14:00-22:00", "14:00-22:00"},     ' Monday Shifts
                                         {"06:00-14:00", "06:00-14:00", "14:00-22:00", "14:00-22:00"},     ' Tuesday Shifts
                                         {"06:00-14:00", "06:00-14:00", "14:00-22:00", "14:00-22:00"},     ' Wednesday Shifts
                                         {"06:00-14:00", "06:00-14:00", "14:00-22:00", "14:00-22:00"},     ' Thursday Shifts
                                         {"06:00-14:00", "06:00-14:00", "14:00-21:30", "14:00-21:30"},     ' Friday Shifts
                                         {"06:30-12:30", "06:30-12:30", "12:30-18:30", "12:30-18:30"},     ' Saturday Shifts
                                         {"07:00-15:00", "07:00-15:00", "15:00-20:00", "15:00-20:00"}}     ' Sunday Shifts

        ' Declare a 2d array of shifts to store the shifts created from the shift pattern. 7 days in a week and 4 shifts per day
        Dim shifts(6, 3) As Shift
        Dim offset As Integer = 0 ' Offset for shift allocation so staff member does now work the same shift every week (read from file) persistent value.
        FileOpen(1, "offset.txt", OpenMode.Input)
        Input(1, offset)
        FileClose(1)

        'Mod by 4 as 4 shifts per day so no point shifting staff members more then 4 locations as it will just be extra processing.
        offset = offset Mod 4
        ' Shift all items in the full time staff array by the offset (looping the staff at the end to the start)
        ' Sort out an array of staff members to be used to allocate shifts to.
        ' Get all the full-time staff
        Dim listOfFullTimeStaff As List(Of String) = DataStructures.StaffHashTable.fullTimeStaff()
        ' Keep a couint of the number of full-time staff - reduce unnecessary calls to the count method.
        Dim fullTimeStaffCount As Integer = listOfFullTimeStaff.Count
        ' Create an array for all the list of staff
        Dim staffArray(fullTimeStaffCount - 1) As String
        ' Convert the list of staff to an array
        listOfFullTimeStaff.CopyTo(staffArray)
        ' Shuffle all staff in array to the right by x amount where x is the offset
        Dim temp As String
        For i = 0 To offset - 1
            temp = staffArray(fullTimeStaffCount - 1)
            For j = fullTimeStaffCount - 1 To 1 Step -1
                staffArray(j) = staffArray(j - 1)
            Next
            staffArray(0) = temp
        Next

        ' CREATE SHIFTS.


        ' Get the current date and time
        Dim startDate As Date = Date.Now
        ' Set the start time to be the start of the day ie 00:00
        startDate = startDate.Date
        ' Add 2 weeks to the current date
        startDate = startDate.AddDays(14)
        ' Set the start date to the start of the week it is currently in
        startDate = startDate.AddDays(-(startDate.DayOfWeek - 1))

        ' Create a new shift.
        Dim tmpShift As Shift

        ' Starting ShiftID (Only workout once
        ' CUZ NEED ERRORS LEAVE ID AS IS RN
        ' HOWEVER TO FIX THE BUG OF ALL SHIFTS HAVING THE SAME ID, ONLY ALLOCATE THE ID AS THE SHIFT IS BEING ADDED TO THE LL SO THE ONE BEFORE WITH THAT ID HAS BEEN ADDED.

        ' For every day of the week
        For i = 0 To 6
            ' 2 shifts per day ie one early one late
            For j = 0 To 3
                ' Populate the shift with the correct shift data according to the shift pattern.
                tmpShift.shiftID = DataStructures.ShiftLL.nextAvailableID()
                ' Set the start date of the shift to the current date of start date but set the time to the first time in the shift pattern
                tmpShift.startTime = startDate.Add(TimeSpan.Parse(shiftPattern(i, j).Substring(0, 5)))
                ' Set the end date of the shift to the current date of start date but set the time to the second time in the shift pattern
                tmpShift.endTime = startDate.Add(TimeSpan.Parse(shiftPattern(i, j).Substring(6)))
                ' Set the staff member to be a placeholder so system does not creash - overwritten when shift allocated.
                tmpShift.staffUserName = "HarrisonGreen0"
                ' Set the shift type to be a full time shift
                tmpShift.isTaken = False

                ' Add the shift to the array of shifts
                shifts(i, j) = tmpShift
            Next
            ' Increment the start date by one day so a full week of shifts are created.
            startDate = startDate.AddDays(1)
        Next

        ' ALLOCATE SHIFTS

        'TODO
        ' Calculate the number of shifts that need to be assigned - Full time staff should each have 40 hours over the week. Should not work more than 5 days in a row and should have 2 days off in a row and should not work longer then eight hours in a day.
        ' Use the number of full-time staff to calculate the number of shifts that need to be assigned and when they should be assigned given there are 4 shifts per day and 7 days in a week
        Dim shiftsPerWeek As Integer = fullTimeStaffCount * 5
        ' Looping over all the new shifts, allocate them to full time staff members ensuring each staff member works 5 days with 2 days of
        For i = 0 To 6
            Dim k As Integer
            If fullTimeStaffCount > 4 And i > 4 Then
                k = 4
            Else
                k = 0
            End If
            For j = 0 To 3
                ' Check if shifts still need allocating 
                If shiftsPerWeek > 0 Then
                    If k < fullTimeStaffCount Then
                        ' If the shift is not taken
                        If shifts(i, j).isTaken = False Then
                            ' Assign the shift to the staff member
                            shifts(i, j).staffUserName = staffArray(k)
                            ' Set the shift to be taken
                            shifts(i, j).isTaken = True
                            ' Decrement the number of shifts that need to be assigned
                            shiftsPerWeek -= 1
                            k += 1
                        End If
                    End If
                Else
                    ' If all shifts have been assigned then break out of the loop
                    Exit For
                End If
            Next
        Next

        ' Add the shifts to the linked list of shifts
        For i = 0 To 6
            For j = 0 To 3
                ' Update the shiftID to be the next available shiftID in the linked list of shifts Due to error x
                shifts(i, j).shiftID = DataStructures.ShiftLL.nextAvailableID()
                DataStructures.ShiftLL.append(shifts(i, j))
            Next
        Next


        ' Update offset
        offset += 1
        FileOpen(1, "offset.txt", OpenMode.Output)
        Write(1, offset)
        FileClose(1)

        Return "Shifts have been generated"



    End Function


    '
    ' ENCRYPTION/Decryption

    ' Create a list of all characters
    Private Shared allCharacters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@£$%^&*()_+"
    ' Create a copy of all the characters for the key
    Private Shared key As String = allCharacters
    ' Shuffle all character in the key by 5 characters
    Public Shared Sub shuffleKey()
        ' Create a new string builder
        Dim newKey As New StringBuilder
        ' Loop over all the characters in the key
        For i = 0 To key.Length - 1
            ' Get the character at the current index
            Dim currentChar As Char = key(i)
            ' Get the index of the current character in the all characters string
            Dim index As Integer = allCharacters.IndexOf(currentChar)
            ' Add 5 to the index
            index += 7
            ' If the index is greater than the length of the all characters string
            If index > allCharacters.Length - 1 Then
                ' Subtract the length of the all characters string from the index
                index -= allCharacters.Length
            End If
            ' Get the character at the new index
            Dim newChar As Char = allCharacters(index)
            ' Append the new character to the new key
            newKey.Append(newChar)
        Next
        ' Set the key to be the new key
        key = newKey.ToString()
    End Sub
    ' Encrypt a string
    Public Shared Function encryptString(ByVal input As String) As String
        ' Create a new string builder
        Dim output As New StringBuilder
        ' Loop over all the characters in the input string
        For i = 0 To input.Length - 1
            ' Get the character at the current index
            Dim currentChar As Char = input(i)
            ' Get the index of the current character in the all characters string
            Dim index As Integer = allCharacters.IndexOf(currentChar)
            ' Get the character at the index of the key
            Dim newChar As Char = key(index)
            ' Append the new character to the output string
            output.Append(newChar)
        Next
        ' Return the output string
        Return output.ToString()
    End Function

    ' Decrypt a string
    Public Shared Function decryptString(ByVal input As String) As String
        ' Create a new string builder
        Dim output As New StringBuilder
        ' Loop over all the characters in the input string
        For i = 0 To input.Length - 1
            ' Get the character at the current index
            Dim currentChar As Char = input(i)
            ' Get the index of the current character in the key
            Dim index As Integer = key.IndexOf(currentChar)
            ' Get the character at the index of the all characters string
            Dim newChar As Char = allCharacters(index)
            ' Append the new character to the output string
            output.Append(newChar)
        Next
        ' Return the output string
        Return output.ToString()
    End Function


End Class




