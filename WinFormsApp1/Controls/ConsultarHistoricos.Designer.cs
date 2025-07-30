namespace WinFormsApp1.Controls
{
    partial class ConsultarHistoricos
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
            buttonVoltar = new Button();
            textBoxAlunoEscolhido = new TextBox();
            labelInfo = new Label();
            labelTitulo = new Label();
            listBoxListagem = new ListBox();
            labelInfoHistorico = new Label();
            SuspendLayout();
            // 
            // buttonVoltar
            // 
            buttonVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltar.Location = new Point(14, 469);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(294, 23);
            buttonVoltar.TabIndex = 5;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // textBoxAlunoEscolhido
            // 
            textBoxAlunoEscolhido.BackColor = SystemColors.Window;
            textBoxAlunoEscolhido.ForeColor = SystemColors.WindowText;
            textBoxAlunoEscolhido.Location = new Point(12, 60);
            textBoxAlunoEscolhido.Name = "textBoxAlunoEscolhido";
            textBoxAlunoEscolhido.ReadOnly = true;
            textBoxAlunoEscolhido.Size = new Size(764, 23);
            textBoxAlunoEscolhido.TabIndex = 2;
            textBoxAlunoEscolhido.KeyDown += textBoxAlunoEscolhido_KeyDown;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(11, 38);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(298, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Pressione F2 para escolher o aluno a listar o Historico";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(6, 6);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(154, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Consultar histórico";
            // 
            // listBoxListagem
            // 
            listBoxListagem.FormattingEnabled = true;
            listBoxListagem.ItemHeight = 15;
            listBoxListagem.Location = new Point(13, 114);
            listBoxListagem.Name = "listBoxListagem";
            listBoxListagem.Size = new Size(763, 349);
            listBoxListagem.TabIndex = 4;
            // 
            // labelInfoHistorico
            // 
            labelInfoHistorico.AutoSize = true;
            labelInfoHistorico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoHistorico.Location = new Point(11, 96);
            labelInfoHistorico.Name = "labelInfoHistorico";
            labelInfoHistorico.Size = new Size(60, 15);
            labelInfoHistorico.TabIndex = 3;
            labelInfoHistorico.Text = "Historico:";
            // 
            // ConsultarHistoricos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelInfoHistorico);
            Controls.Add(listBoxListagem);
            Controls.Add(textBoxAlunoEscolhido);
            Controls.Add(labelInfo);
            Controls.Add(labelTitulo);
            Controls.Add(buttonVoltar);
            Name = "ConsultarHistoricos";
            Size = new Size(800, 500);
            KeyDown += ConsultarHistoricos_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVoltar;
        private TextBox textBoxAlunoEscolhido;
        private Label labelInfo;
        private Label labelTitulo;
        private ListBox listBoxListagem;
        private Label labelInfoHistorico;
    }
}
