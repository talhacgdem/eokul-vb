Public Class Not_Girişi

    Dim s1, s2, s3, s4, s5 As Integer
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Not_Girişi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox11.Enabled = False
        Me.MdiParent = Ana_tablo
        OleDbDataAdapter1.Fill(DataSet11.Hızlı_Kayıt)
        ComboBox1.Text = ""

        ComboBox1.Items.Clear()

        cek()



    End Sub
    Sub cek()
        Dim connect As New OleDb.OleDbConnection
        connect.ConnectionString = "Provider=Microsoft.ACE.oledb.12.0;Data Source = mebsa.accdb"
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = connect
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Ders_Giriş where NUMARASI=@N "
        Dim p1 As New OleDb.OleDbParameter("@N", DbType.String)
        p1.SourceColumn = "NUMARASI"
        p1.Value = TextBox8.Text
        cmd.Parameters.Add(p1)
        connect.Open()

        Try
            Dim r As OleDb.OleDbDataReader
            r = cmd.ExecuteReader
            Do While r.Read = True
                ComboBox1.Items.Add(r.Item("DERSLER"))

            Loop


            connect.Close()
        Catch ex As Exception

        End Try
        
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            BindingSource1.Filter = "NUMARASI='" + TextBox8.Text + "'"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox8_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Me, KeyEventArgs.Empty)
        End If


    End Sub



    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        ComboBox1.Text = ""

        ComboBox1.Items.Clear()

        cek()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox8.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("ÖĞRENCİ NUMARASI GİRMEDİNİZ VEYA DERS SEÇİMİ YAPMADINIZ", MsgBoxStyle.Critical, "HATA")
        Else
            ekle()

        End If
    End Sub
    Sub ekle()
        Dim baglantı As New OleDb.OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.oledb.12.0;Data Source = mebsa.accdb"
        Dim veri As New OleDb.OleDbCommand
        veri.CommandText = "INSERT INTO Not_Girişi(NUMARASI,DERSLER,YAZ1,YAZ2,YAZ3,SOZ1,SOZ2,ORT) values ('" & TextBox8.Text & "','" & ComboBox1.Text & "','" & TextBox9.Text & "','" & TextBox24.Text & "','" + TextBox22.Text + "','" + TextBox19.Text + "','" + TextBox14.Text + "','" + TextBox10.Text + "') "
        veri.CommandType = CommandType.Text
        veri.Connection = baglantı
        baglantı.Open()

        Try
            veri.ExecuteNonQuery()
        Catch ex As Exception

        End Try




        baglantı.Close()
    End Sub
#Region "ayrılmalar"
    Private Sub TextBox9_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.Leave
        TextBox10.Text = TextBox9.Text

    End Sub

    Private Sub TextBox24_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox24.Leave
        Try
            s1 = TextBox9.Text
            s2 = TextBox24.Text

            TextBox10.Text = (s1 + s2) / 2

        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub TextBox22_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox22.Leave
        s1 = TextBox9.Text
        s2 = TextBox24.Text
        s3 = TextBox22.Text
        TextBox10.Text = (s1 + s2 + s3) / 3

    End Sub

    Private Sub TextBox19_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.Leave
        s1 = TextBox9.Text
        s2 = TextBox24.Text
        s3 = TextBox22.Text
        s4 = TextBox19.Text
        TextBox10.Text = (s1 + s2 + s3 + s4) / 4
    End Sub

    Private Sub TextBox14_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.Leave
        s1 = TextBox9.Text
        s2 = TextBox24.Text
        s3 = TextBox22.Text
        s4 = TextBox19.Text
        s5 = TextBox14.Text

        TextBox10.Text = (s1 + s2 + s3 + s4 + s5) / 5
    End Sub
#End Region
    
End Class