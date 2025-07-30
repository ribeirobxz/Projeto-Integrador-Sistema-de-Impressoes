using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Impressao
    {

        public int Codigo { get; set; }
        public int CodigoAluno { get; set; }
        public int CodigoHistorico { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public Impressao(int codigo, int codigoAluno, int codigoHistorico, int quantidade, DateTime data)
        {
            Codigo = codigo;
            CodigoAluno = codigoAluno;
            CodigoHistorico = codigoHistorico;
            Quantidade = quantidade;
            Data = data;
        }
        public Impressao() { }
        public override string ToString()
        {
            return $"Codigo: {Codigo}, Aluno: #{CodigoAluno}, Historico: #{CodigoHistorico}, Quantidade: {Quantidade}, Data: {Data.ToShortDateString()}";
        }
    }
}
