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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.gb_esp = New System.Windows.Forms.GroupBox()
        Me.gb_material = New System.Windows.Forms.GroupBox()
        Me.r_lona = New System.Windows.Forms.RadioButton()
        Me.r_seda = New System.Windows.Forms.RadioButton()
        Me.r_algodon = New System.Windows.Forms.RadioButton()
        Me.gb_tam = New System.Windows.Forms.GroupBox()
        Me.r_large = New System.Windows.Forms.RadioButton()
        Me.r_medium = New System.Windows.Forms.RadioButton()
        Me.r_small = New System.Windows.Forms.RadioButton()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gb_esp.SuspendLayout()
        Me.gb_material.SuspendLayout()
        Me.gb_tam.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global._201800934_CHUMPAS.My.Resources.Resources.Fondo1
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.btn_limpiar)
        Me.GroupBox1.Controls.Add(Me.btn_calcular)
        Me.GroupBox1.Controls.Add(Me.gb_esp)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Pepper Sauce", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 412)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DATOS PEDIDO DE CHUMPAS"
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_salir.Font = New System.Drawing.Font("Pepper Sauce", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(510, 345)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(157, 49)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_limpiar.Font = New System.Drawing.Font("Pepper Sauce", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(296, 345)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(157, 49)
        Me.btn_limpiar.TabIndex = 4
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_calcular.Font = New System.Drawing.Font("Pepper Sauce", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(96, 345)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(157, 49)
        Me.btn_calcular.TabIndex = 3
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'gb_esp
        '
        Me.gb_esp.Controls.Add(Me.gb_material)
        Me.gb_esp.Controls.Add(Me.gb_tam)
        Me.gb_esp.Location = New System.Drawing.Point(367, 32)
        Me.gb_esp.Name = "gb_esp"
        Me.gb_esp.Size = New System.Drawing.Size(365, 252)
        Me.gb_esp.TabIndex = 2
        Me.gb_esp.TabStop = False
        Me.gb_esp.Text = "Especificaciones:"
        '
        'gb_material
        '
        Me.gb_material.Controls.Add(Me.r_lona)
        Me.gb_material.Controls.Add(Me.r_seda)
        Me.gb_material.Controls.Add(Me.r_algodon)
        Me.gb_material.Location = New System.Drawing.Point(194, 57)
        Me.gb_material.Name = "gb_material"
        Me.gb_material.Size = New System.Drawing.Size(136, 169)
        Me.gb_material.TabIndex = 3
        Me.gb_material.TabStop = False
        Me.gb_material.Text = "Material:"
        '
        'r_lona
        '
        Me.r_lona.AutoSize = True
        Me.r_lona.Location = New System.Drawing.Point(16, 116)
        Me.r_lona.Name = "r_lona"
        Me.r_lona.Size = New System.Drawing.Size(78, 29)
        Me.r_lona.TabIndex = 2
        Me.r_lona.TabStop = True
        Me.r_lona.Text = "Lona"
        Me.r_lona.UseVisualStyleBackColor = True
        '
        'r_seda
        '
        Me.r_seda.AutoSize = True
        Me.r_seda.Location = New System.Drawing.Point(16, 76)
        Me.r_seda.Name = "r_seda"
        Me.r_seda.Size = New System.Drawing.Size(77, 29)
        Me.r_seda.TabIndex = 1
        Me.r_seda.TabStop = True
        Me.r_seda.Text = "Seda"
        Me.r_seda.UseVisualStyleBackColor = True
        '
        'r_algodon
        '
        Me.r_algodon.AutoSize = True
        Me.r_algodon.Location = New System.Drawing.Point(16, 34)
        Me.r_algodon.Name = "r_algodon"
        Me.r_algodon.Size = New System.Drawing.Size(111, 29)
        Me.r_algodon.TabIndex = 0
        Me.r_algodon.TabStop = True
        Me.r_algodon.Text = "Algodon"
        Me.r_algodon.UseVisualStyleBackColor = True
        '
        'gb_tam
        '
        Me.gb_tam.Controls.Add(Me.r_large)
        Me.gb_tam.Controls.Add(Me.r_medium)
        Me.gb_tam.Controls.Add(Me.r_small)
        Me.gb_tam.Location = New System.Drawing.Point(31, 57)
        Me.gb_tam.Name = "gb_tam"
        Me.gb_tam.Size = New System.Drawing.Size(136, 169)
        Me.gb_tam.TabIndex = 0
        Me.gb_tam.TabStop = False
        Me.gb_tam.Text = "Tamaño:"
        '
        'r_large
        '
        Me.r_large.AutoSize = True
        Me.r_large.Location = New System.Drawing.Point(16, 116)
        Me.r_large.Name = "r_large"
        Me.r_large.Size = New System.Drawing.Size(88, 29)
        Me.r_large.TabIndex = 2
        Me.r_large.TabStop = True
        Me.r_large.Text = "Large"
        Me.r_large.UseVisualStyleBackColor = True
        '
        'r_medium
        '
        Me.r_medium.AutoSize = True
        Me.r_medium.Location = New System.Drawing.Point(16, 76)
        Me.r_medium.Name = "r_medium"
        Me.r_medium.Size = New System.Drawing.Size(103, 29)
        Me.r_medium.TabIndex = 1
        Me.r_medium.TabStop = True
        Me.r_medium.Text = "Medium"
        Me.r_medium.UseVisualStyleBackColor = True
        '
        'r_small
        '
        Me.r_small.AutoSize = True
        Me.r_small.Location = New System.Drawing.Point(16, 34)
        Me.r_small.Name = "r_small"
        Me.r_small.Size = New System.Drawing.Size(86, 29)
        Me.r_small.TabIndex = 0
        Me.r_small.TabStop = True
        Me.r_small.Text = "Small"
        Me.r_small.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_cantidad.Location = New System.Drawing.Point(187, 100)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(141, 33)
        Me.txt_cantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Pepper Sauce", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "SISTEMA FABRICA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_esp.ResumeLayout(False)
        Me.gb_material.ResumeLayout(False)
        Me.gb_material.PerformLayout()
        Me.gb_tam.ResumeLayout(False)
        Me.gb_tam.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gb_esp As GroupBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gb_material As GroupBox
    Friend WithEvents r_lona As RadioButton
    Friend WithEvents r_seda As RadioButton
    Friend WithEvents r_algodon As RadioButton
    Friend WithEvents gb_tam As GroupBox
    Friend WithEvents r_large As RadioButton
    Friend WithEvents r_medium As RadioButton
    Friend WithEvents r_small As RadioButton
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_calcular As Button
End Class
