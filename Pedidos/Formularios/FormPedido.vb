Public Class FormPedido
    Private dt As New DataTable
    Private Sub btnMostar_Click(sender As Object, e As EventArgs) Handles btnMostar.Click
        Listado()
    End Sub
    Private Sub Listado()
        Try
            Dim fc As New FPedido
            dt = fc.mostrar
            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
            Else
                dgvListado.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentClick
        txtNroPedido.Text = dgvListado.SelectedCells.Item(0).Value
        txtNroCliente.Text = dgvListado.SelectedCells.Item(1).Value
        txtCodProducto.Text = dgvListado.SelectedCells.Item(2).Value
        txtCantidad.Text = dgvListado.SelectedCells.Item(3).Value
        txtFecha.Text = dgvListado.SelectedCells.Item(4).Value
    End Sub
End Class