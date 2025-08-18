namespace WinFormsApp1.Model.Historic
{
    public class PacotesComprados
    {
        public int Codigo { get; set; }
        public int CodigoCompra { get; set; }
        public int CodigoPacote { get; set; }
        public int Multiplicador { get; set; }
        public decimal PrecoPacote { get; set; }

        public PacotesComprados() { }

        public PacotesComprados(int Codigo, int CodigoPacote, int Multiplicador, decimal PrecoPacote)
        {
            this.Codigo = Codigo;
            this.CodigoPacote = CodigoPacote;
            this.Multiplicador = Multiplicador;
            this.PrecoPacote = PrecoPacote;
        }
    }
}
