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
    public partial class ComprarImpressao : UserControl
    {
        public Action? FecharControl;


        private readonly AlunoRepository _alunoRepository;

        private readonly PacoteRepository _pacoteRepository;

        private readonly object _comprarRepository; // mudar para o type correto

        private Aluno? _alunoSelecionado = null;

        internal ComprarImpressao(AlunoRepository alunoRepository, PacoteRepository pacoteRepository, object comprarRepository)
        {
            InitializeComponent();
            _comprarRepository = comprarRepository;
            _alunoRepository = alunoRepository;
            _pacoteRepository = pacoteRepository;
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
                // aluno em _alunoSelecionado
                // e os pacotes estão em listBoxPacotes.Items

                // fazer a inserção no banco de dados aqui
                //_comprarRepository.
                // nas tabelas Compras / Historico / PacotesCompras 

                FecharControl?.Invoke();
            }
            catch (Exception)
            {
                // colocar erros de inserção aqui
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
            _alunoSelecionado = (Aluno)alunoSelecionado;
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
            if (listBoxPacotes.Items.Contains(conteudo))
            {
                return false;
            }

            listBoxPacotes.Items.Add(conteudo);
            
            int quantidadeTotal = 0; // calcular
            decimal valorTotal = 0; // calcular

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
