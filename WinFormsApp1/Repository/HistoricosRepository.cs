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
    internal class HistoricosRepository
    {
        private SqlConnection _connection;

        public HistoricosRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarHistorico(Historicos historico)
        {
            var sqlQuery =
                """
                INSERT INTO Historicos (
                CodigoTipoMovimentacao,
                CodigoAluno,
                DataHistorico,
                QntdTotal,
                SaldoAntes,
                SaldoDepois,
                ValorTotalPago
                ) VALUES (
                @CodigoTipoMovimentacao,
                @CodigoAluno,
                @DataHistorico,
                @QntdTotal,
                @SaldoAntes,
                @SaldoDepois,
                @ValorTotalPago
                );
                SELECT CAST(SCOPE_IDENTITY() AS INT);
                """;

            var id = _connection.ExecuteScalar<int>(sqlQuery, historico);
            historico.Codigo = id;

            return true;
        }

        public bool AtualizarHistorico(Historicos historico)
        {
            var sqlQuery =
                     """
                    UPDATE Historicos SET 
                    CodigoTipoMovimentacao = @CodigoTipoMovimentacao, 
                    CodigoAluno = @CodigoAluno, 
                    DataHistorico = @DataHistorico, 
                    QntdTotal = @QntdTotal, 
                    SaldoAntes = @SaldoAntes, 
                    SaldoDepois = @SaldoDepois, 
                    ValorTotalPago = @ValorTotalPago 
                    WHERE Codigo = @Codigo;
                    """;

            return _connection.Execute(sqlQuery, historico) > 0;
        }

        public bool RemoverHistorico(long codigo)
        {
            var sql = "DELETE FROM Historicos WHERE Codigo = @Codigo;";
            _connection.Execute(sql, new { Codigo = codigo });

            return true;
        }

        public IEnumerable<Historicos> SelecionarTodosPorAluno(long codigo)
        {
            var sqlQuery = "SELECT * FROM Historicos WHERE CodigoAluno = @CodigoAluno ORDER BY Codigo DESC;";
            return _connection.Query<Historicos>(sqlQuery, new { CodigoAluno = codigo });
        }

    }
}
