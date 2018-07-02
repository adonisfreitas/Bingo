<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDownTempo = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LabelSorteados = New System.Windows.Forms.Label
        Me.ButtonPlay = New System.Windows.Forms.Button
        Me.LabelFaltam = New System.Windows.Forms.Label
        Me.ButtonPause = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LabelLetra = New System.Windows.Forms.Label
        Me.LabelNumero = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ReiniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LabelCartela = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.NumericUpDownTempo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(29, 171)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 85)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Sortear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3
        '
        'NumericUpDownTempo
        '
        Me.NumericUpDownTempo.BackColor = System.Drawing.Color.White
        Me.NumericUpDownTempo.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownTempo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.NumericUpDownTempo.Location = New System.Drawing.Point(87, 59)
        Me.NumericUpDownTempo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NumericUpDownTempo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownTempo.Name = "NumericUpDownTempo"
        Me.NumericUpDownTempo.Size = New System.Drawing.Size(67, 23)
        Me.NumericUpDownTempo.TabIndex = 87
        Me.NumericUpDownTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownTempo.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Segundos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LabelSorteados)
        Me.GroupBox1.Controls.Add(Me.ButtonPlay)
        Me.GroupBox1.Controls.Add(Me.LabelFaltam)
        Me.GroupBox1.Controls.Add(Me.ButtonPause)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownTempo)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 250)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(284, 276)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Sorteio "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Timer de "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(205, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "números"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Faltam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Sorteio nº"
        '
        'LabelSorteados
        '
        Me.LabelSorteados.AutoSize = True
        Me.LabelSorteados.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSorteados.Location = New System.Drawing.Point(73, 31)
        Me.LabelSorteados.Name = "LabelSorteados"
        Me.LabelSorteados.Size = New System.Drawing.Size(22, 17)
        Me.LabelSorteados.TabIndex = 85
        Me.LabelSorteados.Text = "00"
        Me.LabelSorteados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonPlay
        '
        Me.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPlay.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlay.ForeColor = System.Drawing.Color.Black
        Me.ButtonPlay.Location = New System.Drawing.Point(152, 101)
        Me.ButtonPlay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(95, 51)
        Me.ButtonPlay.TabIndex = 90
        Me.ButtonPlay.Text = "Auto   >"
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'LabelFaltam
        '
        Me.LabelFaltam.AutoSize = True
        Me.LabelFaltam.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFaltam.Location = New System.Drawing.Point(176, 31)
        Me.LabelFaltam.Name = "LabelFaltam"
        Me.LabelFaltam.Size = New System.Drawing.Size(22, 17)
        Me.LabelFaltam.TabIndex = 86
        Me.LabelFaltam.Text = "00"
        Me.LabelFaltam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonPause
        '
        Me.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPause.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPause.Location = New System.Drawing.Point(29, 101)
        Me.ButtonPause.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(95, 51)
        Me.ButtonPause.TabIndex = 89
        Me.ButtonPause.Text = "Pausa ||"
        Me.ButtonPause.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelLetra)
        Me.Panel1.Controls.Add(Me.LabelNumero)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(13, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 151)
        Me.Panel1.TabIndex = 90
        '
        'LabelLetra
        '
        Me.LabelLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelLetra.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLetra.Location = New System.Drawing.Point(13, 15)
        Me.LabelLetra.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelLetra.Name = "LabelLetra"
        Me.LabelLetra.Size = New System.Drawing.Size(91, 115)
        Me.LabelLetra.TabIndex = 1
        Me.LabelLetra.Text = "B"
        Me.LabelLetra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelNumero
        '
        Me.LabelNumero.BackColor = System.Drawing.Color.Yellow
        Me.LabelNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelNumero.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumero.Location = New System.Drawing.Point(107, 15)
        Me.LabelNumero.Name = "LabelNumero"
        Me.LabelNumero.Size = New System.Drawing.Size(160, 115)
        Me.LabelNumero.TabIndex = 0
        Me.LabelNumero.Text = "99"
        Me.LabelNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ListBox1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 33
        Me.ListBox1.Items.AddRange(New Object() {"X 99"})
        Me.ListBox1.Location = New System.Drawing.Point(317, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(102, 499)
        Me.ListBox1.TabIndex = 91
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReiniciarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(454, 24)
        Me.MenuStrip1.TabIndex = 92
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReiniciarToolStripMenuItem
        '
        Me.ReiniciarToolStripMenuItem.Name = "ReiniciarToolStripMenuItem"
        Me.ReiniciarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ReiniciarToolStripMenuItem.Text = "Reiniciar"
        '
        'LabelCartela
        '
        Me.LabelCartela.BackColor = System.Drawing.Color.Red
        Me.LabelCartela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelCartela.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCartela.ForeColor = System.Drawing.Color.Yellow
        Me.LabelCartela.Location = New System.Drawing.Point(86, 195)
        Me.LabelCartela.Name = "LabelCartela"
        Me.LabelCartela.Size = New System.Drawing.Size(78, 37)
        Me.LabelCartela.TabIndex = 93
        Me.LabelCartela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Cartela"
        '
        'frmControle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 550)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelCartela)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Cooper Std Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmControle"
        Me.Text = "ControleRemoto"
        CType(Me.NumericUpDownTempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NumericUpDownTempo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonPlay As System.Windows.Forms.Button
    Friend WithEvents ButtonPause As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelLetra As System.Windows.Forms.Label
    Friend WithEvents LabelNumero As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ReiniciarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelSorteados As System.Windows.Forms.Label
    Friend WithEvents LabelFaltam As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelCartela As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
