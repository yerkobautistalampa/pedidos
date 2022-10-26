Imports System.Data.SqlClient
Public Class FCliente
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function Buscar(ByVal ci As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("BuscarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@ci", ci)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function Eliminar(ByVal ci As String) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("BorrarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nro_Ci", ci)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function Insertar(ByVal num As Integer, ByVal nit As String, ByVal nom As String, ByVal apMa As String, ByVal apPa As String, ByVal sex As String, ByVal ema As String, ByVal tel As String) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("InsertarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nro", num)
            cmd.Parameters.AddWithValue("@ci", nit)
            cmd.Parameters.AddWithValue("@nom", nom)
            cmd.Parameters.AddWithValue("@apPa", apPa)
            cmd.Parameters.AddWithValue("@apMa", apMa)
            cmd.Parameters.AddWithValue("@sex", sex)
            cmd.Parameters.AddWithValue("@ema", ema)
            cmd.Parameters.AddWithValue("@tel", tel)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Public Function actualizar(ByVal num As Integer, ByVal nit As String, ByVal nom As String, ByVal apMa As String, ByVal apPa As String, ByVal sex As String, ByVal ema As String, ByVal tel As String) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ActualizarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nro", num)
            cmd.Parameters.AddWithValue("@ci", nit)
            cmd.Parameters.AddWithValue("@nom", nom)
            cmd.Parameters.AddWithValue("@apPa", apPa)
            cmd.Parameters.AddWithValue("@apMa", apMa)
            cmd.Parameters.AddWithValue("@sex", sex)
            cmd.Parameters.AddWithValue("@ema", ema)
            cmd.Parameters.AddWithValue("@tel", tel)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

End Class
