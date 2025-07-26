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
    public partial class EditarAluno : UserControl
    {
        public Action? FecharControl;

        private readonly AlunoService _service;

        private Aluno? _alunoSelecionado = null;

        internal EditarAluno(AlunoService service)
        {
            InitializeComponent();
            _service = service;
        }

        public void ResetarConteudo()
        {
            _alunoSelecionado = null;
            textBoxAlunoAEditar.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxMatricula.Text = string.Empty;
            labelEmailErro.Text = string.Empty;
            labelMatriculaErro.Text = string.Empty;
            labelNomeErro.Text = string.Empty;
            labelErroDiversos.Text = string.Empty;
            groupBoxAreaDeEdicao.Enabled = false;
            buttonEditarOK.Enabled = false;
        }


        private void EditarAluno_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoAEditarKeyPress(e);
        }

        private void textBoxAlunoAEditar_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoAEditarKeyPress(e);
        }

        private void _OnAlunoAEditarKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SelecionarAluno selecionarAluno = new SelecionarAluno(_service, _onReceberAlunoSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarAluno);
                form.ShowDialog();
            }
        }

        private void _onReceberAlunoSelecionado(object alunoSelecionado) 
        {
            _alunoSelecionado = (Aluno)alunoSelecionado;
            textBoxAlunoAEditar.Text = alunoSelecionado.ToString();
            textBoxNome.Text = _alunoSelecionado.Nome;
            textBoxEmail.Text = _alunoSelecionado.Email;
            textBoxMatricula.Text = _alunoSelecionado.Matricula;
            groupBoxAreaDeEdicao.Enabled = true;
            buttonEditarOK.Enabled = true;
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void buttonEditarOK_Click(object sender, EventArgs e)
        {
            labelEmailErro.Text = string.Empty;
            labelMatriculaErro.Text = string.Empty;
            labelNomeErro.Text = string.Empty;
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

    }

}
