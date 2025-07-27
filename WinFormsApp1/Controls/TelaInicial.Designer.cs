namespace WinFormsApp1.Controls
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
            buttonSair = new Button();
            buttonConsultarHistoricos = new Button();
            buttonConsultarSaldos = new Button();
            buttonRealizarImpressao = new Button();
            buttonComprarImpressao = new Button();
            buttonCadastrarAluno = new Button();
            labelTitulo = new Label();
            buttonEditarAluno = new Button();
            buttonDeletarAluno = new Button();
            buttonConsultarAluno = new Button();
            buttonConsultarPacotes = new Button();
            buttonDeletarPacote = new Button();
            buttonEditarPacote = new Button();
            buttonCadastrarPacote = new Button();
            buttonDeletarUltimaImpressaoRealizada = new Button();
            buttonDeletarUltimaCompra = new Button();
            SuspendLayout();
            // 
            // buttonSair
            // 
            buttonSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSair.Location = new Point(166, 283);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(491, 23);
            buttonSair.TabIndex = 15;
            buttonSair.Text = "Sair do sistema";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonConsultarHistoricos
            // 
            buttonConsultarHistoricos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConsultarHistoricos.Location = new Point(414, 241);
            buttonConsultarHistoricos.Name = "buttonConsultarHistoricos";
            buttonConsultarHistoricos.Size = new Size(243, 23);
            buttonConsultarHistoricos.TabIndex = 14;
            buttonConsultarHistoricos.Text = "Consultar histórico";
            buttonConsultarHistoricos.UseVisualStyleBackColor = true;
            buttonConsultarHistoricos.Click += buttonConsultarHistoricos_Click;
            // 
            // buttonConsultarSaldos
            // 
            buttonConsultarSaldos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConsultarSaldos.Location = new Point(165, 241);
            buttonConsultarSaldos.Name = "buttonConsultarSaldos";
            buttonConsultarSaldos.Size = new Size(243, 23);
            buttonConsultarSaldos.TabIndex = 13;
            buttonConsultarSaldos.Text = "Consultar saldo de todos os alunos";
            buttonConsultarSaldos.UseVisualStyleBackColor = true;
            buttonConsultarSaldos.Click += buttonConsultarSaldos_Click;
            // 
            // buttonRealizarImpressao
            // 
            buttonRealizarImpressao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRealizarImpressao.Location = new Point(166, 212);
            buttonRealizarImpressao.Name = "buttonRealizarImpressao";
            buttonRealizarImpressao.Size = new Size(242, 23);
            buttonRealizarImpressao.TabIndex = 11;
            buttonRealizarImpressao.Text = " Realizar impressões";
            buttonRealizarImpressao.UseVisualStyleBackColor = true;
            buttonRealizarImpressao.Click += buttonRealizarImpressao_Click;
            // 
            // buttonComprarImpressao
            // 
            buttonComprarImpressao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonComprarImpressao.Location = new Point(165, 183);
            buttonComprarImpressao.Name = "buttonComprarImpressao";
            buttonComprarImpressao.Size = new Size(243, 23);
            buttonComprarImpressao.TabIndex = 9;
            buttonComprarImpressao.Text = "Comprar impressões";
            buttonComprarImpressao.UseVisualStyleBackColor = true;
            buttonComprarImpressao.Click += buttonComprarImpressao_Click;
            // 
            // buttonCadastrarAluno
            // 
            buttonCadastrarAluno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrarAluno.Location = new Point(186, 112);
            buttonCadastrarAluno.Name = "buttonCadastrarAluno";
            buttonCadastrarAluno.Size = new Size(110, 23);
            buttonCadastrarAluno.TabIndex = 1;
            buttonCadastrarAluno.Text = "Cadastrar Aluno";
            buttonCadastrarAluno.UseVisualStyleBackColor = true;
            buttonCadastrarAluno.Click += buttonCadastrarAluno_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(16, 19);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(765, 45);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Seja bem vindo ao sistema de impressão do senac";
            // 
            // buttonEditarAluno
            // 
            buttonEditarAluno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditarAluno.Location = new Point(302, 112);
            buttonEditarAluno.Name = "buttonEditarAluno";
            buttonEditarAluno.Size = new Size(106, 23);
            buttonEditarAluno.TabIndex = 2;
            buttonEditarAluno.Text = "Editar Aluno";
            buttonEditarAluno.UseVisualStyleBackColor = true;
            buttonEditarAluno.Click += buttonEditarAluno_Click;
            // 
            // buttonDeletarAluno
            // 
            buttonDeletarAluno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletarAluno.Location = new Point(415, 112);
            buttonDeletarAluno.Name = "buttonDeletarAluno";
            buttonDeletarAluno.Size = new Size(106, 23);
            buttonDeletarAluno.TabIndex = 3;
            buttonDeletarAluno.Text = "Deletar Aluno";
            buttonDeletarAluno.UseVisualStyleBackColor = true;
            buttonDeletarAluno.Click += buttonDeletarAluno_Click;
            // 
            // buttonConsultarAluno
            // 
            buttonConsultarAluno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConsultarAluno.Location = new Point(527, 112);
            buttonConsultarAluno.Name = "buttonConsultarAluno";
            buttonConsultarAluno.Size = new Size(116, 23);
            buttonConsultarAluno.TabIndex = 4;
            buttonConsultarAluno.Text = "Consultar Aluno";
            buttonConsultarAluno.UseVisualStyleBackColor = true;
            buttonConsultarAluno.Click += buttonConsultarAluno_Click;
            // 
            // buttonConsultarPacotes
            // 
            buttonConsultarPacotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConsultarPacotes.Location = new Point(527, 141);
            buttonConsultarPacotes.Name = "buttonConsultarPacotes";
            buttonConsultarPacotes.Size = new Size(116, 23);
            buttonConsultarPacotes.TabIndex = 8;
            buttonConsultarPacotes.Text = "Consultar Pacote";
            buttonConsultarPacotes.UseVisualStyleBackColor = true;
            buttonConsultarPacotes.Click += buttonConsultarPacotes_Click;
            // 
            // buttonDeletarPacote
            // 
            buttonDeletarPacote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletarPacote.Location = new Point(415, 141);
            buttonDeletarPacote.Name = "buttonDeletarPacote";
            buttonDeletarPacote.Size = new Size(106, 23);
            buttonDeletarPacote.TabIndex = 7;
            buttonDeletarPacote.Text = "Deletar Pacote";
            buttonDeletarPacote.UseVisualStyleBackColor = true;
            buttonDeletarPacote.Click += buttonDeletarPacote_Click;
            // 
            // buttonEditarPacote
            // 
            buttonEditarPacote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditarPacote.Location = new Point(302, 141);
            buttonEditarPacote.Name = "buttonEditarPacote";
            buttonEditarPacote.Size = new Size(106, 23);
            buttonEditarPacote.TabIndex = 6;
            buttonEditarPacote.Text = "Editar Pacote";
            buttonEditarPacote.UseVisualStyleBackColor = true;
            buttonEditarPacote.Click += buttonEditarPacote_Click;
            // 
            // buttonCadastrarPacote
            // 
            buttonCadastrarPacote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrarPacote.Location = new Point(186, 141);
            buttonCadastrarPacote.Name = "buttonCadastrarPacote";
            buttonCadastrarPacote.Size = new Size(110, 23);
            buttonCadastrarPacote.TabIndex = 5;
            buttonCadastrarPacote.Text = "Cadastrar Pacote";
            buttonCadastrarPacote.UseVisualStyleBackColor = true;
            buttonCadastrarPacote.Click += buttonCadastrarPacote_Click;
            // 
            // buttonDeletarUltimaImpressaoRealizada
            // 
            buttonDeletarUltimaImpressaoRealizada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletarUltimaImpressaoRealizada.Location = new Point(415, 212);
            buttonDeletarUltimaImpressaoRealizada.Name = "buttonDeletarUltimaImpressaoRealizada";
            buttonDeletarUltimaImpressaoRealizada.Size = new Size(242, 23);
            buttonDeletarUltimaImpressaoRealizada.TabIndex = 12;
            buttonDeletarUltimaImpressaoRealizada.Text = "Deletar ultima impressão realizada";
            buttonDeletarUltimaImpressaoRealizada.UseVisualStyleBackColor = true;
            buttonDeletarUltimaImpressaoRealizada.Click += buttonDeletarUltimaImpressaoRealizada_Click;
            // 
            // buttonDeletarUltimaCompra
            // 
            buttonDeletarUltimaCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletarUltimaCompra.Location = new Point(414, 183);
            buttonDeletarUltimaCompra.Name = "buttonDeletarUltimaCompra";
            buttonDeletarUltimaCompra.Size = new Size(243, 23);
            buttonDeletarUltimaCompra.TabIndex = 10;
            buttonDeletarUltimaCompra.Text = "Deletar ultima compra de impressão";
            buttonDeletarUltimaCompra.UseVisualStyleBackColor = true;
            buttonDeletarUltimaCompra.Click += buttonDeletarUltimaCompra_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDeletarUltimaImpressaoRealizada);
            Controls.Add(buttonDeletarUltimaCompra);
            Controls.Add(buttonConsultarPacotes);
            Controls.Add(buttonDeletarPacote);
            Controls.Add(buttonEditarPacote);
            Controls.Add(buttonCadastrarPacote);
            Controls.Add(buttonConsultarAluno);
            Controls.Add(buttonDeletarAluno);
            Controls.Add(buttonEditarAluno);
            Controls.Add(labelTitulo);
            Controls.Add(buttonSair);
            Controls.Add(buttonConsultarHistoricos);
            Controls.Add(buttonConsultarSaldos);
            Controls.Add(buttonRealizarImpressao);
            Controls.Add(buttonComprarImpressao);
            Controls.Add(buttonCadastrarAluno);
            Name = "TelaInicial";
            Size = new Size(800, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSair;
        private Button buttonConsultarHistoricos;
        private Button buttonConsultarSaldos;
        private Button buttonRealizarImpressao;
        private Button buttonComprarImpressao;
        private Button buttonCadastrarAluno;
        private Label labelTitulo;
        private Button buttonEditarAluno;
        private Button buttonDeletarAluno;
        private Button buttonConsultarAluno;
        private Button buttonConsultarPacotes;
        private Button buttonDeletarPacote;
        private Button buttonEditarPacote;
        private Button buttonCadastrarPacote;
        private Button buttonDeletarUltimaImpressaoRealizada;
        private Button buttonDeletarUltimaCompra;
    }
}
