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
    public partial class TelaInicial : UserControl
    {
        public Action? _OnCadastrarAluno_Click;
        public Action? _OnSair_Click;
        public Action? _OnEditarAluno_Click;
        public Action? _OnDeletarAluno_Click;
        public Action? _OnConsultarAluno_Click;
        public Action? _OnCadastrarPacote_Click;
        public Action? _OnEditarPacote_Click;
        public Action? _OnDeletarPacote_Click;
        public Action? _OnConsultarPacotes_Click;
        public Action? _OnComprarImpressao_Click;
        public Action? _OnRealizarImpressao_Click;
        public Action? _OnConsutarSaldos_Click;
        public Action? _OnConsultarHistoricos_Click;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void buttonCadastrarAluno_Click(object sender, EventArgs e)
        {
            _OnCadastrarAluno_Click?.Invoke();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            _OnSair_Click?.Invoke();
        }

        private void buttonEditarAluno_Click(object sender, EventArgs e)
        {
            _OnEditarAluno_Click?.Invoke();
        }

        private void buttonDeletarAluno_Click(object sender, EventArgs e)
        {
            _OnDeletarAluno_Click?.Invoke();
        }

        private void buttonConsultarAluno_Click(object sender, EventArgs e)
        {
            _OnConsultarAluno_Click?.Invoke();
        }

        private void buttonCadastrarPacote_Click(object sender, EventArgs e)
        {
            _OnCadastrarPacote_Click?.Invoke();
        }

        private void buttonEditarPacote_Click(object sender, EventArgs e)
        {
            _OnEditarPacote_Click?.Invoke();
        }

        private void buttonDeletarPacote_Click(object sender, EventArgs e)
        {
            _OnDeletarPacote_Click?.Invoke();
        }

        private void buttonConsultarPacotes_Click(object sender, EventArgs e)
        {
            _OnConsultarPacotes_Click?.Invoke();
        }

        private void buttonComprarImpressao_Click(object sender, EventArgs e)
        {
            _OnComprarImpressao_Click?.Invoke();
        }

        private void buttonRealizarImpressao_Click(object sender, EventArgs e)
        {
            _OnRealizarImpressao_Click?.Invoke();
        }

        private void buttonConsutarSaldos_Click(object sender, EventArgs e)
        {
            _OnConsutarSaldos_Click?.Invoke();
        }

        private void buttonConsultarHistoricos_Click(object sender, EventArgs e)
        {
            _OnConsultarHistoricos_Click?.Invoke();
        }
    }
}
