<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pacientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardarPaciente = New System.Windows.Forms.Button()
        Me.btnSignosVitales = New System.Windows.Forms.Button()
        Me.btnCrearCita = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.txtBuscarNombre = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.lblSeguro = New System.Windows.Forms.Label()
        Me.cmbPueblos = New System.Windows.Forms.ComboBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblPueblo = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.rdbHombre = New System.Windows.Forms.RadioButton()
        Me.rdbMujer = New System.Windows.Forms.RadioButton()
        Me.gbxGenero = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtBuscarApellido = New System.Windows.Forms.TextBox()
        Me.gbxPaciente = New System.Windows.Forms.GroupBox()
        Me.cmbPlanesMedicos = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblBuscarApellido = New System.Windows.Forms.Label()
        Me.lblBuscarNombre = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxGenero.SuspendLayout()
        Me.gbxPaciente.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(156, 370)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(128, 23)
        Me.btnActualizar.TabIndex = 0
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnGuardarPaciente
        '
        Me.btnGuardarPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardarPaciente.Location = New System.Drawing.Point(384, 104)
        Me.btnGuardarPaciente.Name = "btnGuardarPaciente"
        Me.btnGuardarPaciente.Size = New System.Drawing.Size(158, 28)
        Me.btnGuardarPaciente.TabIndex = 1
        Me.btnGuardarPaciente.Text = "Guardar paciente"
        Me.btnGuardarPaciente.UseVisualStyleBackColor = False
        '
        'btnSignosVitales
        '
        Me.btnSignosVitales.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignosVitales.Location = New System.Drawing.Point(292, 370)
        Me.btnSignosVitales.Name = "btnSignosVitales"
        Me.btnSignosVitales.Size = New System.Drawing.Size(128, 23)
        Me.btnSignosVitales.TabIndex = 3
        Me.btnSignosVitales.Text = "Signos Vitales"
        Me.btnSignosVitales.UseVisualStyleBackColor = True
        '
        'btnCrearCita
        '
        Me.btnCrearCita.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCita.Location = New System.Drawing.Point(426, 370)
        Me.btnCrearCita.Name = "btnCrearCita"
        Me.btnCrearCita.Size = New System.Drawing.Size(128, 23)
        Me.btnCrearCita.TabIndex = 10
        Me.btnCrearCita.Text = "Crear Cita"
        Me.btnCrearCita.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Lista de pacientes"
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToAddRows = False
        Me.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(22, 56)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.RowHeadersVisible = False
        Me.dgvPacientes.RowHeadersWidth = 102
        Me.dgvPacientes.Size = New System.Drawing.Size(532, 167)
        Me.dgvPacientes.TabIndex = 13
        '
        'txtBuscarNombre
        '
        Me.txtBuscarNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarNombre.Location = New System.Drawing.Point(161, 17)
        Me.txtBuscarNombre.Name = "txtBuscarNombre"
        Me.txtBuscarNombre.Size = New System.Drawing.Size(101, 21)
        Me.txtBuscarNombre.TabIndex = 14
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(428, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(217, 417)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 31)
        Me.btnSalir.TabIndex = 51
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(116, 52)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(218, 22)
        Me.dtpFechaNacimiento.TabIndex = 72
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(7, 56)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(103, 15)
        Me.lblFechaNacimiento.TabIndex = 68
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(340, 56)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(56, 15)
        Me.lblTelefono.TabIndex = 67
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(407, 53)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(135, 22)
        Me.txtTelefono.TabIndex = 66
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(270, 107)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(108, 22)
        Me.txtZipCode.TabIndex = 65
        '
        'lblSeguro
        '
        Me.lblSeguro.AutoSize = True
        Me.lblSeguro.Location = New System.Drawing.Point(7, 85)
        Me.lblSeguro.Name = "lblSeguro"
        Me.lblSeguro.Size = New System.Drawing.Size(89, 15)
        Me.lblSeguro.TabIndex = 63
        Me.lblSeguro.Text = "Seguro Medico:"
        '
        'cmbPueblos
        '
        Me.cmbPueblos.FormattingEnabled = True
        Me.cmbPueblos.Location = New System.Drawing.Point(62, 107)
        Me.cmbPueblos.Name = "cmbPueblos"
        Me.cmbPueblos.Size = New System.Drawing.Size(139, 23)
        Me.cmbPueblos.TabIndex = 62
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(270, 82)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(272, 22)
        Me.txtCalle.TabIndex = 61
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(238, 20)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(91, 22)
        Me.txtApellido.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 15)
        Me.Label7.TabIndex = 58
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(207, 111)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(57, 15)
        Me.lblZipCode.TabIndex = 57
        Me.lblZipCode.Text = "Zip Code:"
        '
        'lblPueblo
        '
        Me.lblPueblo.AutoSize = True
        Me.lblPueblo.Location = New System.Drawing.Point(11, 110)
        Me.lblPueblo.Name = "lblPueblo"
        Me.lblPueblo.Size = New System.Drawing.Size(47, 15)
        Me.lblPueblo.TabIndex = 56
        Me.lblPueblo.Text = "Pueblo:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(229, 84)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(35, 15)
        Me.lblCalle.TabIndex = 55
        Me.lblCalle.Text = "Calle:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(176, 22)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(54, 15)
        Me.lblApellido.TabIndex = 54
        Me.lblApellido.Text = "Apellido:"
        '
        'rdbHombre
        '
        Me.rdbHombre.AutoSize = True
        Me.rdbHombre.Location = New System.Drawing.Point(35, 14)
        Me.rdbHombre.Name = "rdbHombre"
        Me.rdbHombre.Size = New System.Drawing.Size(67, 19)
        Me.rdbHombre.TabIndex = 73
        Me.rdbHombre.TabStop = True
        Me.rdbHombre.Text = "Hombre" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.rdbHombre.UseVisualStyleBackColor = True
        '
        'rdbMujer
        '
        Me.rdbMujer.AutoSize = True
        Me.rdbMujer.Location = New System.Drawing.Point(134, 14)
        Me.rdbMujer.Name = "rdbMujer"
        Me.rdbMujer.Size = New System.Drawing.Size(56, 19)
        Me.rdbMujer.TabIndex = 74
        Me.rdbMujer.TabStop = True
        Me.rdbMujer.Text = "Mujer"
        Me.rdbMujer.UseVisualStyleBackColor = True
        '
        'gbxGenero
        '
        Me.gbxGenero.Controls.Add(Me.rdbHombre)
        Me.gbxGenero.Controls.Add(Me.rdbMujer)
        Me.gbxGenero.Location = New System.Drawing.Point(343, 12)
        Me.gbxGenero.Name = "gbxGenero"
        Me.gbxGenero.Size = New System.Drawing.Size(199, 37)
        Me.gbxGenero.TabIndex = 75
        Me.gbxGenero.TabStop = False
        Me.gbxGenero.Text = "Genero"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(1204, 69)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 76
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(22, 370)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(128, 23)
        Me.btnEliminar.TabIndex = 77
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'txtBuscarApellido
        '
        Me.txtBuscarApellido.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarApellido.Location = New System.Drawing.Point(321, 16)
        Me.txtBuscarApellido.Name = "txtBuscarApellido"
        Me.txtBuscarApellido.Size = New System.Drawing.Size(101, 21)
        Me.txtBuscarApellido.TabIndex = 78
        '
        'gbxPaciente
        '
        Me.gbxPaciente.Controls.Add(Me.cmbPlanesMedicos)
        Me.gbxPaciente.Controls.Add(Me.txtNombre)
        Me.gbxPaciente.Controls.Add(Me.lblNombre)
        Me.gbxPaciente.Controls.Add(Me.lblApellido)
        Me.gbxPaciente.Controls.Add(Me.txtApellido)
        Me.gbxPaciente.Controls.Add(Me.txtZipCode)
        Me.gbxPaciente.Controls.Add(Me.lblTelefono)
        Me.gbxPaciente.Controls.Add(Me.lblZipCode)
        Me.gbxPaciente.Controls.Add(Me.cmbPueblos)
        Me.gbxPaciente.Controls.Add(Me.Label7)
        Me.gbxPaciente.Controls.Add(Me.txtCalle)
        Me.gbxPaciente.Controls.Add(Me.btnGuardarPaciente)
        Me.gbxPaciente.Controls.Add(Me.txtTelefono)
        Me.gbxPaciente.Controls.Add(Me.lblPueblo)
        Me.gbxPaciente.Controls.Add(Me.lblSeguro)
        Me.gbxPaciente.Controls.Add(Me.gbxGenero)
        Me.gbxPaciente.Controls.Add(Me.lblFechaNacimiento)
        Me.gbxPaciente.Controls.Add(Me.lblCalle)
        Me.gbxPaciente.Controls.Add(Me.dtpFechaNacimiento)
        Me.gbxPaciente.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPaciente.Location = New System.Drawing.Point(12, 229)
        Me.gbxPaciente.Name = "gbxPaciente"
        Me.gbxPaciente.Size = New System.Drawing.Size(560, 135)
        Me.gbxPaciente.TabIndex = 79
        Me.gbxPaciente.TabStop = False
        Me.gbxPaciente.Text = "Paciente"
        '
        'cmbPlanesMedicos
        '
        Me.cmbPlanesMedicos.FormattingEnabled = True
        Me.cmbPlanesMedicos.Location = New System.Drawing.Point(99, 81)
        Me.cmbPlanesMedicos.Name = "cmbPlanesMedicos"
        Me.cmbPlanesMedicos.Size = New System.Drawing.Size(124, 23)
        Me.cmbPlanesMedicos.TabIndex = 76
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(67, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(93, 22)
        Me.txtNombre.TabIndex = 59
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(7, 22)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(53, 15)
        Me.lblNombre.TabIndex = 53
        Me.lblNombre.Text = "Nombre:"
        '
        'lblBuscarApellido
        '
        Me.lblBuscarApellido.AutoSize = True
        Me.lblBuscarApellido.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarApellido.Location = New System.Drawing.Point(268, 18)
        Me.lblBuscarApellido.Name = "lblBuscarApellido"
        Me.lblBuscarApellido.Size = New System.Drawing.Size(54, 16)
        Me.lblBuscarApellido.TabIndex = 80
        Me.lblBuscarApellido.Text = "Apellido:"
        '
        'lblBuscarNombre
        '
        Me.lblBuscarNombre.AutoSize = True
        Me.lblBuscarNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarNombre.Location = New System.Drawing.Point(108, 19)
        Me.lblBuscarNombre.Name = "lblBuscarNombre"
        Me.lblBuscarNombre.Size = New System.Drawing.Size(53, 16)
        Me.lblBuscarNombre.TabIndex = 81
        Me.lblBuscarNombre.Text = "Nombre:"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(509, 14)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(63, 23)
        Me.btnLimpiar.TabIndex = 82
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Pacientes
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(581, 460)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblBuscarNombre)
        Me.Controls.Add(Me.lblBuscarApellido)
        Me.Controls.Add(Me.gbxPaciente)
        Me.Controls.Add(Me.txtBuscarApellido)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscarNombre)
        Me.Controls.Add(Me.dgvPacientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCrearCita)
        Me.Controls.Add(Me.btnSignosVitales)
        Me.Controls.Add(Me.btnActualizar)
        Me.DoubleBuffered = True
        Me.Name = "Pacientes"
        Me.ShowIcon = False
        Me.Text = "Paciente"
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxGenero.ResumeLayout(False)
        Me.gbxGenero.PerformLayout()
        Me.gbxPaciente.ResumeLayout(False)
        Me.gbxPaciente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardarPaciente As Button
    Friend WithEvents btnSignosVitales As Button
    Friend WithEvents btnCrearCita As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents txtBuscarNombre As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents lblSeguro As Label
    Friend WithEvents cmbPueblos As ComboBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblPueblo As Label
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents rdbHombre As RadioButton
    Friend WithEvents rdbMujer As RadioButton
    Friend WithEvents gbxGenero As GroupBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtBuscarApellido As TextBox
    Friend WithEvents gbxPaciente As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblBuscarApellido As Label
    Friend WithEvents lblBuscarNombre As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cmbPlanesMedicos As ComboBox
End Class
