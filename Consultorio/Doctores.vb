Imports System.Data.SqlClient
Public Class Doctores

    Private connectionString As String = "Data Source=JOEL\JLEON;Initial Catalog=Consultorio;Integrated Security=True;TrustServerCertificate=True"

    Private Sub Doctores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
        LlenarCmbEspecialidades()
    End Sub
    Private Sub btnGuardarDoctor_Click(sender As Object, e As EventArgs) Handles btnGuardarDoctor.Click
        InsertarDB()
        CargarDatos()
    End Sub
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        LimpiarCampos()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Actualizar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click  'esta bien'
        Buscar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarDoctor()
    End Sub
    Private Sub dgvDoctores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDoctores.CellClick
        If e.RowIndex >= 0 AndAlso dgvDoctores.Columns(e.ColumnIndex).Name = "Nombre" Then
            Try

                Dim selectedId As Object = dgvDoctores.Rows(e.RowIndex).Cells("id_doctor").Value


                If selectedId IsNot Nothing AndAlso Not IsDBNull(selectedId) Then
                    Dim idDoctor As Integer = Convert.ToInt32(selectedId)


                    CargarDetallesDesdeBD(idDoctor)
                Else
                    MessageBox.Show("No se pudo obtener un ID válido del Doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al seleccionar el Doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    'metodos'

    Private Sub Actualizar()
        If Not Validar() Then Exit Sub

        Try
            If String.IsNullOrWhiteSpace(lblID.Text) Then
                MessageBox.Show("Seleccione un doctor antes de actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim idDoctor As Integer = Convert.ToInt32(lblID.Text)
            Dim idEspecialidad As Integer = Convert.ToInt32(cmbEspecialidades.SelectedValue)

            Dim query As String = "UPDATE Doctor SET Nombre = @Nombre, Apellido = @Apellido, id_especialidad = @Especialidad
                          WHERE id_doctor = @ID"

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = idDoctor
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = txtNombre.Text
                    command.Parameters.Add("@Apellido", SqlDbType.VarChar, 100).Value = txtApellido.Text
                    command.Parameters.Add("@Especialidad", SqlDbType.Int).Value = idEspecialidad

                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Información actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarDatos()
                    Else
                        MessageBox.Show("No se pudo actualizar el doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Buscar()
        Try
            Dim nombreBusqueda As String = txtNombre.Text.Trim()
            Dim apellidoBusqueda As String = txtApellido.Text.Trim()
            Dim especialidadBusqueda As String = cmbEspecialidades.Text.Trim()

            Dim query As String = "SELECT d.id_doctor, d.Nombre, d.Apellido, e.nombre_especialidad AS Especialidad 
                               FROM Doctor d
                               INNER JOIN Especialidades e ON d.id_especialidad = e.id_especialidad
                               WHERE 1=1"

            If nombreBusqueda <> "" Then
                query &= " AND d.Nombre LIKE @Nombre"
            End If
            If apellidoBusqueda <> "" Then
                query &= " AND d.Apellido LIKE @Apellido"
            End If
            If especialidadBusqueda <> "" Then
                query &= " AND e.nombre_especialidad LIKE @Especialidad"
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)

                    If nombreBusqueda <> "" Then
                        command.Parameters.AddWithValue("@Nombre", "%" & nombreBusqueda & "%")
                    End If
                    If apellidoBusqueda <> "" Then
                        command.Parameters.AddWithValue("@Apellido", "%" & apellidoBusqueda & "%")
                    End If
                    If especialidadBusqueda <> "" Then
                        command.Parameters.AddWithValue("@Especialidad", "%" & especialidadBusqueda & "%")
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvDoctores.DataSource = table
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al buscar doctores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertarDB()
        If Not Validar() Then Exit Sub

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using transaction As SqlTransaction = connection.BeginTransaction()
                    Try
                        Dim queryEspecialidad As String = "SELECT id_especialidad FROM Especialidades WHERE nombre_especialidad = @NombreEspecialidad"
                        Dim idEspecialidad As Integer

                        Using commandEspecialidad As New SqlCommand(queryEspecialidad, connection, transaction)
                            commandEspecialidad.Parameters.Add("@NombreEspecialidad", SqlDbType.VarChar).Value = cmbEspecialidades.Text
                            Dim result = commandEspecialidad.ExecuteScalar()

                            If result IsNot Nothing Then
                                idEspecialidad = Convert.ToInt32(result)
                            Else
                                MessageBox.Show("No se encontró la especialidad seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        End Using

                        Dim queryDoctor As String = "INSERT INTO Doctor (Nombre, Apellido, id_especialidad) 
                                                 VALUES (@Nombre, @Apellido, @Especialidad)"

                        Using commandDoctor As New SqlCommand(queryDoctor, connection, transaction)
                            commandDoctor.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = txtNombre.Text
                            commandDoctor.Parameters.Add("@Apellido", SqlDbType.VarChar, 100).Value = txtApellido.Text
                            commandDoctor.Parameters.Add("@Especialidad", SqlDbType.Int).Value = idEspecialidad

                            commandDoctor.ExecuteNonQuery()
                        End Using

                        transaction.Commit()

                        MessageBox.Show("Doctor guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error general: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDetalles(id_doctor As Integer) 'Esta bien'
        Dim query As String = "SELECT * FROM Doctor WHERE id_doctor = @Id"

        Using connection As New SqlConnection(connectionString)
            Try
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", id_doctor)

                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    txtNombre.Text = reader("nombre").ToString()
                    txtApellido.Text = reader("apellido").ToString()
                    cmbEspecialidades.Text = reader("id_especialidad").ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar los detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function Validar() As Boolean 'esta bien"
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

        If cmbEspecialidades.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbEspecialidades.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub LlenarCmbEspecialidades()   'esta bien'
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()


                Dim query As String = "SELECT * FROM Especialidades"

                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        cmbEspecialidades.DataSource = dt
                        cmbEspecialidades.DisplayMember = "nombre_especialidad"
                        cmbEspecialidades.ValueMember = "id_especialidad"
                        cmbEspecialidades.SelectedIndex = -1

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al llenar el ComboBox: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarDatos()  'esta bien'

        Dim query As String = "SELECT d.id_doctor, d.Nombre, d.Apellido, e.nombre_especialidad AS Especialidad
                           FROM Doctor d
                           INNER JOIN Especialidades e ON d.id_especialidad = e.id_especialidad"

        Using connection As New SqlConnection(connectionString)
            Try
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable)

                dgvDoctores.DataSource = dataTable
                dgvDoctores.Columns("id_doctor").Visible = False

            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        dgvDoctores.Columns("Especialidad").HeaderText = "Especialidad"
    End Sub



    Private Sub EliminarDoctor()
        If String.IsNullOrWhiteSpace(lblID.Text) Then
            MessageBox.Show("Seleccione un doctor antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idDoctor As Integer = Convert.ToInt32(lblID.Text)

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using transaction As SqlTransaction = connection.BeginTransaction()
                    Try
                        Dim queryDeleteCitas As String = "DELETE FROM Citas WHERE id_doctor = @IdDoctor"
                        Using cmdCitas As New SqlCommand(queryDeleteCitas, connection, transaction)
                            cmdCitas.Parameters.AddWithValue("@IdDoctor", idDoctor)
                            cmdCitas.ExecuteNonQuery()
                        End Using

                        Dim queryDeleteDoctor As String = "DELETE FROM Doctor WHERE id_doctor = @IdDoctor"
                        Using cmdDoctor As New SqlCommand(queryDeleteDoctor, connection, transaction)
                            cmdDoctor.Parameters.AddWithValue("@IdDoctor", idDoctor)
                            Dim filasAfectadas As Integer = cmdDoctor.ExecuteNonQuery()

                            If filasAfectadas > 0 Then
                                transaction.Commit()
                                MessageBox.Show("Doctor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                CargarDatos()
                            Else
                                transaction.Rollback()
                                MessageBox.Show("No se pudo eliminar el doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("Error al eliminar el doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDetallesDesdeBD(idDoctor As Integer)
        Try
            Dim query As String = "SELECT d.id_doctor, d.Nombre, d.Apellido, e.nombre_especialidad 
                               FROM Doctor d
                               INNER JOIN Especialidades e ON d.id_especialidad = e.id_especialidad
                               WHERE d.id_doctor = @ID"

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = idDoctor

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            lblID.Text = If(IsDBNull(reader("id_doctor")), "", reader("id_doctor").ToString())
                            txtNombre.Text = If(IsDBNull(reader("Nombre")), "", reader("Nombre").ToString())
                            txtApellido.Text = If(IsDBNull(reader("Apellido")), "", reader("Apellido").ToString())

                            cmbEspecialidades.SelectedIndex = cmbEspecialidades.FindStringExact(reader("nombre_especialidad").ToString())

                            MessageBox.Show("Datos cargados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No se encontró información del doctor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los detalles del doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarCampos() 'esta bien'
        lblID.Text = ""
        txtNombre.Clear()
        txtApellido.Clear()
        cmbEspecialidades.SelectedIndex = -1
    End Sub


End Class