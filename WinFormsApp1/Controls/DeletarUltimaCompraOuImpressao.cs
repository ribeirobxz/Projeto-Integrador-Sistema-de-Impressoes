using Microsoft.Extensions.Logging.Abstractions;
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
    public partial class DeletarUltimaCompraOuImpressao : UserControl
    {
        public Action? FecharControl;

        private readonly AlunoRepository _alunoRepository;

        private readonly object _comprarRepository; // mudar para o type correto

        private Aluno? _alunoSelecionado = null;

        private object? _compraDePacoteASerDeletada = null; //mudar para o tipo correto.

        internal DeletarUltimaCompraOuImpressao(AlunoRepository alunoRepository, object comprarRepository)
        {
            InitializeComponent();
            _comprarRepository = comprarRepository;
            _alunoRepository = alunoRepository;
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
                SelecionarAluno selecionarAluno = new SelecionarAluno(_alunoRepository, _onReceberAlunoSelecionado);
                SelecionarObjetoForm form = new SelecionarObjetoForm(selecionarAluno);
                form.ShowDialog();
            }
        }

        private void _onReceberAlunoSelecionado(object alunoSelecionado)
        {
            _alunoSelecionado = (Aluno)alunoSelecionado;
            textBoxAlunoEscolhido.Text = alunoSelecionado.ToString();

            // com o aluno consulta o historico valido, verificar se é do tipo compra, caso sim preencher o texto de historico
            // caso não for do tipo compra (for do tipo realizar impressão), não abalitar o botão de deletar, e colocar um aviso no historio, dizendo que não da pra deletar.

            _compraDePacoteASerDeletada = null;// aqui no lugar de null preencher com o objeto que vai ser excluido.

            bool podeDeletar = true; // se não poder deletar colocar como false;

            if (podeDeletar)
            {
                textBoxUltimoHistorico.Text = "coloque aqui a informação do ultimo historico existente, aque que vai ser excluido";// fazer oque esta no texto
                buttonDeletar.Enabled = true;
            }
            else 
            {
                textBoxUltimoHistorico.Text = "Não pode ser excluido a compra pois existe a realização de impressão cadastrado após a compra!"; // aqui é pra ser esse texto
                buttonDeletar.Enabled = false;
            }
        }

    }
}
