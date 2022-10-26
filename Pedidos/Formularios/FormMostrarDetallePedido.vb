Public Class FormMostrarDetallePedido
    Private Sub FormMostrarDetallePedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PEDIDOSDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.PEDIDOSDataSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'PEDIDOSDataSet3.mostrarDetallePedido' Puede moverla o quitarla según sea necesario.
        Me.mostrarDetallePedidoTableAdapter.Fill(Me.PEDIDOSDataSet3.mostrarDetallePedido, Convert.ToInt32(txtNumPedido.Text))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class