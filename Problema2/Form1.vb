Public Class Form1
    Dim cedula As Integer
    Dim nombre, apellido, estado As String
    Dim peso, Imc As Single
    Dim altura As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        txtApellido.Text = ""
        txtCedula.Text = ""
        txtEstatura.Text = ""
        txtIMC.Text = ""
        txtNombre.Text = ""
        txtPeso.Text = ""
        txtEstado.Text = ""
    End Sub
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            cedula = CDbl(Me.txtCedula.Text)
            peso = CDbl(Me.txtPeso.Text)
            altura = CDbl(Me.txtEstatura.Text)
        Catch ex As Exception
            MsgBox("TEXTO NO DETECTADO, TIENES QUE ESCRIBIR UN NUMERO")
        End Try

        txtIMC.Text = Val(txtPeso.Text) / Val(txtEstatura.Text ^ 2)

        Select Case (txtIMC.Text)
            Case Is <= 14.9
                txtEstado.Text = "Normal"

            Case Is >= 18
                txtEstado.Text = "Sobre peso"

            Case Is >= 25
                txtEstado.Text = "Excesivamente"

            Case Is >= 34
                txtEstado.Text = "Pasado de peso"

            Case Else
                txtEstado.Text = " Usted esta en buenas Condiciones "
        End Select

    End Sub
End Class
