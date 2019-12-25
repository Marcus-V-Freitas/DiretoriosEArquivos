Public Class Form1
    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        Dim file As OpenFileDialog = New OpenFileDialog
        Dim result As DialogResult = file.ShowDialog
        txtProcurar.Text = file.FileName
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim fileOrDirectory As String = txtProcurar.Text
        Dim infoOutput As String = ""

        If IO.File.Exists(fileOrDirectory) Then
            infoOutput = "Criado em: " & IO.File.GetCreationTime(fileOrDirectory) & vbCrLf
            infoOutput += "Modificado em: " & IO.File.GetLastWriteTime(fileOrDirectory) & vbCrLf
            infoOutput += "Ultimo acesso em: " & IO.File.GetLastAccessTime(fileOrDirectory) & vbCrLf
            txtInfo.Text = infoOutput
        ElseIf IO.Directory.Exists(fileOrDirectory) Then
            infoOutput = "Criado em: " & IO.Directory.GetCreationTime(fileOrDirectory) & vbCrLf
            infoOutput += "Modificado em: " & IO.Directory.GetLastWriteTime(fileOrDirectory) & vbCrLf
            infoOutput += "Ultimo acesso em: " & IO.Directory.GetLastAccessTime(fileOrDirectory) & vbCrLf
            txtInfo.Text = infoOutput
        Else
            MessageBox.Show("O arquivo ou o diretório não existem.")
        End If

    End Sub
End Class
