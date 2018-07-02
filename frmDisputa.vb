Public Class frmDisputa

    Private NumerosDisputa(74) As Integer
    Private NumLeftDisputa As Integer
    Private SorteioOrdem As Integer
    Private Maior As Integer

    Private Sub frmDisputa_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Timer1.Enabled = False

    End Sub

    'Carrega Form
    Private Sub frmDisputa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SorteioOrdem = 0
        Maior = 0
        Timer1.Enabled = False
        LabelNum.Text = "00"
        LabelParticipante.Text = ""
        PreencheNumerosDisputa()

    End Sub

    'Preenche Os NumerosDisputa
    Private Sub PreencheNumerosDisputa()
        Dim Indice As Integer

        For Indice = 0 To 74
            NumerosDisputa(Indice) = Indice + 1
        Next

        EmbaralharDisputa()


        NumLeftDisputa = 74
        SorteioOrdem = 0
        ListBox1.Items.Clear()

    End Sub

    ' Embaralhar
    Public Sub EmbaralharDisputa()
        Dim A As Integer, Tmp As Integer, Indice As Integer

        For A = 0 To NumLeftDisputa
            Randomize()
            Indice = (NumLeftDisputa * Rnd())  ' Pega um numero aleatorio
            Tmp = NumerosDisputa(A)
            NumerosDisputa(A) = NumerosDisputa(Indice)
            NumerosDisputa(Indice) = Tmp
        Next

    End Sub

    'Sorteio do numero
    Private Sub SorteioDisputa()
        Dim Indice As Integer, Numero As Integer

        If NumLeftDisputa = -1 Then Exit Sub

        SorteioOrdem = SorteioOrdem + 1
        Randomize()
        Indice = CInt(Int((NumLeftDisputa * Rnd())))
        Numero = NumerosDisputa(Indice)

        LabelNum.Text = Format(Numero, "00")

        If Numero > Maior Then
            Maior = Numero
            LabelParticipante.Text = "Participante " & Format(SorteioOrdem, "00") & " com a bola " & Format(Numero, "00")
        End If

        ListBox1.Items.Add("Participante " & Format(SorteioOrdem, "00 = Bola ") & Format(Numero, "00"))

        'Retira o numero do array de números disponiveis
        If Indice = NumLeftDisputa Then
            NumerosDisputa(Indice) = 0
        Else
            NumerosDisputa(Indice) = NumerosDisputa(NumLeftDisputa)
            NumerosDisputa(NumLeftDisputa) = 0
        End If

        NumLeftDisputa = NumLeftDisputa - 1
        EmbaralharDisputa()

    End Sub

    'Controla Teclas
    Private Sub frmDisputa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode

            Case 27
                'vbKeyShift  16 SHIFT key  
                'vbKeyEscape 27 ESC key 
                'vbKeyF5 116 F5 key 
                Me.Close()

            Case 66
                'vbKeyB 66 B key 
                If Timer1.Enabled Then
                    Timer1.Enabled = False
                    SorteioDisputa()
                Else
                    Timer1.Enabled = True
                End If

            Case 33
                'vbKeyPageUp 33 PAGE UP key 
                Me.Close()

            Case 34
                'vbKeyPageDown 34 PAGE DOWN key 

        End Select
    End Sub

    'Animação da disputa
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Indice As Integer

        Randomize()
        Indice = CInt(Int((NumLeftDisputa * Rnd())))
        LabelNum.Text = Format(NumerosDisputa(Indice), "00")
        'Beep()

    End Sub
End Class