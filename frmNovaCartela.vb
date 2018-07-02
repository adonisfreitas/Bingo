Public NotInheritable Class frmNovaCartela

    Private Sub frmNovaCartela_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Debug.Print(e.KeyCode)

        Select Case e.KeyCode

            Case 34
                'vbKeyPageDown 34 PAGE DOWN key 
                frmDsk.IniciaNovaRodada(3)
                frmDsk.Focus()
                Me.Close()

            Case Else
                frmDsk.Focus()
                Me.Close()
        End Select
    End Sub

    Private Sub frmNovaCartela_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick

        frmDsk.Focus()
        Me.Close()

    End Sub


End Class
