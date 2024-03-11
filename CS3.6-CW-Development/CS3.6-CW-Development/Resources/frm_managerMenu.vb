Public Class frm_managerMenu
    Private Sub frm_managerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' Formatting Buttons
        ' Loop through all buttons on the form and set the colour and round the edges.
        For Each btn As Button In Me.Controls.OfType(Of Button)
            standardProcedures.RoundButton(btn)
        Next

    End Sub


    Private Sub btn_profile_redir_Click(sender As Object, e As EventArgs) Handles btn_profile_redir.Click
        frm_accountEditor.Show()
        Me.Hide()
    End Sub

    Private Sub btn_editAcc_redir_Click(sender As Object, e As EventArgs) Handles btn_editAcc_redir.Click
        frm_accountManager.Show()
        Me.Hide()
    End Sub

    Private Sub btn_myShifts_redir_Click(sender As Object, e As EventArgs) Handles btn_myShifts_redir.Click
        frm_myShifts.Show()
        Me.Hide()
    End Sub

    Private Sub btn_allShifts_redir_Click(sender As Object, e As EventArgs) Handles btn_allShifts_redir.Click
        frm_allShifts.Show()
        Me.Hide()
    End Sub

    Private Sub btn_takeShifts_redir_Click(sender As Object, e As EventArgs) Handles btn_takeShifts_redir.Click
        frm_takeShifts.Show()
        Me.Hide()
    End Sub

    Private Sub frm_managerMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ' Edit title to show user's first name.
            lbl_menu_TITLE.Text = DataStructures.StaffHashTable.firstFromUserName(activeUser) & "'s Menu (Manager)"
        End If
    End Sub

    Private Sub btn_removeOldData_process_Click(sender As Object, e As EventArgs) Handles btn_removeOldData_process.Click
        ' Remove old shifts
        ' Check empty tree
        If DataStructures.ShiftLL._root Is Nothing Then
            Exit Sub
        End If


        Dim currentNode As ShiftNode = DataStructures.ShiftLL._root ' Set current node to root of tree
        Dim cuttoffDate As Date = Date.Now.AddDays(-30) ' Set cutoff date to 30 days ago

        ' Check root of tree
        If DataStructures.ShiftLL._root.shiftData.endTime < cuttoffDate Then
            ' Check not one node in LL
            If DataStructures.ShiftLL._root.nextShift IsNot Nothing Then
                ' Make the next node the new root of the tree
                DataStructures.ShiftLL._root = DataStructures.ShiftLL._root.nextShift
                DataStructures.ShiftLL._root.lastShift = Nothing

                ' Repeat setting next node to root until new root is not older than cutoffDate
                While DataStructures.ShiftLL._root.shiftData.endTime < cuttoffDate
                    ' Check its not last node in LL
                    If DataStructures.ShiftLL._root.nextShift IsNot Nothing Then
                        ' Make the next node the new root of the tree
                        DataStructures.ShiftLL._root = DataStructures.ShiftLL._root.nextShift
                        DataStructures.ShiftLL._root.lastShift = Nothing
                    Else
                        ' Only one node in LL so set LL to noting.
                        DataStructures.ShiftLL._root = Nothing
                        ' Exit loop to ensure error is thrown when checking if nothing.shiftdata exists.
                        Exit While
                    End If
                End While
            Else
                ' Only one node in LL so set LL to noting.
                DataStructures.ShiftLL._root = Nothing
            End If
            ' Set current node to root of tree as it has been changed.
            currentNode = DataStructures.ShiftLL._root
        End If

        ' Set current node to next node if it exists.
        If currentNode IsNot Nothing Then
            currentNode = currentNode.nextShift
        End If

        ' Loop through all shifts and remove any that are older than cutoffDate.
        While currentNode IsNot Nothing
            If currentNode.shiftData.endTime < cuttoffDate Then
                ' Removing node if it is not the end of the LL.
                If currentNode.nextShift IsNot Nothing Then
                    currentNode.lastShift.nextShift = currentNode.nextShift
                    currentNode.nextShift.lastShift = currentNode.lastShift
                Else
                    ' Node is the end of the LL
                    currentNode.lastShift.nextShift = Nothing
                End If
            End If
            ' Set current node to next node.
            currentNode = currentNode.nextShift
        End While

        MsgBox("Old Shifts Deleted Succesfully.") ' Informs the user the old shifts have been deleted.
        ' Write Shift LL to file to save
        If Not FileHandler.shiftWrite() Then MsgBox("Error Writing to shift file, data not saved, please restart system.") : Exit Sub

        'Remove line when notification implemented
        Exit Sub

        ' Get a list of all the notifications that currently have atleast one instance attached to it.
        Dim distinctNotifications As New List(Of Integer)
        distinctNotifications = DataStructures.NotificationInstanceLL.distinctNotification()
        ' Get a list of all the notifications in the binary tree.
        Dim notificationList As List(Of Integer)
        notificationList = DataStructures.NotificationTree.inOrderTraversal(DataStructures.NotificationTree._root, notificationList)

        ' Loop over every notification in the tree and see if it has an instance attached to it
        For Each notification In notificationList
            If Not distinctNotifications.Contains(notification) Then
                ' Remove the notification if it does not have a notification instance in it.
                DataStructures.NotificationTree.remove(DataStructures.NotificationTree._root, notification)
            End If
        Next

        MsgBox("Old Notifications Removed.") ' Notify user that old data has been removed.
        ' Write Notification Tree to file to save
        If Not FileHandler.notificationWrite() Then MsgBox("Error writing to notification file, data not saved, please restart system.") : Exit Sub
    End Sub

    Private Sub btn_notifications_redir_Click(sender As Object, e As EventArgs) Handles btn_notifications_redir.Click
        frm_notifications.Show()
        Me.Hide()
    End Sub
End Class