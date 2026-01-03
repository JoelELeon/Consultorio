<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnCitas = New System.Windows.Forms.Button()
        Me.btnDoctor = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPaciente
        '
        Me.btnPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaciente.Location = New System.Drawing.Point(118, 12)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(94, 45)
        Me.btnPaciente.TabIndex = 12
        Me.btnPaciente.Text = "Paciente"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'btnCitas
        '
        Me.btnCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitas.Location = New System.Drawing.Point(218, 12)
        Me.btnCitas.Name = "btnCitas"
        Me.btnCitas.Size = New System.Drawing.Size(83, 45)
        Me.btnCitas.TabIndex = 11
        Me.btnCitas.Text = "Citas"
        Me.btnCitas.UseVisualStyleBackColor = True
        '
        'btnDoctor
        '
        Me.btnDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctor.Location = New System.Drawing.Point(12, 12)
        Me.btnDoctor.Name = "btnDoctor"
        Me.btnDoctor.Size = New System.Drawing.Size(100, 45)
        Me.btnDoctor.TabIndex = 10
        Me.btnDoctor.Text = "Doctor"
        Me.btnDoctor.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(118, 69)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(94, 35)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(316, 116)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnPaciente)
        Me.Controls.Add(Me.btnCitas)
        Me.Controls.Add(Me.btnDoctor)
        Me.Name = "Inicio"
        Me.ShowIcon = False
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnCitas As Button
    Friend WithEvents btnDoctor As Button
    Friend WithEvents btnCerrar As Button
End Class
