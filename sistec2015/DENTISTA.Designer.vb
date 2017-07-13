<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DENTISTA
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DENTISTA))
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbFiltro = New System.Windows.Forms.ComboBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.Detalles = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CombEsp = New System.Windows.Forms.ComboBox()
        Me.VEspecialidad = New System.Windows.Forms.Label()
        Me.VCelular = New System.Windows.Forms.Label()
        Me.VTelefono = New System.Windows.Forms.Label()
        Me.VNombre = New System.Windows.Forms.Label()
        Me.VId = New System.Windows.Forms.Label()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Especialidad = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.LblCelular = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.Label()
        Me.Filtro = New System.Windows.Forms.GroupBox()
        Me.TextEspec = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Detalles.SuspendLayout()
        Me.Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtFiltro
        '
        Me.TxtFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtFiltro.Location = New System.Drawing.Point(220, 23)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(151, 20)
        Me.TxtFiltro.TabIndex = 150
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(162, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 18)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "Filtro"
        '
        'CbFiltro
        '
        Me.CbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CbFiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbFiltro.FormattingEnabled = True
        Me.CbFiltro.Items.AddRange(New Object() {"ID", "Nombre", "Especialidad"})
        Me.CbFiltro.Location = New System.Drawing.Point(6, 22)
        Me.CbFiltro.Name = "CbFiltro"
        Me.CbFiltro.Size = New System.Drawing.Size(149, 21)
        Me.CbFiltro.TabIndex = 148
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(565, 46)
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
        Me.BtnEliminar.Location = New System.Drawing.Point(621, 46)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BtnEliminar.TabIndex = 140
        Me.BtnEliminar.UseVisualStyleBackColor = True
        Me.BtnEliminar.Visible = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.Enabled = False
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(539, 152)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(50, 50)
        Me.BtnAgregar.TabIndex = 138
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
        Me.BtnActualizar.Location = New System.Drawing.Point(610, 152)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(509, 46)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(50, 50)
        Me.BtnNuevo.TabIndex = 136
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label.Location = New System.Drawing.Point(207, 6)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(127, 30)
        Me.Label.TabIndex = 117
        Me.Label.Text = "DENTISTA"
        '
        'Detalles
        '
        Me.Detalles.Controls.Add(Me.Button1)
        Me.Detalles.Controls.Add(Me.CombEsp)
        Me.Detalles.Controls.Add(Me.VEspecialidad)
        Me.Detalles.Controls.Add(Me.VCelular)
        Me.Detalles.Controls.Add(Me.VTelefono)
        Me.Detalles.Controls.Add(Me.VNombre)
        Me.Detalles.Controls.Add(Me.VId)
        Me.Detalles.Controls.Add(Me.TxtCelular)
        Me.Detalles.Controls.Add(Me.TxtTelefono)
        Me.Detalles.Controls.Add(Me.TxtId)
        Me.Detalles.Controls.Add(Me.Telefono)
        Me.Detalles.Controls.Add(Me.TxtNombre)
        Me.Detalles.Controls.Add(Me.Especialidad)
        Me.Detalles.Controls.Add(Me.Nombre)
        Me.Detalles.Controls.Add(Me.LblCelular)
        Me.Detalles.Controls.Add(Me.Id)
        Me.Detalles.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Detalles.Location = New System.Drawing.Point(8, 137)
        Me.Detalles.Name = "Detalles"
        Me.Detalles.Size = New System.Drawing.Size(525, 196)
        Me.Detalles.TabIndex = 163
        Me.Detalles.TabStop = False
        Me.Detalles.Text = "Detalles"
        Me.Detalles.Visible = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(390, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 179
        Me.Button1.Text = "Horario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CombEsp
        '
        Me.CombEsp.Enabled = False
        Me.CombEsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombEsp.FormattingEnabled = True
        Me.CombEsp.Items.AddRange(New Object() {"Endodentista", "General", "Cirujano Oral", "Ortodoncista", "Pedodentista", "Periodentista"})
        Me.CombEsp.Location = New System.Drawing.Point(368, 76)
        Me.CombEsp.Name = "CombEsp"
        Me.CombEsp.Size = New System.Drawing.Size(137, 21)
        Me.CombEsp.TabIndex = 178
        '
        'VEspecialidad
        '
        Me.VEspecialidad.AutoSize = True
        Me.VEspecialidad.ForeColor = System.Drawing.Color.Maroon
        Me.VEspecialidad.Location = New System.Drawing.Point(371, 99)
        Me.VEspecialidad.Name = "VEspecialidad"
        Me.VEspecialidad.Size = New System.Drawing.Size(0, 17)
        Me.VEspecialidad.TabIndex = 177
        '
        'VCelular
        '
        Me.VCelular.AutoSize = True
        Me.VCelular.ForeColor = System.Drawing.Color.Maroon
        Me.VCelular.Location = New System.Drawing.Point(370, 56)
        Me.VCelular.Name = "VCelular"
        Me.VCelular.Size = New System.Drawing.Size(0, 17)
        Me.VCelular.TabIndex = 176
        '
        'VTelefono
        '
        Me.VTelefono.AutoSize = True
        Me.VTelefono.ForeColor = System.Drawing.Color.Maroon
        Me.VTelefono.Location = New System.Drawing.Point(106, 140)
        Me.VTelefono.Name = "VTelefono"
        Me.VTelefono.Size = New System.Drawing.Size(0, 17)
        Me.VTelefono.TabIndex = 175
        '
        'VNombre
        '
        Me.VNombre.AutoSize = True
        Me.VNombre.ForeColor = System.Drawing.Color.Maroon
        Me.VNombre.Location = New System.Drawing.Point(106, 97)
        Me.VNombre.Name = "VNombre"
        Me.VNombre.Size = New System.Drawing.Size(0, 17)
        Me.VNombre.TabIndex = 174
        '
        'VId
        '
        Me.VId.AutoSize = True
        Me.VId.ForeColor = System.Drawing.Color.Maroon
        Me.VId.Location = New System.Drawing.Point(106, 56)
        Me.VId.Name = "VId"
        Me.VId.Size = New System.Drawing.Size(0, 17)
        Me.VId.TabIndex = 173
        '
        'TxtCelular
        '
        Me.TxtCelular.Enabled = False
        Me.TxtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtCelular.Location = New System.Drawing.Point(368, 33)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(137, 20)
        Me.TxtCelular.TabIndex = 171
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Enabled = False
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTelefono.Location = New System.Drawing.Point(106, 117)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(142, 20)
        Me.TxtTelefono.TabIndex = 170
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtId.Location = New System.Drawing.Point(106, 34)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(142, 20)
        Me.TxtId.TabIndex = 168
        '
        'Telefono
        '
        Me.Telefono.AutoSize = True
        Me.Telefono.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Telefono.Location = New System.Drawing.Point(10, 119)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(64, 18)
        Me.Telefono.TabIndex = 167
        Me.Telefono.Text = "Teléfono"
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNombre.Location = New System.Drawing.Point(106, 75)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(142, 20)
        Me.TxtNombre.TabIndex = 169
        '
        'Especialidad
        '
        Me.Especialidad.AutoSize = True
        Me.Especialidad.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Especialidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Especialidad.Location = New System.Drawing.Point(272, 78)
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.Size = New System.Drawing.Size(90, 18)
        Me.Especialidad.TabIndex = 165
        Me.Especialidad.Text = "Especialidad"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nombre.Location = New System.Drawing.Point(10, 74)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(62, 18)
        Me.Nombre.TabIndex = 163
        Me.Nombre.Text = "Nombre"
        '
        'LblCelular
        '
        Me.LblCelular.AutoSize = True
        Me.LblCelular.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCelular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblCelular.Location = New System.Drawing.Point(274, 35)
        Me.LblCelular.Name = "LblCelular"
        Me.LblCelular.Size = New System.Drawing.Size(53, 18)
        Me.LblCelular.TabIndex = 166
        Me.LblCelular.Text = "Celular"
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Id.Location = New System.Drawing.Point(10, 35)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(22, 18)
        Me.Id.TabIndex = 164
        Me.Id.Text = "ID"
        '
        'Filtro
        '
        Me.Filtro.Controls.Add(Me.TextEspec)
        Me.Filtro.Controls.Add(Me.TextName)
        Me.Filtro.Controls.Add(Me.CbFiltro)
        Me.Filtro.Controls.Add(Me.Label12)
        Me.Filtro.Controls.Add(Me.TxtFiltro)
        Me.Filtro.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Filtro.Location = New System.Drawing.Point(8, 39)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(441, 87)
        Me.Filtro.TabIndex = 164
        Me.Filtro.TabStop = False
        Me.Filtro.Text = "Filtro de Consultas"
        '
        'TextEspec
        '
        Me.TextEspec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextEspec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextEspec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextEspec.Location = New System.Drawing.Point(220, 23)
        Me.TextEspec.Name = "TextEspec"
        Me.TextEspec.Size = New System.Drawing.Size(151, 20)
        Me.TextEspec.TabIndex = 152
        Me.TextEspec.Visible = False
        '
        'TextName
        '
        Me.TextName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextName.Location = New System.Drawing.Point(220, 24)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(151, 20)
        Me.TextName.TabIndex = 151
        Me.TextName.Visible = False
        '
        'DENTISTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(686, 360)
        Me.Controls.Add(Me.Filtro)
        Me.Controls.Add(Me.Detalles)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label)
        Me.Name = "DENTISTA"
        Me.Text = "DENTISTA"
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
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Detalles As GroupBox
    Friend WithEvents VEspecialidad As Label
    Friend WithEvents VCelular As Label
    Friend WithEvents VTelefono As Label
    Friend WithEvents VNombre As Label
    Friend WithEvents VId As Label
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Telefono As Label
    Friend WithEvents LblCelular As Label
    Friend WithEvents Especialidad As Label
    Friend WithEvents Id As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents Filtro As GroupBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents TextEspec As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CombEsp As ComboBox
    Friend WithEvents Button1 As Button
End Class
