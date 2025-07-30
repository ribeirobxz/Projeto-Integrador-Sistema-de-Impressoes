namespace WinFormsApp1.Forms
{
    partial class SelecionarObjetoForm
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
            textBoxOqueProcurar = new TextBox();
            buttonProcurar = new Button();
            labelInfo = new Label();
            listBoxListagem = new ListBox();
            SuspendLayout();
            // 
            // textBoxOqueProcurar
            // 
            textBoxOqueProcurar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOqueProcurar.Location = new Point(6, 21);
            textBoxOqueProcurar.Name = "textBoxOqueProcurar";
            textBoxOqueProcurar.Size = new Size(684, 23);
            textBoxOqueProcurar.TabIndex = 0;
            textBoxOqueProcurar.KeyDown += textBoxOqueProcurar_KeyDown;
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
            labelInfo.Size = new Size(56, 15);
            labelInfo.TabIndex = 2;
            labelInfo.Text = "labelInfo";
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
            // SelecionarObjetoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxListagem);
            Controls.Add(labelInfo);
            Controls.Add(buttonProcurar);
            Controls.Add(textBoxOqueProcurar);
            Name = "SelecionarObjetoForm";
            Text = "SelecionarObjetoForm";
            KeyDown += SelecionarObjetoForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxOqueProcurar;
        private Button buttonProcurar;
        private Label labelInfo;
        private ListBox listBoxListagem;
    }
}