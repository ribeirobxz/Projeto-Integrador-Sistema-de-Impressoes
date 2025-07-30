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
using WinFormsApp1.Repository;
using WinFormsApp1.SelecionarObjeto;

namespace WinFormsApp1.Controls
{
    public partial class RealizarImpressao : UserControl
    {
        public Action? FecharControl;

        private readonly AlunoRepository _alunoRepository;

        private readonly object _imprimirRepository; // mudar para o type correto

        private Aluno? _alunoSelecionado = null;

        internal RealizarImpressao(AlunoRepository alunoRepository, object imprimirRepository)
        {
            InitializeComponent();
            _alunoRepository = alunoRepository;
            _imprimirRepository = imprimirRepository;
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
                // aluno em _alunoSelecionado

                // fazer a inserção no banco de dados aqui
                //_imprimirRepository.
                // nas tabelas Compras / Historico / PacotesCompras 

                FecharControl?.Invoke();
            }
            catch (Exception)
            {
                // colocar erros de inserção aqui
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
                numericUpDownQuantidade.Value = 1;
                numericUpDownQuantidade.Minimum = 1;
                numericUpDownQuantidade.Maximum = _alunoSelecionado.QntdImpressao; // não vai conseguir colocar um valor maior do que tem disponivel
                numericUpDownQuantidade.Enabled = true;
                buttonImprimir.Enabled = true;
            }
            else
            {
                numericUpDownQuantidade.Value = 0;
                numericUpDownQuantidade.Minimum = 0;
                numericUpDownQuantidade.Maximum = 0;
                numericUpDownQuantidade.Enabled = false;
                buttonImprimir.Enabled = false;
            }
        }
    }
}
