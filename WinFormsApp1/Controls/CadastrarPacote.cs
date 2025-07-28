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

namespace WinFormsApp1.Controls
{
    public partial class CadastrarPacote : UserControl
    {
        public Action? FecharControl;

        private readonly PacoteRepository _pacoteRepository;

        internal CadastrarPacote(PacoteRepository pacoteRepository)
        {
            InitializeComponent();
            _pacoteRepository = pacoteRepository;
        }

        public void ResetarConteudo()
        {
            numericUpDownPreço.Value = 0;
            numericUpDownQuantidade.Value = 0;
            labelErroDiversos.Text = string.Empty;
            labelPrecoErro.Text = string.Empty;
            labelQuantidadeErro.Text = string.Empty;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            labelPrecoErro.Text = string.Empty;
            labelQuantidadeErro.Text = string.Empty;
            labelErroDiversos.Text = string.Empty;

            decimal quantidade = numericUpDownQuantidade.Value;
            decimal preco = numericUpDownPreço.Value;

            try
            {
                // fazer criação aqui
                
                FecharControl?.Invoke();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("????"))
                {
                    labelPrecoErro.Text = "????.";
                    return;
                }
                else if (ex.Message.Contains("???"))
                {
                    labelQuantidadeErro.Text = "?????.";
                    return;
                }
                else
                {
                    labelErroDiversos.Text = "Um erro não esparado aconteceu: " + ex.Message;
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }
    }
}
