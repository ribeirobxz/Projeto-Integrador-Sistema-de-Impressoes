using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Repository
{
    internal class AlunoRepository
    {
        private SqlConnection _connection;

        public AlunoRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarAluno(Aluno aluno)
        {
            try
            {
               var sqlQuery = @"INSERT INTO Aluno (Nome, Matricula, Email, QntdImpressao) VALUES (@Nome, @Matricula, @Email, 
                                @QntdImpressao) SELECT CAST(SCOPE_IDENTITY() AS INT);";

               var id = _connection.ExecuteScalar<int>(sqlQuery, aluno);
               aluno.Codigo = id;

               return true;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public bool AtualizarAluno(Aluno aluno)
        {
            try
            {
                var sqlQuery = @"UPDATE Aluno SET Nome = @Nome, Matricula = @Matricula, Email = @Email, 
                                QntdImpressao = @QntdImpressao WHERE Codigo = @Codigo;";
                return _connection.Execute(sqlQuery, aluno) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool RemoverAluno(long codigo)
        {
            try
            {
                var sql = "DELETE FROM Aluno WHERE Codigo = @Codigo;";
                _connection.Execute(sql, new { Codigo = codigo });

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Aluno? SelecionarAlunoPorCodigo(int codigo)
        {
            var sqlQuery = "SELECT * FROM Aluno WHERE Codigo = @Codigo;";
            return _connection.QueryFirstOrDefault<Aluno>(sqlQuery, new { Codigo = codigo });
        }

        public Aluno? SelecionarAlunoPorNome(string nome)
        {
            var sqlQuery = "SELECT * FROM Aluno WHERE Nome = @Nome;";
            return _connection.QueryFirstOrDefault<Aluno>(sqlQuery, new { Nome = nome });
        }

        public IEnumerable<Aluno> SelecionarTodosAlunos()
        {
            var sqlQuery = "SELECT * FROM Aluno;";
            return _connection.Query<Aluno>(sqlQuery);
        }

        public IEnumerable<Aluno> SelecionarAlunosPorNome(string NomeQueContem)
        {
            var sqlQuery = "SELECT * FROM Aluno WHERE Nome LIKE @Nome;";
            return _connection.Query<Aluno>(sqlQuery, new { Nome = "%" + NomeQueContem + "%" });
        }

    }
}
