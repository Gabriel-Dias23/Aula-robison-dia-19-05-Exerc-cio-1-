using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Executavel
    {
        class Program
        {
            static void Main()
            {
                Competicao competicao = null;

                while (true)
                {
                    Console.WriteLine("\n1-Criar competição\n2-Adicionar competidor\n3-Listar\n4-Editar\n5-Remover\n6-Sair");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Nome: ");
                            competicao = new Competicao(Console.ReadLine());
                            break;

                        case "2":
                            if (competicao == null) { Console.WriteLine("Crie uma competição."); break; }
                            Console.Write("Nome: "); string n = Console.ReadLine();
                            Console.Write("Idade: "); int i = int.Parse(Console.ReadLine());
                            Console.Write("Modalidade: "); string m = Console.ReadLine();
                            competicao.AdicionarCompetidor(new Competidor(n, i, m));
                            break;

                        case "3":
                            if (competicao != null) competicao.ListarCompetidores();
                            else Console.WriteLine("Crie uma competição.");
                            break;

                        case "4":
                            if (competicao == null || competicao.QuantidadeCompetidores() == 0) { Console.WriteLine("Nada para editar."); break; }
                            competicao.ListarCompetidores();
                            Console.Write("Número: "); int e = int.Parse(Console.ReadLine()) - 1;
                            Console.Write("Novo nome: "); string nn = Console.ReadLine();
                            Console.Write("Nova idade: "); int ni = int.Parse(Console.ReadLine());
                            Console.Write("Nova modalidade: "); string nm = Console.ReadLine();
                            competicao.EditarCompetidor(e, nn, ni, nm);
                            break;

                        case "5":
                            if (competicao == null || competicao.QuantidadeCompetidores() == 0) { Console.WriteLine("Nada para remover."); break; }
                            competicao.ListarCompetidores();
                            Console.Write("Número: "); int r = int.Parse(Console.ReadLine()) - 1;
                            competicao.RemoverCompetidor(r);
                            break;

                        case "6": return;
                        default: Console.WriteLine("Opção inválida."); break;
                    }
                }
            }
        }

    }
}
