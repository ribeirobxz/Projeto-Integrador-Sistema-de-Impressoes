using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
