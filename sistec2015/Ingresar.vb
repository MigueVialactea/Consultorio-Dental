Imports System.Data.SqlClient
Public Class FrmIngresar
    Dim conexion As New SqlConnection
    Dim u, p, s, c As String
    Dim od As New OpenFileDialog
    Dim con As New SqlConnection
    Dim com As New SqlCommand
    Dim nom As String
    Dim st As String
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        u = TxtUsuario.Text
        p = TxtContraseña.Text
        s = TxtServidor.Text
        url = "Data Source=" & s & "; Initial Catalog=ConsultorioDental; User Id=" & u & "; Password=" & p & ";"
        conexion.ConnectionString = url
        Try
            conexion.Open()
            Me.Hide()
            FrmMenu.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        End 'Cierra el proyecto
    End Sub

    Private Sub FrmIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim count As Integer
        count = 0
        s = My.Computer.FileSystem.ReadAllText("Docs\path.txt")
        TxtServidor.Text = s
        Label1.Text = hoy()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = "DATA SOURCE=SONIA-PC; INITIAL CATALOG=master; USER ID=SA; PASSWORD=1235;"
        If od.ShowDialog = Windows.Forms.DialogResult.OK Then
            con = New SqlConnection(c)
            nom = od.FileName
            st = "RESTORE DATABASE ConsultorioDental FROM DISK='" & nom & "' with replace"
        End If
        Try
            con.Open()
            com = New SqlCommand(st, con)
            com.ExecuteNonQuery()
            MessageBox.Show("Se ha restaurado la base de datos.")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim original As String
        Dim dialogo As Object
        original = "Sonia-Pc"
        dialogo = InputBox("Ingrese nombre del Servidor", "Servidor", "Sonia-Pc")
        If dialogo Is "" Then dialogo = original
        TxtServidor.Text = dialogo
    End Sub
End Class