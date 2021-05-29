<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class durumu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(durumu))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.NUMARASIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DERSLERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YAZ1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YAZ2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YAZ3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOZ1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SOZ2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ORTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New Okul_Otomasyonu.DataSet1
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.NUMARASIDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RAPORLUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOPÖZÜRLÜDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ÖGLESONRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ÖZÜRSÜZDEVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMARASIDataGridViewTextBoxColumn, Me.DERSLERDataGridViewTextBoxColumn, Me.YAZ1DataGridViewTextBoxColumn, Me.YAZ2DataGridViewTextBoxColumn, Me.YAZ3DataGridViewTextBoxColumn, Me.SOZ1DataGridViewTextBoxColumn, Me.SOZ2DataGridViewTextBoxColumn, Me.ORTDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(843, 216)
        Me.DataGridView1.TabIndex = 0
        '
        'NUMARASIDataGridViewTextBoxColumn
        '
        Me.NUMARASIDataGridViewTextBoxColumn.DataPropertyName = "NUMARASI"
        Me.NUMARASIDataGridViewTextBoxColumn.HeaderText = "NUMARASI"
        Me.NUMARASIDataGridViewTextBoxColumn.Name = "NUMARASIDataGridViewTextBoxColumn"
        '
        'DERSLERDataGridViewTextBoxColumn
        '
        Me.DERSLERDataGridViewTextBoxColumn.DataPropertyName = "DERSLER"
        Me.DERSLERDataGridViewTextBoxColumn.HeaderText = "DERSLER"
        Me.DERSLERDataGridViewTextBoxColumn.Name = "DERSLERDataGridViewTextBoxColumn"
        '
        'YAZ1DataGridViewTextBoxColumn
        '
        Me.YAZ1DataGridViewTextBoxColumn.DataPropertyName = "YAZ1"
        Me.YAZ1DataGridViewTextBoxColumn.HeaderText = "YAZ1"
        Me.YAZ1DataGridViewTextBoxColumn.Name = "YAZ1DataGridViewTextBoxColumn"
        '
        'YAZ2DataGridViewTextBoxColumn
        '
        Me.YAZ2DataGridViewTextBoxColumn.DataPropertyName = "YAZ2"
        Me.YAZ2DataGridViewTextBoxColumn.HeaderText = "YAZ2"
        Me.YAZ2DataGridViewTextBoxColumn.Name = "YAZ2DataGridViewTextBoxColumn"
        '
        'YAZ3DataGridViewTextBoxColumn
        '
        Me.YAZ3DataGridViewTextBoxColumn.DataPropertyName = "YAZ3"
        Me.YAZ3DataGridViewTextBoxColumn.HeaderText = "YAZ3"
        Me.YAZ3DataGridViewTextBoxColumn.Name = "YAZ3DataGridViewTextBoxColumn"
        '
        'SOZ1DataGridViewTextBoxColumn
        '
        Me.SOZ1DataGridViewTextBoxColumn.DataPropertyName = "SOZ1"
        Me.SOZ1DataGridViewTextBoxColumn.HeaderText = "SOZ1"
        Me.SOZ1DataGridViewTextBoxColumn.Name = "SOZ1DataGridViewTextBoxColumn"
        '
        'SOZ2DataGridViewTextBoxColumn
        '
        Me.SOZ2DataGridViewTextBoxColumn.DataPropertyName = "SOZ2"
        Me.SOZ2DataGridViewTextBoxColumn.HeaderText = "SOZ2"
        Me.SOZ2DataGridViewTextBoxColumn.Name = "SOZ2DataGridViewTextBoxColumn"
        '
        'ORTDataGridViewTextBoxColumn
        '
        Me.ORTDataGridViewTextBoxColumn.DataPropertyName = "ORT"
        Me.ORTDataGridViewTextBoxColumn.HeaderText = "ORT"
        Me.ORTDataGridViewTextBoxColumn.Name = "ORTDataGridViewTextBoxColumn"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Not_Girişi"
        Me.BindingSource1.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Bisque
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(843, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ÖĞRENCİ NOT BİLGİSİ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Bisque
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(843, 48)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ÖĞRENCİ DEVAMSIZLIK BİLGİSİ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMARASIDataGridViewTextBoxColumn1, Me.AYDataGridViewTextBoxColumn, Me.RAPORLUDataGridViewTextBoxColumn, Me.TOPÖZÜRLÜDataGridViewTextBoxColumn, Me.ÖGLESONRADataGridViewTextBoxColumn, Me.ÖZÜRSÜZDEVDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.BindingSource2
        Me.DataGridView2.Location = New System.Drawing.Point(0, 312)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(843, 216)
        Me.DataGridView2.TabIndex = 2
        '
        'NUMARASIDataGridViewTextBoxColumn1
        '
        Me.NUMARASIDataGridViewTextBoxColumn1.DataPropertyName = "NUMARASI"
        Me.NUMARASIDataGridViewTextBoxColumn1.HeaderText = "NUMARASI"
        Me.NUMARASIDataGridViewTextBoxColumn1.Name = "NUMARASIDataGridViewTextBoxColumn1"
        '
        'AYDataGridViewTextBoxColumn
        '
        Me.AYDataGridViewTextBoxColumn.DataPropertyName = "AY"
        Me.AYDataGridViewTextBoxColumn.HeaderText = "AY"
        Me.AYDataGridViewTextBoxColumn.Name = "AYDataGridViewTextBoxColumn"
        '
        'RAPORLUDataGridViewTextBoxColumn
        '
        Me.RAPORLUDataGridViewTextBoxColumn.DataPropertyName = "RAPORLU"
        Me.RAPORLUDataGridViewTextBoxColumn.HeaderText = "RAPORLU"
        Me.RAPORLUDataGridViewTextBoxColumn.Name = "RAPORLUDataGridViewTextBoxColumn"
        '
        'TOPÖZÜRLÜDataGridViewTextBoxColumn
        '
        Me.TOPÖZÜRLÜDataGridViewTextBoxColumn.DataPropertyName = "TOPÖZÜRLÜ"
        Me.TOPÖZÜRLÜDataGridViewTextBoxColumn.HeaderText = "TOPÖZÜRLÜ"
        Me.TOPÖZÜRLÜDataGridViewTextBoxColumn.Name = "TOPÖZÜRLÜDataGridViewTextBoxColumn"
        '
        'ÖGLESONRADataGridViewTextBoxColumn
        '
        Me.ÖGLESONRADataGridViewTextBoxColumn.DataPropertyName = "ÖGLESONRA"
        Me.ÖGLESONRADataGridViewTextBoxColumn.HeaderText = "ÖGLESONRA"
        Me.ÖGLESONRADataGridViewTextBoxColumn.Name = "ÖGLESONRADataGridViewTextBoxColumn"
        '
        'ÖZÜRSÜZDEVDataGridViewTextBoxColumn
        '
        Me.ÖZÜRSÜZDEVDataGridViewTextBoxColumn.DataPropertyName = "ÖZÜRSÜZDEV"
        Me.ÖZÜRSÜZDEVDataGridViewTextBoxColumn.HeaderText = "ÖZÜRSÜZDEV"
        Me.ÖZÜRSÜZDEVDataGridViewTextBoxColumn.Name = "ÖZÜRSÜZDEVDataGridViewTextBoxColumn"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "Devamsızlık"
        Me.BindingSource2.DataSource = Me.DataSet11
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT      [Not_Girişi].*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          [Not_Girişi]"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""mebsa.accdb"""
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `Not_Girişi` (`NUMARASI`, `DERSLER`, `YAZ1`, `YAZ2`, `YAZ3`, `SOZ1`, " & _
            "`SOZ2`, `ORT`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("DERSLER", System.Data.OleDb.OleDbType.VarWChar, 0, "DERSLER"), New System.Data.OleDb.OleDbParameter("YAZ1", System.Data.OleDb.OleDbType.VarWChar, 0, "YAZ1"), New System.Data.OleDb.OleDbParameter("YAZ2", System.Data.OleDb.OleDbType.VarWChar, 0, "YAZ2"), New System.Data.OleDb.OleDbParameter("YAZ3", System.Data.OleDb.OleDbType.VarWChar, 0, "YAZ3"), New System.Data.OleDb.OleDbParameter("SOZ1", System.Data.OleDb.OleDbType.VarWChar, 0, "SOZ1"), New System.Data.OleDb.OleDbParameter("SOZ2", System.Data.OleDb.OleDbType.VarWChar, 0, "SOZ2"), New System.Data.OleDb.OleDbParameter("ORT", System.Data.OleDb.OleDbType.VarWChar, 0, "ORT")})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Not_Girişi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NUMARASI", "NUMARASI"), New System.Data.Common.DataColumnMapping("DERSLER", "DERSLER"), New System.Data.Common.DataColumnMapping("YAZ1", "YAZ1"), New System.Data.Common.DataColumnMapping("YAZ2", "YAZ2"), New System.Data.Common.DataColumnMapping("YAZ3", "YAZ3"), New System.Data.Common.DataColumnMapping("SOZ1", "SOZ1"), New System.Data.Common.DataColumnMapping("SOZ2", "SOZ2"), New System.Data.Common.DataColumnMapping("ORT", "ORT")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT      Devamsızlık.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM          Devamsızlık"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection2
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""mebsa.accdb"""
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO `Devamsızlık` (`NUMARASI`, `AY`, `RAPORLU`, `TOPÖZÜRLÜ`, `ÖGLESONRA`," & _
            " `ÖZÜRSÜZDEV`) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("AY", System.Data.OleDb.OleDbType.VarWChar, 0, "AY"), New System.Data.OleDb.OleDbParameter("RAPORLU", System.Data.OleDb.OleDbType.VarWChar, 0, "RAPORLU"), New System.Data.OleDb.OleDbParameter("TOPÖZÜRLÜ", System.Data.OleDb.OleDbType.VarWChar, 0, "TOPÖZÜRLÜ"), New System.Data.OleDb.OleDbParameter("ÖGLESONRA", System.Data.OleDb.OleDbType.VarWChar, 0, "ÖGLESONRA"), New System.Data.OleDb.OleDbParameter("ÖZÜRSÜZDEV", System.Data.OleDb.OleDbType.VarWChar, 0, "ÖZÜRSÜZDEV")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, "NUMARASI"), New System.Data.OleDb.OleDbParameter("AY", System.Data.OleDb.OleDbType.VarWChar, 0, "AY"), New System.Data.OleDb.OleDbParameter("RAPORLU", System.Data.OleDb.OleDbType.VarWChar, 0, "RAPORLU"), New System.Data.OleDb.OleDbParameter("TOPÖZÜRLÜ", System.Data.OleDb.OleDbType.VarWChar, 0, "TOPÖZÜRLÜ"), New System.Data.OleDb.OleDbParameter("ÖGLESONRA", System.Data.OleDb.OleDbType.VarWChar, 0, "ÖGLESONRA"), New System.Data.OleDb.OleDbParameter("ÖZÜRSÜZDEV", System.Data.OleDb.OleDbType.VarWChar, 0, "ÖZÜRSÜZDEV"), New System.Data.OleDb.OleDbParameter("Original_NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMARASI", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_AY", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_AY", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_RAPORLU", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RAPORLU", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_RAPORLU", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RAPORLU", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TOPÖZÜRLÜ", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TOPÖZÜRLÜ", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TOPÖZÜRLÜ", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TOPÖZÜRLÜ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ÖGLESONRA", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ÖGLESONRA", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ÖGLESONRA", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ÖGLESONRA", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ÖZÜRSÜZDEV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ÖZÜRSÜZDEV", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ÖZÜRSÜZDEV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ÖZÜRSÜZDEV", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_NUMARASI", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMARASI", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_AY", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "AY", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_AY", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AY", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_RAPORLU", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "RAPORLU", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_RAPORLU", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RAPORLU", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TOPÖZÜRLÜ", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TOPÖZÜRLÜ", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TOPÖZÜRLÜ", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TOPÖZÜRLÜ", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ÖGLESONRA", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ÖGLESONRA", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ÖGLESONRA", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ÖGLESONRA", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ÖZÜRSÜZDEV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ÖZÜRSÜZDEV", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ÖZÜRSÜZDEV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ÖZÜRSÜZDEV", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Devamsızlık", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NUMARASI", "NUMARASI"), New System.Data.Common.DataColumnMapping("AY", "AY"), New System.Data.Common.DataColumnMapping("RAPORLU", "RAPORLU"), New System.Data.Common.DataColumnMapping("TOPÖZÜRLÜ", "TOPÖZÜRLÜ"), New System.Data.Common.DataColumnMapping("ÖGLESONRA", "ÖGLESONRA"), New System.Data.Common.DataColumnMapping("ÖZÜRSÜZDEV", "ÖZÜRSÜZDEV")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'durumu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 535)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "durumu"
        Me.Text = "Durumu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet11 As Okul_Otomasyonu.DataSet1
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents NUMARASIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DERSLERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YAZ1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YAZ2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YAZ3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOZ1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOZ2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMARASIDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAPORLUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOPÖZÜRLÜDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ÖGLESONRADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ÖZÜRSÜZDEVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
