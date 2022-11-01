<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreSuc = New System.Windows.Forms.TextBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de la sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ubiacion de la sucursal:"
        '
        'txtNombreSuc
        '
        Me.txtNombreSuc.Location = New System.Drawing.Point(153, 37)
        Me.txtNombreSuc.Name = "txtNombreSuc"
        Me.txtNombreSuc.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreSuc.TabIndex = 2
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(153, 66)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(100, 20)
        Me.txtUbicacion.TabIndex = 3
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(72, 100)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 4
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(153, 100)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 157)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.txtNombreSuc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Registrar sucursal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreSuc As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnSalir As Button
End Class
