<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMostar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCanselar = New System.Windows.Forms.Button()
        Me.btnAgrgarPedido = New System.Windows.Forms.Button()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos del Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod. Producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-3, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(390, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stok:"
        '
        'txtCodProducto
        '
        Me.txtCodProducto.Location = New System.Drawing.Point(168, 58)
        Me.txtCodProducto.Name = "txtCodProducto"
        Me.txtCodProducto.Size = New System.Drawing.Size(185, 29)
        Me.txtCodProducto.TabIndex = 5
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(168, 96)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(185, 29)
        Me.txtNombreProducto.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(449, 61)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(179, 29)
        Me.txtPrecio.TabIndex = 7
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(449, 100)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(179, 29)
        Me.txtStok.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(422, 197)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(191, 30)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(225, 161)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(191, 30)
        Me.btnNuevo.TabIndex = 20
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(422, 161)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(191, 30)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(225, 196)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(191, 30)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Location = New System.Drawing.Point(76, 232)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(484, 195)
        Me.dgvListado.TabIndex = 22
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(369, 433)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(191, 30)
        Me.btnCerrar.TabIndex = 24
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMostar
        '
        Me.btnMostar.Location = New System.Drawing.Point(76, 433)
        Me.btnMostar.Name = "btnMostar"
        Me.btnMostar.Size = New System.Drawing.Size(191, 30)
        Me.btnMostar.TabIndex = 23
        Me.btnMostar.Text = "Mostar"
        Me.btnMostar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(28, 161)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(191, 30)
        Me.btnGuardar.TabIndex = 25
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCanselar
        '
        Me.btnCanselar.Location = New System.Drawing.Point(28, 196)
        Me.btnCanselar.Name = "btnCanselar"
        Me.btnCanselar.Size = New System.Drawing.Size(191, 29)
        Me.btnCanselar.TabIndex = 28
        Me.btnCanselar.Text = "Canselar"
        Me.btnCanselar.UseVisualStyleBackColor = True
        '
        'btnAgrgarPedido
        '
        Me.btnAgrgarPedido.Location = New System.Drawing.Point(449, 7)
        Me.btnAgrgarPedido.Name = "btnAgrgarPedido"
        Me.btnAgrgarPedido.Size = New System.Drawing.Size(179, 35)
        Me.btnAgrgarPedido.TabIndex = 29
        Me.btnAgrgarPedido.Text = "Agregar pedido"
        Me.btnAgrgarPedido.UseVisualStyleBackColor = True
        Me.btnAgrgarPedido.Visible = False
        '
        'FormProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 475)
        Me.Controls.Add(Me.btnAgrgarPedido)
        Me.Controls.Add(Me.btnCanselar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnMostar)
        Me.Controls.Add(Me.dgvListado)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.txtCodProducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FormProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProducto"
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMostar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCanselar As Button
    Friend WithEvents btnAgrgarPedido As Button
End Class
