Imports System.IO
Public Class Hızlı_Kayıt
    Dim isim As String
    Dim dosya() As String
    Dim resim_ad As String
    Private Sub Hızlı_Kayıt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sadece_okuma()
        Numara.Focus()
        Dal.Enabled = False
        Me.MdiParent = Ana_tablo
    End Sub
    Sub sadece_okuma()
        TextBox1.ReadOnly = True
        TextBox16.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox19.ReadOnly = True
        TextBox10.ReadOnly = True
        TextBox8.ReadOnly = True
        TextBox12.ReadOnly = True
        TextBox14.ReadOnly = True
        TextBox18.ReadOnly = True
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sınıf.SelectedIndexChanged
        If Sınıf.Text >= 9 Then
            Bölüm.Enabled = True
        ElseIf Sınıf.Text < 9 Then
            Bölüm.Enabled = False
        End If
        If Sınıf.Text >= 11 Then
            Dal.Enabled = True
        Else
            Dal.Enabled = False

        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If kontrol(Numara.Text) = False Then
            resim_ekle()
            EKLE()
            MsgBox("KAYDINIZ BAŞARILI BİR ŞEKİLDE KAYDEDİLMİŞTİR", MsgBoxStyle.Information, "DOGRULAMA")




        End If



    End Sub
    Sub EKLE()
        Dim baglantı As New OleDb.OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.oledb.12.0;Data Source = mebsa.accdb"
        Dim veri As New OleDb.OleDbCommand
        veri.CommandText = "insert into Hızlı_Kayıt(NUMARASI,AD,SOY,CIN,SINF,SUBE,BOLUM,DAL,DIL,YIL,DONEM,OKUL) values (@num,@ad,@so,@cın,@sın,@sub,@bol,@dal,@dıl,@yıl,@don,@okul)"
        veri.CommandType = CommandType.Text
        veri.Connection = baglantı
        baglantı.Open()

        Dim p0 As New OleDb.OleDbParameter("@num", DbType.String)
        Dim p1 As New OleDb.OleDbParameter("@ad", DbType.String)
        Dim p2 As New OleDb.OleDbParameter("@so", DbType.String)
        Dim p3 As New OleDb.OleDbParameter("@cın", DbType.String)
        Dim p4 As New OleDb.OleDbParameter("@sın", DbType.String)
        Dim p5 As New OleDb.OleDbParameter("@sub", DbType.String)
        Dim p6 As New OleDb.OleDbParameter("@bol", DbType.String)
        Dim p7 As New OleDb.OleDbParameter("@dal", DbType.String)
        Dim p8 As New OleDb.OleDbParameter("@dıl", DbType.String)
        Dim p9 As New OleDb.OleDbParameter("@yıl", DbType.String)
        Dim p10 As New OleDb.OleDbParameter("@don", DbType.String)
        Dim p11 As New OleDb.OleDbParameter("@okul", DbType.String)

        p0.SourceColumn = "NUMARASI"
        p1.SourceColumn = "AD"
        p2.SourceColumn = "SOY"
        p3.SourceColumn = "CIN"
        p4.SourceColumn = "SINF"
        p5.SourceColumn = "SUBE"
        p6.SourceColumn = "BOLUM"
        p7.SourceColumn = "DAL"
        p8.SourceColumn = "DIL"
        p9.SourceColumn = "YIL"
        p10.SourceColumn = "DONEM"
        p11.SourceColumn = "OKUL"

        p0.Value = Numara.Text
        p1.Value = Ad.Text
        p2.Value = Soyad.Text
        p3.Value = Cinsiyet.Text
        p4.Value = Sınıf.Text
        p5.Value = Şube.Text
        p6.Value = Bölüm.Text
        p7.Value = Dal.Text
        p8.Value = Yabancı_Dil.Text
        p9.Value = Öğrenim_Yıl.Text
        p10.Value = Dönem.Text
        p11.Value = Okul.Text

        veri.Parameters.Add(p0)
        veri.Parameters.Add(p1)
        veri.Parameters.Add(p2)
        veri.Parameters.Add(p3)
        veri.Parameters.Add(p4)
        veri.Parameters.Add(p5)
        veri.Parameters.Add(p6)
        veri.Parameters.Add(p7)
        veri.Parameters.Add(p8)
        veri.Parameters.Add(p9)
        veri.Parameters.Add(p10)
        veri.Parameters.Add(p11)
        veri.ExecuteNonQuery()



        baglantı.Close()
    End Sub
    Public Function kontrol(ByVal ad As String) As Boolean
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.oledb.12.0;Data Source = mebsa.accdb"
        Dim veri As New OleDb.OleDbCommand
        veri.CommandText = "SELECT * FROM Hızlı_Kayıt where NUMARASI=@NUMARASI"
        veri.CommandType = CommandType.Text
        veri.Connection = conn
        conn.Open()
        Dim p1 As New OleDb.OleDbParameter("@NUMARASI", DbType.String)
        p1.SourceColumn = "NUMARASI"
        p1.Value = ad
        veri.Parameters.Add(p1)

        Dim onay As Boolean = False
        Dim oku As OleDb.OleDbDataReader
        oku = veri.ExecuteReader
        Do While oku.Read = True
            If oku.Item("NUMARASI") = ad Then
                onay = True
            End If
        Loop
        Try
            If onay = True Then
                MsgBox("BU ÖĞRENCİ NUMARASI KAYITLIDIR LÜTFEN BAŞKA BİR ÖĞRENCİ NUMARASI GİRİNİZ", MsgBoxStyle.Critical, "HATA")
                Return True
            ElseIf onay = False Then

                Return False

            End If

        Catch ex As Exception

        End Try

        conn.Close()


    End Function

    Private Sub Ad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ad.Leave
        Ad.Text = UCase(Ad.Text)

    End Sub

    Private Sub Soyad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Soyad.Leave
        Soyad.Text = UCase(Soyad.Text)

    End Sub

    Private Sub Şube_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Şube.Leave
        Şube.Text = UCase(Şube.Text)

    End Sub

    Private Sub Bölüm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bölüm.Leave
        Bölüm.Text = UCase(Bölüm.Text)

    End Sub

    Private Sub Dal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dal.Leave
        Dal.Text = UCase(Dal.Text)

    End Sub

    Private Sub Okul_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Okul.Leave
        Okul.Text = UCase(Okul.Text)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        degistir()
        MsgBox("KAYDINIZ GÜNCELLENMİŞTİR", MsgBoxStyle.Information, "BAŞARILI")

    End Sub
    Sub degistir()
        Dim baglantı As New OleDb.OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.oledb.12.0;Data Source = mebsa.accdb"
        Dim veri As New OleDb.OleDbCommand
        veri.CommandText = "UPDATE Hızlı_Kayıt set AD='" & Ad.Text & " ', SOY='" & Soyad.Text & "',CIN='" & Cinsiyet.Text & "',SINF='" & Sınıf.Text & "',SUBE ='" & Şube.Text & "',BOLUM='" & Bölüm.Text & "',DAL='" & Dal.Text & "',DIL='" & Yabancı_Dil.Text & "',YIL='" & Öğrenim_Yıl.Text & "',DONEM='" & Dönem.Text & "',OKUL='" & Okul.Text & "',RESIM='" & Yol.Text & "' where NUMARASI=@num"
        veri.Connection = baglantı

        Dim p1 As New OleDb.OleDbParameter("@num", DbType.String)
        p1.SourceColumn = "NUMARASI"
        p1.Value = Numara.Text
        veri.Parameters.Add(p1)

        baglantı.Open()

        veri.ExecuteNonQuery()


        baglantı.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Numara.Clear()
        Ad.Clear()
        Soyad.Clear()
        Cinsiyet.Text = ""
        Sınıf.Text = ""
        Şube.Clear()
        Bölüm.Clear()
        Dal.Clear()
        Yabancı_Dil.Text = ""
        Öğrenim_Yıl.Text = ""
        Dönem.Clear()
        Okul.Clear()
        Yol.Clear()
        Numara.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Resim Dosyaları|" & "*.jpg;*.bmp;*.gif"
        OpenFileDialog1.ShowDialog()


    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim resimsec_yol As String = Path.GetFullPath(OpenFileDialog1.FileName)
        Dim resimsec_dosya As New FileStream(resimsec_yol, FileMode.Open, FileAccess.Read, FileShare.Read)
        Dim resim As New Bitmap(resimsec_dosya, True)
        PictureBox1.Image = resim
        Yol.Text = resimsec_yol

        dosya = Split(Yol.Text, "\")
        isim = dosya(dosya.Length - 1)
        TextBox2.Text = isim

    End Sub
    Sub resim_ekle()


        Try
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\RESİM DOSYASI")
            File.Copy(Yol.Text, Application.StartupPath & "\RESİM DOSYASI\" & Numara.Text & "-" & Ad.Text & "  " & Soyad.Text & ".jpg")
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Cinsiyet_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cinsiyet.Leave
        Cinsiyet.Text = UCase(Cinsiyet.Text)

    End Sub

    Private Sub Sınıf_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sınıf.Leave
        Sınıf.Text = UCase(Sınıf.Text)

    End Sub

    Private Sub Yabancı_Dil_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Yabancı_Dil.Leave
        Yabancı_Dil.Text = UCase(Yabancı_Dil.Text)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        resim_ekle()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Numara_TextChanged(sender As Object, e As EventArgs) Handles Numara.TextChanged

    End Sub
End Class