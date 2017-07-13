Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class REGISTRO
    Dim con As New SqlConnection
    Dim comando As New SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim ds As New DataSet
    Dim bs As New BindingSource
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click
        bs.MoveFirst()
        Try
            con.Open()
            Dim D1, D2, D3, D4, D5, D6, D7, D8, D9 As String
            D1 = DGV.CurrentRow.Cells(0).EditedFormattedValue.ToString
            D2 = DGV.CurrentRow.Cells(1).EditedFormattedValue.ToString
            D3 = DGV.CurrentRow.Cells(2).EditedFormattedValue.ToString
            D4 = DGV.CurrentRow.Cells(3).EditedFormattedValue.ToString
            D5 = DGV.CurrentRow.Cells(4).EditedFormattedValue.ToString
            D6 = DGV.CurrentRow.Cells(5).EditedFormattedValue.ToString
            D7 = DGV.CurrentRow.Cells(6).EditedFormattedValue.ToString
            D8 = DGV.CurrentRow.Cells(7).EditedFormattedValue.ToString
            D9 = DGV.CurrentRow.Cells(8).EditedFormattedValue.ToString
            TxtCita.Text = D1
            TxtIdPaciente.Text = D2
            Dim c As New SqlCommand("select NombrePaciente from Paciente where IdPaciente='" & TxtIdPaciente.Text & "'", con)
            CbIdPaciente.SelectedItem = c.ExecuteScalar
            CbReceta.SelectedItem = D3
            TxtIdDentista.Text = D4
            Dim d As New SqlCommand("select NombreDentista from Dentista where IdDentista='" & TxtIdDentista.Text & "'", con)
            CbIdDentista.SelectedItem = d.ExecuteScalar
            DtpFecha.Text = D5
            CbMin.SelectedItem = D6
            DtpProx.Value = D7
            CbMinP.SelectedItem = D8
            TxtTotal.Text = D9
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
            Dim D1, D2, D3, D4, D5, D6, D7, D8, D9 As String
            D1 = DGV.CurrentRow.Cells(0).EditedFormattedValue.ToString
            D2 = DGV.CurrentRow.Cells(1).EditedFormattedValue.ToString
            D3 = DGV.CurrentRow.Cells(2).EditedFormattedValue.ToString
            D4 = DGV.CurrentRow.Cells(3).EditedFormattedValue.ToString
            D5 = DGV.CurrentRow.Cells(4).EditedFormattedValue.ToString
            D6 = DGV.CurrentRow.Cells(5).EditedFormattedValue.ToString
            D7 = DGV.CurrentRow.Cells(6).EditedFormattedValue.ToString
            D8 = DGV.CurrentRow.Cells(7).EditedFormattedValue.ToString
            D9 = DGV.CurrentRow.Cells(8).EditedFormattedValue.ToString
            TxtCita.Text = D1
            TxtIdPaciente.Text = D2
            Dim c As New SqlCommand("select NombrePaciente from Paciente where IdPaciente='" & TxtIdPaciente.Text & "'", con)
            CbIdPaciente.SelectedItem = c.ExecuteScalar
            CbReceta.SelectedItem = D3
            TxtIdDentista.Text = D4
            Dim d As New SqlCommand("select NombreDentista from Dentista where IdDentista='" & TxtIdDentista.Text & "'", con)
            CbIdDentista.SelectedItem = d.ExecuteScalar
            'DtpFecha.Text = D5
            CbMin.SelectedItem = D6
            'DtpProx.Value = D7
            CbMinP.SelectedItem = D8
            TxtTotal.Text = D9
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
            Dim D1, D2, D3, D4, D5, D6, D7, D8, D9 As String
            D1 = DGV.CurrentRow.Cells(0).EditedFormattedValue.ToString
            D2 = DGV.CurrentRow.Cells(1).EditedFormattedValue.ToString
            D3 = DGV.CurrentRow.Cells(2).EditedFormattedValue.ToString
            D4 = DGV.CurrentRow.Cells(3).EditedFormattedValue.ToString
            D5 = DGV.CurrentRow.Cells(4).EditedFormattedValue.ToString
            D6 = DGV.CurrentRow.Cells(5).EditedFormattedValue.ToString
            D7 = DGV.CurrentRow.Cells(6).EditedFormattedValue.ToString
            D8 = DGV.CurrentRow.Cells(7).EditedFormattedValue.ToString
            D9 = DGV.CurrentRow.Cells(8).EditedFormattedValue.ToString
            TxtCita.Text = D1
            TxtIdPaciente.Text = D2
            Dim c As New SqlCommand("select NombrePaciente from Paciente where IdPaciente='" & TxtIdPaciente.Text & "'", con)
            CbIdPaciente.SelectedItem = c.ExecuteScalar
            CbReceta.SelectedItem = D3
            TxtIdDentista.Text = D4
            Dim d As New SqlCommand("select NombreDentista from Dentista where IdDentista='" & TxtIdDentista.Text & "'", con)
            CbIdDentista.SelectedItem = d.ExecuteScalar
            'DtpFecha.Text = D5
            CbMin.SelectedItem = D6
            'DtpProx.Value = D7
            CbMinP.SelectedItem = D8
            TxtTotal.Text = D9
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
            Dim D1, D2, D3, D4, D5, D6, D7, D8, D9 As String
            D1 = DGV.CurrentRow.Cells(0).EditedFormattedValue.ToString
            D2 = DGV.CurrentRow.Cells(1).EditedFormattedValue.ToString
            D3 = DGV.CurrentRow.Cells(2).EditedFormattedValue.ToString
            D4 = DGV.CurrentRow.Cells(3).EditedFormattedValue.ToString
            D5 = DGV.CurrentRow.Cells(4).EditedFormattedValue.ToString
            D6 = DGV.CurrentRow.Cells(5).EditedFormattedValue.ToString
            D7 = DGV.CurrentRow.Cells(6).EditedFormattedValue.ToString
            D8 = DGV.CurrentRow.Cells(7).EditedFormattedValue.ToString
            D9 = DGV.CurrentRow.Cells(8).EditedFormattedValue.ToString
            TxtCita.Text = D1
            TxtIdPaciente.Text = D2
            Dim c As New SqlCommand("select NombrePaciente from Paciente where IdPaciente='" & TxtIdPaciente.Text & "'", con)
            CbIdPaciente.SelectedItem = c.ExecuteScalar
            CbReceta.SelectedItem = D3
            TxtIdDentista.Text = D4
            Dim d As New SqlCommand("select NombreDentista from Dentista where IdDentista='" & TxtIdDentista.Text & "'", con)
            CbIdDentista.SelectedItem = d.ExecuteScalar
            'DtpFecha.Text = D5
            CbMin.SelectedItem = D6
            'DtpProx.Value = D7
            CbMinP.SelectedItem = D8
            TxtTotal.Text = D9
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub REGISTRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = url
        Try
            con.Open()
            Me.CenterToScreen()
            Dim cd1 As String = "SELECT DISTINCT NombreDentista FROM Dentista"
            Dim cmd1 As New SqlCommand(cd1, con)
            cmd1.CommandType = CommandType.Text
            Dim da1 As New SqlDataAdapter(cmd1)
            Dim dt1 As New DataTable
            da1.Fill(dt1)
            If dt1.Rows.Count <> 0 Then
                For i = 0 To dt1.Rows.Count - 1
                    CbIdDentista.Items.Add(dt1.Rows(i).Item("NombreDentista"))
                Next
            End If

            Dim cd2 As String = "SELECT DISTINCT IdReceta FROM Receta"
            Dim cmd2 As New SqlCommand(cd2, con)
            cmd2.CommandType = CommandType.Text
            Dim da2 As New SqlDataAdapter(cmd2)
            Dim dt2 As New DataTable
            da2.Fill(dt2)
            If dt2.Rows.Count <> 0 Then
                For i = 0 To dt2.Rows.Count - 1
                    CbReceta.Items.Add(dt2.Rows(i).Item("IdReceta"))
                Next
            End If

            Dim cd3 As String = "SELECT DISTINCT NombrePaciente FROM Paciente"
            Dim cmd3 As New SqlCommand(cd3, con)
            cmd3.CommandType = CommandType.Text
            Dim da3 As New SqlDataAdapter(cmd3)
            Dim dt3 As New DataTable
            da3.Fill(dt3)
            If dt3.Rows.Count <> 0 Then
                For i = 0 To dt3.Rows.Count - 1
                    CbIdPaciente.Items.Add(dt3.Rows(i).Item("NombrePaciente"))
                Next
            End If

            Dim cd4 As String = "SELECT DISTINCT NombreServicio FROM Servicio"
            Dim cmd4 As New SqlCommand(cd4, con)
            cmd4.CommandType = CommandType.Text
            Dim da4 As New SqlDataAdapter(cmd4)
            Dim dt4 As New DataTable
            da4.Fill(dt4)
            If dt4.Rows.Count <> 0 Then
                For i = 0 To dt4.Rows.Count - 1
                    CbServicio.Items.Add(dt4.Rows(i).Item("NombreServicio"))
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
    Private Sub CbIdPaciente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbIdPaciente.SelectionChangeCommitted
        Try
            con.Open()
            Dim c As New SqlCommand("SELECT IdPaciente FROM Paciente WHERE NombrePaciente='" & CbIdPaciente.SelectedItem & "'", con)
            TxtIdPaciente.Text = c.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub CbIdDentista_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbIdDentista.SelectionChangeCommitted
        Try
            con.Open()
            Dim c As New SqlCommand("SELECT IdDentista FROM Dentista WHERE NombreDentista='" & CbIdDentista.SelectedItem & "'", con)
            TxtIdDentista.Text = c.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtCita.Text.Length < 1 Or TxtIdPaciente.Text.Length < 1 Or TxtIdDentista.Text.Length < 1 Or TxtServicio.Text.Length < 1 Then
            If TxtCita.Text.Length < 1 Then
                VId.Text = "*Debe seleccionar un registro."
            End If
            If TxtIdPaciente.Text.Length < 1 Then
                VPaciente.Text = "*Debe ingresar un dato."
            Else
                VPaciente.Text = ""
            End If
            If TxtIdDentista.Text.Length < 1 Then
                VDentist.Text = "*Debe ingresar un dato."
            Else
                VDentist.Text = ""
            End If
            If TxtServicio.Text.Length < 1 Then
                VServicio.Text = "*Debe ingresar un dato."
            End If
        Else
            Try
                con.Open()
                Dim Comando2 As New SqlCommand
                Comando2.Connection = con
                Comando2.CommandText = "update Registro set IdPaciente='" & TxtIdPaciente.Text & "' where IdCita ='" & TxtCita.Text & "'"
                Comando2.ExecuteNonQuery()
                Dim c As New SqlCommand("select NombrePaciente from Paciente where IdPaciente='" & TxtIdPaciente.Text & "'", con)
                CbIdPaciente.SelectedItem = c.ExecuteScalar
                Comando2.CommandText = "update Registro set IdReceta='" & CbReceta.SelectedItem & "' where IdCita ='" & TxtCita.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Registro set IdDentista='" & TxtIdDentista.Text & "' where IdCita ='" & TxtCita.Text & "'"
                Comando2.ExecuteNonQuery()
                Dim d As New SqlCommand("select NombreDentista from Dentista where IdDentista='" & TxtIdDentista.Text & "'", con)
                CbIdDentista.SelectedItem = d.ExecuteScalar
                Comando2.CommandText = "update Registro set FechaCita='" & DtpFecha.Value & "' where IdCita ='" & TxtCita.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Registro set HoraCita='" & CbMin.SelectedItem & "' where IdCita ='" & TxtCita.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Registro set FechaProximaCita='" & DtpProx.Value & "' where IdCita ='" & TxtCita.Text & "'"
                Comando2.ExecuteNonQuery()
                Comando2.CommandText = "update Registro set HoraProximaCita='" & CbMinP.SelectedItem & "' where IdCita ='" & TxtCita.Text & "'"
                Comando2.ExecuteNonQuery()
                'Comando2.CommandText = "update Registro set TotalCita='0" & TxtTotal.Text & "' where IdCita ='" & TxtCita.Text & "'"
                'Comando2.ExecuteNonQuery()
                MsgBox("Edición realizada con éxito")
                TxtFiltro.Text = ""
                Datos.Visible = False
                Actual.Visible = False
                Proxima.Visible = False
                BtnActualizar.Visible = False
                DGV.Visible = False
                Ir.Visible = False
                Filtro.Visible = True
                CbIdDentista.Enabled = False
                CbIdPaciente.Enabled = False
                CbReceta.Enabled = False
                DtpFecha.Enabled = False
                DtpProx.Enabled = False
                CbMin.Enabled = False
                CbMinP.Enabled = False
                CbServicio.Enabled = False
                NumCant.Enabled = False
                BtnNuevo.Visible = True
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtCita.Text.Length < 1 Or TxtIdPaciente.Text.Length < 1 Or TxtIdDentista.Text.Length < 1 Or TxtServicio.Text.Length < 1 Then
            If TxtCita.Text.Length < 1 Then
                VId.Text = "*Debe ingresar un dato."
            End If
            If TxtIdPaciente.Text.Length < 1 Then
                VPaciente.Text = "*Debe ingresar un dato."
            Else
                VPaciente.Text = ""
            End If
            If TxtIdDentista.Text.Length < 1 Then
                VDentist.Text = "*Debe ingresar un dato."
            Else
                VDentist.Text = ""
            End If
            If TxtServicio.Text.Length < 1 Then
                VServicio.Text = "*Debe ingresar un dato."
            End If
        Else
            Try
                con.Open()
                bs.EndEdit()
                Dim Comando2 As New SqlCommand("insert into Registro values('" & TxtCita.Text & "','" & TxtIdPaciente.Text & "','" & CbReceta.SelectedItem & "','" & TxtIdDentista.Text & "','" & DtpFecha.Value & "','" & CbMin.SelectedItem & "','" & DtpProx.Value & "','" & CbMinP.SelectedItem & "',0)", con)
                Comando2.ExecuteNonQuery()
                Dim Comando3 As New SqlCommand("insert into Cita values('" & TxtCita.Text & "','" & TxtServicio.Text & "','" & NumCant.Value & "')", con)
                Comando3.ExecuteNonQuery()
                MsgBox("Dato Almacenado con éxito")
                Filtro.Visible = True
                BtnNuevo.Visible = True
                BtnAgregar.Visible = False
                Actual.Visible = False
                Proxima.Visible = False
                Datos.Visible = False
                CbIdDentista.Enabled = False
                CbIdPaciente.Enabled = False
                CbReceta.Enabled = False
                DtpFecha.Enabled = False
                DtpProx.Enabled = False
                CbMin.Enabled = False
                CbMinP.Enabled = False
                CbServicio.Enabled = False
                NumCant.Enabled = False
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()
            End Try
        End If
    End Sub
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
                comando.CommandText = "SELECT * FROM REg where idCita='" & TxtFiltro.Text & "'"
                adaptador.SelectCommand = comando
                adaptador.Fill(ds, "REGISTRO")
                bs.DataSource = ds
                bs.DataMember = "REGISTRO"
                Dim a As New SqlCommand("select idcita from Reg where idcita='" & TxtFiltro.Text & "'", con)
                TxtCita.Text = a.ExecuteScalar
                Dim b As New SqlCommand("SELECT NombrePaciente FROM Reg WHERE IdCita='" & TxtFiltro.Text & "'", con)
                CbIdPaciente.SelectedItem = b.ExecuteScalar
                Dim c As New SqlCommand("SELECT NombreDentista FROM Reg WHERE IdCita='" & TxtFiltro.Text & "'", con)
                CbIdDentista.SelectedItem = c.ExecuteScalar
                Dim d As New SqlCommand("SELECT IdReceta FROM Reg WHERE IdCita='" & TxtFiltro.Text & "'", con)
                CbReceta.SelectedItem = d.ExecuteScalar
                Dim ee As New SqlCommand("SELECT FechaCita FROM Reg WHERE IdCita='" & TxtFiltro.Text & "'", con)
                'DtpFecha.Value = ee.ExecuteScalar
                Dim f As New SqlCommand("SELECT HoraCita FROM Reg WHERE IdCita='" & TxtFiltro.Text & "'", con)
                CbMin.SelectedItem = f.ExecuteScalar
                Dim g As New SqlCommand("SELECT FechaProximaCita FROM Reg WHERE IdCita='" & TxtFiltro.Text & "'", con)
                'DtpProx.Value = g.ExecuteScalar
                Dim h As New SqlCommand("SELECT HoraProximaCita FROM Reg WHERE IdCita='" & TxtFiltro.Text & "'", con)
                CbMinP.SelectedItem = h.ExecuteScalar
                Dim i As New SqlCommand("select TotalCita from Reg where idcita='" & TxtFiltro.Text & "'", con)
                TxtTotal.Text = i.ExecuteScalar
                Dim j As New SqlCommand("SELECT NombreServicio FROM Reg WHERE IdCita='" & TxtFiltro.Text & "'", con)
                CbServicio.SelectedItem = j.ExecuteScalar
                Dim k As New SqlCommand("SELECT CantidadServicio FROM Reg WHERE IdCita='" & TxtFiltro.Text & "'", con)
                NumCant.Value = k.ExecuteScalar
                con.Close()
                If bs.Count > 1 Then
                    DGV.Visible = True
                    DGV.DataSource = bs
                    Ir.Visible = True
                End If
                If TxtCita.Text.Length > 0 Then
                    Actual.Visible = True
                    Proxima.Visible = True
                    Datos.Visible = True
                    BtnModificar.Visible = True
                    BtnEliminar.Visible = True
                End If
                If TxtCita.Text.Length = 0 Then
                    Actual.Visible = False
                    Proxima.Visible = False
                    Datos.Visible = False
                    BtnModificar.Visible = False
                    BtnEliminar.Visible = False
                End If
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            con.Open()
            Filtro.Visible = False
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnModificar.Visible = False
            BtnNuevo.Visible = False
            Actual.Visible = True
            Proxima.Visible = True
            Datos.Visible = True
            BtnAgregar.Visible = True
            TxtCita.Enabled = True
            CbIdDentista.Enabled = True
            CbIdPaciente.Enabled = True
            CbReceta.Enabled = True
            DtpFecha.Enabled = True
            DtpProx.Enabled = True
            CbMin.Enabled = True
            CbMinP.Enabled = True
            CbServicio.Enabled = True
            NumCant.Enabled = True
            TxtCita.Text = ""
            TxtIdPaciente.Text = ""
            TxtIdDentista.Text = ""
            CbIdPaciente.SelectedIndex = -1
            CbServicio.SelectedIndex = -1
            CbIdDentista.SelectedIndex = -1
            CbReceta.SelectedIndex = -1
            '  DtpFecha.Value = DateString
            '    DtpProx.Value = DateString
            CbMin.SelectedItem = "10:00"
            CbMinP.SelectedItem = "10:00"
            TxtTotal.Text = "0"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtCita.Text.Length < 1 Then
            VId.Text = "*Debe seleccionar un registro."
        Else
            Try
                con.Open()
                If MessageBox.Show("¿En realidad desea borrar el registro?", "My Application",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                 = DialogResult.Yes Then
                    Dim Comando2 As New SqlCommand("delete from Registro where IdCita='" & TxtCita.Text & "'", con)
                    Comando2.ExecuteNonQuery()
                    MsgBox("Registro eliminado satisfactoriamente")
                    bs.RemoveCurrent()
                    TxtCita.Text = ""
                    TxtIdDentista.Text = ""
                    TxtIdPaciente.Text = ""
                    CbIdPaciente.SelectedIndex = -1
                    CbIdDentista.SelectedIndex = -1
                    CbReceta.SelectedIndex = -1
                    CbServicio.SelectedIndex = -1
                    ' DtpFecha.Value = DateString
                    ' DtpProx.Value = DateString
                    CbMin.SelectedItem = "10:00"
                    CbMinP.SelectedItem = "10:00"
                    TxtTotal.Text = "0"
                    Actual.Visible = False
                    Proxima.Visible = False
                    Datos.Visible = False
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
            Actual.Visible = True
            Proxima.Visible = True
            Datos.Visible = True
            BtnActualizar.Visible = True
            CbIdDentista.Enabled = True
            CbIdPaciente.Enabled = True
            CbReceta.Enabled = True
            DtpFecha.Enabled = True
            DtpProx.Enabled = True
            CbMin.Enabled = True
            CbMinP.Enabled = True
            CbServicio.Enabled = True
            NumCant.Enabled = True
            BtnNuevo.Visible = False
            BtnEliminar.Visible = False
            BtnModificar.Visible = False
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CbFiltro.DroppedDown = True
    End Sub
    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            con.Open()
            Dim D1, D2, D3, D4, D5, D6, D7, D8, D9 As String
            D1 = DGV.CurrentRow.Cells(0).EditedFormattedValue.ToString
            D2 = DGV.CurrentRow.Cells(1).EditedFormattedValue.ToString
            D3 = DGV.CurrentRow.Cells(2).EditedFormattedValue.ToString
            D4 = DGV.CurrentRow.Cells(3).EditedFormattedValue.ToString
            D5 = DGV.CurrentRow.Cells(4).EditedFormattedValue.ToString
            D6 = DGV.CurrentRow.Cells(5).EditedFormattedValue.ToString
            D7 = DGV.CurrentRow.Cells(6).EditedFormattedValue.ToString
            D8 = DGV.CurrentRow.Cells(7).EditedFormattedValue.ToString
            D9 = DGV.CurrentRow.Cells(8).EditedFormattedValue.ToString
            TxtCita.Text = D1
            TxtIdPaciente.Text = D2
            Dim c As New SqlCommand("select NombrePaciente from Paciente where IdPaciente='" & TxtIdPaciente.Text & "'", con)
            CbIdPaciente.SelectedItem = c.ExecuteScalar
            CbReceta.SelectedItem = D3
            TxtIdDentista.Text = D4
            Dim d As New SqlCommand("select NombreDentista from Dentista where IdDentista='" & TxtIdDentista.Text & "'", con)
            CbIdDentista.SelectedItem = d.ExecuteScalar
            DtpFecha.Text = D5
            CbMin.SelectedItem = D6
            DtpProx.Value = D7
            CbMinP.SelectedItem = D8
            TxtTotal.Text = D9
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub TxtTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtTotal.TextChanged
        'Dim d1, pattern As String
        'd1 = TxtTotal.Text
        'pattern = "^[0-9]{0,9}$"
        'If Regex.IsMatch(d1, pattern) Then
        '    VServicio.Text = ""
        'Else
        '    If TxtTotal.Text.Length > 0 Then
        '        TxtTotal.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
        '        TxtTotal.Select(TxtTotal.Text.Length, 0)
        '    End If
        '    VServicio.Text = "*Ingrese sólo números, máximo 9."
        'End If
    End Sub
    Private Sub TxtCita_TextChanged(sender As Object, e As EventArgs) Handles TxtCita.TextChanged
        Dim d1, pattern As String
        d1 = TxtCita.Text
        pattern = "^[0-9]{0,5}$"
        If Regex.IsMatch(d1, pattern) Then
            VId.Text = ""
        Else
            If TxtCita.Text.Length > 0 Then
                TxtCita.Text = Microsoft.VisualBasic.Left(d1, Len(d1) - 1)
                TxtCita.Select(TxtCita.Text.Length, 0)
            End If
            VId.Text = "*Ingrese sólo números, máximo 5."
        End If
    End Sub
    Private Sub CbIdPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIdPaciente.SelectedIndexChanged
        If CbIdPaciente.SelectedIndex <> -1 Then
            VPaciente.Text = ""
        End If
    End Sub
    Private Sub CbIdDentista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIdDentista.SelectedIndexChanged
        If CbIdDentista.SelectedIndex <> -1 Then
            VDentist.Text = ""
        End If
    End Sub
    Public Function IdRec() As AutoCompleteStringCollection
        Dim dt As DataTable = Rec()
        Dim coleccion As New AutoCompleteStringCollection()
        'If CbFiltro.SelectedItem = "ID de la Cita" Then
        For Each row As DataRow In dt.Rows
            coleccion.Add(Convert.ToString(row("IdCita")))
        Next
        Return coleccion
        'ElseIf CbFiltro.SelectedItem = "Paciente" Then
        'For Each row As DataRow In dt.Rows
        '    coleccion.Add(Convert.ToString(row("NombrePaciente")))
        'Next
        'Return coleccion
        'ElseIf CbFiltro.SelectedItem = "Dentista" Then
        'For Each row As DataRow In dt.Rows
        '    coleccion.Add(Convert.ToString(row("NombreDentista")))
        'Next
        'Return coleccion
        'ElseIf CbFiltro.SelectedItem = "Fecha" Then
        'For Each row As DataRow In dt.Rows
        '    coleccion.Add(Convert.ToString(row("FechaCita")))
        '    'coleccion.Add(Convert.ToString(row("FechaCitaProxima")))
        'Next
        'Return coleccion
        'End If
        'Return coleccion
    End Function
    Function Rec() As DataTable
        Dim dt As New DataTable()
        Dim Consulta As String = "SELECT * FROM Reg"
        Dim comando As New SqlCommand(Consulta, con)
        Dim adap As New SqlDataAdapter(comando)
        adap.Fill(dt)
        Return dt
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RECETA.Show()
    End Sub
    Private Sub CbServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbServicio.SelectedIndexChanged
        Try
            con.Open()
            Dim c As New SqlCommand("SELECT IdServicio FROM Servicio WHERE NombreServicio='" & CbServicio.SelectedItem & "'", con)
            TxtServicio.Text = c.ExecuteScalar
            If CbServicio.SelectedIndex <> -1 Then
                VServicio.Text = ""
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
End Class