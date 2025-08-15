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
    public class TipoMovimentacoesRepository
    {

        private SqlConnection _connection;

        public TipoMovimentacoesRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public TipoMovimentacoes? SelecionarPorCodigo(long codigo)
        {
            var sqlQuery = "SELECT * FROM TipoMovimentacoes WHERE Codigo = @Codigo;";
            return _connection.QueryFirstOrDefault<TipoMovimentacoes>(sqlQuery, new { Codigo = codigo });
        }

        public TipoMovimentacoes? SelecionarPorNome(string nome)
        {
            var sqlQuery = "SELECT * FROM TipoMovimentacoes WHERE Nome = @Nome;";
            return _connection.QueryFirstOrDefault<TipoMovimentacoes>(sqlQuery, new { Nome = nome });
        }


    }
}
