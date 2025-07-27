namespace WinFormsApp1.Controls
{
    partial class ConsultarAluno
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxArea = new GroupBox();
            labelQuantidadeDeInpressoes = new Label();
            textBoxQuantidade = new TextBox();
            textBoxNome = new TextBox();
            labelNome = new Label();
            textBoxMatricula = new TextBox();
            labelMatricula = new Label();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            textBoxAlunoAConsultar = new TextBox();
            labelInfo = new Label();
            buttonVoltar = new Button();
            labelTitulo = new Label();
            groupBoxArea.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxArea
            // 
            groupBoxArea.Controls.Add(labelQuantidadeDeInpressoes);
            groupBoxArea.Controls.Add(textBoxQuantidade);
            groupBoxArea.Controls.Add(textBoxNome);
            groupBoxArea.Controls.Add(labelNome);
            groupBoxArea.Controls.Add(textBoxMatricula);
            groupBoxArea.Controls.Add(labelMatricula);
            groupBoxArea.Controls.Add(labelEmail);
            groupBoxArea.Controls.Add(textBoxEmail);
            groupBoxArea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxArea.Location = new Point(11, 97);
            groupBoxArea.Name = "groupBoxArea";
            groupBoxArea.Size = new Size(776, 216);
            groupBoxArea.TabIndex = 3;
            groupBoxArea.TabStop = false;
            groupBoxArea.Text = "Aluno";
            // 
            // labelQuantidadeDeInpressoes
            // 
            labelQuantidadeDeInpressoes.AutoSize = true;
            labelQuantidadeDeInpressoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuantidadeDeInpressoes.Location = new Point(8, 163);
            labelQuantidadeDeInpressoes.Name = "labelQuantidadeDeInpressoes";
            labelQuantidadeDeInpressoes.Size = new Size(215, 15);
            labelQuantidadeDeInpressoes.TabIndex = 6;
            labelQuantidadeDeInpressoes.Text = "Quantidade de impresões disponiveis:";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.BackColor = SystemColors.Window;
            textBoxQuantidade.Font = new Font("Segoe UI", 9F);
            textBoxQuantidade.Location = new Point(8, 181);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.ReadOnly = true;
            textBoxQuantidade.Size = new Size(747, 23);
            textBoxQuantidade.TabIndex = 7;
            // 
            // textBoxNome
            // 
            textBoxNome.BackColor = SystemColors.Window;
            textBoxNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNome.Location = new Point(6, 40);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.ReadOnly = true;
            textBoxNome.Size = new Size(747, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(6, 22);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(44, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.BackColor = SystemColors.Window;
            textBoxMatricula.Font = new Font("Segoe UI", 9F);
            textBoxMatricula.Location = new Point(6, 86);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.ReadOnly = true;
            textBoxMatricula.Size = new Size(747, 23);
            textBoxMatricula.TabIndex = 3;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMatricula.Location = new Point(4, 68);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(62, 15);
            labelMatricula.TabIndex = 2;
            labelMatricula.Text = "Matrícula:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(7, 114);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.Window;
            textBoxEmail.Font = new Font("Segoe UI", 9F);
            textBoxEmail.Location = new Point(7, 132);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(747, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxAlunoAConsultar
            // 
            textBoxAlunoAConsultar.BackColor = SystemColors.Window;
            textBoxAlunoAConsultar.ForeColor = SystemColors.WindowText;
            textBoxAlunoAConsultar.Location = new Point(6, 60);
            textBoxAlunoAConsultar.Name = "textBoxAlunoAConsultar";
            textBoxAlunoAConsultar.ReadOnly = true;
            textBoxAlunoAConsultar.Size = new Size(746, 23);
            textBoxAlunoAConsultar.TabIndex = 2;
            textBoxAlunoAConsultar.KeyDown += textBoxAlunoAConsultar_KeyDown;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(3, 38);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(288, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Pressione F2 para escolher o aluno a ser consultado";
            // 
            // buttonVoltar
            // 
            buttonVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltar.Location = new Point(13, 325);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(88, 23);
            buttonVoltar.TabIndex = 0;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(-2, 6);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(133, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Consultar Aluno";
            // 
            // ConsultarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxArea);
            Controls.Add(labelInfo);
            Controls.Add(buttonVoltar);
            Controls.Add(labelTitulo);
            Controls.Add(textBoxAlunoAConsultar);
            Name = "ConsultarAluno";
            Size = new Size(800, 500);
            KeyDown += ConsultarAluno_KeyDown;
            groupBoxArea.ResumeLayout(false);
            groupBoxArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxArea;
        private TextBox textBoxNome;
        private Label labelNome;
        private TextBox textBoxMatricula;
        private Label labelMatricula;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private TextBox textBoxAlunoAConsultar;
        private Label labelInfo;
        private Button buttonVoltar;
        private Label labelTitulo;
        private Label labelQuantidadeDeInpressoes;
        private TextBox textBoxQuantidade;
    }
}
