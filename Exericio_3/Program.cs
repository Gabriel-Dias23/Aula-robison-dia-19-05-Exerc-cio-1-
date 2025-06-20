using System;

public interface IPagamento
{
    void ProcessarPagamento(decimal valor);
}

public class PagamentoCartaoCredito : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} processado no cartão de crédito.");
    }
}

public class PagamentoBoleto : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} processado via boleto bancário.");
    }
}

public class PagamentoPIX : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} processado via PIX.");
    }
}

public class LojaVirtual
{
    public void RealizarPagamento(IPagamento metodo, decimal valor)
    {
        metodo.ProcessarPagamento(valor);
    }
}

class Program
{
    static void Main()
    {
        LojaVirtual loja = new LojaVirtual();

        Console.WriteLine("=== Sistema de Pagamentos ===");
        Console.WriteLine("Escolha o método de pagamento:");
        Console.WriteLine("1 - Cartão de Crédito");
        Console.WriteLine("2 - Boleto Bancário");
        Console.WriteLine("3 - PIX");
        Console.Write("Digite a opção: ");
        string opcao = Console.ReadLine();

        Console.Write("Digite o valor do pagamento: R$ ");
        decimal valor = decimal.Parse(Console.ReadLine());

        IPagamento metodo = null;

        switch (opcao)
        {
            case "1":
                metodo = new PagamentoCartaoCredito();
                break;
            case "2":
                metodo = new PagamentoBoleto();
                break;
            case "3":
                metodo = new PagamentoPIX();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                return;
        }

        loja.RealizarPagamento(metodo, valor);
    }
}
