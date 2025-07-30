using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;
using WinFormsApp1.Repository;

namespace WinFormsApp1.SelecionarObjeto
{
    internal class SelecionarPacote : ISelecionarObjeto
    {
        private readonly Action<object> _RetornoDoEscolhido;

        private readonly PacoteRepository _pacoteRepository;

        public SelecionarPacote(PacoteRepository pacoteRepository, Action<object> retornoDoEscolhido)
        {
            _pacoteRepository = pacoteRepository;
            _RetornoDoEscolhido = retornoDoEscolhido;
        }

        public string ObterTextoInformativoDoForm()
        {
            return "Digite a quantidade do Pacote que você que deseja procurar e aperte \"Enter\" ou clique em \"Procurar\"";
        }

        public string ObterTituloDoForm()
        {
            return "Escolha um Pacote:";
        }

        public object[] ObterConteudoPesquisado(string OqueProcurar)
        {
            return _pacoteRepository
                .SelecionarTodos()
                .Where(pacote => pacote.Quantidade.ToString().Contains(OqueProcurar))
                .ToArray();
        }

        public Action<object> RetornarObjetoEscolhido()
        {
            return _RetornoDoEscolhido;
        }
    }
}
