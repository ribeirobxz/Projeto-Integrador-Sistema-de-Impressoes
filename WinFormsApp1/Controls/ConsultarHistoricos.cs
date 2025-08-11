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
    public partial class ConsultarHistoricos : UserControl
    {
        public Action? FecharControl;

        private readonly AlunoRepository _alunoRepository;

        private readonly object _historicoRepository; // mudar para o type correto

        private Aluno? _alunoSelecionado = null;

        internal ConsultarHistoricos(AlunoRepository alunoRepository, object historicoRepository)
        {
            InitializeComponent();
            _alunoRepository = alunoRepository;
            _historicoRepository = historicoRepository;
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
                SelecionarAluno selecionarAluno = new SelecionarAluno(_alunoRepository, _onReceberAlunoSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarAluno);
                form.ShowDialog();
            }
        }

        private void _onReceberAlunoSelecionado(object alunoSelecionado)
        {
            _alunoSelecionado = (Aluno)alunoSelecionado;
            textBoxAlunoEscolhido.Text = _alunoSelecionado.ToString();

            PrencheListagem();
        }

        private void listBoxListagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxListagem.SelectedItem != null)
            {
                var objetoPraTerOquePreencherNoTextBox = listBoxListagem.SelectedItem;

                textBoxHistoricoInfo.Text = "você vai colocar os textos informacionais adicional aqui"; // fazer oque esta escrito no texto.

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

        private void PrencheListagem()
        {
            // a listagem muda ao selecionar o aluno ou mudar os check box, para mudar isso, (fazer algo diferente)
            // no lugar podemos colocar um botão "consultar", dai so muda o conteudo da listagem quando clicar no botão

            bool ehTodos = radioButtonTodos.Checked;
            bool ehSoCompras = radioButtonCompras.Checked;
            bool ehSoImpressoes = radioButtonImpressoes.Checked;

            // fazer consulta da listagem de historico e colocar no list box

            listBoxListagem.Items.Clear();

            if (ehTodos)
            {
                listBoxListagem.Items.AddRange(new string[] { "apagar isso e colar o conteudo consulta aqui (ehTodos)" });
            }
            else if (ehSoCompras)
            {
                listBoxListagem.Items.AddRange(new string[] { "apagar isso e colar o conteudo consulta aqui (ehSoCompras)" });
            }
            else if (ehSoImpressoes)
            {
                listBoxListagem.Items.AddRange(new string[] { "apagar isso e colar o conteudo consulta aqui (ehSoImpressoes)" });
            }
        }
    }
}
