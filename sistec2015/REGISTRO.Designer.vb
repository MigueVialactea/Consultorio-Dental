<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REGISTRO))
        Me.CbReceta = New System.Windows.Forms.ComboBox()
        Me.CbIdDentista = New System.Windows.Forms.ComboBox()
        Me.CbIdPaciente = New System.Windows.Forms.ComboBox()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.IdDentista = New System.Windows.Forms.Label()
        Me.IdReceta = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.Label()
        Me.IdCita = New System.Windows.Forms.Label()
        Me.IdPaciente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtIdDentista = New System.Windows.Forms.TextBox()
        Me.TxtIdPaciente = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.CbFiltro = New System.Windows.Forms.ComboBox()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.DtpProx = New System.Windows.Forms.DateTimePicker()
        Me.CbMin = New System.Windows.Forms.ComboBox()
        Me.CbMinP = New System.Windows.Forms.ComboBox()
        Me.TxtCita = New System.Windows.Forms.TextBox()
        Me.VId = New System.Windows.Forms.Label()
        Me.VPaciente = New System.Windows.Forms.Label()
        Me.VDentist = New System.Windows.Forms.Label()
        Me.Proxima = New System.Windows.Forms.GroupBox()
        Me.Actual = New System.Windows.Forms.GroupBox()
        Me.TxtServicio = New System.Windows.Forms.TextBox()
        Me.NumCant = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbServicio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VServicio = New System.Windows.Forms.Label()
        Me.Ir = New System.Windows.Forms.GroupBox()
        Me.Datos = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Filtro = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Proxima.SuspendLayout()
        Me.Actual.SuspendLayout()
        CType(Me.NumCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ir.SuspendLayout()
        Me.Datos.SuspendLayout()
        Me.Filtro.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbReceta
        '
        Me.CbReceta.Enabled = False
        Me.CbReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbReceta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbReceta.FormattingEnabled = True
        Me.CbReceta.Location = New System.Drawing.Point(664, 27)
        Me.CbReceta.Name = "CbReceta"
        Me.CbReceta.Size = New System.Drawing.Size(113, 21)
        Me.CbReceta.TabIndex = 58
        Me.CbReceta.Text = "Seleccionar opción"
        '
        'CbIdDentista
        '
        Me.CbIdDentista.Enabled = False
        Me.CbIdDentista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbIdDentista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbIdDentista.FormattingEnabled = True
        Me.CbIdDentista.Location = New System.Drawing.Point(454, 27)
        Me.CbIdDentista.Name = "CbIdDentista"
        Me.CbIdDentista.Size = New System.Drawing.Size(113, 21)
        Me.CbIdDentista.TabIndex = 57
        Me.CbIdDentista.Text = "Seleccionar opción"
        '
        'CbIdPaciente
        '
        Me.CbIdPaciente.Enabled = False
        Me.CbIdPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbIdPaciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbIdPaciente.FormattingEnabled = True
        Me.CbIdPaciente.Location = New System.Drawing.Point(258, 27)
        Me.CbIdPaciente.Name = "CbIdPaciente"
        Me.CbIdPaciente.Size = New System.Drawing.Size(122, 21)
        Me.CbIdPaciente.TabIndex = 56
        Me.CbIdPaciente.Text = "Seleccionar opción"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Fecha.Location = New System.Drawing.Point(20, 24)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(48, 18)
        Me.Fecha.TabIndex = 50
        Me.Fecha.Text = "Fecha"
        '
        'IdDentista
        '
        Me.IdDentista.AutoSize = True
        Me.IdDentista.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdDentista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IdDentista.Location = New System.Drawing.Point(386, 27)
        Me.IdDentista.Name = "IdDentista"
        Me.IdDentista.Size = New System.Drawing.Size(62, 18)
        Me.IdDentista.TabIndex = 49
        Me.IdDentista.Text = "Dentista"
        '
        'IdReceta
        '
        Me.IdReceta.AutoSize = True
        Me.IdReceta.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdReceta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IdReceta.Location = New System.Drawing.Point(573, 27)
        Me.IdReceta.Name = "IdReceta"
        Me.IdReceta.Size = New System.Drawing.Size(72, 18)
        Me.IdReceta.TabIndex = 48
        Me.IdReceta.Text = "ID Receta"
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Hora.Location = New System.Drawing.Point(298, 24)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(41, 18)
        Me.Hora.TabIndex = 47
        Me.Hora.Text = "Hora"
        '
        'IdCita
        '
        Me.IdCita.AutoSize = True
        Me.IdCita.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdCita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IdCita.Location = New System.Drawing.Point(10, 27)
        Me.IdCita.Name = "IdCita"
        Me.IdCita.Size = New System.Drawing.Size(52, 18)
        Me.IdCita.TabIndex = 46
        Me.IdCita.Text = "ID Cita"
        '
        'IdPaciente
        '
        Me.IdPaciente.AutoSize = True
        Me.IdPaciente.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdPaciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IdPaciente.Location = New System.Drawing.Point(187, 27)
        Me.IdPaciente.Name = "IdPaciente"
        Me.IdPaciente.Size = New System.Drawing.Size(65, 18)
        Me.IdPaciente.TabIndex = 45
        Me.IdPaciente.Text = "Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(20, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Total"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label.Location = New System.Drawing.Point(367, 9)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(133, 30)
        Me.Label.TabIndex = 61
        Me.Label.Text = "REGISTRO"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(73, 106)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(128, 20)
        Me.TxtTotal.TabIndex = 71
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(26, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 18)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(30, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 18)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Hora"
        '
        'TxtIdDentista
        '
        Me.TxtIdDentista.Enabled = False
        Me.TxtIdDentista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdDentista.Location = New System.Drawing.Point(399, 47)
        Me.TxtIdDentista.Name = "TxtIdDentista"
        Me.TxtIdDentista.Size = New System.Drawing.Size(11, 20)
        Me.TxtIdDentista.TabIndex = 81
        Me.TxtIdDentista.Visible = False
        '
        'TxtIdPaciente
        '
        Me.TxtIdPaciente.Enabled = False
        Me.TxtIdPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdPaciente.Location = New System.Drawing.Point(214, 47)
        Me.TxtIdPaciente.Name = "TxtIdPaciente"
        Me.TxtIdPaciente.Size = New System.Drawing.Size(12, 20)
        Me.TxtIdPaciente.TabIndex = 82
        Me.TxtIdPaciente.Visible = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(828, 14)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(50, 50)
        Me.BtnNuevo.TabIndex = 83
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(884, 150)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(50, 50)
        Me.BtnActualizar.TabIndex = 84
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(828, 150)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(50, 50)
        Me.BtnAgregar.TabIndex = 85
        Me.BtnAgregar.UseVisualStyleBackColor = True
        Me.BtnAgregar.Visible = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(884, 70)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(50, 50)
        Me.BtnBuscar.TabIndex = 90
        Me.BtnBuscar.UseVisualStyleBackColor = True
        Me.BtnBuscar.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(828, 70)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BtnEliminar.TabIndex = 91
        Me.BtnEliminar.UseVisualStyleBackColor = True
        Me.BtnEliminar.Visible = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(884, 14)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(50, 50)
        Me.BtnModificar.TabIndex = 92
        Me.BtnModificar.UseVisualStyleBackColor = True
        Me.BtnModificar.Visible = False
        '
        'BtnUltimo
        '
        Me.BtnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUltimo.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUltimo.Image = CType(resources.GetObject("BtnUltimo.Image"), System.Drawing.Image)
        Me.BtnUltimo.Location = New System.Drawing.Point(62, 17)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(50, 50)
        Me.BtnUltimo.TabIndex = 96
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.Location = New System.Drawing.Point(6, 73)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(50, 50)
        Me.BtnAnterior.TabIndex = 95
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSiguiente.Image = CType(resources.GetObject("BtnSiguiente.Image"), System.Drawing.Image)
        Me.BtnSiguiente.Location = New System.Drawing.Point(62, 73)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(50, 50)
        Me.BtnSiguiente.TabIndex = 94
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnPrimero
        '
        Me.BtnPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrimero.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrimero.Image = CType(resources.GetObject("BtnPrimero.Image"), System.Drawing.Image)
        Me.BtnPrimero.Location = New System.Drawing.Point(6, 17)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(50, 50)
        Me.BtnPrimero.TabIndex = 93
        Me.BtnPrimero.UseVisualStyleBackColor = True
        '
        'CbFiltro
        '
        Me.CbFiltro.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbFiltro.FormattingEnabled = True
        Me.CbFiltro.Items.AddRange(New Object() {"ID de la Cita", "Paciente", "Dentista", "Fecha"})
        Me.CbFiltro.Location = New System.Drawing.Point(158, 24)
        Me.CbFiltro.Name = "CbFiltro"
        Me.CbFiltro.Size = New System.Drawing.Size(111, 25)
        Me.CbFiltro.TabIndex = 99
        Me.CbFiltro.Text = "ID de la Cita"
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFiltro.Location = New System.Drawing.Point(275, 24)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(370, 24)
        Me.TxtFiltro.TabIndex = 101
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Location = New System.Drawing.Point(80, 24)
        Me.DtpFecha.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(212, 20)
        Me.DtpFecha.TabIndex = 107
        Me.DtpFecha.Value = New Date(2016, 1, 1, 0, 0, 0, 0)
        '
        'DtpProx
        '
        Me.DtpProx.Enabled = False
        Me.DtpProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpProx.Location = New System.Drawing.Point(80, 42)
        Me.DtpProx.Name = "DtpProx"
        Me.DtpProx.Size = New System.Drawing.Size(215, 20)
        Me.DtpProx.TabIndex = 108
        Me.DtpProx.Value = New Date(2016, 1, 1, 0, 0, 0, 0)
        '
        'CbMin
        '
        Me.CbMin.Enabled = False
        Me.CbMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMin.FormattingEnabled = True
        Me.CbMin.Items.AddRange(New Object() {"10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30"})
        Me.CbMin.Location = New System.Drawing.Point(345, 24)
        Me.CbMin.Name = "CbMin"
        Me.CbMin.Size = New System.Drawing.Size(56, 21)
        Me.CbMin.TabIndex = 109
        Me.CbMin.Text = "10:00"
        '
        'CbMinP
        '
        Me.CbMinP.Enabled = False
        Me.CbMinP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMinP.FormattingEnabled = True
        Me.CbMinP.Items.AddRange(New Object() {"10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30"})
        Me.CbMinP.Location = New System.Drawing.Point(80, 69)
        Me.CbMinP.Name = "CbMinP"
        Me.CbMinP.Size = New System.Drawing.Size(59, 21)
        Me.CbMinP.TabIndex = 110
        Me.CbMinP.Text = "10:00"
        '
        'TxtCita
        '
        Me.TxtCita.Enabled = False
        Me.TxtCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCita.Location = New System.Drawing.Point(68, 27)
        Me.TxtCita.Name = "TxtCita"
        Me.TxtCita.Size = New System.Drawing.Size(86, 20)
        Me.TxtCita.TabIndex = 114
        '
        'VId
        '
        Me.VId.AutoSize = True
        Me.VId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VId.ForeColor = System.Drawing.Color.Maroon
        Me.VId.Location = New System.Drawing.Point(68, 47)
        Me.VId.Name = "VId"
        Me.VId.Size = New System.Drawing.Size(0, 13)
        Me.VId.TabIndex = 115
        '
        'VPaciente
        '
        Me.VPaciente.AutoSize = True
        Me.VPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VPaciente.ForeColor = System.Drawing.Color.Maroon
        Me.VPaciente.Location = New System.Drawing.Point(258, 47)
        Me.VPaciente.Name = "VPaciente"
        Me.VPaciente.Size = New System.Drawing.Size(0, 13)
        Me.VPaciente.TabIndex = 118
        '
        'VDentist
        '
        Me.VDentist.AutoSize = True
        Me.VDentist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VDentist.ForeColor = System.Drawing.Color.Maroon
        Me.VDentist.Location = New System.Drawing.Point(454, 47)
        Me.VDentist.Name = "VDentist"
        Me.VDentist.Size = New System.Drawing.Size(0, 13)
        Me.VDentist.TabIndex = 119
        '
        'Proxima
        '
        Me.Proxima.Controls.Add(Me.DtpProx)
        Me.Proxima.Controls.Add(Me.Label10)
        Me.Proxima.Controls.Add(Me.Label9)
        Me.Proxima.Controls.Add(Me.CbMinP)
        Me.Proxima.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proxima.Location = New System.Drawing.Point(483, 233)
        Me.Proxima.Name = "Proxima"
        Me.Proxima.Size = New System.Drawing.Size(319, 146)
        Me.Proxima.TabIndex = 120
        Me.Proxima.TabStop = False
        Me.Proxima.Text = "Próxima Cita"
        Me.Proxima.Visible = False
        '
        'Actual
        '
        Me.Actual.Controls.Add(Me.TxtServicio)
        Me.Actual.Controls.Add(Me.NumCant)
        Me.Actual.Controls.Add(Me.Label4)
        Me.Actual.Controls.Add(Me.CbServicio)
        Me.Actual.Controls.Add(Me.Label3)
        Me.Actual.Controls.Add(Me.DtpFecha)
        Me.Actual.Controls.Add(Me.Hora)
        Me.Actual.Controls.Add(Me.Fecha)
        Me.Actual.Controls.Add(Me.Label2)
        Me.Actual.Controls.Add(Me.TxtTotal)
        Me.Actual.Controls.Add(Me.VServicio)
        Me.Actual.Controls.Add(Me.CbMin)
        Me.Actual.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actual.Location = New System.Drawing.Point(12, 227)
        Me.Actual.Name = "Actual"
        Me.Actual.Size = New System.Drawing.Size(447, 152)
        Me.Actual.TabIndex = 121
        Me.Actual.TabStop = False
        Me.Actual.Text = "Cita Actual"
        Me.Actual.Visible = False
        '
        'TxtServicio
        '
        Me.TxtServicio.Enabled = False
        Me.TxtServicio.Location = New System.Drawing.Point(38, 84)
        Me.TxtServicio.Name = "TxtServicio"
        Me.TxtServicio.Size = New System.Drawing.Size(10, 25)
        Me.TxtServicio.TabIndex = 125
        Me.TxtServicio.Visible = False
        '
        'NumCant
        '
        Me.NumCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCant.Location = New System.Drawing.Point(360, 68)
        Me.NumCant.Name = "NumCant"
        Me.NumCant.Size = New System.Drawing.Size(50, 20)
        Me.NumCant.TabIndex = 124
        Me.NumCant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(284, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Cantidad"
        '
        'CbServicio
        '
        Me.CbServicio.Enabled = False
        Me.CbServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbServicio.FormattingEnabled = True
        Me.CbServicio.Location = New System.Drawing.Point(82, 63)
        Me.CbServicio.Name = "CbServicio"
        Me.CbServicio.Size = New System.Drawing.Size(122, 21)
        Me.CbServicio.TabIndex = 122
        Me.CbServicio.Text = "Seleccionar opción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(21, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Servicio"
        '
        'VServicio
        '
        Me.VServicio.AutoSize = True
        Me.VServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VServicio.ForeColor = System.Drawing.Color.Maroon
        Me.VServicio.Location = New System.Drawing.Point(89, 85)
        Me.VServicio.Name = "VServicio"
        Me.VServicio.Size = New System.Drawing.Size(0, 13)
        Me.VServicio.TabIndex = 116
        '
        'Ir
        '
        Me.Ir.Controls.Add(Me.BtnPrimero)
        Me.Ir.Controls.Add(Me.BtnUltimo)
        Me.Ir.Controls.Add(Me.BtnAnterior)
        Me.Ir.Controls.Add(Me.BtnSiguiente)
        Me.Ir.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ir.Location = New System.Drawing.Point(828, 242)
        Me.Ir.Name = "Ir"
        Me.Ir.Size = New System.Drawing.Size(115, 126)
        Me.Ir.TabIndex = 122
        Me.Ir.TabStop = False
        Me.Ir.Text = "Ir a..."
        Me.Ir.Visible = False
        '
        'Datos
        '
        Me.Datos.Controls.Add(Me.Button1)
        Me.Datos.Controls.Add(Me.TxtCita)
        Me.Datos.Controls.Add(Me.IdCita)
        Me.Datos.Controls.Add(Me.VId)
        Me.Datos.Controls.Add(Me.CbIdPaciente)
        Me.Datos.Controls.Add(Me.IdPaciente)
        Me.Datos.Controls.Add(Me.VDentist)
        Me.Datos.Controls.Add(Me.TxtIdPaciente)
        Me.Datos.Controls.Add(Me.VPaciente)
        Me.Datos.Controls.Add(Me.CbIdDentista)
        Me.Datos.Controls.Add(Me.IdDentista)
        Me.Datos.Controls.Add(Me.TxtIdDentista)
        Me.Datos.Controls.Add(Me.CbReceta)
        Me.Datos.Controls.Add(Me.IdReceta)
        Me.Datos.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datos.Location = New System.Drawing.Point(12, 128)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(790, 81)
        Me.Datos.TabIndex = 123
        Me.Datos.TabStop = False
        Me.Datos.Text = "Datos:"
        Me.Datos.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(607, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 120
        Me.Button1.Text = "Crear Receta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Filtro
        '
        Me.Filtro.Controls.Add(Me.CbFiltro)
        Me.Filtro.Controls.Add(Me.TxtFiltro)
        Me.Filtro.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtro.Location = New System.Drawing.Point(12, 53)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(790, 67)
        Me.Filtro.TabIndex = 124
        Me.Filtro.TabStop = False
        Me.Filtro.Text = "Filtro de Consultas"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(10, 397)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(930, 88)
        Me.DGV.TabIndex = 125
        Me.DGV.Visible = False
        '
        'REGISTRO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(949, 497)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Filtro)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.Ir)
        Me.Controls.Add(Me.Actual)
        Me.Controls.Add(Me.Proxima)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label)
        Me.Name = "REGISTRO"
        Me.Text = "REGISTRO"
        Me.Proxima.ResumeLayout(False)
        Me.Proxima.PerformLayout()
        Me.Actual.ResumeLayout(False)
        Me.Actual.PerformLayout()
        CType(Me.NumCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ir.ResumeLayout(False)
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        Me.Filtro.ResumeLayout(False)
        Me.Filtro.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbReceta As System.Windows.Forms.ComboBox
    Friend WithEvents CbIdDentista As System.Windows.Forms.ComboBox
    Friend WithEvents CbIdPaciente As System.Windows.Forms.ComboBox
    Friend WithEvents Fecha As System.Windows.Forms.Label
    Friend WithEvents IdDentista As System.Windows.Forms.Label
    Friend WithEvents IdReceta As System.Windows.Forms.Label
    Friend WithEvents Hora As System.Windows.Forms.Label
    Friend WithEvents IdCita As System.Windows.Forms.Label
    Friend WithEvents IdPaciente As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtIdDentista As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdPaciente As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnUltimo As System.Windows.Forms.Button
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnPrimero As System.Windows.Forms.Button
    Friend WithEvents CbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpProx As System.Windows.Forms.DateTimePicker
    Friend WithEvents CbMin As System.Windows.Forms.ComboBox
    Friend WithEvents CbMinP As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCita As System.Windows.Forms.TextBox
    Friend WithEvents VId As System.Windows.Forms.Label
    Friend WithEvents VPaciente As System.Windows.Forms.Label
    Friend WithEvents VDentist As System.Windows.Forms.Label
    Friend WithEvents Proxima As System.Windows.Forms.GroupBox
    Friend WithEvents Actual As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumCant As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbServicio As System.Windows.Forms.ComboBox
    Friend WithEvents Ir As System.Windows.Forms.GroupBox
    Friend WithEvents Datos As System.Windows.Forms.GroupBox
    Friend WithEvents Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents VServicio As System.Windows.Forms.Label
    Friend WithEvents TxtServicio As System.Windows.Forms.TextBox
End Class
