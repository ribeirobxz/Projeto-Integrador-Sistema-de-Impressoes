using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model.Historic
{
    public class TipoDeMovimentacao
    {

        public int Codigo {  get; set; }
        public string Nome { get; set; }

        public TipoDeMovimentacao() { }

        public TipoDeMovimentacao(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
