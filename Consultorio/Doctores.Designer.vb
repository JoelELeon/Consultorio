<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctores
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
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardarDoctor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDoctores = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cmbEspecialidades = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.gbxDoctor = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        CType(Me.dgvDoctores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDoctor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(304, 61)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(111, 24)
        Me.btnActualizar.TabIndex = 10
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnGuardarDoctor
        '
        Me.btnGuardarDoctor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardarDoctor.Location = New System.Drawing.Point(445, 61)
        Me.btnGuardarDoctor.Name = "btnGuardarDoctor"
        Me.btnGuardarDoctor.Size = New System.Drawing.Size(111, 24)
        Me.btnGuardarDoctor.TabIndex = 11
        Me.btnGuardarDoctor.Text = "Guardar doctor"
        Me.btnGuardarDoctor.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Lista de doctores"
        '
        'dgvDoctores
        '
        Me.dgvDoctores.AllowUserToAddRows = False
        Me.dgvDoctores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoctores.Location = New System.Drawing.Point(15, 25)
        Me.dgvDoctores.Name = "dgvDoctores"
        Me.dgvDoctores.RowHeadersVisible = False
        Me.dgvDoctores.RowHeadersWidth = 102
        Me.dgvDoctores.Size = New System.Drawing.Size(564, 212)
        Me.dgvDoctores.TabIndex = 20
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(150, 61)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(111, 25)
        Me.btnBuscar.TabIndex = 22
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Location = New System.Drawing.Point(359, 28)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(70, 13)
        Me.lblEspecialidad.TabIndex = 46
        Me.lblEspecialidad.Text = "Especialidad:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(241, 25)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(112, 20)
        Me.txtApellido.TabIndex = 40
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(59, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(123, 20)
        Me.txtNombre.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(417, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 38
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(188, 27)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 34
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 33
        Me.lblNombre.Text = "Nombre:"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(165, 348)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(111, 23)
        Me.btnSalir.TabIndex = 50
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'cmbEspecialidades
        '
        Me.cmbEspecialidades.FormattingEnabled = True
        Me.cmbEspecialidades.Location = New System.Drawing.Point(435, 23)
        Me.cmbEspecialidades.Name = "cmbEspecialidades"
        Me.cmbEspecialidades.Size = New System.Drawing.Size(119, 21)
        Me.cmbEspecialidades.TabIndex = 51
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(9, 61)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(111, 25)
        Me.btnEliminar.TabIndex = 52
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'gbxDoctor
        '
        Me.gbxDoctor.Controls.Add(Me.cmbEspecialidades)
        Me.gbxDoctor.Controls.Add(Me.lblEspecialidad)
        Me.gbxDoctor.Controls.Add(Me.txtApellido)
        Me.gbxDoctor.Controls.Add(Me.lblApellido)
        Me.gbxDoctor.Controls.Add(Me.txtNombre)
        Me.gbxDoctor.Controls.Add(Me.lblNombre)
        Me.gbxDoctor.Controls.Add(Me.btnEliminar)
        Me.gbxDoctor.Controls.Add(Me.btnGuardarDoctor)
        Me.gbxDoctor.Controls.Add(Me.btnBuscar)
        Me.gbxDoctor.Controls.Add(Me.btnActualizar)
        Me.gbxDoctor.Location = New System.Drawing.Point(15, 243)
        Me.gbxDoctor.Name = "gbxDoctor"
        Me.gbxDoctor.Size = New System.Drawing.Size(564, 99)
        Me.gbxDoctor.TabIndex = 58
        Me.gbxDoctor.TabStop = False
        Me.gbxDoctor.Text = "Datos del doctor"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(727, 125)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 53
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(319, 348)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(111, 23)
        Me.btnLimpiarCampos.TabIndex = 59
        Me.btnLimpiarCampos.Text = "Limpiar Campos"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'Doctores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(592, 378)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.gbxDoctor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDoctores)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Doctores"
        Me.ShowIcon = False
        Me.Text = "Doctor"
        CType(Me.dgvDoctores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDoctor.ResumeLayout(False)
        Me.gbxDoctor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardarDoctor As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDoctores As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblEspecialidad As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents cmbEspecialidades As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents gbxDoctor As GroupBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnLimpiarCampos As Button
End Class
