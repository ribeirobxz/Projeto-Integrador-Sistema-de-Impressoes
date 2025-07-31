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
            splitContainerInfo = new SplitContainer();
            textBoxInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainerInfo).BeginInit();
            splitContainerInfo.Panel1.SuspendLayout();
            splitContainerInfo.Panel2.SuspendLayout();
            splitContainerInfo.SuspendLayout();
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
            listBoxListagem.Dock = DockStyle.Fill;
            listBoxListagem.FormattingEnabled = true;
            listBoxListagem.ItemHeight = 15;
            listBoxListagem.Location = new Point(0, 0);
            listBoxListagem.Name = "listBoxListagem";
            listBoxListagem.Size = new Size(756, 282);
            listBoxListagem.TabIndex = 2;
            listBoxListagem.SelectedIndexChanged += listBoxListagem_SelectedIndexChanged;
            // 
            // splitContainerInfo
            // 
            splitContainerInfo.BackColor = SystemColors.ControlLight;
            splitContainerInfo.Location = new Point(19, 39);
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
            splitContainerInfo.Panel2.Controls.Add(textBoxInfo);
            splitContainerInfo.Panel2MinSize = 100;
            splitContainerInfo.Size = new Size(756, 417);
            splitContainerInfo.SplitterDistance = 282;
            splitContainerInfo.TabIndex = 3;
            // 
            // textBoxInfo
            // 
            textBoxInfo.BackColor = SystemColors.Window;
            textBoxInfo.Dock = DockStyle.Fill;
            textBoxInfo.Location = new Point(0, 0);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(756, 131);
            textBoxInfo.TabIndex = 0;
            // 
            // ConsutarSaldos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerInfo);
            Controls.Add(labelTitulo);
            Controls.Add(buttonVoltar);
            Name = "ConsutarSaldos";
            Size = new Size(800, 500);
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
        private Label labelTitulo;
        private ListBox listBoxListagem;
        private SplitContainer splitContainerInfo;
        private TextBox textBoxInfo;
    }
}
