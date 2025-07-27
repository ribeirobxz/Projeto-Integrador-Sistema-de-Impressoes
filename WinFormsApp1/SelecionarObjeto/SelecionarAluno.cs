using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;
using WinFormsApp1.Service;

namespace WinFormsApp1.SelecionarObjeto
{
    internal class SelecionarAluno : ISelecionarObjeto
    {
        private readonly Action<object> _RetornoDoEscolhido;

        private readonly AlunoService _service;

        public SelecionarAluno(AlunoService service, Action<object> retornoDoEscolhido)
        {
            _service = service;
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

            // colocar codigo aqui que lista os alunos
            //_service.

            // mock
            var aa = new List<Aluno>();
            aa.Add(new Aluno(1, "aaa", "aaaa", "aaa@aa.com", 22));
            aa.Add(new Aluno(2, "BBB", "BB", "BB@aa.com", 23));
            aa.Add(new Aluno(3, "CC", "CCC", "CC@aa.com", 242));
            aa.Add(new Aluno(4, "DD", "DDD", "DD@aa.com", 26));
            return aa.ToArray();
        }
        public  Action<object> RetornarObjetoEscolhido()
        {
            return _RetornoDoEscolhido;
        }
    }
}
