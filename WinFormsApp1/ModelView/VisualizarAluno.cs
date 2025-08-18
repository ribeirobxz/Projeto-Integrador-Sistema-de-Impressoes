using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.ModelView
{
    internal class VisualizarAluno
    {
        public Alunos aluno { get; private init; }

        public VisualizarAluno(Alunos aluno)
        {
            this.aluno = aluno;
        }

        public override string ToString()
        {
            return $"Nome: {aluno.Nome} - Saldo: {aluno.QntdImpressao}";
        }
    }
}
