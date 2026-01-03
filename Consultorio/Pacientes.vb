Imports System.Data.SqlClient
Imports Microsoft.SqlServer

Public Class Pacientes

    Private connectionString As String = "Data Source=JOEL\JLEON;Initial Catalog=Consultorio;Integrated Security=True;TrustServerCertificate=True"
    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
        LlenarCmbPueblos()
        LlenarCmbPlanesMedicos()
    End Sub

    'Botones'
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
        CargarDatos()
    End Sub
    Private Sub btnGuardarPaciente_Click(sender As Object, e As EventArgs) Handles btnGuardarPaciente.Click
        InsertarDB()
        CargarDatos()
    End Sub

    Private Sub btnCrearCita_Click(sender As Object, e As EventArgs) Handles btnCrearCita.Click
        CrearCita()
    End Sub


    Private Sub btnSignosVitales_Click(sender As Object, e As EventArgs) Handles btnSignosVitales.Click
        SignosVitales()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click  'esta bien'
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click  'esta bien'
        Buscar()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click 'esta bien'
        Actualizar()
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click  'esta bien'
        EliminarPaciente()
    End Sub

    Private Sub DGVPaciente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellContentClick  'Esta bien'


        If e.RowIndex >= 0 AndAlso dgvPacientes.Columns(e.ColumnIndex).Name = "Nombre" Then
            Try

                Dim selectedId As Object = dgvPacientes.Rows(e.RowIndex).Cells("id_paciente").Value


                If selectedId IsNot Nothing AndAlso Not IsDBNull(selectedId) Then
                    Dim idPaciente As Integer = Convert.ToInt32(selectedId)


                    CargarDetallesDesdeBD(idPaciente)
                Else
                    MessageBox.Show("No se pudo obtener un ID válido del paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al seleccionar el paciente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Metodos'


    Private Sub CrearCita()
        If String.IsNullOrWhiteSpace(lblID.Text) Then
            MessageBox.Show("Seleccione un paciente antes de crear una cita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idPaciente As Integer = Convert.ToInt32(lblID.Text)
        Dim nombrePaciente As String = txtNombre.Text
        Dim apellidoPaciente As String = txtApellido.Text
        Dim nombreCompleto As String = nombrePaciente & " " & apellidoPaciente

        Dim frmCita As New CrearCita(idPaciente, nombreCompleto)
        frmCita.Show()
    End Sub
    Private Sub SignosVitales()
        If String.IsNullOrWhiteSpace(lblID.Text) Then
            MessageBox.Show("Seleccione un paciente antes de registrar signos vitales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idPaciente As Integer = Convert.ToInt32(lblID.Text)

        Dim frmSignos As New SignosVitales(idPaciente)
        frmSignos.Show()
    End Sub
    Private Sub EliminarPaciente()
        If String.IsNullOrWhiteSpace(lblID.Text) Then
            MessageBox.Show("Seleccione un paciente antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idPaciente As Integer = Convert.ToInt32(lblID.Text)


        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de eliminar este paciente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmacion = DialogResult.No Then Exit Sub

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()


                Using transaction As SqlTransaction = connection.BeginTransaction()
                    Try

                        Dim queryEliminarSignos As String = "DELETE FROM SignosVitales WHERE id_cita IN (SELECT id_cita FROM Citas WHERE id_paciente = @IdPaciente)"
                        Using cmdSignos As New SqlCommand(queryEliminarSignos, connection, transaction)
                            cmdSignos.Parameters.AddWithValue("@IdPaciente", idPaciente)
                            cmdSignos.ExecuteNonQuery()
                        End Using


                        Dim queryEliminarCitas As String = "DELETE FROM Citas WHERE id_paciente = @IdPaciente"
                        Using cmdCitas As New SqlCommand(queryEliminarCitas, connection, transaction)
                            cmdCitas.Parameters.AddWithValue("@IdPaciente", idPaciente)
                            cmdCitas.ExecuteNonQuery()
                        End Using


                        Dim queryEliminarPaciente As String = "DELETE FROM Pacientes WHERE id_paciente = @IdPaciente"
                        Using cmdPaciente As New SqlCommand(queryEliminarPaciente, connection, transaction)
                            cmdPaciente.Parameters.AddWithValue("@IdPaciente", idPaciente)
                            Dim filasAfectadas As Integer = cmdPaciente.ExecuteNonQuery()

                            If filasAfectadas > 0 Then
                                transaction.Commit()
                                MessageBox.Show("Paciente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                CargarDatos()
                                LimpiarCampos()
                            Else
                                transaction.Rollback()
                                MessageBox.Show("No se pudo eliminar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show("Error al eliminar el paciente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Actualizar()
        If Not Validar() Then Exit Sub

        Try
            If String.IsNullOrWhiteSpace(lblID.Text) Then
                MessageBox.Show("Seleccione un paciente antes de actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim idPaciente As Integer = Convert.ToInt32(lblID.Text)
            Dim idPueblo As Integer


            Dim queryObtenerIdPueblo As String = "SELECT id_pueblo FROM Pueblos WHERE nombre_pueblo = @NombrePueblo"

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using cmdPueblo As New SqlCommand(queryObtenerIdPueblo, connection)
                    cmdPueblo.Parameters.Add("@NombrePueblo", SqlDbType.VarChar).Value = cmbPueblos.Text
                    Dim result = cmdPueblo.ExecuteScalar()

                    If result IsNot Nothing Then
                        idPueblo = Convert.ToInt32(result)
                    Else
                        MessageBox.Show("No se encontró el ID del pueblo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using


                Dim query As String = "UPDATE Pacientes 
                                   SET Nombre = @Nombre, Apellido = @Apellido, Genero = @Genero, 
                                       FechaNacimiento = @FechaNacimiento, Telefono = @Telefono, SeguroMedico = @SeguroMedico
                                   WHERE id_paciente = @ID;

                                   UPDATE Direccion 
                                   SET calle = @Calle, id_pueblo = @Pueblo, zip_code = @ZipCode
                                   WHERE id_direccion = (SELECT id_direccion FROM Pacientes WHERE id_paciente = @ID)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = idPaciente
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = txtNombre.Text
                    command.Parameters.Add("@Apellido", SqlDbType.VarChar, 100).Value = txtApellido.Text
                    command.Parameters.Add("@Genero", SqlDbType.VarChar, 10).Value = If(rdbHombre.Checked, "Hombre", "Mujer")
                    command.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = dtpFechaNacimiento.Value
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 15).Value = txtTelefono.Text
                    command.Parameters.Add("@SeguroMedico", SqlDbType.VarChar, 50).Value = cmbPlanesMedicos.Text
                    command.Parameters.Add("@Calle", SqlDbType.VarChar, 255).Value = txtCalle.Text
                    command.Parameters.Add("@Pueblo", SqlDbType.Int).Value = idPueblo ' 🔹 Aquí pasamos el ID real del pueblo
                    command.Parameters.Add("@ZipCode", SqlDbType.VarChar, 10).Value = txtZipCode.Text

                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()

                    LimpiarCampos()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Información actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarDatos()
                    Else
                        MessageBox.Show("No se pudo actualizar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el paciente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buscar()
        Try

            Dim nombreBusqueda As String = txtBuscarNombre.Text.Trim()
            Dim apellidoBusqueda As String = txtBuscarApellido.Text.Trim()


            Dim query As String = "SELECT id_paciente, Nombre, Apellido, FechaNacimiento FROM Pacientes WHERE 1=1"


            If nombreBusqueda <> "" Then
                query &= " AND Nombre LIKE @Nombre"
            End If
            If apellidoBusqueda <> "" Then
                query &= " AND Apellido LIKE @Apellido"
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


                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)


                    dgvPacientes.DataSource = table

                    LimpiarCampos()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al buscar pacientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarDetallesDesdeBD(idPaciente As Integer)    'Esta bien'
        Try

            Dim query As String = "SELECT p.id_paciente, p.Nombre, p.Apellido, p.Genero, p.FechaNacimiento, p.Telefono, p.SeguroMedico, 
                              d.calle, pu.nombre_pueblo, d.zip_code
                       FROM Pacientes p
                       INNER JOIN Direccion d ON p.id_direccion = d.id_direccion
                       INNER JOIN Pueblos pu ON d.id_pueblo = pu.id_pueblo
                       WHERE p.id_paciente = @ID"


            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = idPaciente

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then

                            lblID.Text = If(IsDBNull(reader("id_paciente")), "", reader("id_paciente").ToString())
                            txtNombre.Text = If(IsDBNull(reader("Nombre")), "", reader("Nombre").ToString())
                            txtApellido.Text = If(IsDBNull(reader("Apellido")), "", reader("Apellido").ToString())
                            txtTelefono.Text = If(IsDBNull(reader("Telefono")), "", reader("Telefono").ToString())
                            cmbPlanesMedicos.Text = If(IsDBNull(reader("SeguroMedico")), "", reader("SeguroMedico").ToString())
                            txtCalle.Text = If(IsDBNull(reader("calle")), "", reader("calle").ToString())
                            cmbPueblos.Text = If(IsDBNull(reader("nombre_pueblo")), "", reader("nombre_pueblo").ToString())
                            txtZipCode.Text = If(IsDBNull(reader("zip_code")), "", reader("zip_code").ToString())


                            Dim genero As String = If(IsDBNull(reader("Genero")), "", reader("Genero").ToString())
                            rdbHombre.Checked = (genero = "Hombre")
                            rdbMujer.Checked = (genero = "Mujer")


                            If Not IsDBNull(reader("FechaNacimiento")) Then
                                dtpFechaNacimiento.Value = Convert.ToDateTime(reader("FechaNacimiento"))
                            End If

                            MessageBox.Show("Datos cargados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No se encontró información del paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los detalles del paciente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LlenarCmbPlanesMedicos()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()


                Dim query As String = "SELECT id_plan, nombre_plan FROM PlanesMedicos"

                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)


                        cmbPlanesMedicos.DataSource = dt
                        cmbPlanesMedicos.DisplayMember = "nombre_plan"
                        cmbPlanesMedicos.ValueMember = "id_plan"
                        cmbPlanesMedicos.SelectedIndex = -1
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al llenar el ComboBox de planes médicos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarCmbPueblos()   'esta bien'
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()


                Dim query As String = "SELECT id_pueblo, nombre_pueblo FROM Pueblos"

                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        cmbPueblos.DataSource = dt
                        cmbPueblos.DisplayMember = "nombre_pueblo"
                        cmbPueblos.ValueMember = "id_pueblo"
                        cmbPueblos.SelectedIndex = -1

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al llenar el ComboBox: " & ex.Message)
        End Try
    End Sub


    Private Sub CargarDatos()
        Dim query As String = "SELECT id_paciente, Nombre, Apellido, FechaNacimiento FROM Pacientes"

        Using connection As New SqlConnection(connectionString)
            Try
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable)

                dgvPacientes.DataSource = dataTable
                dgvPacientes.Columns("id_paciente").Visible = False

                dgvPacientes.Columns("Nombre").HeaderText = "Nombre del Paciente"
                dgvPacientes.Columns("Apellido").HeaderText = "Apellido del Paciente"
                dgvPacientes.Columns("FechaNacimiento").HeaderText = "Fecha de Nacimiento"

            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    Private Sub InsertarDB()       'Esta bien'
        If Not Validar() Then Exit Sub

        Try

            Using connection As New SqlConnection(connectionString)
                connection.Open()


                Using transaction As SqlTransaction = connection.BeginTransaction()
                    Try
                        Dim queryPueblo As String = "SELECT id_pueblo FROM Pueblos WHERE nombre_pueblo = @NombrePueblo"
                        Dim idPueblo As Integer

                        Using commandPueblo As New SqlCommand(queryPueblo, connection, transaction)
                            commandPueblo.Parameters.Add("@NombrePueblo", SqlDbType.VarChar).Value = cmbPueblos.Text
                            Dim result = commandPueblo.ExecuteScalar()

                            If result IsNot Nothing Then
                                idPueblo = Convert.ToInt32(result)
                            Else
                                Throw New Exception("El pueblo seleccionado no existe en la base de datos.")
                            End If
                        End Using

                        Dim queryDireccion As String = "INSERT INTO Direccion (calle, id_pueblo, zip_code) 
                                VALUES (@Calle, @Pueblo, @ZipCode);
                                SELECT SCOPE_IDENTITY();"

                        Dim idDireccion As Integer
                        Using commandDireccion As New SqlCommand(queryDireccion, connection, transaction)
                            commandDireccion.Parameters.Add("@Calle", SqlDbType.VarChar, 255).Value = txtCalle.Text
                            commandDireccion.Parameters.Add("@Pueblo", SqlDbType.Int).Value = idPueblo
                            commandDireccion.Parameters.Add("@ZipCode", SqlDbType.VarChar, 10).Value = txtZipCode.Text

                            idDireccion = Convert.ToInt32(commandDireccion.ExecuteScalar())
                        End Using



                        Dim queryPaciente As String = "INSERT INTO Pacientes (Nombre, Apellido, Genero, FechaNacimiento, Telefono, SeguroMedico, id_direccion) 
                                                   VALUES (@Nombre, @Apellido, @Genero, @FechaNacimiento, @Telefono, @SeguroMedico, @IdDireccion)"

                        Using commandPaciente As New SqlCommand(queryPaciente, connection, transaction)
                            commandPaciente.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                            commandPaciente.Parameters.AddWithValue("@Apellido", txtApellido.Text)


                            Dim genero As String = If(rdbHombre.Checked, "Hombre", "Mujer")
                            commandPaciente.Parameters.AddWithValue("@Genero", genero)


                            commandPaciente.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value.Date)
                            commandPaciente.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                            commandPaciente.Parameters.AddWithValue("@SeguroMedico", cmbPlanesMedicos.Text)
                            commandPaciente.Parameters.AddWithValue("@IdDireccion", idDireccion)


                            commandPaciente.ExecuteNonQuery()
                        End Using



                        transaction.Commit()

                        LimpiarCampos()

                        MessageBox.Show("Paciente guardados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

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


    Private Function Validar() As Boolean   'Esto esta bien'

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

        If cmbPlanesMedicos.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un Plan Medico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPlanesMedicos.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCalle.Text) Then
            MessageBox.Show("El campo Calle no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCalle.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtZipCode.Text) OrElse Not IsNumeric(txtZipCode.Text) Then
            MessageBox.Show("El campo Zip Code no puede estar vacío y debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtZipCode.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtTelefono.Text) OrElse Not IsNumeric(txtTelefono.Text) Then
            MessageBox.Show("El campo Teléfono no puede estar vacío y debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelefono.Focus()
            Return False
        End If

        If cmbPueblos.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un pueblo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPueblos.Focus()
            Return False
        End If

        If Not rdbHombre.Checked And Not rdbMujer.Checked Then
            MessageBox.Show("Debe seleccionar un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rdbHombre.Focus()
            Return False
        End If

        If dtpFechaNacimiento.Value > DateTime.Today Then
            MessageBox.Show("Debe seleccionar una fecha del pasado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpFechaNacimiento.Focus()
            Return False
        End If


        Return True
    End Function

    Private Sub LimpiarCampos() 'esta bien'
        txtBuscarNombre.Clear()
        txtBuscarApellido.Clear()
        lblID.Text = ""
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefono.Clear()
        cmbPlanesMedicos.SelectedIndex = -1
        txtCalle.Clear()
        cmbPueblos.SelectedIndex = -1
        txtZipCode.Clear()
        rdbHombre.Checked = False
        rdbMujer.Checked = False
        dtpFechaNacimiento.Value = DateTime.Today
    End Sub


End Class







