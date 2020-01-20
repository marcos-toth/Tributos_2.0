Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Module ModCrip

    Public Function Crypt(ByVal Text As String) As String
        Dim strTempChar As String
        For i = 1 To Len(Text)
            If Asc(Mid$(Text, i, 1)) < 128 Then
                strTempChar = Asc(Mid$(Text, i, 1)) + 128
            ElseIf Asc(Mid$(Text, i, 1)) > 128 Then
                strTempChar = Asc(Mid$(Text, i, 1)) - 128
            End If
            Mid$(Text, i, 1) = Chr(strTempChar)
        Next i
        Crypt = Text
        Return Text
    End Function
    Dim sal() As Byte = {&H0, &H1, &H2, &H3, &H4, &H5, &H6, &H5, &H4, &H3, &H2, &H1, &H0}
    Private Sub moveBytes(ByVal fonte As Stream, ByVal destino As Stream)
        Dim bytes(2048) As Byte
        Dim contador = fonte.Read(bytes, 0, bytes.Length - 1)
        While (0 <> contador)
            destino.Write(bytes, 0, contador)
            contador = fonte.Read(bytes, 0, bytes.Length - 1)
        End While
    End Sub
    Public Function ShowLine(ByVal line_selec As String, ByVal senha As String)
        Dim chave As New Rfc2898DeriveBytes(senha, sal)
        Dim algoritmo = New RijndaelManaged()
        algoritmo.Key = chave.GetBytes(16)
        algoritmo.IV = chave.GetBytes(16)
        Using StreamFonte = New MemoryStream(Convert.FromBase64String(line_selec))
            Using StreamDestino As New MemoryStream()
                Using crypto As New CryptoStream(StreamFonte, algoritmo.CreateDecryptor(), CryptoStreamMode.Read)
                    moveBytes(crypto, StreamDestino)
                    Dim bytesDescriptografados() As Byte = StreamDestino.ToArray()
                    Dim mensagemDescriptografada = New UnicodeEncoding().GetString(bytesDescriptografados)
                    Return mensagemDescriptografada
                End Using
            End Using
        End Using
    End Function
End Module
