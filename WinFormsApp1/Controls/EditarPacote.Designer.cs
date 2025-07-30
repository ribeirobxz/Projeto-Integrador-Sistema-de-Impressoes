namespace WinFormsApp1.Controls
{
    partial class EditarPacote
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
            groupBoxAreaDeEdicao = new GroupBox();
            numericUpDownPreço = new NumericUpDown();
            labelPrecoErro = new Label();
            labelPreco = new Label();
            textBoxPacoteAEditar = new TextBox();
            labelInfo = new Label();
            buttonCancelar = new Button();
            buttonEditarOK = new Button();
            labelTitulo = new Label();
            groupBoxAreaDeEdicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreço).BeginInit();
            SuspendLayout();
            // 
            // labelErroDiversos
            // 
            labelErroDiversos.AutoSize = true;
            labelErroDiversos.ForeColor = Color.Brown;
            labelErroDiversos.Location = new Point(229, 193);
            labelErroDiversos.Name = "labelErroDiversos";
            labelErroDiversos.Size = new Size(28, 15);
            labelErroDiversos.TabIndex = 6;
            labelErroDiversos.Text = "erro";
            // 
            // groupBoxAreaDeEdicao
            // 
            groupBoxAreaDeEdicao.Controls.Add(numericUpDownPreço);
            groupBoxAreaDeEdicao.Controls.Add(labelPrecoErro);
            groupBoxAreaDeEdicao.Controls.Add(labelPreco);
            groupBoxAreaDeEdicao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxAreaDeEdicao.Location = new Point(7, 96);
            groupBoxAreaDeEdicao.Name = "groupBoxAreaDeEdicao";
            groupBoxAreaDeEdicao.Size = new Size(766, 83);
            groupBoxAreaDeEdicao.TabIndex = 3;
            groupBoxAreaDeEdicao.TabStop = false;
            groupBoxAreaDeEdicao.Text = "Editar Pacote";
            // 
            // numericUpDownPreço
            // 
            numericUpDownPreço.DecimalPlaces = 4;
            numericUpDownPreço.Font = new Font("Segoe UI", 9F);
            numericUpDownPreço.Location = new Point(7, 42);
            numericUpDownPreço.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDownPreço.Name = "numericUpDownPreço";
            numericUpDownPreço.Size = new Size(741, 23);
            numericUpDownPreço.TabIndex = 2;
            // 
            // labelPrecoErro
            // 
            labelPrecoErro.AutoSize = true;
            labelPrecoErro.Font = new Font("Segoe UI", 9F);
            labelPrecoErro.ForeColor = Color.Brown;
            labelPrecoErro.Location = new Point(53, 18);
            labelPrecoErro.Name = "labelPrecoErro";
            labelPrecoErro.Size = new Size(28, 15);
            labelPrecoErro.TabIndex = 1;
            labelPrecoErro.Text = "erro";
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPreco.Location = new Point(6, 19);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(42, 15);
            labelPreco.TabIndex = 0;
            labelPreco.Text = "Preço:";
            // 
            // textBoxPacoteAEditar
            // 
            textBoxPacoteAEditar.BackColor = SystemColors.Window;
            textBoxPacoteAEditar.ForeColor = SystemColors.WindowText;
            textBoxPacoteAEditar.Location = new Point(9, 56);
            textBoxPacoteAEditar.Name = "textBoxPacoteAEditar";
            textBoxPacoteAEditar.ReadOnly = true;
            textBoxPacoteAEditar.Size = new Size(746, 23);
            textBoxPacoteAEditar.TabIndex = 2;
            textBoxPacoteAEditar.KeyDown += textBoxPacoteAEditar_KeyDown;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(10, 34);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(277, 15);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Pressione F2 para escolher o pacote a ser Editado";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.Location = new Point(133, 189);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(88, 23);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonEditarOK
            // 
            buttonEditarOK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditarOK.Location = new Point(7, 189);
            buttonEditarOK.Name = "buttonEditarOK";
            buttonEditarOK.Size = new Size(120, 23);
            buttonEditarOK.TabIndex = 4;
            buttonEditarOK.Text = "Confirmar Edição";
            buttonEditarOK.UseVisualStyleBackColor = true;
            buttonEditarOK.Click += buttonEditarOK_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(5, 2);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(111, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Editar Pacote";
            // 
            // EditarPacote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelErroDiversos);
            Controls.Add(groupBoxAreaDeEdicao);
            Controls.Add(textBoxPacoteAEditar);
            Controls.Add(labelInfo);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEditarOK);
            Controls.Add(labelTitulo);
            Name = "EditarPacote";
            Size = new Size(800, 500);
            KeyDown += EditarPacote_KeyDown;
            groupBoxAreaDeEdicao.ResumeLayout(false);
            groupBoxAreaDeEdicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreço).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErroDiversos;
        private GroupBox groupBoxAreaDeEdicao;
        private TextBox textBoxPacoteAEditar;
        private Label labelInfo;
        private Button buttonCancelar;
        private Button buttonEditarOK;
        private Label labelTitulo;
        private NumericUpDown numericUpDownPreço;
        private Label labelPrecoErro;
        private Label labelPreco;
    }
}
