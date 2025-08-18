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
        public override string ToString()
        {
            return "Data: " + DataHistorico.ToString("dd/MM/yyyy") + ", Tipo de movimentação: "  + ", Quantidade total: " + QntdTotal + ", Saldo antes: R$ " + SaldoAntes.ToString("F2") + ", Saldo depois: R$ " + SaldoDepois.ToString("F2") + (ValorTotalPago.HasValue ? ", Valor total pago: R$ " + ValorTotalPago.Value.ToString("F2") : "");
        }

    }
}
