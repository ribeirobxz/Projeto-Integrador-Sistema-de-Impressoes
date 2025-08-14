using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model.Historic
{
    public class Impressao
    {

        public int Codigo {  get; set; }
        public int CodigoAluno { get; set; }
        public int CodigoHistorico { get; set; }
        public DateTime DataImpressao { get; set; }
        public int QntdImpressao { get; set; }

        public Impressao() { }

        public Impressao(int codigo, int codigoAluno, int codigoHistorico, DateTime dataImpressao, int qntdImpressao)
        {
            Codigo = codigo;
            CodigoAluno = codigoAluno;
            CodigoHistorico = codigoHistorico;
            DataImpressao = dataImpressao;
            QntdImpressao = qntdImpressao;
        }
    }
}
