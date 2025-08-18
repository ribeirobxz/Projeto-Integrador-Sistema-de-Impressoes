using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Context;
using WinFormsApp1.Forms;
using WinFormsApp1.Model;
using WinFormsApp1.Model.Historic;
using WinFormsApp1.Repository;
using WinFormsApp1.SelecionarObjeto;

namespace WinFormsApp1.Controls
{
    public partial class DeletarUltimaCompraOuImpressao : UserControl
    {
        public Action? FecharControl;

        private readonly RepositoryContext _repositoryContext;

        private Alunos? _alunoSelecionado = null;

        private Historicos? ObjReferencia = null;

        internal DeletarUltimaCompraOuImpressao(RepositoryContext repositoryContext)
        {
            InitializeComponent();
            _repositoryContext = repositoryContext;
        }

        public void ResetarConteudo()
        {
            _alunoSelecionado = null;
            textBoxAlunoEscolhido.Text = string.Empty;
            textBoxMotivo.Text = string.Empty;
            textBoxUltimoHistorico.Text = string.Empty;
            buttonDeletar.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                // ------- TEM QUE FAZER AINDA


                // fazer as coisas do banco de dados aqui
                //remover da tabela compras e adicionar a justificativa em motivodeExclusão

                //voce vai usar a variavel _compraDePacoteASerDeletada aqui.

                FecharControl?.Invoke();
            }
            catch (Exception)
            {
                // tratar os erros aqui
            }
        }

        private void textBoxAlunoEscolhido_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoAEscolherKeyPress(e);
        }

        private void DeletarUltimaCompra_KeyDown(object sender, KeyEventArgs e)
        {
            _OnAlunoAEscolherKeyPress(e);
        }

        private void _OnAlunoAEscolherKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SelecionarAluno selecionarAluno = new SelecionarAluno(_repositoryContext.AlunosRepository, _onReceberAlunoSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarAluno);
                form.ShowDialog();
            }
        }

        private void _onReceberAlunoSelecionado(object alunoSelecionado)
        {
            _alunoSelecionado = (Alunos)alunoSelecionado;
            textBoxAlunoEscolhido.Text = _alunoSelecionado.ToString();

            // com o aluno consulta o historico valido, verificar se é do tipo compra ou impressão, caso sim preencher o texto de historico
            // caso não for do tipo compra ou impressão, não habilitar o botão de deletar, e colocar um aviso no historio, dizendo que não da pra deletar.

            ObjReferencia = _repositoryContext.HistoricosRepository.UltimoHistoricoValido();

            if (ObjReferencia != null)
            {
                textBoxUltimoHistorico.Text = ObjReferencia.ToString();
                buttonDeletar.Enabled = true;
            }
            else 
            {
                textBoxUltimoHistorico.Text = "Não existe mais registros para serem deletados!";
                buttonDeletar.Enabled = false;
            }
        }

    }
}
