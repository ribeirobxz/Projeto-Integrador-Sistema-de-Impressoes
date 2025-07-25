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
using WinFormsApp1.Service;

namespace WinFormsApp1.Controls
{
    public partial class CadastrarAluno : UserControl
    {
        public Action? FecharControl;
        
        private readonly AlunoService _mockService;

        internal CadastrarAluno(AlunoService service)
        {
            InitializeComponent();
            this._mockService = service;
        }

        public void ResetarConteudo()
        {
            textBoxNome.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxMatricula.Text = string.Empty;
            labelEmailErro.Text = string.Empty;
            labelMatriculaErro.Text = string.Empty;
            labelNomeErro.Text = string.Empty;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = textBoxNome.Text;
                if(string.IsNullOrEmpty(nome))
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
                

                Aluno aluno = new Aluno(0, nome, matricula, email, 0);
                _mockService.AdicionarAluno(aluno);

                FecharControl?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("mostrar mensagem de erro", "titulo");
                // ou mudar os label de erro
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }
    }
}
