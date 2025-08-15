namespace WinFormsApp1.Model.Historic
{
    public class Excluidos
    {
        public int Codigo { get; set; }
        public int CodigoHistorico { get; set; }
        public string Motivo { get; set; }
        public DateTime DataExclusao { get; set; }

        public Excluidos() { }

        public Excluidos(int codigo, int codigoHistorico, string motivo, DateTime dataExclusao) 
        {
            Codigo = codigo;
            CodigoHistorico = codigoHistorico;
            Motivo = motivo;
            DataExclusao = dataExclusao;
        }

    }
}
