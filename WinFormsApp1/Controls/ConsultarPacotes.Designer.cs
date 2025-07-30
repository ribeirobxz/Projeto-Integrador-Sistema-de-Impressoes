namespace WinFormsApp1.Controls
{
    partial class ConsultarPacotes
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
            groupBoxArea = new GroupBox();
            numericUpDownPreço = new NumericUpDown();
            labelQuantidade = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            labelPreco = new Label();
            labelInfo = new Label();
            buttonVoltar = new Button();
            labelTitulo = new Label();
            textBoxPacoteAConsultar = new TextBox();
            groupBoxArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreço).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // groupBoxArea
            // 
            groupBoxArea.Controls.Add(numericUpDownPreço);
            groupBoxArea.Controls.Add(labelQuantidade);
            groupBoxArea.Controls.Add(numericUpDownQuantidade);
            groupBoxArea.Controls.Add(labelPreco);
            groupBoxArea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxArea.Location = new Point(15, 92);
            groupBoxArea.Name = "groupBoxArea";
            groupBoxArea.Size = new Size(758, 125);
            groupBoxArea.TabIndex = 4;
            groupBoxArea.TabStop = false;
            groupBoxArea.Text = "Pacote";
            // 
            // numericUpDownPreço
            // 
            numericUpDownPreço.BackColor = SystemColors.Window;
            numericUpDownPreço.DecimalPlaces = 4;
            numericUpDownPreço.Font = new Font("Segoe UI", 9F);
            numericUpDownPreço.Location = new Point(7, 92);
            numericUpDownPreço.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownPreço.Name = "numericUpDownPreço";
            numericUpDownPreço.ReadOnly = true;
            numericUpDownPreço.Size = new Size(745, 23);
            numericUpDownPreço.TabIndex = 3;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuantidade.Location = new Point(6, 19);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(74, 15);
            labelQuantidade.TabIndex = 0;
            labelQuantidade.Text = "Quantidade:";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.BackColor = SystemColors.Window;
            numericUpDownQuantidade.Font = new Font("Segoe UI", 9F);
            numericUpDownQuantidade.Location = new Point(7, 42);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.ReadOnly = true;
            numericUpDownQuantidade.Size = new Size(745, 23);
            numericUpDownQuantidade.TabIndex = 1;
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPreco.Location = new Point(6, 69);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(42, 15);
            labelPreco.TabIndex = 2;
            labelPreco.Text = "Preço:";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(10, 34);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(296, 15);
            labelInfo.TabIndex = 2;
            labelInfo.Text = "Pressione F2 para escolher o pacote a ser consultado";
            // 
            // buttonVoltar
            // 
            buttonVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltar.Location = new Point(15, 228);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(88, 23);
            buttonVoltar.TabIndex = 5;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(5, 2);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(139, 21);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Consultar Pacote";
            // 
            // textBoxPacoteAConsultar
            // 
            textBoxPacoteAConsultar.BackColor = SystemColors.Window;
            textBoxPacoteAConsultar.ForeColor = SystemColors.WindowText;
            textBoxPacoteAConsultar.Location = new Point(13, 56);
            textBoxPacoteAConsultar.Name = "textBoxPacoteAConsultar";
            textBoxPacoteAConsultar.ReadOnly = true;
            textBoxPacoteAConsultar.Size = new Size(746, 23);
            textBoxPacoteAConsultar.TabIndex = 3;
            textBoxPacoteAConsultar.KeyDown += textBoxPacoteAConsultar_KeyDown;
            // 
            // ConsultarPacotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxArea);
            Controls.Add(labelInfo);
            Controls.Add(buttonVoltar);
            Controls.Add(labelTitulo);
            Controls.Add(textBoxPacoteAConsultar);
            Name = "ConsultarPacotes";
            Size = new Size(800, 500);
            KeyDown += ConsultarPacotes_KeyDown;
            groupBoxArea.ResumeLayout(false);
            groupBoxArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreço).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxArea;
        private Label labelInfo;
        private Button buttonVoltar;
        private Label labelTitulo;
        private TextBox textBoxPacoteAConsultar;
        private NumericUpDown numericUpDownPreço;
        private NumericUpDown numericUpDownQuantidade;
        private Label labelPreco;
        private Label labelQuantidade;
    }
}
