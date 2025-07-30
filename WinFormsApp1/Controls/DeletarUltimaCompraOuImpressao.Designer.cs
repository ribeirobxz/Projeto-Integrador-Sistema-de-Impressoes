namespace WinFormsApp1.Controls
{
    partial class DeletarUltimaCompraOuImpressao
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
            textBoxAlunoEscolhido = new TextBox();
            labelInfo = new Label();
            labelTitulo = new Label();
            labelInfoHistorico = new Label();
            textBoxUltimoHistorico = new TextBox();
            buttonDeletar = new Button();
            buttonCancelar = new Button();
            labelMotivacao = new Label();
            textBoxMotivo = new TextBox();
            SuspendLayout();
            // 
            // textBoxAlunoEscolhido
            // 
            textBoxAlunoEscolhido.BackColor = SystemColors.Window;
            textBoxAlunoEscolhido.ForeColor = SystemColors.WindowText;
            textBoxAlunoEscolhido.Location = new Point(12, 53);
            textBoxAlunoEscolhido.Name = "textBoxAlunoEscolhido";
            textBoxAlunoEscolhido.ReadOnly = true;
            textBoxAlunoEscolhido.Size = new Size(760, 23);
            textBoxAlunoEscolhido.TabIndex = 2;
            textBoxAlunoEscolhido.KeyDown += textBoxAlunoEscolhido_KeyDown;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(13, 31);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(405, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Pressione F2 para escolher o aluno no qual vai ser deletado a ultima ação";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(8, -1);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(474, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Deletar ultima compra de impressões ou impressão realizada";
            // 
            // labelInfoHistorico
            // 
            labelInfoHistorico.AutoSize = true;
            labelInfoHistorico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoHistorico.Location = new Point(13, 86);
            labelInfoHistorico.Name = "labelInfoHistorico";
            labelInfoHistorico.Size = new Size(243, 15);
            labelInfoHistorico.TabIndex = 3;
            labelInfoHistorico.Text = "Historico da ultima ação que será deletada:";
            // 
            // textBoxUltimoHistorico
            // 
            textBoxUltimoHistorico.BackColor = SystemColors.Window;
            textBoxUltimoHistorico.Location = new Point(11, 110);
            textBoxUltimoHistorico.Multiline = true;
            textBoxUltimoHistorico.Name = "textBoxUltimoHistorico";
            textBoxUltimoHistorico.ReadOnly = true;
            textBoxUltimoHistorico.Size = new Size(761, 146);
            textBoxUltimoHistorico.TabIndex = 4;
            // 
            // buttonDeletar
            // 
            buttonDeletar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeletar.Location = new Point(12, 462);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(75, 23);
            buttonDeletar.TabIndex = 7;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = true;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(93, 462);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelMotivacao
            // 
            labelMotivacao.AutoSize = true;
            labelMotivacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMotivacao.Location = new Point(12, 271);
            labelMotivacao.Name = "labelMotivacao";
            labelMotivacao.Size = new Size(266, 15);
            labelMotivacao.TabIndex = 5;
            labelMotivacao.Text = "Escreva o motivo de estar deletando essa ação:";
            // 
            // textBoxMotivo
            // 
            textBoxMotivo.BackColor = SystemColors.Window;
            textBoxMotivo.Location = new Point(10, 293);
            textBoxMotivo.MaxLength = 800;
            textBoxMotivo.Multiline = true;
            textBoxMotivo.Name = "textBoxMotivo";
            textBoxMotivo.Size = new Size(761, 163);
            textBoxMotivo.TabIndex = 6;
            // 
            // DeletarUltimaCompraOuImpressao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxMotivo);
            Controls.Add(labelMotivacao);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonDeletar);
            Controls.Add(textBoxUltimoHistorico);
            Controls.Add(labelInfoHistorico);
            Controls.Add(textBoxAlunoEscolhido);
            Controls.Add(labelInfo);
            Controls.Add(labelTitulo);
            Name = "DeletarUltimaCompraOuImpressao";
            Size = new Size(800, 500);
            KeyDown += DeletarUltimaCompra_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAlunoEscolhido;
        private Label labelInfo;
        private Label labelTitulo;
        private Label labelInfoHistorico;
        private TextBox textBoxUltimoHistorico;
        private Button buttonDeletar;
        private Button buttonCancelar;
        private Label labelMotivacao;
        private TextBox textBoxMotivo;
    }
}
