using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Repository
{
    internal class PacoteRepository
    {
        private SqlConnection _connection;

        public PacoteRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        // comandos SQL aqui
    }
}
