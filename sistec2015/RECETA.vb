Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class RECETA
    Dim con As New SqlConnection
    Dim comando As New SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim ds As New DataSet
    Dim bs As New BindingSource
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click
        bs.MoveFirst()
        Try
            con.Open()
            Dim D1, D2, D3, D4, D5, D6 As String
            D1 = DGV.CurrentRow.Cells(0).EditedFormattedValue.ToString
            D2 = DGV.CurrentRow.Cells(1).EditedFormattedValue.ToString
            D3 = DGV.CurrentRow.Cells(2).EditedFormattedValue.ToString
            D4 = DGV.CurrentRow.Cells(3).EditedFormattedValue.ToString
            D5 = DGV.CurrentRow.Cells(4).EditedFormattedValue.ToString
            D6 = DGV.CurrentRow.Cells(5).EditedFormattedValue.ToString
            TxtIdReceta.Text = D1
            TxtIdMedicamento.Text = D2
            CbHoras.SelectedItem = D3
            CbDias.SelectedItem = D4
            CbDosis.SelectedItem = D5
            CbVia.SelectedItem = D6
            Dim c As New SqlCommand("select NombreMedicamento from Medicamento where IdMedicamento='" & TxtIdMedicamento.Text & "'", con)
            CbIdMedicamento.SelectedItem = c.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click
        bs.MoveLast()
        Try
            con.Open()
            Dim D1, D2, D3, D4, D5, D6 As String
            D1 = DGV.CurrentRow.Cells(0).EditedFormattedValue.ToString
            D2 = DGV.CurrentRow.Cells(1).EditedFormattedValue.ToString
            D3 = DGV.CurrentRow.Cells(2).EditedFormattedValue.ToString
            D4 = DGV.CurrentRow.Cells(3).EditedFormattedValue.ToString
            D5 = DGV.CurrentRow.Cells(4).EditedFormattedValue.ToString
            D6 = DGV.CurrentRow.Cells(5).EditedFormattedValue.ToString
            TxtIdReceta.Text = D1
            TxtIdMedicamento.Text = D2
            CbHoras.SelectedItem = D3
            CbDias.SelectedItem = D4
            CbDosis.SelectedItem = D5
            CbVia.SelectedItem = D6
            Dim c As New SqlCommand("select NombreMedicamento from Medicamento where IdMedicamento='" & TxtIdMedicamento.Text & "'", con)
            CbIdMedicamento.SelectedItem = c.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnArriba_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        bs.MovePrevious()
        Try
            con.Open()
            Dim D1, D2, D3, D4, D5, D6 As String
            D1 = DGV.CurrentRow.Cells(0).EditedFormattedValue.ToString
            D2 = DGV.CurrentRow.Cells(1).EditedFormattedValue.ToString
            D3 = DGV.CurrentRow.Cells(2).EditedFormattedValue.ToString
            D4 = DGV.CurrentRow.Cells(3).EditedFormattedValue.ToString
            D5 = DGV.CurrentRow.Cells(4).EditedFormattedValue.ToString
            D6 = DGV.CurrentRow.Cells(5).EditedFormattedValue.ToString
            TxtIdReceta.Text = D1
            TxtIdMedicamento.Text = D2
            CbHoras.SelectedItem = D3
            CbDias.SelectedItem = D4
            CbDosis.SelectedItem = D5
            CbVia.SelectedItem = D6
            Dim c As New SqlCommand("select NombreMedicamento from Medicamento where IdMedicamento='" & TxtIdMedicamento.Text & "'", con)
            CbIdMedicamento.SelectedItem = c.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnAbajo_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        bs.MoveNext()
        Try
            con.Open()
            Dim D1, D2, D3, D4, D5, D6 As String
            D1 = DGV.CurrentRow.Cells(0).EditedFormattedValue.ToString
            D2 = DGV.CurrentRow.Cells(1).EditedFormattedValue.ToString
            D3 = DGV.CurrentRow.Cells(2).EditedFormattedValue.ToString
            D4 = DGV.CurrentRow.Cells(3).EditedFormattedValue.ToString
            D5 = DGV.CurrentRow.Cells(4).EditedFormattedValue.ToString
            D6 = DGV.CurrentRow.Cells(5).EditedFormattedValue.ToString
            TxtIdReceta.Text = D1
            TxtIdMedicamento.Text = D2
            CbHoras.SelectedItem = D3
            CbDias.SelectedItem = D4
            CbDosis.SelectedItem = D5
            CbVia.SelectedItem = D6
            Dim c As New SqlCommand("select NombreMedicamento from Medicamento where IdMedicamento='" & TxtIdMedicamento.Text & "'", con)
            CbIdMedicamento.SelectedItem = c.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub RECETA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = url
        Try
            con.Open()
            Me.CenterToScreen()
            Dim cd As String = "SELECT DISTINCT NombreMedicamento FROM Medicamento"
            Dim cmd As New SqlCommand(cd, con)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                For i = 0 To dt.Rows.Count - 1
                    CbIdMedicamento.Items.Add(dt.Rows(i).Item("NombreMedicamento"))
                Next
            End If

            TxtFiltro.AutoCompleteCustomSource = IdRec()
            TxtFiltro.AutoCompleteMode = AutoCompleteMode.Suggest
            TxtFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
            FrmMenu.Show()
        End Try
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtIdReceta.Text.Length < 1 Or CbDosis.SelectedIndex < 0 Or TxtIdMedicamento.Text.Length < 0 Or CbDias.SelectedIndex < 0 Or CbHoras.SelectedIndex < 0 Or CbVia.SelectedIndex = -1 Then
            If TxtIdReceta.Text.Length < 1 Then
                VId.Text = "*Debe seleccionar un dato."
            End If
            If CbDosis.SelectedIndex < 0 Then
                VDosis.Text = "*Debe ingresar un dato."
            End If
            If TxtIdMedicamento.Text.Length < 1 Then
                VIdM.Text = "*Debe ingresar un dato."
            Else
                VIdM.Text = ""
            End If
            If CbDias.SelectedIndex < 0 Then
                VDias.Text = "*Debe ingresar un dato."
            End If
            If CbHoras.SelectedIndex < 0 Then
                VHoras.Text = "*Debe ingresar un dato."
            End If
            If CbVia.SelectedIndex < 0 Then
                VVia.Text = "*Debe ingresar un dato."
            End If
        Else
            Try
                con.Open()
                Dim Comando2 As New SqlCommand
                Comando2.Connection = con
                Comando2.CommandText = "update Receta set IdMedicamento='" & TxtIdMedicamento.Text & "' where IdReceta ='" & TxtIdReceta.Text & "' and IdMedicamento='" & TxtIdMedicamento.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Receta set HorasReceta='" & CbHoras.SelectedItem & "' where IdReceta ='" & TxtIdReceta.Text & "' and IdMedicamento='" & TxtIdMedicamento.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Receta set DiasReceta='" & CbDias.SelectedItem & "' where IdReceta ='" & TxtIdReceta.Text & "' and IdMedicamento='" & TxtIdMedicamento.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Receta set DosisReceta='" & CbDosis.SelectedItem & "' where IdReceta ='" & TxtIdReceta.Text & "' and IdMedicamento='" & TxtIdMedicamento.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Receta set ViaReceta='" & CbVia.SelectedItem & "' where IdReceta ='" & TxtIdReceta.Text & "' and IdMedicamento='" & TxtIdMedicamento.Text & "'"
                Comando2.ExecuteNonQuery()
                MsgBox("Edición realizada con éxito")
                TxtFiltro.Text = ""
                Detalles.Visible = False
                BtnActualizar.Visible = False
                DGV.Visible = False
                Ir.Visible = False
                Filtro.Visible = True
                CbDias.Enabled = False
                CbDosis.Enabled = False
                CbHoras.Enabled = False
                CbIdMedicamento.Enabled = False
                BtnNuevo.Visible = True
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtIdReceta.Text.Length < 1 Or CbDosis.SelectedIndex < 0 Or TxtIdMedicamento.Text.Length < 0 Or CbDias.SelectedIndex < 0 Or CbHoras.SelectedIndex < 0 Or CbVia.SelectedIndex = -1 Then
            If TxtIdReceta.Text.Length < 1 Then
                VId.Text = "*Debe ingresar un dato."
            End If
            If CbDosis.SelectedIndex < 0 Then
                VDosis.Text = "*Debe ingresar un dato."
            End If
            If TxtIdMedicamento.Text.Length < 1 Then
                VIdM.Text = "*Debe ingresar un dato."
            Else
                VIdM.Text = ""
            End If
            If CbDias.SelectedIndex < 0 Then
                VDias.Text = "*Debe ingresar un dato."
            End If
            If CbHoras.SelectedIndex < 0 Then
                VHoras.Text = "*Debe ingresar un dato."
            End If
            If CbVia.SelectedIndex < 0 Then
                VVia.Text = "*Debe ingresar un dato."
            End If
        Else
            Try
                con.Open()
                bs.EndEdit()
                Dim Comando2 As New SqlCommand("insert into Receta values('" & TxtIdReceta.Text & "','" & TxtIdMedicamento.Text & "','" & CbHoras.SelectedItem & "','" & CbDias.SelectedItem & "','" & CbDosis.SelectedItem & "','" & CbVia.SelectedItem & "')", con)
                Comando2.ExecuteNonQuery()
                comando.Connection = con
                comando.CommandText = "SELECT distinct * FROM Receta where idReceta='" & TxtIdReceta.Text & "' and idMedicamento='" & TxtIdMedicamento.Text & "'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "Receta")
                bs.DataSource = ds
                bs.DataMember = "Receta"
                If MessageBox.Show("Dato Almacenado con éxito, ¿Desea agregar otro medicamento a la receta?", "My Application",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                 = DialogResult.Yes Then
                    TxtIdReceta.Enabled = False
                    TxtFiltro.Text = ""
                    TxtIdMedicamento.Text = ""
                    CbIdMedicamento.SelectedIndex = -1
                    CbDias.SelectedIndex = -1
                    CbHoras.SelectedIndex = -1
                    CbDosis.SelectedIndex = -1
                    CbVia.SelectedIndex = -1
                Else
                    Filtro.Visible = True
                    BtnNuevo.Visible = True
                    BtnAgregar.Visible = False
                    Detalles.Visible = False
                    TxtIdReceta.Enabled = False
                    CbDias.Enabled = False
                    CbDosis.Enabled = False
                    CbHoras.Enabled = False
                    CbIdMedicamento.Enabled = False
                    CbVia.Enabled = False
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            con.Open()
            Filtro.Visible = False
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnModificar.Visible = False
            BtnNuevo.Visible = False
            Detalles.Visible = True
            BtnAgregar.Visible = True
            TxtIdReceta.Enabled = True
            CbDias.Enabled = True
            CbDosis.Enabled = True
            CbHoras.Enabled = True
            CbIdMedicamento.Enabled = True
            CbVia.Enabled = True
            TxtFiltro.Text = ""
            TxtIdMedicamento.Text = ""
            TxtIdReceta.Text = ""
            CbIdMedicamento.SelectedIndex = -1
            CbDias.SelectedIndex = -1
            CbHoras.SelectedIndex = -1
            CbDosis.SelectedIndex = -1
            CbVia.SelectedIndex = -1
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtIdReceta.Text.Length < 1 Then
            VId.Text = "*Debe seleccionar un registro."
        Else
            Try
                con.Open()
                If MessageBox.Show("¿En realidad desea borrar el registro?", "My Application",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                 = DialogResult.Yes Then
                    Dim Comando2 As New SqlCommand("delete from Receta where IdReceta='" & TxtIdReceta.Text & "' and IdMedicamento='" & TxtIdMedicamento.Text & "'", con)
                    Comando2.ExecuteNonQuery()
                    bs.RemoveCurrent()
                    MsgBox("Registro eliminado satisfactoriamente")
                    TxtFiltro.Text = ""
                    TxtIdMedicamento.Text = ""
                    TxtIdReceta.Text = ""
                    CbDosis.SelectedIndex = -1
                    CbIdMedicamento.SelectedIndex = -1
                    CbHoras.SelectedIndex = -1
                    CbVia.SelectedIndex = -1
                    CbDias.SelectedIndex = -1
                    Detalles.Visible = False
                    BtnModificar.Visible = False
                    BtnEliminar.Visible = False
                    DGV.Visible = False
                    Ir.Visible = False
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
            CbIdMedicamento.Enabled = True
            CbDias.Enabled = True
            CbHoras.Enabled = True
            CbDosis.Enabled = True
            CbVia.Enabled = True
            BtnNuevo.Visible = False
            BtnEliminar.Visible = False
            BtnModificar.Visible = False
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub CbIdMedicamento_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbIdMedicamento.SelectionChangeCommitted
        Try
            con.Open()
            Dim c As New SqlCommand("SELECT IdMedicamento FROM Medicamento WHERE NombreMedicamento='" & CbIdMedicamento.SelectedItem & "'", con)
            TxtIdMedicamento.Text = c.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
            FrmMenu.Show()
        End Try
    End Sub
    Private Sub TxtIdReceta_TextChanged(sender As Object, e As EventArgs) Handles TxtIdReceta.TextChanged
        Dim d1, pattern As String
        d1 = TxtIdReceta.Text
        pattern = "^[0-9]{0,5}$"
        If Regex.IsMatch(d1, pattern) Then
            VId.Text = ""
        Else
            If TxtIdReceta.Text.Length > 0 Then
                TxtIdReceta.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                TxtIdReceta.Select(TxtIdReceta.Text.Length, 0)
            End If
            VId.Text = "*Ingrese sólo números, máximo 5."
        End If
    End Sub
    Private Sub CbIdMedicamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIdMedicamento.SelectedIndexChanged
        If CbIdMedicamento.SelectedIndex <> -1 Then
            VIdM.Text = ""
        End If
    End Sub
    Private Sub CbVia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVia.SelectedIndexChanged
        If CbVia.SelectedIndex <> -1 Then
            VVia.Text = ""
        End If
    End Sub
    Private Sub CbHoras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbHoras.SelectedIndexChanged
        If CbHoras.SelectedIndex <> -1 Then
            VHoras.Text = ""
        End If
    End Sub
    Private Sub CbDias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDias.SelectedIndexChanged
        If CbDias.SelectedIndex <> -1 Then
            VDias.Text = ""
        End If
    End Sub
    Private Sub CbDosis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDosis.SelectedIndexChanged
        If CbDosis.SelectedIndex <> -1 Then
            VDosis.Text = ""
        End If
    End Sub
    Public Function IdRec() As AutoCompleteStringCollection
        Dim dt As DataTable = Rec()
        Dim coleccion As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("IdReceta")))
        Next
        Return coleccion
    End Function
    Public Function Rec() As DataTable
        Dim dt As New DataTable()
        Dim Consulta As String = "SELECT * FROM Receta"
        Dim comando As New SqlCommand(Consulta, con)
        Dim adap As New SqlDataAdapter(comando)
        adap.Fill(dt)
        Return dt
    End Function
    Private Sub TxtFiltro_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltro.TextChanged
        Try
            While bs.Count > 0
                DGV.Visible = False
                Ir.Visible = False
                bs.RemoveCurrent()
            End While
            If TxtFiltro.Text.Length > 0 Then
                con.Open()
                comando.Connection = con
                comando.CommandText = "SELECT * FROM RECETA where idReceta='" & TxtFiltro.Text & "'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "RECETA")
                bs.DataSource = ds
                bs.DataMember = "RECETA"
                Dim a As New SqlCommand("select idreceta from Rec where idReceta='" & TxtFiltro.Text & "'", con)
                TxtIdReceta.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT IdMedicamento FROM Rec WHERE IdReceta='" & TxtFiltro.Text & "'", con)
                TxtIdMedicamento.Text = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT NombreMedicamento FROM Rec WHERE IdReceta='" & TxtFiltro.Text & "'", con)
                CbIdMedicamento.SelectedItem = c.ExecuteScalar
                Dim d As New SqlCommand("SELECT HorasReceta FROM Rec WHERE IdReceta='" & TxtFiltro.Text & "'", con)
                CbHoras.SelectedItem = d.ExecuteScalar
                Dim ee As New SqlCommand("SELECT DiasReceta FROM Rec WHERE IdReceta='" & TxtFiltro.Text & "'", con)
                CbDias.SelectedItem = ee.ExecuteScalar
                Dim f As New SqlCommand("SELECT DosisReceta FROM Rec WHERE IdReceta='" & TxtFiltro.Text & "'", con)
                CbDosis.SelectedItem = f.ExecuteScalar
                Dim g As New SqlCommand("SELECT ViaReceta FROM Rec WHERE IdReceta='" & TxtFiltro.Text & "'", con)
                CbVia.SelectedItem = g.ExecuteScalar
                con.Close()
                If bs.Count > 1 Then
                    DGV.Visible = True
                    DGV.DataSource = bs
                    Ir.Visible = True
                End If
                If TxtIdReceta.Text.Length > 0 Then
                    Detalles.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                End If
                If TxtIdReceta.Text.Length = 0 Then
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
    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Try
            con.Open()
            Dim D1, D2, D3, D4, D5, D6 As String
            D1 = DGV.CurrentRow.Cells(0).EditedFormattedValue.ToString
            D2 = DGV.CurrentRow.Cells(1).EditedFormattedValue.ToString
            D3 = DGV.CurrentRow.Cells(2).EditedFormattedValue.ToString
            D4 = DGV.CurrentRow.Cells(3).EditedFormattedValue.ToString
            D5 = DGV.CurrentRow.Cells(4).EditedFormattedValue.ToString
            D6 = DGV.CurrentRow.Cells(5).EditedFormattedValue.ToString
            TxtIdReceta.Text = D1
            TxtIdMedicamento.Text = D2
            CbHoras.SelectedItem = D3
            CbDias.SelectedItem = D4
            CbDosis.SelectedItem = D5
            CbVia.SelectedItem = D6
            Dim c As New SqlCommand("select NombreMedicamento from Medicamento where IdMedicamento='" & TxtIdMedicamento.Text & "'", con)
            CbIdMedicamento.SelectedItem = c.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
End Class