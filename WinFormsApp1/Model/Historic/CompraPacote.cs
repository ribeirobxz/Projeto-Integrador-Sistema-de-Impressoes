using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model.Historic
{
    public class CompraPacote
    {

        public int Codigo { get; set; }
        public int CodigoCompra { get; set; }
        public int CodigoPacote { get; set; }
        public int Multiplicador { get; set; }
        public decimal PrecoPacote { get; set; }

        public CompraPacote() { }

        public CompraPacote(int Codigo, int CodigoPacote, int Multiplicador, decimal PrecoPacote)
        {
            this.Codigo = Codigo;
            this.CodigoPacote = CodigoPacote;
            this.Multiplicador = Multiplicador;
            this.PrecoPacote = PrecoPacote;
        }
    }
}
