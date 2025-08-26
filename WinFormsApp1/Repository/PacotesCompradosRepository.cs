using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model.Historic;

namespace WinFormsApp1.Repository
{
    public class PacotesCompradosRepository
    {

        private SqlConnection _connection;

        public PacotesCompradosRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarPacoteComprado(PacotesComprados PacoteComprado)
        {
            var sqlQuery =
                """
                INSERT INTO PacotesComprados (
                CodigoCompra,
                CodigoPacote,
                Multiplicador,
                PrecoPacote
                ) VALUES (
                @CodigoCompra,
                @CodigoPacote,
                @Multiplicador,
                @PrecoPacote
                );
                SELECT CAST(SCOPE_IDENTITY() AS INT);
                """;

            var id = _connection.ExecuteScalar<int>(sqlQuery, PacoteComprado);
            PacoteComprado.Codigo = id;

            return true;
        }

        public bool RemoverPacoteComprado(long codigo)
        {
            var sql = "DELETE FROM PacotesComprados WHERE Codigo = @Codigo;";
            _connection.Execute(sql, new { Codigo = codigo });

            return true;
        }

        public bool RemoverPacoteCompradoPorCodigoCompra(long codigoCompra)
        {
            var sql = "DELETE FROM PacotesComprados WHERE CodigoCompra = @CodigoCompra;";
            _connection.Execute(sql, new { CodigoCompra = codigoCompra });

            return true;
        }

        public IEnumerable<PacotesComprados>? SelecionarPorCodigo(long codigo)
        {
            var sql = "SELECT * FROM ComprasPacotes WHERE CodigoCompra = @CodigoCompra;";
            return _connection.Query<PacotesComprados>(sql, new { CodigoCompra = codigo });
        }

    }
}
