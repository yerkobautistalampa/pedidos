Public Class FormMenu
    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        FormCliente.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        FormProducto.Show()
    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        FormPedido.Show()
    End Sub
End Class