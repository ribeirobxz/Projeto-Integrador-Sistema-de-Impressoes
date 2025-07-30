namespace WinFormsApp1.Controls
{
    partial class ConsutarSaldos
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
            labelTitulo = new Label();
            listBoxListagem = new ListBox();
            SuspendLayout();
            // 
            // buttonVoltar
            // 
            buttonVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltar.Location = new Point(20, 467);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(239, 23);
            buttonVoltar.TabIndex = 1;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(19, 6);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(274, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Consultar saldo de todos os alunos";
            // 
            // listBoxListagem
            // 
            listBoxListagem.FormattingEnabled = true;
            listBoxListagem.ItemHeight = 15;
            listBoxListagem.Location = new Point(20, 34);
            listBoxListagem.Name = "listBoxListagem";
            listBoxListagem.Size = new Size(760, 424);
            listBoxListagem.TabIndex = 2;
            // 
            // ConsutarSaldos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxListagem);
            Controls.Add(labelTitulo);
            Controls.Add(buttonVoltar);
            Name = "ConsutarSaldos";
            Size = new Size(800, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVoltar;
        private Label labelTitulo;
        private ListBox listBoxListagem;
    }
}
