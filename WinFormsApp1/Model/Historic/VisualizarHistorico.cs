using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model.Historic
{
    public class VisualizarHistorico : Historico
    {

        public TipoDeMovimentacao TipoDeMovimentacao;
        public object? MotivoDeExclusao; // para fazer

        public VisualizarHistorico(int codigo, int codigoTipoDeMovimentacao, int codigoAluno, DateTime dataHistorico, int qntdTotal, decimal saldoAntes, decimal saldoDepois, decimal? valorTotalPago, TipoDeMovimentacao tipoDeMovimentacao) : base() {
            this.TipoDeMovimentacao = tipoDeMovimentacao;
            Codigo = codigo;
            CodigoTipoDeMovimentacao = codigoTipoDeMovimentacao;
            CodigoAluno = codigoAluno;
            DataHistorico = dataHistorico;
            QntdTotal = qntdTotal;
            SaldoAntes = saldoAntes;
            SaldoDepois = saldoDepois;
            ValorTotalPago = valorTotalPago;
        }

        public override string ToString()
        {
            return "Data: " + DataHistorico.ToString("dd/MM/yyyy") + ", Tipo de movimentação: " + TipoDeMovimentacao.Nome + ", Quantidade total: " + QntdTotal + ", Saldo antes: R$ " + SaldoAntes.ToString("F2") + ", Saldo depois: R$ " + SaldoDepois.ToString("F2") + (ValorTotalPago.HasValue ? ", Valor total pago: R$ " + ValorTotalPago.Value.ToString("F2") : "");
        }
    }
}
