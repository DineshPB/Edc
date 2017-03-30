Imports Microsoft.VisualBasic
Imports System.Security.Cryptography
Imports System.IO

Public Class EncryptDecrypt
    Public Function Encrypt(ByVal inText As String, ByVal key As String) As String
        Dim bytesBuff As Byte() = Encoding.Unicode.GetBytes(inText)
        Using aes__1 As Aes = Aes.Create()
            Dim crypto As New Rfc2898DeriveBytes(key, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            aes__1.Key = crypto.GetBytes(32)
            aes__1.IV = crypto.GetBytes(16)
            Using mStream As New MemoryStream()
                Using cStream As New CryptoStream(mStream, aes__1.CreateEncryptor(), CryptoStreamMode.Write)
                    cStream.Write(bytesBuff, 0, bytesBuff.Length)
                    cStream.Close()
                End Using
                inText = Convert.ToBase64String(mStream.ToArray())
            End Using
        End Using
        Return inText
    End Function
    'Decrypting a string
    Public Function Decrypt(ByVal cryptTxt As String, ByVal key As String) As String
        cryptTxt = cryptTxt.Replace(" ", "+")
        Dim bytesBuff As Byte() = Convert.FromBase64String(cryptTxt)
        Using aes__1 As Aes = Aes.Create()
            Dim crypto As New Rfc2898DeriveBytes(key, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            aes__1.Key = crypto.GetBytes(32)
            aes__1.IV = crypto.GetBytes(16)
            Using mStream As New MemoryStream()
                Using cStream As New CryptoStream(mStream, aes__1.CreateDecryptor(), CryptoStreamMode.Write)
                    cStream.Write(bytesBuff, 0, bytesBuff.Length)
                    cStream.Close()
                End Using
                cryptTxt = Encoding.Unicode.GetString(mStream.ToArray())
            End Using
        End Using
        Return cryptTxt
    End Function
End Class
