Imports System.Data.SqlClient
Public Class Conexion
    Protected cnn As New SqlConnection
    Protected Function conectado() As Boolean
        Try
            'cnn = New SqlConnection("Data Source=192.168.1.1;Initial Catalog=PEDIDOS;User Id=sa;Password=12345")
            cnn = New SqlConnection("Data Source=(local);Initial Catalog=PEDIDOS;Integrated Security=True")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Protected Function desconectado() As Boolean
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
