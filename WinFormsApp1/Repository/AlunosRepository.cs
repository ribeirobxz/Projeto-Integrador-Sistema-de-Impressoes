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
    internal class AlunosRepository
    {
        private SqlConnection _connection;

        public AlunosRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarAluno(Alunos aluno)
        {
            var sqlQuery =
                """
                INSERT INTO Alunos (
                Nome,
                Matricula,
                NunTelefone,
                QntdImpressao
                ) VALUES (
                @Nome,
                @Matricula,
                @NunTelefone,
                @QntdImpressao
                );
                SELECT CAST(SCOPE_IDENTITY() AS INT);
                """;

            var id = _connection.ExecuteScalar<int>(sqlQuery, aluno);
            aluno.Codigo = id;

            return true;

        }

        public bool AtualizarAluno(Alunos aluno)
        {

            var sqlQuery =
                """
                UPDATE Alunos SET 
                Nome = @Nome, 
                Matricula = @Matricula, 
                NunTelefone = @NunTelefone, 
                QntdImpressao = @QntdImpressao 
                WHERE Codigo = @Codigo;
                """;

            return _connection.Execute(sqlQuery, aluno) > 0;     
        }

        public bool RemoverAluno(long codigo)
        {

            var sql = "DELETE FROM Alunos WHERE Codigo = @Codigo;";
            _connection.Execute(sql, new { Codigo = codigo });

            return true;

        }

        public Alunos? SelecionarAlunoPorCodigo(int codigo)
        {
            var sqlQuery = "SELECT * FROM Alunos WHERE Codigo = @Codigo;";
            return _connection.QueryFirstOrDefault<Alunos>(sqlQuery, new { Codigo = codigo });
        }

        public Alunos? SelecionarAlunoPorNome(string nome)
        {
            var sqlQuery = "SELECT * FROM Alunos WHERE Nome = @Nome;";
            return _connection.QueryFirstOrDefault<Alunos>(sqlQuery, new { Nome = nome });
        }

        public IEnumerable<Alunos> SelecionarTodosAlunos()
        {
            var sqlQuery = "SELECT * FROM Alunos;";
            return _connection.Query<Alunos>(sqlQuery);
        }

        public IEnumerable<Alunos> SelecionarAlunosPorNome(string NomeQueContem)
        {
            var sqlQuery = "SELECT * FROM Alunos WHERE Nome LIKE @Nome;";
            return _connection.Query<Alunos>(sqlQuery, new { Nome = "%" + NomeQueContem + "%" });
        }

    }
}
