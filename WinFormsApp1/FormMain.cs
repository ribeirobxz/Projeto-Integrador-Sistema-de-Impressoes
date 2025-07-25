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

        internal FormMain(MockService service)
        {
            InitializeComponent();
            telaInicial = new TelaInicial();
            telaInicial.Dock = DockStyle.Fill;
            telaInicial.Show();
            this.panelPrincipal.Controls.Add(telaInicial);

            cadastrarAluno = new CadastrarAluno(service);
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

            cadastrarAluno.FecharControl += VoltaProPainelPrincipal;

            telaInicial._OnSair_Click += () => { this.Close(); };

            telaInicial._OnCadastrarAluno_Click += () =>
            {
                telaInicial.Hide();
                cadastrarAluno.Show();
                //tem que dar hide dos outros controls aqui
            };

            //tem que adicionar os eventos de troca de tela aqui.
        }

        private void VoltaProPainelPrincipal() 
        {
            telaInicial.Show();
            cadastrarAluno.Hide();
            //tem que dar hide dos outros controls aqui
        }
    }
}
