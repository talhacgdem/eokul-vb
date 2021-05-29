Public Class Ders_Girişi

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        


    End Sub

    Private Sub Ders_Girişi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            OleDbDataAdapter1.Fill(DataSet11.Hızlı_Kayıt)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try




        Me.MdiParent = Ana_tablo


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
   
    End Sub

   
    
  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
        Try
            BindingSource1.Filter = "NUMARASI='" + TextBox6.Text + "'"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Me, KeyEventArgs.Empty)

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = UCase(TextBox2.Text)

        Dim baglantı As New OleDb.OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.oledb.12.0;Data Source = mebsa.accdb"
        Dim veri As New OleDb.OleDbCommand
        veri.CommandText = "INSERT INTO Ders_Giriş(NUMARASI,DERSLER) values ('" + TextBox6.Text + "','" + TextBox2.Text + "') "
        veri.CommandType = CommandType.Text
        veri.Connection = baglantı
        baglantı.Open()

        Try
            veri.ExecuteNonQuery()

        Catch ex As Exception

        End Try


        TextBox2.Clear()
        TextBox2.Focus()


        baglantı.Close()
       
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

            Button2_Click(Me, KeyEventArgs.Empty)
            

        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    

   
End Class