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
    internal class HistoricoRepository
    {
        private SqlConnection _connection;

        public HistoricoRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool AdicionarHistorico(Historico historico)
        {
            try
            {
                var sqlQuery = @"
                        INSERT INTO Historicos (
                            CodigoTipoDeMovimentacao,
                            CodigoAluno,
                            DataHistorico,
                            QntdTotal,
                            SaldoAntes,
                            SaldoDepois,
                            ValorTotalPago
                        ) VALUES (
                            @CodigoTipoDeMovimentacao,
                            @CodigoAluno,
                            @DataHistorico,
                            @QntdTotal,
                            @SaldoAntes,
                            @SaldoDepois,
                            @ValorTotalPago
                        );
                        SELECT CAST(SCOPE_IDENTITY() AS INT);
                    ";


                var id = _connection.ExecuteScalar<int>(sqlQuery, historico);
               historico.Codigo = id;

               return true;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public bool AtualizarHistorico(Historico historico)
        {
            try
            {
                var sqlQuery = @"UPDATE Historicos SET CodigoTipoDeMovimentacao = @CodigoTipoDeMovimentacao, CodigoAluno = @CodigoAluno, DataHistorico = @DataHistorico, 
                                QntdTotal = @QntdTotal, SaldoAntes = @SaldoAntes, SaldoDepois = @SaldoDepois, ValorTotalPago = @ValorTotalPago WHERE Codigo = @Codigo;";
                return _connection.Execute(sqlQuery, historico) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool RemoverHistorico(long codigo)
        {
            try
            {
                var sql = "DELETE FROM Historicos WHERE Codigo = @Codigo;";
                _connection.Execute(sql, new { Codigo = codigo });

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<Historico> SelecionarTodosPorAluno(long codigo)
        {
            var sqlQuery = "SELECT * FROM Historicos WHERE CodigoAluno = @CodigoAluno ORDER BY Codigo DESC;";
            return _connection.Query<Historico>(sqlQuery, new { CodigoAluno = codigo });
        }

    }
}
