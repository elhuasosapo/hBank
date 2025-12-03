Imports System.Data.SqlClient
Public Class Form1
    Private connString As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cfg = DbConfigManager.LoadConfig()

        'Se non esiste il JSON > chiedo all’utente
        If cfg Is Nothing Then
            MessageBox.Show("Il file di configurazione del database non è stato trovato." & vbCrLf &
                        "Inserisci ora i parametri di connessione.",
                        "Configurazione mancante",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

            Dim frm As New FrmDbSettings()
            frm.ShowDialog()

            cfg = DbConfigManager.LoadConfig()

            If cfg Is Nothing Then
                MessageBox.Show("Impossibile continuare senza una configurazione valida.",
                            "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
        End If

        connString = DbConfigManager.BuildConnectionString(cfg)

        Try
            CaricaCategorie()
            CaricaMovimenti()
            SetStatus("Pronto.")
        Catch ex As Exception
            SetStatusError("Errore di connessione: " & ex.Message)
            MessageBox.Show("Errore durante la connessione al database:" & vbCrLf &
                        ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub CaricaMovimenti(Optional whereClause As String = "")
        SetStatus("Caricamento dati in corso...")
        Dim query As String = "SELECT * FROM tab_movimenti"

        If whereClause <> "" Then
            query &= " WHERE " & whereClause
        End If

        Using con As New SqlConnection(connString)
            Dim da As New SqlDataAdapter(query, con)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End Using
        SetStatus("Dati caricati.")
    End Sub

    Private Sub CaricaCategorie()
        Using con As New SqlConnection(connString)
            Dim cmd As New SqlCommand("SELECT DISTINCT categoria FROM tab_movimenti WHERE categoria IS NOT NULL", con)
            con.Open()

            Dim reader = cmd.ExecuteReader()
            cmbCategoria.Items.Clear()

            cmbCategoria.Items.Add("") ' Nessun filtro
            While reader.Read()
                cmbCategoria.Items.Add(reader("categoria").ToString())
            End While
        End Using
    End Sub



    Private Sub ImportaMovimentiDaExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportaMovimentiDaExcelToolStripMenuItem.Click
        ' Carico la configurazione dal JSON
        Dim cfg = DbConfigManager.LoadConfig()
        Dim connString = DbConfigManager.BuildConnectionString(cfg)

        ' Apro la finestra di selezione del file
        Dim ofd As New OpenFileDialog With {
            .Filter = "File Excel (*.xlsx)|*.xlsx",
            .Title = "Seleziona il file Excel dei movimenti"
        }

        If ofd.ShowDialog() = DialogResult.OK Then

            Try
                ' Avvio importazione
                Dim importer As New ExcelImporter(connString)
                importer.ImportaMovimenti(ofd.FileName)

                MessageBox.Show("Importazione completata correttamente!", "OK",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Errore durante l'importazione:" & vbCrLf & ex.Message,
                                "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MessageBox.Show("Importazione annullata.")
        End If
    End Sub

    Private Sub ConnessioneSQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnessioneSQLToolStripMenuItem.Click
        Dim frm As New FrmDbSettings()
        frm.ShowDialog()
    End Sub

    '======================================================
    'APPLICAZIONE DEI FILTRI
    '======================================================
    Private Sub btnApplicaFiltro_Click(sender As Object, e As EventArgs) Handles btnApplicaFiltro.Click
        Dim condizioni As New List(Of String)

        ' Filtro per data
        If dtFiltroData.Checked Then
            condizioni.Add($"data_contabile = '{dtFiltroData.Value:yyyy-MM-dd}'")
        End If

        ' Filtro per descrizione
        If txtFiltroDescrizione.Text.Trim() <> "" Then
            condizioni.Add($"descrizione LIKE '%{txtFiltroDescrizione.Text.Trim().Replace("'", "''")}%'")
        End If

        ' Filtro per categoria
        If cmbCategoria.Text.Trim() <> "" Then
            condizioni.Add($"categoria = '{cmbCategoria.Text.Replace("'", "''")}'")
        End If

        ' Monta la WHERE
        Dim whereSQL As String = String.Join(" AND ", condizioni)

        CaricaMovimenti(whereSQL)
    End Sub

    Private Sub btnResetFiltri_Click(sender As Object, e As EventArgs) Handles btnResetFiltri.Click
        dtFiltroData.Checked = False
        txtFiltroDescrizione.Text = ""
        cmbCategoria.SelectedIndex = 0

        CaricaMovimenti()
    End Sub

    '======================================================
    'BARRA DI STATO
    '======================================================
    Public Sub SetStatus(msg As String)
        ToolStripStatusLabel1.Text = msg
    End Sub

    Public Sub SetStatusSuccess(msg As String)
        ToolStripStatusLabel1.ForeColor = Color.Green
        ToolStripStatusLabel1.Text = msg
    End Sub

    Public Sub SetStatusError(msg As String)
        ToolStripStatusLabel1.ForeColor = Color.Red
        ToolStripStatusLabel1.Text = msg
    End Sub

    Public Sub SetStatusInfo(msg As String)
        ToolStripStatusLabel1.ForeColor = Color.DarkBlue
        ToolStripStatusLabel1.Text = msg
    End Sub


End Class
