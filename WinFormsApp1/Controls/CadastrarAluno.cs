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
        
        private MockService service;

        internal CadastrarAluno(MockService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = textBoxNome.Text;
                // fazer validações aqui
                string email = textBoxEmail.Text;
                // fazer validações aqui
                string matricula = textBoxMatricula.Text;
                // fazer validações aqui

                Aluno aluno = new Aluno(0, nome, matricula, email, 0);
                service.AdicionarAluno(aluno);

                //se der tudo certo fecha isso, caso contrario cai no cath, ou dar return no metodo
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
