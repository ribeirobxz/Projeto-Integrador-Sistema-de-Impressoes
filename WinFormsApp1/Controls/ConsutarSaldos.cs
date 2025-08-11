using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Repository;

namespace WinFormsApp1.Controls
{
    public partial class ConsutarSaldos : UserControl
    {
        public Action? FecharControl;

        private AlunoRepository _alunoRepository;

        internal ConsutarSaldos(AlunoRepository alunoRepository)
        {
            InitializeComponent();
            _alunoRepository = alunoRepository;
        }

        public void ResetarConteudo()
        {
            listBoxListagem.Items.Clear();

            listBoxListagem.Items.AddRange(_alunoRepository.SelecionarTodosAlunos()
                .Select(aluno => $"Nome: {aluno.Nome} - Saldo: {aluno.QntdImpressao}").ToArray());

            splitContainerInfo.Panel2Collapsed = true;
            textBoxInfo.Text = string.Empty;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void listBoxListagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxListagem.SelectedItem != null)
            {
                var objetoPraTerOquePreencherNoTextBox = listBoxListagem.SelectedItem;

                textBoxInfo.Text = "você vai colocar os textos informacionais adicional aqui"; // fazer oque esta escrito no texto.

                splitContainerInfo.Panel2Collapsed = false;
            }
            else 
            {
                splitContainerInfo.Panel2Collapsed = true;
                textBoxInfo.Text = string.Empty;
            }
        }
    }
}
