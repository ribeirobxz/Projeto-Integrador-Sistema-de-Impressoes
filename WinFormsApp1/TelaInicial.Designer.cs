namespace WinFormsApp1
{
    partial class TelaInicial
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonRealizarImpressao = new Button();
            buttonComprarImpressao = new Button();
            buttonCadastrarAluno = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(122, 197);
            button3.Name = "button3";
            button3.Size = new Size(243, 23);
            button3.TabIndex = 12;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(122, 168);
            button2.Name = "button2";
            button2.Size = new Size(243, 23);
            button2.TabIndex = 11;
            button2.Text = "Consultar histórico";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(122, 139);
            button1.Name = "button1";
            button1.Size = new Size(243, 23);
            button1.TabIndex = 10;
            button1.Text = "Consultar saldo de todos os alunos";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonRealizarImpressao
            // 
            buttonRealizarImpressao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRealizarImpressao.Location = new Point(123, 110);
            buttonRealizarImpressao.Name = "buttonRealizarImpressao";
            buttonRealizarImpressao.Size = new Size(242, 23);
            buttonRealizarImpressao.TabIndex = 9;
            buttonRealizarImpressao.Text = " Realizar impressão";
            buttonRealizarImpressao.UseVisualStyleBackColor = true;
            // 
            // buttonComprarImpressao
            // 
            buttonComprarImpressao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonComprarImpressao.Location = new Point(122, 81);
            buttonComprarImpressao.Name = "buttonComprarImpressao";
            buttonComprarImpressao.Size = new Size(243, 23);
            buttonComprarImpressao.TabIndex = 8;
            buttonComprarImpressao.Text = "Comprar impressões";
            buttonComprarImpressao.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarAluno
            // 
            buttonCadastrarAluno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrarAluno.Location = new Point(122, 52);
            buttonCadastrarAluno.Name = "buttonCadastrarAluno";
            buttonCadastrarAluno.Size = new Size(243, 23);
            buttonCadastrarAluno.TabIndex = 7;
            buttonCadastrarAluno.Text = "Cadastrar novo aluno";
            buttonCadastrarAluno.UseVisualStyleBackColor = true;
            buttonCadastrarAluno.Click += buttonCadastrarAluno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 17);
            label1.Name = "label1";
            label1.Size = new Size(389, 21);
            label1.TabIndex = 13;
            label1.Text = "Seja bem vindo ao sistema de impressão do senac";
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonRealizarImpressao);
            Controls.Add(buttonComprarImpressao);
            Controls.Add(buttonCadastrarAluno);
            Name = "TelaInicial";
            Size = new Size(559, 294);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonRealizarImpressao;
        private Button buttonComprarImpressao;
        private Button buttonCadastrarAluno;
        private Label label1;
    }
}
