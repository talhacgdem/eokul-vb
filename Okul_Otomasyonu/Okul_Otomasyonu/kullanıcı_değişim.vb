Imports System.Data.OleDb
Public Class kullanıcı_değişim

    Private Sub kullanıcı_değişim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Ana_tablo
        TextBox5.Text = Form1.TextBox1.Text
        Me.Location = New System.Drawing.Point(250, 150)
    End Sub


    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

        If kontrol(TextBox5.Text, TextBox7.Text) = True Then
            TextBox2.Enabled = True
            TextBox3.Enabled = True

        Else

        End If
    End Sub
    Public Function kontrol(ByVal ad As String, ByVal sifrex As String) As Boolean
        Dim baglantı As New OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mebsa.accdb"
        Dim commad As New OleDb.OleDbCommand
        commad.CommandText = "SELECT * FROM Lisans WHERE KADI=@kullanıcı_adı "
        commad.CommandType = CommandType.Text
        commad.Connection = baglantı

        Dim paremert As New OleDbParameter("@kullanıcı_adı", DbType.String)
        paremert.SourceColumn = "KADI"
        paremert.Value = ad
        commad.Parameters.Add(paremert)
        Dim sifrepa As New OleDbParameter("@sifre", DbType.String)
        sifrepa.SourceColumn = "SİFRE"
        sifrepa.Value = sifrex
        commad.Parameters.Add(sifrepa)


        Dim oku As OleDbDataReader

        baglantı.Open()
        Dim kon As Boolean = False
        oku = commad.ExecuteReader
        Do While oku.Read = True
            If oku.Item("KADI") = ad And oku.Item("SİFRE") = sifrex Then
                kon = True
                Exit Do
            End If
        Loop
        If kon = True Then

            Return True
        ElseIf kon = False Then
            TextBox2.Enabled = False
            TextBox3.Enabled = False

            Return False



        End If
        baglantı.Close()


    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sil()
        ekle()

        MsgBox("KULLANICI ADINIZ VE ŞİFRENİZ BAŞARILI BİR ŞEKİLDE DEĞİŞTİRİLMİŞTİR", MsgBoxStyle.Information, "DOĞRULAMA")

    End Sub
    Sub sil()
        Dim baglantı As New OleDb.OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.oledb.12.0;Data Source = mebsa.accdb"
        Dim veri As New OleDb.OleDbCommand
        veri.CommandText = "DELETE *  FROM Lisans where SİFRE=@SİFRE "
        veri.CommandType = CommandType.Text
        veri.Connection = baglantı

        Dim pno As New OleDb.OleDbParameter("@SİFRE", DbType.String)
        pno.SourceColumn = "SİFRE"
        pno.Value = TextBox7.Text
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
        veri.CommandText = "INSERT INTO Lisans(KADI,SİFRE) VALUES (@a,@b) "
        veri.CommandType = CommandType.Text
        veri.Connection = baglantı
        baglantı.Open()
        Dim p0 As New OleDb.OleDbParameter("@a", DbType.String)
        Dim p1 As New OleDb.OleDbParameter("@b", DbType.String)
      

        p0.Value = TextBox2.Text
        p1.Value = TextBox3.Text
       
        p0.SourceColumn = "KADI"
        p1.SourceColumn = "SİFRE"

        veri.Parameters.Add(p0)
        veri.Parameters.Add(p1)
        

        veri.ExecuteNonQuery()


        baglantı.Close()

    End Sub
End Class