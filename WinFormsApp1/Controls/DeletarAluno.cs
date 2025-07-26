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
    public partial class DeletarAluno : UserControl
    {
        public Action? FecharControl;

        private readonly AlunoService _service;

        private Aluno? _alunoSelecionado = null;

        internal DeletarAluno(AlunoService service)
        {
            InitializeComponent();
            _service = service;
        }

        public void ResetarConteudo()
        {
            _alunoSelecionado = null;
            textBoxAlunoADeletar.Text = string.Empty;
            labelErroDiversos.Text = string.Empty;
            buttonDeletar.Enabled = false;
        }


        private void _OnAlunoADeletarKeyPress(KeyEventArgs e)
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
            textBoxAlunoADeletar.Text = _alunoSelecionado.ToString();
            buttonDeletar.Enabled = true;
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
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

        private void DeletarAluno_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoADeletarKeyPress(e);
        }

        private void textBoxAlunoAEditar_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoADeletarKeyPress(e);
        }
    }
}
