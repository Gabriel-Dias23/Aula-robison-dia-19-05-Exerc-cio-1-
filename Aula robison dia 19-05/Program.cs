
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula_robison_dia_19_05
{
    public class Executável
    {
       List<Aluno> alunos = new list<Aluno>();
        public static void Main(string[] args)
        {
            Executável executável = new Executável();
            executável.Executar();
        }
        public void Executar()
        {
            /*Aluno aluno1 = new Aluno("123456", "Robison", 20);
            Console.WriteLine("Dados do Aluno");
            Console.WriteLine($"RA: {aluno1.RA}");
            Console.WriteLine($" Nome: {aluno1.Nome}");
            Console.WriteLine($"Idade: {aluno1.Idade}");
            */

            int op = -1;

            while (op != 0)
            {
                Console.WriteLine(" MENU _______________");
                Console.WriteLine(" Opção 1: saida ");
                Console.WriteLine(" Opção 2: ");
                Console.WriteLine(" Opção 3: ");
                Console.WriteLine(" Opção 4: ");
                Console.WriteLine(" Opção 5 - SAIR: ");

                bool numValido = int.TryParse(Console.ReadLine(), out op);

                if (!numValido || op < 0 || op > 5)
                {
                    
                        Console.WriteLine(" Opção inválida. Tente novamente.");

                        continue; 
                    
                }
                {
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Cadastrar um Aluno ");
                            break;
                        case 2:
                            Console.WriteLine("Listar todos os alunos cadastrados ");
                            break;
                        case 3:
                            Console.WriteLine("Alterar dados de um existente");
                            break;
                        case 4:
                            Console.WriteLine("Remover aluno pelo RA");
                            break;
                        case 5:
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;

                    }

                    return;
                }

                Console.ReadLine();

                
            }
        }

    }
}
