<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbMunicipio = New System.Windows.Forms.ComboBox()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(50, 12)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(121, 20)
        Me.tbNombre.TabIndex = 0
        Me.tbNombre.Text = "Nombre"
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(50, 38)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(121, 20)
        Me.tbApellido.TabIndex = 1
        Me.tbApellido.Text = "Apellido"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(50, 64)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(121, 21)
        Me.cbDepartamento.TabIndex = 2
        Me.cbDepartamento.Text = "Seleccione"
        '
        'cbMunicipio
        '
        Me.cbMunicipio.FormattingEnabled = True
        Me.cbMunicipio.Location = New System.Drawing.Point(50, 91)
        Me.cbMunicipio.Name = "cbMunicipio"
        Me.cbMunicipio.Size = New System.Drawing.Size(121, 21)
        Me.cbMunicipio.TabIndex = 3
        Me.cbMunicipio.Text = "Seleccione"
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(70, 161)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 4
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 261)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.cbMunicipio)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.tbNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents cbMunicipio As ComboBox
    Friend WithEvents btAceptar As Button
End Class
