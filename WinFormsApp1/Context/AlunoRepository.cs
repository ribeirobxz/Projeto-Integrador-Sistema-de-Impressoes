using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Context
{
    internal class AlunoRepository
    {
        private SqlConnection _connection;

        public AlunoRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        private (bool deletado, string mensagem) DeletarDaTabela(long id, string NomeDaTabela)
        {
            var command = _connection.CreateCommand();
            command.CommandText = $"delete from {NomeDaTabela} where id = {id};";

            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    return (true, $"Deletado com sucesso! ID: {id}");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Não foi possivel deletar, ID: {id} Erro: " + ex.Message);
            }

            return (false, $"Não existe esse ID: {id}");
        }

        public bool AdicionarAluno(Aluno aluno)
        {
            var command = _connection.CreateCommand();
            command.CommandText = "INSERT INTO Aluno (Nome, Matricula, Email, QntdImpressao) VALUES (@Nome, @Matricula, @Email, @QntdImpressao);";

            command.Parameters.AddWithValue("@Nome", aluno.Nome);
            command.Parameters.AddWithValue("@Matricula", aluno.Matricula);
            command.Parameters.AddWithValue("@Email", aluno.Email);
            command.Parameters.AddWithValue("@QntdImpressao", aluno.QntdImpressao);

            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public bool AtualizarAluno(Aluno aluno)
        {
            var command = _connection.CreateCommand();
            command.CommandText = "update Aluno set Nome = @Nome, Matricula = @Matricula, Email = @Email, QntdImpressao = @QntdImpressao where Codigo = @Codigo;";

            command.Parameters.AddWithValue("@Nome", aluno.Nome);
            command.Parameters.AddWithValue("@Matricula", aluno.Matricula);
            command.Parameters.AddWithValue("@Email", aluno.Email);
            command.Parameters.AddWithValue("@QntdImpressao", aluno.QntdImpressao);
            command.Parameters.AddWithValue("@Codigo", aluno.Codigo);

            try
            {
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return false;
        }

        public (bool deletado, string mesagem) DeletarAluno(long Codigo)
        {
            return DeletarDaTabela(Codigo, "Aluno");
        }

        public Aluno? SelecionarAlunoPorCodigo(int Codigo)
        {
            var command = _connection.CreateCommand();
            command.CommandText = $"select Nome, Matricula, Email, QntdImpressao from Aluno where Codigo == {Codigo};";

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                Aluno aluno = new Aluno();
                aluno.Codigo = Codigo;
                aluno.Nome = reader.GetString(0);
                aluno.Matricula = reader.GetString(1);
                aluno.Email = reader.GetString(2);
                aluno.QntdImpressao = reader.GetInt16(3);
                return aluno;
            }

            return null;
        }

        public List<Aluno> SelecionarTodosAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();

            var command = _connection.CreateCommand();
            command.CommandText = $"select id, Nome, Matricula, Email, QntdImpressao from Aluno;";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Aluno aluno = new Aluno();
                aluno.Codigo = reader.GetInt32(0);
                aluno.Nome = reader.GetString(1);
                aluno.Matricula = reader.GetString(2);
                aluno.Email = reader.GetString(3);
                aluno.QntdImpressao = reader.GetInt16(4);

                alunos.Add(aluno);
            }

            return alunos;
        }

    }
}
