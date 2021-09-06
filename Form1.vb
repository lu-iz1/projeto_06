Public Class Form1
    Private Sub btnExibirAluno_Click(sender As Object, e As EventArgs) Handles btnExibirAluno.Click
        Dim obj_aluno As New Aluno("Luiz Eduardo", "23362065")
        txbNomeAluno.Text = obj_aluno.PNome
        txbRgmAluno.Text = obj_aluno.pRgm
    End Sub

    Private Sub txbRgmAluno_TextChanged(sender As Object, e As EventArgs) Handles txbRgmAluno.TextChanged

    End Sub

    Private Sub txbTituloProfessor_TextChanged(sender As Object, e As EventArgs) Handles txbTituloProfessor.TextChanged

    End Sub

    Private Sub btnExibirProfessor_Click(sender As Object, e As EventArgs) Handles btnExibirProfessor.Click
        Dim obj_professor As New Professor("Professor", "87654321")
        txbNomeProfessor.Text = obj_professor.PNome1
        txbTituloProfessor.Text = obj_professor.pTitulo
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
