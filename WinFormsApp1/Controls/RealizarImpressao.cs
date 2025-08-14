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
using WinFormsApp1.Repository;
using WinFormsApp1.SelecionarObjeto;

namespace WinFormsApp1.Controls
{
    public partial class RealizarImpressao : UserControl
    {
        public Action? FecharControl;

        private readonly AlunoRepository _alunoRepository;

        private readonly HistoricoRepository _historicoRepository;
        private readonly TipoDeMovimentacaoRepository _tipoDeMovimentacaoRepository;
        private readonly ImpressaoRepository _impressaoRepository;

        private Aluno? _alunoSelecionado = null;

        internal RealizarImpressao(AlunoRepository alunoRepository, HistoricoRepository historicoRepository, TipoDeMovimentacaoRepository tipoDeMovimentacaoRepository,
            ImpressaoRepository impressaoRepository)
        {
            InitializeComponent();
            _alunoRepository = alunoRepository;
            _historicoRepository = historicoRepository;
            _tipoDeMovimentacaoRepository = tipoDeMovimentacaoRepository;
            _impressaoRepository = impressaoRepository;
        }

        public void ResetarConteudo()
        {
            _alunoSelecionado = null;
            buttonImprimir.Enabled = false;
            textBoxAlunoEscolhido.Text = string.Empty;
            numericUpDownQuantidade.Value = 0;
            numericUpDownQuantidade.Minimum = 0;
            numericUpDownQuantidade.Maximum = 0;
            numericUpDownQuantidade.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoDeMovimentacao = _tipoDeMovimentacaoRepository.SelecionarPorNome("Impressão");
                var historico = new Historico(0, tipoDeMovimentacao.Codigo, _alunoSelecionado.Codigo, DateTime.Now, _alunoSelecionado.QntdImpressao);

                int quantidade = (int) numericUpDownQuantidade.Value;

                _alunoSelecionado.QntdImpressao -= quantidade;
                _alunoRepository.AtualizarAluno(_alunoSelecionado);

                historico.QntdTotal = quantidade;
                historico.SaldoDepois = _alunoSelecionado.QntdImpressao;
                historico.ValorTotalPago = null;

                _historicoRepository.AdicionarHistorico(historico);

                var impressao = new Impressao(0, _alunoSelecionado.Codigo, historico.Codigo, DateTime.Now, quantidade);
                _impressaoRepository.AdicionarImpressao(impressao);

                FecharControl?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro");
            }
        }

        private void textBoxAlunoEscolhido_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoASelecionarKeyPress(e);
        }

        private void RealizarImpressao_KeyDown(object sender, KeyEventArgs e)
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
            _alunoSelecionado = (Aluno)alunoSelecionado;
            textBoxAlunoEscolhido.Text = _alunoSelecionado.ToString();

            if (_alunoSelecionado.QntdImpressao > 0)
            {
                numericUpDownQuantidade.Minimum = 1;
                numericUpDownQuantidade.Maximum = _alunoSelecionado.QntdImpressao; // não vai conseguir colocar um valor maior do que tem disponivel
                numericUpDownQuantidade.Value = 1;
                numericUpDownQuantidade.Enabled = true;
                buttonImprimir.Enabled = true;
            }
            else
            { 
                numericUpDownQuantidade.Minimum = 0;
                numericUpDownQuantidade.Maximum = 0;
                numericUpDownQuantidade.Value = 0;
                numericUpDownQuantidade.Enabled = false;
                buttonImprimir.Enabled = false;
            }
        }
    }
}
