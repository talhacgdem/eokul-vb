<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nakil_gelen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nakil_gelen))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox23 = New System.Windows.Forms.TextBox
        Me.TextBox24 = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Cinsiyet = New System.Windows.Forms.ComboBox
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New Okul_Otomasyonu.DataSet1
        Me.Dönem = New System.Windows.Forms.TextBox
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.Numara = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Yabancı_Dil = New System.Windows.Forms.ComboBox
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.Şube = New System.Windows.Forms.TextBox
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.Öğrenim_Yıl = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Sınıf = New System.Windows.Forms.ComboBox
        Me.Dal = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Ad = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.Soyad = New System.Windows.Forms.TextBox
        Me.Bölüm = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.TextBox36 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox34 = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox23)
        Me.GroupBox1.Controls.Add(Me.TextBox24)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 488)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ÖGRENCİ NAKİL İŞLEMLERİ"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.TextBox9.Location = New System.Drawing.Point(1144, 184)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(184, 24)
        Me.TextBox9.TabIndex = 51
        '
        'TextBox23
        '
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.TextBox23.Location = New System.Drawing.Point(1144, 96)
        Me.TextBox23.Multiline = True
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(184, 24)
        Me.TextBox23.TabIndex = 45
        '
        'TextBox24
        '
        Me.TextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.TextBox24.Location = New System.Drawing.Point(1144, 136)
        Me.TextBox24.Multiline = True
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(184, 24)
        Me.TextBox24.TabIndex = 47
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Cinsiyet)
        Me.GroupBox5.Controls.Add(Me.Dönem)
        Me.GroupBox5.Controls.Add(Me.TextBox20)
        Me.GroupBox5.Controls.Add(Me.Numara)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.Controls.Add(Me.Yabancı_Dil)
        Me.GroupBox5.Controls.Add(Me.TextBox18)
        Me.GroupBox5.Controls.Add(Me.Şube)
        Me.GroupBox5.Controls.Add(Me.TextBox19)
        Me.GroupBox5.Controls.Add(Me.Öğrenim_Yıl)
        Me.GroupBox5.Controls.Add(Me.TextBox7)
        Me.GroupBox5.Controls.Add(Me.Sınıf)
        Me.GroupBox5.Controls.Add(Me.Dal)
        Me.GroupBox5.Controls.Add(Me.TextBox12)
        Me.GroupBox5.Controls.Add(Me.Ad)
        Me.GroupBox5.Controls.Add(Me.TextBox10)
        Me.GroupBox5.Controls.Add(Me.TextBox16)
        Me.GroupBox5.Controls.Add(Me.Soyad)
        Me.GroupBox5.Controls.Add(Me.Bölüm)
        Me.GroupBox5.Controls.Add(Me.TextBox11)
        Me.GroupBox5.Controls.Add(Me.TextBox13)
        Me.GroupBox5.Controls.Add(Me.TextBox15)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.TextBox17)
        Me.GroupBox5.Controls.Add(Me.TextBox21)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.TextBox6)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.TextBox8)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.TextBox5)
        Me.GroupBox5.Controls.Add(Me.RadioButton2)
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
        Me.GroupBox5.Controls.Add(Me.TextBox36)
        Me.GroupBox5.Controls.Add(Me.TextBox14)
        Me.GroupBox5.Controls.Add(Me.TextBox34)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(632, 464)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "NAKİL BİLGİLERİ"
        '
        'Cinsiyet
        '
        Me.Cinsiyet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "CIN", True))
        Me.Cinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Cinsiyet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Cinsiyet.FormattingEnabled = True
        Me.Cinsiyet.Items.AddRange(New Object() {"ERKEK", "KIZ"})
        Me.Cinsiyet.Location = New System.Drawing.Point(440, 80)
        Me.Cinsiyet.Name = "Cinsiyet"
        Me.Cinsiyet.Size = New System.Drawing.Size(184, 24)
        Me.Cinsiyet.TabIndex = 4
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "Hızlı_Kayıt"
        Me.BindingSource2.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dönem
        '
        Me.Dönem.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "DONEM", True))
        Me.Dönem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Dönem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Dönem.Location = New System.Drawing.Point(200, 245)
        Me.Dönem.Multiline = True
        Me.Dönem.Name = "Dönem"
        Me.Dönem.Size = New System.Drawing.Size(112, 24)
        Me.Dönem.TabIndex = 11
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.Bisque
        Me.TextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(8, 245)
        Me.TextBox20.Multiline = True
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(184, 24)
        Me.TextBox20.TabIndex = 73
        Me.TextBox20.TabStop = False
        Me.TextBox20.Text = "Kayıtlı Olduğu Dönem"
        '
        'Numara
        '
        Me.Numara.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "NUMARASI", True))
        Me.Numara.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Numara.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Numara.Location = New System.Drawing.Point(128, 40)
        Me.Numara.Multiline = True
        Me.Numara.Name = "Numara"
        Me.Numara.Size = New System.Drawing.Size(184, 24)
        Me.Numara.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Bisque
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(8, 40)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 24)
        Me.TextBox4.TabIndex = 51
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "Numarası"
        '
        'Yabancı_Dil
        '
        Me.Yabancı_Dil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "DIL", True))
        Me.Yabancı_Dil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Yabancı_Dil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Yabancı_Dil.FormattingEnabled = True
        Me.Yabancı_Dil.Items.AddRange(New Object() {"İngilizce", "Almanca", "Fransızca", "Diğerleri"})
        Me.Yabancı_Dil.Location = New System.Drawing.Point(128, 200)
        Me.Yabancı_Dil.Name = "Yabancı_Dil"
        Me.Yabancı_Dil.Size = New System.Drawing.Size(184, 24)
        Me.Yabancı_Dil.TabIndex = 9
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.Color.Bisque
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(8, 200)
        Me.TextBox18.Multiline = True
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(112, 24)
        Me.TextBox18.TabIndex = 71
        Me.TextBox18.TabStop = False
        Me.TextBox18.Text = "Yabancı Dili"
        '
        'Şube
        '
        Me.Şube.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "SUBE", True))
        Me.Şube.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Şube.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Şube.Location = New System.Drawing.Point(440, 120)
        Me.Şube.Multiline = True
        Me.Şube.Name = "Şube"
        Me.Şube.Size = New System.Drawing.Size(184, 24)
        Me.Şube.TabIndex = 6
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.Color.Bisque
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(320, 120)
        Me.TextBox19.Multiline = True
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(112, 24)
        Me.TextBox19.TabIndex = 72
        Me.TextBox19.TabStop = False
        Me.TextBox19.Text = "Şubesi"
        '
        'Öğrenim_Yıl
        '
        Me.Öğrenim_Yıl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "YIL", True))
        Me.Öğrenim_Yıl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Öğrenim_Yıl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Öğrenim_Yıl.Location = New System.Drawing.Point(440, 200)
        Me.Öğrenim_Yıl.Multiline = True
        Me.Öğrenim_Yıl.Name = "Öğrenim_Yıl"
        Me.Öğrenim_Yıl.Size = New System.Drawing.Size(184, 24)
        Me.Öğrenim_Yıl.TabIndex = 10
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Bisque
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(320, 200)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(112, 24)
        Me.TextBox7.TabIndex = 69
        Me.TextBox7.TabStop = False
        Me.TextBox7.Text = "Öğrenim(Yılı)"
        '
        'Sınıf
        '
        Me.Sınıf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "SINF", True))
        Me.Sınıf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Sınıf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Sınıf.FormattingEnabled = True
        Me.Sınıf.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.Sınıf.Location = New System.Drawing.Point(128, 120)
        Me.Sınıf.Name = "Sınıf"
        Me.Sınıf.Size = New System.Drawing.Size(184, 24)
        Me.Sınıf.TabIndex = 5
        '
        'Dal
        '
        Me.Dal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "DAL", True))
        Me.Dal.Enabled = False
        Me.Dal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Dal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Dal.Location = New System.Drawing.Point(440, 160)
        Me.Dal.Multiline = True
        Me.Dal.Name = "Dal"
        Me.Dal.Size = New System.Drawing.Size(184, 24)
        Me.Dal.TabIndex = 8
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Bisque
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(320, 160)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(112, 24)
        Me.TextBox12.TabIndex = 65
        Me.TextBox12.TabStop = False
        Me.TextBox12.Text = "Dalı"
        '
        'Ad
        '
        Me.Ad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "AD", True))
        Me.Ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Ad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Ad.Location = New System.Drawing.Point(440, 40)
        Me.Ad.Multiline = True
        Me.Ad.Name = "Ad"
        Me.Ad.Size = New System.Drawing.Size(184, 24)
        Me.Ad.TabIndex = 2
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Bisque
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(320, 80)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(112, 24)
        Me.TextBox10.TabIndex = 62
        Me.TextBox10.TabStop = False
        Me.TextBox10.Text = "Cinsiyeti"
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.Bisque
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(320, 40)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(112, 24)
        Me.TextBox16.TabIndex = 70
        Me.TextBox16.TabStop = False
        Me.TextBox16.Text = "Adı"
        '
        'Soyad
        '
        Me.Soyad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "SOY", True))
        Me.Soyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Soyad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Soyad.Location = New System.Drawing.Point(128, 80)
        Me.Soyad.Multiline = True
        Me.Soyad.Name = "Soyad"
        Me.Soyad.Size = New System.Drawing.Size(184, 24)
        Me.Soyad.TabIndex = 3
        '
        'Bölüm
        '
        Me.Bölüm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "BOLUM", True))
        Me.Bölüm.Enabled = False
        Me.Bölüm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Bölüm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Bölüm.Location = New System.Drawing.Point(128, 160)
        Me.Bölüm.Multiline = True
        Me.Bölüm.Name = "Bölüm"
        Me.Bölüm.Size = New System.Drawing.Size(184, 24)
        Me.Bölüm.TabIndex = 7
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Bisque
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(8, 160)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(112, 24)
        Me.TextBox11.TabIndex = 60
        Me.TextBox11.TabStop = False
        Me.TextBox11.Text = "Bölümü"
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.Bisque
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(8, 80)
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(112, 24)
        Me.TextBox13.TabIndex = 53
        Me.TextBox13.TabStop = False
        Me.TextBox13.Text = "Soyadı"
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.Bisque
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(8, 120)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(112, 24)
        Me.TextBox15.TabIndex = 56
        Me.TextBox15.TabStop = False
        Me.TextBox15.Text = "Sınıfı"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(360, 400)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 56)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "YENİ KAYIT"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "NUMARASI", True))
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.TextBox17.Location = New System.Drawing.Point(176, 304)
        Me.TextBox17.Multiline = True
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(136, 24)
        Me.TextBox17.TabIndex = 13
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Nakil_Gelen"
        Me.BindingSource1.DataSource = Me.DataSet11
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.Color.Bisque
        Me.TextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox21.Location = New System.Drawing.Point(8, 304)
        Me.TextBox21.Multiline = True
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(160, 24)
        Me.TextBox21.TabIndex = 41
        Me.TextBox21.TabStop = False
        Me.TextBox21.Text = "Numarası"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "GEL_OKUL", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(440, 240)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(184, 24)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Bisque
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(320, 240)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 24)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Geldiği Okul"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Bisque
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(8, 352)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(160, 24)
        Me.TextBox6.TabIndex = 4
        Me.TextBox6.TabStop = False
        Me.TextBox6.Text = "Geliş Yeri"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(488, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 56)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "KAYDET"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Bisque
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(320, 352)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(152, 24)
        Me.TextBox8.TabIndex = 6
        Me.TextBox8.TabStop = False
        Me.TextBox8.Text = "Okula Giriş Puanı"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "KAYIT_TAR", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(440, 304)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 24)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "GİRİŞ_PUAN", True))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(480, 352)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(144, 24)
        Me.TextBox5.TabIndex = 17
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "GELİŞ_YERİ_KOY", True))
        Me.RadioButton2.Location = New System.Drawing.Point(256, 352)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(53, 21)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Köy"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "GELİŞ_YERİ_ŞEHIR", True))
        Me.RadioButton1.Location = New System.Drawing.Point(184, 352)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 21)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Şehir"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBox36
        '
        Me.TextBox36.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "BUR_ORAN", True))
        Me.TextBox36.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.TextBox36.Location = New System.Drawing.Point(192, 400)
        Me.TextBox36.Multiline = True
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(144, 24)
        Me.TextBox36.TabIndex = 18
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.Bisque
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(8, 400)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(160, 24)
        Me.TextBox14.TabIndex = 12
        Me.TextBox14.TabStop = False
        Me.TextBox14.Text = "Burs Oranı"
        '
        'TextBox34
        '
        Me.TextBox34.BackColor = System.Drawing.Color.Bisque
        Me.TextBox34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox34.Location = New System.Drawing.Point(320, 304)
        Me.TextBox34.Multiline = True
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(112, 24)
        Me.TextBox34.TabIndex = 14
        Me.TextBox34.TabStop = False
        Me.TextBox34.Text = "Kayıt Tarihi"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(176, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(304, 50)
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT      Nakil_Gelen.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          Nakil_Gelen"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""mebsa.accdb"""
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `Nakil_Gelen` (`NUMARASI`, `GEL_OKUL`, `GELİŞ_YERİ_ŞEHIR`, `GELİŞ_YER" & _
            "İ_KOY`, `KAYIT_TAR`, `GİRİŞ_PUAN`, `BUR_ORAN`) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("GEL_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, "GEL_OKUL"), New System.Data.OleDb.OleDbParameter("GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, "GELİŞ_YERİ_ŞEHIR"), New System.Data.OleDb.OleDbParameter("GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, "GELİŞ_YERİ_KOY"), New System.Data.OleDb.OleDbParameter("KAYIT_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, "KAYIT_TAR"), New System.Data.OleDb.OleDbParameter("GİRİŞ_PUAN", System.Data.OleDb.OleDbType.VarWChar, 0, "GİRİŞ_PUAN"), New System.Data.OleDb.OleDbParameter("BUR_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, "BUR_ORAN")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("GEL_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, "GEL_OKUL"), New System.Data.OleDb.OleDbParameter("GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, "GELİŞ_YERİ_ŞEHIR"), New System.Data.OleDb.OleDbParameter("GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, "GELİŞ_YERİ_KOY"), New System.Data.OleDb.OleDbParameter("KAYIT_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, "KAYIT_TAR"), New System.Data.OleDb.OleDbParameter("GİRİŞ_PUAN", System.Data.OleDb.OleDbType.VarWChar, 0, "GİRİŞ_PUAN"), New System.Data.OleDb.OleDbParameter("BUR_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, "BUR_ORAN"), New System.Data.OleDb.OleDbParameter("Original_NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMARASI", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GEL_OKUL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GEL_OKUL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GEL_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GEL_OKUL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_ŞEHIR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_ŞEHIR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_KOY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_KOY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_KAYIT_TAR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "KAYIT_TAR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_KAYIT_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KAYIT_TAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GİRİŞ_PUAN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GİRİŞ_PUAN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GİRİŞ_PUAN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GİRİŞ_PUAN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_BUR_ORAN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BUR_ORAN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_BUR_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BUR_ORAN", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMARASI", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GEL_OKUL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GEL_OKUL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GEL_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GEL_OKUL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_ŞEHIR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_ŞEHIR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_KOY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_KOY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_KAYIT_TAR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "KAYIT_TAR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_KAYIT_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KAYIT_TAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GİRİŞ_PUAN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GİRİŞ_PUAN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GİRİŞ_PUAN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GİRİŞ_PUAN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_BUR_ORAN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BUR_ORAN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_BUR_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BUR_ORAN", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Nakil_Gelen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NUMARASI", "NUMARASI"), New System.Data.Common.DataColumnMapping("GEL_OKUL", "GEL_OKUL"), New System.Data.Common.DataColumnMapping("GELİŞ_YERİ_ŞEHIR", "GELİŞ_YERİ_ŞEHIR"), New System.Data.Common.DataColumnMapping("GELİŞ_YERİ_KOY", "GELİŞ_YERİ_KOY"), New System.Data.Common.DataColumnMapping("KAYIT_TAR", "KAYIT_TAR"), New System.Data.Common.DataColumnMapping("GİRİŞ_PUAN", "GİRİŞ_PUAN"), New System.Data.Common.DataColumnMapping("BUR_ORAN", "BUR_ORAN")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT      [Hızlı_Kayıt].*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          [Hızlı_Kayıt]"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection2
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""mebsa.accdb"""
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO `Hızlı_Kayıt` (`NUMARASI`, `AD`, `SOY`, `CIN`, `SINF`, `SUBE`, `BOLUM" & _
            "`, `DAL`, `DIL`, `YIL`, `DONEM`, `OKUL`, `RESIM`) VALUES (?, ?, ?, ?, ?, ?, ?, ?" & _
            ", ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("AD", System.Data.OleDb.OleDbType.VarWChar, 0, "AD"), New System.Data.OleDb.OleDbParameter("SOY", System.Data.OleDb.OleDbType.VarWChar, 0, "SOY"), New System.Data.OleDb.OleDbParameter("CIN", System.Data.OleDb.OleDbType.VarWChar, 0, "CIN"), New System.Data.OleDb.OleDbParameter("SINF", System.Data.OleDb.OleDbType.VarWChar, 0, "SINF"), New System.Data.OleDb.OleDbParameter("SUBE", System.Data.OleDb.OleDbType.VarWChar, 0, "SUBE"), New System.Data.OleDb.OleDbParameter("BOLUM", System.Data.OleDb.OleDbType.VarWChar, 0, "BOLUM"), New System.Data.OleDb.OleDbParameter("DAL", System.Data.OleDb.OleDbType.VarWChar, 0, "DAL"), New System.Data.OleDb.OleDbParameter("DIL", System.Data.OleDb.OleDbType.VarWChar, 0, "DIL"), New System.Data.OleDb.OleDbParameter("YIL", System.Data.OleDb.OleDbType.VarWChar, 0, "YIL"), New System.Data.OleDb.OleDbParameter("DONEM", System.Data.OleDb.OleDbType.VarWChar, 0, "DONEM"), New System.Data.OleDb.OleDbParameter("OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, "OKUL"), New System.Data.OleDb.OleDbParameter("RESIM", System.Data.OleDb.OleDbType.VarWChar, 0, "RESIM")})
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = resources.GetString("OleDbUpdateCommand2.CommandText")
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("AD", System.Data.OleDb.OleDbType.VarWChar, 0, "AD"), New System.Data.OleDb.OleDbParameter("SOY", System.Data.OleDb.OleDbType.VarWChar, 0, "SOY"), New System.Data.OleDb.OleDbParameter("CIN", System.Data.OleDb.OleDbType.VarWChar, 0, "CIN"), New System.Data.OleDb.OleDbParameter("SINF", System.Data.OleDb.OleDbType.VarWChar, 0, "SINF"), New System.Data.OleDb.OleDbParameter("SUBE", System.Data.OleDb.OleDbType.VarWChar, 0, "SUBE"), New System.Data.OleDb.OleDbParameter("BOLUM", System.Data.OleDb.OleDbType.VarWChar, 0, "BOLUM"), New System.Data.OleDb.OleDbParameter("DAL", System.Data.OleDb.OleDbType.VarWChar, 0, "DAL"), New System.Data.OleDb.OleDbParameter("DIL", System.Data.OleDb.OleDbType.VarWChar, 0, "DIL"), New System.Data.OleDb.OleDbParameter("YIL", System.Data.OleDb.OleDbType.VarWChar, 0, "YIL"), New System.Data.OleDb.OleDbParameter("DONEM", System.Data.OleDb.OleDbType.VarWChar, 0, "DONEM"), New System.Data.OleDb.OleDbParameter("OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, "OKUL"), New System.Data.OleDb.OleDbParameter("RESIM", System.Data.OleDb.OleDbType.VarWChar, 0, "RESIM"), New System.Data.OleDb.OleDbParameter("Original_NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMARASI", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_AD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AD", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_AD", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SOY", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SOY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SOY", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SOY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_CIN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CIN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_CIN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SINF", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SINF", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SINF", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SINF", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SUBE", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SUBE", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SUBE", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUBE", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_BOLUM", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BOLUM", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_BOLUM", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BOLUM", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DAL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DAL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DAL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DAL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DIL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DIL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DIL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DIL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_YIL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "YIL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_YIL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "YIL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DONEM", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DONEM", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DONEM", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DONEM", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_OKUL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OKUL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OKUL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_RESIM", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RESIM", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_RESIM", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RESIM", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = resources.GetString("OleDbDeleteCommand2.CommandText")
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMARASI", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_AD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AD", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_AD", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SOY", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SOY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SOY", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SOY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_CIN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CIN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_CIN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SINF", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SINF", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SINF", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SINF", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SUBE", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SUBE", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SUBE", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUBE", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_BOLUM", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BOLUM", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_BOLUM", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BOLUM", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DAL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DAL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DAL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DAL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DIL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DIL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DIL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DIL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_YIL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "YIL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_YIL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "YIL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DONEM", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DONEM", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DONEM", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DONEM", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_OKUL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "OKUL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OKUL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_RESIM", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RESIM", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_RESIM", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RESIM", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Hızlı_Kayıt", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NUMARASI", "NUMARASI"), New System.Data.Common.DataColumnMapping("AD", "AD"), New System.Data.Common.DataColumnMapping("SOY", "SOY"), New System.Data.Common.DataColumnMapping("CIN", "CIN"), New System.Data.Common.DataColumnMapping("SINF", "SINF"), New System.Data.Common.DataColumnMapping("SUBE", "SUBE"), New System.Data.Common.DataColumnMapping("BOLUM", "BOLUM"), New System.Data.Common.DataColumnMapping("DAL", "DAL"), New System.Data.Common.DataColumnMapping("DIL", "DIL"), New System.Data.Common.DataColumnMapping("YIL", "YIL"), New System.Data.Common.DataColumnMapping("DONEM", "DONEM"), New System.Data.Common.DataColumnMapping("OKUL", "OKUL"), New System.Data.Common.DataColumnMapping("RESIM", "RESIM")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'Nakil_gelen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(654, 564)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Nakil_gelen"
        Me.Text = "Nakil_gelen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet11 As Okul_Otomasyonu.DataSet1
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Cinsiyet As System.Windows.Forms.ComboBox
    Friend WithEvents Dönem As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Numara As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Yabancı_Dil As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Şube As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Öğrenim_Yıl As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Sınıf As System.Windows.Forms.ComboBox
    Friend WithEvents Dal As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Ad As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Soyad As System.Windows.Forms.TextBox
    Friend WithEvents Bölüm As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
End Class
