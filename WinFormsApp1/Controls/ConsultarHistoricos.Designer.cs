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
            groupBoxTipos = new GroupBox();
            radioButtonImpressoes = new RadioButton();
            radioButtonCompras = new RadioButton();
            radioButtonTodos = new RadioButton();
            splitContainerInfo = new SplitContainer();
            textBoxHistoricoInfo = new TextBox();
            groupBoxTipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerInfo).BeginInit();
            splitContainerInfo.Panel1.SuspendLayout();
            splitContainerInfo.Panel2.SuspendLayout();
            splitContainerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // buttonVoltar
            // 
            buttonVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltar.Location = new Point(14, 469);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(294, 23);
            buttonVoltar.TabIndex = 6;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // textBoxAlunoEscolhido
            // 
            textBoxAlunoEscolhido.BackColor = SystemColors.Window;
            textBoxAlunoEscolhido.ForeColor = SystemColors.WindowText;
            textBoxAlunoEscolhido.Location = new Point(20, 60);
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
            listBoxListagem.Dock = DockStyle.Fill;
            listBoxListagem.FormattingEnabled = true;
            listBoxListagem.ItemHeight = 15;
            listBoxListagem.Location = new Point(0, 0);
            listBoxListagem.Name = "listBoxListagem";
            listBoxListagem.Size = new Size(770, 214);
            listBoxListagem.TabIndex = 0;
            listBoxListagem.SelectedIndexChanged += listBoxListagem_SelectedIndexChanged;
            // 
            // labelInfoHistorico
            // 
            labelInfoHistorico.AutoSize = true;
            labelInfoHistorico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoHistorico.Location = new Point(14, 96);
            labelInfoHistorico.Name = "labelInfoHistorico";
            labelInfoHistorico.Size = new Size(60, 15);
            labelInfoHistorico.TabIndex = 4;
            labelInfoHistorico.Text = "Historico:";
            // 
            // groupBoxTipos
            // 
            groupBoxTipos.Controls.Add(radioButtonImpressoes);
            groupBoxTipos.Controls.Add(radioButtonCompras);
            groupBoxTipos.Controls.Add(radioButtonTodos);
            groupBoxTipos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxTipos.Location = new Point(540, 3);
            groupBoxTipos.Name = "groupBoxTipos";
            groupBoxTipos.Size = new Size(239, 50);
            groupBoxTipos.TabIndex = 3;
            groupBoxTipos.TabStop = false;
            groupBoxTipos.Text = "Tipo De Histórico";
            // 
            // radioButtonImpressoes
            // 
            radioButtonImpressoes.AutoSize = true;
            radioButtonImpressoes.Location = new Point(150, 22);
            radioButtonImpressoes.Name = "radioButtonImpressoes";
            radioButtonImpressoes.Size = new Size(88, 19);
            radioButtonImpressoes.TabIndex = 2;
            radioButtonImpressoes.Text = "Impressões";
            radioButtonImpressoes.UseVisualStyleBackColor = true;
            radioButtonImpressoes.CheckedChanged += radioButtonImpressoes_CheckedChanged;
            // 
            // radioButtonCompras
            // 
            radioButtonCompras.AutoSize = true;
            radioButtonCompras.Location = new Point(71, 21);
            radioButtonCompras.Name = "radioButtonCompras";
            radioButtonCompras.Size = new Size(73, 19);
            radioButtonCompras.TabIndex = 1;
            radioButtonCompras.Text = "Compras";
            radioButtonCompras.UseVisualStyleBackColor = true;
            radioButtonCompras.CheckedChanged += radioButtonCompras_CheckedChanged;
            // 
            // radioButtonTodos
            // 
            radioButtonTodos.AutoSize = true;
            radioButtonTodos.Checked = true;
            radioButtonTodos.Location = new Point(8, 22);
            radioButtonTodos.Name = "radioButtonTodos";
            radioButtonTodos.Size = new Size(57, 19);
            radioButtonTodos.TabIndex = 0;
            radioButtonTodos.TabStop = true;
            radioButtonTodos.Text = "Todos";
            radioButtonTodos.UseVisualStyleBackColor = true;
            radioButtonTodos.CheckedChanged += radioButtonTodos_CheckedChanged;
            // 
            // splitContainerInfo
            // 
            splitContainerInfo.BackColor = SystemColors.ControlLight;
            splitContainerInfo.Location = new Point(14, 114);
            splitContainerInfo.Name = "splitContainerInfo";
            splitContainerInfo.Orientation = Orientation.Horizontal;
            // 
            // splitContainerInfo.Panel1
            // 
            splitContainerInfo.Panel1.BackColor = SystemColors.Control;
            splitContainerInfo.Panel1.Controls.Add(listBoxListagem);
            splitContainerInfo.Panel1MinSize = 100;
            // 
            // splitContainerInfo.Panel2
            // 
            splitContainerInfo.Panel2.BackColor = SystemColors.Control;
            splitContainerInfo.Panel2.Controls.Add(textBoxHistoricoInfo);
            splitContainerInfo.Panel2MinSize = 100;
            splitContainerInfo.Size = new Size(770, 349);
            splitContainerInfo.SplitterDistance = 214;
            splitContainerInfo.TabIndex = 5;
            // 
            // textBoxHistoricoInfo
            // 
            textBoxHistoricoInfo.BackColor = SystemColors.Window;
            textBoxHistoricoInfo.Dock = DockStyle.Fill;
            textBoxHistoricoInfo.Location = new Point(0, 0);
            textBoxHistoricoInfo.Multiline = true;
            textBoxHistoricoInfo.Name = "textBoxHistoricoInfo";
            textBoxHistoricoInfo.ReadOnly = true;
            textBoxHistoricoInfo.Size = new Size(770, 131);
            textBoxHistoricoInfo.TabIndex = 0;
            // 
            // ConsultarHistoricos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerInfo);
            Controls.Add(groupBoxTipos);
            Controls.Add(labelInfoHistorico);
            Controls.Add(textBoxAlunoEscolhido);
            Controls.Add(labelInfo);
            Controls.Add(labelTitulo);
            Controls.Add(buttonVoltar);
            Name = "ConsultarHistoricos";
            Size = new Size(800, 500);
            KeyDown += ConsultarHistoricos_KeyDown;
            groupBoxTipos.ResumeLayout(false);
            groupBoxTipos.PerformLayout();
            splitContainerInfo.Panel1.ResumeLayout(false);
            splitContainerInfo.Panel2.ResumeLayout(false);
            splitContainerInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerInfo).EndInit();
            splitContainerInfo.ResumeLayout(false);
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
        private GroupBox groupBoxTipos;
        private RadioButton radioButtonImpressoes;
        private RadioButton radioButtonCompras;
        private RadioButton radioButtonTodos;
        private SplitContainer splitContainerInfo;
        private TextBox textBoxHistoricoInfo;
    }
}
