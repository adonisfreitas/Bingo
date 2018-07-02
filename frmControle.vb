Public Class frmControle

    'Carga do form
    Private Sub frmControle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Interval = NumericUpDownTempo.Value * 1000
        SetTimerModo(False)

    End Sub

    ' Efetua sorteio manualmente
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        SetTimerModo(False)
        frmDsk.Sorteio()

    End Sub

    ' Reinicia o jogo
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If MsgBox("Reiniciar jogo", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            frmDsk.PreencheNumeros()
        End If

    End Sub

    'Comanda sorteio
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If NumLeft = -1 Then
            SetTimerModo(False)
            Exit Sub
        End If

        frmDsk.Sorteio()

    End Sub

    ' Começa sorteio Auomatico
    Private Sub ButtonPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlay.Click

        SetTimerModo(True)

    End Sub

    'Para sorteio automatico
    Private Sub ButtonPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPause.Click

        SetTimerModo(False)

    End Sub

    ' Altera tempo de sorteio
    Private Sub NumericUpDownTempo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownTempo.ValueChanged

        Timer1.Interval = NumericUpDownTempo.Value * 1000

    End Sub

    ' Altera modo do timer
    ' True = Liga / False = Desliga
    Public Sub SetTimerModo(ByVal Modo As Boolean)

        If Modo Then
            Timer1.Start()
            NumericUpDownTempo.BackColor = Color.White
        Else
            Timer1.Stop()
            NumericUpDownTempo.BackColor = Color.Red
        End If

    End Sub

    'Reiniciar jogo
    Private Sub ReiniciarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReiniciarToolStripMenuItem.Click

        If MsgBox("Reiniciar jogo", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SetTimerModo(False)
            frmDsk.DescarregaResumoBingo()
        End If


    End Sub


End Class