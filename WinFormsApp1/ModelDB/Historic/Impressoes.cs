namespace WinFormsApp1.Model.Historic
{
    public class Impressoes
    {
        public int Codigo {  get; set; }
        public int CodigoAluno { get; set; }
        public int CodigoHistorico { get; set; }
        public DateTime DataImpressao { get; set; }
        public short QntdImpressao { get; set; }

        public Impressoes() { }

        public Impressoes(int codigo, int codigoAluno, int codigoHistorico, DateTime dataImpressao, short qntdImpressao)
        {
            Codigo = codigo;
            CodigoAluno = codigoAluno;
            CodigoHistorico = codigoHistorico;
            DataImpressao = dataImpressao;
            QntdImpressao = qntdImpressao;
        }
    }
}
