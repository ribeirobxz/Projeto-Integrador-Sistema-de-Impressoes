using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class Pacote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }
        public short Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Pacote(int codigo, short quantidade, decimal preco)
        {
            Codigo = codigo;
            Quantidade = quantidade;
            Preco = preco;
        }

        public Pacote() { }

        public override string ToString()
        {
            return $"Quantidade: {Quantidade}, Preco: R$: {Preco:F4}";
        }
    }
}
