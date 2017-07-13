<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SERVICIO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SERVICIO))
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbFiltro = New System.Windows.Forms.ComboBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtServicio = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblImporte = New System.Windows.Forms.Label()
        Me.LbIdServicio = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.VId = New System.Windows.Forms.Label()
        Me.VNombre = New System.Windows.Forms.Label()
        Me.VImporte = New System.Windows.Forms.Label()
        Me.Detalles = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Filtro = New System.Windows.Forms.GroupBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Detalles.SuspendLayout()
        Me.Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtFiltro
        '
        Me.TxtFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtFiltro.Location = New System.Drawing.Point(215, 32)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(169, 20)
        Me.TxtFiltro.TabIndex = 192
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(168, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 18)
        Me.Label12.TabIndex = 191
        Me.Label12.Text = "Filtro"
        '
        'CbFiltro
        '
        Me.CbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CbFiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbFiltro.FormattingEnabled = True
        Me.CbFiltro.Items.AddRange(New Object() {"ID", "Nombre"})
        Me.CbFiltro.Location = New System.Drawing.Point(12, 32)
        Me.CbFiltro.Name = "CbFiltro"
        Me.CbFiltro.Size = New System.Drawing.Size(150, 21)
        Me.CbFiltro.TabIndex = 190
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.Enabled = False
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(521, 190)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(50, 50)
        Me.BtnAgregar.TabIndex = 188
        Me.BtnAgregar.UseVisualStyleBackColor = True
        Me.BtnAgregar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.Enabled = False
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.Location = New System.Drawing.Point(587, 190)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(50, 50)
        Me.BtnActualizar.TabIndex = 187
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(553, 59)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(50, 50)
        Me.BtnModificar.TabIndex = 182
        Me.BtnModificar.UseVisualStyleBackColor = True
        Me.BtnModificar.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(622, 59)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BtnEliminar.TabIndex = 181
        Me.BtnEliminar.UseVisualStyleBackColor = True
        Me.BtnEliminar.Visible = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(483, 59)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(50, 50)
        Me.BtnNuevo.TabIndex = 179
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNombre.Location = New System.Drawing.Point(77, 84)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(173, 20)
        Me.TxtNombre.TabIndex = 178
        '
        'TxtServicio
        '
        Me.TxtServicio.Enabled = False
        Me.TxtServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtServicio.Location = New System.Drawing.Point(79, 36)
        Me.TxtServicio.Name = "TxtServicio"
        Me.TxtServicio.Size = New System.Drawing.Size(171, 20)
        Me.TxtServicio.TabIndex = 177
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(33, 365)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(624, 85)
        Me.DGV.TabIndex = 175
        Me.DGV.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(225, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 30)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "SERVICIO"
        '
        'LblImporte
        '
        Me.LblImporte.AutoSize = True
        Me.LblImporte.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblImporte.Location = New System.Drawing.Point(9, 131)
        Me.LblImporte.Name = "LblImporte"
        Me.LblImporte.Size = New System.Drawing.Size(59, 18)
        Me.LblImporte.TabIndex = 171
        Me.LblImporte.Text = "Importe"
        '
        'LbIdServicio
        '
        Me.LbIdServicio.AutoSize = True
        Me.LbIdServicio.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbIdServicio.Location = New System.Drawing.Point(9, 35)
        Me.LbIdServicio.Name = "LbIdServicio"
        Me.LbIdServicio.Size = New System.Drawing.Size(22, 18)
        Me.LbIdServicio.TabIndex = 170
        Me.LbIdServicio.Text = "ID"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNombre.Location = New System.Drawing.Point(7, 83)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(62, 18)
        Me.LblNombre.TabIndex = 169
        Me.LblNombre.Text = "Nombre"
        '
        'TxtImporte
        '
        Me.TxtImporte.Enabled = False
        Me.TxtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtImporte.Location = New System.Drawing.Point(79, 132)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(171, 20)
        Me.TxtImporte.TabIndex = 193
        '
        'VId
        '
        Me.VId.AutoSize = True
        Me.VId.ForeColor = System.Drawing.Color.Maroon
        Me.VId.Location = New System.Drawing.Point(74, 58)
        Me.VId.Name = "VId"
        Me.VId.Size = New System.Drawing.Size(0, 17)
        Me.VId.TabIndex = 194
        '
        'VNombre
        '
        Me.VNombre.AutoSize = True
        Me.VNombre.ForeColor = System.Drawing.Color.Maroon
        Me.VNombre.Location = New System.Drawing.Point(74, 107)
        Me.VNombre.Name = "VNombre"
        Me.VNombre.Size = New System.Drawing.Size(0, 17)
        Me.VNombre.TabIndex = 195
        '
        'VImporte
        '
        Me.VImporte.AutoSize = True
        Me.VImporte.ForeColor = System.Drawing.Color.Maroon
        Me.VImporte.Location = New System.Drawing.Point(74, 155)
        Me.VImporte.Name = "VImporte"
        Me.VImporte.Size = New System.Drawing.Size(0, 17)
        Me.VImporte.TabIndex = 196
        '
        'Detalles
        '
        Me.Detalles.Controls.Add(Me.Label1)
        Me.Detalles.Controls.Add(Me.TxtServicio)
        Me.Detalles.Controls.Add(Me.LbIdServicio)
        Me.Detalles.Controls.Add(Me.VImporte)
        Me.Detalles.Controls.Add(Me.LblNombre)
        Me.Detalles.Controls.Add(Me.VNombre)
        Me.Detalles.Controls.Add(Me.LblImporte)
        Me.Detalles.Controls.Add(Me.VId)
        Me.Detalles.Controls.Add(Me.TxtImporte)
        Me.Detalles.Controls.Add(Me.TxtNombre)
        Me.Detalles.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Detalles.Location = New System.Drawing.Point(12, 165)
        Me.Detalles.Name = "Detalles"
        Me.Detalles.Size = New System.Drawing.Size(420, 194)
        Me.Detalles.TabIndex = 197
        Me.Detalles.TabStop = False
        Me.Detalles.Text = "Detalles"
        Me.Detalles.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Pesos"
        '
        'Filtro
        '
        Me.Filtro.Controls.Add(Me.TextName)
        Me.Filtro.Controls.Add(Me.TxtFiltro)
        Me.Filtro.Controls.Add(Me.CbFiltro)
        Me.Filtro.Controls.Add(Me.Label12)
        Me.Filtro.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Filtro.Location = New System.Drawing.Point(12, 56)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(420, 84)
        Me.Filtro.TabIndex = 199
        Me.Filtro.TabStop = False
        Me.Filtro.Text = "Filtro de Consultas"
        '
        'TextName
        '
        Me.TextName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextName.Location = New System.Drawing.Point(215, 32)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(169, 20)
        Me.TextName.TabIndex = 193
        Me.TextName.Visible = False
        '
        'SERVICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(684, 410)
        Me.Controls.Add(Me.Filtro)
        Me.Controls.Add(Me.Detalles)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label3)
        Me.Name = "SERVICIO"
        Me.Text = "SERVICIO"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Detalles.ResumeLayout(False)
        Me.Detalles.PerformLayout()
        Me.Filtro.ResumeLayout(False)
        Me.Filtro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtServicio As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblImporte As System.Windows.Forms.Label
    Friend WithEvents LbIdServicio As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents VId As System.Windows.Forms.Label
    Friend WithEvents VNombre As System.Windows.Forms.Label
    Friend WithEvents VImporte As System.Windows.Forms.Label
    Friend WithEvents Detalles As GroupBox
    Friend WithEvents Filtro As GroupBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents Label1 As Label
End Class
