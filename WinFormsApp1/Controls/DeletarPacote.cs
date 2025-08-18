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

        private readonly PacotesRepository _pacoteRepository;

        private Pacotes? _pacoteSelecionado = null;

        internal DeletarPacote(PacotesRepository pacoteRepository)
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
            _pacoteSelecionado = (Pacotes)pacoteSelecionado;
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

            if (_pacoteSelecionado == null)
            {
                labelErroDiversos.Text = "Nenhum pacote selecionado.";
                return;
            }

            try
            {
                _pacoteRepository.RemoverPacote(_pacoteSelecionado.Codigo);
                FecharControl?.Invoke();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PctFK_CodigoPacote"))
                {
                    labelErroDiversos.Text = "Erro: Esse pacote não pode ser deletado, pois está sendo usado!";
                }
                else 
                {
                    labelErroDiversos.Text = "Erro: " + ex.Message;
                }
                
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
