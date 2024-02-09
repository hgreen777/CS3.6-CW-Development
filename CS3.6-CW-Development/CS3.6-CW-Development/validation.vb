Public Class validation
    ' Contains all validation modules for the program.
    ' Ensures no code duplication and abstraction of project

    'TODO : Implement Presence Check
    ' Presence Check
    Function DataPresent()

    End Function

    'TODO: Implement TimeFormat (check works)
    ' Time Format Check 
    Public Shared Function CorrectTimeFormat(ByVal Input As String)
        ' Checking time is in format "HH:mm"

        ' Checking the length of the string is the correct size (5 digits)
        ' Input.Length is not 0 indexed
        If Input.Length <> 5 Then
            Return False
        End If

        ' Loops over each character in the string to check it meets the validation requirements
        For i = 0 To Input.Length - 1
            If i = 2 Then
                ' Checks that the time is in the correct format
                ' Checks the 3rd Character in the string is a ":"
                ' Indexing into a string is 0 indexed
                If Input(i) <> ":" Then
                    Return False
                End If
            Else
                ' Checks all other characters are digits.
                ' Returns false if the character is not a digit
                If Not (Input(i) Like "[0-9]") Then
                    Return False
                End If
            End If
        Next

        ' If Function has not returned then the string has passed validation
        Return True
    End Function
End Class
