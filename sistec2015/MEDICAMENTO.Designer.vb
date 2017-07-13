<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEDICAMENTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MEDICAMENTO))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbClasificacion = New System.Windows.Forms.ComboBox()
        Me.LblClasificacion = New System.Windows.Forms.Label()
        Me.LbIdMedicamento = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtMedicamento = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbFiltro = New System.Windows.Forms.ComboBox()
        Me.LbPresentacion = New System.Windows.Forms.Label()
        Me.CbPresentacion = New System.Windows.Forms.ComboBox()
        Me.VId = New System.Windows.Forms.Label()
        Me.VNombre = New System.Windows.Forms.Label()
        Me.VPres = New System.Windows.Forms.Label()
        Me.VClas = New System.Windows.Forms.Label()
        Me.Detalles = New System.Windows.Forms.GroupBox()
        Me.Filtro = New System.Windows.Forms.GroupBox()
        Me.TextFClasificacion = New System.Windows.Forms.TextBox()
        Me.TextFPresentacion = New System.Windows.Forms.TextBox()
        Me.TextBNombre = New System.Windows.Forms.TextBox()
        Me.Detalles.SuspendLayout()
        Me.Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(207, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 30)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "MEDICAMENTO"
        '
        'CbClasificacion
        '
        Me.CbClasificacion.Enabled = False
        Me.CbClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CbClasificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbClasificacion.FormattingEnabled = True
        Me.CbClasificacion.Items.AddRange(New Object() {"Anestésicos", "Antibióticos", "Anticoagulantes", "Antihistamínicos", "Antipiréticos", "Antisépticos ", "Astringentes"})
        Me.CbClasificacion.Location = New System.Drawing.Point(109, 141)
        Me.CbClasificacion.Name = "CbClasificacion"
        Me.CbClasificacion.Size = New System.Drawing.Size(167, 21)
        Me.CbClasificacion.TabIndex = 115
        Me.CbClasificacion.Text = "Seleccione una opción"
        '
        'LblClasificacion
        '
        Me.LblClasificacion.AutoSize = True
        Me.LblClasificacion.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClasificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblClasificacion.Location = New System.Drawing.Point(12, 141)
        Me.LblClasificacion.Name = "LblClasificacion"
        Me.LblClasificacion.Size = New System.Drawing.Size(85, 18)
        Me.LblClasificacion.TabIndex = 108
        Me.LblClasificacion.Text = "Clasificación"
        '
        'LbIdMedicamento
        '
        Me.LbIdMedicamento.AutoSize = True
        Me.LbIdMedicamento.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIdMedicamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbIdMedicamento.Location = New System.Drawing.Point(11, 21)
        Me.LbIdMedicamento.Name = "LbIdMedicamento"
        Me.LbIdMedicamento.Size = New System.Drawing.Size(22, 18)
        Me.LbIdMedicamento.TabIndex = 106
        Me.LbIdMedicamento.Text = "ID"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNombre.Location = New System.Drawing.Point(11, 66)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(62, 18)
        Me.LblNombre.TabIndex = 105
        Me.LblNombre.Text = "Nombre"
        '
        'TxtMedicamento
        '
        Me.TxtMedicamento.Enabled = False
        Me.TxtMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMedicamento.Location = New System.Drawing.Point(111, 19)
        Me.TxtMedicamento.Name = "TxtMedicamento"
        Me.TxtMedicamento.Size = New System.Drawing.Size(165, 20)
        Me.TxtMedicamento.TabIndex = 153
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNombre.Location = New System.Drawing.Point(111, 60)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(165, 20)
        Me.TxtNombre.TabIndex = 154
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(541, 62)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(50, 50)
        Me.BtnModificar.TabIndex = 158
        Me.BtnModificar.UseVisualStyleBackColor = True
        Me.BtnModificar.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(597, 62)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BtnEliminar.TabIndex = 157
        Me.BtnEliminar.UseVisualStyleBackColor = True
        Me.BtnEliminar.Visible = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(485, 62)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(50, 50)
        Me.BtnNuevo.TabIndex = 155
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.Enabled = False
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(508, 172)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(50, 50)
        Me.BtnAgregar.TabIndex = 164
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
        Me.BtnActualizar.Location = New System.Drawing.Point(573, 173)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(50, 50)
        Me.BtnActualizar.TabIndex = 163
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtFiltro.Location = New System.Drawing.Point(216, 19)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(165, 20)
        Me.TxtFiltro.TabIndex = 168
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(169, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 18)
        Me.Label12.TabIndex = 167
        Me.Label12.Text = "Filtro"
        '
        'CbFiltro
        '
        Me.CbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CbFiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbFiltro.FormattingEnabled = True
        Me.CbFiltro.Items.AddRange(New Object() {"ID", "Nombre", "Clasificacion", "Presentacion"})
        Me.CbFiltro.Location = New System.Drawing.Point(2, 18)
        Me.CbFiltro.Name = "CbFiltro"
        Me.CbFiltro.Size = New System.Drawing.Size(150, 21)
        Me.CbFiltro.TabIndex = 166
        '
        'LbPresentacion
        '
        Me.LbPresentacion.AutoSize = True
        Me.LbPresentacion.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPresentacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbPresentacion.Location = New System.Drawing.Point(11, 100)
        Me.LbPresentacion.Name = "LbPresentacion"
        Me.LbPresentacion.Size = New System.Drawing.Size(91, 18)
        Me.LbPresentacion.TabIndex = 169
        Me.LbPresentacion.Text = "Presentación"
        '
        'CbPresentacion
        '
        Me.CbPresentacion.Enabled = False
        Me.CbPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CbPresentacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbPresentacion.FormattingEnabled = True
        Me.CbPresentacion.Items.AddRange(New Object() {"Capsulas", "Inyección", "Jarabe", "Pastillas"})
        Me.CbPresentacion.Location = New System.Drawing.Point(111, 100)
        Me.CbPresentacion.Name = "CbPresentacion"
        Me.CbPresentacion.Size = New System.Drawing.Size(165, 21)
        Me.CbPresentacion.TabIndex = 170
        Me.CbPresentacion.Text = "Seleccione una opción"
        '
        'VId
        '
        Me.VId.AutoSize = True
        Me.VId.ForeColor = System.Drawing.Color.Maroon
        Me.VId.Location = New System.Drawing.Point(89, 37)
        Me.VId.Name = "VId"
        Me.VId.Size = New System.Drawing.Size(0, 17)
        Me.VId.TabIndex = 171
        '
        'VNombre
        '
        Me.VNombre.AutoSize = True
        Me.VNombre.ForeColor = System.Drawing.Color.Maroon
        Me.VNombre.Location = New System.Drawing.Point(89, 83)
        Me.VNombre.Name = "VNombre"
        Me.VNombre.Size = New System.Drawing.Size(0, 17)
        Me.VNombre.TabIndex = 172
        '
        'VPres
        '
        Me.VPres.AutoSize = True
        Me.VPres.ForeColor = System.Drawing.Color.Maroon
        Me.VPres.Location = New System.Drawing.Point(105, 119)
        Me.VPres.Name = "VPres"
        Me.VPres.Size = New System.Drawing.Size(0, 17)
        Me.VPres.TabIndex = 173
        '
        'VClas
        '
        Me.VClas.AutoSize = True
        Me.VClas.ForeColor = System.Drawing.Color.Maroon
        Me.VClas.Location = New System.Drawing.Point(103, 161)
        Me.VClas.Name = "VClas"
        Me.VClas.Size = New System.Drawing.Size(0, 17)
        Me.VClas.TabIndex = 174
        '
        'Detalles
        '
        Me.Detalles.Controls.Add(Me.CbClasificacion)
        Me.Detalles.Controls.Add(Me.VClas)
        Me.Detalles.Controls.Add(Me.LblNombre)
        Me.Detalles.Controls.Add(Me.VPres)
        Me.Detalles.Controls.Add(Me.LbIdMedicamento)
        Me.Detalles.Controls.Add(Me.VNombre)
        Me.Detalles.Controls.Add(Me.LblClasificacion)
        Me.Detalles.Controls.Add(Me.VId)
        Me.Detalles.Controls.Add(Me.TxtMedicamento)
        Me.Detalles.Controls.Add(Me.CbPresentacion)
        Me.Detalles.Controls.Add(Me.TxtNombre)
        Me.Detalles.Controls.Add(Me.LbPresentacion)
        Me.Detalles.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Detalles.Location = New System.Drawing.Point(14, 152)
        Me.Detalles.Name = "Detalles"
        Me.Detalles.Size = New System.Drawing.Size(457, 180)
        Me.Detalles.TabIndex = 176
        Me.Detalles.TabStop = False
        Me.Detalles.Text = "Detalles"
        Me.Detalles.Visible = False
        '
        'Filtro
        '
        Me.Filtro.Controls.Add(Me.TextFClasificacion)
        Me.Filtro.Controls.Add(Me.TextFPresentacion)
        Me.Filtro.Controls.Add(Me.TextBNombre)
        Me.Filtro.Controls.Add(Me.TxtFiltro)
        Me.Filtro.Controls.Add(Me.CbFiltro)
        Me.Filtro.Controls.Add(Me.Label12)
        Me.Filtro.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Filtro.Location = New System.Drawing.Point(12, 61)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(401, 64)
        Me.Filtro.TabIndex = 177
        Me.Filtro.TabStop = False
        Me.Filtro.Text = "Filtro de Consultas"
        '
        'TextFClasificacion
        '
        Me.TextFClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFClasificacion.Location = New System.Drawing.Point(216, 19)
        Me.TextFClasificacion.Name = "TextFClasificacion"
        Me.TextFClasificacion.Size = New System.Drawing.Size(165, 20)
        Me.TextFClasificacion.TabIndex = 180
        Me.TextFClasificacion.Visible = False
        '
        'TextFPresentacion
        '
        Me.TextFPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFPresentacion.Location = New System.Drawing.Point(216, 20)
        Me.TextFPresentacion.Name = "TextFPresentacion"
        Me.TextFPresentacion.Size = New System.Drawing.Size(165, 20)
        Me.TextFPresentacion.TabIndex = 179
        Me.TextFPresentacion.Visible = False
        '
        'TextBNombre
        '
        Me.TextBNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBNombre.Location = New System.Drawing.Point(216, 19)
        Me.TextBNombre.Name = "TextBNombre"
        Me.TextBNombre.Size = New System.Drawing.Size(165, 20)
        Me.TextBNombre.TabIndex = 169
        Me.TextBNombre.Visible = False
        '
        'MEDICAMENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(684, 405)
        Me.Controls.Add(Me.Filtro)
        Me.Controls.Add(Me.Detalles)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Name = "MEDICAMENTO"
        Me.Detalles.ResumeLayout(False)
        Me.Detalles.PerformLayout()
        Me.Filtro.ResumeLayout(False)
        Me.Filtro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbClasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents LblClasificacion As System.Windows.Forms.Label
    Friend WithEvents LbIdMedicamento As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxtMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents LbPresentacion As System.Windows.Forms.Label
    Friend WithEvents CbPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents VId As System.Windows.Forms.Label
    Friend WithEvents VNombre As System.Windows.Forms.Label
    Friend WithEvents VPres As System.Windows.Forms.Label
    Friend WithEvents VClas As System.Windows.Forms.Label
    Friend WithEvents Detalles As GroupBox
    Friend WithEvents Filtro As GroupBox
    Friend WithEvents TextBNombre As TextBox
    Friend WithEvents TextFPresentacion As TextBox
    Friend WithEvents TextFClasificacion As TextBox
End Class
