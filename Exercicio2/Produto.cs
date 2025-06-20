//exercicio 2 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Produto
    {
        public string descricao { get; set; }
        public decimal preco { get; set; }

        public Produto(string descricao, decimal preco)
        {
            this.descricao = descricao;
            this.preco = preco;
        }

        public override string ToString()
        {
            return $"Descrição: {descricao}, Preço: {preco:C}";
        }
    }
}
