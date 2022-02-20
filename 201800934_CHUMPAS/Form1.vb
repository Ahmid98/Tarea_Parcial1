Public Class Form1
    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click

        If r_small.Checked = True Or r_medium.Checked = True Or r_large.Checked = True Then
            If r_seda.Checked = True Or r_algodon.Checked = True Or r_lona.Checked = True Then
                Resultados.lb_precioC.Text = System.Math.Round(Calculos.PrecioCosto, 2)
                Resultados.lb_precioV.Text = System.Math.Round(Calculos.PrecioVenta, 2)
                Resultados.lb_totalP.Text = System.Math.Round(Calculos.TotalProduccion, 2)
            Else
                MsgBox("Debe seleccionar un tamaño..")
            End If
        Else
            MsgBox("Debe seleccionar un material..")
        End If



        Resultados.Show()
        Me.Hide()

    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Salir()
    End Sub
End Class
