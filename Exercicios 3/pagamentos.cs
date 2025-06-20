using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercicios_3.pagamentos.PagamentoCartaoCredito;
using static Exercicios_3.pagamentos;

namespace Exercicios_3
{
    internal class pagamentos
    {
 
public interface Ipagamento
    {
        void ProcessarPagamento(decimal valor);
    }

    public class PagamentoCartaoCredito : Ipagamento
    {

        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de {valor} processado via Cartão de crédito.");
        }

        public class PagamentoBoleto : Ipagamento
        {
            public void ProcessarPagamento(decimal valor)
            {
                Console.WriteLine($"Pagamento de {valor} processado via Boleto.");
            }

        }

        public class PagamentoPix : Ipagamento
        {
            public void ProcessarPagamento(decimal valor)
            {

                    Console.WriteLine($"Pagamento de {valor} processado via Pix.");

             }
        }
         
         public class LojaVirtual
            {
                public void RealizarPagamento(Ipagamento pagamento, decimal valor)
                {
                    pagamento.ProcessarPagamento(valor);
                }
            }

            class Program
            {
                static void Main()
                {
                    LojaVirtual loja = new LojaVirtual();

                    Console.WriteLine("Sistema de Pagamentos ");
                    Console.WriteLine("Escolha o método de pagamento:");
                    Console.WriteLine("1: Cartão de Crédito");
                    Console.WriteLIne("2: Boleto");
                    Console.WriteLine("3: Pix");

                    string escolha = Console.ReadLine(); Console.Write("Digite o valor do pagamento: R$ ");
                    decimal valor = decimal.Parse(Console.ReadLine());

                    IPagamento metodo = null;

                    switch (escolha)
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
        }
}
