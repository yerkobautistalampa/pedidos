Public Class FormListaCliente
    Private Sub FormListaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PEDIDOSDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.PEDIDOSDataSet.Cliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class