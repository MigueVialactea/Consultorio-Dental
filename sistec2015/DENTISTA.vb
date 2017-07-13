Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class DENTISTA
    Dim con As New SqlConnection
    Dim comando As New SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim ds As New DataSet
    Dim bs As New BindingSource
    Private Sub DENTISTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            TxtFiltro.AutoCompleteCustomSource = IdDent()
            TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
            TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextName.AutoCompleteCustomSource = NomDent()
            TextName.AutoCompleteMode = AutoCompleteMode.Suggest
            TextName.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextEspec.AutoCompleteCustomSource = EspDent()
            TextEspec.AutoCompleteMode = AutoCompleteMode.Suggest
            TextEspec.AutoCompleteSource = AutoCompleteSource.CustomSource
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
            FrmMenu.Show()
        End Try
    End Sub
    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltro.TextChanged
        Try
            If TxtFiltro.Text.Length > 0 Then
                con.Open()
                comando.Connection = con
                comando.CommandText = "SELECT * FROM Dentista where IdDentista like '%" & TxtFiltro.Text & "%'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "DENTISTA")
                bs.DataSource = ds
                bs.DataMember = "DENTISTA"
                Dim a As New SqlCommand("select idDentista from Dentista where idDentista='" & TxtFiltro.Text & "'", con)
                TxtId.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT NombreDentista FROM Dentista where idDentista='" & TxtFiltro.Text & "'", con)
                TxtNombre.Text = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT TelefonoDentista FROM Dentista where idDentista='" & TxtFiltro.Text & "'", con)
                TxtTelefono.Text = c.ExecuteScalar
                Dim d As New SqlCommand("SELECT CelularDentista FROM Dentista where idDentista='" & TxtFiltro.Text & "'", con)
                TxtCelular.Text = d.ExecuteScalar
                Dim ee As New SqlCommand("SELECT EspecialidadDentista FROM Dentista where idDentista='" & TxtFiltro.Text & "'", con)
                CombEsp.SelectedItem = ee.ExecuteScalar
                con.Close()
                If TxtId.Text.Length > 0 Then
                    Detalles.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                    Button1.Enabled = False
                End If
                If TxtId.Text.Length = 0 Then
                    Detalles.Visible = False
                    BtnModificar.Visible = False
                    BtnEliminar.Visible = False
                    Button1.Enabled = False
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
            Dim Aa As New SqlCommand("select max(IdDentista)+1 from Dentista", con)
            TxtId.Text = Aa.ExecuteScalar.ToString
            Filtro.Visible = False
            BtnAgregar.Visible = True
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnModificar.Visible = False
            BtnNuevo.Visible = False
            Detalles.Visible = True
            BtnAgregar.Enabled = True
            TxtId.Enabled = False
            TxtNombre.Enabled = True
            TxtTelefono.Enabled = True
            TxtCelular.Enabled = True
            CombEsp.Enabled = True
            Button1.Enabled = False
            TxtFiltro.Text = ""
            TxtNombre.Text = ""
            TxtTelefono.Text = ""
            TxtCelular.Text = ""
            CombEsp.SelectedIndex = -1
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtId.Text.Length < 1 Then
            VId.Text = "*Debe seleccionar un registro."
        Else
            Try
                con.Open()
                If MessageBox.Show("¿En realidad desea borrar el registro?", "My Application",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                 = DialogResult.Yes Then
                    Dim Comando2 As New SqlCommand("delete from Dentista where IdDentista='" & TxtId.Text & "'", con)
                    Comando2.ExecuteNonQuery()
                    bs.RemoveCurrent()
                    MsgBox("Registro eliminado satisfactoriamente")
                    TxtFiltro.Text = ""
                    TxtId.Text = ""
                    TxtNombre.Text = ""
                    TxtTelefono.Text = ""
                    TxtCelular.Text = ""
                    CombEsp.SelectedIndex = -1
                    Detalles.Visible = False
                    BtnModificar.Visible = False
                    BtnEliminar.Visible = False
                    TxtFiltro.AutoCompleteCustomSource = IdDent()
                    TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
                    TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
                    TextName.AutoCompleteCustomSource = NomDent()
                    TextName.AutoCompleteMode = AutoCompleteMode.Suggest
                    TextName.AutoCompleteSource = AutoCompleteSource.CustomSource
                    TextEspec.AutoCompleteCustomSource = EspDent()
                    TextEspec.AutoCompleteMode = AutoCompleteMode.Suggest
                    TextEspec.AutoCompleteSource = AutoCompleteSource.CustomSource
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
            Button1.Enabled = False
            TxtTelefono.Enabled = True
            TxtCelular.Enabled = True
            TxtNombre.Enabled = True
            CombEsp.Enabled = True
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
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtId.Text.Length < 1 Or TxtNombre.Text.Length < 1 Or TxtTelefono.Text.Length < 1 Or TxtCelular.Text.Length < 1 Or CombEsp.SelectedIndex = -1 Then
            If TxtId.Text.Length < 1 Then
                VId.Text = "*Debe seleccionar un dato."
            End If
            If TxtNombre.Text.Length < 1 Then
                VNombre.Text = "*Debe ingresar un dato."
            End If
            If TxtTelefono.Text.Length < 1 Then
                VTelefono.Text = "*Debe ingresar un dato."
            End If
            If TxtCelular.Text.Length < 1 Then
                VCelular.Text = "*Debe ingresar un dato."
            End If
            If CombEsp.SelectedIndex < 0 Then
                VEspecialidad.Text = "*Debe ingresar un dato."
            End If
        Else
            Try
                con.Open()
                Dim Comando2 As New SqlCommand
                Comando2.Connection = con
                Comando2.CommandText = "update Dentista set NombreDentista='" & TxtNombre.Text & "' where IdDentista='" & TxtId.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Dentista set TelefonoDentista='" & TxtTelefono.Text & "' where IdDentista='" & TxtId.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Dentista set CelularDentista='" & TxtCelular.Text & "' where IdDentista='" & TxtId.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Dentista set EspecialidadDentista='" & CombEsp.SelectedItem & "' where IdDentista='" & TxtId.Text & "'"
                Comando2.ExecuteNonQuery()
                MsgBox("Edición realizada con éxito")
                TxtFiltro.Text = ""
                'Detalles.Visible = False
                'Filtro.Visible = True
                'BtnEliminar.Enabled = True
                'BtnModificar.Enabled = True
                'BtnAgregar.Enabled = False
                'BtnActualizar.Enabled = False
                'BtnActualizar.Visible = False
                'BtnNuevo.Visible = True
                'BtnNuevo.Enabled = True
                'TxtFiltro.Enabled = True
                'CbFiltro.Enabled = True
                TxtId.Enabled = False
                TxtNombre.Enabled = False
                TxtTelefono.Enabled = False
                TxtCelular.Enabled = False
                CombEsp.Enabled = False
                Button1.Enabled = True
                TxtFiltro.AutoCompleteCustomSource = IdDent()
                TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
                TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextName.AutoCompleteCustomSource = NomDent()
                TextName.AutoCompleteMode = AutoCompleteMode.Suggest
                TextName.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextEspec.AutoCompleteCustomSource = EspDent()
                TextEspec.AutoCompleteMode = AutoCompleteMode.Suggest
                TextEspec.AutoCompleteSource = AutoCompleteSource.CustomSource
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtId.Text.Length < 1 Or TxtNombre.Text.Length < 1 Or TxtTelefono.Text.Length < 1 Or TxtCelular.Text.Length < 1 Or CombEsp.SelectedIndex = -1 Then
            If TxtId.Text.Length < 1 Then
                VId.Text = "*Debe ingresar un dato."
            End If
            If TxtNombre.Text.Length < 1 Then
                VNombre.Text = "*Debe ingresar un dato."
            End If
            If TxtTelefono.Text.Length < 1 Then
                VTelefono.Text = "*Debe ingresar un dato."
            End If
            If TxtCelular.Text.Length < 1 Then
                VCelular.Text = "*Debe ingresar un dato."
            End If
            If CombEsp.SelectedIndex < 0 Then
                VEspecialidad.Text = "*Debe ingresar un dato."
            End If
        Else
            Try
                con.Open()
                bs.EndEdit()
                Dim Comando2 As New SqlCommand("insert into Dentista values('" & TxtId.Text & "','" & TxtNombre.Text & "','" & TxtTelefono.Text & "','" & TxtCelular.Text & "','" & CombEsp.SelectedItem & "')", con)
                Comando2.ExecuteNonQuery()
                'Para que agregue ahi
                comando.Connection = con
                comando.CommandText = "SELECT distinct * FROM Dentista where idDentista='" & TxtId.Text & "'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "Dentista")
                bs.DataSource = ds
                bs.DataMember = "Dentista"
                'BtnEliminar.Enabled = True
                'Filtro.Visible = True
                'BtnNuevo.Visible = True
                'BtnAgregar.Visible = False
                'Detalles.Visible = False
                'TxtFiltro.Enabled = True
                'CbFiltro.Enabled = True
                TxtId.Enabled = False
                TxtNombre.Enabled = False
                TxtTelefono.Enabled = False
                TxtCelular.Enabled = False
                CombEsp.Enabled = False
                Button1.Enabled = True
                TxtFiltro.AutoCompleteCustomSource = IdDent()
                TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
                TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextName.AutoCompleteCustomSource = NomDent()
                TextName.AutoCompleteMode = AutoCompleteMode.Suggest
                TextName.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextEspec.AutoCompleteCustomSource = EspDent()
                TextEspec.AutoCompleteMode = AutoCompleteMode.Suggest
                TextEspec.AutoCompleteSource = AutoCompleteSource.CustomSource
                MsgBox("Dato Almacenado con éxito")
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub TxtCelular_TextChanged(sender As Object, e As EventArgs) Handles TxtCelular.TextChanged
        Dim d1, pattern As String
        d1 = TxtCelular.Text
        pattern = "^[0-9]{0,25}$"
        If Regex.IsMatch(d1, pattern) Then
            VCelular.Text = ""
        Else
            If TxtCelular.Text.Length > 0 Then
                TxtCelular.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                TxtCelular.Select(TxtCelular.Text.Length, 0)
            End If
            VCelular.Text = "*Ingrese sólo números, máximo 25."
        End If
    End Sub
    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        Dim d1, pattern As String
        d1 = TxtNombre.Text
        pattern = "^([A-Za-záéíóúü]( ?)){0,50}$"
        If Regex.IsMatch(d1, pattern) Then
            VNombre.Text = ""
        Else
            If TxtNombre.Text.Length > 0 Then
                TxtNombre.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                TxtNombre.Select(TxtNombre.Text.Length, 0)
            End If
            VNombre.Text = "*Ingrese sólo letras, máximo 50."
        End If
    End Sub
    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged
        Dim d1, pattern As String
        d1 = TxtId.Text
        pattern = "^[0-9]{0,5}$"
        If Regex.IsMatch(d1, pattern) Then
            VId.Text = ""
        Else
            If TxtId.Text.Length > 0 Then
                TxtId.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                TxtId.Select(TxtId.Text.Length, 0)
            End If
            VId.Text = "*Ingrese sólo números, máximo 5."
        End If
    End Sub
    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
        Dim d1, pattern As String
        d1 = TxtTelefono.Text
        pattern = "^[0-9]{0,25}$"
        If Regex.IsMatch(d1, pattern) Then
            VTelefono.Text = ""
        Else
            If TxtTelefono.Text.Length > 0 Then
                TxtTelefono.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                TxtTelefono.Select(TxtTelefono.Text.Length, 0)
            End If
            VTelefono.Text = "*Ingrese sólo números, máximo 25."
        End If
    End Sub

    Public Function IdDent() As AutoCompleteStringCollection
        Dim dt As DataTable = Dent()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("IdDentista")))
        Next
        Return coleccion
    End Function
    Public Function NomDent() As AutoCompleteStringCollection
        Dim dt As DataTable = Dent()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("NombreDentista")))
        Next
        Return coleccion
    End Function
    Public Function EspDent() As AutoCompleteStringCollection
        Dim dt As DataTable = Dent()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("EspecialidadDentista")))
        Next
        Return coleccion
    End Function
    Public Function Dent() As DataTable
        Dim dt As New DataTable()
        Dim Consulta As String = "SELECT * FROM Dentista"
        Dim comando As New SqlCommand(Consulta, con)
        Dim adap As New SqlDataAdapter(comando)
        adap.Fill(dt)
        Return dt
    End Function

    Private Sub CbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbFiltro.SelectedIndexChanged
        If CbFiltro.SelectedIndex = 0 Then
            TxtFiltro.Visible = True
            TextName.Visible = False
            TextName.Text = ""
            TextEspec.Visible = False
            TextEspec.Text = ""
        ElseIf CbFiltro.SelectedIndex = 1 Then
            TxtFiltro.Visible = False
            TxtFiltro.Text = ""
            TextName.Visible = True
            TextEspec.Visible = False
            TextEspec.Text = ""
        ElseIf CbFiltro.SelectedIndex = 2 Then
            TxtFiltro.Visible = False
            TxtFiltro.Text = ""
            TextName.Visible = False
            TextName.Text = ""
            TextEspec.Visible = True
        End If
    End Sub

    Private Sub TextName_TextChanged(sender As Object, e As EventArgs) Handles TextName.TextChanged
        Try
            If TextName.Text.Length > 0 Then
                con.Open()
                comando.Connection = con
                comando.CommandText = "SELECT * FROM Dentista where NombreDentista like '%" & TextName.Text & "%'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "DENTISTA")
                bs.DataSource = ds
                bs.DataMember = "DENTISTA"
                Dim a As New SqlCommand("select idDentista from Dentista where NombreDentista='" & TextName.Text & "'", con)
                TxtId.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT NombreDentista FROM Dentista where NombreDentista='" & TextName.Text & "'", con)
                TxtNombre.Text = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT TelefonoDentista FROM Dentista where NombreDentista='" & TextName.Text & "'", con)
                TxtTelefono.Text = c.ExecuteScalar
                Dim d As New SqlCommand("SELECT CelularDentista FROM Dentista where NombreDentista='" & TextName.Text & "'", con)
                TxtCelular.Text = d.ExecuteScalar
                Dim ee As New SqlCommand("SELECT EspecialidadDentista FROM Dentista where NombreDentista='" & TextName.Text & "'", con)
                CombEsp.SelectedItem = ee.ExecuteScalar
                con.Close()
                If TxtId.Text.Length > 0 Then
                    Detalles.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                    Button1.Enabled = False
                End If
                If TxtId.Text.Length = 0 Then
                    Detalles.Visible = False
                    BtnModificar.Visible = False
                    BtnEliminar.Visible = False
                    Button1.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub TextEspec_TextChanged(sender As Object, e As EventArgs) Handles TextEspec.TextChanged
        Try
            If TextEspec.Text.Length > 0 Then
                con.Open()
                comando.Connection = con
                comando.CommandText = "SELECT * FROM Dentista where EspecialidadDentista like '%" & TextEspec.Text & "%'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "DENTISTA")
                bs.DataSource = ds
                bs.DataMember = "DENTISTA"
                Dim a As New SqlCommand("select idDentista from Dentista where EspecialidadDentista='" & TextEspec.Text & "'", con)
                TxtId.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT NombreDentista FROM Dentista where EspecialidadDentista='" & TextEspec.Text & "'", con)
                TxtNombre.Text = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT TelefonoDentista FROM Dentista where EspecialidadDentista='" & TextEspec.Text & "'", con)
                TxtTelefono.Text = c.ExecuteScalar
                Dim d As New SqlCommand("SELECT CelularDentista FROM Dentista where EspecialidadDentista='" & TextEspec.Text & "'", con)
                TxtCelular.Text = d.ExecuteScalar
                Dim ee As New SqlCommand("SELECT EspecialidadDentista FROM Dentista where EspecialidadDentista='" & TextEspec.Text & "'", con)
                CombEsp.SelectedItem = ee.ExecuteScalar
                con.Close()
                If TxtId.Text.Length > 0 Then
                    Detalles.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                    Button1.Enabled = False
                End If
                If TxtId.Text.Length = 0 Then
                    Detalles.Visible = False
                    BtnModificar.Visible = False
                    BtnEliminar.Visible = False
                    Button1.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        BtnEliminar.Enabled = True
        BtnActualizar.Visible = False
        Filtro.Visible = True
        BtnNuevo.Visible = True
        BtnAgregar.Visible = False
        Detalles.Visible = False
        TxtFiltro.Enabled = True
        CbFiltro.Enabled = True
        Dim myForm As New Horario()
        myForm.Show()
        myForm.TxtNombre.Text = TxtNombre.Text
    End Sub
End Class