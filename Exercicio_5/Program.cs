using System;
using System.Collections.Generic;
namespace Exercicio_5
{
    public class Competidor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Modalidade { get; set; }

        public Competidor(string nome, int idade, string modalidade)
        {
            Nome = nome;
            Idade = idade;
            Modalidade = modalidade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Modalidade: {Modalidade}";
        }
    }

    public class Competicao
    {
        public string Nome { get; set; }
        private List<Competidor> competidores;

        public Competicao(string nome)
        {
            Nome = nome;
            competidores = new List<Competidor>();
        }

        public void AdicionarCompetidor(Competidor c) => competidores.Add(c);
        public void ListarCompetidores()
        {
            if (competidores.Count == 0) Console.WriteLine("Nenhum competidor cadastrado.");
            else for (int i = 0; i < competidores.Count; i++)
                    Console.WriteLine($"{i + 1}. {competidores[i]}");
        }

        public void EditarCompetidor(int i, string n, int id, string m)
        {
            if (i >= 0 && i < competidores.Count)
            {
                competidores[i].Nome = n;
                competidores[i].Idade = id;
                competidores[i].Modalidade = m;
            }
        }

        public void RemoverCompetidor(int i)
        {
            if (i >= 0 && i < competidores.Count)
                competidores.RemoveAt(i);
        }

        public int QuantidadeCompetidores() => competidores.Count;
    }


}
