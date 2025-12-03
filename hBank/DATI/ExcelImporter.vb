Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class ExcelImporter

    Public Property ConnectionString As String

    Public Sub New(connString As String)
        Me.ConnectionString = connString
    End Sub

    ' ==================================================================================
    ' Importa i movimenti da un file Excel nella tabella SQL Server tab_movimenti.
    ' I dati partono dalla riga 10 e dalla colonna B.
    ' Prevedere in futuro questa selezione
    ' ==================================================================================
    Public Sub ImportaMovimenti(excelPath As String)
        Try
            Dim excelConnString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={excelPath};Extended Properties='Excel 12.0 Xml;HDR=NO';"

            Using excelConn As New OleDbConnection(excelConnString)
                excelConn.Open()

                Dim sheetName As String = GetFirstSheetName(excelConn)

                Dim qryExcel As String = $"SELECT * FROM [{sheetName}B10:Z10000]"
                Dim cmd As New OleDbCommand(qryExcel, excelConn)

                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                Using sqlConn As New SqlConnection(ConnectionString)
                    sqlConn.Open()

                    While reader.Read()
                        If IsDBNull(reader(0)) Then Continue While ' Salta righe vuote

                        ' Mappatura
                        Dim dataContabile = ConvertToDate(reader(0))
                        Dim dataValuta = ConvertToDate(reader(1))
                        Dim causaleABI = reader(2)?.ToString()
                        Dim descrizione = reader(3)?.ToString()
                        Dim importo = ConvertToDecimal(reader(4))
                        Dim categoria = reader(5)?.ToString()
                        Dim sottoCategoria = reader(6)?.ToString()
                        Dim shop = reader(7)?.ToString()
                        Dim utilizzatore = reader(8)?.ToString()
                        Dim essenziale = ConvertToBool(reader(9))
                        Dim ricorrente = ConvertToBool(reader(10))

                        Dim query As String = "INSERT INTO tab_movimenti (data_contabile, data_valuta, causale_abi, descrizione, importo, categoria, sottocategoria, shop_azienda, utilizzatore, essenziale, ricorrente) " &
                                            "VALUES (@dc, @dv, @cau, @desc, @imp, @cat, @scat, @shop, @uti, @ess, @ric)"

                        Using cmdSql As New SqlCommand(query, sqlConn)
                            cmdSql.Parameters.AddWithValue("@dc", If(dataContabile Is Nothing OrElse IsDBNull(dataContabile), DBNull.Value, dataContabile))
                            cmdSql.Parameters.AddWithValue("@dv", If(dataValuta Is Nothing OrElse IsDBNull(dataValuta), DBNull.Value, dataValuta))
                            cmdSql.Parameters.AddWithValue("@cau", causaleABI)
                            cmdSql.Parameters.AddWithValue("@desc", descrizione)
                            cmdSql.Parameters.AddWithValue("@imp", importo)
                            cmdSql.Parameters.AddWithValue("@cat", categoria)
                            cmdSql.Parameters.AddWithValue("@scat", sottoCategoria)
                            cmdSql.Parameters.AddWithValue("@shop", shop)
                            cmdSql.Parameters.AddWithValue("@uti", utilizzatore)
                            cmdSql.Parameters.AddWithValue("@ess", essenziale)
                            cmdSql.Parameters.AddWithValue("@ric", ricorrente)

                            cmdSql.ExecuteNonQuery()
                        End Using
                    End While
                End Using

            End Using

        Catch ex As Exception
            Throw New Exception("Errore durante l'importazione: " & ex.Message)
        End Try
    End Sub

    Private Function ConvertToDate(value As Object) As Object
        If IsDBNull(value) Then Return DBNull.Value

        Dim raw As String = value.ToString().Trim()

        ' Valori non data
        If raw = "" OrElse raw.ToLower() = "non contabilizzato" Then
            Return DBNull.Value
        End If

        Dim d As Date
        If Date.TryParse(raw, d) Then
            ' SQL Server supporta date solo dal 1753
            If d.Year >= 1753 Then
                Return d
            End If
        End If

        ' Se non è una data valida
        Return DBNull.Value
    End Function


    Private Function ConvertToDecimal(value As Object) As Decimal
        If IsDBNull(value) Then Return 0
        Dim dec As Decimal
        If Decimal.TryParse(value.ToString(), dec) Then Return dec
        Return 0
    End Function

    Private Function ConvertToBool(value As Object) As Boolean
        If IsDBNull(value) Then Return False
        Dim b As Boolean
        If Boolean.TryParse(value.ToString(), b) Then Return b
        Return False
    End Function

    Private Function GetFirstSheetName(excelConn As OleDbConnection) As String
        Dim schemaTable As DataTable = excelConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

        For Each row As DataRow In schemaTable.Rows
            Dim sheetName As String = row("TABLE_NAME").ToString()

            ' Esclusione tabelle interne o nomi strani
            If sheetName.EndsWith("$") OrElse sheetName.EndsWith("$'") Then
                ' Normalizzazione nome foglio
                sheetName = sheetName.Trim("'"c)
                Return sheetName
            End If
        Next

        Throw New Exception("Nessun foglio valido trovato nel file Excel.")
    End Function


End Class
