Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class SERVICIO
    Dim con As New SqlConnection
    Dim comando As New SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim ds As New DataSet
    Dim bs As New BindingSource

    Private Sub SERVICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = url
        Try
            con.Open()
            Me.CenterToScreen()
            comando.Connection = con
            comando.CommandText = "SELECT * FROM Servicio"
            adaptador.SelectCommand = comando
            adaptador.Fill(ds, "Servicio")
            bs.DataSource = ds
            bs.DataMember = "Servicio"
            TxtFiltro.AutoCompleteCustomSource = IdServ()
            TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
            TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextName.AutoCompleteCustomSource = NameServ()
            TextName.AutoCompleteMode = AutoCompleteMode.Suggest
            TextName.AutoCompleteSource = AutoCompleteSource.CustomSource
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
            FrmMenu.Show()
        End Try
    End Sub

    Private Sub TxtCadena_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltro.TextChanged
        Try
            If TxtFiltro.Text.Length > 0 Then
                con.Open()
                comando.Connection = con
                comando.CommandText = "SELECT * FROM Servicio where IdServicio like '%" & TxtFiltro.Text & "%'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "SERVICIO")
                bs.DataSource = ds
                bs.DataMember = "SERVICIO"
                Dim a As New SqlCommand("select IdServicio from Servicio where IdServicio='" & TxtFiltro.Text & "'", con)
                TxtServicio.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT NombreServicio FROM Servicio where IdServicio='" & TxtFiltro.Text & "'", con)
                TxtNombre.Text = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT ImporteServicio FROM Servicio where IdServicio='" & TxtFiltro.Text & "'", con)
                TxtImporte.Text = c.ExecuteScalar
                con.Close()
                If bs.Count > 1 Then
                    DGV.DataSource = bs
                End If
                If TxtServicio.Text.Length > 0 Then
                    Detalles.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                End If
                If TxtServicio.Text.Length = 0 Then
                    Detalles.Visible = False
                    BtnModificar.Visible = False
                    BtnEliminar.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            con.Open()
            Dim Aa As New SqlCommand("select max(IdServicio)+1 from Servicio", con)
            TxtServicio.Text = Aa.ExecuteScalar.ToString
            Filtro.Visible = False
            BtnAgregar.Visible = True
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnModificar.Visible = False
            BtnNuevo.Visible = False
            Detalles.Visible = True
            BtnAgregar.Enabled = True
            TxtServicio.Enabled = False
            TxtNombre.Enabled = True
            TxtImporte.Enabled = True
            TxtFiltro.Text = ""
            TxtNombre.Text = ""
            TxtImporte.Text = ""
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtServicio.Text.Length < 1 Then
            VId.Text = "*Debe seleccionar un registro."
        Else
            Try
                con.Open()
                If MessageBox.Show("¿En realidad desea borrar el registro?", "My Application",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                     = DialogResult.Yes Then
                    Dim Comando2 As New SqlCommand("delete from Servicio where IdServicio='" & TxtServicio.Text & "'", con)
                    Comando2.ExecuteNonQuery()
                    bs.RemoveCurrent()
                    MsgBox("Registro eliminado satisfactoriamente")
                    TxtImporte.Text = ""
                    TxtNombre.Text = ""
                    TxtServicio.Text = ""
                    TxtFiltro.Text = ""
                    Detalles.Visible = False
                    BtnModificar.Visible = False
                    BtnEliminar.Visible = False
                    TxtFiltro.AutoCompleteCustomSource = IdServ()
                    TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
                    TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
                    TextName.AutoCompleteCustomSource = NameServ()
                    TextName.AutoCompleteMode = AutoCompleteMode.Suggest
                    TextName.AutoCompleteSource = AutoCompleteSource.CustomSource
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try
            con.Open()
            TxtFiltro.Text = ""
            Filtro.Visible = False
            Detalles.Visible = True
            BtnActualizar.Visible = True

            TxtNombre.Enabled = True
            TxtImporte.Enabled = True
            BtnNuevo.Visible = False
            BtnEliminar.Visible = False
            BtnModificar.Visible = False
            BtnActualizar.Enabled = True
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)
        CbFiltro.DroppedDown = True
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtServicio.Text.Length < 1 Or TxtNombre.Text.Length < 1 Or TxtImporte.Text.Length < 1 Then
            If TxtServicio.Text.Length < 1 Then
                VId.Text = "*Debe seleccionar un dato."
            End If
            If TxtNombre.Text.Length < 1 Then
                VNombre.Text = "*Debe ingresar un dato."
            End If
            If TxtImporte.Text.Length < 1 Then
                VImporte.Text = "*Debe ingresar un dato."
            End If
        Else
            Try
                con.Open()
                Dim Comando2 As New SqlCommand
                Comando2.Connection = con
                Comando2.CommandText = "update Servicio set NombreServicio='" & TxtNombre.Text & "' where IdServicio='" & TxtServicio.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Servicio set ImporteServicio='" & TxtImporte.Text & "' where IdServicio='" & TxtServicio.Text & "'"
                Comando2.ExecuteNonQuery()
                MsgBox("Edición realizada con éxito")
                TxtFiltro.Text = ""
                Detalles.Visible = False
                Filtro.Visible = True
                DGV.Visible = False
                BtnEliminar.Enabled = True
                BtnModificar.Enabled = True
                BtnAgregar.Enabled = False
                BtnActualizar.Enabled = False
                BtnActualizar.Visible = False
                BtnNuevo.Visible = True
                BtnNuevo.Enabled = True
                TxtImporte.Enabled = False
                TxtNombre.Enabled = False
                TxtFiltro.AutoCompleteCustomSource = IdServ()
                TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
                TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextName.AutoCompleteCustomSource = NameServ()
                TextName.AutoCompleteMode = AutoCompleteMode.Suggest
                TextName.AutoCompleteSource = AutoCompleteSource.CustomSource
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtServicio.Text.Length < 1 Or TxtNombre.Text.Length < 1 Or TxtImporte.Text.Length < 1 Then
            If TxtServicio.Text.Length < 1 Then
                VId.Text = "*Debe ingresar un dato."
            End If
            If TxtNombre.Text.Length < 1 Then
                VNombre.Text = "*Debe ingresar un dato."
            End If
            If TxtImporte.Text.Length < 1 Then
                VImporte.Text = "*Debe ingresar un dato."
            End If
        Else
            Try
                con.Open()
                bs.EndEdit()
                Dim Comando2 As New SqlCommand("insert into servicio values('" & TxtServicio.Text & "','" & TxtNombre.Text & "','" & TxtImporte.Text & "')", con)
                Comando2.ExecuteNonQuery()
                'Para que agregue ahi
                comando.Connection = con
                comando.CommandText = "SELECT distinct * FROM Servicio where idServicio='" & TxtServicio.Text & "'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "Servicio")
                bs.DataSource = ds
                bs.DataMember = "Servicio"
                DGV.DataSource = bs 'Todo esto
                BtnEliminar.Enabled = True
                Filtro.Visible = True
                BtnNuevo.Visible = True
                BtnAgregar.Visible = False
                Detalles.Visible = False
                TxtFiltro.Enabled = True
                TxtFiltro.Text = ""
                TxtImporte.Enabled = False
                TxtNombre.Enabled = False
                TxtServicio.Enabled = False
                MsgBox("Dato almacenado con éxito")
                TxtFiltro.AutoCompleteCustomSource = IdServ()
                TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
                TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextName.AutoCompleteCustomSource = NameServ()
                TextName.AutoCompleteMode = AutoCompleteMode.Suggest
                TextName.AutoCompleteSource = AutoCompleteSource.CustomSource
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        Dim d1, pattern As String
        d1 = TxtNombre.Text
        pattern = "^([A-Za-záéíóúü]( ?)){0,40}$"
        If Regex.IsMatch(d1, pattern) Then
            VNombre.Text = ""
        Else
            If TxtNombre.Text.Length > 0 Then
                If Microsoft.VisualBasic.Left(d1, 1) = " " Then
                    TxtNombre.Text = Microsoft.VisualBasic.Right(d1, Len(d1) - 1)
                Else
                    TxtNombre.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                    TxtNombre.Select(TxtNombre.Text.Length, 0)
                End If
            End If
                VNombre.Text = "*Ingrese solo letras, máximo 40."
        End If
    End Sub

    Private Sub TxtServicio_TextChanged(sender As Object, e As EventArgs) Handles TxtServicio.TextChanged
        Dim d1, pattern As String
        d1 = TxtServicio.Text
        pattern = "^[0-9]{0,5}$"
        If Regex.IsMatch(d1, pattern) Then
            VId.Text = ""
        Else
            If TxtServicio.Text.Length > 0 Then
                If Microsoft.VisualBasic.Left(d1, 1) = " " Then
                    TxtServicio.Text = Microsoft.VisualBasic.Right(d1, Len(d1) - 1)
                Else
                    TxtServicio.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                    TxtServicio.Select(TxtServicio.Text.Length, 0)
                End If
            End If
            VId.Text = "*Ingrese sólo números, máximo 5."
        End If
    End Sub

    Private Sub TxtImporte_TextChanged(sender As Object, e As EventArgs) Handles TxtImporte.TextChanged
        Dim d1, pattern As String
        d1 = TxtImporte.Text
        pattern = "^[0-9]{0,9}$"
        If Regex.IsMatch(d1, pattern) Then
            VImporte.Text = ""
        Else
            If TxtImporte.Text.Length > 0 Then
                If Microsoft.VisualBasic.Left(d1, 1) = " " Then
                    TxtImporte.Text = Microsoft.VisualBasic.Right(d1, Len(d1) - 1)
                Else
                    TxtImporte.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                    TxtImporte.Select(TxtImporte.Text.Length, 0)
                End If
            End If
            VImporte.Text = "*Ingrese sólo números, máximo 9."
        End If
    End Sub

    Public Function IdServ() As AutoCompleteStringCollection
        Dim dt As DataTable = Serv()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("IdServicio")))
        Next
        Return coleccion
    End Function
    Public Function NameServ() As AutoCompleteStringCollection
        Dim dt As DataTable = Serv()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("NombreServicio")))
        Next
        Return coleccion
    End Function
    Public Function Serv() As DataTable
        Dim dt As New DataTable()
        Dim Consulta As String = "SELECT * FROM Servicio"
        Dim comando As New SqlCommand(Consulta, con)
        Dim adap As New SqlDataAdapter(comando)
        adap.Fill(dt)
        Return dt
    End Function

    Private Sub TextName_TextChanged(sender As Object, e As EventArgs) Handles TextName.TextChanged
        Try
            If TextName.Text.Length > 0 Then
                con.Open()
                comando.Connection = con
                comando.CommandText = "SELECT * FROM Servicio where NombreServicio like '%" & TextName.Text & "%'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "SERVICIO")
                bs.DataSource = ds
                bs.DataMember = "SERVICIO"
                Dim a As New SqlCommand("select IdServicio from Servicio where NombreServicio='" & TextName.Text & "'", con)
                TxtServicio.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT NombreServicio FROM Servicio where NombreServicio='" & TextName.Text & "'", con)
                TxtNombre.Text = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT ImporteServicio FROM Servicio where NombreServicio='" & TextName.Text & "'", con)
                TxtImporte.Text = c.ExecuteScalar
                con.Close()
                If TxtServicio.Text.Length > 0 Then
                    Detalles.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                End If
                If TxtServicio.Text.Length = 0 Then
                    Detalles.Visible = False
                    BtnModificar.Visible = False
                    BtnEliminar.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub CbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbFiltro.SelectedIndexChanged
        If CbFiltro.SelectedIndex = 0 Then
            TxtFiltro.Visible = True
            TextName.Visible = False
            TextName.Text = ""
        ElseIf CbFiltro.SelectedIndex = 1 Then
            TxtFiltro.Visible = False
            TxtFiltro.Text = ""
            TextName.Visible = True
        End If
    End Sub
End Class