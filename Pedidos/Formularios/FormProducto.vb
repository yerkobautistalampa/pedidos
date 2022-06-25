Public Class FormProducto
    Private dt As New DataTable
    Private Sub btnMostar_Click(sender As Object, e As EventArgs) Handles btnMostar.Click
        Listado()
    End Sub
    Private Sub Listado()
        Try
            Dim fc As New FProducto
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
        txtCodProducto.Text = dgvListado.SelectedCells.Item(0).Value
        txtNombreProducto.Text = dgvListado.SelectedCells.Item(1).Value
        txtPrecio.Text = dgvListado.SelectedCells.Item(2).Value
        txtPrecio.Text = dgvListado.SelectedCells.Item(3).Value
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class