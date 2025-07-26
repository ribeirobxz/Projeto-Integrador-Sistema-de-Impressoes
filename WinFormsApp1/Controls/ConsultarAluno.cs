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
using WinFormsApp1.Service;

namespace WinFormsApp1.Controls
{
    public partial class ConsultarAluno : UserControl
    {
        public Action? FecharControl;

        private readonly AlunoService _service;

        private Aluno? _alunoSelecionado = null;

        internal ConsultarAluno(AlunoService service)
        {
            InitializeComponent();
            _service = service;
        }

        public void ResetarConteudo()
        {
            _alunoSelecionado = null;
            textBoxAlunoAConsultar.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxMatricula.Text = string.Empty;
            textBoxQuantidade.Text = string.Empty;
        }


        private void _OnAlunoAConsultarKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SelecionarAlunoForm form = new SelecionarAlunoForm(_service);
                form._RetornoDoAlunoEscolhido += _onReceberAlunoSelecionado;
                form.ShowDialog();
            }
        }

        private void _onReceberAlunoSelecionado(Aluno alunoSelecionado)
        {
            _alunoSelecionado = alunoSelecionado;
            textBoxAlunoAConsultar.Text = alunoSelecionado.ToString();
            textBoxNome.Text = alunoSelecionado.Nome;
            textBoxEmail.Text = alunoSelecionado.Email;
            textBoxMatricula.Text = alunoSelecionado.Matricula;
            textBoxQuantidade.Text = alunoSelecionado.QntdImpressao.ToString();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void textBoxAlunoAConsultar_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoAConsultarKeyPress(e);
        }

        private void ConsultarAluno_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoAConsultarKeyPress(e);
        }
    }
}
