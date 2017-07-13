Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Horario
    Dim con As New SqlConnection
    Dim comando As New SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim ds As New DataSet
    Dim bs As New BindingSource
    Private Sub Horario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = url
        Try
            con.Open()
            Me.CenterToScreen()
            comando.Connection = con
            comando.CommandText = "SELECT distinct * FROM Dentista"
            adaptador.SelectCommand = comando
            adaptador.Fill(ds, "Dentista")
            bs.DataSource = ds
            bs.DataMember = "Dentista"
            TxtNombre.AutoCompleteCustomSource = IdHorario()
            TxtNombre.AutoCompleteMode = AutoCompleteMode.Suggest
            TxtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
            con.Close()
            Dim xc As Integer
            xc = 7
            While xc < 22
                DGV.Rows.Add(xc & ":00")
                xc = xc + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
            FrmMenu.Show()
        End Try
    End Sub
    Public Function IdHorario() As AutoCompleteStringCollection
        Dim dt As DataTable = Hor()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("NombreDentista")))
        Next
        Return coleccion
    End Function
    Public Function Hor() As DataTable
        Dim dt As New DataTable()
        Dim Consulta As String = "SELECT * from Dentista"
        Dim comando As New SqlCommand(Consulta, con)
        Dim adap As New SqlDataAdapter(comando)
        adap.Fill(dt)
        Return dt
    End Function

    Private Sub TxtHorario_TextChanged(sender As Object, e As EventArgs) Handles TxtHorario.TextChanged
        Try
            con.Open()
            If TxtHorario.Text.Length > 0 Then
                Dim dias(8) As String
                dias(1) = "Lunes"
                dias(2) = "Martes"
                dias(3) = "Miercoles"
                dias(4) = "Jueves"
                dias(5) = "Viernes"
                dias(6) = "Sabado"
                dias(7) = "Domingo"
                Dim z = 1
                While z < 8
                    Dim x = 0, y = 7
                    While y < 22
                        Dim consul As New SqlCommand("select Hora from HorarioDentista where dia='" & dias(z) & "' and hora =" & y & "and IdDentista=" & TxtHorario.Text, con)
                        If consul.ExecuteScalar = y Then
                            DGV(z, x).Value = True
                        Else
                            DGV(z, x).Value = False
                        End If
                        x = x + 1
                        y = y + 1
                    End While
                    z = z + 1
                End While
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub BtnH_Click(sender As Object, e As EventArgs) Handles BtnH.Click
        If TxtHorario.Text.Length < 1 Then
            MsgBox("Id no existente")
        Else
            Try
                con.Open()
                Dim dias(8) As String
                dias(1) = "Lunes"
                dias(2) = "Martes"
                dias(3) = "Miercoles"
                dias(4) = "Jueves"
                dias(5) = "Viernes"
                dias(6) = "Sabado"
                dias(7) = "Domingo"
                Dim z = 1
                While z < 8
                    Dim x = 0, y = 7
                    While y < 22
                        If DGV(z, x).Value = True Then
                            Dim Aa As New SqlCommand("select max(IdHorario)+1 from HorarioDentista", con)
                            Dim disponible As New SqlCommand("select Hora from HorarioDentista where dia='" & dias(z) & "' and hora =" & y & "and IdDentista=" & TxtHorario.Text, con)
                            If disponible.ExecuteScalar <> y Then
                                Dim Comando2 As New SqlCommand("insert into HorarioDentista values(" & Aa.ExecuteScalar.ToString & "," & TxtHorario.Text & ",'" & dias(z) & "'," & y & ")", con)
                                Comando2.ExecuteNonQuery()
                            End If
                        Else
                            Dim elmiminar As New SqlCommand("delete from HorarioDentista where dia='" & dias(z) & "' and hora =" & y & "and IdDentista=" & TxtHorario.Text, con)
                            elmiminar.ExecuteNonQuery()
                        End If
                        x = x + 1
                        y = y + 1
                    End While
                    z = z + 1
                End While
                MsgBox("Horario Almacenado con éxito")
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
            Me.Hide()
        End If
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If TxtNombre.Text.Length > 1 Then
            Try
                con.Open()
                Dim id As New SqlCommand("select Max(HorarioDentista.IdDentista) from HorarioDentista,Dentista where HorarioDentista.IdDentista=Dentista.IdDentista and NombreDentista='" & TxtNombre.Text & "'", con)
                Dim AuxId As String = id.ExecuteScalar
                con.Close()
                TxtHorario.Text = AuxId
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
End Class