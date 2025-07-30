namespace WinFormsApp1.Controls
{
    partial class RealizarImpressao
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
            labelInfoQuantidade = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            buttonCancelar = new Button();
            buttonImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // textBoxAlunoEscolhido
            // 
            textBoxAlunoEscolhido.BackColor = SystemColors.Window;
            textBoxAlunoEscolhido.ForeColor = SystemColors.WindowText;
            textBoxAlunoEscolhido.Location = new Point(7, 54);
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
            labelInfo.Location = new Point(8, 32);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(299, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Pressione F2 para escolher o aluno a que vai imprimir";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(3, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(164, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = " Realizar impressões";
            // 
            // labelInfoQuantidade
            // 
            labelInfoQuantidade.AutoSize = true;
            labelInfoQuantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoQuantidade.Location = new Point(8, 96);
            labelInfoQuantidade.Name = "labelInfoQuantidade";
            labelInfoQuantidade.Size = new Size(211, 15);
            labelInfoQuantidade.TabIndex = 3;
            labelInfoQuantidade.Text = "Informe a quantidade a ser impressa:";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Enabled = false;
            numericUpDownQuantidade.Location = new Point(8, 125);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(759, 23);
            numericUpDownQuantidade.TabIndex = 4;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(89, 165);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonImprimir
            // 
            buttonImprimir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonImprimir.Location = new Point(8, 165);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(75, 23);
            buttonImprimir.TabIndex = 5;
            buttonImprimir.Text = "Imprimir";
            buttonImprimir.UseVisualStyleBackColor = true;
            buttonImprimir.Click += buttonImprimir_Click;
            // 
            // RealizarImpressao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonCancelar);
            Controls.Add(buttonImprimir);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(labelInfoQuantidade);
            Controls.Add(textBoxAlunoEscolhido);
            Controls.Add(labelInfo);
            Controls.Add(labelTitulo);
            Name = "RealizarImpressao";
            Size = new Size(800, 500);
            KeyDown += RealizarImpressao_KeyDown;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAlunoEscolhido;
        private Label labelInfo;
        private Label labelTitulo;
        private Label labelInfoQuantidade;
        private NumericUpDown numericUpDownQuantidade;
        private Button buttonCancelar;
        private Button buttonImprimir;
    }
}
