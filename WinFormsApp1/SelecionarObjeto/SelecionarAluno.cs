using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;
using WinFormsApp1.Repository;

namespace WinFormsApp1.SelecionarObjeto
{
    internal class SelecionarAluno : ISelecionarObjeto
    {
        private readonly Action<object> _RetornoDoEscolhido;

        private readonly AlunoRepository _alunoRepository;

        public SelecionarAluno(AlunoRepository alunoRepository, Action<object> retornoDoEscolhido)
        {
            _alunoRepository = alunoRepository;
            _RetornoDoEscolhido = retornoDoEscolhido;
        }

        public string ObterTextoInformativoDoForm()
        {
            return "Digite o nome do Aluno que você que deseja procurar e aperte \"Enter\" ou clique em \"Procurar\"";
        }

        public string ObterTituloDoForm()
        {
            return "Escolha um Aluno:";
        }

        public object[] ObterConteudoPesquisado(string OqueProcurar)
        {
            if (OqueProcurar.Length < 3)
            {
                MessageBox.Show("Você deve digitar um nome com mais de duas letras!", "Aviso:");
                return Array.Empty<Aluno>();
            }

            return _alunoRepository.SelecionarAlunosPorNome(OqueProcurar).ToArray();
        }

        public  Action<object> RetornarObjetoEscolhido()
        {
            return _RetornoDoEscolhido;
        }
    }
}
