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
    public partial class ConsultarAluno : UserControl
    {
        public Action? FecharControl;

        private readonly AlunoRepository _alunoRepository;

        private Aluno? _alunoSelecionado = null;

        internal ConsultarAluno(AlunoRepository alunoRepository)
        {
            InitializeComponent();
            _alunoRepository = alunoRepository;
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
                SelecionarAluno selecionarAluno = new SelecionarAluno(_alunoRepository, _onReceberAlunoSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarAluno);
                form.ShowDialog();
            }
        }

        private void _onReceberAlunoSelecionado(object alunoSelecionado)
        {
            _alunoSelecionado = (Aluno)alunoSelecionado;
            textBoxAlunoAConsultar.Text = alunoSelecionado.ToString();
            textBoxNome.Text = _alunoSelecionado.Nome;
            textBoxEmail.Text = _alunoSelecionado.Email;
            textBoxMatricula.Text = _alunoSelecionado.Matricula;
            textBoxQuantidade.Text = _alunoSelecionado.QntdImpressao.ToString();
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
