Public Class frm_notifications
    Private Sub frm_notifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next
    End Sub

    Private Sub btn_back_redir_Click(sender As Object, e As EventArgs) Handles btn_back_redir.Click
        ' Show the previous form (depending on if user is a manager) and hide this one.
        Dim tmpStaff As StaffMember = DataStructures.StaffHashTable.findStaffMember(activeUser, True)

        If tmpStaff.isManager Then
            frm_managerMenu.Show()
        Else
            frm_staffMenu.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub frm_notifications_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible() Then
            ' Update title
            lbl_notifications_TITLE.Text = DataStructures.StaffHashTable.firstFromUserName(activeUser) & "'s Notifications"

            ' Clear the listbox
            lsv_notificationPreview.Items.Clear()

            ' Clear the labels/textboxes
            lbl_notificationID_dynamic.Text = "<NotificationID>"
            txt_notificationContent_disp.Text = ""
            lbl_sender_dynamic.Text = "<StaffFirstName>"
            lbl_sentDate_dynamic.Text = "<DD/MM/YYYY HH:mm>"


            ' Get all user's notifications
            Dim userNotifications As List(Of Integer) = DataStructures.NotificationInstanceLL.userNotification()
            Dim tmpNotification As Notification

            For i = 0 To userNotifications.Count - 1
                tmpNotification = DataStructures.NotificationTree.find(DataStructures.NotificationTree._root, userNotifications(i))

                lsv_notificationPreview.Items.Add(tmpNotification.notificationID)
                lsv_notificationPreview.Items(i).SubItems.Add(tmpNotification.content)

                lsv_notificationPreview.Items(i).SubItems.Add(DataStructures.StaffHashTable.firstFromUserName(tmpNotification.sender))
                lsv_notificationPreview.Items(i).SubItems.Add(tmpNotification.sentDate.ToString())

            Next
        End If
    End Sub

    Private Sub lsv_notificationPreview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsv_notificationPreview.SelectedIndexChanged
        ' If a notification is deselected, clear the labels/textboxes
        If lsv_notificationPreview.SelectedItems.Count = 0 Then
            lbl_notificationID_dynamic.Text = "<NotificationID>"
            txt_notificationContent_disp.Text = ""
            lbl_sender_dynamic.Text = "<StaffFirstName>"
            lbl_sentDate_dynamic.Text = "<DD/MM/YYYY HH:mm>"
        End If

        ' Check if an item is selected
        If lsv_notificationPreview.SelectedItems.Count > 0 Then
            ' Get the notification ID
            Dim notificationID As Integer = lsv_notificationPreview.SelectedItems(0).Text

            ' Get the notification
            Dim tmpNotification As Notification = DataStructures.NotificationTree.find(DataStructures.NotificationTree._root, notificationID)

            ' Populate the labels
            lbl_notificationID_dynamic.Text = tmpNotification.notificationID
            txt_notificationContent_disp.Text = tmpNotification.content
            lbl_sender_dynamic.Text = DataStructures.StaffHashTable.firstFromUserName(tmpNotification.sender)
            lbl_sentDate_dynamic.Text = tmpNotification.sentDate.ToString()


        End If
    End Sub

    Private Sub btn_deleteNotification_process_Click(sender As Object, e As EventArgs) Handles btn_deleteNotification_process.Click
        Exit Sub
        ' Check if a notification is selected
        If lbl_notificationID_dynamic.Text = "<NotificationID>" Then
            MsgBox("Please select a notification to delete.")
            Exit Sub
        End If

        ' Delete the notification instance


        ' Write the notificationinstanceLL to file
        If Not FileHandler.notificationInstanceWrite() Then
            MsgBox("Error writing to notification instance file, data not saved, please restart system.")
            Exit Sub
        End If

        ' Update the listbox
        frm_notifications_VisibleChanged(sender, e)

    End Sub
End Class