using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Controls
{
    public partial class ConsutarSaldos : UserControl
    {
        public Action? FecharControl;

        public ConsutarSaldos()
        {
            InitializeComponent();
        }

        public void ResetarConteudo()
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FecharControl?.Invoke();
        }
    }
}
