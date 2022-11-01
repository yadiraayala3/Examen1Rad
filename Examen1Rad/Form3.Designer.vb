<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreEmp = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtIdSuc = New System.Windows.Forms.TextBox()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(26, 141)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(107, 141)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido:"
        '
        'txtNombreEmp
        '
        Me.txtNombreEmp.Location = New System.Drawing.Point(107, 25)
        Me.txtNombreEmp.Name = "txtNombreEmp"
        Me.txtNombreEmp.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreEmp.TabIndex = 4
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(107, 51)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 5
        '
        'txtIdSuc
        '
        Me.txtIdSuc.Location = New System.Drawing.Point(107, 79)
        Me.txtIdSuc.Name = "txtIdSuc"
        Me.txtIdSuc.Size = New System.Drawing.Size(100, 20)
        Me.txtIdSuc.TabIndex = 6
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(107, 105)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Id Sucursal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sueldo:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 203)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.txtIdSuc)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombreEmp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Name = "Form3"
        Me.Text = "Registrar empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreEmp As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtIdSuc As TextBox
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
