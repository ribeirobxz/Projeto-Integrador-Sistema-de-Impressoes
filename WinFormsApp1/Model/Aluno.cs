using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Aluno
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public short QntdImpressao { get; set; }

        public Aluno(int codigo, string nome, string matricula, string email, short qntdImpressao)
        {
            Codigo = codigo;
            Nome = nome;
            Matricula = matricula;
            Email = email;
            QntdImpressao = qntdImpressao;
        }

        public Aluno() { }
    }
}
