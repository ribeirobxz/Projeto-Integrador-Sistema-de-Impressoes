using WinFormsApp1.Controls;
using WinFormsApp1.Service;

namespace WinFormsApp1
{
    public partial class FormMain : Form
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

        private readonly AlunoService _mockService;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(AlunoService mockService) : this()
        {

            _mockService = mockService;

            telaInicial = new TelaInicial();
            telaInicial.Dock = DockStyle.Fill;
            telaInicial.Show();
            this.panelPrincipal.Controls.Add(telaInicial);

            cadastrarAluno = new CadastrarAluno(_mockService);
            cadastrarAluno.Dock = DockStyle.Fill;
            cadastrarAluno.Hide();
            this.panelPrincipal.Controls.Add(cadastrarAluno);

            editarAluno = new EditarAluno();
            editarAluno.Dock = DockStyle.Fill;
            editarAluno.Hide();
            this.panelPrincipal.Controls.Add(editarAluno);

            deletarAluno = new DeletarAluno();
            deletarAluno.Dock = DockStyle.Fill;
            deletarAluno.Hide();
            this.panelPrincipal.Controls.Add(deletarAluno);

            consultarAluno = new ConsultarAluno();
            consultarAluno.Dock = DockStyle.Fill;
            consultarAluno.Hide();
            this.panelPrincipal.Controls.Add(consultarAluno);

            cadastrarPacote = new CadastrarPacote();
            cadastrarPacote.Dock = DockStyle.Fill;
            cadastrarPacote.Hide();
            this.panelPrincipal.Controls.Add(cadastrarPacote);

            editarPacote = new EditarPacote();
            editarPacote.Dock = DockStyle.Fill;
            editarPacote.Hide();
            this.panelPrincipal.Controls.Add(editarPacote);

            deletarPacote = new DeletarPacote();
            deletarPacote.Dock = DockStyle.Fill;
            deletarPacote.Hide();
            this.panelPrincipal.Controls.Add(deletarPacote);

            consultarPacotes = new ConsultarPacotes();
            consultarPacotes.Dock = DockStyle.Fill;
            consultarPacotes.Hide();
            this.panelPrincipal.Controls.Add(consultarPacotes);

            comprarImpressao = new ComprarImpressao();
            comprarImpressao.Dock = DockStyle.Fill;
            comprarImpressao.Hide();
            this.panelPrincipal.Controls.Add(comprarImpressao);


            realizarImpressao = new RealizarImpressao();
            realizarImpressao.Dock = DockStyle.Fill;
            realizarImpressao.Hide();
            this.panelPrincipal.Controls.Add(realizarImpressao);

            consutarSaldos = new ConsutarSaldos();
            consutarSaldos.Dock = DockStyle.Fill;
            consutarSaldos.Hide();
            this.panelPrincipal.Controls.Add(consutarSaldos);


            consultarHistoricos = new ConsultarHistoricos();
            consultarHistoricos.Dock = DockStyle.Fill;
            consultarHistoricos.Hide();
            this.panelPrincipal.Controls.Add(consultarHistoricos);

            cadastrarAluno.FecharControl += VoltaProPainelPrincipal;

            telaInicial._OnSair_Click += () => { this.Close(); };

            telaInicial._OnCadastrarAluno_Click += _OnCadastrarAluno_Click;
            telaInicial._OnCadastrarPacote_Click += _OnCadastrarPacote_Click;
            telaInicial._OnComprarImpressao_Click += _OnComprarImpressao_Click;
            telaInicial._OnConsultarAluno_Click += _OnConsultarAluno_Click;
            telaInicial._OnConsultarHistoricos_Click += _OnConsultarHistoricos_Click;
            telaInicial._OnConsultarPacotes_Click += _OnConsultarPacotes_Click;
            telaInicial._OnConsutarSaldos_Click += _OnConsutarSaldos_Click;
            telaInicial._OnDeletarAluno_Click += _OnDeletarAluno_Click;
            telaInicial._OnDeletarPacote_Click += _OnDeletarPacote_Click;
            telaInicial._OnEditarAluno_Click += _OnEditarAluno_Click;
            telaInicial._OnEditarPacote_Click += _OnEditarPacote_Click;
            telaInicial._OnRealizarImpressao_Click += _OnRealizarImpressao_Click;

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
            editarAluno.Show();
        }

        private void _OnDeletarAluno_Click()
        {
            EsconderTodos();
            deletarAluno.Show();
        }

        private void _OnConsultarAluno_Click()
        {
            EsconderTodos();
            consultarAluno.Show();
        }


        private void _OnCadastrarPacote_Click()
        {
            EsconderTodos();
            cadastrarPacote.Show();
        }

        private void _OnEditarPacote_Click()
        {
            EsconderTodos();
            editarPacote.Show();
        }

        private void _OnDeletarPacote_Click()
        {
            EsconderTodos();
            deletarPacote.Show();
        }


        private void _OnConsultarPacotes_Click()
        {
            EsconderTodos();
            consultarPacotes.Show();
        }

        private void _OnComprarImpressao_Click()
        {
            EsconderTodos();
            comprarImpressao.Show();
        }

        private void _OnRealizarImpressao_Click()
        {
            EsconderTodos();
            realizarImpressao.Show();
        }

        private void _OnConsutarSaldos_Click()
        {
            EsconderTodos();
            consutarSaldos.Show();
        }

        private void _OnConsultarHistoricos_Click()
        {
            EsconderTodos();
            consultarHistoricos.Show();
        }
    }
}
