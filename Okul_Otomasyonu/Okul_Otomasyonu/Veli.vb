Public Class Veli

  

    Private Sub Veli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DataSet11.Veli)

        Me.MdiParent = Ana_tablo

    End Sub
    Sub ol()
        current = CType(Me.BindingContext(BindingSource1), CurrencyManager)

    End Sub
    Public current As CurrencyManager
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ol()
            current.EndCurrentEdit()
            OleDbDataAdapter1.Update(DataSet11.Veli)
        Catch ex As Exception

        End Try
      

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            ol()
            current.AddNew()
        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BindingSource1.Filter = "NUMARASI='" + TextBox2.Text + "'"
    End Sub

#Region "BÜYÜK HARDLER"
    Private Sub TextBox9_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.Leave
        TextBox9.Text = UCase(TextBox9.Text)

    End Sub


    Private Sub TextBox3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        TextBox3.Text = UCase(TextBox3.Text)
    End Sub

    Private Sub TextBox5_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.Leave
        TextBox5.Text = UCase(TextBox5.Text)
    End Sub

    Private Sub TextBox23_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox23.Leave
        TextBox23.Text = UCase(TextBox23.Text)
    End Sub

    Private Sub TextBox11_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.Leave
        TextBox11.Text = UCase(TextBox11.Text)
    End Sub

    Private Sub TextBox7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.Leave
        TextBox7.Text = UCase(TextBox7.Text)
    End Sub

    Private Sub TextBox13_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.Leave
        TextBox13.Text = UCase(TextBox13.Text)
    End Sub

    Private Sub ComboBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.Leave
        ComboBox1.Text = UCase(ComboBox1.Text)
    End Sub

    Private Sub TextBox21_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.Leave
        TextBox21.Text = UCase(TextBox21.Text)
        TextBox21.Text = TextBox21.Text + " TL"
    End Sub

    Private Sub TextBox17_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.Leave
        TextBox17.Text = UCase(TextBox17.Text)
    End Sub
#End Region
   
    Private Sub TextBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Enter
        Button4_Click(Me, KeyEventArgs.Empty)

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3_Click(Me, KeyEventArgs.Empty)

        End If
    End Sub

    Private Sub TextBox9_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox9.KeyDown, TextBox5.KeyDown, TextBox3.KeyDown, TextBox23.KeyDown, TextBox11.KeyDown, TextBox7.KeyDown, TextBox21.KeyDown, TextBox17.KeyDown, TextBox13.KeyDown, ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2_Click(Me, KeyEventArgs.Empty)

        End If
    End Sub
End Class