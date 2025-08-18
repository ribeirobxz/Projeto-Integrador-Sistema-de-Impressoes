namespace WinFormsApp1.Model.Historic
{
    public class Compras
    {
        public int Codigo { get; set; }
        public int CodigoAluno { get; set; }
        public int CodigoHistorico { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorTotalPago { get; set; }

        public Compras() { }

        public Compras(int codigo, int codigoAluno, int codigoHistorico, DateTime dataCompra, decimal valorTotalPago)
        {
            Codigo = codigo;
            CodigoAluno = codigoAluno;
            CodigoHistorico = codigoHistorico;
            DataCompra = dataCompra;
            ValorTotalPago = valorTotalPago;
        }
    }
}
