Public Class Ogrenci_Belgesi

  

    Private Sub Ogrenci_Belgesi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = Ana_tablo
        OleDbDataAdapter1.Fill(DataSet11.Hızlı_Kayıt)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Belge_sec.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            BindingSource1.Filter = "NUMARASI='" + TextBox6.Text + "'"
        Catch ex As Exception

        End Try
    End Sub
End Class