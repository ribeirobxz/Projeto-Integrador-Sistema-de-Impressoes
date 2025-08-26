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
    internal class ExcluidosRepository
    {
        private SqlConnection _connection;

        public ExcluidosRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        //tem que fazer ainda

        public bool Adicionar(Excluidos excluidos)
        {

            var sqlQuery =
                """
                INSERT INTO Excluidos (
                CodigoHistorico,
                Motivo,
                DataExclusao
                ) VALUES (
                @CodigoHistorico,
                @Motivo,
                @DataExclusao
                );
                SELECT CAST(SCOPE_IDENTITY() AS INT);
                """;

            var id = _connection.ExecuteScalar<int>(sqlQuery, excluidos);
            excluidos.Codigo = id;

            return true;
        }


    }
}
