Public Class frm_notificationManager
    '
    ' Form Open & close Events
    '
    Private Sub frm_notificationManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub
    Private Sub frm_notificationManager_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ' Clear the form
            txt_notificationContent_inp.Text = ""
            txt_staffFirstName_inp.Text = ""
            lst_notificationRecipients.Items.Clear()
        End If
    End Sub
    '
    ' Redirect Code
    '
    Private Sub btn_back_redir_Click(sender As Object, e As EventArgs) Handles btn_back_redir.Click
        frm_managerMenu.Show()
        Me.Hide()
    End Sub
    '
    ' Processes code ie buttons for processing data
    '
    Private Sub btn_searchStaff_process_Click(sender As Object, e As EventArgs) Handles btn_searchStaff_process.Click
        ' Validate Input 
        If Validation.PresenceValidation(txt_staffFirstName_inp.Text) = False Then MsgBox("Must enter a name to search") : Exit Sub

        Dim searchData As String        ' Store the data to search for either a username or firstname
        Dim tmpStaff As StaffMember     ' Store the staff member that is found
        ' Check if the input is a username or a name
        Dim isUserName As Boolean = Validation.isUsernameFormat(txt_staffFirstName_inp.Text)

        ' Checks if input is a username or a name
        If isUserName Then
            searchData = txt_staffFirstName_inp.Text
        Else
            ' Formatting input if it is not a username and is a name.
            searchData = Validation.FormatName(txt_staffFirstName_inp.Text)
        End If

        ' Find User
        tmpStaff = DataStructures.StaffHashTable.findStaffMember(searchData, isUserName)

        'Check if a user has been found before updating info.
        If tmpStaff.userName IsNot Nothing Then
            ' Check if user is already in the listbox
            If lst_notificationRecipients.Items.Contains(tmpStaff.userName) Then MsgBox("User is already in the list") : Exit Sub
            ' Add the user to the listbox
            lst_notificationRecipients.Items.Add(tmpStaff.userName)

            txt_staffFirstName_inp.Text = ""
        End If
    End Sub

    Private Sub btn_removeFromNotification_process_Click(sender As Object, e As EventArgs) Handles btn_removeFromNotification_process.Click
        ' Check a user has been selected
        If lst_notificationRecipients.SelectedIndex = -1 Then MsgBox("Must select a user to remove from the notification") : Exit Sub
        ' Remove the user from the listBox
        lst_notificationRecipients.Items.RemoveAt(lst_notificationRecipients.SelectedIndex)

    End Sub

    Private Sub btn_addAllStaff_process_Click(sender As Object, e As EventArgs) Handles btn_addAllStaff_process.Click
        ' add all staff to the listbox
        For i = 0 To DataStructures.StaffHashTable._hashTable.Length - 1
            Dim tmpStaff As StaffMemberNode = DataStructures.StaffHashTable._hashTable(i)

            While tmpStaff IsNot Nothing
                ' Check if the user is in the listbox already
                If lst_notificationRecipients.Items.Contains(tmpStaff.staffMemberData.userName) = False Then
                    lst_notificationRecipients.Items.Add(tmpStaff.staffMemberData.userName)
                End If
                tmpStaff = tmpStaff.nextStaffMember
            End While
        Next
    End Sub

    Private Sub btn_sendNotification_process_Click(sender As Object, e As EventArgs) Handles btn_sendNotification_process.Click
        ' Validate Input
        If Validation.PresenceValidation(txt_notificationContent_inp.Text) = False Then MsgBox("Must enter a message to send") : Exit Sub

        'Check atleast one recipient has been selected
        If lst_notificationRecipients.Items.Count = 0 Then MsgBox("Must select atleast one recipient") : Exit Sub

        ' Create the notification node
        Dim newNotification As Notification
        ' Populate the notification
        newNotification.notificationID = DataStructures.NotificationTree.nextAvailableID()
        newNotification.content = txt_notificationContent_inp.Text
        newNotification.sender = activeUser
        newNotification.sentDate = Date.Now
        ' Add the notification to the tree
        DataStructures.NotificationTree.add(newNotification)

        ' Create the notification instance node for each staff member
        Dim newNotificationInstance As NotificationInstance
        newNotificationInstance.notificationID = newNotification.notificationID
        For i = 0 To lst_notificationRecipients.Items.Count - 1
            newNotificationInstance.notificationInstanceID = DataStructures.NotificationInstanceLL.nextAvailableID()
            newNotificationInstance.recipient = lst_notificationRecipients.Items(i)

            DataStructures.NotificationInstanceLL.add(newNotificationInstance)
        Next

        ' Inform user of success
        MsgBox("Notification Sent Successfully")
        ' Clear the form
        txt_notificationContent_inp.Text = ""
        lst_notificationRecipients.Items.Clear()


        ' Write to file
        If FileHandler.notificationWrite() = False Then MsgBox("Error writing to file. Notification not saved - please restart")
        If FileHandler.notificationInstanceWrite() = False Then MsgBox("Error writing to file - please restart")


    End Sub

    Private Sub lst_notificationRecipients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_notificationRecipients.SelectedIndexChanged
        ' Allow user to deselect a user
    End Sub
End Class