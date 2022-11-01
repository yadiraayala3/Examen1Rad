Imports System.Data.SqlClient

Module Module1

    Public conexion As New SqlConnection
    Public comando As New SqlCommand
    Public estado As String
    Public respuesta As SqlDataReader

    Sub conectar()
        Try
            conexion.ConnectionString = "Data Source=DESKTOP-RDE5K43\INSTANCIA;Initial Catalog=ExamenRAD;Integrated Security=True"
            conexion.Open()
            estado = "conectado"
        Catch ex As Exception
            estado = "desconectado"
        End Try
    End Sub

    Function verificarUsuario(ByVal usuario As String, ByVal pass As String) As Boolean
        Dim resultado As Boolean = False
        Try
            comando = New SqlCommand("SELECT * FROM Usuarios WHERE usuario=@Usuario and pass=@Pass", conexion)
            comando.Parameters.AddWithValue("@Usuario", usuario)
            comando.Parameters.AddWithValue("@Pass", pass)
            respuesta = comando.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

End Module
