Public Class Gelen_Giden

    Private Sub Gelen_Giden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Ana_tablo
        OleDbDataAdapter1.Fill(DataSet11.Nakil_Giden)
        OleDbDataAdapter2.Fill(DataSet11.Nakil_Gelen)

    End Sub
End Class