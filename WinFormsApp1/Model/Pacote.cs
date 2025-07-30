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
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Pacote(int codigo, int quantidade, decimal preco)
        {
            Codigo = codigo;
            Quantidade = quantidade;
            Preco = preco;
        }

        public Pacote() { }

        public override string ToString()
        {
            return $"Quantidade: {Quantidade}, Preco: R$: {Preco:F2}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Pacote pacote)
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
