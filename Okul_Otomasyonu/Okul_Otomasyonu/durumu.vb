Public Class durumu

    Private Sub durumu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbDataAdapter1.Fill(DataSet11.Not_Girişi)

        OleDbDataAdapter2.Fill(DataSet11.Devamsızlık)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class