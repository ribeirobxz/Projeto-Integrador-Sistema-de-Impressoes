using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Context;
using WinFormsApp1.Model;

namespace WinFormsApp1.Service
{
    internal class AlunoService
    {
        private readonly RepositoryContext _repositoryContext;

        public AlunoService(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public bool AdicionarAluno(Aluno aluno)
        {
            try
            {
               return _repositoryContext.AlunoRepository.AdicionarAluno(aluno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EditarAluno(Aluno aluno)
        {
            try
            {
               return  _repositoryContext.AlunoRepository.AtualizarAluno(aluno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeletarAluno(int Codigo) 
        {
            try
            {
               return _repositoryContext.AlunoRepository.DeletarAluno(Codigo).deletado;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Aluno? SelecionarAlunoPorCodigo(int codigo) 
        {
            Aluno aluno = null;
            if (aluno == null)
            {
                return null;
            }

            return aluno;
        }

        public Aluno? SelecionarAlunoPorNome(string nome)
        {
            Aluno aluno = null;
            if (aluno == null)
            {
                return null;
            }

            return aluno;
        }

    }
}
