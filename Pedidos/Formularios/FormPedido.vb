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
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNroPedido.Text <> "" And txtNroCliente.Text <> "" And txtCodProducto.Text <> "" And txtCantidad.Text <> "" And dtpFechaPedido.Text <> "" Then
            Try
                Dim fun As New FPedido
                If fun.Insertar(txtNroPedido.Text, txtNroCliente.Text, txtCodProducto.Text, txtCantidad.Text, dtpFechaPedido.Text) Then
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
        txtNroPedido.Text = ""
        txtCodProducto.Text = ""
        txtNroCliente.Text = ""
        txtCantidad.Text = ""
        dtpFechaPedido.Text = ""
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim fc As New FPedido
            dt = fc.Buscar(txtNroPedido.Text)
            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
            Else
                dgvListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("esta seguro de eliminar los datos del pedido", "eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            If txtNroPedido.Text <> "" Then
                Try
                    Dim fc As New FPedido
                    If fc.Eliminar(txtNroPedido.Text) Then
                        Listado()
                        limpiar()
                        MessageBox.Show("pedido eliminado correctamente", "eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("pedido no fue eliminado correctamente", "eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("inserte un nro de pedido", "eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub


    Private Sub dgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentClick

    End Sub
    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick
        Try
            txtNroPedido.Text = dgvListado.SelectedCells.Item(0).Value
            txtNroCliente.Text = dgvListado.SelectedCells.Item(1).Value
            txtCodProducto.Text = dgvListado.SelectedCells.Item(4).Value
            txtCantidad.Text = dgvListado.SelectedCells.Item(6).Value
            dtpFechaPedido.Text = dgvListado.SelectedCells.Item(7).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNroPedido.Text <> "" And txtNroCliente.Text <> "" And txtCodProducto.Text <> "" And txtCantidad.Text <> "" And dtpFechaPedido.Text <> "" Then
            Try
                Dim fun As New FPedido
                If fun.actualizar(txtNroPedido.Text, txtNroCliente.Text, txtCodProducto.Text, txtCantidad.Text, dtpFechaPedido.Text) Then
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

    Private Sub btnFormCliente_Click(sender As Object, e As EventArgs) Handles btnFormCliente.Click
        FormCliente.Show()
        FormCliente.btnAgrgarPedido.Visible = True
    End Sub

    Private Sub btnFormProductyo_Click(sender As Object, e As EventArgs) Handles btnFormProductyo.Click
        FormProducto.Show()
        FormProducto.btnAgrgarPedido.Visible = True
    End Sub

    Private Sub FormPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listado()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        FormMostrarDetallePedido.txtNumPedido.Text = txtNroPedido.Text
        FormMostrarDetallePedido.ShowDialog()

    End Sub
End Class