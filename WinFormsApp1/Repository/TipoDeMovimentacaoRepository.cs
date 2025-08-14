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
    public class TipoDeMovimentacaoRepository
    {

        private SqlConnection _connection;

        public TipoDeMovimentacaoRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public TipoDeMovimentacao? SelecionarPorCodigo(long codigo)
        {
            var sqlQuery = "SELECT * FROM TipoMovimentacoes WHERE Codigo = @Codigo;";
            return _connection.QueryFirstOrDefault<TipoDeMovimentacao>(sqlQuery, new { Codigo = codigo });
        }

        public TipoDeMovimentacao? SelecionarPorNome(string nome)
        {
            var sqlQuery = "SELECT * FROM TipoMovimentacoes WHERE Nome = @Nome;";
            return _connection.QueryFirstOrDefault<TipoDeMovimentacao>(sqlQuery, new { Nome = nome });
        }


    }
}
