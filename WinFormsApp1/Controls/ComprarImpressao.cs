using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Forms;
using WinFormsApp1.Model;
using WinFormsApp1.Model.Historic;
using WinFormsApp1.ModelView;
using WinFormsApp1.Repository;
using WinFormsApp1.SelecionarObjeto;

namespace WinFormsApp1.Controls
{
    public partial class ComprarImpressao : UserControl
    {
        public Action? FecharControl;


        private readonly AlunosRepository _alunoRepository;

        private readonly PacotesRepository _pacoteRepository;
        private readonly TipoMovimentacoesRepository _tipoDeMovimentacaoRepository;
        private readonly HistoricosRepository _historicoRepository;
        private readonly ComprasRepository _compraRepository;
        private readonly PacotesCompradosRepository _comprasPacoteRepository;

        private Alunos? _alunoSelecionado = null;

        internal ComprarImpressao(AlunosRepository alunoRepository, PacotesRepository pacoteRepository, TipoMovimentacoesRepository tipoDeMovimentacaoRepository, HistoricosRepository historicoRepository, 
            ComprasRepository compraRepository, PacotesCompradosRepository comprasPacoteRepository)
        {
            InitializeComponent();
            _alunoRepository = alunoRepository;
            _pacoteRepository = pacoteRepository;
            _tipoDeMovimentacaoRepository = tipoDeMovimentacaoRepository;
            _historicoRepository = historicoRepository;
            _compraRepository = compraRepository;
            _comprasPacoteRepository = comprasPacoteRepository;
        }

        public void ResetarConteudo()
        {
            _alunoSelecionado = null;
            buttonComprar.Enabled = false;
            buttonRemoverPacoteSelecionado.Enabled = false;
            textBoxAlunoEscolhido.Text = "";
            listBoxPacotes.Items.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoDeMovimentacao = _tipoDeMovimentacaoRepository.SelecionarPorNome("Compra");
                var historico = new Historicos(0, tipoDeMovimentacao.Codigo, _alunoSelecionado.Codigo, DateTime.Now, _alunoSelecionado.QntdImpressao);
                
                var comprasPacote = new List<PacotesComprados>();
                foreach (var compraImpressao in listBoxPacotes.Items.Cast<CompraImpressao>())
                {
                short calc = (short)(compraImpressao.Pacote.Quantidade * compraImpressao.Quantidade);
                    _alunoSelecionado.QntdImpressao += calc;
                    historico.QntdTotal = calc;

                    historico.SaldoDepois = _alunoSelecionado.QntdImpressao;
                    historico.ValorTotalPago = compraImpressao.Pacote.Preco * compraImpressao.Quantidade;

                    comprasPacote.Add(new PacotesComprados(0, compraImpressao.Pacote.Codigo, compraImpressao.Quantidade, compraImpressao.Pacote.Preco));

                }
                _historicoRepository.AdicionarHistorico(historico);

                var compra = new Compras(0, _alunoSelecionado.Codigo, historico.Codigo, historico.DataHistorico, (decimal)historico.ValorTotalPago);
                _compraRepository.AdicionarCompra(compra);

                _alunoRepository.AtualizarAluno(_alunoSelecionado);

                foreach (var compraPacote in comprasPacote)
                {
                    compraPacote.CodigoCompra = compra.Codigo;
                    _comprasPacoteRepository.AdicionarPacoteComprado(compraPacote);
                }

                FecharControl?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro:");
            }
        }

        private void ComprarImpressao_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoASelecionarKeyPress(e);
        }

        private void textBoxAlunoEscolhido_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoASelecionarKeyPress(e);
        }

        private void _OnAlunoASelecionarKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SelecionarAluno selecionarAluno = new SelecionarAluno(_alunoRepository, _onReceberAlunoSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarAluno);
                form.ShowDialog();
            }
        }

        private void _onReceberAlunoSelecionado(object alunoSelecionado)
        {
            _alunoSelecionado = (Alunos)alunoSelecionado;
            textBoxAlunoEscolhido.Text = _alunoSelecionado.ToString();

            if (_alunoSelecionado != null && listBoxPacotes.Items.Count > 0)
            {
                buttonComprar.Enabled = true;
            }
        }

        private void listBoxPacotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemoverPacoteSelecionado.Enabled = listBoxPacotes.SelectedItem != null;
        }

        private void buttonAdicionarPacote_Click(object sender, EventArgs e)
        {
            EscolhaDePacoteForm escolhaDePacoteForm = new EscolhaDePacoteForm(_pacoteRepository, PacoteConteudoEscolhido);
            escolhaDePacoteForm.ShowDialog();

            if (_alunoSelecionado != null && listBoxPacotes.Items.Count > 0)
            {
                buttonComprar.Enabled = true;
            }
        }

        private bool PacoteConteudoEscolhido(object conteudo) 
        {
            if (listBoxPacotes.Items.Contains(conteudo)) // deixar assim, pois mudei o equal do objeto so para consideral a quantidade dentro do pacote
            // ou fazer listBoxPacotes.Items.Cast<CompraImpressao>().Where(x => x.Pacote.Quantidade == ((CompraImpressao)conteudo).Pacote.Quantidade) > 0
            // que não usa o equal do objeto
            {
                return false;
            }
            

            listBoxPacotes.Items.Add(conteudo);
            
            int quantidadeTotal = 0;
            decimal valorTotal = 0;

            foreach (var compraImpressao in listBoxPacotes.Items.Cast<CompraImpressao>())
            {
                quantidadeTotal = compraImpressao.Pacote.Quantidade * compraImpressao.Quantidade;
                valorTotal = compraImpressao.Pacote.Preco * compraImpressao.Quantidade;
            }

            labelQuantidadeTotal.Text = $"Quantidade total: {quantidadeTotal} folhas";
            labelValorTotalCompra.Text = $"Valor total da compra: R$: {valorTotal:F2}";

            return true;
        }

        private void buttonRemoverPacoteSelecionado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realemente quer excluir esse pacote da compra?","Reponda a pergunta:",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listBoxPacotes.Items.Remove(listBoxPacotes.SelectedItem);
            }
        }
    }
}
