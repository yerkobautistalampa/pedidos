<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMostrarDetallePedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.mostrarDetallePedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PEDIDOSDataSet3 = New Pedidos.PEDIDOSDataSet3()
        Me.PedidosDataSet1 = New Pedidos.PEDIDOSDataSet()
        Me.mostrarDetallePedidoTableAdapter = New Pedidos.PEDIDOSDataSet3TableAdapters.mostrarDetallePedidoTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtNumPedido = New System.Windows.Forms.TextBox()
        Me.PEDIDOSDataSet = New Pedidos.PEDIDOSDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New Pedidos.PEDIDOSDataSetTableAdapters.ClienteTableAdapter()
        CType(Me.mostrarDetallePedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDIDOSDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDIDOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mostrarDetallePedidoBindingSource
        '
        Me.mostrarDetallePedidoBindingSource.DataMember = "mostrarDetallePedido"
        Me.mostrarDetallePedidoBindingSource.DataSource = Me.PEDIDOSDataSet3
        '
        'PEDIDOSDataSet3
        '
        Me.PEDIDOSDataSet3.DataSetName = "PEDIDOSDataSet3"
        Me.PEDIDOSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosDataSet1
        '
        Me.PedidosDataSet1.DataSetName = "PEDIDOSDataSet"
        Me.PedidosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrarDetallePedidoTableAdapter
        '
        Me.mostrarDetallePedidoTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mostrarDetallePedidoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pedidos.rptDetallePedido.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(750, 321)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtNumPedido
        '
        Me.txtNumPedido.Location = New System.Drawing.Point(400, 68)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtNumPedido.TabIndex = 1
        Me.txtNumPedido.Visible = False
        '
        'PEDIDOSDataSet
        '
        Me.PEDIDOSDataSet.DataSetName = "PEDIDOSDataSet"
        Me.PEDIDOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.PEDIDOSDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'FormMostrarDetallePedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 321)
        Me.Controls.Add(Me.txtNumPedido)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormMostrarDetallePedido"
        Me.Text = "FormMostrarDetallePedido"
        CType(Me.mostrarDetallePedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDIDOSDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDIDOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PedidosDataSet1 As PEDIDOSDataSet
    Friend WithEvents mostrarDetallePedidoBindingSource As BindingSource
    Friend WithEvents PEDIDOSDataSet3 As PEDIDOSDataSet3
    Friend WithEvents mostrarDetallePedidoTableAdapter As PEDIDOSDataSet3TableAdapters.mostrarDetallePedidoTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtNumPedido As TextBox
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents PEDIDOSDataSet As PEDIDOSDataSet
    Friend WithEvents ClienteTableAdapter As PEDIDOSDataSetTableAdapters.ClienteTableAdapter
End Class
