namespace WinFormsApp1.Controls
{
    partial class CadastrarPacote
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
            labelErroDiversos = new Label();
            buttonCancelar = new Button();
            buttonCadastrar = new Button();
            labelPrecoErro = new Label();
            labelPreco = new Label();
            labelQuantidadeErro = new Label();
            labelQuantidade = new Label();
            labelTitulo = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownPreço = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreço).BeginInit();
            SuspendLayout();
            // 
            // labelErroDiversos
            // 
            labelErroDiversos.AutoSize = true;
            labelErroDiversos.ForeColor = Color.Brown;
            labelErroDiversos.Location = new Point(189, 138);
            labelErroDiversos.Name = "labelErroDiversos";
            labelErroDiversos.Size = new Size(28, 15);
            labelErroDiversos.TabIndex = 25;
            labelErroDiversos.Text = "erro";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(102, 135);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 24;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(12, 135);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 23;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelPrecoErro
            // 
            labelPrecoErro.AutoSize = true;
            labelPrecoErro.ForeColor = Color.Brown;
            labelPrecoErro.Location = new Point(58, 82);
            labelPrecoErro.Name = "labelPrecoErro";
            labelPrecoErro.Size = new Size(28, 15);
            labelPrecoErro.TabIndex = 18;
            labelPrecoErro.Text = "erro";
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPreco.Location = new Point(11, 83);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(42, 15);
            labelPreco.TabIndex = 17;
            labelPreco.Text = "Preço:";
            // 
            // labelQuantidadeErro
            // 
            labelQuantidadeErro.AutoSize = true;
            labelQuantidadeErro.ForeColor = Color.Brown;
            labelQuantidadeErro.Location = new Point(91, 33);
            labelQuantidadeErro.Name = "labelQuantidadeErro";
            labelQuantidadeErro.Size = new Size(28, 15);
            labelQuantidadeErro.TabIndex = 15;
            labelQuantidadeErro.Text = "erro";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuantidade.Location = new Point(11, 33);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(74, 15);
            labelQuantidade.TabIndex = 14;
            labelQuantidade.Text = "Quantidade:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(3, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(184, 21);
            labelTitulo.TabIndex = 13;
            labelTitulo.Text = "Cadastrar Novo Pacote";
            // 
            // numericUpDownQunatidade
            // 
            numericUpDownQuantidade.Location = new Point(12, 56);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQunatidade";
            numericUpDownQuantidade.Size = new Size(762, 23);
            numericUpDownQuantidade.TabIndex = 26;
            // 
            // numericUpDownPreço
            // 
            numericUpDownPreço.DecimalPlaces = 4;
            numericUpDownPreço.Location = new Point(12, 106);
            numericUpDownPreço.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownPreço.Name = "numericUpDownPreço";
            numericUpDownPreço.Size = new Size(762, 23);
            numericUpDownPreço.TabIndex = 27;
            // 
            // CadastrarPacote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numericUpDownPreço);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(labelErroDiversos);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonCadastrar);
            Controls.Add(labelPrecoErro);
            Controls.Add(labelPreco);
            Controls.Add(labelQuantidadeErro);
            Controls.Add(labelQuantidade);
            Controls.Add(labelTitulo);
            Name = "CadastrarPacote";
            Size = new Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreço).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErroDiversos;
        private Button buttonCancelar;
        private Button buttonCadastrar;
        private Label labelPrecoErro;
        private Label labelPreco;
        private Label labelQuantidadeErro;
        private Label labelQuantidade;
        private Label labelTitulo;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownPreço;
    }
}
