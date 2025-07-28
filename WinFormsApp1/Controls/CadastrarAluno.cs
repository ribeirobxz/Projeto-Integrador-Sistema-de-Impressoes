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
    public partial class CadastrarAluno : UserControl
    {
        public Action? FecharControl;
        
        private readonly AlunoRepository _alunoRepository;

        internal CadastrarAluno(AlunoRepository alunoRepository)
        {
            InitializeComponent();
            this._alunoRepository = alunoRepository;
        }

        public void ResetarConteudo()
        {
            textBoxNome.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxMatricula.Text = string.Empty;
            labelErroDiversos.Text = string.Empty;
            labelEmailErro.Text = string.Empty;
            labelMatriculaErro.Text = string.Empty;
            labelNomeErro.Text = string.Empty;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            labelNomeErro.Text = string.Empty;
            labelEmailErro.Text = string.Empty;
            labelMatriculaErro.Text = string.Empty;
            labelErroDiversos.Text = string.Empty;

            string nome = textBoxNome.Text;
            if (string.IsNullOrEmpty(nome))
            {
                labelNomeErro.Text = "O nome não pode ser vazio.";
                return;
            }

            string matricula = textBoxMatricula.Text;
            if (string.IsNullOrEmpty(matricula))
            {
                labelMatriculaErro.Text = "A matrícula não pode ser vazia.";
                return;
            }

            string email = textBoxEmail.Text;
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                labelEmailErro.Text = "O email deve ser válido.";
                return;
            }

            try
            {
                var aluno = new Aluno(0, nome, matricula, email, 0);
                _alunoRepository.AdicionarAluno(aluno);

                FecharControl?.Invoke();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unique_Aluno_Nome"))
                {
                    labelNomeErro.Text = "Esse nome ja esta cadastrado.";
                    return;
                }
                else if (ex.Message.Contains("Unique_Aluno_Matricula"))
                {
                    labelMatriculaErro.Text = "Essa matricula ja esta cadastrada.";
                    return;
                }
                else if (ex.Message.Contains("Unique_Aluno_Email"))
                {
                    labelEmailErro.Text = "Esse email ja esta cadastrado.";
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
