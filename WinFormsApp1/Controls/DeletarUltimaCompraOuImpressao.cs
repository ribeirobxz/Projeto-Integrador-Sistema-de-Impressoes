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
    public partial class DeletarUltimaCompraOuImpressao : UserControl
    {
        public Action? FecharControl;

        private readonly RepositoryContext _repositoryContext;

        private Alunos? _alunoSelecionado = null;

        private Historicos? ObjReferencia = null;

        internal DeletarUltimaCompraOuImpressao(RepositoryContext repositoryContext)
        {
            InitializeComponent();
            _repositoryContext = repositoryContext;
        }

        public void ResetarConteudo()
        {
            _alunoSelecionado = null;
            textBoxAlunoEscolhido.Text = string.Empty;
            textBoxMotivo.Text = string.Empty;
            textBoxUltimoHistorico.Text = string.Empty;
            buttonDeletar.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMotivo.Text.Length <= 3)
                {
                    MessageBox.Show("O texto do motivo tem que ter mais de 3 caracteres!", "Aviso");
                    return;
                }
                //consuta impressão
                var impressao = _repositoryContext.ImpressoesRepository.SelecionarPorCodigoHistorico(ObjReferencia?.Codigo ?? 0);

                //deleta impressão se tiver
                _repositoryContext.ImpressoesRepository.RemoverImpressaoPorCodigoHistorico(ObjReferencia?.Codigo ?? 0);

                //consulta impressão
                var compra = _repositoryContext.ComprasRepository.SelecionarPorCodigoHistorico(ObjReferencia?.Codigo ?? 0);

                //deleta pacote comprados
                _repositoryContext.PacotesCompradosRepository.RemoverPacoteCompradoPorCodigoCompra(compra?.Codigo ?? 0);

                //deleta compra
                _repositoryContext.ComprasRepository.RemoverCompraPorCodigoHistorico(ObjReferencia?.Codigo ?? 0);

                Excluidos excluidos = new Excluidos(0, ObjReferencia?.Codigo ?? 0, textBoxMotivo.Text, DateTime.Now);

                if (impressao != null)
                {
                    ObjReferencia.CodigoTipoMovimentacao = _repositoryContext.TipoMovimentacoesRepository.SelecionarPorNome("ImpressãoExcluida")?.Codigo ?? 0;
                }
                else if (compra != null)
                {

                    ObjReferencia.CodigoTipoMovimentacao = _repositoryContext.TipoMovimentacoesRepository.SelecionarPorNome("CompraExcluida")?.Codigo ?? 0;
                }
                else 
                {
                    ObjReferencia.CodigoTipoMovimentacao = _repositoryContext.TipoMovimentacoesRepository.SelecionarPorNome("Excluido")?.Codigo ?? 0;
                }

                var aluno = _repositoryContext.AlunosRepository.SelecionarAlunoPorCodigo(ObjReferencia.CodigoAluno);
                aluno.QntdImpressao = ObjReferencia.SaldoAntes;

                _repositoryContext.AlunosRepository.AtualizarAluno(aluno);

                _repositoryContext.ExcluidosRepository.Adicionar(excluidos);

                _repositoryContext.HistoricosRepository.AtualizarHistorico(ObjReferencia);

                 FecharControl?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro:");
            }
        }

        private void textBoxAlunoEscolhido_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoAEscolherKeyPress(e);
        }

        private void DeletarUltimaCompra_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoAEscolherKeyPress(e);
        }

        private void _OnAlunoAEscolherKeyPress(KeyEventArgs e)
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

            // com o aluno consulta o historico valido, verificar se é do tipo compra ou impressão, caso sim preencher o texto de historico
            // caso não for do tipo compra ou impressão, não habilitar o botão de deletar, e colocar um aviso no historio, dizendo que não da pra deletar.

            ObjReferencia = _repositoryContext.HistoricosRepository.UltimoHistoricoValido();

            if (ObjReferencia != null)
            {
                var tipoDeMovimentacao = _repositoryContext.TipoMovimentacoesRepository.SelecionarPorCodigo(ObjReferencia.CodigoTipoMovimentacao);
                textBoxUltimoHistorico.Text = PegarMaisInformacoes(new VisualizarHistorico()
                {
                    Codigo = ObjReferencia.Codigo,
                    CodigoTipoMovimentacao = ObjReferencia.CodigoTipoMovimentacao,
                    CodigoAluno = ObjReferencia.CodigoAluno,
                    DataHistorico = ObjReferencia.DataHistorico,
                    QntdTotal = ObjReferencia.QntdTotal,
                    SaldoAntes = ObjReferencia.SaldoAntes,
                    SaldoDepois = ObjReferencia.SaldoDepois,
                    ValorTotalPago = ObjReferencia.ValorTotalPago,
                    NomeTipoMovimentacoes = tipoDeMovimentacao.Nome
                });
                buttonDeletar.Enabled = true;
            }
            else 
            {
                textBoxUltimoHistorico.Text = "Não existe mais registros para serem deletados!";
                buttonDeletar.Enabled = false;
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

                return compraInformacoes;
            }

            var impressaoInformacoes = $"""
                    Data: {visualizarHistorico.DataHistorico}
                    Tipo de movimentação: {(visualizarHistorico.NomeTipoMovimentacoes.ToLower().Contains("excl") ? "Impressão Excluída" : "Impressão")}
                    Quantidade total: {visualizarHistorico.QntdTotal}
                    Saldo de impressões antes: {visualizarHistorico.SaldoAntes}
                    Saldo de impressões depois: {visualizarHistorico.SaldoDepois}

                    """;

            return impressaoInformacoes;
        }

    }
}
