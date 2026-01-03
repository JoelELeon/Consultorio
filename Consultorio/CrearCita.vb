Imports System.Data.SqlClient

Public Class CrearCita

    Private connectionString As String = "Data Source=JOEL\JLEON;Initial Catalog=Consultorio;Integrated Security=True;TrustServerCertificate=True"

    Private Sub dtpCita_ValueChanged(sender As Object, e As EventArgs) Handles dtpCita.ValueChanged
        If dtpCita.Value < DateTime.Today Then
            MessageBox.Show("La cita debe ser programda con una fecha posterior al momento de crearla.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpCita.Value = DateTime.Today
        End If
    End Sub

    Private Sub CrearCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCmbDoctores()
        LlenarCmbTipoCita()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Guardar()
    End Sub

    Private Sub Guardar()
        If String.IsNullOrWhiteSpace(lblNombre.Text) OrElse cmbDoctor.SelectedIndex = -1 OrElse cmbTipo.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, complete todos los campos antes de crear la cita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim idDoctor As Integer = Convert.ToInt32(cmbDoctor.SelectedValue)
                Dim tipoCita As String = cmbTipo.Text
                Dim fechaCita As DateTime = dtpCita.Value

                Dim query As String = "INSERT INTO Citas (id_paciente, id_doctor, tipo, fecha) 
                                   VALUES (@IdPaciente, @IdDoctor, @TipoCita, @Fecha)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@IdPaciente", SqlDbType.Int).Value = idPaciente
                    command.Parameters.Add("@IdDoctor", SqlDbType.Int).Value = idDoctor
                    command.Parameters.Add("@TipoCita", SqlDbType.VarChar, 50).Value = tipoCita
                    command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fechaCita

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Cita creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al crear la cita: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LlenarCmbDoctores()   'esta bien'
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()


                Dim query As String = "SELECT id_doctor, (Nombre + ' ' + Apellido) AS NombreCompleto FROM Doctor"

                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        cmbDoctor.DataSource = dt
                        cmbDoctor.DisplayMember = "NombreCompleto"
                        cmbDoctor.ValueMember = "id_doctor"
                        cmbDoctor.SelectedIndex = -1

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al llenar el ComboBox: " & ex.Message)
        End Try
    End Sub

    Private Sub LlenarCmbTipoCita()
        cmbTipo.Items.Clear()
        cmbTipo.Items.Add("Primera cita")
        cmbTipo.Items.Add("Seguimiento")

        cmbTipo.SelectedIndex = -1
    End Sub


    Private idPaciente As Integer

    Public Sub New(pacienteId As Integer, nombreCompleto As String)
        InitializeComponent()
        idPaciente = pacienteId
        lblNombre.Text = nombreCompleto
    End Sub
End Class