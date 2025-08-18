namespace WinFormsApp1.Model.Historic
{
    public class TipoMovimentacoes
    {
        public int Codigo {  get; set; }
        public string Nome { get; set; }

        public TipoMovimentacoes() { }

        public TipoMovimentacoes(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
