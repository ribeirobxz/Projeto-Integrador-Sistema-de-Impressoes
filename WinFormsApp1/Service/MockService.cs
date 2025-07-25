using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Service
{
    internal class MockService
    {
        private static int alunoIndex = 1;
        private static Dictionary<int, Aluno> TabelaAlunos = new Dictionary<int, Aluno>();

        public bool AdicionarAluno(Aluno aluno) 
        {
            if (TabelaAlunos.Where(x => x.Value.Matricula == aluno.Matricula).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Matricula");
            }

            if (TabelaAlunos.Where(x => x.Value.Nome == aluno.Nome).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Nome");
            }

            if (TabelaAlunos.Where(x => x.Value.Email == aluno.Email).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Email");
            }

            aluno.Codigo = alunoIndex;
            TabelaAlunos.Add(alunoIndex++, aluno);
            return true;
        }

        public bool EditarAluno(Aluno aluno)
        {
            if (!TabelaAlunos.ContainsKey(aluno.Codigo))
            {
                throw new ArgumentException("Não existe EXCEPTION");
            }

            if (TabelaAlunos.Where(x => x.Value.Matricula == aluno.Matricula && x.Value.Codigo != aluno.Codigo).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Matricula");
            }

            if (TabelaAlunos.Where(x => x.Value.Nome == aluno.Nome && x.Value.Codigo != aluno.Codigo).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Nome");
            }

            if (TabelaAlunos.Where(x => x.Value.Email == aluno.Email && x.Value.Codigo != aluno.Codigo).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Email");
            }

            TabelaAlunos[aluno.Codigo] = aluno;
            return true;
        }

        public bool DeletarAluno(Aluno aluno) 
        {
            return TabelaAlunos.Remove(aluno.Codigo);
        }

        public Aluno? SelecionarAlunoPorCodigo(int codigo) 
        {
            if (!TabelaAlunos.ContainsKey(codigo))
            {
                return null;
            }

            return TabelaAlunos[codigo];
        }

        public Aluno? SelecionarAlunoPorNome(string nome)
        {
            return TabelaAlunos.Values.Where(x => x.Nome == nome).FirstOrDefault();
        }

    }
}
