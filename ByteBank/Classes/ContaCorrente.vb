Namespace Classes

    Public Class ContaCorrente
#Region "Property"

        Public Property titular As Cliente
        Public Property numero As Integer

        Private Shared m_TotalDeContasCriadas As Integer
        Public Shared ReadOnly Property TotalDeContasCriadas As Integer
            Get
                Return m_TotalDeContasCriadas
            End Get
        End Property

        Private m_agencia As Integer
        Public Property agencia As Integer
            Get
                Return m_agencia
            End Get
            Set(value As Integer)
                If value < 0 Then
                    m_agencia = 0
                End If
                m_agencia = value
            End Set
        End Property

        Private m_saldo As Double = 100
        Public Property saldo As Double
            Get
                Return saldo
            End Get
            Set(value As Double)
                If value < 0 Then
                    m_saldo = 0
                End If
                m_saldo = value
            End Set
        End Property


#End Region

#Region "Constructor"
        Public Sub New(_Agencia As Integer, _numero As Integer)
            m_agencia = _Agencia
            numero = _numero
            m_TotalDeContasCriadas += 1
        End Sub
#End Region

#Region "methods"
        Public Function Sacar(ValorSacado As Double) As Boolean
            Dim vRetorno As Boolean

            If m_saldo < ValorSacado Then
                vRetorno = False
            Else
                vRetorno = True
                m_saldo -= ValorSacado
            End If

            Return vRetorno
        End Function

        Public Sub Depositar(ValorDepositar As Double)
            m_saldo += ValorDepositar
        End Sub

        Public Function Transferir(ValorTransferencia As Double, ContaCorrente As ContaCorrente) As Boolean
            Dim vRetorno As Boolean

            If m_saldo < ValorTransferencia Then
                vRetorno = False
            Else
                ContaCorrente.Depositar(ValorTransferencia)
                m_saldo -= ValorTransferencia

                vRetorno = True
            End If

            Return vRetorno
        End Function


#End Region
    End Class
End Namespace
