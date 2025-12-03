<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ApriToolStripMenuItem = New ToolStripMenuItem()
        EventiToolStripMenuItem = New ToolStripMenuItem()
        CategorieToolStripMenuItem = New ToolStripMenuItem()
        SottocategorieToolStripMenuItem = New ToolStripMenuItem()
        SHOPAZIENDEToolStripMenuItem = New ToolStripMenuItem()
        ModificaToolStripMenuItem = New ToolStripMenuItem()
        ImportaMovimentiDaExcelToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        VisualizzaToolStripMenuItem = New ToolStripMenuItem()
        ImpostazioniToolStripMenuItem = New ToolStripMenuItem()
        ConnessioneSQLToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        btnResetFiltri = New Guna.UI2.WinForms.Guna2Button()
        btnApplicaFiltro = New Guna.UI2.WinForms.Guna2Button()
        txtFiltroDescrizione = New Guna.UI2.WinForms.Guna2TextBox()
        dtFiltroData = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Label3 = New Label()
        Label1 = New Label()
        cmbCategoria = New Guna.UI2.WinForms.Guna2ComboBox()
        Label2 = New Label()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        NotifyIcon1 = New NotifyIcon(components)
        Panel3 = New Panel()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Font = New Font("Segoe UI", 14.0F)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ModificaToolStripMenuItem, VisualizzaToolStripMenuItem, ImpostazioniToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ApriToolStripMenuItem, EventiToolStripMenuItem, CategorieToolStripMenuItem, SottocategorieToolStripMenuItem, SHOPAZIENDEToolStripMenuItem})
        FileToolStripMenuItem.ForeColor = Color.WhiteSmoke
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(126, 29)
        FileToolStripMenuItem.Text = "Anagrafiche"
        ' 
        ' ApriToolStripMenuItem
        ' 
        ApriToolStripMenuItem.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        ApriToolStripMenuItem.ForeColor = Color.White
        ApriToolStripMenuItem.Name = "ApriToolStripMenuItem"
        ApriToolStripMenuItem.Size = New Size(215, 30)
        ApriToolStripMenuItem.Text = "Utilizzatori"
        ' 
        ' EventiToolStripMenuItem
        ' 
        EventiToolStripMenuItem.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        EventiToolStripMenuItem.ForeColor = Color.White
        EventiToolStripMenuItem.Name = "EventiToolStripMenuItem"
        EventiToolStripMenuItem.Size = New Size(215, 30)
        EventiToolStripMenuItem.Text = "Eventi"
        ' 
        ' CategorieToolStripMenuItem
        ' 
        CategorieToolStripMenuItem.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        CategorieToolStripMenuItem.ForeColor = Color.WhiteSmoke
        CategorieToolStripMenuItem.Name = "CategorieToolStripMenuItem"
        CategorieToolStripMenuItem.Size = New Size(215, 30)
        CategorieToolStripMenuItem.Text = "Categorie"
        ' 
        ' SottocategorieToolStripMenuItem
        ' 
        SottocategorieToolStripMenuItem.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        SottocategorieToolStripMenuItem.ForeColor = Color.WhiteSmoke
        SottocategorieToolStripMenuItem.Name = "SottocategorieToolStripMenuItem"
        SottocategorieToolStripMenuItem.Size = New Size(215, 30)
        SottocategorieToolStripMenuItem.Text = "Sottocategorie"
        ' 
        ' SHOPAZIENDEToolStripMenuItem
        ' 
        SHOPAZIENDEToolStripMenuItem.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        SHOPAZIENDEToolStripMenuItem.ForeColor = Color.WhiteSmoke
        SHOPAZIENDEToolStripMenuItem.Name = "SHOPAZIENDEToolStripMenuItem"
        SHOPAZIENDEToolStripMenuItem.Size = New Size(215, 30)
        SHOPAZIENDEToolStripMenuItem.Text = "SHOP/AZIENDE"
        ' 
        ' ModificaToolStripMenuItem
        ' 
        ModificaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ImportaMovimentiDaExcelToolStripMenuItem, ToolStripMenuItem1})
        ModificaToolStripMenuItem.ForeColor = Color.WhiteSmoke
        ModificaToolStripMenuItem.Name = "ModificaToolStripMenuItem"
        ModificaToolStripMenuItem.Size = New Size(98, 29)
        ModificaToolStripMenuItem.Text = "Modifica"
        ' 
        ' ImportaMovimentiDaExcelToolStripMenuItem
        ' 
        ImportaMovimentiDaExcelToolStripMenuItem.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        ImportaMovimentiDaExcelToolStripMenuItem.ForeColor = Color.White
        ImportaMovimentiDaExcelToolStripMenuItem.Name = "ImportaMovimentiDaExcelToolStripMenuItem"
        ImportaMovimentiDaExcelToolStripMenuItem.Size = New Size(318, 30)
        ImportaMovimentiDaExcelToolStripMenuItem.Text = "Importa movimenti da Excel"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        ToolStripMenuItem1.ForeColor = Color.White
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(318, 30)
        ToolStripMenuItem1.Text = "Esporta Dati"
        ' 
        ' VisualizzaToolStripMenuItem
        ' 
        VisualizzaToolStripMenuItem.ForeColor = Color.White
        VisualizzaToolStripMenuItem.Name = "VisualizzaToolStripMenuItem"
        VisualizzaToolStripMenuItem.Size = New Size(84, 29)
        VisualizzaToolStripMenuItem.Text = "Moduli"
        ' 
        ' ImpostazioniToolStripMenuItem
        ' 
        ImpostazioniToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConnessioneSQLToolStripMenuItem})
        ImpostazioniToolStripMenuItem.ForeColor = Color.White
        ImpostazioniToolStripMenuItem.Name = "ImpostazioniToolStripMenuItem"
        ImpostazioniToolStripMenuItem.Size = New Size(132, 29)
        ImpostazioniToolStripMenuItem.Text = "Impostazioni"
        ' 
        ' ConnessioneSQLToolStripMenuItem
        ' 
        ConnessioneSQLToolStripMenuItem.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        ConnessioneSQLToolStripMenuItem.ForeColor = Color.WhiteSmoke
        ConnessioneSQLToolStripMenuItem.Name = "ConnessioneSQLToolStripMenuItem"
        ConnessioneSQLToolStripMenuItem.Size = New Size(230, 30)
        ConnessioneSQLToolStripMenuItem.Text = "Connessione SQL"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnResetFiltri)
        Panel1.Controls.Add(btnApplicaFiltro)
        Panel1.Controls.Add(txtFiltroDescrizione)
        Panel1.Controls.Add(dtFiltroData)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(cmbCategoria)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("OpenSymbol", 11.0F)
        Panel1.ForeColor = Color.WhiteSmoke
        Panel1.Location = New Point(0, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 478)
        Panel1.TabIndex = 3
        ' 
        ' btnResetFiltri
        ' 
        btnResetFiltri.BorderThickness = 2
        btnResetFiltri.CustomizableEdges = CustomizableEdges1
        btnResetFiltri.DisabledState.BorderColor = Color.DarkGray
        btnResetFiltri.DisabledState.CustomBorderColor = Color.DarkGray
        btnResetFiltri.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnResetFiltri.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnResetFiltri.Dock = DockStyle.Bottom
        btnResetFiltri.Font = New Font("Segoe UI", 9.0F)
        btnResetFiltri.ForeColor = Color.White
        btnResetFiltri.Location = New Point(0, 388)
        btnResetFiltri.Name = "btnResetFiltri"
        btnResetFiltri.Padding = New Padding(5)
        btnResetFiltri.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnResetFiltri.Size = New Size(200, 45)
        btnResetFiltri.TabIndex = 13
        btnResetFiltri.Text = "Reset Filtro"
        ' 
        ' btnApplicaFiltro
        ' 
        btnApplicaFiltro.BorderThickness = 2
        btnApplicaFiltro.CustomizableEdges = CustomizableEdges3
        btnApplicaFiltro.DisabledState.BorderColor = Color.DarkGray
        btnApplicaFiltro.DisabledState.CustomBorderColor = Color.DarkGray
        btnApplicaFiltro.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnApplicaFiltro.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnApplicaFiltro.Dock = DockStyle.Bottom
        btnApplicaFiltro.Font = New Font("Segoe UI", 9.0F)
        btnApplicaFiltro.ForeColor = Color.White
        btnApplicaFiltro.Location = New Point(0, 433)
        btnApplicaFiltro.Name = "btnApplicaFiltro"
        btnApplicaFiltro.Padding = New Padding(5)
        btnApplicaFiltro.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnApplicaFiltro.Size = New Size(200, 45)
        btnApplicaFiltro.TabIndex = 12
        btnApplicaFiltro.Text = "Applica Filtro"
        ' 
        ' txtFiltroDescrizione
        ' 
        txtFiltroDescrizione.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFiltroDescrizione.CustomizableEdges = CustomizableEdges5
        txtFiltroDescrizione.DefaultText = ""
        txtFiltroDescrizione.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtFiltroDescrizione.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtFiltroDescrizione.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFiltroDescrizione.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFiltroDescrizione.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtFiltroDescrizione.Font = New Font("Segoe UI", 9.0F)
        txtFiltroDescrizione.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtFiltroDescrizione.Location = New Point(3, 186)
        txtFiltroDescrizione.Name = "txtFiltroDescrizione"
        txtFiltroDescrizione.PlaceholderText = ""
        txtFiltroDescrizione.SelectedText = ""
        txtFiltroDescrizione.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtFiltroDescrizione.Size = New Size(191, 36)
        txtFiltroDescrizione.TabIndex = 11
        ' 
        ' dtFiltroData
        ' 
        dtFiltroData.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtFiltroData.BorderColor = Color.White
        dtFiltroData.BorderRadius = 10
        dtFiltroData.BorderStyle = Drawing2D.DashStyle.Dash
        dtFiltroData.Checked = True
        dtFiltroData.CustomizableEdges = CustomizableEdges7
        dtFiltroData.FillColor = Color.CornflowerBlue
        dtFiltroData.Font = New Font("Segoe UI", 9.0F)
        dtFiltroData.ForeColor = Color.White
        dtFiltroData.Format = DateTimePickerFormat.Long
        dtFiltroData.Location = New Point(3, 37)
        dtFiltroData.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtFiltroData.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtFiltroData.Name = "dtFiltroData"
        dtFiltroData.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        dtFiltroData.Size = New Size(191, 43)
        dtFiltroData.TabIndex = 8
        dtFiltroData.Value = New Date(2025, 12, 3, 0, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("OpenSymbol", 9.75F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 16)
        Label3.TabIndex = 4
        Label3.Text = "Categoria"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("OpenSymbol", 9.75F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 16)
        Label1.TabIndex = 0
        Label1.Text = "Data"
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbCategoria.BackColor = Color.Transparent
        cmbCategoria.CustomizableEdges = CustomizableEdges9
        cmbCategoria.DrawMode = DrawMode.OwnerDrawFixed
        cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategoria.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbCategoria.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbCategoria.Font = New Font("Segoe UI", 10.0F)
        cmbCategoria.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbCategoria.ItemHeight = 30
        cmbCategoria.Location = New Point(3, 114)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        cmbCategoria.Size = New Size(191, 36)
        cmbCategoria.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("OpenSymbol", 9.75F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 16)
        Label2.TabIndex = 2
        Label2.Text = "Descrizione"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(DataGridView1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(200, 33)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 478)
        Panel2.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle1.ForeColor = SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle3.ForeColor = SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        DataGridViewCellStyle4.Font = New Font("OpenSymbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.Info
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        DataGridView1.RowTemplate.DefaultCellStyle.Font = New Font("OpenSymbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.Info
        DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(600, 478)
        DataGridView1.TabIndex = 0
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(StatusStrip1)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 511)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(800, 25)
        Panel3.TabIndex = 5
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = SystemColors.WindowFrame
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus, ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 3)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.RenderMode = ToolStripRenderMode.Professional
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 0
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 17)
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(133, 17)
        ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        ClientSize = New Size(800, 536)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Nome Programma?"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportaMovimentiDaExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VisualizzaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategorieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SottocategorieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SHOPAZIENDEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpostazioniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnessioneSQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents cmbCategoria As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtFiltroData As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFiltroDescrizione As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnApplicaFiltro As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnResetFiltri As Guna.UI2.WinForms.Guna2Button

End Class
