namespace WinFormsApp1.Controls
{
    partial class EditarAluno
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
            buttonCancelar = new Button();
            buttonEditarOK = new Button();
            labelTelefoneErro = new Label();
            labelEmail = new Label();
            labelMatriculaErro = new Label();
            labelMatricula = new Label();
            textBoxMatricula = new TextBox();
            labelNomeErro = new Label();
            labelNome = new Label();
            labelTitulo = new Label();
            textBoxNome = new TextBox();
            labelInfo = new Label();
            textBoxAlunoAEditar = new TextBox();
            groupBoxAreaDeEdicao = new GroupBox();
            labelErroDiversos = new Label();
            textBoxTelefone = new MaskedTextBox();
            groupBoxAreaDeEdicao.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(138, 267);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(88, 23);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonEditarOK
            // 
            buttonEditarOK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditarOK.Location = new Point(12, 267);
            buttonEditarOK.Name = "buttonEditarOK";
            buttonEditarOK.Size = new Size(120, 23);
            buttonEditarOK.TabIndex = 4;
            buttonEditarOK.Text = "Confirmar Edição";
            buttonEditarOK.UseVisualStyleBackColor = true;
            buttonEditarOK.Click += buttonEditarOK_Click;
            // 
            // labelTelefoneErro
            // 
            labelTelefoneErro.AutoSize = true;
            labelTelefoneErro.Font = new Font("Segoe UI", 9F);
            labelTelefoneErro.ForeColor = Color.Brown;
            labelTelefoneErro.Location = new Point(66, 114);
            labelTelefoneErro.Name = "labelTelefoneErro";
            labelTelefoneErro.Size = new Size(28, 15);
            labelTelefoneErro.TabIndex = 7;
            labelTelefoneErro.Text = "erro";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(7, 114);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(59, 15);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Telefone:";
            // 
            // labelMatriculaErro
            // 
            labelMatriculaErro.AutoSize = true;
            labelMatriculaErro.Font = new Font("Segoe UI", 9F);
            labelMatriculaErro.ForeColor = Color.Brown;
            labelMatriculaErro.Location = new Point(69, 68);
            labelMatriculaErro.Name = "labelMatriculaErro";
            labelMatriculaErro.Size = new Size(28, 15);
            labelMatriculaErro.TabIndex = 4;
            labelMatriculaErro.Text = "erro";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMatricula.Location = new Point(4, 68);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(62, 15);
            labelMatricula.TabIndex = 3;
            labelMatricula.Text = "Matrícula:";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Font = new Font("Segoe UI", 9F);
            textBoxMatricula.Location = new Point(6, 86);
            textBoxMatricula.MaxLength = 20;
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(740, 23);
            textBoxMatricula.TabIndex = 5;
            // 
            // labelNomeErro
            // 
            labelNomeErro.AutoSize = true;
            labelNomeErro.Font = new Font("Segoe UI", 9F);
            labelNomeErro.ForeColor = Color.Brown;
            labelNomeErro.Location = new Point(53, 22);
            labelNomeErro.Name = "labelNomeErro";
            labelNomeErro.Size = new Size(28, 15);
            labelNomeErro.TabIndex = 1;
            labelNomeErro.Text = "erro";
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
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(10, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(105, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Editar Aluno";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNome.Location = new Point(6, 40);
            textBoxNome.MaxLength = 200;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(740, 23);
            textBoxNome.TabIndex = 2;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(15, 32);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(269, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Pressione F2 para escolher o aluno a ser Editado";
            // 
            // textBoxAlunoAEditar
            // 
            textBoxAlunoAEditar.BackColor = SystemColors.Window;
            textBoxAlunoAEditar.ForeColor = SystemColors.WindowText;
            textBoxAlunoAEditar.Location = new Point(14, 54);
            textBoxAlunoAEditar.Name = "textBoxAlunoAEditar";
            textBoxAlunoAEditar.ReadOnly = true;
            textBoxAlunoAEditar.Size = new Size(746, 23);
            textBoxAlunoAEditar.TabIndex = 2;
            textBoxAlunoAEditar.KeyDown += textBoxAlunoAEditar_KeyDown;
            // 
            // groupBoxAreaDeEdicao
            // 
            groupBoxAreaDeEdicao.Controls.Add(textBoxTelefone);
            groupBoxAreaDeEdicao.Controls.Add(textBoxNome);
            groupBoxAreaDeEdicao.Controls.Add(labelNome);
            groupBoxAreaDeEdicao.Controls.Add(labelNomeErro);
            groupBoxAreaDeEdicao.Controls.Add(textBoxMatricula);
            groupBoxAreaDeEdicao.Controls.Add(labelMatricula);
            groupBoxAreaDeEdicao.Controls.Add(labelTelefoneErro);
            groupBoxAreaDeEdicao.Controls.Add(labelMatriculaErro);
            groupBoxAreaDeEdicao.Controls.Add(labelEmail);
            groupBoxAreaDeEdicao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxAreaDeEdicao.Location = new Point(12, 94);
            groupBoxAreaDeEdicao.Name = "groupBoxAreaDeEdicao";
            groupBoxAreaDeEdicao.Size = new Size(766, 167);
            groupBoxAreaDeEdicao.TabIndex = 3;
            groupBoxAreaDeEdicao.TabStop = false;
            groupBoxAreaDeEdicao.Text = "Editar Aluno";
            // 
            // labelErroDiversos
            // 
            labelErroDiversos.AutoSize = true;
            labelErroDiversos.ForeColor = Color.Brown;
            labelErroDiversos.Location = new Point(234, 271);
            labelErroDiversos.Name = "labelErroDiversos";
            labelErroDiversos.Size = new Size(28, 15);
            labelErroDiversos.TabIndex = 6;
            labelErroDiversos.Text = "erro";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Font = new Font("Segoe UI", 9F);
            textBoxTelefone.Location = new Point(6, 132);
            textBoxTelefone.Mask = "(00) 00000-0000";
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(738, 23);
            textBoxTelefone.TabIndex = 8;
            // 
            // EditarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelErroDiversos);
            Controls.Add(groupBoxAreaDeEdicao);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEditarOK);
            Controls.Add(textBoxAlunoAEditar);
            Controls.Add(labelInfo);
            Controls.Add(labelTitulo);
            Name = "EditarAluno";
            Size = new Size(800, 500);
            KeyDown += EditarAluno_KeyDown;
            groupBoxAreaDeEdicao.ResumeLayout(false);
            groupBoxAreaDeEdicao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonEditarOK;
        private Label labelTelefoneErro;
        private Label labelEmail;
        private Label labelMatriculaErro;
        private Label labelMatricula;
        private TextBox textBoxMatricula;
        private Label labelNomeErro;
        private Label labelNome;
        private Label labelTitulo;
        private TextBox textBoxNome;
        private Label labelInfo;
        private TextBox textBoxAlunoAEditar;
        private GroupBox groupBoxAreaDeEdicao;
        private Label labelErroDiversos;
        private MaskedTextBox textBoxTelefone;
    }
}
