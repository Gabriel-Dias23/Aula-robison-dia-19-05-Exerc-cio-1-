
//exercicio 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio_1
{



    public class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno(string ra, string nome, int idade)
        {
            RA = ra;
            Nome = nome;
            Idade = idade;

        }
        public override string ToString()
        {
            return $"RA: {RA}, Nome: {Nome}, Idade: {Idade}";
        }

    }
}