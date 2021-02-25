Imports ByteBank.Classes

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Projeto ByteBank"
        Lbl_Principal.Text = "Projeto ByteBank"
    End Sub

    Private Sub Vídeo01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo01ToolStripMenuItem.Click
        Dim conta As New ContaCorrente(4009, 481235)
        MsgBox("o número de contas correntes criadas são de " + ContaCorrente.TotalDeContasCriadas.ToString)
        MsgBox("o valor total das taxas de operação é de " + ContaCorrente.TaxaOperacao.ToString)
    End Sub
End Class
