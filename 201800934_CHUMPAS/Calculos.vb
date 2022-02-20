Module Calculos

    Const p_small As Double = 65.5
    Const p_medium As Double = 85.99
    Const p_large As Double = 99.99

    Const m_algodon As Double = 15
    Const m_seda As Double = 23.99
    Const m_lona As Double = 30.99

    Const c_small As Double = 2
    Const c_medium As Double = 2.5
    Const c_large As Double = 3

    Function PrecioCosto() As Double
        Dim precioC As Double

        If Form1.r_small.Checked = True Then
            If Form1.r_algodon.Checked = True Then
                precioC = p_small + c_small * m_algodon
            ElseIf Form1.r_seda.Checked = True Then
                precioC = p_small + c_small * m_seda
            ElseIf Form1.r_lona.Checked = True Then
                precioC = p_small + c_small * m_lona
            End If
        ElseIf Form1.r_medium.Checked = True Then
            If Form1.r_algodon.Checked = True Then
                precioC = p_medium + c_medium * m_algodon
            ElseIf Form1.r_seda.Checked = True Then
                precioC = p_medium + c_medium * m_seda
            ElseIf Form1.r_lona.Checked = True Then
                precioC = p_medium + c_medium * m_lona
            End If
        ElseIf Form1.r_large.Checked = True Then
            If Form1.r_algodon.Checked = True Then
                precioC = p_large + c_large * m_algodon
            ElseIf Form1.r_seda.Checked = True Then
                precioC = p_large + c_large * m_seda
            ElseIf Form1.r_lona.Checked = True Then
                precioC = p_large + c_large * m_lona
            End If
        End If
        Return precioC
    End Function

    Function PrecioVenta() As Double
        Dim precioV As Double

        precioV = PrecioCosto()

        Return precioV * 0.65 + precioV
    End Function

    Function TotalProduccion() As Double
        Dim totalP As Double

        totalP = PrecioCosto() * Val(Form1.txt_cantidad.Text)

        Return totalP
    End Function

    Public Sub Limpiar()
        Form1.txt_cantidad.Text = 0
        Form1.r_small.Checked = False
        Form1.r_medium.Checked = False
        Form1.r_large.Checked = False
        Form1.r_seda.Checked = False
        Form1.r_algodon.Checked = False
        Form1.r_lona.Checked = False

    End Sub

    Public Sub Salir()
        End
    End Sub

End Module
