using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;
using WinFormsApp1.Repository;
using WinFormsApp1.SelecionarObjeto;

namespace WinFormsApp1.Forms
{
    public partial class EscolhaDePacoteForm : Form
    {
        private readonly PacoteRepository _pacoteRepository;
  
        private Func<object, bool>? _conteudoEscolhido; // mude o obj pela classe que representa o objeto

        private Pacote? _pacoteSelecionado = null;

        internal EscolhaDePacoteForm(PacoteRepository pacoteRepository, Func<object, bool> conteudoEscolhido)
        {
            InitializeComponent();
            _pacoteRepository = pacoteRepository;
            _conteudoEscolhido = conteudoEscolhido;
        }

        private void textBoxPacoteEscolhido_KeyDown(object sender, KeyEventArgs e)
        {
            _OnPacoteEscolherKeyPress(e);
        }

        private void EscolhaDePacoteForm_KeyDown(object sender, KeyEventArgs e)
        {
            _OnPacoteEscolherKeyPress(e);

            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            var obj = new CompraImpressao(_pacoteSelecionado, (int) numericUpDownMultiplicador.Value);

            if (_conteudoEscolhido?.Invoke(obj) == true)
            {
                Close();
            }
            else 
            {
                MessageBox.Show("Você já fez a insersão desse pacote na listagem, remova-o e ensina novamente para mudar a quantidade de pacotes!", "Aviso:");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _OnPacoteEscolherKeyPress(KeyEventArgs e)
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
            _pacoteSelecionado = (Pacote)pacoteSelecionado;
            textBoxPacoteEscolhido.Text = _pacoteSelecionado.ToString();
            buttonAdicionar.Enabled = true;
        }
    }
}
