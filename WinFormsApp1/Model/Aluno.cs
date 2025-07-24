using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class Aluno
    {

        public int Codigo { get; set; }
        public string Nome;
        public int Impressoes { get; set; }

        public List<int> ContasVinculadas { get; set; }

        public Aluno(int codigo, string nome, int impressoes)
        {
            Codigo = codigo;
            Nome = nome;
            Impressoes = impressoes;
        }

        public void AdicionarImpressao(int quantidade)
        {
            this.Impressoes += quantidade;
        }

        public void RemoverImpressao(int quantidade)
        {
            this.Impressoes -= quantidade;
        }
    }
}
