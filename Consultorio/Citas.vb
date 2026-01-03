Imports System.Data.SqlClient

Public Class Citas
    Private connectionString As String = "Data Source=JOEL\JLEON;Initial Catalog=Consultorio;Integrated Security=True;TrustServerCertificate=True"

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Citas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCitas()
    End Sub

    Private Sub btnTraerCitas_Click(sender As Object, e As EventArgs) Handles btnTraerCitas.Click
        BuscarCitas()
    End Sub

    Private Sub btnCambiarCita_Click(sender As Object, e As EventArgs) Handles btnCambiarCita.Click
        CambiarCita()
    End Sub

    Private Sub CambiarCita()
        Try
            If String.IsNullOrWhiteSpace(lblIDCita.Text) Then
                MessageBox.Show("Seleccione una cita antes de cambiar la fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim idCita As Integer = Convert.ToInt32(lblIDCita.Text)

            If dtpCambiarFecha.Value = DateTime.MinValue Then
                MessageBox.Show("Seleccione una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim nuevaFecha As DateTime = dtpCambiarFecha.Value

            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de cambiar la fecha de la cita?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.No Then Exit Sub

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE Citas SET fecha = @NuevaFecha WHERE id_cita = @IdCita"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@NuevaFecha", SqlDbType.DateTime).Value = nuevaFecha
                    command.Parameters.Add("@IdCita", SqlDbType.Int).Value = idCita

                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Fecha de la cita actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        CargarCitas()
                    Else
                        MessageBox.Show("No se pudo actualizar la fecha de la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al actualizar la fecha de la cita: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BuscarCitas()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT c.id_cita, p.Nombre, p.Apellido, c.fecha, c.tipo 
                                   FROM Citas c
                                   INNER JOIN Pacientes p ON c.id_paciente = p.id_paciente
                                   WHERE 1=1"

                Dim parameters As New List(Of SqlParameter)

                If Not String.IsNullOrWhiteSpace(txtBuscarNombre.Text) Then
                    query &= " AND p.Nombre LIKE @Nombre"
                    parameters.Add(New SqlParameter("@Nombre", "%" & txtBuscarNombre.Text & "%"))
                End If

                If Not String.IsNullOrWhiteSpace(txtBuscarApellido.Text) Then
                    query &= " AND p.Apellido LIKE @Apellido"
                    parameters.Add(New SqlParameter("@Apellido", "%" & txtBuscarApellido.Text & "%"))
                End If

                Dim fechaDesde As DateTime = dtpDesde.Value
                Dim fechaHasta As DateTime = dtpHasta.Value

                query &= " AND c.fecha BETWEEN @FechaDesde AND @FechaHasta"
                parameters.Add(New SqlParameter("@FechaDesde", fechaDesde))
                parameters.Add(New SqlParameter("@FechaHasta", fechaHasta))

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvCitas.DataSource = table
                    dgvCitas.Columns("id_cita").Visible = False
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar citas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub dtpDesde_ValueChanged(sender As Object, e As EventArgs) Handles dtpDesde.ValueChanged
        If dtpDesde.Value > dtpHasta.Value Then
            dtpHasta.Value = dtpDesde.Value
        End If
    End Sub

    Private Sub dtpHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtpHasta.ValueChanged
        If dtpHasta.Value < dtpDesde.Value Then
            dtpDesde.Value = dtpHasta.Value
        End If
    End Sub




    Private Sub dgvCitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCitas.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idCitaSeleccionada As Integer = Convert.ToInt32(dgvCitas.Rows(e.RowIndex).Cells("id_cita").Value)

        Dim fechaSeleccionada As DateTime = Convert.ToDateTime(dgvCitas.Rows(e.RowIndex).Cells("fecha").Value)

        Dim nombrePaciente As String = dgvCitas.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
        Dim apellidoPaciente As String = dgvCitas.Rows(e.RowIndex).Cells("Apellido").Value.ToString()

        lblIDCita.Text = idCitaSeleccionada.ToString()
        lblIDCita.Visible = False
        dtpCambiarFecha.Value = fechaSeleccionada
        txtNombrePaciente.Text = nombrePaciente & " " & apellidoPaciente


    End Sub


    Private Sub CargarCitas()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT c.id_cita, p.Nombre, p.Apellido, c.fecha, c.tipo 
                                   FROM Citas c
                                   INNER JOIN Pacientes p ON c.id_paciente = p.id_paciente
                                   WHERE 1=1"
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvCitas.DataSource = table
                dgvCitas.Columns("id_cita").Visible = False

                dgvCitas.Columns("fecha").HeaderText = "Fecha de la Cita"
                dgvCitas.Columns("tipo").HeaderText = "Tipo de Cita"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las citas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class