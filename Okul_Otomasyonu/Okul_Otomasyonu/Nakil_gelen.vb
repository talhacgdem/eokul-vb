
Public Class Nakil_gelen
    Sub ol()
        current = CType(Me.BindingContext(BindingSource1), CurrencyManager)
        current2 = CType(Me.BindingContext(BindingSource2), CurrencyManager)

    End Sub
    Public current, current2 As CurrencyManager
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Nakil_gelen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = Ana_tablo

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ol()
        current.EndCurrentEdit()
        current2.EndCurrentEdit()
        OleDbDataAdapter1.Update(DataSet11.Nakil_Gelen)
        OleDbDataAdapter2.Update(DataSet11.Hızlı_Kayıt)

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            ol()
            current.AddNew()
            current2.AddNew()
        Catch ex As Exception
            MsgBox("AÇTIĞINIZ KAYIYA BİR DEĞER GİRMEDEN KAYIT AÇAMAYA ÇALIŞTINIZ", MsgBoxStyle.Critical, "HATA")

        End Try


    End Sub
End Class


