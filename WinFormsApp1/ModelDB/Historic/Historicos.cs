namespace WinFormsApp1.Model.Historic
{
    public class Historicos
    {
        public int Codigo { get; set; }
        public int CodigoTipoMovimentacao { get; set; }
        public int CodigoAluno { get; set; }
        public DateTime DataHistorico { get; set; }
        public short QntdTotal { get; set; }
        public short SaldoAntes { get; set; }
        public short SaldoDepois { get; set; }
        public decimal? ValorTotalPago { get; set; }

        public Historicos() { }

        public Historicos(int codigo, int codigoTipoMovimentacao, int codigoAluno, DateTime dataHistorico, short saldoAntes)
        {
            Codigo = codigo;
            CodigoTipoMovimentacao = codigoTipoMovimentacao;
            CodigoAluno = codigoAluno;
            DataHistorico = dataHistorico;
            SaldoAntes = saldoAntes;
        }

       
    }
}
