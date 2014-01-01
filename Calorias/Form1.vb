Public Class Form1
    Public Sub Calorias()
        'Declaramos las variables
        Dim altura, caloria, edad, peso, RBM As Double
        Dim actividad As String
        'Condiciones que evalúan si los campos de Texto esta vacíos
        If TextBox_Altura.Text = "" Then
            MessageBox.Show("Ingrese la altura", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox_Altura.Focus()
        Else
            If TextBox_Edad.Text = "" Then
                MessageBox.Show("Ingrese la edad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox_Edad.Focus()
            Else
                If TextBox_Peso.Text = "" Then
                    MessageBox.Show("Ingrese el peso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBox_Peso.Focus()
                Else
                    'Métodos que convierte en un tipo double el valor que se ingrese por TextBox
                    altura = Convert.ToInt32(TextBox_Altura.Text)
                    edad = Convert.ToInt32(TextBox_Edad.Text)
                    peso = Convert.ToInt32(TextBox_Peso.Text)
                    'Método para extraer el Item seleccionado en ComboBox
                    actividad = ComboBox_Actividades.SelectedItem.ToString()
                    ' La sentencia Select Case
                    Select Case actividad
                        Case "Actividades"
                            MessageBox.Show("Seleccione una actividad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case "Sedentaria"
                            'Condición que evalúa el RadioButton si es seleccionado
                            If RadioButton_F.Checked Then
                                'Formula del RITMO METABÓLICO BASAL femenino
                                RBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * edad)
                                caloria = (RBM * 1.2)
                                Label_Calorias.Text = caloria.ToString()
                            Else
                                'Formula del RITMO METABÓLICO BASAL masculino
                                RBM = 66 + (13.7 * peso) + (5 * altura) - (6.8 * edad)
                                caloria = (RBM * 1.2)
                                Label_Calorias.Text = caloria.ToString()
                            End If
                        Case "Ligera"
                            'Condición que evalúa el RadioButton si es seleccionado
                            If RadioButton_F.Checked Then
                                'Formula del RITMO METABÓLICO BASAL femenino
                                RBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * edad)
                                caloria = (RBM * 1.375)
                                Label_Calorias.Text = caloria.ToString()
                            Else
                                'Formula del RITMO METABÓLICO BASAL masculino
                                RBM = 66 + (13.7 * peso) + (5 * altura) - (6.8 * edad)
                                caloria = (RBM * 1.375)
                                Label_Calorias.Text = caloria.ToString()
                            End If
                        Case "Moderada"
                            'Condición que evalúa el RadioButton si es seleccionado
                            If RadioButton_F.Checked Then
                                'Formula del RITMO METABÓLICO BASAL femenino
                                RBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * edad)
                                caloria = (RBM * 1.55)
                                Label_Calorias.Text = caloria.ToString()
                            Else
                                'Formula del RITMO METABÓLICO BASAL masculino
                                RBM = 66 + (13.7 * peso) + (5 * altura) - (6.8 * edad)
                                caloria = (RBM * 1.55)
                                Label_Calorias.Text = caloria.ToString()
                            End If
                        Case "Dinamica"
                            'Condición que evalúa el RadioButton si es seleccionado
                            If RadioButton_F.Checked Then
                                'Formula del RITMO METABÓLICO BASAL femenino
                                RBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * edad)
                                caloria = (RBM * 1.725)
                                Label_Calorias.Text = caloria.ToString()
                            Else
                                'Formula del RITMO METABÓLICO BASAL masculino
                                RBM = 66 + (13.7 * peso) + (5 * altura) - (6.8 * edad)
                                caloria = (RBM * 1.725)
                                Label_Calorias.Text = caloria.ToString()
                            End If
                        Case "Muy dinamica"
                            'Condición que evalúa el RadioButton si es seleccionado
                            If RadioButton_F.Checked Then
                                'Formula del RITMO METABÓLICO BASAL femenino
                                RBM = 655 + (9.6 * peso) + (1.8 * altura) - (4.7 * edad)
                                caloria = (RBM * 1.9)
                                Label_Calorias.Text = caloria.ToString()
                            Else
                                'Formula del RITMO METABÓLICO BASAL masculino
                                RBM = 66 + (13.7 * peso) + (5 * altura) - (6.8 * edad)
                                caloria = (RBM * 1.9)
                                Label_Calorias.Text = caloria.ToString()
                            End If
                    End Select
                End If
            End If
        End If

    End Sub

    Private Sub Button_Calcular_Click(sender As Object, e As EventArgs) Handles Button_Calcular.Click
        Calorias()
    End Sub

    Private Sub Button_Restaurar_Click(sender As Object, e As EventArgs) Handles Button_Restaurar.Click
        TextBox_Altura.Text = " "
        TextBox_Edad.Text = " "
        TextBox_Peso.Text = " "
        Label_Calorias.Text = "0"
        TextBox_Altura.Focus()
        ComboBox_Actividades.SelectedItem = "Actividades"

    End Sub
End Class

     