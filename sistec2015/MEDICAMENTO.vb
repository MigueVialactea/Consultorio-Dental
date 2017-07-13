Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class MEDICAMENTO
    Dim con As New SqlConnection
    Dim comando As New SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim ds As New DataSet
    Dim bs As New BindingSource
    Private Sub MEDICAMENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = url
        Try
            con.Open()
            Me.CenterToScreen()
            comando.Connection = con
            comando.CommandText = "SELECT * FROM Medicamento"
            adaptador.SelectCommand = comando
            adaptador.Fill(ds, "Medicamento")
            bs.DataSource = ds
            bs.DataMember = "Medicamento"
            TxtFiltro.AutoCompleteCustomSource = IdMed()
            TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
            TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextFPresentacion.AutoCompleteCustomSource = PreMed()
            TextFPresentacion.AutoCompleteMode = AutoCompleteMode.Suggest
            TextFPresentacion.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextBNombre.AutoCompleteCustomSource = NomMed()
            TextBNombre.AutoCompleteMode = AutoCompleteMode.Suggest
            TextBNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextFClasificacion.AutoCompleteCustomSource = ClaMed()
            TextFClasificacion.AutoCompleteMode = AutoCompleteMode.Suggest
            TextFClasificacion.AutoCompleteSource = AutoCompleteSource.CustomSource
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
                comando.CommandText = "SELECT * FROM Medicamento where IdMedicamento like '%" & TxtFiltro.Text & "%'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "MEDICAMENTO")
                bs.DataSource = ds
                bs.DataMember = "MEDICAMENTO"
                Dim a As New SqlCommand("select IdMedicamento from MEDICAMENTO where IdMedicamento='" & TxtFiltro.Text & "'", con)
                TxtMedicamento.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT NombreMedicamento FROM MEDICAMENTO where IdMedicamento='" & TxtFiltro.Text & "'", con)
                TxtNombre.Text = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT ClasificacionMedicamento FROM MEDICAMENTO where IdMedicamento='" & TxtFiltro.Text & "'", con)
                CbClasificacion.SelectedItem = c.ExecuteScalar
                Dim d As New SqlCommand("SELECT PresentacionMedicamento FROM MEDICAMENTO where IdMedicamento='" & TxtFiltro.Text & "'", con)
                CbPresentacion.SelectedItem = d.ExecuteScalar
                con.Close()
                If TxtMedicamento.Text.Length > 0 Then
                    Detalles.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                End If
                If TxtMedicamento.Text.Length = 0 Then
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
            Dim Aa As New SqlCommand("select max(IdMedicamento)+1 from Medicamento", con)
            TxtMedicamento.Text = Aa.ExecuteScalar.ToString
            Filtro.Visible = False
            BtnAgregar.Visible = True
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnModificar.Visible = False
            BtnNuevo.Visible = False
            Detalles.Visible = True
            BtnAgregar.Enabled = True
            TxtMedicamento.Enabled = False
            TxtNombre.Enabled = True
            CbClasificacion.Enabled = True
            CbPresentacion.Enabled = True
            TxtNombre.Text = ""
            CbClasificacion.SelectedIndex = -1
            CbPresentacion.SelectedIndex = -1
            TxtFiltro.Text = ""
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtMedicamento.Text.Length < 1 Then
            VId.Text = "*Debe seleccionar un Medicamento."
        Else
            Try
                con.Open()
                If MessageBox.Show("¿En realidad desea borrar el registro?", "My Application",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                 = DialogResult.Yes Then
                    Dim Comando2 As New SqlCommand("delete from Medicamento where IdMedicamento='" & TxtMedicamento.Text & "'", con)
                    Comando2.ExecuteNonQuery()
                    bs.RemoveCurrent()
                    MsgBox("Registro eliminado satisfactoriamente")
                    TxtFiltro.Text = ""
                    Detalles.Visible = False
                    BtnModificar.Visible = False
                    BtnEliminar.Visible = False
                    TxtMedicamento.Text = ""
                    TxtNombre.Text = ""
                    CbClasificacion.SelectedIndex = -1
                    CbPresentacion.SelectedIndex = -1
                    TxtFiltro.AutoCompleteCustomSource = IdMed()
                    TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
                    TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
                    TextFPresentacion.AutoCompleteCustomSource = PreMed()
                    TextFPresentacion.AutoCompleteMode = AutoCompleteMode.Suggest
                    TextFPresentacion.AutoCompleteSource = AutoCompleteSource.CustomSource
                    TextBNombre.AutoCompleteCustomSource = NomMed()
                    TextBNombre.AutoCompleteMode = AutoCompleteMode.Suggest
                    TextBNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
                    TextFClasificacion.AutoCompleteCustomSource = ClaMed()
                    TextFClasificacion.AutoCompleteMode = AutoCompleteMode.Suggest
                    TextFClasificacion.AutoCompleteSource = AutoCompleteSource.CustomSource
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

            CbClasificacion.Enabled = True
            TxtNombre.Enabled = True
            CbPresentacion.Enabled = True
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
        If TxtMedicamento.Text.Length < 1 Or TxtNombre.Text.Length < 1 Or CbClasificacion.SelectedIndex = -1 Or CbPresentacion.SelectedIndex = -1 Then
            If TxtMedicamento.Text.Length < 1 Then
                VId.Text = "*Debe seleccionar un dato."
            End If
            If TxtNombre.Text.Length < 1 Then
                VNombre.Text = "*Debe ingresar un dato."
            End If
            If CbClasificacion.SelectedIndex < 0 Then
                VClas.Text = "*Debe ingresar un dato."
            End If
            If CbPresentacion.SelectedIndex < 0 Then
                VPres.Text = "*Debe ingresar un dato."
            End If
        Else
            Try
                con.Open()
                Dim Comando2 As New SqlCommand
                Comando2.Connection = con
                Comando2.CommandText = "update Medicamento set NombreMedicamento='" & TxtNombre.Text & "' where IdMedicamento='" & TxtMedicamento.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Medicamento set ClasificacionMedicamento='" & CbClasificacion.SelectedItem & "' where IdMedicamento='" & TxtMedicamento.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Medicamento set PresentacionMedicamento='" & CbPresentacion.SelectedItem & "' where IdMedicamento='" & TxtMedicamento.Text & "'"
                Comando2.ExecuteNonQuery()
                MsgBox("Edición realizada con éxito")
                TxtFiltro.Text = ""
                Detalles.Visible = False
                Filtro.Visible = True
                BtnEliminar.Enabled = True
                BtnModificar.Enabled = True
                BtnAgregar.Enabled = False
                BtnActualizar.Enabled = False
                BtnActualizar.Visible = False
                BtnNuevo.Visible = True
                BtnNuevo.Enabled = True
                TxtMedicamento.Enabled = False
                TxtNombre.Enabled = False
                CbPresentacion.Enabled = False
                CbClasificacion.Enabled = False
                TxtFiltro.AutoCompleteCustomSource = IdMed()
                TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
                TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextFPresentacion.AutoCompleteCustomSource = PreMed()
                TextFPresentacion.AutoCompleteMode = AutoCompleteMode.Suggest
                TextFPresentacion.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextBNombre.AutoCompleteCustomSource = NomMed()
                TextBNombre.AutoCompleteMode = AutoCompleteMode.Suggest
                TextBNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextFClasificacion.AutoCompleteCustomSource = ClaMed()
                TextFClasificacion.AutoCompleteMode = AutoCompleteMode.Suggest
                TextFClasificacion.AutoCompleteSource = AutoCompleteSource.CustomSource
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtMedicamento.Text.Length < 1 Or TxtNombre.Text.Length < 1 Or CbClasificacion.SelectedIndex = -1 Or CbPresentacion.SelectedIndex = -1 Then
            If TxtMedicamento.Text.Length < 1 Then
                VId.Text = "*Debe ingresar un dato."
            End If
            If TxtNombre.Text.Length < 1 Then
                VNombre.Text = "*Debe ingresar un dato."
            End If
            If CbClasificacion.SelectedIndex < 0 Then
                VClas.Text = "*Debe ingresar un dato."
            End If
            If CbPresentacion.SelectedIndex < 0 Then
                VPres.Text = "*Debe ingresar un dato."
            End If
        Else
            Try
                con.Open()
                bs.EndEdit()
                Dim Comando2 As New SqlCommand("insert into Medicamento values('" & TxtMedicamento.Text & "','" & TxtNombre.Text & "','" & CbClasificacion.SelectedItem & "','" & CbPresentacion.SelectedItem & "')", con)
                Comando2.ExecuteNonQuery()
                'Para que agregue ahi
                comando.Connection = con
                comando.CommandText = "SELECT distinct * FROM Medicamento where idMedicamento='" & TxtMedicamento.Text & "'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "Medicamento")
                bs.DataSource = ds
                bs.DataMember = "Medicamento"
                BtnEliminar.Enabled = True
                Filtro.Visible = True
                BtnNuevo.Visible = True
                BtnAgregar.Visible = False
                Detalles.Visible = False
                TxtFiltro.Enabled = True
                TxtMedicamento.Enabled = False
                TxtNombre.Enabled = False
                CbPresentacion.Enabled = False
                CbClasificacion.Enabled = False
                MsgBox("Dato Almacenado con éxito")
                TxtFiltro.AutoCompleteCustomSource = IdMed()
                TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
                TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextFPresentacion.AutoCompleteCustomSource = PreMed()
                TextFPresentacion.AutoCompleteMode = AutoCompleteMode.Suggest
                TextFPresentacion.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextBNombre.AutoCompleteCustomSource = NomMed()
                TextBNombre.AutoCompleteMode = AutoCompleteMode.Suggest
                TextBNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
                TextFClasificacion.AutoCompleteCustomSource = ClaMed()
                TextFClasificacion.AutoCompleteMode = AutoCompleteMode.Suggest
                TextFClasificacion.AutoCompleteSource = AutoCompleteSource.CustomSource
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
                TxtNombre.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                TxtNombre.Select(TxtNombre.Text.Length, 0)
            End If
            VNombre.Text = "*Ingrese sólo letras, máximo 40."
        End If
    End Sub
    Private Sub TxtMedicamento_TextChanged(sender As Object, e As EventArgs) Handles TxtMedicamento.TextChanged
        Dim d1, pattern As String
        d1 = TxtMedicamento.Text
        pattern = "^[0-9]{0,5}$"
        If Regex.IsMatch(d1, pattern) Then
            VId.Text = ""
        Else
            If TxtMedicamento.Text.Length > 0 Then
                TxtMedicamento.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                TxtMedicamento.Select(TxtMedicamento.Text.Length, 0)
            End If
            VId.Text = "*Ingrese sólo números, máximo 5."
        End If
    End Sub

    Private Sub CbClasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbClasificacion.SelectedIndexChanged
        If CbClasificacion.SelectedIndex <> -1 Then
            VClas.Text = ""
        End If
    End Sub

    Private Sub CbPresentacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPresentacion.SelectedIndexChanged
        If CbPresentacion.SelectedIndex <> -1 Then
            VPres.Text = ""
        End If
    End Sub

    Public Function IdMed() As AutoCompleteStringCollection
        Dim dt As DataTable = Med()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("IdMedicamento")))
        Next
        Return coleccion
    End Function
    Public Function NomMed() As AutoCompleteStringCollection
        Dim dt As DataTable = Med()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("NombreMedicamento")))
        Next
        Return coleccion
    End Function
    Public Function PreMed() As AutoCompleteStringCollection
        Dim dt As DataTable = Med()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("PresentacionMedicamento")))
        Next
        Return coleccion
    End Function
    Public Function ClaMed() As AutoCompleteStringCollection
        Dim dt As DataTable = Med()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("ClasificacionMedicamento")))
        Next
        Return coleccion
    End Function
    Public Function Med() As DataTable
        Dim dt As New DataTable()
        Dim Consulta As String = "SELECT * FROM Medicamento"
        Dim comando As New SqlCommand(Consulta, con)
        Dim adap As New SqlDataAdapter(comando)
        adap.Fill(dt)
        Return dt
    End Function

    Private Sub TextBNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBNombre.TextChanged
        Try
            If TextBNombre.Text.Length > 0 Then
                con.Open()
                comando.Connection = con
                comando.CommandText = "SELECT * FROM Medicamento where NombreMedicamento like '%" & TextBNombre.Text & "%'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "MEDICAMENTO")
                bs.DataSource = ds
                bs.DataMember = "MEDICAMENTO"
                Dim a As New SqlCommand("select IdMedicamento from MEDICAMENTO where NombreMedicamento='" & TextBNombre.Text & "'", con)
                TxtMedicamento.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT NombreMedicamento FROM MEDICAMENTO where NombreMedicamento='" & TextBNombre.Text & "'", con)
                TxtNombre.Text = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT ClasificacionMedicamento FROM MEDICAMENTO where NombreMedicamento='" & TextBNombre.Text & "'", con)
                CbClasificacion.SelectedItem = c.ExecuteScalar
                Dim d As New SqlCommand("SELECT PresentacionMedicamento FROM MEDICAMENTO where NombreMedicamento='" & TextBNombre.Text & "'", con)
                CbPresentacion.SelectedItem = d.ExecuteScalar
                con.Close()
                If TxtMedicamento.Text.Length > 0 Then
                    Detalles.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                End If
                If TxtMedicamento.Text.Length = 0 Then
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
            TextBNombre.Visible = False
            TextBNombre.Text = ""
            TextFPresentacion.Visible = False
            TextFPresentacion.Text = ""
            TextFClasificacion.Visible = False
            TextFClasificacion.Text = ""
        ElseIf CbFiltro.SelectedIndex = 1 Then
            TxtFiltro.Visible = False
            TxtFiltro.Text = ""
            TextBNombre.Visible = True
            TextFPresentacion.Visible = False
            TextFPresentacion.Text = ""
            TextFClasificacion.Visible = False
            TextFClasificacion.Text = ""
        ElseIf CbFiltro.SelectedIndex = 3 Then
            TxtFiltro.Visible = False
            TxtFiltro.Text = ""
            TextBNombre.Visible = False
            TextBNombre.Text = ""
            TextFPresentacion.Visible = True
            TextFClasificacion.Visible = False
            TextFClasificacion.Text = ""
        ElseIf CbFiltro.SelectedIndex = 2 Then
            TxtFiltro.Visible = False
            TxtFiltro.Text = ""
            TextFClasificacion.Visible = True
            TextFPresentacion.Visible = False
            TextFPresentacion.Text = ""
            TextBNombre.Visible = False
            TextBNombre.Text = ""
        End If
    End Sub

    Private Sub TextFPresentacion_TextChanged(sender As Object, e As EventArgs) Handles TextFPresentacion.TextChanged
        Try
            If TextFPresentacion.Text.Length > 0 Then
                con.Open()
                comando.Connection = con
                comando.CommandText = "SELECT * FROM Medicamento where PresentacionMedicamento like '%" & TextFPresentacion.Text & "%'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "MEDICAMENTO")
                bs.DataSource = ds
                bs.DataMember = "MEDICAMENTO"
                Dim a As New SqlCommand("select IdMedicamento from MEDICAMENTO where PresentacionMedicamento='" & TextFPresentacion.Text & "'", con)
                TxtMedicamento.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT NombreMedicamento FROM MEDICAMENTO where PresentacionMedicamento='" & TextFPresentacion.Text & "'", con)
                TxtNombre.Text = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT ClasificacionMedicamento FROM MEDICAMENTO where PresentacionMedicamento='" & TextFPresentacion.Text & "'", con)
                CbClasificacion.SelectedItem = c.ExecuteScalar
                Dim d As New SqlCommand("SELECT PresentacionMedicamento FROM MEDICAMENTO where PresentacionMedicamento='" & TextFPresentacion.Text & "'", con)
                CbPresentacion.SelectedItem = d.ExecuteScalar
                con.Close()
                If TxtMedicamento.Text.Length > 0 Then
                    Detalles.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                End If
                If TxtMedicamento.Text.Length = 0 Then
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

    Private Sub TextFClasificacion_TextChanged(sender As Object, e As EventArgs) Handles TextFClasificacion.TextChanged
        Try
            If TextFClasificacion.Text.Length > 0 Then
                con.Open()
                comando.Connection = con
                comando.CommandText = "SELECT * FROM Medicamento where ClasificacionMedicamento like '%" & TextFClasificacion.Text & "%'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "MEDICAMENTO")
                bs.DataSource = ds
                bs.DataMember = "MEDICAMENTO"
                Dim a As New SqlCommand("select IdMedicamento from MEDICAMENTO where ClasificacionMedicamento='" & TextFClasificacion.Text & "'", con)
                TxtMedicamento.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT NombreMedicamento FROM MEDICAMENTO where ClasificacionMedicamento='" & TextFClasificacion.Text & "'", con)
                TxtNombre.Text = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT ClasificacionMedicamento FROM MEDICAMENTO where ClasificacionMedicamento='" & TextFClasificacion.Text & "'", con)
                CbClasificacion.SelectedItem = c.ExecuteScalar
                Dim d As New SqlCommand("SELECT PresentacionMedicamento FROM MEDICAMENTO where ClasificacionMedicamento='" & TextFClasificacion.Text & "'", con)
                CbPresentacion.SelectedItem = d.ExecuteScalar
                con.Close()
                If TxtMedicamento.Text.Length > 0 Then
                    Detalles.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                End If
                If TxtMedicamento.Text.Length = 0 Then
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
End Class