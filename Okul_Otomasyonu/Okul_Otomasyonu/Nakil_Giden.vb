Public Class Nakil_Giden
   

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Nakil_Giden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = Ana_tablo

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ekle()
        sil()



        MsgBox("ÖĞRENCİ NAKİL EDİLMİŞTİR", MsgBoxStyle.Information, "GÖNDERME İŞLEMİ")

    End Sub
    
    Sub sil()
        Dim baglantı As New OleDb.OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.oledb.12.0;Data Source = mebsa.accdb"
        Dim veri As New OleDb.OleDbCommand
        veri.CommandText = "DELETE *  FROM Hızlı_Kayıt where NUMARASI=@personel_no "
        veri.CommandType = CommandType.Text
        veri.Connection = baglantı

        Dim pno As New OleDb.OleDbParameter("@personel_no", DbType.String)
        pno.SourceColumn = "NUMARASI"
        pno.Value = TextBox4.Text
        veri.Parameters.Add(pno)

        Try
            baglantı.Open()
            veri.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        baglantı.Close()
    End Sub
    Sub ekle()
        Dim baglantı As New OleDb.OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.oledb.12.0;Data Source = mebsa.accdb"
        Dim veri As New OleDb.OleDbCommand
        veri.CommandText = "INSERT INTO Nakil_Giden(NUMARASI,GİDEN_OKUL,GÖN_TAR,BURS_ORAN) VALUES (@a,@b,@c,@d) "
        veri.CommandType = CommandType.Text
        veri.Connection = baglantı
        baglantı.Open()
        Dim p0 As New OleDb.OleDbParameter("@a", DbType.String)
        Dim p1 As New OleDb.OleDbParameter("@b", DbType.String)
        Dim p2 As New OleDb.OleDbParameter("@c", DbType.String)
        Dim p3 As New OleDb.OleDbParameter("@d", DbType.String)

        p0.Value = TextBox4.Text
        p1.Value = TextBox2.Text
        p2.Value = TextBox3.Text
        p3.Value = TextBox13.Text
        p0.SourceColumn = "NUMARASI"
        p1.SourceColumn = "GİDEN_OKUL"
        p2.SourceColumn = "GÖN_TAR"
        p3.SourceColumn = "BURS_ORAN"
        veri.Parameters.Add(p0)
        veri.Parameters.Add(p1)
        veri.Parameters.Add(p2)
        veri.Parameters.Add(p3)

        veri.ExecuteNonQuery()


        baglantı.Close()

    End Sub
End Class