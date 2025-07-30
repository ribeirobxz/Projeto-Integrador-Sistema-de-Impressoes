using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Repository;

namespace WinFormsApp1.Controls
{
    public partial class ConsutarSaldos : UserControl
    {
        public Action? FecharControl;

        private AlunoRepository _alunoRepository;

        internal ConsutarSaldos(AlunoRepository alunoRepository)
        {
            InitializeComponent();
            _alunoRepository = alunoRepository;
        }

        public void ResetarConteudo()
        {
            listBoxListagem.Items.Clear();

            listBoxListagem.Items.AddRange(_alunoRepository.SelecionarTodosAlunos()
                .Select(aluno => $"Nome: {aluno.Nome} - Saldo: {aluno.QntdImpressao}").ToArray());
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }
    }
}
