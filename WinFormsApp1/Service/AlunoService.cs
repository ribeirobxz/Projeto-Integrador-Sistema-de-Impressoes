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
        private readonly AlunoRepository _alunoRepository;

        public AlunoService(AlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public bool AdicionarAluno(Aluno aluno)
        {
            try
            {
               return _alunoRepository.AdicionarAluno(aluno);
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
               return _alunoRepository.AtualizarAluno(aluno);
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
               return _alunoRepository.DeletarAluno(Codigo).deletado;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Aluno? SelecionarAlunoPorCodigo(int codigo) 
        {
            // a fazer
            Aluno aluno = null;
            if (aluno == null)
            {
                return null;
            }

            return aluno;
        }

        public Aluno? SelecionarAlunoPorNome(string nome)
        {
            // a fazer
            Aluno aluno = null;
            if (aluno == null)
            {
                return null;
            }

            return aluno;
        }

    }
}
