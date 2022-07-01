<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(139, 126)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(145, 38)
        Me.btnCliente.TabIndex = 0
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(139, 199)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(145, 38)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnPedidos
        '
        Me.btnPedidos.Location = New System.Drawing.Point(139, 279)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(145, 38)
        Me.btnPedidos.TabIndex = 2
        Me.btnPedidos.Text = "Pedidos"
        Me.btnPedidos.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 442)
        Me.Controls.Add(Me.btnPedidos)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnCliente)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCliente As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnPedidos As Button
End Class
