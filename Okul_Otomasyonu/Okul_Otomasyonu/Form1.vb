Imports System.Data.OleDb
Public Class Form1
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim a As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            a.ClassStyle = a.ClassStyle Or CS_NOCLOSE
            CS_NOCLOSE.ToString.Trim()
            Return a
        End Get
    End Property
    Private Sub Timer1_Tick(ByVal accesstr As System.Object, ByVal s As System.EventArgs)

    End Sub



    Private Sub Form1_Load(ByVal accesstr As System.Object, ByVal s As System.EventArgs) Handles MyBase.Load
        Me.Location = New System.Drawing.Point(250, 150)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If kontrol(TextBox1.Text, TextBox2.Text) = True Then
            MsgBox("HOŞGELDİNİZ... ", MsgBoxStyle.Information, "HOŞGELDİNİZ")
            Me.Visible = False
            Ana_tablo.Show()



        Else

        End If


    End Sub
    Public Function kontrol(ByVal ad As String, ByVal sifrex As String) As Boolean
        Dim baglantı As New OleDbConnection
        baglantı.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mebsa.accdb"
        Dim commad As New OleDb.OleDbCommand
        commad.CommandText = "SELECT * FROM Lisans WHERE KADI=@kullanıcı_adı "
        commad.CommandType = CommandType.Text
        commad.Connection = baglantı

        Dim paremert As New OleDbParameter("@kullanıcı_adı", DbType.String)
        paremert.SourceColumn = "KADI"
        paremert.Value = ad
        commad.Parameters.Add(paremert)
        Dim sifrepa As New OleDbParameter("@sifre", DbType.String)
        sifrepa.SourceColumn = "SİFRE"
        sifrepa.Value = sifrex
        commad.Parameters.Add(sifrepa)


        Dim oku As OleDbDataReader

        baglantı.Open()
        Dim kon As Boolean = False
        oku = commad.ExecuteReader
        Do While oku.Read = True
            If oku.Item("KADI") = ad And oku.Item("SİFRE") = sifrex Then
                kon = True
                Exit Do
            End If
        Loop
        If kon = True Then

            Return True
        ElseIf kon = False Then
            MsgBox("KULLANICI ADI VEYA ŞİFRENİZİ KONTROL EDİNİZ", MsgBoxStyle.Critical, "UYARI")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
            Return False
            


        End If
        baglantı.Close()


    End Function

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Button1_Click(Me, KeyEventArgs.Empty)

            End If
        Catch ex As Exception

        End Try
        
    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        Windows.Forms.Application.Exit()

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
