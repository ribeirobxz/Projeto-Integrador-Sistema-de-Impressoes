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
    public class ImpressaoRepository
    {

        private SqlConnection _connection;

        public ImpressaoRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarImpressao(Impressao impressao)
        {
            try
            {
                var sqlQuery = @"
                        INSERT INTO Impressoes (
                            CodigoAluno,
                            CodigoHistorico,
                            DataImpressao,
                            QntdImpressao
                        ) VALUES (
                            @CodigoAluno,
                            @CodigoHistorico,
                            @DataImpressao,
                            @QntdImpressao
                        );
                        SELECT CAST(SCOPE_IDENTITY() AS INT);
                    ";


                var id = _connection.ExecuteScalar<int>(sqlQuery, impressao);
                impressao.Codigo = id;

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public bool RemoverImpressao(long codigo)
        {
            try
            {
                var sql = "DELETE FROM Impressoes WHERE Codigo = @Codigo;";
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
                var sql = "SELECT * FROM Impressoes WHERE Codigo = @Codigo;";
                return _connection.QueryFirstOrDefault<Compra>(sql, new { Codigo = codigo });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
