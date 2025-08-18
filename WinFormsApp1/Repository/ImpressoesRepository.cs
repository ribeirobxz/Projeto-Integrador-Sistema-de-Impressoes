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
    public class ImpressoesRepository
    {

        private SqlConnection _connection;

        public ImpressoesRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarImpressao(Impressoes impressao)
        {
            var sqlQuery = 
                """
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
                """;

            var id = _connection.ExecuteScalar<int>(sqlQuery, impressao);
            impressao.Codigo = id;

            return true;

        }

        public bool RemoverImpressao(long codigo)
        {
            var sql = "DELETE FROM Impressoes WHERE Codigo = @Codigo;";
            _connection.Execute(sql, new { Codigo = codigo });

            return true;
        }

        public Compras? SelecionarPorCodigo(long codigo)
        {
            var sql = "SELECT * FROM Impressoes WHERE Codigo = @Codigo;";
            return _connection.QueryFirstOrDefault<Compras>(sql, new { Codigo = codigo });
        }
    }
}
