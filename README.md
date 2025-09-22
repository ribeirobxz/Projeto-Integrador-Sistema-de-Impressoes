# Projeto Integrador: Sistema de Impressões

Sistema de gerenciamento de impressões, desenvolvido em C#, com interface WinForms, para controle de filas de impressão, usuários, permissões e monitoramento.

---

## 📄 Índice

1. [Descrição](#descrição)
2. [Funcionalidades](#funcionalidades)
3. [Tecnologias](#tecnologias)
4. [Estrutura do Projeto](#estrutura-do-projeto)
5. [Instalação e Uso](#instalação-e-uso)
6. [Banco de Dados](#banco-de-dados)
8. [Possíveis Melhorias](#possíveis-melhorias)
9. [Contribuição](#contribuição)

---

## Descrição

Este projeto é um sistema de impressões cujo objetivo é:

* Gerenciar requisições de impressão em um ambiente controlado.
* Permitir que usuários solicitem impressões e administrem permissões.
* Monitorar quantas páginas foram impressas, possibilitar controle de cota ou restrições.
* Registrar histórico de impressões para auditoria.

A interface gráfica é feita em **WinForms**, sendo uma aplicação desktop, provavelmente pensando em uso interno de empresas, escolas ou organizações.

---

## Funcionalidades

* Autenticação de usuário (login).
* Interface gráfica em WinForms para submissão e gerenciamento de tarefas de impressão.
* Banco de dados para armazenar usuários, tipos de impressão, histórico.
* Geração de consultas SQL (há um arquivo `SQLQuery2.sql`) para preparação do banco de dados.
* Possibilidade de configurar impressoras, escolher entre impressoras disponíveis.
* Visualização de histórico de impressões.

---

## Tecnologias

* Linguagem: **C#** ([GitHub][1])
* Plataforma: Windows Forms (WinForms) ([GitHub][1])
* IDE provável: Visual Studio ou equivalente.
* Banco de dados: via scripts SQL (não identifiquei se é SQL Server, SQLite ou outro, o script SQL está presente no repositório `SQLQuery2.sql`) ([GitHub][1])

---

## Estrutura do Projeto

Estrutura observada no repositório:

```
/ Projeto‑Integrador‑Sistema‑de‑Impressoes
├── WinFormsApp1/
│   ├── Formulários e telas WinForms
│   ├── Lógica de backend (classes C#)
│   ├── Conexão com banco de dados
│   └── Recursos visuais (imagens, ícones etc.)
├── SQLQuery2.sql        # Script de criação/preparação do banco de dados
├── WinFormsApp1.sln     # Solução do Visual Studio
├── .gitignore
└── .gitattributes
```

---

## Instalação e Uso

Siga estes passos para rodar o sistema em sua máquina:

1. **Clonar o repositório**

   ```bash
   git clone https://github.com/ribeirobxz/Projeto-Integrador-Sistema-de-Impressoes.git
   ```

2. **Abrir no Visual Studio**

   * Abrir o arquivo `.sln` (solução) “WinFormsApp1.sln”.

3. **Configurar banco de dados**

   * Executar o script `SQLQuery2.sql` em seu gerenciador de banco de dados (pode ser SQL Server ou outro compatível).
   * Ajustar connection string no código para apontar para seu servidor de banco e database.
   * Verificar se usuário e senha estão corretos.

4. **Construir e executar**

   * Compilar o projeto: Build Solution.
   * Executar (F5 ou Executar sem depurar).
   * Fazer login com credenciais de administrador (caso haja).

5. **Testar funcionalidades**

   * Criar usuário, fazer solicitação de impressão, ver histórico, etc.

---

## Banco de Dados

* O script `SQLQuery2.sql` contém as instruções para a criação das tabelas necessárias. ([GitHub][1])
* As tabelas devem contemplar: usuários, registros de impressão, possivelmente tipos ou configurações de impressão.
* Certifique-se de conceder permissões adequadas de leitura/gravação para a aplicação.

---

## Possíveis Melhorias

Algumas ideias para evoluções do sistema:

* Melhorar tratamento de erros e mensagens de feedback ao usuário.
* Incluir logs mais completos (arquivo de log, níveis de log etc.).
* Permitir que administradores definam cotas por usuário (número de páginas permitidas).
* Adicionar suporte a impressão em rede ou servidores de impressão remota.
* Melhorar UI/UX com layout mais moderno ou responsivo (mesmo em desktop).
* Gerar relatórios PDF exportáveis.
* Internacionalização (suporte a múltiplos idiomas, se necessário).

---

## Contribuição

Se quiser contribuir:

* Faça um fork do repositório.
* Crie uma branch para sua feature ou correção (`git checkout -b minha-feature`).
* Faça commit das suas alterações.
* Envie um pull request descrevendo suas mudanças.

[1]: https://github.com/ribeirobxz/Projeto-Integrador-Sistema-de-Impressoes "GitHub - ribeirobxz/Projeto-Integrador-Sistema-de-Impressoes"
