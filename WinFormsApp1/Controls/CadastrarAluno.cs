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
        
        private readonly AlunosRepository _alunoRepository;

        internal CadastrarAluno(AlunosRepository alunoRepository)
        {
            InitializeComponent();
            this._alunoRepository = alunoRepository;
        }

        public void ResetarConteudo()
        {
            textBoxNome.Text = string.Empty;
            textBoxTelefone.Text = string.Empty;
            textBoxMatricula.Text = string.Empty;
            labelErroDiversos.Text = string.Empty;
            labelTelefoneErro.Text = string.Empty;
            labelMatriculaErro.Text = string.Empty;
            labelNomeErro.Text = string.Empty;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
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
            if (telefoneArr.Length >= 15)
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
                var aluno = new Alunos(0, nome, matricula, telefone, 0);
                _alunoRepository.AdicionarAluno(aluno);

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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }
    }
}
