using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;
using WinFormsApp1.Model.Historic;
using WinFormsApp1.ModelView;

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

        public IEnumerable<Historicos> SelecionarTodosPorAluno(long codigoAluno)
        {
            var sqlQuery = "SELECT * FROM Historicos WHERE CodigoAluno = @CodigoAluno ORDER BY Codigo DESC;";
            return _connection.Query<Historicos>(sqlQuery, new { CodigoAluno = codigoAluno });
        }


        public Historicos? UltimoHistoricoValido() 
        {
            try
            {
                var sqlQuery =
                    """                   
                    SELECT TOP 1 * FROM Historicos WHERE
                    CodigoTipoMovimentacao = (SELECT Codigo FROM TipoMovimentacoes where Nome = 'Compra')
                    or
                    CodigoTipoMovimentacao = (SELECT Codigo FROM TipoMovimentacoes where Nome = 'Impressão')
                    Order By codigo Desc;
                    """;
                return _connection.QueryFirstOrDefault<Historicos>(sqlQuery);
            }
            catch (Exception)
            {
            }

            return null;
        }

        public IEnumerable<VisualizarHistorico>? ObterListaDeHistoricoVisualizacaoTodos(long codigoAluno) 
        {
            try
            {
                var sqlQuery =
                    """
                    SELECT h.Codigo as 'Codigo', h.CodigoTipoMovimentacao as 'CodigoTipoMovimentacao', h.CodigoAluno as 'CodigoAluno',
                     h.DataHistorico as 'DataHistorico', h.QntdTotal as 'QntdTotal', h.SaldoAntes as 'SaldoAntes', h.SaldoDepois as 'SaldoDepois',
                     h.ValorTotalPago as 'ValorTotalPago', t.Nome as 'NomeTipoMovimentacoes',
                     e.Motivo as 'Motivo', e.DataExclusao as 'DataExclusao', e.Codigo as 'CodigoExcluido'
                     FROM Historicos h
                     LEFT JOIN TipoMovimentacoes t on h.CodigoTipoMovimentacao = t.Codigo
                     LEFT JOIN Excluidos e on h.Codigo = e.CodigoHistorico
                     WHERE CodigoAluno = @CodigoAluno 
                     ORDER BY Codigo DESC;
                    """;
                return _connection.Query<VisualizarHistorico>(sqlQuery, new { CodigoAluno = codigoAluno });
            }
            catch (Exception)
            {
            }

            return null;
        }

        public IEnumerable<VisualizarHistorico>? ObterListaDeHistoricoVisualizacaoCompras(long codigoAluno)
        {
            try
            {
                var sqlQuery =
                    """
                    SELECT h.Codigo as 'Codigo', h.CodigoTipoMovimentacao as 'CodigoTipoMovimentacao', h.CodigoAluno as 'CodigoAluno',
                     h.DataHistorico as 'DataHistorico', h.QntdTotal as 'QntdTotal', h.SaldoAntes as 'SaldoAntes', h.SaldoDepois as 'SaldoDepois',
                     h.ValorTotalPago as 'ValorTotalPago', t.Nome as 'NomeTipoMovimentacoes',
                     e.Motivo as 'Motivo', e.DataExclusao as 'DataExclusao', e.Codigo as 'CodigoExcluido'
                     FROM Historicos h
                     LEFT JOIN TipoMovimentacoes t on h.CodigoTipoMovimentacao = t.Codigo
                     LEFT JOIN Excluidos e on h.Codigo = e.CodigoHistorico
                     WHERE CodigoAluno = @CodigoAluno and h.CodigoTipoMovimentacao = (select Codigo from TipoMovimentacoes where Nome = 'Compra')
                     ORDER BY Codigo DESC;
                    """;
                return _connection.Query<VisualizarHistorico>(sqlQuery, new { CodigoAluno = codigoAluno });
            }
            catch (Exception)
            {
            }

            return null;
        }


        public IEnumerable<VisualizarHistorico>? ObterListaDeHistoricoVisualizacaoImpressões(long codigoAluno)
        {
            try
            {
                var sqlQuery =
                    """
                    SELECT h.Codigo as 'Codigo', h.CodigoTipoMovimentacao as 'CodigoTipoMovimentacao', h.CodigoAluno as 'CodigoAluno',
                     h.DataHistorico as 'DataHistorico', h.QntdTotal as 'QntdTotal', h.SaldoAntes as 'SaldoAntes', h.SaldoDepois as 'SaldoDepois',
                     h.ValorTotalPago as 'ValorTotalPago', t.Nome as 'NomeTipoMovimentacoes',
                     e.Motivo as 'Motivo', e.DataExclusao as 'DataExclusao', e.Codigo as 'CodigoExcluido'
                     FROM Historicos h
                     LEFT JOIN TipoMovimentacoes t on h.CodigoTipoMovimentacao = t.Codigo
                     LEFT JOIN Excluidos e on h.Codigo = e.CodigoHistorico
                     WHERE CodigoAluno = @CodigoAluno and h.CodigoTipoMovimentacao = (select Codigo from TipoMovimentacoes where Nome = 'Impressão')
                     ORDER BY Codigo DESC;
                    """;
                return _connection.Query<VisualizarHistorico>(sqlQuery, new { CodigoAluno = codigoAluno });
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
