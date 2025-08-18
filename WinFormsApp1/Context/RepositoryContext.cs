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

            AlunosRepository = new AlunosRepository(_connection);
            PacotesRepository = new PacotesRepository(_connection);
            TipoMovimentacoesRepository = new TipoMovimentacoesRepository(_connection);
            HistoricosRepository = new HistoricosRepository(_connection);
            ComprasRepository = new ComprasRepository(_connection);
            PacotesCompradosRepository = new PacotesCompradosRepository(_connection);
            ImpressoesRepository = new ImpressoesRepository(_connection);
            ExcluidosRepository = new ExcluidosRepository(_connection);
        }

        ~RepositoryContext()
        {
            _connection?.CloseAsync().Wait();
        }

        public AlunosRepository AlunosRepository { get; private init; }
        public PacotesRepository PacotesRepository { get; private init; }
        public TipoMovimentacoesRepository TipoMovimentacoesRepository { get; private init; }
        public HistoricosRepository HistoricosRepository { get; private init; }
        public ComprasRepository ComprasRepository { get; private init; }
        public PacotesCompradosRepository PacotesCompradosRepository { get; private init; }
        public ImpressoesRepository ImpressoesRepository { get; private init; }
        public ExcluidosRepository ExcluidosRepository { get; private init; }

        private void CreatesIniciais()
        {
            {
                var CREATE_ALUNOS_TABLE_QUERY = 
                """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Alunos')
                BEGIN
                CREATE TABLE Alunos (
                Codigo int identity not null,
                Nome varchar(200) not null,
                Matricula Varchar(20) not null,
                NunTelefone Varchar(20) not null,
                QntdImpressao smallint not null,
                CONSTRAINT AlunosPK Primary key (Codigo),
                CONSTRAINT Unique_Alunos_Nome UNIQUE (Nome),
                CONSTRAINT Unique_Alunos_Matricula UNIQUE (Matricula),
                CONSTRAINT Unique_Alunos_NunTelefone UNIQUE (NunTelefone)
                );
                END
                """;
                _connection.Execute(CREATE_ALUNOS_TABLE_QUERY);
            }

            {
                var CREATE_PACOTES_TABLE_QUERY = 
                """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Pacotes')
                BEGIN
                CREATE TABLE Pacotes (
                Codigo int identity not null,
                Quantidade smallint not null,
                Preco decimal(9,2) not null,
                Constraint PacotesPK Primary key (Codigo),
                Constraint Unique_Pacotes_Quantidade Unique (Quantidade)
                );
                END
                """;
                _connection.Execute(CREATE_PACOTES_TABLE_QUERY);
            }

            {
                var CREATE_TIPOS_DE_MOVIMENTACOES_TABLE_QUERY = 
                """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TipoMovimentacoes')
                BEGIN
                CREATE TABLE TipoMovimentacoes (
                Codigo Tinyint identity not null,
                Nome Varchar(20) not null,
                CONSTRAINT TipoMovimentacoesPK Primary key (Codigo),
                CONSTRAINT Unique_TipoMovimentacoes_Nome UNIQUE (Nome)
                );
                END
                """;
                _connection.Execute(CREATE_TIPOS_DE_MOVIMENTACOES_TABLE_QUERY);
            }

            {
                var CREATE_HISTORICOS_TABLE_QUERY =
                """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Historicos')
                BEGIN
                CREATE TABLE Historicos (
                Codigo int identity not null,
                CodigoTipoMovimentacao tinyint not null,
                CodigoAluno int not null,
                DataHistorico datetime not null,
                QntdTotal Smallint not null,
                SaldoAntes smallint not null,
                SaldoDepois smallint not null,
                ValorTotalPago decimal(12,2) null,
                Constraint HistoricosPK Primary key (Codigo),
                Constraint HistoricosFK_CodigoAluno Foreign key (CodigoAluno) References Alunos(Codigo),
                Constraint HistoricosFK_CodigoTipoMovimentacao Foreign key (CodigoTipoMovimentacao) References TipoMovimentacoes(Codigo)
                );
                END
                """;
                _connection.Execute(CREATE_HISTORICOS_TABLE_QUERY);
            }

            {
                var CREATE_COMPRAS_TABLE_QUERY = 
                """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Compras')
                BEGIN
                CREATE TABLE Compras (
                Codigo int identity not null,
                CodigoAluno int not null,
                CodigoHistorico int not null,
                DataCompra datetime not null,
                ValorTotalPago Decimal(12,2) not null,
                Constraint ComprasPK Primary key (Codigo),
                Constraint ComprasFK_CodigoAluno Foreign key (CodigoAluno) References Alunos(Codigo),
                Constraint ComprasFK_CodigoHistorico Foreign key(CodigoHistorico) References Historicos(Codigo),
                Constraint Unique_Compras_CodigoHistorico Unique (CodigoHistorico)
                );
                END
                """;
                _connection.Execute(CREATE_COMPRAS_TABLE_QUERY);
            }

            {
                var CREATE_PACOTES_COMPRADOS_TABLE_QUERY = 
                """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'PacotesComprados')
                BEGIN
                CREATE TABLE PacotesComprados (
                Codigo int identity not null,
                CodigoCompra int not null,
                CodigoPacote int not null,
                Multiplicador smallint not null,
                PrecoPacote decimal(9,2) not null,
                Constraint PacotesCompradosPK Primary key (Codigo),
                Constraint PctFK_CodigoCompra Foreign key (CodigoCompra) References Compras(Codigo),
                Constraint PctFK_CodigoPacote Foreign key (CodigoPacote) References Pacotes(Codigo),
                Constraint Unique_PacotesComprados unique(CodigoCompra, CodigoPacote)
                );
                END
                """;
                _connection.Execute(CREATE_PACOTES_COMPRADOS_TABLE_QUERY);
            }

            {
                var CREATE_IMPRESOES_TABLE_QUERY =
                """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Impressoes')
                BEGIN
                CREATE TABLE Impressoes (
                Codigo int identity not null,
                CodigoAluno int not null,
                CodigoHistorico int not null,
                DataImpressao datetime not null,
                QntdImpressao Smallint not null,
                Constraint ImpressoesPK Primary key (Codigo),
                Constraint ImpressoesFK_CodigoAluno Foreign key (CodigoAluno) References Alunos(Codigo),
                Constraint ImpressoesFK_CodigoHistorico Foreign key (CodigoHistorico) References Historicos(Codigo),
                Constraint Unique_Impressoes_CodigoHistorico Unique (CodigoHistorico)
                );
                END
                """;
                _connection.Execute(CREATE_IMPRESOES_TABLE_QUERY);
            }

            {
                var CREATE_EXCLUIDOS_TABLE_QUERY =
                """
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Excluidos')
                BEGIN
                CREATE TABLE Excluidos (
                Codigo int identity not null,
                Motivo Varchar(800) not null,
                CodigoHistorico int not null,
                DataExclusao datetime not null,
                Constraint ExcluidosPK Primary key (codigo),
                Constraint ExcluidosFK_CodigoHistorico Foreign key (CodigoHistorico) References Historicos(Codigo),
                Constraint Unique_Excluidos_CodigoHistorico unique (CodigoHistorico)
                );
                END
                """;
                _connection.Execute(CREATE_EXCLUIDOS_TABLE_QUERY);
            }
        }

        private void InsertsIniciais()
        {
            {
                var INSERT_TIPOS_DE_MOVIMENTACOES_QUERY =
                """
                IF NOT EXISTS (SELECT * FROM TipoMovimentacoes)
                BEGIN
                INSERT INTO TipoMovimentacoes (Nome) VALUES ('Compra');
                INSERT INTO TipoMovimentacoes (Nome) VALUES ('Impressão');
                INSERT INTO TipoMovimentacoes (Nome) VALUES ('CompraExcluida');
                INSERT INTO TipoMovimentacoes (Nome) VALUES ('ImpressãoExcluida');
                END
                """;
                _connection.Execute(INSERT_TIPOS_DE_MOVIMENTACOES_QUERY);
            }

            {
                var INSERT_PACOTES_QUERY =
                """
                IF NOT EXISTS (SELECT * FROM Pacotes)
                BEGIN
                INSERT INTO Pacotes (Quantidade, Preco) VALUES (25, 5.00);
                INSERT INTO Pacotes (Quantidade, Preco) VALUES (50, 10.00);
                END
                """;
                _connection.Execute(INSERT_PACOTES_QUERY);
            }

        }
    }
}
