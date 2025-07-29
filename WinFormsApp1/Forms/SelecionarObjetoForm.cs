using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.SelecionarObjeto;

namespace WinFormsApp1.Forms
{
    public partial class SelecionarObjetoForm : Form
    {
        internal SelecionarObjetoForm(ISelecionarObjeto selecionarObjeto)
        {
            InitializeComponent();
            _selecionarObjeto = selecionarObjeto;
            Text = selecionarObjeto.ObterTituloDoForm();
            labelInfo.Text = selecionarObjeto.ObterTextoInformativoDoForm();
        }

        ISelecionarObjeto _selecionarObjeto;

        private void textBoxOqueProcurar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListarobjetosComConteudoDigitado();
            }
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            ListarobjetosComConteudoDigitado();
        }

        private void listBoxListagem_DoubleClick(object sender, EventArgs e)
        {
            RetornarobjetoEscolhido();
        }

        private void listBoxListagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetornarobjetoEscolhido();
            }
        }

        private void ListarobjetosComConteudoDigitado()
        {
            string OqueProcurar = textBoxOqueProcurar.Text;
            listBoxListagem.Items.Clear();
            listBoxListagem.Items.AddRange(_selecionarObjeto.ObterConteudoPesquisado(OqueProcurar));
        }

        private void RetornarobjetoEscolhido()
        {
            if (listBoxListagem.SelectedItem != null)
            {
                _selecionarObjeto.RetornarObjetoEscolhido().Invoke(listBoxListagem.SelectedItem);
                Close();
            }
        }

        private void SelecionarObjetoForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }
    }
}
