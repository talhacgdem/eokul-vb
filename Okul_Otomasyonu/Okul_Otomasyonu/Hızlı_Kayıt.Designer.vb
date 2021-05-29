<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hızlı_Kayıt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hızlı_Kayıt))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Cinsiyet = New System.Windows.Forms.ComboBox()
        Me.Okul = New System.Windows.Forms.TextBox()
        Me.Dönem = New System.Windows.Forms.TextBox()
        Me.Numara = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Yabancı_Dil = New System.Windows.Forms.ComboBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Şube = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Öğrenim_Yıl = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sınıf = New System.Windows.Forms.ComboBox()
        Me.Dal = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ad = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Soyad = New System.Windows.Forms.TextBox()
        Me.Bölüm = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Yol = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(1099, 30)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 69)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "YENİ KAYIT"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(1099, 167)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 69)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "DEĞİŞTİR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Cinsiyet
        '
        Me.Cinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Cinsiyet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Cinsiyet.FormattingEnabled = True
        Me.Cinsiyet.Items.AddRange(New Object() {"ERKEK", "KIZ"})
        Me.Cinsiyet.Location = New System.Drawing.Point(587, 79)
        Me.Cinsiyet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cinsiyet.Name = "Cinsiyet"
        Me.Cinsiyet.Size = New System.Drawing.Size(244, 28)
        Me.Cinsiyet.TabIndex = 4
        '
        'Okul
        '
        Me.Okul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Okul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Okul.Location = New System.Drawing.Point(587, 282)
        Me.Okul.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Okul.Multiline = True
        Me.Okul.Name = "Okul"
        Me.Okul.Size = New System.Drawing.Size(244, 29)
        Me.Okul.TabIndex = 12
        '
        'Dönem
        '
        Me.Dönem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Dönem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Dönem.Location = New System.Drawing.Point(267, 282)
        Me.Dönem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dönem.Multiline = True
        Me.Dönem.Name = "Dönem"
        Me.Dönem.Size = New System.Drawing.Size(148, 29)
        Me.Dönem.TabIndex = 11
        '
        'Numara
        '
        Me.Numara.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Numara.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Numara.Location = New System.Drawing.Point(171, 30)
        Me.Numara.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Numara.Multiline = True
        Me.Numara.Name = "Numara"
        Me.Numara.Size = New System.Drawing.Size(244, 29)
        Me.Numara.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.Color.Bisque
        Me.TextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox22.Location = New System.Drawing.Point(427, 282)
        Me.TextBox22.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox22.Multiline = True
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(148, 29)
        Me.TextBox22.TabIndex = 26
        Me.TextBox22.TabStop = False
        Me.TextBox22.Text = "Geldiği Okul"
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.Bisque
        Me.TextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(11, 282)
        Me.TextBox20.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox20.Multiline = True
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(244, 29)
        Me.TextBox20.TabIndex = 24
        Me.TextBox20.TabStop = False
        Me.TextBox20.Text = "Kayıtlı Olduğu Dönem"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(1099, 236)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 69)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "KAYDET"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Cinsiyet)
        Me.GroupBox1.Controls.Add(Me.Okul)
        Me.GroupBox1.Controls.Add(Me.TextBox22)
        Me.GroupBox1.Controls.Add(Me.Dönem)
        Me.GroupBox1.Controls.Add(Me.TextBox20)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Numara)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Yabancı_Dil)
        Me.GroupBox1.Controls.Add(Me.TextBox18)
        Me.GroupBox1.Controls.Add(Me.Şube)
        Me.GroupBox1.Controls.Add(Me.TextBox19)
        Me.GroupBox1.Controls.Add(Me.Öğrenim_Yıl)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Sınıf)
        Me.GroupBox1.Controls.Add(Me.Dal)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Ad)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Controls.Add(Me.Soyad)
        Me.GroupBox1.Controls.Add(Me.Bölüm)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 85)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1257, 374)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ÖGRENCİ BİLGİLERİ GİRİŞİ"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Bisque
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(11, 30)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 29)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Numarası"
        '
        'Yabancı_Dil
        '
        Me.Yabancı_Dil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Yabancı_Dil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Yabancı_Dil.FormattingEnabled = True
        Me.Yabancı_Dil.Items.AddRange(New Object() {"İngilizce", "Almanca", "Fransızca", "Diğerleri"})
        Me.Yabancı_Dil.Location = New System.Drawing.Point(171, 226)
        Me.Yabancı_Dil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Yabancı_Dil.Name = "Yabancı_Dil"
        Me.Yabancı_Dil.Size = New System.Drawing.Size(244, 28)
        Me.Yabancı_Dil.TabIndex = 9
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.Color.Bisque
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(11, 226)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox18.Multiline = True
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(148, 29)
        Me.TextBox18.TabIndex = 18
        Me.TextBox18.TabStop = False
        Me.TextBox18.Text = "Yabancı Dili"
        '
        'Şube
        '
        Me.Şube.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Şube.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Şube.Location = New System.Drawing.Point(587, 128)
        Me.Şube.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Şube.Multiline = True
        Me.Şube.Name = "Şube"
        Me.Şube.Size = New System.Drawing.Size(244, 29)
        Me.Şube.TabIndex = 6
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.Color.Bisque
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(427, 128)
        Me.TextBox19.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox19.Multiline = True
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(148, 29)
        Me.TextBox19.TabIndex = 20
        Me.TextBox19.TabStop = False
        Me.TextBox19.Text = "Şubesi"
        '
        'Öğrenim_Yıl
        '
        Me.Öğrenim_Yıl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Öğrenim_Yıl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Öğrenim_Yıl.Location = New System.Drawing.Point(587, 226)
        Me.Öğrenim_Yıl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Öğrenim_Yıl.Multiline = True
        Me.Öğrenim_Yıl.Name = "Öğrenim_Yıl"
        Me.Öğrenim_Yıl.Size = New System.Drawing.Size(244, 29)
        Me.Öğrenim_Yıl.TabIndex = 10
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.Bisque
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(427, 226)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(148, 29)
        Me.TextBox14.TabIndex = 12
        Me.TextBox14.TabStop = False
        Me.TextBox14.Text = "Öğrenim(Yılı)"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(1099, 98)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 69)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "RESİM YÜKLE"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sınıf
        '
        Me.Sınıf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Sınıf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Sınıf.FormattingEnabled = True
        Me.Sınıf.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.Sınıf.Location = New System.Drawing.Point(171, 128)
        Me.Sınıf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sınıf.Name = "Sınıf"
        Me.Sınıf.Size = New System.Drawing.Size(244, 28)
        Me.Sınıf.TabIndex = 5
        '
        'Dal
        '
        Me.Dal.Enabled = False
        Me.Dal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Dal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Dal.Location = New System.Drawing.Point(587, 177)
        Me.Dal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dal.Multiline = True
        Me.Dal.Name = "Dal"
        Me.Dal.Size = New System.Drawing.Size(244, 29)
        Me.Dal.TabIndex = 8
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Bisque
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(427, 177)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(148, 29)
        Me.TextBox12.TabIndex = 10
        Me.TextBox12.TabStop = False
        Me.TextBox12.Text = "Dalı"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(843, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 285)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Ad
        '
        Me.Ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Ad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Ad.Location = New System.Drawing.Point(587, 30)
        Me.Ad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ad.Multiline = True
        Me.Ad.Name = "Ad"
        Me.Ad.Size = New System.Drawing.Size(244, 29)
        Me.Ad.TabIndex = 2
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Bisque
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(427, 79)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(148, 29)
        Me.TextBox10.TabIndex = 8
        Me.TextBox10.TabStop = False
        Me.TextBox10.Text = "Cinsiyeti"
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.Bisque
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(427, 30)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(148, 29)
        Me.TextBox16.TabIndex = 14
        Me.TextBox16.TabStop = False
        Me.TextBox16.Text = "Adı"
        '
        'Soyad
        '
        Me.Soyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Soyad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Soyad.Location = New System.Drawing.Point(171, 79)
        Me.Soyad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Soyad.Multiline = True
        Me.Soyad.Name = "Soyad"
        Me.Soyad.Size = New System.Drawing.Size(244, 29)
        Me.Soyad.TabIndex = 3
        '
        'Bölüm
        '
        Me.Bölüm.Enabled = False
        Me.Bölüm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Bölüm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Bölüm.Location = New System.Drawing.Point(171, 177)
        Me.Bölüm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Bölüm.Multiline = True
        Me.Bölüm.Name = "Bölüm"
        Me.Bölüm.Size = New System.Drawing.Size(244, 29)
        Me.Bölüm.TabIndex = 7
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Bisque
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(11, 177)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(148, 29)
        Me.TextBox8.TabIndex = 6
        Me.TextBox8.TabStop = False
        Me.TextBox8.Text = "Bölümü"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Bisque
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(11, 79)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(148, 29)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "Soyadı"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Bisque
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(11, 128)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(148, 29)
        Me.TextBox6.TabIndex = 4
        Me.TextBox6.TabStop = False
        Me.TextBox6.Text = "Sınıfı"
        '
        'Yol
        '
        Me.Yol.Location = New System.Drawing.Point(845, 9)
        Me.Yol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Yol.Name = "Yol"
        Me.Yol.Size = New System.Drawing.Size(399, 22)
        Me.Yol.TabIndex = 30
        Me.Yol.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(845, 38)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(399, 22)
        Me.TextBox2.TabIndex = 31
        Me.TextBox2.Visible = False
        '
        'Hızlı_Kayıt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1268, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Yol)
        Me.Controls.Add(Me.TextBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Hızlı_Kayıt"
        Me.Text = "Hızlı_Kayıt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Cinsiyet As System.Windows.Forms.ComboBox
    Friend WithEvents Okul As System.Windows.Forms.TextBox
    Friend WithEvents Dönem As System.Windows.Forms.TextBox
    Friend WithEvents Numara As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Yabancı_Dil As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Şube As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Öğrenim_Yıl As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Sınıf As System.Windows.Forms.ComboBox
    Friend WithEvents Dal As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Ad As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Soyad As System.Windows.Forms.TextBox
    Friend WithEvents Bölüm As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Yol As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents NUMARASIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SINFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUBEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOLUMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DONEMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OKULDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESIMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
