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
using WinFormsApp1.SelecionarObjeto;
using WinFormsApp1.Service;

namespace WinFormsApp1.Controls
{
    public partial class EditarPacote : UserControl
    {
        public Action? FecharControl;

        private readonly PacoteService _service;

        private Pacote? _pacoteSelecionado;

        internal EditarPacote(PacoteService service)
        {
            InitializeComponent();
            _service = service;
        }

        public void ResetarConteudo()
        {
            _pacoteSelecionado = null;
            textBoxPacoteAEditar.Text = string.Empty;
            numericUpDownPreço.Value = 0;
            labelPrecoErro.Text = string.Empty;
            labelErroDiversos.Text = string.Empty;
            groupBoxAreaDeEdicao.Enabled = false;
            buttonEditarOK.Enabled = false;
        }


        private void _OnPacoteAEditarKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SelecionarPacote selecionarPacote = new SelecionarPacote(_service, _onReceberPacoteSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarPacote);
                form.ShowDialog();
            }
        }

        private void _onReceberPacoteSelecionado(object pacoteSelecionado)
        {
            _pacoteSelecionado = (Pacote)pacoteSelecionado;
            textBoxPacoteAEditar.Text = _pacoteSelecionado.ToString();
            numericUpDownPreço.Value = _pacoteSelecionado.Preco;
            groupBoxAreaDeEdicao.Enabled = true;
            buttonEditarOK.Enabled = true;
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void buttonEditarOK_Click(object sender, EventArgs e)
        {
            labelPrecoErro.Text = string.Empty;
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

        private void textBoxPacoteAEditar_KeyDown(object sender, KeyEventArgs e)
        {
            _OnPacoteAEditarKeyPress(e);
        }

        private void EditarPacote_KeyDown(object sender, KeyEventArgs e)
        {
            _OnPacoteAEditarKeyPress(e);
        }
    }
}
