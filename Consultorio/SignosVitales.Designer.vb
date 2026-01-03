<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignosVitales
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtFrecuencia = New System.Windows.Forms.TextBox()
        Me.txtPresion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblIDCita = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxSignosVitales = New System.Windows.Forms.GroupBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.dgvCitas = New System.Windows.Forms.DataGridView()
        Me.gbxListaVitales = New System.Windows.Forms.GroupBox()
        Me.gbxSignosVitales.SuspendLayout()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxListaVitales.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(284, 102)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(125, 23)
        Me.btnGuardar.TabIndex = 33
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(9, 102)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 23)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Location = New System.Drawing.Point(357, 76)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(52, 21)
        Me.txtTemperatura.TabIndex = 31
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(188, 76)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(52, 21)
        Me.txtAltura.TabIndex = 30
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(46, 76)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(48, 21)
        Me.txtPeso.TabIndex = 29
        '
        'txtFrecuencia
        '
        Me.txtFrecuencia.Location = New System.Drawing.Point(310, 49)
        Me.txtFrecuencia.Name = "txtFrecuencia"
        Me.txtFrecuencia.Size = New System.Drawing.Size(100, 21)
        Me.txtFrecuencia.TabIndex = 28
        '
        'txtPresion
        '
        Me.txtPresion.Location = New System.Drawing.Point(91, 49)
        Me.txtPresion.Name = "txtPresion"
        Me.txtPresion.Size = New System.Drawing.Size(100, 21)
        Me.txtPresion.TabIndex = 27
        '
        'txtApellido
        '
        Me.txtApellido.Enabled = False
        Me.txtApellido.Location = New System.Drawing.Point(254, 22)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(156, 21)
        Me.txtApellido.TabIndex = 26
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(59, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(132, 21)
        Me.txtNombre.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Temperatura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(145, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Altura:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Peso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Frecuencia cardiaca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Presión arterial:"
        '
        'lblIDCita
        '
        Me.lblIDCita.AutoSize = True
        Me.lblIDCita.Location = New System.Drawing.Point(590, 285)
        Me.lblIDCita.Name = "lblIDCita"
        Me.lblIDCita.Size = New System.Drawing.Size(0, 13)
        Me.lblIDCita.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre:"
        '
        'gbxSignosVitales
        '
        Me.gbxSignosVitales.Controls.Add(Me.lblApellido)
        Me.gbxSignosVitales.Controls.Add(Me.btnLimpiarCampos)
        Me.gbxSignosVitales.Controls.Add(Me.Label2)
        Me.gbxSignosVitales.Controls.Add(Me.btnGuardar)
        Me.gbxSignosVitales.Controls.Add(Me.btnSalir)
        Me.gbxSignosVitales.Controls.Add(Me.txtNombre)
        Me.gbxSignosVitales.Controls.Add(Me.txtTemperatura)
        Me.gbxSignosVitales.Controls.Add(Me.txtApellido)
        Me.gbxSignosVitales.Controls.Add(Me.Label8)
        Me.gbxSignosVitales.Controls.Add(Me.txtAltura)
        Me.gbxSignosVitales.Controls.Add(Me.Label4)
        Me.gbxSignosVitales.Controls.Add(Me.txtPeso)
        Me.gbxSignosVitales.Controls.Add(Me.Label7)
        Me.gbxSignosVitales.Controls.Add(Me.txtPresion)
        Me.gbxSignosVitales.Controls.Add(Me.txtFrecuencia)
        Me.gbxSignosVitales.Controls.Add(Me.Label5)
        Me.gbxSignosVitales.Controls.Add(Me.Label6)
        Me.gbxSignosVitales.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSignosVitales.Location = New System.Drawing.Point(12, 338)
        Me.gbxSignosVitales.Name = "gbxSignosVitales"
        Me.gbxSignosVitales.Size = New System.Drawing.Size(425, 134)
        Me.gbxSignosVitales.TabIndex = 34
        Me.gbxSignosVitales.TabStop = False
        Me.gbxSignosVitales.Text = "Signos vitales"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(197, 25)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(54, 16)
        Me.lblApellido.TabIndex = 35
        Me.lblApellido.Text = "Apellido:"
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.BackColor = System.Drawing.Color.White
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(148, 102)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(92, 23)
        Me.btnLimpiarCampos.TabIndex = 34
        Me.btnLimpiarCampos.Text = "Limpiar campos"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = False
        '
        'dgvCitas
        '
        Me.dgvCitas.AllowUserToAddRows = False
        Me.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitas.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvCitas.Location = New System.Drawing.Point(6, 19)
        Me.dgvCitas.Name = "dgvCitas"
        Me.dgvCitas.RowHeadersVisible = False
        Me.dgvCitas.Size = New System.Drawing.Size(413, 295)
        Me.dgvCitas.TabIndex = 35
        '
        'gbxListaVitales
        '
        Me.gbxListaVitales.Controls.Add(Me.dgvCitas)
        Me.gbxListaVitales.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxListaVitales.Location = New System.Drawing.Point(12, 12)
        Me.gbxListaVitales.Name = "gbxListaVitales"
        Me.gbxListaVitales.Size = New System.Drawing.Size(425, 320)
        Me.gbxListaVitales.TabIndex = 36
        Me.gbxListaVitales.TabStop = False
        Me.gbxListaVitales.Text = "Lista de Citas"
        '
        'SignosVitales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(449, 478)
        Me.Controls.Add(Me.gbxListaVitales)
        Me.Controls.Add(Me.gbxSignosVitales)
        Me.Controls.Add(Me.lblIDCita)
        Me.Name = "SignosVitales"
        Me.ShowIcon = False
        Me.Text = "Signos Vitales"
        Me.gbxSignosVitales.ResumeLayout(False)
        Me.gbxSignosVitales.PerformLayout()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxListaVitales.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtFrecuencia As TextBox
    Friend WithEvents txtPresion As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblIDCita As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbxSignosVitales As GroupBox
    Friend WithEvents dgvCitas As DataGridView
    Friend WithEvents gbxListaVitales As GroupBox
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents lblApellido As Label
End Class
