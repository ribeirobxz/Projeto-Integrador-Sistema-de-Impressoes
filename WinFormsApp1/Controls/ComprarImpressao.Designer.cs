namespace WinFormsApp1.Controls
{
    partial class ComprarImpressao
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
            labelInfoPacote = new Label();
            buttonAdicionarPacote = new Button();
            buttonRemoverPacoteSelecionado = new Button();
            listBoxPacotes = new ListBox();
            labelValorTotalCompra = new Label();
            labelQuantidadeTotal = new Label();
            buttonComprar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxAlunoEscolhido
            // 
            textBoxAlunoEscolhido.BackColor = SystemColors.Window;
            textBoxAlunoEscolhido.ForeColor = SystemColors.WindowText;
            textBoxAlunoEscolhido.Location = new Point(11, 55);
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
            labelInfo.Location = new Point(12, 33);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(377, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Pressione F2 para escolher o aluno a que vai comprar as impressões";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(7, 1);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(165, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Comprar impressões";
            // 
            // labelInfoPacote
            // 
            labelInfoPacote.AutoSize = true;
            labelInfoPacote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoPacote.Location = new Point(12, 96);
            labelInfoPacote.Name = "labelInfoPacote";
            labelInfoPacote.Size = new Size(191, 15);
            labelInfoPacote.TabIndex = 3;
            labelInfoPacote.Text = "Lista de pacotes a ser comprados:";
            // 
            // buttonAdicionarPacote
            // 
            buttonAdicionarPacote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdicionarPacote.Location = new Point(12, 114);
            buttonAdicionarPacote.Name = "buttonAdicionarPacote";
            buttonAdicionarPacote.Size = new Size(160, 23);
            buttonAdicionarPacote.TabIndex = 4;
            buttonAdicionarPacote.Text = "Adicionar pacote na lista";
            buttonAdicionarPacote.UseVisualStyleBackColor = true;
            buttonAdicionarPacote.Click += buttonAdicionarPacote_Click;
            // 
            // buttonRemoverPacoteSelecionado
            // 
            buttonRemoverPacoteSelecionado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemoverPacoteSelecionado.Location = new Point(178, 114);
            buttonRemoverPacoteSelecionado.Name = "buttonRemoverPacoteSelecionado";
            buttonRemoverPacoteSelecionado.Size = new Size(223, 23);
            buttonRemoverPacoteSelecionado.TabIndex = 5;
            buttonRemoverPacoteSelecionado.Text = "Remover pacote selecionado da lista";
            buttonRemoverPacoteSelecionado.UseVisualStyleBackColor = true;
            buttonRemoverPacoteSelecionado.Click += buttonRemoverPacoteSelecionado_Click;
            // 
            // listBoxPacotes
            // 
            listBoxPacotes.FormattingEnabled = true;
            listBoxPacotes.ItemHeight = 15;
            listBoxPacotes.Location = new Point(12, 143);
            listBoxPacotes.Name = "listBoxPacotes";
            listBoxPacotes.Size = new Size(759, 154);
            listBoxPacotes.TabIndex = 6;
            listBoxPacotes.SelectedIndexChanged += listBoxPacotes_SelectedIndexChanged;
            // 
            // labelValorTotalCompra
            // 
            labelValorTotalCompra.AutoSize = true;
            labelValorTotalCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorTotalCompra.Location = new Point(15, 320);
            labelValorTotalCompra.Name = "labelValorTotalCompra";
            labelValorTotalCompra.Size = new Size(176, 15);
            labelValorTotalCompra.TabIndex = 8;
            labelValorTotalCompra.Text = "Valor total da compra: R$: 0,00";
            // 
            // labelQuantidadeTotal
            // 
            labelQuantidadeTotal.AutoSize = true;
            labelQuantidadeTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuantidadeTotal.Location = new Point(15, 301);
            labelQuantidadeTotal.Name = "labelQuantidadeTotal";
            labelQuantidadeTotal.Size = new Size(149, 15);
            labelQuantidadeTotal.TabIndex = 7;
            labelQuantidadeTotal.Text = "Quantidade total: 0 folhas";
            // 
            // buttonComprar
            // 
            buttonComprar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonComprar.Location = new Point(15, 350);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(75, 23);
            buttonComprar.TabIndex = 9;
            buttonComprar.Text = "Comprar";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(96, 350);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 10;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // ComprarImpressao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonCancelar);
            Controls.Add(buttonComprar);
            Controls.Add(labelQuantidadeTotal);
            Controls.Add(labelValorTotalCompra);
            Controls.Add(listBoxPacotes);
            Controls.Add(buttonRemoverPacoteSelecionado);
            Controls.Add(buttonAdicionarPacote);
            Controls.Add(labelInfoPacote);
            Controls.Add(textBoxAlunoEscolhido);
            Controls.Add(labelInfo);
            Controls.Add(labelTitulo);
            Name = "ComprarImpressao";
            Size = new Size(800, 500);
            KeyDown += ComprarImpressao_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAlunoEscolhido;
        private Label labelInfo;
        private Label labelTitulo;
        private Label labelInfoPacote;
        private Button buttonAdicionarPacote;
        private Button buttonRemoverPacoteSelecionado;
        private ListBox listBoxPacotes;
        private Label labelValorTotalCompra;
        private Label labelQuantidadeTotal;
        private Button buttonComprar;
        private Button buttonCancelar;
    }
}
