using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int numero1 = 0;
            int numero2 = 0;

           
            try
            {
                Console.Write("Digite o primeiro número: ");
                numero1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Valor inválido. Digite um número inteiro.");
                continue;
            }

            try
            {
                Console.Write("Digite o segundo número: ");
                numero2 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Valor inválido. Digite um número inteiro.");
                continue;
            }

            try
            {
                int resultado = numero1 / numero2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
                continue;
            }

         
            Console.Write("Deseja realizar outra operação? (s/n): ");
            string opcao = Console.ReadLine().ToLower();

            if (opcao != "s")
                break;
        }
    }
}
