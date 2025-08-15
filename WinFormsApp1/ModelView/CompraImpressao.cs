using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;

namespace WinFormsApp1.ModelView
{
    internal class CompraImpressao
    {

        public Pacotes Pacote { get; set; }
        public short Quantidade { get; set; }

        public CompraImpressao(Pacotes pacote, short quantidade)
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
                return Pacote.Quantidade == compraImpressao.Pacote.Quantidade;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Pacote.Quantidade;
        }
    }
}
