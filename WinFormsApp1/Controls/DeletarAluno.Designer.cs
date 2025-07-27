namespace WinFormsApp1.Controls
{
    partial class DeletarAluno
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
            textBoxAlunoADeletar = new TextBox();
            labelInfo = new Label();
            labelTitulo = new Label();
            labelErroDiversos = new Label();
            buttonCancelar = new Button();
            buttonDeletar = new Button();
            SuspendLayout();
            // 
            // textBoxAlunoADeletar
            // 
            textBoxAlunoADeletar.BackColor = SystemColors.Window;
            textBoxAlunoADeletar.ForeColor = SystemColors.WindowText;
            textBoxAlunoADeletar.Location = new Point(14, 54);
            textBoxAlunoADeletar.Name = "textBoxAlunoADeletar";
            textBoxAlunoADeletar.ReadOnly = true;
            textBoxAlunoADeletar.Size = new Size(746, 23);
            textBoxAlunoADeletar.TabIndex = 2;
            textBoxAlunoADeletar.KeyDown += textBoxAlunoAEditar_KeyDown;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(15, 32);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(279, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Pressione F2 para escolher o aluno a ser Deletado";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(10, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(116, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Deletar Aluno";
            // 
            // labelErroDiversos
            // 
            labelErroDiversos.AutoSize = true;
            labelErroDiversos.ForeColor = Color.Brown;
            labelErroDiversos.Location = new Point(197, 94);
            labelErroDiversos.Name = "labelErroDiversos";
            labelErroDiversos.Size = new Size(28, 15);
            labelErroDiversos.TabIndex = 5;
            labelErroDiversos.Text = "erro";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(105, 92);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonDeletar
            // 
            buttonDeletar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletar.Location = new Point(15, 92);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(75, 23);
            buttonDeletar.TabIndex = 3;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = true;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // DeletarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelErroDiversos);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonDeletar);
            Controls.Add(textBoxAlunoADeletar);
            Controls.Add(labelInfo);
            Controls.Add(labelTitulo);
            Name = "DeletarAluno";
            Size = new Size(800, 500);
            KeyDown += DeletarAluno_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAlunoADeletar;
        private Label labelInfo;
        private Label labelTitulo;
        private Label labelErroDiversos;
        private Button buttonCancelar;
        private Button buttonDeletar;
    }
}
