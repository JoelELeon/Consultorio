<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearCita
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpCita = New System.Windows.Forms.DateTimePicker()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbDoctor = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbxCrearCita = New System.Windows.Forms.GroupBox()
        Me.gbxCrearCita.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'dtpCita
        '
        Me.dtpCita.Location = New System.Drawing.Point(58, 90)
        Me.dtpCita.Name = "dtpCita"
        Me.dtpCita.Size = New System.Drawing.Size(188, 20)
        Me.dtpCita.TabIndex = 4
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(48, 36)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(198, 21)
        Me.cmbTipo.TabIndex = 6
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(31, 140)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(104, 23)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(141, 140)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(104, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Crear"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Paciente:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(73, 20)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(0, 13)
        Me.lblNombre.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Doctor:"
        '
        'cmbDoctor
        '
        Me.cmbDoctor.FormattingEnabled = True
        Me.cmbDoctor.Location = New System.Drawing.Point(61, 63)
        Me.cmbDoctor.Name = "cmbDoctor"
        Me.cmbDoctor.Size = New System.Drawing.Size(185, 21)
        Me.cmbDoctor.TabIndex = 12
        '
        'gbxCrearCita
        '
        Me.gbxCrearCita.Controls.Add(Me.Label5)
        Me.gbxCrearCita.Controls.Add(Me.cmbDoctor)
        Me.gbxCrearCita.Controls.Add(Me.Label2)
        Me.gbxCrearCita.Controls.Add(Me.Label7)
        Me.gbxCrearCita.Controls.Add(Me.Label3)
        Me.gbxCrearCita.Controls.Add(Me.lblNombre)
        Me.gbxCrearCita.Controls.Add(Me.dtpCita)
        Me.gbxCrearCita.Controls.Add(Me.cmbTipo)
        Me.gbxCrearCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCrearCita.Location = New System.Drawing.Point(12, 12)
        Me.gbxCrearCita.Name = "gbxCrearCita"
        Me.gbxCrearCita.Size = New System.Drawing.Size(259, 122)
        Me.gbxCrearCita.TabIndex = 13
        Me.gbxCrearCita.TabStop = False
        Me.gbxCrearCita.Text = "Crear cita"
        '
        'CrearCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(283, 173)
        Me.Controls.Add(Me.gbxCrearCita)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "CrearCita"
        Me.ShowIcon = False
        Me.Text = "Cita"
        Me.gbxCrearCita.ResumeLayout(False)
        Me.gbxCrearCita.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpCita As DateTimePicker
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbDoctor As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents gbxCrearCita As GroupBox
End Class
