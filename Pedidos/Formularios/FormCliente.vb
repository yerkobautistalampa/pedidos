Imports System.Data.SqlClient
Public Class FormCliente
    Private dt As New DataTable
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Listado()
    End Sub
    Private Sub Listado()
        Try
            Dim fc As New FCliente
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim fc As New FCliente
            dt = fc.Buscar(txtCi.Text)
            If dt.Rows.Count <> 0 Then
                dgvListado.DataSource = dt
            Else
                dgvListado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        btnGuardar.Visible = True
        btnCanselar.Visible = True
        btnBuscar.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False


    End Sub
    Private Sub limpiar()
        txtNro.Text = ""
        txtCi.Text = ""
        txtSexo.Text = ""
        txtNombre.Text = ""
        txtAPaterno.Text = ""
        txtAMaterno.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNro.Text <> "" And txtCi.Text <> "" And txtNombre.Text <> "" And txtAPaterno.Text <> "" And txtAMaterno.Text <> "" And txtEmail.Text <> "" And txtSexo.Text <> "" And txtTelefono.Text <> "" Then
            Try
                Dim fun As New FCliente
                If fun.Insertar(txtNro.Text, txtCi.Text, txtNombre.Text, txtAPaterno.Text, txtAMaterno.Text, txtSexo.Text, txtEmail.Text, txtTelefono.Text) Then
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
        BtnEliminar.Enabled = True

    End Sub
    Private Sub btnCanselar_Click(sender As Object, e As EventArgs) Handles btnCanselar.Click
        btnGuardar.Enabled = True
        btnCanselar.Enabled = True
        btnBuscar.Enabled = True
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        BtnEliminar.Enabled = True
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim resul As DialogResult
        resul = MessageBox.Show("esta seguro de eliminar los datos del clientes", "eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resul = DialogResult.OK Then
            If txtCi.Text <> "" Then
                Try
                    Dim fc As New FCliente
                    If fc.Eliminar(txtCi.Text) Then
                        Listado()
                        limpiar()
                        MessageBox.Show("cliente eliminado correctamente", "eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("cliente no fue eliminado correctamente", "eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("inserte un ci", "eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNro.Text <> "" And txtCi.Text <> "" And txtNombre.Text <> "" And txtAPaterno.Text <> "" And txtAMaterno.Text <> "" And txtEmail.Text <> "" And txtSexo.Text <> "" And txtTelefono.Text <> "" Then
            Try
                Dim fun As New FCliente
                If fun.actualizar(txtNro.Text, txtCi.Text, txtNombre.Text, txtAPaterno.Text, txtAMaterno.Text, txtSexo.Text, txtEmail.Text, txtTelefono.Text) Then
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


    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick
        Try
            txtNro.Text = dgvListado.SelectedCells.Item(0).Value
            txtCi.Text = dgvListado.SelectedCells.Item(1).Value
            txtSexo.Text = dgvListado.SelectedCells.Item(2).Value
            txtNombre.Text = dgvListado.SelectedCells.Item(3).Value
            txtAPaterno.Text = dgvListado.SelectedCells.Item(4).Value
            txtAMaterno.Text = dgvListado.SelectedCells.Item(5).Value
            txtTelefono.Text = dgvListado.SelectedCells.Item(6).Value
            txtEmail.Text = dgvListado.SelectedCells.Item(7).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listado()
    End Sub
    Private Sub btnModificarn_Click(sender As Object, e As EventArgs) Handles btnModificarn.Click

    End Sub

    Private Sub dgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentClick
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
        FormMenu.Show()
    End Sub

    Private Sub btnAgrgarPedido_Click(sender As Object, e As EventArgs) Handles btnAgrgarPedido.Click
        FormPedido.txtNroCliente.Text = txtNro.Text
        btnAgrgarPedido.Visible = Visible
        Close()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        FormListaCliente.Show()
    End Sub
End Class