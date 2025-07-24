namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        UserControl1 user;
        CadastrarAluno cadastrarAluno;
        TelaInicial telaInicial;

        public FormMain()
        {
            InitializeComponent();
            telaInicial = new TelaInicial();
            telaInicial.Dock = DockStyle.Fill;
            telaInicial.Show();
            this.panelPrincipal.Controls.Add(telaInicial);

            user = new UserControl1();
            user.Dock = DockStyle.Fill;
            user.Hide();
            this.panelPrincipal.Controls.Add(user);

            cadastrarAluno = new CadastrarAluno();
            cadastrarAluno.Dock = DockStyle.Fill;
            cadastrarAluno.Hide();
            this.panelPrincipal.Controls.Add(cadastrarAluno);


            telaInicial._onCadastrarAlunoClick += () =>
            {
                telaInicial.Hide();
                cadastrarAluno.Show();
            };  
        }
    }
}
