Public Class Professor
    'Private para que ele não possa ser acessado por uma classe que não seja dele
    Inherits Pessoa

    Private nome1 As String
    Private v As String

    Public Sub New(nome As String)
        Me.nome1 = nome1
    End Sub

    Public Sub New(nome As String, v As String)
        Me.New(nome)
        Me.v = v
    End Sub

    Public Property PNome1 As String
        Get
            Return nome1
        End Get
        Set(value As String)
            nome1 = value
        End Set
    End Property

    Public Property pTitulo As String
End Class
