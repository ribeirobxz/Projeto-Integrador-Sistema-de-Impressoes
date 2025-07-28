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
    internal class PacoteRepository
    {
        private SqlConnection _connection;

        public PacoteRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public void AdicionarPacote(Pacote pacote)
        {
            try
            {
                var sqlQuery = @"INSERT INTO Pacotes (Quantidade, Preco) VALUES(@Quantidade, @Preco)" +
                    " SELECT CAST(SCOPE_IDENTITY() AS INT);";

                var codigo = _connection.ExecuteScalar<int>(sqlQuery, pacote);
                pacote.Codigo = codigo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool AtualizarPacote(Pacote pacote)
        {
            try
            {
                var sqlQuery = @"UPDATE Pacotes SET Quantidade = @Quantidade, Preco = @Preco WHERE Codigo = @Codigo;";
                return _connection.Execute(sqlQuery, pacote) > 0;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public bool RemoverPacote(int codigo)
        {
            try
            {
                var sqlQuery = @"DELETE FROM Pacotes WHERE Codigo = @Codigo";
                return _connection.Execute(sqlQuery, new { Codigo = codigo }) > 0;
            } catch(Exception e)
            {
                throw;
            }
        }

        public Pacote? SelecionarPorCodigo(int codigo)
        {
                var sqlQuery = @"SELECT * FROM Pacotes WHERE Codigo = @Codigo;";
                return _connection.QueryFirstOrDefault<Pacote>(sqlQuery, new { Codigo = codigo });
        }

        public IEnumerable<Pacote> SelecionarTodos()
        {
            var sqlQuery = "SELECT * FROM Pacotes ORDER BY Codigo";
            return _connection.Query<Pacote>(sqlQuery);
        }
    }
}
