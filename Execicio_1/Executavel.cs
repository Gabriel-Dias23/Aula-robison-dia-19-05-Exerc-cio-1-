

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
    {
        public class execucao
        {
            List<Aluno> alunos = new List<Aluno>();
            static void Main(string[] args)
            {
                execucao exec = new execucao();
                exec.Executar();
            }

            public void Executar()
            {


                int op = -1;

                while (op != 5)
                {
                    Console.WriteLine("\n MENU");
                    Console.WriteLine("1: Cadastrar um Aluno");
                    Console.WriteLine("2: Listar Alunos");
                    Console.WriteLine("3: Alterar Aluno");
                    Console.WriteLine("4: Remover Aluno");
                    Console.WriteLine("5: SAIR");

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
                                CadastrarAluno();
                                break;
                            case 2:
                                ListarAlunosCadastrados();
                                break;
                            case 3:
                                AlterarDados();
                                break;
                            case 4:
                                RemoverAlunoRA();
                                break;
                            case 5:
                                Console.WriteLine("Saindo...");
                                break;
                            default:
                                Console.WriteLine("Opção inválida.Tente novamente");
                                break;

                        }
                    }
                }
            }


            private void CadastrarAluno()
            {
                Console.Write("Digite o RA: ");
                string ra = Console.ReadLine();

                if (alunos.Exists(a => a.RA == ra))
                {
                    Console.WriteLine("Já existe um aluno com esse RA.");
                    return;
                }

                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a idade: ");
                bool idadeValida = int.TryParse(Console.ReadLine(), out int idade);

                if (!idadeValida)
                {
                    Console.WriteLine("Idade inválida.");
                    return;
                }

                Aluno novoAluno = new Aluno(ra, nome, idade);
                alunos.Add(novoAluno);
                Console.WriteLine("Aluno cadastrado com sucesso!");
            }

            private void ListarAlunosCadastrados()
            {
                if (alunos.Count == 0)
                {
                    Console.WriteLine("Nenhum aluno cadastrado.");
                    return;
                }

                Console.WriteLine("\nLista de Alunos:");
                foreach (Aluno a in alunos)
                {
                    Console.WriteLine(a);
                }
            }

            private void AlterarDados()
            {
                Console.Write("Digite o RA do aluno a ser alterado: ");
                string ra = Console.ReadLine();

                Aluno aluno = alunos.Find(a => a.RA == ra);

                if (aluno == null)
                {
                    Console.WriteLine("Aluno não encontrado.");
                    return;
                }

                Console.Write($"Novo nome (atual: {aluno.Nome}): ");
                aluno.Nome = Console.ReadLine();

                Console.Write($"Nova idade (atual: {aluno.Idade}): ");
                bool idadeValida = int.TryParse(Console.ReadLine(), out int novaIdade);

                if (!idadeValida)
                {
                    Console.WriteLine("Idade inválida.");
                    return;
                }

                aluno.Idade = novaIdade;
                Console.WriteLine("Aluno atualizado com sucesso.");
            }

            private void RemoverAlunoRA()
            {
                Console.Write("Digite o RA do aluno a ser removido: ");
                string ra = Console.ReadLine();

                Aluno aluno = alunos.Find(a => a.RA == ra);

                if (aluno == null)
                {
                    Console.WriteLine("Aluno não encontrado.");
                    return;
                }

                alunos.Remove(aluno);
                Console.WriteLine("Aluno removido com sucesso.");

            }

        }
    }







}
}
