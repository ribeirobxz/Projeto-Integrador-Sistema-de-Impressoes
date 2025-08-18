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
    public partial class ConsultarPacotes : UserControl
    {
        public Action? FecharControl;

        private readonly PacotesRepository _pacoteRepository;

        private Pacotes? _pacoteSelecionado;

        internal ConsultarPacotes(PacotesRepository pacoteRepository)
        {
            InitializeComponent();
            _pacoteRepository = pacoteRepository;
        }

        public void ResetarConteudo()
        {
            _pacoteSelecionado = null;
            textBoxPacoteAConsultar.Text = string.Empty;
            numericUpDownPreço.Value = 0;
            numericUpDownQuantidade.Value = 0;
        }


        private void _OnPacoteAConsultarKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SelecionarPacote selecionarPacote = new SelecionarPacote(_pacoteRepository, _onReceberPacoteSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarPacote);
                form.ShowDialog();
            }
        }

        private void _onReceberPacoteSelecionado(object pacoteSelecionado)
        {
            _pacoteSelecionado = (Pacotes)pacoteSelecionado;
            textBoxPacoteAConsultar.Text = _pacoteSelecionado.ToString();
            numericUpDownPreço.Value = _pacoteSelecionado.Preco;
            numericUpDownQuantidade.Value = _pacoteSelecionado.Quantidade;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void ConsultarPacotes_KeyDown(object sender, KeyEventArgs e)
        {
            _OnPacoteAConsultarKeyPress(e);
        }

        private void textBoxPacoteAConsultar_KeyDown(object sender, KeyEventArgs e)
        {
            _OnPacoteAConsultarKeyPress(e);
        }
    }
}
