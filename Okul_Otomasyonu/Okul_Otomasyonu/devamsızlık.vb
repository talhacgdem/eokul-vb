Public Class devamsızlık

    Private Sub devamsızlık_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Ana_tablo
        OleDbDataAdapter1.Fill(DataSet11.Hızlı_Kayıt)


    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim baglantı As New OleDb.OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.oledb.12.0;Data Source =mebsa.accdb"
        Dim veri As New OleDb.OleDbCommand
        veri.CommandText = "INSERT INTO Devamsızlık(NUMARASI,AY,RAPORLU,TOPÖZÜRLÜ,ÖGLESONRA,ÖZÜRSÜZDEV) values ('" & TextBox14.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox6.Text & "','" + TextBox10.Text + "','" + TextBox8.Text + "') "
        veri.CommandType = CommandType.Text
        veri.Connection = baglantı
        baglantı.Open()

        Try
            veri.ExecuteNonQuery()
        Catch ex As Exception

        End Try




        baglantı.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingSource1.Filter = "NUMARASI='" + TextBox14.Text + "'"
    End Sub

    Private Sub TextBox14_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox14.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Me, KeyEventArgs.Empty)
        End If


    End Sub
End Class