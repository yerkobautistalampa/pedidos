Imports System.Data.SqlClient
Public Class FProducto
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MostrarProducto")
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

    Public Function Buscar(ByVal Cod_producto As String) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("BuscarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Cod_producto", Cod_producto)
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

    Public Function Eliminar(ByVal Cod_producto As String) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("BorrarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Cod_producto", Cod_producto)
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
    Public Function Insertar(ByVal Cod_producto As String, ByVal Nonmbre_producto As String, ByVal Precio As Double, ByVal Stok As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("InsertarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Cod_producto", Cod_producto)
            cmd.Parameters.AddWithValue("@Nonmbre_producto", Nonmbre_producto)
            cmd.Parameters.AddWithValue("@Precio", Precio)
            cmd.Parameters.AddWithValue("@Stok", Stok)

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

    Public Function actualizar(ByVal Cod_producto As String, ByVal Nonmbre_producto As String, ByVal Precio As Double, ByVal Stok As Integer) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ActualizarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Cod_producto", Cod_producto)
            cmd.Parameters.AddWithValue("@Nonmbre_producto", Nonmbre_producto)
            cmd.Parameters.AddWithValue("@Precio", Precio)
            cmd.Parameters.AddWithValue("@Stok", Stok)
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
