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
    public class AlunoService
    {
        private readonly AppDatabaseContext _appDatabaseContext;

        public AlunoService(AppDatabaseContext appDatabaseContext)
        {
            _appDatabaseContext = appDatabaseContext;
        }

        public bool AdicionarAluno(Aluno aluno) 
        {
            if (_appDatabaseContext.Alunos.Where(x => x.Matricula == aluno.Matricula).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Matricula");
            }

            if (_appDatabaseContext.Alunos.Where(x => x.Nome == aluno.Nome).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Nome");
            }

            if (_appDatabaseContext.Alunos.Where(x => x.Email == aluno.Email).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Email");
            }

            _appDatabaseContext.Alunos.Add(aluno);
            _appDatabaseContext.SaveChanges();

            return true;
        }

        public bool EditarAluno(Aluno aluno)
        {
            var alunoParaEditar = _appDatabaseContext.Alunos.FirstOrDefault(x => x.Nome == aluno.Nome);
            if (aluno == null)
            {
                throw new ArgumentException("Não existe EXCEPTION");
            }

            if (_appDatabaseContext.Alunos.Where(x => x.Matricula == aluno.Matricula && x.Codigo != aluno.Codigo).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Matricula");
            }

            if (_appDatabaseContext.Alunos.Where(x => x.Nome == aluno.Nome && x.Codigo != aluno.Codigo).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Nome");
            }

            if (_appDatabaseContext.Alunos.Where(x => x.Email == aluno.Email && x.Codigo != aluno.Codigo).Count() > 0)
            {
                throw new ArgumentException("UNIQUE EXCEPTION Email");
            }

            alunoParaEditar.Nome = aluno.Nome;
            alunoParaEditar.Matricula = aluno.Matricula;
            alunoParaEditar.Email = aluno.Email;
            alunoParaEditar.QntdImpressao = aluno.QntdImpressao;

            _appDatabaseContext.SaveChanges();

            return true;
        }

        public bool DeletarAluno(Aluno aluno) 
        {
            _appDatabaseContext.Alunos.Remove(aluno);
            return _appDatabaseContext.SaveChanges() > 0;
        }

        public Aluno? SelecionarAlunoPorCodigo(int codigo) 
        {
            var aluno = _appDatabaseContext.Alunos.FirstOrDefault(x => x.Codigo == codigo);
            if (aluno == null)
            {
                return null;
            }

            return aluno;
        }

        public Aluno? SelecionarAlunoPorNome(string nome)
        {
            var aluno = _appDatabaseContext.Alunos.FirstOrDefault(x => x.Nome == nome);
            if (aluno == null)
            {
                return null;
            }

            return aluno;
        }

    }
}
