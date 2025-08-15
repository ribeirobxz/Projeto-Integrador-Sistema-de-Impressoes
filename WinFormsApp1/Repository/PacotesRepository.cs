using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.Repository
{
    internal class PacotesRepository
    {
        private SqlConnection _connection;

        public PacotesRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarPacote(Pacotes pacote)
        {
            var sqlQuery = 
                """
                INSERT INTO Pacotes (
                Quantidade, 
                Preco
                ) VALUES(
                @Quantidade, 
                @Preco
                );
                SELECT CAST(SCOPE_IDENTITY() AS INT);
                """;

            var codigo = _connection.ExecuteScalar<int>(sqlQuery, pacote);
            pacote.Codigo = codigo;

            return true;
        }

        public bool AtualizarPacote(Pacotes pacote)
        {
            var sqlQuery = @"UPDATE Pacotes SET Quantidade = @Quantidade, Preco = @Preco WHERE Codigo = @Codigo;";
            return _connection.Execute(sqlQuery, pacote) > 0;
        }

        public bool RemoverPacote(int codigo)
        {
            var sqlQuery = @"DELETE FROM Pacotes WHERE Codigo = @Codigo";
            return _connection.Execute(sqlQuery, new { Codigo = codigo }) > 0;
        }

        public Pacotes? SelecionarPorCodigo(int codigo)
        {
            var sqlQuery = @"SELECT * FROM Pacotes WHERE Codigo = @Codigo;";
            return _connection.QueryFirstOrDefault<Pacotes>(sqlQuery, new { Codigo = codigo });
        }

        public IEnumerable<Pacotes> SelecionarTodos()
        {
            var sqlQuery = "SELECT * FROM Pacotes ORDER BY Codigo";
            return _connection.Query<Pacotes>(sqlQuery);
        }
    }
}
