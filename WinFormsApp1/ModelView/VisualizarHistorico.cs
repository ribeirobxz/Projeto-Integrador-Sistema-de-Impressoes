using WinFormsApp1.Model.Historic;

namespace WinFormsApp1.ModelView
{
    public class VisualizarHistorico : Historicos
    {
        public string NomeTipoMovimentacoes { get; set; }

        public int? CodigoExcluido { get; set; }
        public string? Motivo { get; set; }
        public DateTime? DataExclusao { get; set; }

        public override string ToString()
        {
            if (CodigoExcluido != null) 
            {
                return "Data Exclusão: " + ((DateTime)DataExclusao).ToString("dd/MM/yyyy") + ", Motivo da exclusão: " + Motivo;
            }

            return "Data: " + DataHistorico.ToString("dd/MM/yyyy") + ", Tipo de movimentação: " + NomeTipoMovimentacoes + ", Quantidade total: " + QntdTotal + ", Saldo antes: R$ " + SaldoAntes.ToString("F2") + ", Saldo depois: R$ " + SaldoDepois.ToString("F2") + (ValorTotalPago.HasValue ? ", Valor total pago: R$ " + ValorTotalPago.Value.ToString("F2") : "");
        }
    }
}
