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
        Me.Button_Restaurar = New System.Windows.Forms.Button()
        Me.Button_Calcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_Calorias = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Peso = New System.Windows.Forms.TextBox()
        Me.TextBox_Edad = New System.Windows.Forms.TextBox()
        Me.TextBox_Altura = New System.Windows.Forms.TextBox()
        Me.RadioButton_M = New System.Windows.Forms.RadioButton()
        Me.RadioButton_F = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_Actividades = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Restaurar
        '
        Me.Button_Restaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Restaurar.Location = New System.Drawing.Point(174, 251)
        Me.Button_Restaurar.Name = "Button_Restaurar"
        Me.Button_Restaurar.Size = New System.Drawing.Size(94, 23)
        Me.Button_Restaurar.TabIndex = 0
        Me.Button_Restaurar.Text = "Restaurar"
        Me.Button_Restaurar.UseVisualStyleBackColor = True
        '
        'Button_Calcular
        '
        Me.Button_Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Calcular.Location = New System.Drawing.Point(33, 251)
        Me.Button_Calcular.Name = "Button_Calcular"
        Me.Button_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Button_Calcular.TabIndex = 1
        Me.Button_Calcular.Text = "Calcular"
        Me.Button_Calcular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calorias:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Calorias diarias"
        '
        'Label_Calorias
        '
        Me.Label_Calorias.AutoSize = True
        Me.Label_Calorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Calorias.Location = New System.Drawing.Point(101, 209)
        Me.Label_Calorias.Name = "Label_Calorias"
        Me.Label_Calorias.Size = New System.Drawing.Size(16, 16)
        Me.Label_Calorias.TabIndex = 8
        Me.Label_Calorias.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_Peso)
        Me.GroupBox1.Controls.Add(Me.TextBox_Edad)
        Me.GroupBox1.Controls.Add(Me.TextBox_Altura)
        Me.GroupBox1.Controls.Add(Me.RadioButton_M)
        Me.GroupBox1.Controls.Add(Me.RadioButton_F)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Actividades)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 160)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'TextBox_Peso
        '
        Me.TextBox_Peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Peso.Location = New System.Drawing.Point(60, 113)
        Me.TextBox_Peso.Name = "TextBox_Peso"
        Me.TextBox_Peso.Size = New System.Drawing.Size(84, 21)
        Me.TextBox_Peso.TabIndex = 23
        '
        'TextBox_Edad
        '
        Me.TextBox_Edad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Edad.Location = New System.Drawing.Point(63, 68)
        Me.TextBox_Edad.Name = "TextBox_Edad"
        Me.TextBox_Edad.Size = New System.Drawing.Size(82, 21)
        Me.TextBox_Edad.TabIndex = 22
        '
        'TextBox_Altura
        '
        Me.TextBox_Altura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Altura.Location = New System.Drawing.Point(65, 26)
        Me.TextBox_Altura.Name = "TextBox_Altura"
        Me.TextBox_Altura.Size = New System.Drawing.Size(81, 21)
        Me.TextBox_Altura.TabIndex = 21
        '
        'RadioButton_M
        '
        Me.RadioButton_M.AutoSize = True
        Me.RadioButton_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_M.Location = New System.Drawing.Point(237, 30)
        Me.RadioButton_M.Name = "RadioButton_M"
        Me.RadioButton_M.Size = New System.Drawing.Size(38, 20)
        Me.RadioButton_M.TabIndex = 20
        Me.RadioButton_M.TabStop = True
        Me.RadioButton_M.Text = "M"
        Me.RadioButton_M.UseVisualStyleBackColor = True
        '
        'RadioButton_F
        '
        Me.RadioButton_F.AutoSize = True
        Me.RadioButton_F.Checked = True
        Me.RadioButton_F.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_F.Location = New System.Drawing.Point(175, 29)
        Me.RadioButton_F.Name = "RadioButton_F"
        Me.RadioButton_F.Size = New System.Drawing.Size(35, 20)
        Me.RadioButton_F.TabIndex = 19
        Me.RadioButton_F.TabStop = True
        Me.RadioButton_F.Text = "F"
        Me.RadioButton_F.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Peso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Edad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Altura"
        '
        'ComboBox_Actividades
        '
        Me.ComboBox_Actividades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Actividades.FormattingEnabled = True
        Me.ComboBox_Actividades.Items.AddRange(New Object() {"Actividades", "Sedentaria", "Ligera", "Moderada", "Dinamica", "Muy dinamica"})
        Me.ComboBox_Actividades.Location = New System.Drawing.Point(165, 68)
        Me.ComboBox_Actividades.Name = "ComboBox_Actividades"
        Me.ComboBox_Actividades.Size = New System.Drawing.Size(108, 23)
        Me.ComboBox_Actividades.TabIndex = 15
        Me.ComboBox_Actividades.Text = "Actividades"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(312, 296)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_Calorias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Calcular)
        Me.Controls.Add(Me.Button_Restaurar)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calorias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Restaurar As System.Windows.Forms.Button
    Friend WithEvents Button_Calcular As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label_Calorias As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Peso As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Edad As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Altura As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton_M As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_F As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Actividades As System.Windows.Forms.ComboBox

End Class
