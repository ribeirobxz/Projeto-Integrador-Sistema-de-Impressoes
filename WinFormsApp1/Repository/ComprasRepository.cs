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
    internal class ComprasRepository
    {
        private SqlConnection _connection;

        public ComprasRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarCompra(Compras compra)
        {

            var sqlQuery =
                """
                INSERT INTO Compras (
                CodigoAluno,
                CodigoHistorico,
                DataCompra,
                ValorTotalPago
                ) VALUES (
                @CodigoAluno,
                @CodigoHistorico,
                @DataCompra,
                @ValorTotalPago
                );
                SELECT CAST(SCOPE_IDENTITY() AS INT);
                """;

            var id = _connection.ExecuteScalar<int>(sqlQuery, compra);
            compra.Codigo = id;

            return true;
        }

        public bool RemoverCompra(long codigo)
        {
            var sql = "DELETE FROM Compras WHERE Codigo = @Codigo;";
            _connection.Execute(sql, new { Codigo = codigo });

            return true;
        }

        public bool RemoverCompraPorCodigoHistorico(long codigoHistorico)
        {
            var sql = "DELETE FROM Compras WHERE CodigoHistorico = @CodigoHistorico;";
            _connection.Execute(sql, new { CodigoHistorico = codigoHistorico });

            return true;
        }

        public Compras? SelecionarPorCodigo(long codigo)
        {
            var sql = "SELECT * FROM Compras WHERE Codigo = @Codigo;";
            return _connection.QueryFirstOrDefault<Compras>(sql, new { Codigo = codigo });
        }

        public Compras? SelecionarPorCodigoHistorico(long codigoHistorico)
        {
            var sql = "SELECT * FROM Compras WHERE CodigoHistorico = @CodigoHistorico;";
            return _connection.QueryFirstOrDefault<Compras>(sql, new { CodigoHistorico = codigoHistorico });
        }

    }
}
