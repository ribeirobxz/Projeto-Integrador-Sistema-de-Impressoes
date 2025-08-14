using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model.Historic
{
    public class Historico
    {

        public int Codigo { get; set; }
        public int CodigoTipoDeMovimentacao { get; set; }
        public int CodigoAluno { get; set; }
        public DateTime DataHistorico { get; set; }
        public int QntdTotal { get; set; }
        public decimal SaldoAntes { get; set; }
        public decimal SaldoDepois { get; set; }
        public decimal? ValorTotalPago { get; set; }

        public Historico() { }

        public Historico(int codigo, int codigoTipoDeMovimentacao, int codigoAluno, DateTime dataHistorico, decimal saldoAntes)
        {
            Codigo = codigo;
            CodigoTipoDeMovimentacao = codigoTipoDeMovimentacao;
            CodigoAluno = codigoAluno;
            DataHistorico = dataHistorico;
            SaldoAntes = saldoAntes;
        }

       
    }
}
