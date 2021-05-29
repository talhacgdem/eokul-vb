Public Class Belge_sec

    Private Sub Belge_sec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Ogrenci_Belgesi.TextBox6.Text
        TextBox2.Text = Ogrenci_Belgesi.TextBox47.Text
        TextBox3.Text = Ogrenci_Belgesi.TextBox45.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Process.Start("hasta.docx")
        ElseIf RadioButton3.Checked = True Then
            Process.Start("NUFUS.docx")
        End If
        Me.Hide()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class