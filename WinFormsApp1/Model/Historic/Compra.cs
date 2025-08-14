using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model.Historic
{
    public class Compra
    {

        public int Codigo { get; set; }
        public int CodigoAluno { get; set; }
        public int CodigoHistorico { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorTotalPago { get; set; }

        public Compra() { }

        public Compra(int codigo, int codigoAluno, int codigoHistorico, DateTime dataCompra, decimal valorTotalPago)
        {
            Codigo = codigo;
            CodigoAluno = codigoAluno;
            CodigoHistorico = codigoHistorico;
            DataCompra = dataCompra;
            ValorTotalPago = valorTotalPago;
        }
    }
}
