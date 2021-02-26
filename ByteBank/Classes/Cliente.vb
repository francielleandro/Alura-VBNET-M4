Namespace Classes
    Public Class Cliente
#Region "Property"

        Private m_cpf As String
        Public Property cpf As String
            Get
                Return m_cpf
            End Get
            Set(value As String)
                m_cpf = value
            End Set
        End Property

        Public Property nome As String

        Public Property profissao As String
    End Class

#End Region
End Namespace

