Imports System.Data.SqlClient

Public Class Inicio

    Private Sub btnCitas_Click(sender As Object, e As EventArgs) Handles btnCitas.Click
        Dim Citas As New Citas()
        Citas.Show()
    End Sub

    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        Dim Pacientes As New Pacientes()
        Pacientes.Show()
    End Sub

    Private Sub btnDoctor_Click(sender As Object, e As EventArgs) Handles btnDoctor.Click
        Dim Doctores As New Doctores()
        Doctores.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class