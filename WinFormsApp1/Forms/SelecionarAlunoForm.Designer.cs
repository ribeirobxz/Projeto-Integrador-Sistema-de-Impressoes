namespace WinFormsApp1.Forms
{
    partial class SelecionarAlunoForm
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
            textBoxNomeAluno = new TextBox();
            buttonProcurar = new Button();
            labelInfo = new Label();
            listBoxListagem = new ListBox();
            SuspendLayout();
            // 
            // textBoxNomeAluno
            // 
            textBoxNomeAluno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNomeAluno.Location = new Point(6, 21);
            textBoxNomeAluno.Name = "textBoxNomeAluno";
            textBoxNomeAluno.Size = new Size(684, 23);
            textBoxNomeAluno.TabIndex = 0;
            textBoxNomeAluno.KeyDown += textBoxNomeAluno_KeyDown;
            // 
            // buttonProcurar
            // 
            buttonProcurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonProcurar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProcurar.Location = new Point(696, 20);
            buttonProcurar.Name = "buttonProcurar";
            buttonProcurar.Size = new Size(99, 23);
            buttonProcurar.TabIndex = 1;
            buttonProcurar.Text = "Procurar";
            buttonProcurar.UseVisualStyleBackColor = true;
            buttonProcurar.Click += buttonProcurar_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(6, 2);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(537, 15);
            labelInfo.TabIndex = 2;
            labelInfo.Text = "Digite o nome do Aluno que você que deseja procurar e aperte \"Enter\" ou clique em \"Procurar\"";
            // 
            // listBoxListagem
            // 
            listBoxListagem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxListagem.FormattingEnabled = true;
            listBoxListagem.ItemHeight = 15;
            listBoxListagem.Location = new Point(6, 50);
            listBoxListagem.Name = "listBoxListagem";
            listBoxListagem.Size = new Size(789, 394);
            listBoxListagem.TabIndex = 3;
            listBoxListagem.DoubleClick += listBoxListagem_DoubleClick;
            listBoxListagem.KeyDown += listBoxListagem_KeyDown;
            // 
            // SelecionarAlunoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxListagem);
            Controls.Add(labelInfo);
            Controls.Add(buttonProcurar);
            Controls.Add(textBoxNomeAluno);
            Name = "SelecionarAlunoForm";
            Text = "Escolha um aluno:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNomeAluno;
        private Button buttonProcurar;
        private Label labelInfo;
        private ListBox listBoxListagem;
    }
}