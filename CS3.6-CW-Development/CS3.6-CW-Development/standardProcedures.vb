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

    Dim strKey As String = "EncypherKey"
    Dim objSimpleDes As New Simple3Des(strKey)
    Sub encrypTest()
        Dim stri = InputBox("?")
        Dim strEncrypted As String = objSimpleDes.Encrypt(stri)
        MsgBox(strEncrypted)
        Dim strDeEncrypted As String = objSimpleDes.Decrypt(strEncrypted)
        MsgBox(strDeEncrypted)

    End Sub

    ' This class is used to encrypt and decrypt strings.
    Public Class Simple3Des
        ' Encrypt a string into a string using a key.
        Private tdDes As New TripleDESCryptoServiceProvider
        ' The constructor obtains the key and initialization vector for the TripleDES
        Sub New(ByVal strKey As String)
            ' Initialize the TripleDES object.
            tdDes.Key = Truncate(strKey, tdDes.KeySize \ 8)
            ' Initialize the IV.
            tdDes.IV = Truncate("", tdDes.BlockSize \ 8)

        End Sub
        ' Truncate or pad a string to a specified length.
        Public Function Encrypt(ByVal strInput As String) As String
            ' Convert the input string to a byte array.
            Dim btInputBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(strInput)
            ' Create a MemoryStream.
            Dim msInput As New IO.MemoryStream
            ' Create a CryptoStream using the MemoryStream
            Dim csEncrypt As New CryptoStream(msInput,
               tdDes.CreateEncryptor(), CryptoStreamMode.Write)

            ' Write the byte array to the MemoryStream.
            csEncrypt.Write(btInputBytes, 0, btInputBytes.Length)
            csEncrypt.FlushFinalBlock()

            ' Convert the MemoryStream to a byte array.
            Return Convert.ToBase64String(msInput.ToArray)

        End Function
        Public Function Decrypt(ByVal strOutput As String) As String

            Dim btOutputBytes() As Byte =
               Convert.FromBase64String(strOutput)
            Dim msOutput As New IO.MemoryStream
            Dim csDecrypt As New CryptoStream(msOutput,
               tdDes.CreateDecryptor(), CryptoStreamMode.Write)

            csDecrypt.Write(btOutputBytes, 0, btOutputBytes.Length)
            csDecrypt.FlushFinalBlock()

            Return System.Text.Encoding.Unicode.GetString(msOutput.ToArray)

        End Function
        Private Function Truncate(ByVal strKey As String,
             ByVal intLength As Integer) As Byte()

            Dim shaCrypto As New SHA1CryptoServiceProvider
            Dim btKeyBytes() As Byte = Encoding.Unicode.GetBytes(strKey)
            Dim btHash() As Byte = shaCrypto.ComputeHash(btKeyBytes)

            ReDim Preserve btHash(intLength - 1)
            Return btHash

        End Function
    End Class
End Class


