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
    public partial class DeletarPacote : UserControl
    {
        public Action? FecharControl;

        private readonly PacoteRepository _pacoteRepository;

        private Pacote? _pacoteSelecionado = null;

        internal DeletarPacote(PacoteRepository pacoteRepository)
        {
            InitializeComponent();
            _pacoteRepository = pacoteRepository;
        }

        public void ResetarConteudo()
        {
            _pacoteSelecionado = null;
            textBoxPacoteADeletar.Text = string.Empty;
            labelErroDiversos.Text = string.Empty;
            buttonDeletar.Enabled = false;
        }


        private void _OnPacoteADeletarKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SelecionarPacote selecionarAluno = new SelecionarPacote(_pacoteRepository, _onReceberpacoteSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarAluno);
                form.ShowDialog();
            }
        }

        private void _onReceberpacoteSelecionado(object pacoteSelecionado)
        {
            _pacoteSelecionado = (Pacote)pacoteSelecionado;
            textBoxPacoteADeletar.Text = _pacoteSelecionado.ToString();
            buttonDeletar.Enabled = true;
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            labelErroDiversos.Text = string.Empty;

            try
            {
                // a fazer ainda

                FecharControl?.Invoke();
            }
            catch (Exception)
            {

            }
        }

        private void textBoxPacoteADeletar_KeyDown(object sender, KeyEventArgs e)
        {
            _OnPacoteADeletarKeyPress(e);
        }

        private void DeletarPacote_KeyDown(object sender, KeyEventArgs e)
        {
            _OnPacoteADeletarKeyPress(e);
        }
    }
}
