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
        btnApplicaFiltro = New Button()
        btnResetFiltri = New Button()
        cmbCategoria = New ComboBox()
        Label3 = New Label()
        txtFiltroDescrizione = New TextBox()
        Label2 = New Label()
        dtFiltroData = New DateTimePicker()
        Label1 = New Label()
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
        MenuStrip1.BackColor = SystemColors.ControlLight
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ModificaToolStripMenuItem, VisualizzaToolStripMenuItem, ImpostazioniToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 25)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ApriToolStripMenuItem, EventiToolStripMenuItem, CategorieToolStripMenuItem, SottocategorieToolStripMenuItem, SHOPAZIENDEToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(89, 21)
        FileToolStripMenuItem.Text = "Anagrafiche"
        ' 
        ' ApriToolStripMenuItem
        ' 
        ApriToolStripMenuItem.Name = "ApriToolStripMenuItem"
        ApriToolStripMenuItem.Size = New Size(165, 22)
        ApriToolStripMenuItem.Text = "Utilizzatori"
        ' 
        ' EventiToolStripMenuItem
        ' 
        EventiToolStripMenuItem.Name = "EventiToolStripMenuItem"
        EventiToolStripMenuItem.Size = New Size(165, 22)
        EventiToolStripMenuItem.Text = "Eventi"
        ' 
        ' CategorieToolStripMenuItem
        ' 
        CategorieToolStripMenuItem.Name = "CategorieToolStripMenuItem"
        CategorieToolStripMenuItem.Size = New Size(165, 22)
        CategorieToolStripMenuItem.Text = "Categorie"
        ' 
        ' SottocategorieToolStripMenuItem
        ' 
        SottocategorieToolStripMenuItem.Name = "SottocategorieToolStripMenuItem"
        SottocategorieToolStripMenuItem.Size = New Size(165, 22)
        SottocategorieToolStripMenuItem.Text = "Sottocategorie"
        ' 
        ' SHOPAZIENDEToolStripMenuItem
        ' 
        SHOPAZIENDEToolStripMenuItem.Name = "SHOPAZIENDEToolStripMenuItem"
        SHOPAZIENDEToolStripMenuItem.Size = New Size(165, 22)
        SHOPAZIENDEToolStripMenuItem.Text = "SHOP/AZIENDE"
        ' 
        ' ModificaToolStripMenuItem
        ' 
        ModificaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ImportaMovimentiDaExcelToolStripMenuItem, ToolStripMenuItem1})
        ModificaToolStripMenuItem.Name = "ModificaToolStripMenuItem"
        ModificaToolStripMenuItem.Size = New Size(71, 21)
        ModificaToolStripMenuItem.Text = "Modifica"
        ' 
        ' ImportaMovimentiDaExcelToolStripMenuItem
        ' 
        ImportaMovimentiDaExcelToolStripMenuItem.Name = "ImportaMovimentiDaExcelToolStripMenuItem"
        ImportaMovimentiDaExcelToolStripMenuItem.Size = New Size(238, 22)
        ImportaMovimentiDaExcelToolStripMenuItem.Text = "Importa movimenti da Excel"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(238, 22)
        ToolStripMenuItem1.Text = "Esporta Dati"
        ' 
        ' VisualizzaToolStripMenuItem
        ' 
        VisualizzaToolStripMenuItem.Name = "VisualizzaToolStripMenuItem"
        VisualizzaToolStripMenuItem.Size = New Size(61, 21)
        VisualizzaToolStripMenuItem.Text = "Moduli"
        ' 
        ' ImpostazioniToolStripMenuItem
        ' 
        ImpostazioniToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConnessioneSQLToolStripMenuItem})
        ImpostazioniToolStripMenuItem.Name = "ImpostazioniToolStripMenuItem"
        ImpostazioniToolStripMenuItem.Size = New Size(94, 21)
        ImpostazioniToolStripMenuItem.Text = "Impostazioni"
        ' 
        ' ConnessioneSQLToolStripMenuItem
        ' 
        ConnessioneSQLToolStripMenuItem.Name = "ConnessioneSQLToolStripMenuItem"
        ConnessioneSQLToolStripMenuItem.Size = New Size(177, 22)
        ConnessioneSQLToolStripMenuItem.Text = "Connessione SQL"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnApplicaFiltro)
        Panel1.Controls.Add(btnResetFiltri)
        Panel1.Controls.Add(cmbCategoria)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtFiltroDescrizione)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dtFiltroData)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 486)
        Panel1.TabIndex = 3
        ' 
        ' btnApplicaFiltro
        ' 
        btnApplicaFiltro.Dock = DockStyle.Bottom
        btnApplicaFiltro.Location = New Point(0, 408)
        btnApplicaFiltro.Name = "btnApplicaFiltro"
        btnApplicaFiltro.Size = New Size(200, 39)
        btnApplicaFiltro.TabIndex = 6
        btnApplicaFiltro.Text = "Applica Filtro"
        btnApplicaFiltro.UseVisualStyleBackColor = True
        ' 
        ' btnResetFiltri
        ' 
        btnResetFiltri.Dock = DockStyle.Bottom
        btnResetFiltri.Location = New Point(0, 447)
        btnResetFiltri.Name = "btnResetFiltri"
        btnResetFiltri.Size = New Size(200, 39)
        btnResetFiltri.TabIndex = 7
        btnResetFiltri.Text = "Reset Filtro"
        btnResetFiltri.UseVisualStyleBackColor = True
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(3, 173)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(191, 25)
        cmbCategoria.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 17)
        Label3.TabIndex = 4
        Label3.Text = "Categoria"
        ' 
        ' txtFiltroDescrizione
        ' 
        txtFiltroDescrizione.Location = New Point(3, 94)
        txtFiltroDescrizione.Name = "txtFiltroDescrizione"
        txtFiltroDescrizione.Size = New Size(191, 25)
        txtFiltroDescrizione.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 17)
        Label2.TabIndex = 2
        Label2.Text = "Descrizione"
        ' 
        ' dtFiltroData
        ' 
        dtFiltroData.Location = New Point(3, 20)
        dtFiltroData.Name = "dtFiltroData"
        dtFiltroData.Size = New Size(191, 25)
        dtFiltroData.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 17)
        Label1.TabIndex = 0
        Label1.Text = "Data"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(DataGridView1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(200, 25)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 486)
        Panel2.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(600, 486)
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
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 536)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
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
    Friend WithEvents dtFiltroData As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnApplicaFiltro As Button
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFiltroDescrizione As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents btnResetFiltri As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel

End Class
