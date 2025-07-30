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

        internal ConsultarHistoricos(AlunoRepository alunoRepository, object historicoRepository)
        {
            InitializeComponent();
            _alunoRepository = alunoRepository;
            _historicoRepository = historicoRepository;
        }

        public void ResetarConteudo()
        {
            listBoxListagem.Items.Clear();
            textBoxAlunoEscolhido.Text = string.Empty;
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
            listBoxListagem.Items.Clear();

            textBoxAlunoEscolhido.Text = alunoSelecionado.ToString();

            // fazer consulta da listagem de historico e colocar no list box

            listBoxListagem.Items.AddRange(new string[] { "apagar isso e colar o conteudo consulta aqui"});

        }
    }
}
