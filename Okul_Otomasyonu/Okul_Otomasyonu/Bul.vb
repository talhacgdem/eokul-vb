Public Class Bul

    Private Sub Bul_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Ana_tablo
        OleDbDataAdapter1.Fill(DataSet11.Hızlı_Kayıt)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        durumu.Show()

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick

        durumu.BindingSource2.Filter = "NUMARASI='" + TextBox1.Text + "'"
        durumu.BindingSource1.Filter = "NUMARASI='" + TextBox1.Text + "'"
        durumu.Show()


        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()


    End Sub
End Class