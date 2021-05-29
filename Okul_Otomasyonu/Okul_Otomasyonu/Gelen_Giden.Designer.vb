<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gelen_Giden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gelen_Giden))
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection
        Me.NUMARASIDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GELOKULDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GELİŞYERİŞEHIRDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GELİŞYERİKOYDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.KAYITTARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GİRİŞPUANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BURORANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New Okul_Otomasyonu.DataSet1
        Me.NUMARASIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GİDENOKULDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GÖNYERİSEHIRDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GÖNYERİKOYDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GÖNTARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BURSORANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Bisque
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(743, 48)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NAKİL GELEN ÖĞRENCİLER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMARASIDataGridViewTextBoxColumn1, Me.GELOKULDataGridViewTextBoxColumn, Me.GELİŞYERİŞEHIRDataGridViewCheckBoxColumn, Me.GELİŞYERİKOYDataGridViewCheckBoxColumn, Me.KAYITTARDataGridViewTextBoxColumn, Me.GİRİŞPUANDataGridViewTextBoxColumn, Me.BURORANDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.BindingSource2
        Me.DataGridView2.Location = New System.Drawing.Point(1, 306)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(743, 216)
        Me.DataGridView2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Bisque
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(743, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NAKİL GİDEN ÖĞRENCİLER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMARASIDataGridViewTextBoxColumn, Me.GİDENOKULDataGridViewTextBoxColumn, Me.GÖNYERİSEHIRDataGridViewCheckBoxColumn, Me.GÖNYERİKOYDataGridViewCheckBoxColumn, Me.GÖNTARDataGridViewTextBoxColumn, Me.BURSORANDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(1, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 216)
        Me.DataGridView1.TabIndex = 4
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT      Nakil_Giden.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          Nakil_Giden"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `Nakil_Giden` (`NUMARASI`, `GİDEN_OKUL`, `GÖN_YERİ_SEHIR`, `GÖN_YERİ_" & _
            "KOY`, `GÖN_TAR`, `BURS_ORAN`) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("GİDEN_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, "GİDEN_OKUL"), New System.Data.OleDb.OleDbParameter("GÖN_YERİ_SEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, "GÖN_YERİ_SEHIR"), New System.Data.OleDb.OleDbParameter("GÖN_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, "GÖN_YERİ_KOY"), New System.Data.OleDb.OleDbParameter("GÖN_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, "GÖN_TAR"), New System.Data.OleDb.OleDbParameter("BURS_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, "BURS_ORAN")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("GİDEN_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, "GİDEN_OKUL"), New System.Data.OleDb.OleDbParameter("GÖN_YERİ_SEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, "GÖN_YERİ_SEHIR"), New System.Data.OleDb.OleDbParameter("GÖN_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, "GÖN_YERİ_KOY"), New System.Data.OleDb.OleDbParameter("GÖN_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, "GÖN_TAR"), New System.Data.OleDb.OleDbParameter("BURS_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, "BURS_ORAN"), New System.Data.OleDb.OleDbParameter("Original_NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMARASI", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GİDEN_OKUL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GİDEN_OKUL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GİDEN_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GİDEN_OKUL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GÖN_YERİ_SEHIR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GÖN_YERİ_SEHIR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GÖN_YERİ_SEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GÖN_YERİ_SEHIR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GÖN_YERİ_KOY", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GÖN_YERİ_KOY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GÖN_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GÖN_YERİ_KOY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GÖN_TAR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GÖN_TAR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GÖN_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GÖN_TAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_BURS_ORAN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BURS_ORAN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_BURS_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BURS_ORAN", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMARASI", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GİDEN_OKUL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GİDEN_OKUL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GİDEN_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GİDEN_OKUL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GÖN_YERİ_SEHIR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GÖN_YERİ_SEHIR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GÖN_YERİ_SEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GÖN_YERİ_SEHIR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GÖN_YERİ_KOY", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GÖN_YERİ_KOY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GÖN_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GÖN_YERİ_KOY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GÖN_TAR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GÖN_TAR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GÖN_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GÖN_TAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_BURS_ORAN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BURS_ORAN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_BURS_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BURS_ORAN", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Nakil_Giden", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NUMARASI", "NUMARASI"), New System.Data.Common.DataColumnMapping("GİDEN_OKUL", "GİDEN_OKUL"), New System.Data.Common.DataColumnMapping("GÖN_YERİ_SEHIR", "GÖN_YERİ_SEHIR"), New System.Data.Common.DataColumnMapping("GÖN_YERİ_KOY", "GÖN_YERİ_KOY"), New System.Data.Common.DataColumnMapping("GÖN_TAR", "GÖN_TAR"), New System.Data.Common.DataColumnMapping("BURS_ORAN", "BURS_ORAN")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""mebsa.accdb"""
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT      Nakil_Gelen.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          Nakil_Gelen"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection2
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO `Nakil_Gelen` (`NUMARASI`, `GEL_OKUL`, `GELİŞ_YERİ_ŞEHIR`, `GELİŞ_YER" & _
            "İ_KOY`, `KAYIT_TAR`, `GİRİŞ_PUAN`, `BUR_ORAN`) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("GEL_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, "GEL_OKUL"), New System.Data.OleDb.OleDbParameter("GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, "GELİŞ_YERİ_ŞEHIR"), New System.Data.OleDb.OleDbParameter("GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, "GELİŞ_YERİ_KOY"), New System.Data.OleDb.OleDbParameter("KAYIT_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, "KAYIT_TAR"), New System.Data.OleDb.OleDbParameter("GİRİŞ_PUAN", System.Data.OleDb.OleDbType.VarWChar, 0, "GİRİŞ_PUAN"), New System.Data.OleDb.OleDbParameter("BUR_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, "BUR_ORAN")})
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = resources.GetString("OleDbUpdateCommand2.CommandText")
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("GEL_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, "GEL_OKUL"), New System.Data.OleDb.OleDbParameter("GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, "GELİŞ_YERİ_ŞEHIR"), New System.Data.OleDb.OleDbParameter("GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, "GELİŞ_YERİ_KOY"), New System.Data.OleDb.OleDbParameter("KAYIT_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, "KAYIT_TAR"), New System.Data.OleDb.OleDbParameter("GİRİŞ_PUAN", System.Data.OleDb.OleDbType.VarWChar, 0, "GİRİŞ_PUAN"), New System.Data.OleDb.OleDbParameter("BUR_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, "BUR_ORAN"), New System.Data.OleDb.OleDbParameter("Original_NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMARASI", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GEL_OKUL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GEL_OKUL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GEL_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GEL_OKUL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_ŞEHIR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_ŞEHIR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_KOY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_KOY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_KAYIT_TAR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "KAYIT_TAR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_KAYIT_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KAYIT_TAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GİRİŞ_PUAN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GİRİŞ_PUAN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GİRİŞ_PUAN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GİRİŞ_PUAN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_BUR_ORAN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BUR_ORAN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_BUR_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BUR_ORAN", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = resources.GetString("OleDbDeleteCommand2.CommandText")
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMARASI", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GEL_OKUL", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GEL_OKUL", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GEL_OKUL", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GEL_OKUL", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_ŞEHIR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GELİŞ_YERİ_ŞEHIR", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_ŞEHIR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_KOY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GELİŞ_YERİ_KOY", System.Data.OleDb.OleDbType.[Boolean], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GELİŞ_YERİ_KOY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_KAYIT_TAR", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "KAYIT_TAR", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_KAYIT_TAR", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KAYIT_TAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GİRİŞ_PUAN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GİRİŞ_PUAN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GİRİŞ_PUAN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GİRİŞ_PUAN", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_BUR_ORAN", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BUR_ORAN", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_BUR_ORAN", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BUR_ORAN", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Nakil_Gelen", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NUMARASI", "NUMARASI"), New System.Data.Common.DataColumnMapping("GEL_OKUL", "GEL_OKUL"), New System.Data.Common.DataColumnMapping("GELİŞ_YERİ_ŞEHIR", "GELİŞ_YERİ_ŞEHIR"), New System.Data.Common.DataColumnMapping("GELİŞ_YERİ_KOY", "GELİŞ_YERİ_KOY"), New System.Data.Common.DataColumnMapping("KAYIT_TAR", "KAYIT_TAR"), New System.Data.Common.DataColumnMapping("GİRİŞ_PUAN", "GİRİŞ_PUAN"), New System.Data.Common.DataColumnMapping("BUR_ORAN", "BUR_ORAN")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""mebsa.accdb"""
        '
        'NUMARASIDataGridViewTextBoxColumn1
        '
        Me.NUMARASIDataGridViewTextBoxColumn1.DataPropertyName = "NUMARASI"
        Me.NUMARASIDataGridViewTextBoxColumn1.HeaderText = "NUMARASI"
        Me.NUMARASIDataGridViewTextBoxColumn1.Name = "NUMARASIDataGridViewTextBoxColumn1"
        '
        'GELOKULDataGridViewTextBoxColumn
        '
        Me.GELOKULDataGridViewTextBoxColumn.DataPropertyName = "GEL_OKUL"
        Me.GELOKULDataGridViewTextBoxColumn.HeaderText = "GEL_OKUL"
        Me.GELOKULDataGridViewTextBoxColumn.Name = "GELOKULDataGridViewTextBoxColumn"
        '
        'GELİŞYERİŞEHIRDataGridViewCheckBoxColumn
        '
        Me.GELİŞYERİŞEHIRDataGridViewCheckBoxColumn.DataPropertyName = "GELİŞ_YERİ_ŞEHIR"
        Me.GELİŞYERİŞEHIRDataGridViewCheckBoxColumn.HeaderText = "GELİŞ_YERİ_ŞEHIR"
        Me.GELİŞYERİŞEHIRDataGridViewCheckBoxColumn.Name = "GELİŞYERİŞEHIRDataGridViewCheckBoxColumn"
        '
        'GELİŞYERİKOYDataGridViewCheckBoxColumn
        '
        Me.GELİŞYERİKOYDataGridViewCheckBoxColumn.DataPropertyName = "GELİŞ_YERİ_KOY"
        Me.GELİŞYERİKOYDataGridViewCheckBoxColumn.HeaderText = "GELİŞ_YERİ_KOY"
        Me.GELİŞYERİKOYDataGridViewCheckBoxColumn.Name = "GELİŞYERİKOYDataGridViewCheckBoxColumn"
        '
        'KAYITTARDataGridViewTextBoxColumn
        '
        Me.KAYITTARDataGridViewTextBoxColumn.DataPropertyName = "KAYIT_TAR"
        Me.KAYITTARDataGridViewTextBoxColumn.HeaderText = "KAYIT_TAR"
        Me.KAYITTARDataGridViewTextBoxColumn.Name = "KAYITTARDataGridViewTextBoxColumn"
        '
        'GİRİŞPUANDataGridViewTextBoxColumn
        '
        Me.GİRİŞPUANDataGridViewTextBoxColumn.DataPropertyName = "GİRİŞ_PUAN"
        Me.GİRİŞPUANDataGridViewTextBoxColumn.HeaderText = "GİRİŞ_PUAN"
        Me.GİRİŞPUANDataGridViewTextBoxColumn.Name = "GİRİŞPUANDataGridViewTextBoxColumn"
        '
        'BURORANDataGridViewTextBoxColumn
        '
        Me.BURORANDataGridViewTextBoxColumn.DataPropertyName = "BUR_ORAN"
        Me.BURORANDataGridViewTextBoxColumn.HeaderText = "BUR_ORAN"
        Me.BURORANDataGridViewTextBoxColumn.Name = "BURORANDataGridViewTextBoxColumn"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "Nakil_Gelen"
        Me.BindingSource2.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NUMARASIDataGridViewTextBoxColumn
        '
        Me.NUMARASIDataGridViewTextBoxColumn.DataPropertyName = "NUMARASI"
        Me.NUMARASIDataGridViewTextBoxColumn.HeaderText = "NUMARASI"
        Me.NUMARASIDataGridViewTextBoxColumn.Name = "NUMARASIDataGridViewTextBoxColumn"
        '
        'GİDENOKULDataGridViewTextBoxColumn
        '
        Me.GİDENOKULDataGridViewTextBoxColumn.DataPropertyName = "GİDEN_OKUL"
        Me.GİDENOKULDataGridViewTextBoxColumn.HeaderText = "GİDEN_OKUL"
        Me.GİDENOKULDataGridViewTextBoxColumn.Name = "GİDENOKULDataGridViewTextBoxColumn"
        '
        'GÖNYERİSEHIRDataGridViewCheckBoxColumn
        '
        Me.GÖNYERİSEHIRDataGridViewCheckBoxColumn.DataPropertyName = "GÖN_YERİ_SEHIR"
        Me.GÖNYERİSEHIRDataGridViewCheckBoxColumn.HeaderText = "GÖN_YERİ_SEHIR"
        Me.GÖNYERİSEHIRDataGridViewCheckBoxColumn.Name = "GÖNYERİSEHIRDataGridViewCheckBoxColumn"
        '
        'GÖNYERİKOYDataGridViewCheckBoxColumn
        '
        Me.GÖNYERİKOYDataGridViewCheckBoxColumn.DataPropertyName = "GÖN_YERİ_KOY"
        Me.GÖNYERİKOYDataGridViewCheckBoxColumn.HeaderText = "GÖN_YERİ_KOY"
        Me.GÖNYERİKOYDataGridViewCheckBoxColumn.Name = "GÖNYERİKOYDataGridViewCheckBoxColumn"
        '
        'GÖNTARDataGridViewTextBoxColumn
        '
        Me.GÖNTARDataGridViewTextBoxColumn.DataPropertyName = "GÖN_TAR"
        Me.GÖNTARDataGridViewTextBoxColumn.HeaderText = "GÖN_TAR"
        Me.GÖNTARDataGridViewTextBoxColumn.Name = "GÖNTARDataGridViewTextBoxColumn"
        '
        'BURSORANDataGridViewTextBoxColumn
        '
        Me.BURSORANDataGridViewTextBoxColumn.DataPropertyName = "BURS_ORAN"
        Me.BURSORANDataGridViewTextBoxColumn.HeaderText = "BURS_ORAN"
        Me.BURSORANDataGridViewTextBoxColumn.Name = "BURSORANDataGridViewTextBoxColumn"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Nakil_Giden"
        Me.BindingSource1.DataSource = Me.DataSet11
        '
        'Gelen_Giden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 528)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Gelen_Giden"
        Me.Text = "Gelen_Giden"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet11 As Okul_Otomasyonu.DataSet1
    Friend WithEvents NUMARASIDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GELOKULDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GELİŞYERİŞEHIRDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GELİŞYERİKOYDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents KAYITTARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GİRİŞPUANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BURORANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMARASIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GİDENOKULDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GÖNYERİSEHIRDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GÖNYERİKOYDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GÖNTARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BURSORANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
