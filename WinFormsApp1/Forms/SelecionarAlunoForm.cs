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

namespace WinFormsApp1.Forms
{
    public partial class SelecionarAlunoForm : Form
    {
        public Action<Aluno>? _RetornoDoAlunoEscolhido;

        private readonly AlunoService _service;

        internal SelecionarAlunoForm(AlunoService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void textBoxNomeAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListarAlunosComNomeDigitado();
            }
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            ListarAlunosComNomeDigitado();
        }

        private void listBoxListagem_DoubleClick(object sender, EventArgs e)
        {
            RetornarAlunoEscolhido();
        }

        private void listBoxListagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetornarAlunoEscolhido();
            }
        }

        private void ListarAlunosComNomeDigitado() 
        {
            string nome = textBoxNomeAluno.Text;
            if (nome.Length < 3)
            {
                MessageBox.Show("Você deve digitar um nome com mais de duas letras!","Aviso:");
                return;
            }

            // colocar codigo aqui que lista os alunos
            //_service.
        }

        private void RetornarAlunoEscolhido() 
        {
            //pegar o conteudo do listbox para retornar o aluno
            Aluno aluno = new Aluno(0,"nome","matricula","email",0);

            if (aluno != null)
            {
                _RetornoDoAlunoEscolhido?.Invoke(aluno);
                Close();
            }
        }



    }
}
