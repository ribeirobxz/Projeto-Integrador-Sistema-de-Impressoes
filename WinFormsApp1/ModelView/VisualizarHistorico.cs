using WinFormsApp1.Model.Historic;

namespace WinFormsApp1.ModelView
{
    public class VisualizarHistorico : Historicos
    {

        public TipoMovimentacoes TipoMovimentacao;
        public Excluidos? Excluido;

        public VisualizarHistorico(int codigo, int codigoTipoDeMovimentacao, int codigoAluno, DateTime dataHistorico, short qntdTotal, short saldoAntes, short saldoDepois, decimal? valorTotalPago, TipoMovimentacoes tipoDeMovimentacao, Excluidos? excluido) : base() {
            TipoMovimentacao = tipoDeMovimentacao;
            Codigo = codigo;
            CodigoTipoMovimentacao = codigoTipoDeMovimentacao;
            CodigoAluno = codigoAluno;
            DataHistorico = dataHistorico;
            QntdTotal = qntdTotal;
            SaldoAntes = saldoAntes;
            SaldoDepois = saldoDepois;
            ValorTotalPago = valorTotalPago;
            Excluido = excluido;
        }

        public override string ToString()
        {
            return "Data: " + DataHistorico.ToString("dd/MM/yyyy") + ", Tipo de movimentação: " + TipoMovimentacao.Nome + ", Quantidade total: " + QntdTotal + ", Saldo antes: R$ " + SaldoAntes.ToString("F2") + ", Saldo depois: R$ " + SaldoDepois.ToString("F2") + (ValorTotalPago.HasValue ? ", Valor total pago: R$ " + ValorTotalPago.Value.ToString("F2") : "");
        }
    }
}
