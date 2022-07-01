<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAPaterno = New System.Windows.Forms.TextBox()
        Me.txtAMaterno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCanselar = New System.Windows.Forms.Button()
        Me.btnModificarn = New System.Windows.Forms.Button()
        Me.btnAgrgarPedido = New System.Windows.Forms.Button()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos del Cliente"
        '
        'txtNro
        '
        Me.txtNro.Location = New System.Drawing.Point(143, 55)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(200, 29)
        Me.txtNro.TabIndex = 1
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(444, 55)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(200, 29)
        Me.txtCi.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(143, 91)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 29)
        Me.txtNombre.TabIndex = 2
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(444, 91)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(200, 29)
        Me.txtSexo.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(444, 126)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 29)
        Me.txtEmail.TabIndex = 7
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(444, 161)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(200, 29)
        Me.txtTelefono.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nro Ci."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sexo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(349, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Telefono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(376, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Email:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(226, 253)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(209, 29)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(226, 207)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(209, 32)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(446, 207)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(198, 30)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(446, 249)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(198, 32)
        Me.BtnEliminar.TabIndex = 16
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Location = New System.Drawing.Point(26, 289)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(842, 183)
        Me.dgvListado.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Ap. Paterno:"
        '
        'txtAPaterno
        '
        Me.txtAPaterno.Location = New System.Drawing.Point(143, 126)
        Me.txtAPaterno.Name = "txtAPaterno"
        Me.txtAPaterno.Size = New System.Drawing.Size(200, 29)
        Me.txtAPaterno.TabIndex = 3
        '
        'txtAMaterno
        '
        Me.txtAMaterno.Location = New System.Drawing.Point(143, 161)
        Me.txtAMaterno.Name = "txtAMaterno"
        Me.txtAMaterno.Size = New System.Drawing.Size(200, 29)
        Me.txtAMaterno.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Ap. Materno:"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(26, 483)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(238, 32)
        Me.btnMostrar.TabIndex = 22
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(421, 483)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(223, 32)
        Me.btnCerrar.TabIndex = 23
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(26, 208)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(189, 30)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCanselar
        '
        Me.btnCanselar.Location = New System.Drawing.Point(26, 254)
        Me.btnCanselar.Name = "btnCanselar"
        Me.btnCanselar.Size = New System.Drawing.Size(191, 29)
        Me.btnCanselar.TabIndex = 27
        Me.btnCanselar.Text = "Canselar"
        Me.btnCanselar.UseVisualStyleBackColor = True
        '
        'btnModificarn
        '
        Me.btnModificarn.Location = New System.Drawing.Point(734, 505)
        Me.btnModificarn.Name = "btnModificarn"
        Me.btnModificarn.Size = New System.Drawing.Size(10, 10)
        Me.btnModificarn.TabIndex = 28
        Me.btnModificarn.Text = "Modificar"
        Me.btnModificarn.UseVisualStyleBackColor = True
        Me.btnModificarn.Visible = False
        '
        'btnAgrgarPedido
        '
        Me.btnAgrgarPedido.Location = New System.Drawing.Point(444, 4)
        Me.btnAgrgarPedido.Name = "btnAgrgarPedido"
        Me.btnAgrgarPedido.Size = New System.Drawing.Size(200, 32)
        Me.btnAgrgarPedido.TabIndex = 29
        Me.btnAgrgarPedido.Text = "Agregar pedido"
        Me.btnAgrgarPedido.UseVisualStyleBackColor = True
        Me.btnAgrgarPedido.Visible = False
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 527)
        Me.Controls.Add(Me.btnAgrgarPedido)
        Me.Controls.Add(Me.btnModificarn)
        Me.Controls.Add(Me.btnCanselar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtAMaterno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAPaterno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvListado)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSexo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.txtNro)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FormCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCliente"
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents txtCi As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAPaterno As TextBox
    Friend WithEvents txtAMaterno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCanselar As Button
    Friend WithEvents btnModificarn As Button
    Friend WithEvents btnAgrgarPedido As Button
End Class
