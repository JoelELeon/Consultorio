<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Citas
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxCitas = New System.Windows.Forms.GroupBox()
        Me.lblBuscarNombre = New System.Windows.Forms.Label()
        Me.lblBuscarApellido = New System.Windows.Forms.Label()
        Me.txtBuscarApellido = New System.Windows.Forms.TextBox()
        Me.txtBuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dgvCitas = New System.Windows.Forms.DataGridView()
        Me.btnTraerCitas = New System.Windows.Forms.Button()
        Me.gbxCambiarCita = New System.Windows.Forms.GroupBox()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.lblNombreCompleto = New System.Windows.Forms.Label()
        Me.btnCambiarCita = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpCambiarFecha = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblIDCita = New System.Windows.Forms.Label()
        Me.gbxCitas.SuspendLayout()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCambiarCita.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(30, 300)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 52)
        Me.btnSalir.TabIndex = 51
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'gbxCitas
        '
        Me.gbxCitas.Controls.Add(Me.lblBuscarNombre)
        Me.gbxCitas.Controls.Add(Me.lblBuscarApellido)
        Me.gbxCitas.Controls.Add(Me.txtBuscarApellido)
        Me.gbxCitas.Controls.Add(Me.txtBuscarNombre)
        Me.gbxCitas.Controls.Add(Me.Label3)
        Me.gbxCitas.Controls.Add(Me.Label1)
        Me.gbxCitas.Controls.Add(Me.dtpHasta)
        Me.gbxCitas.Controls.Add(Me.dtpDesde)
        Me.gbxCitas.Controls.Add(Me.dgvCitas)
        Me.gbxCitas.Controls.Add(Me.btnTraerCitas)
        Me.gbxCitas.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCitas.Location = New System.Drawing.Point(12, 12)
        Me.gbxCitas.Name = "gbxCitas"
        Me.gbxCitas.Size = New System.Drawing.Size(506, 260)
        Me.gbxCitas.TabIndex = 57
        Me.gbxCitas.TabStop = False
        Me.gbxCitas.Text = "Citas creadas"
        '
        'lblBuscarNombre
        '
        Me.lblBuscarNombre.AutoSize = True
        Me.lblBuscarNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarNombre.Location = New System.Drawing.Point(12, 48)
        Me.lblBuscarNombre.Name = "lblBuscarNombre"
        Me.lblBuscarNombre.Size = New System.Drawing.Size(53, 16)
        Me.lblBuscarNombre.TabIndex = 85
        Me.lblBuscarNombre.Text = "Nombre:"
        '
        'lblBuscarApellido
        '
        Me.lblBuscarApellido.AutoSize = True
        Me.lblBuscarApellido.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarApellido.Location = New System.Drawing.Point(207, 48)
        Me.lblBuscarApellido.Name = "lblBuscarApellido"
        Me.lblBuscarApellido.Size = New System.Drawing.Size(54, 16)
        Me.lblBuscarApellido.TabIndex = 84
        Me.lblBuscarApellido.Text = "Apellido:"
        '
        'txtBuscarApellido
        '
        Me.txtBuscarApellido.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarApellido.Location = New System.Drawing.Point(267, 45)
        Me.txtBuscarApellido.Name = "txtBuscarApellido"
        Me.txtBuscarApellido.Size = New System.Drawing.Size(125, 21)
        Me.txtBuscarApellido.TabIndex = 83
        '
        'txtBuscarNombre
        '
        Me.txtBuscarNombre.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarNombre.Location = New System.Drawing.Point(73, 46)
        Me.txtBuscarNombre.Name = "txtBuscarNombre"
        Me.txtBuscarNombre.Size = New System.Drawing.Size(128, 21)
        Me.txtBuscarNombre.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Desde:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(257, 19)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(135, 21)
        Me.dtpHasta.TabIndex = 60
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(65, 19)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(136, 21)
        Me.dtpDesde.TabIndex = 59
        '
        'dgvCitas
        '
        Me.dgvCitas.AllowUserToAddRows = False
        Me.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitas.Location = New System.Drawing.Point(15, 73)
        Me.dgvCitas.Name = "dgvCitas"
        Me.dgvCitas.RowHeadersVisible = False
        Me.dgvCitas.Size = New System.Drawing.Size(477, 173)
        Me.dgvCitas.TabIndex = 58
        '
        'btnTraerCitas
        '
        Me.btnTraerCitas.Location = New System.Drawing.Point(398, 19)
        Me.btnTraerCitas.Name = "btnTraerCitas"
        Me.btnTraerCitas.Size = New System.Drawing.Size(94, 45)
        Me.btnTraerCitas.TabIndex = 57
        Me.btnTraerCitas.Text = "Traer citas"
        Me.btnTraerCitas.UseVisualStyleBackColor = True
        '
        'gbxCambiarCita
        '
        Me.gbxCambiarCita.Controls.Add(Me.txtNombrePaciente)
        Me.gbxCambiarCita.Controls.Add(Me.lblNombreCompleto)
        Me.gbxCambiarCita.Controls.Add(Me.btnCambiarCita)
        Me.gbxCambiarCita.Controls.Add(Me.lblFecha)
        Me.gbxCambiarCita.Controls.Add(Me.dtpCambiarFecha)
        Me.gbxCambiarCita.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCambiarCita.Location = New System.Drawing.Point(108, 279)
        Me.gbxCambiarCita.Name = "gbxCambiarCita"
        Me.gbxCambiarCita.Size = New System.Drawing.Size(410, 89)
        Me.gbxCambiarCita.TabIndex = 58
        Me.gbxCambiarCita.TabStop = False
        Me.gbxCambiarCita.Text = "Cambiar Fecha de la Cita"
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Enabled = False
        Me.txtNombrePaciente.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePaciente.Location = New System.Drawing.Point(65, 54)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(228, 21)
        Me.txtNombrePaciente.TabIndex = 86
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.AutoSize = True
        Me.lblNombreCompleto.Location = New System.Drawing.Point(6, 57)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(53, 16)
        Me.lblNombreCompleto.TabIndex = 89
        Me.lblNombreCompleto.Text = "Nombre:"
        '
        'btnCambiarCita
        '
        Me.btnCambiarCita.Location = New System.Drawing.Point(299, 21)
        Me.btnCambiarCita.Name = "btnCambiarCita"
        Me.btnCambiarCita.Size = New System.Drawing.Size(103, 56)
        Me.btnCambiarCita.TabIndex = 88
        Me.btnCambiarCita.Text = "Cambiar fecha"
        Me.btnCambiarCita.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(6, 25)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(76, 16)
        Me.lblFecha.TabIndex = 87
        Me.lblFecha.Text = "Nueva fecha:"
        '
        'dtpCambiarFecha
        '
        Me.dtpCambiarFecha.Location = New System.Drawing.Point(88, 21)
        Me.dtpCambiarFecha.Name = "dtpCambiarFecha"
        Me.dtpCambiarFecha.Size = New System.Drawing.Size(205, 21)
        Me.dtpCambiarFecha.TabIndex = 86
        '
        'lblIDCita
        '
        Me.lblIDCita.AutoSize = True
        Me.lblIDCita.Location = New System.Drawing.Point(651, 143)
        Me.lblIDCita.Name = "lblIDCita"
        Me.lblIDCita.Size = New System.Drawing.Size(0, 13)
        Me.lblIDCita.TabIndex = 86
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(529, 390)
        Me.Controls.Add(Me.lblIDCita)
        Me.Controls.Add(Me.gbxCambiarCita)
        Me.Controls.Add(Me.gbxCitas)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "Citas"
        Me.ShowIcon = False
        Me.Text = "Citas"
        Me.gbxCitas.ResumeLayout(False)
        Me.gbxCitas.PerformLayout()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCambiarCita.ResumeLayout(False)
        Me.gbxCambiarCita.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As Button
    Friend WithEvents gbxCitas As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents dgvCitas As DataGridView
    Friend WithEvents btnTraerCitas As Button
    Friend WithEvents lblBuscarNombre As Label
    Friend WithEvents lblBuscarApellido As Label
    Friend WithEvents txtBuscarApellido As TextBox
    Friend WithEvents txtBuscarNombre As TextBox
    Friend WithEvents gbxCambiarCita As GroupBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpCambiarFecha As DateTimePicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnCambiarCita As Button
    Friend WithEvents lblIDCita As Label
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents lblNombreCompleto As Label
End Class
