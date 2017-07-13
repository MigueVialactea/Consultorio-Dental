<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RECETA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RECETA))
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtIdMedicamento = New System.Windows.Forms.TextBox()
        Me.CbVia = New System.Windows.Forms.ComboBox()
        Me.CbHoras = New System.Windows.Forms.ComboBox()
        Me.CbDias = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.CbIdMedicamento = New System.Windows.Forms.ComboBox()
        Me.LblDosis = New System.Windows.Forms.Label()
        Me.Via = New System.Windows.Forms.Label()
        Me.Horas = New System.Windows.Forms.Label()
        Me.IdReceta = New System.Windows.Forms.Label()
        Me.IdMedicamento = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdReceta = New System.Windows.Forms.TextBox()
        Me.VId = New System.Windows.Forms.Label()
        Me.VIdM = New System.Windows.Forms.Label()
        Me.VHoras = New System.Windows.Forms.Label()
        Me.VVia = New System.Windows.Forms.Label()
        Me.CbDosis = New System.Windows.Forms.ComboBox()
        Me.VDosis = New System.Windows.Forms.Label()
        Me.VDias = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Detalles = New System.Windows.Forms.GroupBox()
        Me.Ir = New System.Windows.Forms.GroupBox()
        Me.Filtro = New System.Windows.Forms.GroupBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Detalles.SuspendLayout()
        Me.Ir.SuspendLayout()
        Me.Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtFiltro
        '
        Me.TxtFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtFiltro.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFiltro.Location = New System.Drawing.Point(165, 28)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(308, 24)
        Me.TxtFiltro.TabIndex = 150
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(52, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 18)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "Id de la Receta"
        '
        'BtnUltimo
        '
        Me.BtnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUltimo.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUltimo.Image = CType(resources.GetObject("BtnUltimo.Image"), System.Drawing.Image)
        Me.BtnUltimo.Location = New System.Drawing.Point(62, 24)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(50, 50)
        Me.BtnUltimo.TabIndex = 145
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.Location = New System.Drawing.Point(6, 78)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(50, 50)
        Me.BtnAnterior.TabIndex = 144
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSiguiente.Image = CType(resources.GetObject("BtnSiguiente.Image"), System.Drawing.Image)
        Me.BtnSiguiente.Location = New System.Drawing.Point(62, 78)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(50, 50)
        Me.BtnSiguiente.TabIndex = 143
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnPrimero
        '
        Me.BtnPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrimero.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrimero.Image = CType(resources.GetObject("BtnPrimero.Image"), System.Drawing.Image)
        Me.BtnPrimero.Location = New System.Drawing.Point(6, 24)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(50, 50)
        Me.BtnPrimero.TabIndex = 142
        Me.BtnPrimero.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(609, 26)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(50, 50)
        Me.BtnModificar.TabIndex = 141
        Me.BtnModificar.UseVisualStyleBackColor = True
        Me.BtnModificar.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(582, 82)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BtnEliminar.TabIndex = 140
        Me.BtnEliminar.UseVisualStyleBackColor = True
        Me.BtnEliminar.Visible = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(491, 196)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(50, 50)
        Me.BtnAgregar.TabIndex = 138
        Me.BtnAgregar.UseVisualStyleBackColor = True
        Me.BtnAgregar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(491, 252)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(50, 50)
        Me.BtnActualizar.TabIndex = 137
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(553, 26)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(50, 50)
        Me.BtnNuevo.TabIndex = 136
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtIdMedicamento
        '
        Me.TxtIdMedicamento.Enabled = False
        Me.TxtIdMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtIdMedicamento.Location = New System.Drawing.Point(253, 78)
        Me.TxtIdMedicamento.Name = "TxtIdMedicamento"
        Me.TxtIdMedicamento.Size = New System.Drawing.Size(14, 20)
        Me.TxtIdMedicamento.TabIndex = 135
        Me.TxtIdMedicamento.Visible = False
        '
        'CbVia
        '
        Me.CbVia.Enabled = False
        Me.CbVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbVia.FormattingEnabled = True
        Me.CbVia.Items.AddRange(New Object() {"Intravenoso", "Inyeccion", "Oral", "Sublingual"})
        Me.CbVia.Location = New System.Drawing.Point(180, 174)
        Me.CbVia.Name = "CbVia"
        Me.CbVia.Size = New System.Drawing.Size(79, 21)
        Me.CbVia.TabIndex = 128
        Me.CbVia.Text = "Seleccionar"
        '
        'CbHoras
        '
        Me.CbHoras.Enabled = False
        Me.CbHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbHoras.FormattingEnabled = True
        Me.CbHoras.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.CbHoras.Location = New System.Drawing.Point(113, 125)
        Me.CbHoras.Name = "CbHoras"
        Me.CbHoras.Size = New System.Drawing.Size(79, 21)
        Me.CbHoras.TabIndex = 121
        Me.CbHoras.Text = "Seleccionar"
        '
        'CbDias
        '
        Me.CbDias.Enabled = False
        Me.CbDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDias.FormattingEnabled = True
        Me.CbDias.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.CbDias.Location = New System.Drawing.Point(306, 125)
        Me.CbDias.Name = "CbDias"
        Me.CbDias.Size = New System.Drawing.Size(79, 21)
        Me.CbDias.TabIndex = 119
        Me.CbDias.Text = "Seleccionar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(391, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 18)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "días."
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label.Location = New System.Drawing.Point(241, 9)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(103, 30)
        Me.Label.TabIndex = 117
        Me.Label.Text = "RECETA"
        '
        'CbIdMedicamento
        '
        Me.CbIdMedicamento.Enabled = False
        Me.CbIdMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbIdMedicamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbIdMedicamento.FormattingEnabled = True
        Me.CbIdMedicamento.Location = New System.Drawing.Point(113, 77)
        Me.CbIdMedicamento.Name = "CbIdMedicamento"
        Me.CbIdMedicamento.Size = New System.Drawing.Size(126, 21)
        Me.CbIdMedicamento.TabIndex = 113
        Me.CbIdMedicamento.Text = "Seleccionar opción"
        '
        'LblDosis
        '
        Me.LblDosis.AutoSize = True
        Me.LblDosis.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDosis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblDosis.Location = New System.Drawing.Point(265, 177)
        Me.LblDosis.Name = "LblDosis"
        Me.LblDosis.Size = New System.Drawing.Size(66, 18)
        Me.LblDosis.TabIndex = 111
        Me.LblDosis.Text = "y la dosis"
        '
        'Via
        '
        Me.Via.AutoSize = True
        Me.Via.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Via.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Via.Location = New System.Drawing.Point(19, 174)
        Me.Via.Name = "Via"
        Me.Via.Size = New System.Drawing.Size(155, 18)
        Me.Via.TabIndex = 110
        Me.Via.Text = "La vía de aplicación es"
        '
        'Horas
        '
        Me.Horas.AutoSize = True
        Me.Horas.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Horas.Location = New System.Drawing.Point(198, 125)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(102, 18)
        Me.Horas.TabIndex = 109
        Me.Horas.Text = "horas, durante"
        '
        'IdReceta
        '
        Me.IdReceta.AutoSize = True
        Me.IdReceta.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdReceta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IdReceta.Location = New System.Drawing.Point(18, 35)
        Me.IdReceta.Name = "IdReceta"
        Me.IdReceta.Size = New System.Drawing.Size(72, 18)
        Me.IdReceta.TabIndex = 108
        Me.IdReceta.Text = "ID Receta"
        '
        'IdMedicamento
        '
        Me.IdMedicamento.AutoSize = True
        Me.IdMedicamento.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdMedicamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IdMedicamento.Location = New System.Drawing.Point(19, 77)
        Me.IdMedicamento.Name = "IdMedicamento"
        Me.IdMedicamento.Size = New System.Drawing.Size(96, 18)
        Me.IdMedicamento.TabIndex = 105
        Me.IdMedicamento.Text = "Medicamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(19, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "Tomar cada"
        '
        'TxtIdReceta
        '
        Me.TxtIdReceta.Enabled = False
        Me.TxtIdReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdReceta.Location = New System.Drawing.Point(96, 33)
        Me.TxtIdReceta.Name = "TxtIdReceta"
        Me.TxtIdReceta.Size = New System.Drawing.Size(79, 20)
        Me.TxtIdReceta.TabIndex = 153
        '
        'VId
        '
        Me.VId.AutoSize = True
        Me.VId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VId.ForeColor = System.Drawing.Color.Maroon
        Me.VId.Location = New System.Drawing.Point(96, 58)
        Me.VId.Name = "VId"
        Me.VId.Size = New System.Drawing.Size(0, 13)
        Me.VId.TabIndex = 158
        '
        'VIdM
        '
        Me.VIdM.AutoSize = True
        Me.VIdM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIdM.ForeColor = System.Drawing.Color.Maroon
        Me.VIdM.Location = New System.Drawing.Point(121, 98)
        Me.VIdM.Name = "VIdM"
        Me.VIdM.Size = New System.Drawing.Size(0, 13)
        Me.VIdM.TabIndex = 160
        '
        'VHoras
        '
        Me.VHoras.AutoSize = True
        Me.VHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VHoras.ForeColor = System.Drawing.Color.Maroon
        Me.VHoras.Location = New System.Drawing.Point(110, 152)
        Me.VHoras.Name = "VHoras"
        Me.VHoras.Size = New System.Drawing.Size(0, 13)
        Me.VHoras.TabIndex = 162
        '
        'VVia
        '
        Me.VVia.AutoSize = True
        Me.VVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VVia.ForeColor = System.Drawing.Color.Maroon
        Me.VVia.Location = New System.Drawing.Point(180, 198)
        Me.VVia.Name = "VVia"
        Me.VVia.Size = New System.Drawing.Size(0, 13)
        Me.VVia.TabIndex = 163
        '
        'CbDosis
        '
        Me.CbDosis.Enabled = False
        Me.CbDosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDosis.FormattingEnabled = True
        Me.CbDosis.Items.AddRange(New Object() {"125 ml", "275 ml", "    1 g", "  10 g", "250 g", "500 g"})
        Me.CbDosis.Location = New System.Drawing.Point(334, 177)
        Me.CbDosis.Name = "CbDosis"
        Me.CbDosis.Size = New System.Drawing.Size(81, 21)
        Me.CbDosis.TabIndex = 164
        Me.CbDosis.Text = "Seleccionar"
        '
        'VDosis
        '
        Me.VDosis.AutoSize = True
        Me.VDosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VDosis.ForeColor = System.Drawing.Color.Maroon
        Me.VDosis.Location = New System.Drawing.Point(334, 198)
        Me.VDosis.Name = "VDosis"
        Me.VDosis.Size = New System.Drawing.Size(0, 13)
        Me.VDosis.TabIndex = 159
        '
        'VDias
        '
        Me.VDias.AutoSize = True
        Me.VDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VDias.ForeColor = System.Drawing.Color.Maroon
        Me.VDias.Location = New System.Drawing.Point(303, 145)
        Me.VDias.Name = "VDias"
        Me.VDias.Size = New System.Drawing.Size(0, 13)
        Me.VDias.TabIndex = 161
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(1, 352)
        Me.DGV.Name = "DGV"
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV.Size = New System.Drawing.Size(658, 84)
        Me.DGV.TabIndex = 168
        Me.DGV.Visible = False
        '
        'Detalles
        '
        Me.Detalles.Controls.Add(Me.IdReceta)
        Me.Detalles.Controls.Add(Me.IdMedicamento)
        Me.Detalles.Controls.Add(Me.Horas)
        Me.Detalles.Controls.Add(Me.VDias)
        Me.Detalles.Controls.Add(Me.Via)
        Me.Detalles.Controls.Add(Me.VDosis)
        Me.Detalles.Controls.Add(Me.LblDosis)
        Me.Detalles.Controls.Add(Me.CbDosis)
        Me.Detalles.Controls.Add(Me.CbIdMedicamento)
        Me.Detalles.Controls.Add(Me.VVia)
        Me.Detalles.Controls.Add(Me.Label4)
        Me.Detalles.Controls.Add(Me.VHoras)
        Me.Detalles.Controls.Add(Me.CbDias)
        Me.Detalles.Controls.Add(Me.VIdM)
        Me.Detalles.Controls.Add(Me.CbHoras)
        Me.Detalles.Controls.Add(Me.VId)
        Me.Detalles.Controls.Add(Me.CbVia)
        Me.Detalles.Controls.Add(Me.Label3)
        Me.Detalles.Controls.Add(Me.TxtIdMedicamento)
        Me.Detalles.Controls.Add(Me.TxtIdReceta)
        Me.Detalles.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detalles.Location = New System.Drawing.Point(12, 126)
        Me.Detalles.Name = "Detalles"
        Me.Detalles.Size = New System.Drawing.Size(473, 220)
        Me.Detalles.TabIndex = 169
        Me.Detalles.TabStop = False
        Me.Detalles.Text = "Detalles:"
        Me.Detalles.Visible = False
        '
        'Ir
        '
        Me.Ir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Ir.Controls.Add(Me.BtnUltimo)
        Me.Ir.Controls.Add(Me.BtnPrimero)
        Me.Ir.Controls.Add(Me.BtnSiguiente)
        Me.Ir.Controls.Add(Me.BtnAnterior)
        Me.Ir.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ir.Location = New System.Drawing.Point(547, 168)
        Me.Ir.Name = "Ir"
        Me.Ir.Size = New System.Drawing.Size(117, 134)
        Me.Ir.TabIndex = 170
        Me.Ir.TabStop = False
        Me.Ir.Text = " Ir a..."
        Me.Ir.Visible = False
        '
        'Filtro
        '
        Me.Filtro.Controls.Add(Me.TxtFiltro)
        Me.Filtro.Controls.Add(Me.Label12)
        Me.Filtro.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtro.Location = New System.Drawing.Point(12, 42)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(506, 65)
        Me.Filtro.TabIndex = 171
        Me.Filtro.TabStop = False
        Me.Filtro.Text = "Filtro de Consultas:"
        '
        'RECETA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(667, 438)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Filtro)
        Me.Controls.Add(Me.Ir)
        Me.Controls.Add(Me.Detalles)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label)
        Me.Name = "RECETA"
        Me.Text = "RECETA"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Detalles.ResumeLayout(False)
        Me.Detalles.PerformLayout()
        Me.Ir.ResumeLayout(False)
        Me.Filtro.ResumeLayout(False)
        Me.Filtro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnUltimo As System.Windows.Forms.Button
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnPrimero As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents TxtIdMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents CbVia As System.Windows.Forms.ComboBox
    Friend WithEvents CbHoras As System.Windows.Forms.ComboBox
    Friend WithEvents CbDias As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents CbIdMedicamento As System.Windows.Forms.ComboBox
    Friend WithEvents LblDosis As System.Windows.Forms.Label
    Friend WithEvents Via As System.Windows.Forms.Label
    Friend WithEvents Horas As System.Windows.Forms.Label
    Friend WithEvents IdReceta As System.Windows.Forms.Label
    Friend WithEvents IdMedicamento As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtIdReceta As System.Windows.Forms.TextBox
    Friend WithEvents VId As System.Windows.Forms.Label
    Friend WithEvents VIdM As System.Windows.Forms.Label
    Friend WithEvents VHoras As System.Windows.Forms.Label
    Friend WithEvents VVia As System.Windows.Forms.Label
    Friend WithEvents CbDosis As System.Windows.Forms.ComboBox
    Friend WithEvents VDosis As System.Windows.Forms.Label
    Friend WithEvents VDias As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Detalles As System.Windows.Forms.GroupBox
    Friend WithEvents Ir As System.Windows.Forms.GroupBox
    Friend WithEvents Filtro As System.Windows.Forms.GroupBox
End Class
