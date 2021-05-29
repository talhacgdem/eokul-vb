Public Class Bilgiler

    Sub ol()
        current = CType(Me.BindingContext(BindingSource1), CurrencyManager)

    End Sub
    Public current As CurrencyManager

    Private Sub Bilgiler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DataSet11.Bilgiler)

        Me.MdiParent = Ana_tablo

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ol()
        current.EndCurrentEdit()
        OleDbDataAdapter1.Update(DataSet11.Bilgiler)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BindingSource1.Filter = "NUMARASI='" + TextBox2.Text + "'"

    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ol()
        current.AddNew()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox15_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox15.KeyDown, TextBox9.KeyDown, TextBox7.KeyDown, TextBox5.KeyDown, TextBox3.KeyDown, TextBox25.KeyDown, TextBox23.KeyDown, TextBox13.KeyDown, ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2_Click(Me, KeyEventArgs.Empty)

        End If
    End Sub
End Class