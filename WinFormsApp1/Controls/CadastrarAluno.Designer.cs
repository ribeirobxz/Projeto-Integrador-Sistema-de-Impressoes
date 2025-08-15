namespace WinFormsApp1.Controls
{
    partial class CadastrarAluno
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
            textBoxNome = new TextBox();
            labelTitulo = new Label();
            labelNome = new Label();
            labelNomeErro = new Label();
            labelMatriculaErro = new Label();
            labelMatricula = new Label();
            textBoxMatricula = new TextBox();
            labelTelefoneErro = new Label();
            labelEmail = new Label();
            buttonCadastrar = new Button();
            buttonCancelar = new Button();
            labelErroDiversos = new Label();
            textBoxTelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(10, 52);
            textBoxNome.MaxLength = 200;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(762, 23);
            textBoxNome.TabIndex = 3;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(4, 1);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(178, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Cadastrar Novo Aluno";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(12, 34);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(44, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome:";
            // 
            // labelNomeErro
            // 
            labelNomeErro.AutoSize = true;
            labelNomeErro.ForeColor = Color.Brown;
            labelNomeErro.Location = new Point(58, 34);
            labelNomeErro.Name = "labelNomeErro";
            labelNomeErro.Size = new Size(28, 15);
            labelNomeErro.TabIndex = 2;
            labelNomeErro.Text = "erro";
            // 
            // labelMatriculaErro
            // 
            labelMatriculaErro.AutoSize = true;
            labelMatriculaErro.ForeColor = Color.Brown;
            labelMatriculaErro.Location = new Point(75, 83);
            labelMatriculaErro.Name = "labelMatriculaErro";
            labelMatriculaErro.Size = new Size(28, 15);
            labelMatriculaErro.TabIndex = 5;
            labelMatriculaErro.Text = "erro";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMatricula.Location = new Point(12, 84);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(62, 15);
            labelMatricula.TabIndex = 4;
            labelMatricula.Text = "Matrícula:";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(10, 101);
            textBoxMatricula.MaxLength = 20;
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(762, 23);
            textBoxMatricula.TabIndex = 6;
            // 
            // labelTelefoneErro
            // 
            labelTelefoneErro.AutoSize = true;
            labelTelefoneErro.ForeColor = Color.Brown;
            labelTelefoneErro.Location = new Point(72, 130);
            labelTelefoneErro.Name = "labelTelefoneErro";
            labelTelefoneErro.Size = new Size(28, 15);
            labelTelefoneErro.TabIndex = 8;
            labelTelefoneErro.Text = "erro";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(13, 130);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(59, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Telefone:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(13, 180);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 10;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(103, 180);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelErroDiversos
            // 
            labelErroDiversos.AutoSize = true;
            labelErroDiversos.ForeColor = Color.Brown;
            labelErroDiversos.Location = new Point(197, 182);
            labelErroDiversos.Name = "labelErroDiversos";
            labelErroDiversos.Size = new Size(28, 15);
            labelErroDiversos.TabIndex = 12;
            labelErroDiversos.Text = "erro";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(13, 151);
            textBoxTelefone.Mask = "(00) 00000-0000";
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(759, 23);
            textBoxTelefone.TabIndex = 9;
            // 
            // CadastrarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxTelefone);
            Controls.Add(labelErroDiversos);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonCadastrar);
            Controls.Add(labelTelefoneErro);
            Controls.Add(labelEmail);
            Controls.Add(labelMatriculaErro);
            Controls.Add(labelMatricula);
            Controls.Add(textBoxMatricula);
            Controls.Add(labelNomeErro);
            Controls.Add(labelNome);
            Controls.Add(labelTitulo);
            Controls.Add(textBoxNome);
            Name = "CadastrarAluno";
            Size = new Size(800, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private Label labelTitulo;
        private Label labelNome;
        private Label labelNomeErro;
        private Label labelMatriculaErro;
        private Label labelMatricula;
        private TextBox textBoxMatricula;
        private Label labelTelefoneErro;
        private Label labelEmail;
        private Button buttonCadastrar;
        private Button buttonCancelar;
        private Label labelErroDiversos;
        private MaskedTextBox textBoxTelefone;
    }
}
