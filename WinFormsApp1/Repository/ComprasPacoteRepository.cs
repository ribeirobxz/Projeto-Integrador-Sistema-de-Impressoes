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
    public class ComprasPacoteRepository
    {

        private SqlConnection _connection;

        public ComprasPacoteRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarCompraPacote(CompraPacote compraPacote)
        {
            try
            {
                var sqlQuery = @"
                        INSERT INTO ComprasPacotes (
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
                    ";


                var id = _connection.ExecuteScalar<int>(sqlQuery, compraPacote);
                compraPacote.Codigo = id;

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public bool RemoverCompraPacote(long codigo)
        {
            try
            {
                var sql = "DELETE FROM ComprasPacotes WHERE Codigo = @Codigo;";
                _connection.Execute(sql, new { Codigo = codigo });

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<CompraPacote>? SelecionarPorCodigo(long codigo)
        {
            try
            {
                var sql = "SELECT * FROM ComprasPacotes WHERE CodigoCompra = @CodigoCompra;";
                return _connection.Query<CompraPacote>(sql, new { CodigoCompra = codigo });
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
