Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If verificarUsuario(txtUsuario.Text, txtPass.Text) Then
                MsgBox("Bienvenido")
            Else
                MsgBox("Datos incorrectos")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()

        MsgBox(estado)
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        conexion.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
