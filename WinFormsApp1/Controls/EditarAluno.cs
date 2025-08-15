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
    public partial class EditarAluno : UserControl
    {
        public Action? FecharControl;

        private readonly AlunosRepository _alunoRepository;

        private Alunos? _alunoSelecionado = null;

        internal EditarAluno(AlunosRepository alunoRepository)
        {
            InitializeComponent();
            _alunoRepository = alunoRepository;
        }

        public void ResetarConteudo()
        {
            _alunoSelecionado = null;
            textBoxAlunoAEditar.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxTelefone.Text = string.Empty;
            textBoxMatricula.Text = string.Empty;
            labelTelefoneErro.Text = string.Empty;
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
                SelecionarAluno selecionarAluno = new SelecionarAluno(_alunoRepository, _onReceberAlunoSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarAluno);
                form.ShowDialog();
            }
        }

        private void _onReceberAlunoSelecionado(object alunoSelecionado) 
        {
            _alunoSelecionado = (Alunos)alunoSelecionado;
            textBoxAlunoAEditar.Text = _alunoSelecionado.ToString();
            textBoxNome.Text = _alunoSelecionado.Nome;
            textBoxTelefone.Text = _alunoSelecionado.NunTelefone;
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
            labelNomeErro.Text = string.Empty;
            labelTelefoneErro.Text = string.Empty;
            labelMatriculaErro.Text = string.Empty;
            labelErroDiversos.Text = string.Empty;

            string nome = textBoxNome.Text;
            if (string.IsNullOrEmpty(nome) || nome.Length < 2)
            {
                labelNomeErro.Text = "O nome tem que ter pelo menos 3 letras.";
                return;
            }

            string matricula = textBoxMatricula.Text;
            if (string.IsNullOrEmpty(matricula))
            {
                labelMatriculaErro.Text = "A matrícula não pode ser vazia.";
                return;
            }

            string telefone = textBoxTelefone.Text;
            var telefoneArr = telefone.ToCharArray();
            if (telefoneArr.Length > 5)
            {
                telefoneArr[4] = '_';
            }
            string telefoneTest = String.Concat(telefoneArr);
            if (string.IsNullOrEmpty(telefone) || telefoneTest.Contains(' '))
            {
                labelTelefoneErro.Text = "O telefone deve ser válido.";
                return;
            }

            try
            {
                _alunoSelecionado.Nome = textBoxNome.Text;
                _alunoSelecionado.NunTelefone = textBoxTelefone.Text;
                _alunoSelecionado.Matricula = textBoxMatricula.Text;

                _alunoRepository.AtualizarAluno(_alunoSelecionado);

                FecharControl?.Invoke();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unique_Alunos_Nome"))
                {
                    labelNomeErro.Text = "Esse nome ja esta cadastrado.";
                    return;
                }
                else if (ex.Message.Contains("Unique_Alunos_Matricula"))
                {
                    labelMatriculaErro.Text = "Essa matricula ja esta cadastrada.";
                    return;
                }
                else if (ex.Message.Contains("Unique_Alunos_NunTelefone"))
                {
                    labelTelefoneErro.Text = "Esse telefone ja esta cadastrado.";
                    return;
                }
                else
                {
                    labelErroDiversos.Text = "Um erro não esparado aconteceu: " + ex.Message;
                }
            }
        }

    }

}
