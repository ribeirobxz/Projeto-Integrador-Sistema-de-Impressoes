namespace WinFormsApp1.Model
{
    internal class Pacotes
    {
        public int Codigo { get; set; }
        public short Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Pacotes(int codigo, short quantidade, decimal preco)
        {
            Codigo = codigo;
            Quantidade = quantidade;
            Preco = preco;
        }

        public Pacotes() { }

        public override string ToString()
        {
            return $"Quantidade: {Quantidade}, Preco: R$: {Preco:F2}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Pacotes pacote)
            {
                return Codigo == pacote.Codigo &&
                       Quantidade == pacote.Quantidade &&
                       Preco == pacote.Preco;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Codigo, Quantidade, Preco);
        }
    }
}
