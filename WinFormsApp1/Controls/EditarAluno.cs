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
                SelecionarAlunoForm form = new SelecionarAlunoForm(_service);
                form._RetornoDoAlunoEscolhido += _onReceberAlunoSelecionado;
                form.ShowDialog();
            }
        }

        private void _onReceberAlunoSelecionado(Aluno alunoSelecionado) 
        {
            _alunoSelecionado = alunoSelecionado;
            textBoxAlunoAEditar.Text = alunoSelecionado.ToString();
            textBoxNome.Text = alunoSelecionado.Nome;
            textBoxEmail.Text = alunoSelecionado.Email;
            textBoxMatricula.Text = alunoSelecionado.Matricula;
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
