using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class CompraImpressao
    {

        public Pacote Pacote { get; set; }
        public int Quantidade { get; set; }

        public CompraImpressao(Pacote pacote, int quantidade)
        {
            Pacote = pacote;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"Pacote: {Pacote}, Quantidade de pacotes: {Quantidade}x";
        }

        public override bool Equals(object obj)
        {
            if (obj is CompraImpressao compraImpressao)
            {
                return Pacote.Equals(compraImpressao.Pacote) &&
                       Quantidade == compraImpressao.Quantidade;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Pacote, Quantidade);
        }
    }
}
