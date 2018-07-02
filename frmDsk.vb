Public Class frmDsk

    ' Programa criado para sorteio de bingos beneficentes
    ' OUT / 2017

    Public Sorteios As Integer
    Public NumLeft As Integer
    Public Cartela As Integer

    Public Numeros(74) As Integer
    Public Tempos(74) As Integer
    Public Delay As Integer
    Public MinDelay As Integer

    Public ModoManual As Boolean
    Public SelecionaNovaCartela As Boolean
    Public TocaBeep As Boolean

    Public LastSort As Date
    Public InicioCartela As Date

    Public ImpListbox As Object
    '------------------------------------------------

    ' Carga do form
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cartela = 0
        MinDelay = 5
        ModoManual = False
        SelecionaNovaCartela = False
        TocaBeep = False
        LastSort = Now

        ' Atualiza janela para tamanho padrão
        Me.Width = 800
        Me.Height = 600
        Me.Update()

        LerCartelas()
        AtualizaCartela(False)
        PreencheNumeros()
        TableLayoutPanelTotal.Visible = False

    End Sub

    'Atualiza o nome da cartela para apresentção
    ' Modo : True = Avança / False = retrocede
    Public Sub AtualizaCartela(ByVal Modo As Integer)

        If Modo Then
            Cartela = Cartela + 1
            If Cartela > ListBox1.Items.Count - 1 Then Cartela = ListBox1.Items.Count - 1
        Else
            Cartela = Cartela - 1
            If Cartela < 0 Then Cartela = 0
        End If

        LabelCartela.Text = UCase(ListBox1.Items.Item(Cartela).ToString)
        InicioCartela = Now
        Me.Update()

    End Sub

    'Preenche numeros a serem sorteados
    Public Sub PreencheNumeros()
        Dim Indice As Integer, Nome As String

        TableLayoutPanelTotal.Visible = False

        ' Ajuste Inicial de variaveis
        Sorteios = 0
        lblLinha0.Tag = 0 : lblLinha1.Tag = 0 : lblLinha2.Tag = 0 : lblLinha3.Tag = 0 : lblLinha4.Tag = 0
        CheckBoxSorteio.Enabled = True
        InicioCartela = Now
        LastSort = Now

        ' Limpa obj auxiliares 
        TextBoxListaNumeros.Text = ""  ' limpa resumo dos numeros
        TextBoxListaSorteio.Text = "" ' limpa sorteios

        ' Zera objetos auxiliares
        TxtLista.Text = ""
        LabelNumero.Text = ""
        LabelLetra.Text = ""
        TxtLista.Tag = "  " & vbCrLf

        NumLeft = 74

        For Indice = 0 To NumLeft
            Numeros(Indice) = Indice + 1
        Next

        For Indice = 0 To NumLeft
            Tempos(Indice) = 0
        Next

        ListaNumeros()
        Embaralhar()

        'zera marcação na cartela
        ModoManual = IIf(CheckBoxSorteio.Checked, True, False)

        For Indice = 1 To 75
            Nome = "Num" & Indice
            TableLayoutPanelNumeros.Controls.Find(Nome, True)(0).BackColor = Color.LightGray
            TableLayoutPanelNumeros.Controls.Find(Nome, True)(0).ForeColor = IIf(ModoManual, Color.Gray, Color.LightGray)
            TableLayoutPanelNumeros.Controls.Find(Nome, True)(0).Tag = 0
        Next

        'Caixas BINGO
        lblLinha0.BackColor = Color.LightGray
        lblLinha1.BackColor = Color.LightGray
        lblLinha2.BackColor = Color.LightGray
        lblLinha3.BackColor = Color.LightGray
        lblLinha4.BackColor = Color.LightGray

        'Atualiza linha de status
        LabelStatus.Text = "Sairam " & Sorteios & " números / faltam " & NumLeft + 1 & " números"

    End Sub

    ' Descarrega Resumo do bingo
    Public Sub DescarregaResumoBingo()
        'Dim Delay As Integer

        If TextBoxListaSorteio.TextLength > 0 Then

            Delay = DateDiff(DateInterval.Second, InicioCartela, LastSort)

            AddLog("Resumo da cartela : " & LabelCartela.Text & vbCrLf)

            AddLog("Tempos")
            AddLog("Inicio da cartela ......... : " & Format(InicioCartela, "dd-MM-yyyy HH:mm:sss"))
            AddLog("Término da cartela ........ : " & Format(LastSort, "dd-MM-yyyy HH:mm:sss"))
            AddLog("Tempo total ............... : " & ConvTempo(Delay))
            AddLog("Intervalos entre sorteios . : " & ListaTempos())

            AddLog(vbCrLf & "Sorteios" & IIf(ModoManual, " pelo modo manual", " efetuados pelo computador"))
            AddLog("Sorteados " & Sorteios & " números - restaram " & NumLeft + 1 & " números")
            AddLog(TextBoxListaSorteio.Text)

            If Not ModoManual Then
                AddLog("Números válidos para sorteios")
                AddLog(TextBoxListaNumeros.Text)
            End If

        End If

        PreencheNumeros()

    End Sub

    ' Sorteio pelo computador
    Public Sub Sorteio()
        Dim Indice As Integer, Numero As Integer, Letra As String, Delay As Integer, Linha As Integer

        If ModoManual Then Exit Sub ' Modo de operação já foi selecionado como manual

        If Sorteios = 0 Then
            Delay = 0 ' Ajuste para feito de estatisticas
            CheckBoxSorteio.Enabled = False
            InicioCartela = Now 'Inicio efetivo da cartela com o primeiro sorteio
        Else
            Delay = DateDiff(DateInterval.Second, LastSort, Now)
            If Delay < MinDelay Then Exit Sub ' Previve o acionamento em tempo muito curto para o sorteio
        End If

        LastSort = Now ' Ajusta tempo do ultimo sorteio para evitar sorteios seguidos por efeito de repetição de teclado ou dispositivos

        If NumLeft = -1 Then Exit Sub

        Randomize()
        Indice = CInt(Int((NumLeft * Rnd())))
        Letra = "X"
        Numero = Numeros(Indice)

        Select Case Numero
            Case 1 To 15 : Letra = "B" : Linha = 0 : lblLinha0.Tag = lblLinha0.Tag + 1
            Case 16 To 30 : Letra = "I" : Linha = 1 : lblLinha1.Tag = lblLinha1.Tag + 1
            Case 31 To 45 : Letra = "N" : Linha = 2 : lblLinha2.Tag = lblLinha2.Tag + 1
            Case 46 To 60 : Letra = "G" : Linha = 3 : lblLinha3.Tag = lblLinha3.Tag + 1
            Case 61 To 75 : Letra = "O" : Linha = 4 : lblLinha4.Tag = lblLinha4.Tag + 1
        End Select

        'Retira o numero do array de números disponiveis
        If Indice = NumLeft Then
            Numeros(Indice) = 0
        Else
            Numeros(Indice) = Numeros(NumLeft)
            Numeros(NumLeft) = 0
        End If

        ' Armazena dados para o resumo
        TextBoxListaSorteio.Text = TextBoxListaSorteio.Text & _
        "Sorteio " & Format(Sorteios + 1, "00 - ") & _
        " Numero " & Format(Numero, "00") & _
        " - Indice " & Format(Indice + 1, "00") & _
        " - Hora " & Format(Now, "HH:mm:sss") & _
        " - Delay de " & ConvTempo(Delay) & vbCrLf

        Tempos(Sorteios) = Delay

        ' Display
        LabelNumero.Text = Numero
        LabelLetra.Text = Letra
        '
        TxtLista.Text = TxtLista.Tag & TxtLista.Text
        TxtLista.Tag = Letra & " " & Format(Numero, "00") & vbCrLf
        '
        Sorteios = Sorteios + 1
        NumLeft = NumLeft - 1

        MarcarNumero(Numero)
        MarcarLinha(Linha)
        Embaralhar()

        'Atualiza linha de status
        LabelStatus.Text = "Sairam " & Sorteios & " números / faltam " & NumLeft + 1 & " números"

        Timer1.Enabled = True

        Me.Focus()

    End Sub

    ' Marca numero por sorteio manual
    Private Sub Num_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num9.Click, Num8.Click, Num75.Click, Num74.Click, Num73.Click, Num72.Click, Num71.Click, Num70.Click, Num7.Click, Num69.Click, Num68.Click, Num67.Click, Num66.Click, Num65.Click, Num64.Click, Num63.Click, Num62.Click, Num61.Click, Num60.Click, Num6.Click, Num59.Click, Num58.Click, Num57.Click, Num56.Click, Num55.Click, Num54.Click, Num53.Click, Num52.Click, Num51.Click, Num50.Click, Num5.Click, Num49.Click, Num48.Click, Num47.Click, Num46.Click, Num45.Click, Num44.Click, Num43.Click, Num42.Click, Num41.Click, Num40.Click, Num4.Click, Num39.Click, Num38.Click, Num37.Click, Num36.Click, Num35.Click, Num34.Click, Num33.Click, Num32.Click, Num31.Click, Num30.Click, Num3.Click, Num29.Click, Num28.Click, Num27.Click, Num26.Click, Num25.Click, Num24.Click, Num23.Click, Num22.Click, Num21.Click, Num20.Click, Num2.Click, Num19.Click, Num18.Click, Num17.Click, Num16.Click, Num15.Click, Num14.Click, Num13.Click, Num12.Click, Num11.Click, Num10.Click, Num1.Click
        Dim Obj As Label, Numero As Integer, Letra As String, Linha As Integer
        Dim Delay As Integer

        If ModoManual = False Then Exit Sub ' Modo de operação já foi selecionado como automatico

        If Sorteios = 0 Then
            Delay = 0 ' Ajuste para feito de estatisticas
            CheckBoxSorteio.Enabled = False
            InicioCartela = Now 'Inicio efetivo da cartela com o primeiro sorteio
        End If

        Delay = DateDiff(DateInterval.Second, LastSort, Now)
        If Delay < MinDelay Then Exit Sub ' Previve o acionamento em tempo muito curto para o sorteio
        LastSort = Now ' Ajusta tempo do ultimo sorteio para evitar sorteios seguidos por efeito de repetição de teclado ou dispositivos

        Obj = sender
        If Obj.Tag = 1 Then Exit Sub 'Numero já foi sorteado / marcado
        Obj.Tag = 1  ' marca como seortado

        Letra = "X"
        Numero = Int(Obj.Text)

        Select Case Numero
            Case 1 To 15 : Letra = "B" : Linha = 0 : lblLinha0.Tag = lblLinha0.Tag + 1
            Case 16 To 30 : Letra = "I" : Linha = 1 : lblLinha1.Tag = lblLinha1.Tag + 1
            Case 31 To 45 : Letra = "N" : Linha = 2 : lblLinha2.Tag = lblLinha2.Tag + 1
            Case 46 To 60 : Letra = "G" : Linha = 3 : lblLinha3.Tag = lblLinha3.Tag + 1
            Case 61 To 75 : Letra = "O" : Linha = 4 : lblLinha4.Tag = lblLinha4.Tag + 1
        End Select

        ' Armazena dados para o resumo
        TextBoxListaSorteio.Text = TextBoxListaSorteio.Text & _
        "Sorteio " & Format(Sorteios + 1, "00 - ") & _
        " Numero " & Format(Numero, "00") & _
        " - Hora " & Format(Now, "HH:mm:sss") & _
        " - Delay de " & ConvTempo(Delay) & vbCrLf

        Tempos(Sorteios) = Delay

        ' Display
        LabelNumero.Text = Numero
        LabelLetra.Text = Letra

        TxtLista.Text = TxtLista.Tag & TxtLista.Text
        TxtLista.Tag = Letra & " " & Format(Numero, "00") & vbCrLf
        '
        Sorteios = Sorteios + 1
        NumLeft = NumLeft - 1

        MarcarNumero(Numero)
        MarcarLinha(Linha)

        'Atualiza linha de status
        LabelStatus.Text = "Sairam " & Sorteios & " números / faltam " & NumLeft + 1 & " números"
        Timer1.Enabled = True

    End Sub

    ' Embaralhar
    Public Sub Embaralhar()
        Dim A As Integer, Tmp As Integer, Indice As Integer

        For A = 0 To NumLeft
            Randomize()
            Indice = (NumLeft * Rnd())  ' Pega um numero aleatorio
            Tmp = Numeros(A)
            Numeros(A) = Numeros(Indice)
            Numeros(Indice) = Tmp
        Next

        ListaNumeros()

    End Sub

    ' Debug Lista de tempos de sorteio
    Public Function ListaTempos() As String
        Dim Min As Integer, Max As Integer, Qtde As Integer, Total As Integer

        If Sorteios < 2 Then
            ListaTempos = "Mínimo=" & Tempos(0) & "sec. Max=" & Tempos(0) & "sec. Media=" & Tempos(0) & "sec."
            Exit Function
        End If

        Min = 1000 : Max = 0 : Qtde = 0 : Total = 0

        ' Calcula os tempos
        For A = 1 To Sorteios - 1   ' despreza o primeiro sorteio 
            If Tempos(A) <= Min Then Min = Tempos(A)
            If Tempos(A) >= Max Then Max = Tempos(A)
            Total = Total + Tempos(A)
            Qtde = Qtde + 1
        Next

        ListaTempos = "Mínimo=" & Min & " sec. Max=" & Max & " sec. Media=" & Int(Total / Qtde) & " sec."

    End Function

    ' Debug Lista de numeros para sorteio
    Public Sub ListaNumeros()
        Dim Texto As String

        ' Descrarrega Array de Números
        Texto = Format(Sorteios + 1, "00-|")
        For A = 0 To NumLeft
            Texto = Texto & Format(Numeros(A), "00") & "|"
        Next

        TextBoxListaNumeros.Text = TextBoxListaNumeros.Text & Texto & vbCrLf

    End Sub

    ' Marcar Numero sorteado manualmente
    Public Sub MarcarNumero(ByVal Numero As Integer)
        Dim Nome As String

        Nome = "Num" & Numero

        TableLayoutPanelNumeros.Controls.Find(Nome, True)(0).BackColor = Color.Red
        TableLayoutPanelNumeros.Controls.Find(Nome, True)(0).ForeColor = Color.Black

    End Sub

    ' Marcar linha  
    Public Sub MarcarLinha(ByVal Linha As Integer)
        Dim Nome As String

        Select Case Linha
            Case 0 'B
                If lblLinha0.Tag = 15 Then
                    lblLinha0.BackColor = Color.Red
                    'For Indice = 1 To 15
                    '    Nome = "Num" & Indice
                    '    TableLayoutPanelNumeros.Controls.Find(Nome, True)(0).BackColor = Color.Lime
                    'Next
                End If

            Case 1 'I
                If lblLinha1.Tag = 15 Then
                    lblLinha1.BackColor = Color.Red
                    'For Indice = 16 To 30
                    '    Nome = "Num" & Indice
                    '    TableLayoutPanelNumeros.Controls.Find(Nome, True)(0).BackColor = Color.Lime
                    'Next
                End If

            Case 2  'N
                If lblLinha2.Tag = 15 Then
                    lblLinha2.BackColor = Color.Red
                    'For Indice = 31 To 45
                    '    Nome = "Num" & Indice
                    '    TableLayoutPanelNumeros.Controls.Find(Nome, True)(0).BackColor = Color.Lime
                    'Next
                End If

            Case 3 'G
                If lblLinha3.Tag = 15 Then
                    lblLinha3.BackColor = Color.Red
                    'For Indice = 46 To 60
                    '    Nome = "Num" & Indice
                    '    TableLayoutPanelNumeros.Controls.Find(Nome, True)(0).BackColor = Color.Lime
                    'Next
                End If

            Case 4 'O
                If lblLinha4.Tag = 15 Then
                    lblLinha4.BackColor = Color.Red
                    'For Indice = 61 To 75
                    '    Nome = "Num" & Indice
                    '    TableLayoutPanelNumeros.Controls.Find(Nome, True)(0).BackColor = Color.Lime
                    'Next
                End If

        End Select

    End Sub

    ' Chaveador para reiniciar jogo
    ' Modo 1=Liga aviso ,  2=Desliga aviso,  3=Reinicia jogo
    Public Sub IniciaNovaRodada(ByVal Modo As Integer)

        Select Case Modo
            Case 1  ' Liga aviso para reinicio
                SelecionaNovaCartela = True
                frmNovaCartela.ShowDialog()

            Case 2  ' Apenas desliga aviso
                SelecionaNovaCartela = False

            Case 3  ' Reinicia jogo
                DescarregaResumoBingo()
                AtualizaCartela(True)
                SelecionaNovaCartela = False

        End Select

    End Sub

    'Leitura do arquivo com a lista de cartelas posiveis
    'que deve estar no dietorio corrente do aplicativo
    'ou carrega lista defaut de 20 cartelas
    Public Sub LerCartelas()
        Dim Arquivo As String, itens As Object, A As Integer

        Arquivo = System.Environment.CurrentDirectory & "\Cartelas.txt"

        If Dir(Arquivo) = "" Then
            ''O arquivo NÃO existe 
            ' Inclui 20 cartelas padrão
            For A = 1 To 20
                ListBox1.Items.Add("Cartela " & A)
            Next

        Else
            ListBox1.Items.Clear()
            itens = (My.Computer.FileSystem.ReadAllText(Arquivo, System.Text.Encoding.Default)).Replace(vbLf, String.Empty).Split((CChar(vbCr)))
            ListBox1.Items.AddRange(itens)
        End If

    End Sub

    ' Cria log dos sorteios
    Public Sub AddLog(ByVal Texto As String)
        Dim ArqLog As String

        ArqLog = System.Environment.CurrentDirectory & "\LogBingo_" & Format(Now, "ddMM_HHmm") & ".txt"
        Texto = Texto & vbCrLf

        My.Computer.FileSystem.WriteAllText(ArqLog, Texto, True)

    End Sub

    ' Conversão de tempo em texto
    Public Function ConvTempo(ByVal Sec As Integer) As String
        Dim Texto As String, Res As Integer

        If Sec < 60 Then
            Texto = Sec & " sec."
        Else
            Res = Int(Sec / 60)
            Texto = Res & " min e " & (Sec - (Res * 60)) & " sec."
        End If

        Return Texto

    End Function

    'Captura tecla do controle depresentação
    'A tecla do controle ptt show fim lança os coigo 16,27 e 166 
    Public Sub frmDsk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Debug.Print(e.KeyCode)

        'If PanelSplash.Visible Then
        '    PanelSplash.Visible = False
        '    Exit Sub
        'End If

        Select Case e.KeyCode
            Case 27
                'vbKeyShift  16 SHIFT key  
                'vbKeyEscape 27 ESC key 
                'vbKeyF5 116 F5 key 
                If Sorteios > 0 Then
                    IniciaNovaRodada(1) 'Liga opção de reiniciar novo jogo
                End If

            Case 66
                'vbKeyB 66 B key 
                If SelecionaNovaCartela Then
                    IniciaNovaRodada(2)  'Desliga aviso de nova cartela
                Else
                    If TableLayoutPanelTotal.Visible = False Then
                        TableLayoutPanelTotal.Visible = True
                        Exit Sub
                    End If

                    Sorteio()

                End If

            Case 33
                'vbKeyPageUp 33 PAGE UP key 
                If SelecionaNovaCartela Then
                    IniciaNovaRodada(2)  'Desliga aviso de nova cartela
                    Exit Sub
                Else
                    If Sorteios = 0 Then
                        AtualizaCartela(False)
                        Exit Sub
                    Else
                        ' Abre painel de disputa
                        frmDisputa.ShowDialog()
                    End If
                End If

            Case 34
                'vbKeyPageDown 34 PAGE DOWN key 
                If SelecionaNovaCartela Then
                    IniciaNovaRodada(3) ' Inicia nova rodada 
                Else
                    If Sorteios = 0 Then
                        AtualizaCartela(True)
                    Else
                        TocaBeep = IIf(TocaBeep, False, True)
                    End If

                End If

            Case 112
                'vbKeyF1 - Help
                frmHelp.ShowDialog()

            Case Else
                If SelecionaNovaCartela Then IniciaNovaRodada(2) ' Desliga aviso de nova cartela

        End Select

    End Sub

    ' Altera modo se sorteio
    Private Sub CheckBoxSorteio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSorteio.CheckedChanged

        PreencheNumeros()

    End Sub

    ' Timer pisca pisca
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Dim Delay As Integer = 0

        LabelLetra.BackColor = IIf(LabelLetra.BackColor = Color.Blue, Color.Red, Color.Blue)
        LabelLetra.ForeColor = IIf(LabelLetra.BackColor = Color.Red, Color.Black, Color.White)
        LabelNumero.BackColor = LabelLetra.BackColor
        LabelNumero.ForeColor = LabelLetra.ForeColor

        Delay = DateDiff(DateInterval.Second, LastSort, Now)

        If Delay > MinDelay Then
            Timer1.Enabled = False
            LabelLetra.BackColor = Color.Lime
            LabelNumero.BackColor = LabelLetra.BackColor
            LabelLetra.ForeColor = Color.Black
            LabelNumero.ForeColor = LabelLetra.ForeColor
            Exit Sub
        End If

    End Sub

    ' Ajusta tamanho da fonte de TxtLista
    Private Sub Label1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        Dim Valor As Integer = 0

        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                If (Control.ModifierKeys And Keys.Shift) <> Keys.None Then
                    AjustaFonte2(1)
                Else
                    AjustaFonte2(10)
                End If

            Case Windows.Forms.MouseButtons.Right
                If (Control.ModifierKeys And Keys.Shift) <> Keys.None Then
                    AjustaFonte2(-1)
                Else
                    AjustaFonte2(-10)
                End If
        End Select

    End Sub

    ' Ajusta tamanho da fonte de LabelNumero e Label Letra 
    Private Sub Label2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                If (Control.ModifierKeys And Keys.Shift) <> Keys.None Then
                    AjustaFonte1(1)
                Else
                    AjustaFonte1(10)
                End If
            Case Windows.Forms.MouseButtons.Right
                If (Control.ModifierKeys And Keys.Shift) <> Keys.None Then
                    AjustaFonte1(-1)
                Else
                    AjustaFonte1(-10)
                End If
        End Select
    End Sub

    ' Ajusta tamanho da fonte de mostrador de resultaldos
    Private Sub Label3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseDown
        Select Case e.Button

            Case Windows.Forms.MouseButtons.Left
                If (Control.ModifierKeys And Keys.Shift) <> Keys.None Then
                    AjustaFonte3(1)
                Else
                    AjustaFonte3(10)
                End If

            Case Windows.Forms.MouseButtons.Right
                If (Control.ModifierKeys And Keys.Shift) <> Keys.None Then
                    AjustaFonte3(-1)
                Else
                    AjustaFonte3(-10)
                End If

        End Select
    End Sub

    'Ajusta tamanho da fonte de LabelNumero e Label Letra
    Private Sub AjustaFonte1(ByVal Valor As Integer)
        Dim Tam1 As Integer

        Tam1 = LabelNumero.Font.Size
        Tam1 = Tam1 + Valor

        LabelNumero.Font = New Font(LabelNumero.Font.FontFamily, Tam1)
        LabelLetra.Font = New Font(LabelLetra.Font.FontFamily, Tam1)

    End Sub

    'Ajusta tamanho da fonte de TxtLista
    Private Sub AjustaFonte2(ByVal Valor As Integer)
        Dim Tam As Integer

        Tam = TxtLista.Font.Size
        Tam = Tam + Valor

        TxtLista.Font = New Font(TxtLista.Font.FontFamily, Tam)
    End Sub

    'Ajusta tamanho da fonte de Lista Sorteados
    Private Sub AjustaFonte3(ByVal Valor As Integer)
        Dim Tam As Integer, Nome As String, lblObj As Label

        Tam = Num1.Font.Size
        Tam = Tam + Valor

        For Indice = 1 To 75
            Nome = "Num" & Indice
            lblObj = TableLayoutPanelNumeros.Controls.Find(Nome, True)(0)
            lblObj.Font = New Font(lblObj.Font.FontFamily, Tam)
        Next


        lblLinha0.Font = New Font(lblLinha0.Font.FontFamily, Tam)
        lblLinha1.Font = New Font(lblLinha0.Font.FontFamily, Tam)
        lblLinha2.Font = New Font(lblLinha0.Font.FontFamily, Tam)
        lblLinha3.Font = New Font(lblLinha0.Font.FontFamily, Tam)
        lblLinha4.Font = New Font(lblLinha0.Font.FontFamily, Tam)

    End Sub

End Class
