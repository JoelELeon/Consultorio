Imports System.Data.SqlClient

Public Class SignosVitales

    Private connectionString As String = "Data Source=JOEL\JLEON;Initial Catalog=Consultorio;Integrated Security=True;TrustServerCertificate=True"

    Private Sub SignosVitales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos(idPaciente)
        CargarDatosPaciente()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Guardar()
    End Sub
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        LimpiarCampos()
    End Sub
    Private Sub LimpiarCampos() 'esta bien'
        txtAltura.Clear()
        txtFrecuencia.Clear()
        txtPeso.Clear()
        txtTemperatura.Clear()
        txtPresion.Clear()
    End Sub

    Private Sub Guardar() 'esta bien'
        If String.IsNullOrWhiteSpace(lblIDCita.Text) OrElse lblIDCita.Text = "-1" Then
            MessageBox.Show("Seleccione una fecha de cita antes de guardar los signos vitales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idCitaSeleccionada As Integer = Convert.ToInt32(lblIDCita.Text)

        GuardarSignosVitales(idCitaSeleccionada)
    End Sub
    Private Function Validar() As Boolean

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtApellido.Text) Then
            MessageBox.Show("El campo Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtApellido.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAltura.Text) Then
            MessageBox.Show("El campo Seguro no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAltura.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtFrecuencia.Text) Then
            MessageBox.Show("El campo Calle no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFrecuencia.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPeso.Text) Then
            MessageBox.Show("El campo Seguro no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPeso.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPresion.Text) Then
            MessageBox.Show("El campo Seguro no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPresion.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtTemperatura.Text) Then
            MessageBox.Show("El campo Seguro no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTemperatura.Focus()
            Return False
        End If
        Return True
    End Function


    Private idPaciente As Integer

    Public Sub New(pacienteId As Integer)
            InitializeComponent()
            idPaciente = pacienteId
        End Sub


    Private Sub CargarDatos(idPaciente As Integer)
        Dim query As String = "SELECT id_cita, fecha FROM Citas WHERE id_paciente = @IdPaciente"

        Using connection As New SqlConnection(connectionString)
            Try
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@IdPaciente", SqlDbType.Int).Value = idPaciente
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    dgvCitas.DataSource = dataTable
                    dgvCitas.Columns("id_cita").Visible = False

                    dgvCitas.Columns("fecha").HeaderText = "Fechas de las Citas"
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub CargarDatosPaciente()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Nombre, Apellido FROM Pacientes WHERE id_paciente = @IdPaciente"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@IdPaciente", SqlDbType.Int).Value = idPaciente

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            txtNombre.Text = reader("Nombre").ToString()
                            txtApellido.Text = reader("Apellido").ToString()
                        Else
                            MessageBox.Show("No se encontró el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del paciente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgvCitas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim fechaSeleccionada As DateTime = Convert.ToDateTime(dgvCitas.Rows(e.RowIndex).Cells("fecha").Value)

        Dim idCitaSeleccionada As Integer = ObtenerIdCitaPorFecha(fechaSeleccionada)
        If idCitaSeleccionada = -1 Then
            MessageBox.Show("No se encontró una cita con la fecha seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        lblIDCita.Text = idCitaSeleccionada.ToString()

        MostrarSignosVitales(idCitaSeleccionada)

    End Sub

    Private Function ObtenerIdCitaPorFecha(fecha As DateTime) As Integer
        Dim idCita As Integer = -1

        Dim query As String = "SELECT id_cita FROM Citas WHERE fecha = @Fecha"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fecha

                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        idCita = Convert.ToInt32(result)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al obtener la cita por fecha: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return idCita
    End Function

    Private Sub GuardarSignosVitales(idCita As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO SignosVitales (peso, altura, presion_arterial, frecuencia_cardiaca, temperatura, id_cita) 
                                   VALUES (@Peso, @Altura, @Presion, @Frecuencia, @Temperatura, @IdCita)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@Peso", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPeso.Text)
                    command.Parameters.Add("@Altura", SqlDbType.Decimal).Value = Convert.ToDecimal(txtAltura.Text)
                    command.Parameters.Add("@Presion", SqlDbType.VarChar, 10).Value = txtPresion.Text
                    command.Parameters.Add("@Frecuencia", SqlDbType.Int).Value = Convert.ToInt32(txtFrecuencia.Text)
                    command.Parameters.Add("@Temperatura", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTemperatura.Text)
                    command.Parameters.Add("@IdCita", SqlDbType.Int).Value = idCita ' 🔹 Ahora la cita está correctamente vinculada

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Signos vitales guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al guardar los signos vitales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarSignosVitales(idCita As Integer)
        Dim query As String = "SELECT peso, altura, presion_arterial, frecuencia_cardiaca, temperatura 
                           FROM SignosVitales WHERE id_cita = @IdCita"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@IdCita", SqlDbType.Int).Value = idCita

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            txtPeso.Text = reader("peso").ToString()
                            txtAltura.Text = reader("altura").ToString()
                            txtPresion.Text = reader("presion_arterial").ToString()
                            txtFrecuencia.Text = reader("frecuencia_cardiaca").ToString()
                            txtTemperatura.Text = reader("temperatura").ToString()
                        Else
                            txtPeso.Clear()
                            txtAltura.Clear()
                            txtPresion.Clear()
                            txtFrecuencia.Clear()
                            txtTemperatura.Clear()
                            MessageBox.Show("No hay signos vitales registrados para esta cita.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar los signos vitales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class