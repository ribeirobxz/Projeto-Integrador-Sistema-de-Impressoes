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

        private readonly PacotesRepository _pacoteRepository;

        internal CadastrarPacote(PacotesRepository pacoteRepository)
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

            short quantidade = (short)numericUpDownQuantidade.Value;
            decimal preco = numericUpDownPreço.Value;

            try
            {
                var pacote = new Pacotes(0, quantidade, preco);
                _pacoteRepository.AdicionarPacote(pacote);

                FecharControl?.Invoke();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("????"))
                {
                    labelPrecoErro.Text = "????.";
                    return;
                }
                else if (ex.Message.Contains("Unique_Pacotes_Quantidade"))
                {
                    labelQuantidadeErro.Text = "Já existe um pacote cadastrado com essa quantidade.";
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
