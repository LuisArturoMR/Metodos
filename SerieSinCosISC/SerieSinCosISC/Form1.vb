Public Class Form1

    
    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim x, n, vsin, vcos, ve, auxsin, auxcos, auxe, signo, facto, potencia As Double

        x = Val(TxtX.Text)
        n = Val(TxtN.Text)

        If (x <= 0 Or n <= 0) Then
            TxtMensaje.Text = "Error: Ingresa un numero valido"
        Else
            TxtMensaje.Text = "Listo!"

            'sen'
            signo = 1

            For i As Integer = 1 To n Step 2
                facto = 1
                potencia = Math.Pow(x, i)
                For j As Integer = 1 To i Step 1
                    facto = facto * j
                Next

                auxsin = auxsin + (potencia / facto) * signo

                'signo'
                signo = signo * (-1)
            Next
            vsin = Math.Sin(x)
            TxtSin.Text = Str(vsin)
            TxtAproxSin.Text = Str(auxsin)

            'cos'

            signo = 1
            auxcos = 1
            For i = 2 To n Step 2
                facto = 1
                potencia = Math.Pow(x, i)
                For j As Integer = 1 To i Step 1
                    facto = facto * j
                Next
                auxcos = auxcos - (potencia / facto) * signo

                'signo'
                signo = signo * (-1)
            Next
            vcos = Math.Cos(x)
            TxtAproxCos.Text = Str(auxcos)
            TxtCos.Text = Str(vcos)

            'e(x)'
            auxe = 2
            For i As Integer = 1 To n Step 1
                facto = 1
                potencia = Math.Pow(x, i)
                For j = 1 To i Step 1
                    facto = facto * j
                Next
                auxe = auxe + (potencia / facto)

            Next

            ve = Math.Exp(x)
            TxtAproxE.Text = Str(auxe)
            TxtE.Text = Str(ve)

        End If
    End Sub
End Class
