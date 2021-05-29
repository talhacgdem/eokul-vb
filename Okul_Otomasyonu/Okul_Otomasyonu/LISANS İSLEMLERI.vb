Imports System.Management
Imports System.Data.OleDb

Public Class LISANS_İSLEMLERI
    Dim disk As New ManagementClass("Win32_PhysicalMedia")
    Dim kon As Boolean = False
    Private Sub LISANS_İSLEMLERI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        Button1.Enabled = False

        Me.Location = New System.Drawing.Point(250, 150)
        For Each hdisk As ManagementObject In disk.GetInstances()
            If hdisk("SerialNumber") <> Nothing Then
                TextBox7.Text = (CStr(hdisk("SerialNumber")))
                Exit For
            End If
        Next hdisk
        Dim cont As Boolean = FileIO.FileSystem.FileExists(Application.StartupPath + "\\msn.dll")
        If cont = True Then
            Try

                Me.Visible = False
            Catch ex As Exception

            End Try
           
        End If

    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True And RadioButton2.Checked = False Then
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox2.Focus()

        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton2.Checked = True Then
            Demo()
        ElseIf RadioButton1.Checked = True Then
            If kontrol(TextBox2.Text & TextBox3.Text & TextBox4.Text) = True Then
                ekle()

                MsgBox("AKTİVASYON KODUNUZ BAŞARILI BİR ŞEKİLDE UYGULANMIŞTIR MASTER YAZILIM İYİ KULLANIMLAR DİLER", MsgBoxStyle.Information, "DOĞRULAMA")
                Me.Visible = False
                Ana_tablo.Show()
                Form1.ShowDialog()
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\msn.dll", String.Empty, False)

            End If

        End If
    End Sub
    Sub Demo()
        Dim hak As Integer = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("demo").GetValue("Süre", 15)

        Ana_tablo.Text = hak & " AÇMA KAPAMA HAKKINIZ VAR "

        hak -= 1

        If hak < 0 Then

            MsgBox("Kullanım Hakkınız Sona Erdi", MsgBoxStyle.Critical)

            Me.Close()

        Else
            Ana_tablo.Show()
            Me.Visible = False
            Ana_tablo.Musteri.Enabled = False
            Ana_tablo.ÖĞRENCİNAKİLİŞLEMLERİToolStripMenuItem.Enabled = False
            Ana_tablo.ToolStripMenuItem3.Enabled = False
            Ana_tablo.ÖĞRENCİBELGELERİToolStripMenuItem.Enabled = False
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey("demo").SetValue("Süre", hak)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.TextLength = 3 Then
            TextBox3.Focus()

        End If
    End Sub
    Sub ekle()
        Dim baglantı As New OleDb.OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = mebsa.accdb"
        Dim veri As New OleDb.OleDbCommand
        veri.CommandText = "UPDATE Lisans SET HDD_NO='" + TextBox7.Text + "' where KOD=@a"
        veri.CommandType = CommandType.Text
        veri.Connection = baglantı
        baglantı.Open()
        

        Dim p0 As New OleDb.OleDbParameter("@a", DbType.String)
        p0.SourceColumn = "KOD"
        p0.Value = TextBox2.Text + TextBox3.Text + TextBox4.Text
        veri.Parameters.Add(p0)


        veri.ExecuteNonQuery()
       

        baglantı.Close()


    End Sub


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.TextLength = 3 Then
            TextBox4.Focus()

        End If
    End Sub
    Public Function kontrol(ByVal ad As String) As Boolean
        Dim baglantı As New OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mebsa.accdb"
        Dim commad As New OleDb.OleDbCommand
        commad.CommandText = "SELECT * FROM Lisans WHERE KOD=@KOD "
        commad.CommandType = CommandType.Text
        commad.Connection = baglantı

        Dim paremert As New OleDbParameter("@KOD", DbType.String)
        paremert.SourceColumn = "KOD"
        paremert.Value = TextBox2.Text & TextBox3.Text & TextBox4.Text
        commad.Parameters.Add(paremert)


        Dim oku As OleDbDataReader

        baglantı.Open()
        oku = commad.ExecuteReader
        Do While oku.Read = True
            If oku.Item("KOD") = ad Then
                kon = True
                Exit Do
            End If
        Loop
        If kon = True Then

            Return True
        ElseIf kon = False Then
            MsgBox("BÖYLE BİR AKTİVASYON KODU BULUNAMAMAKTADIR LÜTFEN GEÇERLİ BİR AKTİVASYON KODU GİRİNİZ", MsgBoxStyle.Critical, "UYARI")
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

            Return False
            TextBox2.Focus()

        End If
        baglantı.Close()

    End Function
   
End Class
