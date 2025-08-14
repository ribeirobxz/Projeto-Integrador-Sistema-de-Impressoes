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
            InsertsIniciais();

            AlunoRepository = new AlunoRepository(_connection);
            PacoteRepository = new PacoteRepository(_connection);
            TipoDeMovimentacaoRepository = new TipoDeMovimentacaoRepository(_connection);
            HistoricoRepository = new HistoricoRepository(_connection);
            CompraRepository = new CompraRepository(_connection);
            ComprasPacoteRepository = new ComprasPacoteRepository(_connection);
            ImpressaoRepository = new ImpressaoRepository(_connection);
        }

        ~RepositoryContext()
        {
            _connection?.CloseAsync().Wait();
        }

        public AlunoRepository AlunoRepository { get; private init; }
        public PacoteRepository PacoteRepository { get; private init; }
        public TipoDeMovimentacaoRepository TipoDeMovimentacaoRepository { get; private init; }
        public HistoricoRepository HistoricoRepository { get; private init; }
        public CompraRepository CompraRepository { get; private init; }
        public ComprasPacoteRepository ComprasPacoteRepository { get; private init; }
        public ImpressaoRepository ImpressaoRepository { get; private init; }

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

            {
                var CREATE_TIPOS_DE_MOVIMENTACOES_TABLE_QUERY = """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TipoMovimentacoes')
                BEGIN
                  CREATE TABLE TipoMovimentacoes(
                        Codigo Tinyint identity not null,
                        Nome Varchar(20) not null,
                        Constraint TipoMovimentacoesPK
                        Primary key (codigo)
                  );
                END
                """;
                _connection.Execute(CREATE_TIPOS_DE_MOVIMENTACOES_TABLE_QUERY);
            }

            {
                var CREATE_HISTORICO_TABLE_QUERY = """
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Historicos')
                    BEGIN
                        CREATE TABLE Historicos(
                            Codigo int identity not null,
                            CodigoTipoDeMovimentacao tinyint,
                            CodigoAluno int,
                            DataHistorico datetime not null,
                            QntdTotal Smallint not null,
                            SaldoAntes smallint not null,
                            SaldoDepois smallint not null,
                            ValorTotalPago decimal(12,4),
                            Constraint HitoricosPK
                            Primary key (codigo),
                            Constraint Codigo_Alunos
                            Foreign key (CodigoAluno)
                            References Aluno(codigo),
                            Constraint CodigoTipoDeMovimentacao
                            Foreign key (CodigoTipoDeMovimentacao)
                            References TipoMovimentacoes(codigo),
                        );
                    END
                    """;
                _connection.Execute(CREATE_HISTORICO_TABLE_QUERY);
            }

            {
                var CREATE_COMPRAS_TABLE_QUERY = """
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Compras')
                    BEGIN
                        CREATE TABLE Compras(
                            Codigo INT IDENTITY NOT NULL,
                            CodigoAluno int not null,
                            CodigoHistorico int not null,
                            DataCompra datetime not null,
                            ValorTotalPago Decimal(12,4),
                            Constraint ComprasPK
                            Primary key (codigo),
                             Constraint Compras_CodigoAlunos
                            Foreign key (CodigoAluno)
                            References Aluno(codigo),
                             Constraint Compra_CodigoHistoricos
                            Foreign key(CodigoHistorico)
                            References Historicos(codigo),
                            Constraint Unique_Compras_CodigoHistoricos Unique (CodigoHistorico)
                        )
                    END
                    """;
                _connection.Execute(CREATE_COMPRAS_TABLE_QUERY);
            }

            {
                var CREATE_COMPRAS_PACOTES_TABLE_QUERY = """
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ComprasPacotes')
                    BEGIN
                       CREATE TABLE ComprasPacotes(
                            Codigo int identity,
                            CodigoCompra int,
                            CodigoPacote int,
                            Multiplicador smallint,
                            PrecoPacote decimal(9,4)
                            Constraint PacotesComprasPK
                            Primary key (Codigo)
                            Constraint Pct_CodigoCompras
                            Foreign key (CodigoCompra)
                            References Compras(Codigo),
                            Constraint Pct_CodigoPacotes
                            Foreign key (CodigoPacote)
                            References Pacotes(codigo),
                            Constraint Unique_PacotesCompras unique(CodigoCompra,CodigoPacote)
                        )
                    END
                    """;
                _connection.Execute(CREATE_COMPRAS_PACOTES_TABLE_QUERY);
            }

            {
                var CREATE_IMPRESAO_TABLE_QUERY = """
                    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Impressoes')
                    BEGIN
                        CREATE TABLE Impressoes(
                            Codigo int identity not null,
                            CodigoAluno int not null,
                            CodigoHistorico int not null,
                            DataImpressao datetime not null,
                            QntdImpressao Smallint not null,
                            Constraint ImpressoesPK
                            Primary key (codigo),
                             Constraint ImpCodigo_Aluno
                            Foreign key (CodigoAluno)
                            References Aluno(codigo),
                             Constraint ImpCodigo_Historico
                            Foreign key(CodigoHistorico)
                            References Historicos(codigo),
                            Constraint Unique_Impressoes_CodigoHistorico Unique (CodigoHistorico)
                         )
                    END
                    """;
                _connection.Execute(CREATE_IMPRESAO_TABLE_QUERY);
            }
           
            //colocar os outros Create aqui
        }

        private void InsertsIniciais()
        {
            var INSERT_TIPOS_DE_MOVIMENTACOES_QUERY = """
                IF NOT EXISTS (SELECT * FROM TipoMovimentacoes)
                BEGIN
                    INSERT INTO TipoMovimentacoes (Nome) VALUES ('Compra');
                    INSERT INTO TipoMovimentacoes (Nome) VALUES ('Impressão');
                END
                """;
            _connection.Execute(INSERT_TIPOS_DE_MOVIMENTACOES_QUERY);
        }
    }
}
