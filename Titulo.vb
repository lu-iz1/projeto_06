Public Class Titulo
    'Comando que possibilita a classe titulo herdar as características da classe Professor
    Inherits Professor
    Private titulo As String

    Public Sub New(nome1 As String, titulo As String)
        'Como essa classe herda características da classe Pessoa preciso informar na linha de baixo
        MyBase.New(nome1)
        'MyBase informa que essa informação é da classe "PAI"
        Me.titulo = titulo
    End Sub

    Public Property pTitulo As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property
End Class
