using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using WinFormsApp1.Repository;

namespace WinFormsApp1.Context
{
    internal class RepositoryContext
    {
        private Microsoft.Data.SqlClient.SqlConnection _connection;

        public RepositoryContext(string connectionString)
        {
            _connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
            _connection.Open();

            CreatesIniciais();

            AlunoRepository = new AlunoRepository(_connection);
            PacoteRepository = new PacoteRepository(_connection);
        }

        ~RepositoryContext()
        {
            _connection?.CloseAsync().Wait();
        }

        public AlunoRepository AlunoRepository { get; private init; }
        public PacoteRepository PacoteRepository { get; private init; }

        private void CreatesIniciais()
        {
            {
                var CREATE_ALUNO_TABLE_QUERY = """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Aluno')
                BEGIN
                    CREATE TABLE Aluno (
                        Codigo INT IDENTITY PRIMARY KEY,
                        Nome VARCHAR(200) NOT NULL,
                        Matricula VARCHAR(20) NOT NULL,
                        Email VARCHAR(200) NOT NULL,
                        QntdImpressao SMALLINT NOT NULL,
                        CONSTRAINT Unique_Aluno_Nome UNIQUE (Nome),
                        CONSTRAINT Unique_Aluno_Matricula UNIQUE (Matricula),
                        CONSTRAINT Unique_Aluno_Email UNIQUE (Email)
                    );
                END
                """;
                _connection.Execute(CREATE_ALUNO_TABLE_QUERY);
            }

            {
                var CREATE_PACOTES_TABLE_QUERY = """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Pacotes')
                BEGIN
                    CREATE TABLE Pacotes (
                        Codigo INT IDENTITY PRIMARY KEY,
                        Quantidade SMALLINT NOT NULL,
                        Preco DECIMAL(6, 2) NOT NULL
                    );
                END
                """;
                _connection.Execute(CREATE_PACOTES_TABLE_QUERY);
            }
           
            //colocar os outros Create aqui
        }
    }
}
