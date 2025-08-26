using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Context;
using WinFormsApp1.Forms;
using WinFormsApp1.Model;
using WinFormsApp1.Model.Historic;
using WinFormsApp1.ModelView;
using WinFormsApp1.Repository;
using WinFormsApp1.SelecionarObjeto;

namespace WinFormsApp1.Controls
{
    public partial class ConsultarHistoricos : UserControl
    {
        public Action? FecharControl;

        private readonly RepositoryContext _repositoryContext;

        private Alunos? _alunoSelecionado = null;

        internal ConsultarHistoricos(RepositoryContext repositoryContext)
        {
            InitializeComponent();
            _repositoryContext = repositoryContext;
        }

        public void ResetarConteudo()
        {
            _alunoSelecionado = null;
            listBoxListagem.Items.Clear();
            textBoxAlunoEscolhido.Text = string.Empty;
            splitContainerInfo.Panel2Collapsed = true;
            textBoxHistoricoInfo.Text = string.Empty;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void ConsultarHistoricos_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoAConsultarKeyPress(e);
        }

        private void textBoxAlunoEscolhido_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoAConsultarKeyPress(e);
        }

        private void _OnAlunoAConsultarKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SelecionarAluno selecionarAluno = new SelecionarAluno(_repositoryContext.AlunosRepository, _onReceberAlunoSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarAluno);
                form.ShowDialog();
            }
        }

        private void _onReceberAlunoSelecionado(object alunoSelecionado)
        {
            _alunoSelecionado = (Alunos)alunoSelecionado;
            textBoxAlunoEscolhido.Text = _alunoSelecionado.ToString();

            PrencheListagem();
        }

        private void listBoxListagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxListagem.SelectedItem != null)
            {
                var historicoSelecionado = listBoxListagem.SelectedItem as VisualizarHistorico;
                textBoxHistoricoInfo.Text = PegarMaisInformacoes(historicoSelecionado);

                splitContainerInfo.Panel2Collapsed = false;
            }
            else
            {
                splitContainerInfo.Panel2Collapsed = true;
                textBoxHistoricoInfo.Text = string.Empty;
            }
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTodos.Checked && _alunoSelecionado != null)
            {
                PrencheListagem();
            }
        }

        private void radioButtonCompras_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCompras.Checked && _alunoSelecionado != null)
            {
                PrencheListagem();
            }
        }

        private void radioButtonImpressoes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonImpressoes.Checked && _alunoSelecionado != null)
            {
                PrencheListagem();
            }
        }

        private void PrencheListagem() // --FEITO
        {

            bool ehTodos = radioButtonTodos.Checked;
            bool ehSoCompras = radioButtonCompras.Checked;
            bool ehSoImpressoes = radioButtonImpressoes.Checked;

            listBoxListagem.Items.Clear();

            if (ehTodos)
            {
                listBoxListagem.Items.AddRange(_repositoryContext.HistoricosRepository.ObterListaDeHistoricoVisualizacaoTodos(_alunoSelecionado.Codigo)?.ToArray() ?? new object[0]);
            }
            else if (ehSoCompras)
            {
                listBoxListagem.Items.AddRange(_repositoryContext.HistoricosRepository.ObterListaDeHistoricoVisualizacaoCompras(_alunoSelecionado.Codigo)?.ToArray() ?? new object[0]);
            }
            else if (ehSoImpressoes)
            {
                listBoxListagem.Items.AddRange(_repositoryContext.HistoricosRepository.ObterListaDeHistoricoVisualizacaoImpressões(_alunoSelecionado.Codigo)?.ToArray() ?? new object[0]);
            }
        }

        private string PegarMaisInformacoes(VisualizarHistorico visualizarHistorico)
        {
            if(visualizarHistorico.NomeTipoMovimentacoes.ToLower().Contains("compra"))
            {
                var compraInformacoes = $"""
                    Data: {visualizarHistorico.DataHistorico}
                    Tipo de movimentação: {(visualizarHistorico.NomeTipoMovimentacoes.ToLower().Contains("excl") ? "Compra Excluída" : "Compra")}
                    Quantidade total: {visualizarHistorico.QntdTotal}
                    Saldo de compra antes: {visualizarHistorico.SaldoAntes}
                    Saldo de compra depois: {visualizarHistorico.SaldoDepois}
                    """;

                if(visualizarHistorico.CodigoExcluido != null)
                {
                    compraInformacoes += $"""
                        Data Exclusão: {((DateTime) visualizarHistorico.DataExclusao).ToString("dd/MM/yyyy")}
                        Motivo da exclusão: {visualizarHistorico.Motivo}
                        """;
                }

                return compraInformacoes;
            }

            var impressaoInformacoes = $"""
                    Data: {visualizarHistorico.DataHistorico}
                    Tipo de movimentação: {(visualizarHistorico.NomeTipoMovimentacoes.ToLower().Contains("excl") ? "Impressão Excluída" : "Impressão")}
                    Quantidade total: {visualizarHistorico.QntdTotal}
                    Saldo de impressões antes: {visualizarHistorico.SaldoAntes}
                    Saldo de impressões depois: {visualizarHistorico.SaldoDepois}

                    """;
            if (visualizarHistorico.CodigoExcluido != null)
            {
                impressaoInformacoes += $"""
                        Data Exclusão: {((DateTime)visualizarHistorico.DataExclusao).ToString("dd/MM/yyyy")}
                        Motivo da exclusão: {visualizarHistorico.Motivo}
                        """;
            }

            return impressaoInformacoes;
        }
    }
}
