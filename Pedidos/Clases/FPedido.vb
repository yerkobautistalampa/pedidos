Imports System.Data.SqlClient
Public Class FPedido
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarPedido")
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
    Public Function Insertar(ByVal Nro_pedido As Integer, ByVal Nro_cliente As Integer, ByVal Cod_producto As String, ByVal Cantidad As Integer, ByVal Fecha_pedido As Date) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("InsertarPedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nro_pedido", Nro_pedido)
            cmd.Parameters.AddWithValue("@Nro_cliente", Nro_cliente)
            cmd.Parameters.AddWithValue("@Cod_producto", Cod_producto)
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad)
            cmd.Parameters.AddWithValue("@Fecha_pedido", Fecha_pedido)
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
    Public Function Buscar(ByVal Nro_pedido As Integer) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("BuscarPedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nro_pedido", Nro_pedido)
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
    Public Function Eliminar(ByVal Nro_pedido As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("BorrarPedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nro_pedido", Nro_pedido)
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
    Public Function actualizar(ByVal Nro_pedido As Integer, ByVal Nro_cliente As Integer, ByVal Cod_producto As String, ByVal Cantidad As Integer, ByVal Fecha_pedido As Date) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ActualizarPedido")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nro_pedido", Nro_pedido)
            cmd.Parameters.AddWithValue("@Nro_cliente", Nro_cliente)
            cmd.Parameters.AddWithValue("@Cod_producto", Cod_producto)
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad)
            cmd.Parameters.AddWithValue("@Fecha_pedido", Fecha_pedido)
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
