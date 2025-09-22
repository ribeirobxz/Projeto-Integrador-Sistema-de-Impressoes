CREATE DATABASE PI_IMPRESSAO;
 
USE PI_IMPRESSAO;
 
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

CREATE TABLE TipoMovimentacoes (
Codigo Tinyint identity not null,
Nome Varchar(20) not null,
CONSTRAINT TipoMovimentacoesPK Primary key (Codigo),
CONSTRAINT Unique_TipoMovimentacoes_Nome UNIQUE (Nome)
);
 
CREATE TABLE Pacotes (
Codigo int identity not null,
Quantidade smallint not null,
Preco decimal(9,2) not null,
Constraint PacotesPK Primary key (Codigo),
Constraint Unique_Pacotes_Quantidade Unique (Quantidade)
);
 
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

CREATE TABLE Excluidos (
Codigo int identity not null,
Motivo Varchar(800) not null,
CodigoHistorico int not null,
DataExclusao datetime not null,
Constraint ExcluidosPK Primary key (codigo),
Constraint ExcluidosFK_CodigoHistorico Foreign key (CodigoHistorico) References Historicos(Codigo),
Constraint Unique_Excluidos_CodigoHistorico unique (CodigoHistorico)
);

