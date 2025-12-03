Imports System.Windows.Forms

Public Class FrmDbSettings
    Inherits Form

    Private lblServer As Label
    Private lblDatabase As Label
    Private lblUser As Label
    Private lblPassword As Label


    Private txtServer As TextBox
    Private txtDatabase As TextBox
    Private txtUser As TextBox
    Private txtPassword As TextBox

    Private btnSave As Button

    Public Sub New()
        Me.Text = "Impostazioni Connessione Database"
        Me.Width = 400
        Me.Height = 280


        lblServer = New Label With {.Text = "Server:", .Top = 20, .Left = 20, .Width = 120}
        lblDatabase = New Label With {.Text = "Database:", .Top = 60, .Left = 20, .Width = 120}
        lblUser = New Label With {.Text = "User:", .Top = 100, .Left = 20, .Width = 120}
        lblPassword = New Label With {.Text = "Password:", .Top = 140, .Left = 20, .Width = 120}


        txtServer = New TextBox With {.Top = 20, .Left = 150, .Width = 180}
        txtDatabase = New TextBox With {.Top = 60, .Left = 150, .Width = 180}
        txtUser = New TextBox With {.Top = 100, .Left = 150, .Width = 180}
        txtPassword = New TextBox With {.Top = 140, .Left = 150, .Width = 180, .UseSystemPasswordChar = True}


        btnSave = New Button With {.Text = "Salva", .Top = 190, .Left = 150, .Width = 120}
        AddHandler btnSave.Click, AddressOf SaveSettings


        Me.Controls.AddRange({lblServer, lblDatabase, lblUser, lblPassword, txtServer, txtDatabase, txtUser, txtPassword, btnSave})


        LoadCurrentSettings()
    End Sub


    Public Sub LoadCurrentSettings()

        Dim cfg = DbConfigManager.LoadConfig()

        ' Se non esiste config > valori vuoti
        If cfg Is Nothing Then
            txtServer.Text = ""
            txtDatabase.Text = ""
            txtUser.Text = ""
            txtPassword.Text = ""
            Exit Sub
        End If

        ' Se esiste > carico i valori
        txtServer.Text = cfg.Server
        txtDatabase.Text = cfg.Database
        txtUser.Text = cfg.User
        txtPassword.Text = cfg.Password

    End Sub



    Private Sub SaveSettings(sender As Object, e As EventArgs)
        Dim cfg As New DbConfig With {
        .Server = txtServer.Text,
        .Database = txtDatabase.Text,
        .User = txtUser.Text,
        .Password = txtPassword.Text
        }


        DbConfigManager.SaveConfig(cfg)
        MessageBox.Show("Configurazione salvata correttamente.")
        Me.Close()
    End Sub


End Class