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

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim fc As New FProducto
            dt = fc.Buscar(txtCodProducto.Text)
            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
            Else
                dgvListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCodProducto.Text <> "" And txtNombreProducto.Text <> "" And txtPrecio.Text <> "" And txtStok.Text <> "" Then
            Try
                Dim fun As New FProducto
                If fun.Insertar(txtCodProducto.Text, txtNombreProducto.Text, txtPrecio.Text, txtStok.Text) Then
                    MessageBox.Show("se inserto correctamente", "guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Listado()
                Else
                    MessageBox.Show("no fue registrado", "guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("llenar datos porfavor", "guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        btnGuardar.Visible = False
        btnCanselar.Visible = False
        btnBuscar.Enabled = True
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnCanselar_Click(sender As Object, e As EventArgs) Handles btnCanselar.Click
        btnGuardar.Enabled = True
        btnCanselar.Enabled = True
        btnBuscar.Enabled = True
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("esta seguro de eliminar los datos del producto", "eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            If txtCodProducto.Text <> "" Then
                Try
                    Dim fc As New FProducto
                    If fc.Eliminar(txtCodProducto.Text) Then
                        Listado()
                        limpiar()
                        MessageBox.Show("producto eliminado correctamente", "eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("producto no fue eliminado correctamente", "eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("inserte un ci", "eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        btnGuardar.Visible = True
        btnCanselar.Visible = True
        btnBuscar.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Sub limpiar()
        txtCodProducto.Text = ""
        txtNombreProducto.Text = ""
        txtPrecio.Text = ""
        txtStok.Text = ""
    End Sub

    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick
        Try
            txtCodProducto.Text = dgvListado.SelectedCells.Item(0).Value
            txtNombreProducto.Text = dgvListado.SelectedCells.Item(1).Value
            txtPrecio.Text = dgvListado.SelectedCells.Item(2).Value
            txtStok.Text = dgvListado.SelectedCells.Item(3).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtCodProducto.Text <> "" And txtNombreProducto.Text <> "" And txtPrecio.Text <> "" And txtStok.Text <> "" Then
            Try
                Dim fun As New FProducto
                If fun.actualizar(txtCodProducto.Text, txtNombreProducto.Text, txtPrecio.Text, txtStok.Text) Then
                    MessageBox.Show("se actualizo correctamente", "actualizando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Listado()
                Else
                    MessageBox.Show("los datos no fueron actualizados", "actualizando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("falta llenar datos", "actualizando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
        FormMenu.Show()
    End Sub

    Private Sub btnAgrgarPedido_Click(sender As Object, e As EventArgs) Handles btnAgrgarPedido.Click
        FormPedido.txtCodProducto.Text = txtCodProducto.Text
        btnAgrgarPedido.Visible = Visible
        Close()
    End Sub
End Class