Imports System.ComponentModel

Public Class Form1

    Dim horasextra As Double
    Dim pagoxhora As Double
    Dim pagohorasextra As Double
    Dim horasTrabajadas As Double
    Dim sueldobruto As Double
    Dim sueldoNeto As Double


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If Val(TextBox3.Text) > 40 Then
            horasextra = Val(TextBox3.Text) - 40
            horasTrabajadas = 40
        Else
            horasextra = 0
            horasTrabajadas = Val(TextBox3.Text)
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pagoxhora = Val(TextBox2.Text)
        pagohorasextra = pagoxhora * horasextra


        If CheckBox1.Checked Then 'turno diurno
            pagohorasextra = pagohorasextra * 0.15 + pagohorasextra
            TextBox4.Text = pagohorasextra
        End If

        If CheckBox2.Checked Then 'turno nocturno
            pagohorasextra = pagohorasextra * 0.25 + pagohorasextra
            TextBox4.Text = pagohorasextra
        End If




        'TextBox8.Text = sueldobruto

        sueldobruto = (pagoxhora * horasTrabajadas) + (pagohorasextra)
        'TextBox8.Text = sueldoNeto

        If checkboxs3.Checked Then
            sueldoNeto = sueldobruto - (sueldobruto * 0.035)
        End If

        If CheckBox4.Checked Then
            sueldoNeto = sueldobruto - (sueldobruto * 0.015)
        End If

        If CheckBox5.Checked Then
            sueldoNeto = sueldobruto - 1000
        End If




        If checkboxs3.Checked And CheckBox4.Checked Then
            sueldoNeto = sueldobruto - (sueldobruto * 0.035) - (sueldobruto * 0.015)
        End If

        If CheckBox4.Checked And CheckBox5.Checked Then
            sueldoNeto = sueldobruto - (sueldobruto * 0.015) - 1000
        End If

        If checkboxs3.Checked And CheckBox5.Checked Then
            sueldoNeto = sueldobruto - (sueldobruto * 0.035) - 1000
        End If

        If checkboxs3.Checked And CheckBox4.Checked And CheckBox5.Checked Then
            sueldoNeto = sueldobruto - (sueldobruto * 0.035) - (sueldobruto * 0.015) - 1000
        End If


        If sueldoNeto = 0 Then
            TextBox8.Text = sueldobruto
        Else
            TextBox8.Text = sueldoNeto
        End If

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox5.Text = "3.5%"
        TextBox6.Text = "1.5%"
        TextBox7.Text = "1000"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox8.Text = ""

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        checkboxs3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class


