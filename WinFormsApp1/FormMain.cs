using WinFormsApp1.Context;
using WinFormsApp1.Controls;

namespace WinFormsApp1
{
    internal partial class FormMain : Form
    {
        TelaInicial telaInicial;
        CadastrarAluno cadastrarAluno;
        EditarAluno editarAluno;
        DeletarAluno deletarAluno;
        ConsultarAluno consultarAluno;
        CadastrarPacote cadastrarPacote;
        EditarPacote editarPacote;
        DeletarPacote deletarPacote;
        ConsultarPacotes consultarPacotes;
        ComprarImpressao comprarImpressao;
        RealizarImpressao realizarImpressao;
        ConsutarSaldos consutarSaldos;
        ConsultarHistoricos consultarHistoricos;
        DeletarUltimaCompraOuImpressao deletarUltimaCompraOuImpressao;

        private readonly RepositoryContext _repositoryContext;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(RepositoryContext repositoryContext) : this()
        {

            _repositoryContext = repositoryContext;

            telaInicial = new TelaInicial();
            telaInicial.Dock = DockStyle.Fill;
            telaInicial.Show();
            this.panelPrincipal.Controls.Add(telaInicial);

            cadastrarAluno = new CadastrarAluno(_repositoryContext.AlunoRepository);
            cadastrarAluno.Dock = DockStyle.Fill;
            cadastrarAluno.Hide();
            this.panelPrincipal.Controls.Add(cadastrarAluno);

            editarAluno = new EditarAluno(_repositoryContext.AlunoRepository);
            editarAluno.Dock = DockStyle.Fill;
            editarAluno.Hide();
            this.panelPrincipal.Controls.Add(editarAluno);

            deletarAluno = new DeletarAluno(_repositoryContext.AlunoRepository);
            deletarAluno.Dock = DockStyle.Fill;
            deletarAluno.Hide();
            this.panelPrincipal.Controls.Add(deletarAluno);

            consultarAluno = new ConsultarAluno(_repositoryContext.AlunoRepository);
            consultarAluno.Dock = DockStyle.Fill;
            consultarAluno.Hide();
            this.panelPrincipal.Controls.Add(consultarAluno);

            cadastrarPacote = new CadastrarPacote(_repositoryContext.PacoteRepository);
            cadastrarPacote.Dock = DockStyle.Fill;
            cadastrarPacote.Hide();
            this.panelPrincipal.Controls.Add(cadastrarPacote);

            editarPacote = new EditarPacote(_repositoryContext.PacoteRepository);
            editarPacote.Dock = DockStyle.Fill;
            editarPacote.Hide();
            this.panelPrincipal.Controls.Add(editarPacote);

            deletarPacote = new DeletarPacote(_repositoryContext.PacoteRepository);
            deletarPacote.Dock = DockStyle.Fill;
            deletarPacote.Hide();
            this.panelPrincipal.Controls.Add(deletarPacote);

            consultarPacotes = new ConsultarPacotes(_repositoryContext.PacoteRepository);
            consultarPacotes.Dock = DockStyle.Fill;
            consultarPacotes.Hide();
            this.panelPrincipal.Controls.Add(consultarPacotes);

            comprarImpressao = new ComprarImpressao(_repositoryContext.AlunoRepository, _repositoryContext.PacoteRepository, null); // no lugar de null colocar o Repository que vc for usar
            comprarImpressao.Dock = DockStyle.Fill;
            comprarImpressao.Hide();
            this.panelPrincipal.Controls.Add(comprarImpressao);

            realizarImpressao = new RealizarImpressao(_repositoryContext.AlunoRepository, null);// no lugar de null colocar o Repository que vc for usar
            realizarImpressao.Dock = DockStyle.Fill;
            realizarImpressao.Hide();
            this.panelPrincipal.Controls.Add(realizarImpressao);

            consutarSaldos = new ConsutarSaldos(_repositoryContext.AlunoRepository);
            consutarSaldos.Dock = DockStyle.Fill;
            consutarSaldos.Hide();
            this.panelPrincipal.Controls.Add(consutarSaldos);

            consultarHistoricos = new ConsultarHistoricos(_repositoryContext.AlunoRepository, null);// no lugar de null colocar o Repository que vc for usar
            consultarHistoricos.Dock = DockStyle.Fill;
            consultarHistoricos.Hide();
            this.panelPrincipal.Controls.Add(consultarHistoricos);

            deletarUltimaCompraOuImpressao = new DeletarUltimaCompraOuImpressao(_repositoryContext.AlunoRepository, null);// no lugar de null colocar o Repository que vc for usar
            deletarUltimaCompraOuImpressao.Dock = DockStyle.Fill;
            deletarUltimaCompraOuImpressao.Hide();
            this.panelPrincipal.Controls.Add(deletarUltimaCompraOuImpressao);


            cadastrarAluno.FecharControl += VoltaProPainelPrincipal;
            editarAluno.FecharControl += VoltaProPainelPrincipal;
            deletarAluno.FecharControl += VoltaProPainelPrincipal;
            consultarAluno.FecharControl += VoltaProPainelPrincipal;
            cadastrarPacote.FecharControl += VoltaProPainelPrincipal;
            editarPacote.FecharControl += VoltaProPainelPrincipal;
            deletarPacote.FecharControl += VoltaProPainelPrincipal;
            consultarPacotes.FecharControl += VoltaProPainelPrincipal;
            comprarImpressao.FecharControl += VoltaProPainelPrincipal;
            realizarImpressao.FecharControl += VoltaProPainelPrincipal;
            consutarSaldos.FecharControl += VoltaProPainelPrincipal;
            consultarHistoricos.FecharControl += VoltaProPainelPrincipal;
            deletarUltimaCompraOuImpressao.FecharControl += VoltaProPainelPrincipal;

            telaInicial._OnSair_Click += () => { Close(); };

            telaInicial._OnCadastrarAluno_Click += _OnCadastrarAluno_Click;
            telaInicial._OnCadastrarPacote_Click += _OnCadastrarPacote_Click;
            telaInicial._OnComprarImpressao_Click += _OnComprarImpressao_Click;
            telaInicial._OnConsultarAluno_Click += _OnConsultarAluno_Click;
            telaInicial._OnConsultarHistoricos_Click += _OnConsultarHistoricos_Click;
            telaInicial._OnConsultarPacotes_Click += _OnConsultarPacotes_Click;
            telaInicial._OnConsultarSaldos_Click += _OnConsutarSaldos_Click;
            telaInicial._OnDeletarAluno_Click += _OnDeletarAluno_Click;
            telaInicial._OnDeletarPacote_Click += _OnDeletarPacote_Click;
            telaInicial._OnEditarAluno_Click += _OnEditarAluno_Click;
            telaInicial._OnEditarPacote_Click += _OnEditarPacote_Click;
            telaInicial._OnRealizarImpressao_Click += _OnRealizarImpressao_Click;
            telaInicial._OnDeletarUltimaCompraOuImpressao_Click += _OnDeletarUltimaCompraOuImpressao_Click;
            
        }

        private void EsconderTodos()
        {
            telaInicial.Hide();
            cadastrarAluno.Hide();
            editarAluno.Hide();
            deletarAluno.Hide();
            consultarAluno.Hide();
            cadastrarPacote.Hide();
            editarPacote.Hide();
            deletarPacote.Hide();
            consultarPacotes.Hide();
            comprarImpressao.Hide();
            realizarImpressao.Hide();
            consutarSaldos.Hide();
            consultarHistoricos.Hide();
            deletarUltimaCompraOuImpressao.Hide();
        }

        private void VoltaProPainelPrincipal()
        {
            EsconderTodos();
            telaInicial.Show();
        }

        private void _OnCadastrarAluno_Click()
        {
            EsconderTodos();

            cadastrarAluno.ResetarConteudo();
            cadastrarAluno.Show();
        }

        private void _OnEditarAluno_Click()
        {
            EsconderTodos();
            editarAluno.ResetarConteudo();
            editarAluno.Show();
        }

        private void _OnDeletarAluno_Click()
        {
            EsconderTodos();
            deletarAluno.ResetarConteudo();
            deletarAluno.Show();
        }

        private void _OnConsultarAluno_Click()
        {
            EsconderTodos();
            consultarAluno.ResetarConteudo();
            consultarAluno.Show();
        }


        private void _OnCadastrarPacote_Click()
        {
            EsconderTodos();
            cadastrarPacote.ResetarConteudo();
            cadastrarPacote.Show();
        }

        private void _OnEditarPacote_Click()
        {
            EsconderTodos();
            editarPacote.ResetarConteudo();
            editarPacote.Show();
        }

        private void _OnDeletarPacote_Click()
        {
            EsconderTodos();
            deletarPacote.ResetarConteudo();
            deletarPacote.Show();
        }


        private void _OnConsultarPacotes_Click()
        {
            EsconderTodos();
            consultarPacotes.ResetarConteudo();
            consultarPacotes.Show();
        }

        private void _OnComprarImpressao_Click()
        {
            EsconderTodos();
            comprarImpressao.ResetarConteudo();
            comprarImpressao.Show();
        }

        private void _OnRealizarImpressao_Click()
        {
            EsconderTodos();
            realizarImpressao.ResetarConteudo();
            realizarImpressao.Show();
        }

        private void _OnConsutarSaldos_Click()
        {
            EsconderTodos();
            consutarSaldos.ResetarConteudo();
            consutarSaldos.Show();
        }

        private void _OnConsultarHistoricos_Click()
        {
            EsconderTodos();
            consultarHistoricos.ResetarConteudo();
            consultarHistoricos.Show();
        }

        private void _OnDeletarUltimaCompraOuImpressao_Click() 
        {
            EsconderTodos();
            deletarUltimaCompraOuImpressao.ResetarConteudo();
            deletarUltimaCompraOuImpressao.Show();
        }

    }
}
