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
            SuspendLayout();
            // 
            // buttonVoltar
            // 
            buttonVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltar.Location = new Point(3, 3);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(152, 23);
            buttonVoltar.TabIndex = 1;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // ConsutarSaldos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonVoltar);
            Name = "ConsutarSaldos";
            Size = new Size(800, 500);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVoltar;
    }
}
