Imports ByteBank.Classes

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Projeto ByteBank"
        Lbl_Principal.Text = "Projeto ByteBank"
        Lbl_denominador.Text = "Número denominador"
    End Sub

    Private Sub Vídeo01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo01ToolStripMenuItem.Click
        Dim conta As New ContaCorrente(4009, 481235)
        MsgBox("o número de contas correntes criadas são de " + ContaCorrente.TotalDeContasCriadas.ToString)
        MsgBox("o valor total das taxas de operação é de " + ContaCorrente.TaxaOperacao.ToString)
    End Sub

    Private Sub Vídeo02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo02ToolStripMenuItem.Click
        Dim denominador As Integer = Txt_Denominador.Text
        Dim resposta As Integer = TestarDivisao(denominador)


        If resposta = -1 Then
            MsgBox("Não é possivel fazer a divisão porque o denominador é igual a zero")
        ElseIf resposta = -2 Then
            MsgBox("Não é possivel fazer ad divisão porque o denominador é maior que o numerador")
        Else
            MsgBox("O valor da divisão entre 10 e " + denominador.ToString + " é de " + resposta.ToString)
        End If
    End Sub

    Function TestarDivisao(Valor As Integer) As Integer
        Dim Resultado As Integer = EfetuarDivisao(10, Valor)

        If Resultado = -1 Then
            Return -1
        ElseIf Resultado = -2 Then
            Return -2
        End If
        Return Resultado
    End Function

    Function EfetuarDivisao(numerador As Integer, denominador As Integer) As Integer

        If denominador = 0 Then
            Return -1
        ElseIf denominador > numerador Then
            Return -2
        End If

        Return numerador / denominador
    End Function

    Private Sub Vídeo03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Vídeo03ToolStripMenuItem.Click

    End Sub
End Class
