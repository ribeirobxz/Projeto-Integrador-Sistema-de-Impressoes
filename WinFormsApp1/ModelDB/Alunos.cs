namespace WinFormsApp1.Model
{
    public class Alunos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string NunTelefone { get; set; }
        public short QntdImpressao { get; set; }

        public Alunos(int codigo, string nome, string matricula, string nunTelefone, short qntdImpressao)
        {
            Codigo = codigo;
            Nome = nome;
            Matricula = matricula;
            NunTelefone = nunTelefone;
            QntdImpressao = qntdImpressao;
        }

        public Alunos() { }

        public override string ToString()
        {
            return $"Nome: {Nome}, Matricula: {Matricula}, Telefone: {NunTelefone}, Quantidade de impressão disponivel: {QntdImpressao}";

        }
    }
}
