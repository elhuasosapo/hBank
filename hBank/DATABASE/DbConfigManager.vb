Imports System.IO
Imports System.Text.Json


Public Class DbConfig
    Public Property Server As String
    Public Property Database As String
    Public Property User As String
    Public Property Password As String
End Class


Public Class DbConfigManager


    Private Shared ReadOnly configPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dbconfig.json")


    Public Shared Function LoadConfig() As DbConfig
        If Not File.Exists(configPath) Then
            Return Nothing
        End If

        Try
            Dim json = File.ReadAllText(configPath)
            Return JsonSerializer.Deserialize(Of DbConfig)(json)
        Catch ex As Exception
            ' Se file corrotto o non leggibile
            Return Nothing
        End Try
    End Function



    Public Shared Sub SaveConfig(cfg As DbConfig)
        Dim json As String = JsonSerializer.Serialize(cfg, New JsonSerializerOptions With {.WriteIndented = True})
        File.WriteAllText(configPath, json)
    End Sub


    Public Shared Function BuildConnectionString(cfg As DbConfig) As String
        Return $"Server={cfg.Server};Database={cfg.Database};User Id={cfg.User};Password={cfg.Password};TrustServerCertificate=True;"
    End Function


End Class