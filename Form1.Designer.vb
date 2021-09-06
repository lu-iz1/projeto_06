<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbNomeAluno = New System.Windows.Forms.TextBox()
        Me.txbRgmAluno = New System.Windows.Forms.TextBox()
        Me.btnExibirAluno = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbTituloProfessor = New System.Windows.Forms.TextBox()
        Me.txbNomeProfessor = New System.Windows.Forms.TextBox()
        Me.btnExibirProfessor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aluno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RGM:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome:"
        '
        'txbNomeAluno
        '
        Me.txbNomeAluno.Location = New System.Drawing.Point(161, 149)
        Me.txbNomeAluno.Name = "txbNomeAluno"
        Me.txbNomeAluno.Size = New System.Drawing.Size(293, 20)
        Me.txbNomeAluno.TabIndex = 3
        '
        'txbRgmAluno
        '
        Me.txbRgmAluno.Location = New System.Drawing.Point(161, 118)
        Me.txbRgmAluno.Name = "txbRgmAluno"
        Me.txbRgmAluno.Size = New System.Drawing.Size(119, 20)
        Me.txbRgmAluno.TabIndex = 4
        '
        'btnExibirAluno
        '
        Me.btnExibirAluno.Location = New System.Drawing.Point(311, 116)
        Me.btnExibirAluno.Name = "btnExibirAluno"
        Me.btnExibirAluno.Size = New System.Drawing.Size(116, 23)
        Me.btnExibirAluno.TabIndex = 5
        Me.btnExibirAluno.Text = "Exibir"
        Me.btnExibirAluno.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(218, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 33)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Professor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Título:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nome:"
        '
        'txbTituloProfessor
        '
        Me.txbTituloProfessor.Location = New System.Drawing.Point(161, 247)
        Me.txbTituloProfessor.Name = "txbTituloProfessor"
        Me.txbTituloProfessor.Size = New System.Drawing.Size(119, 20)
        Me.txbTituloProfessor.TabIndex = 9
        '
        'txbNomeProfessor
        '
        Me.txbNomeProfessor.Location = New System.Drawing.Point(161, 284)
        Me.txbNomeProfessor.Name = "txbNomeProfessor"
        Me.txbNomeProfessor.Size = New System.Drawing.Size(293, 20)
        Me.txbNomeProfessor.TabIndex = 10
        '
        'btnExibirProfessor
        '
        Me.btnExibirProfessor.Location = New System.Drawing.Point(311, 244)
        Me.btnExibirProfessor.Name = "btnExibirProfessor"
        Me.btnExibirProfessor.Size = New System.Drawing.Size(116, 23)
        Me.btnExibirProfessor.TabIndex = 11
        Me.btnExibirProfessor.Text = "Exibir"
        Me.btnExibirProfessor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExibirProfessor)
        Me.Controls.Add(Me.txbNomeProfessor)
        Me.Controls.Add(Me.txbTituloProfessor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExibirAluno)
        Me.Controls.Add(Me.txbRgmAluno)
        Me.Controls.Add(Me.txbNomeAluno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sistema Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txbNomeAluno As TextBox
    Friend WithEvents txbRgmAluno As TextBox
    Friend WithEvents btnExibirAluno As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txbTituloProfessor As TextBox
    Friend WithEvents txbNomeProfessor As TextBox
    Friend WithEvents btnExibirProfessor As Button
End Class
