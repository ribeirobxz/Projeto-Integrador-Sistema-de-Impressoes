using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;
using WinFormsApp1.Model.Historic;

namespace WinFormsApp1.Repository
{
    internal class CompraRepository
    {
        private SqlConnection _connection;

        public CompraRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarCompra(Compra compra)
        {
            try
            {
                var sqlQuery = @"
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
                    ";


                var id = _connection.ExecuteScalar<int>(sqlQuery, compra);
                compra.Codigo = id;

               return true;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public bool RemoverCompra(long codigo)
        {
            try
            {
                var sql = "DELETE FROM Compras WHERE Codigo = @Codigo;";
                _connection.Execute(sql, new { Codigo = codigo });

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Compra? SelecionarPorCodigo(long codigo)
        {
            try
            {
                var sql = "SELECT * FROM Compras WHERE Codigo = @Codigo;";
                return _connection.QueryFirstOrDefault<Compra>(sql, new { Codigo = codigo });
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
