namespace WinFormsApp1.Forms
{
    partial class EscolhaDePacoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPacoteEscolhido = new TextBox();
            labelInfo = new Label();
            labelinfoQuantidade = new Label();
            numericUpDownMultiplicador = new NumericUpDown();
            buttonAdicionar = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMultiplicador).BeginInit();
            SuspendLayout();
            // 
            // textBoxPacoteEscolhido
            // 
            textBoxPacoteEscolhido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPacoteEscolhido.BackColor = SystemColors.Window;
            textBoxPacoteEscolhido.ForeColor = SystemColors.WindowText;
            textBoxPacoteEscolhido.Location = new Point(11, 31);
            textBoxPacoteEscolhido.Name = "textBoxPacoteEscolhido";
            textBoxPacoteEscolhido.ReadOnly = true;
            textBoxPacoteEscolhido.Size = new Size(564, 23);
            textBoxPacoteEscolhido.TabIndex = 11;
            textBoxPacoteEscolhido.KeyDown += textBoxPacoteEscolhido_KeyDown;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(12, 9);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(292, 15);
            labelInfo.TabIndex = 10;
            labelInfo.Text = "Pressione F2 para escolher o pacote a ser comprado";
            // 
            // labelinfoQuantidade
            // 
            labelinfoQuantidade.AutoSize = true;
            labelinfoQuantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelinfoQuantidade.Location = new Point(13, 60);
            labelinfoQuantidade.Name = "labelinfoQuantidade";
            labelinfoQuantidade.Size = new Size(240, 15);
            labelinfoQuantidade.TabIndex = 12;
            labelinfoQuantidade.Text = "Quantos desse pacote vão ser comprados?";
            // 
            // numericUpDownMultiplicador
            // 
            numericUpDownMultiplicador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownMultiplicador.Location = new Point(12, 81);
            numericUpDownMultiplicador.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownMultiplicador.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMultiplicador.Name = "numericUpDownMultiplicador";
            numericUpDownMultiplicador.Size = new Size(563, 23);
            numericUpDownMultiplicador.TabIndex = 13;
            numericUpDownMultiplicador.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Enabled = false;
            buttonAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdicionar.Location = new Point(14, 117);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(142, 23);
            buttonAdicionar.TabIndex = 14;
            buttonAdicionar.Text = "Adicionar a listagem";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(163, 117);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(79, 23);
            buttonCancelar.TabIndex = 15;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // EscolhaDePacoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 151);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAdicionar);
            Controls.Add(numericUpDownMultiplicador);
            Controls.Add(labelinfoQuantidade);
            Controls.Add(textBoxPacoteEscolhido);
            Controls.Add(labelInfo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(4000, 190);
            MinimumSize = new Size(400, 190);
            Name = "EscolhaDePacoteForm";
            Text = "Escolha o pacote a adicionar na listagem de compra:";
            KeyDown += EscolhaDePacoteForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)numericUpDownMultiplicador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPacoteEscolhido;
        private Label labelInfo;
        private Label labelinfoQuantidade;
        private NumericUpDown numericUpDownMultiplicador;
        private Button buttonAdicionar;
        private Button buttonCancelar;
    }
}