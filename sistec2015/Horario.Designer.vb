<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Horario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtHorario = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lunes = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Martes = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Miercoles = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Jueves = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Viernes = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Sabado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BtnH = New System.Windows.Forms.Button()
        Me.Domingo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(465, 27)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(187, 17)
        Me.Label22.TabIndex = 116
        Me.Label22.Text = "Identificador del Dentista"
        '
        'TxtHorario
        '
        Me.TxtHorario.Enabled = False
        Me.TxtHorario.Location = New System.Drawing.Point(658, 26)
        Me.TxtHorario.Name = "TxtHorario"
        Me.TxtHorario.Size = New System.Drawing.Size(81, 20)
        Me.TxtHorario.TabIndex = 117
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Horas, Me.Lunes, Me.Martes, Me.Miercoles, Me.Jueves, Me.Viernes, Me.Sabado, Me.Domingo})
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV.Location = New System.Drawing.Point(12, 67)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(844, 414)
        Me.DGV.TabIndex = 118
        '
        'Horas
        '
        Me.Horas.HeaderText = "Horas"
        Me.Horas.Name = "Horas"
        Me.Horas.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Horas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Lunes
        '
        Me.Lunes.HeaderText = "Lunes"
        Me.Lunes.Name = "Lunes"
        Me.Lunes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Lunes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Martes
        '
        Me.Martes.HeaderText = "Martes"
        Me.Martes.Name = "Martes"
        '
        'Miercoles
        '
        Me.Miercoles.HeaderText = "Miercoles"
        Me.Miercoles.Name = "Miercoles"
        '
        'Jueves
        '
        Me.Jueves.HeaderText = "Jueves"
        Me.Jueves.Name = "Jueves"
        '
        'Viernes
        '
        Me.Viernes.HeaderText = "Viernes"
        Me.Viernes.Name = "Viernes"
        '
        'Sabado
        '
        Me.Sabado.HeaderText = "Sabado"
        Me.Sabado.Name = "Sabado"
        '
        'BtnH
        '
        Me.BtnH.Location = New System.Drawing.Point(748, 487)
        Me.BtnH.Name = "BtnH"
        Me.BtnH.Size = New System.Drawing.Size(108, 23)
        Me.BtnH.TabIndex = 119
        Me.BtnH.Text = "Asignar Horario"
        Me.BtnH.UseVisualStyleBackColor = True
        '
        'Domingo
        '
        Me.Domingo.HeaderText = "Domingo"
        Me.Domingo.Name = "Domingo"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(171, 27)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(233, 20)
        Me.TxtNombre.TabIndex = 121
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 17)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Nombre del Dentista"
        '
        'Horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(854, 511)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnH)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TxtHorario)
        Me.Controls.Add(Me.Label22)
        Me.Name = "Horario"
        Me.Text = "Horario"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtHorario As TextBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Horas As DataGridViewTextBoxColumn
    Friend WithEvents Lunes As DataGridViewCheckBoxColumn
    Friend WithEvents Martes As DataGridViewCheckBoxColumn
    Friend WithEvents Miercoles As DataGridViewCheckBoxColumn
    Friend WithEvents Jueves As DataGridViewCheckBoxColumn
    Friend WithEvents Viernes As DataGridViewCheckBoxColumn
    Friend WithEvents Sabado As DataGridViewCheckBoxColumn
    Friend WithEvents BtnH As Button
    Friend WithEvents Domingo As DataGridViewCheckBoxColumn
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
End Class
