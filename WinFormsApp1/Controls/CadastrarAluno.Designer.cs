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
            labelEmailErro = new Label();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            buttonCadastrar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(4, 52);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(394, 23);
            textBoxNome.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(4, 1);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(178, 21);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Cadastrar Novo Aluno";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(4, 34);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(41, 15);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // labelNomeErro
            // 
            labelNomeErro.AutoSize = true;
            labelNomeErro.ForeColor = Color.Brown;
            labelNomeErro.Location = new Point(6, 79);
            labelNomeErro.Name = "labelNomeErro";
            labelNomeErro.Size = new Size(28, 15);
            labelNomeErro.TabIndex = 3;
            labelNomeErro.Text = "erro";
            // 
            // labelMatriculaErro
            // 
            labelMatriculaErro.AutoSize = true;
            labelMatriculaErro.ForeColor = Color.Brown;
            labelMatriculaErro.Location = new Point(7, 148);
            labelMatriculaErro.Name = "labelMatriculaErro";
            labelMatriculaErro.Size = new Size(28, 15);
            labelMatriculaErro.TabIndex = 6;
            labelMatriculaErro.Text = "erro";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMatricula.Location = new Point(5, 103);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(59, 15);
            labelMatricula.TabIndex = 5;
            labelMatricula.Text = "Matrícula";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(5, 121);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(394, 23);
            textBoxMatricula.TabIndex = 4;
            // 
            // labelEmailErro
            // 
            labelEmailErro.AutoSize = true;
            labelEmailErro.ForeColor = Color.Brown;
            labelEmailErro.Location = new Point(8, 216);
            labelEmailErro.Name = "labelEmailErro";
            labelEmailErro.Size = new Size(28, 15);
            labelEmailErro.TabIndex = 9;
            labelEmailErro.Text = "erro";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(6, 171);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(6, 189);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(394, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(8, 245);
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
            buttonCancelar.Location = new Point(98, 245);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // CadastrarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonCancelar);
            Controls.Add(buttonCadastrar);
            Controls.Add(labelEmailErro);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelMatriculaErro);
            Controls.Add(labelMatricula);
            Controls.Add(textBoxMatricula);
            Controls.Add(labelNomeErro);
            Controls.Add(labelNome);
            Controls.Add(labelTitulo);
            Controls.Add(textBoxNome);
            Name = "CadastrarAluno";
            Size = new Size(434, 292);
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
        private Label labelEmailErro;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Button buttonCadastrar;
        private Button buttonCancelar;
    }
}
