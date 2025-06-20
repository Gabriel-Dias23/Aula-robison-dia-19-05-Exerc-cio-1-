//exercicio 
using Exercicio2;
using System.Security.Cryptography.X509Certificates;



public class Execucao
{
    List<Produto> produtos = new List<Produto>();

    static void Main(string[] args)
    {
        Execucao exec = new Execucao();
        exec.Executar();
    }

    public void Executar()
    {
        int op = -1;
        while (op != 5)
        {
            Console.WriteLine("\n MENU");
            Console.WriteLine("\n______________________");
            Console.WriteLine("1: Cadastrar um Produto");
            Console.WriteLine("2: Listar Produtos");
            Console.WriteLine("3: Alterar Produto");
            Console.WriteLine("4: Remover Produto");
            Console.WriteLine("\n5: SAIR");


            bool numValido = int.TryParse(Console.ReadLine(), out op);

            if (!numValido || op < 0 || op > 5)
            {
                Console.WriteLine(" Opção inválida. Tente novamente.");
                continue;
            }
            switch (op)
            {
                case 1:
                    CadastrarProduto();
                    break;
                case 2:
                    ListarProdutosCadastrados();
                    break;
                case 3:
                    AlterarDados();
                    break;
                case 4:
                    RemoverProduto();
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    private void CadastrarProduto()
    {
        Console.Write("Digite a descrição do produto: ");
        string descricao = Console.ReadLine();
        Console.Write("Digite o preço do produto: ");
        decimal preco;
        while (!decimal.TryParse(Console.ReadLine(), out preco) || preco < 0)
        {
            Console.Write("Preço inválido. Digite novamente: ");
        }
        Produto produto = new Produto(descricao, preco);
        produtos.Add(produto);
        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    private void ListarProdutosCadastrados()
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }
        Console.WriteLine("Produtos cadastrados:");
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }
    private void AlterarDados()
    {
        Console.Write("Digite a descrição do produto a ser alterado: ");
        string descricao = Console.ReadLine();
        Produto produto = produtos.FirstOrDefault(p => p.descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
        if (produto == null)
        {
            Console.WriteLine("Produto não encontrado.");
            return;
        }
        Console.Write("Digite a nova descrição do produto: ");
        produto.descricao = Console.ReadLine();
        Console.Write("Digite o novo preço do produto: ");

        decimal novoPreco;
        while (!decimal.TryParse(Console.ReadLine(), out novoPreco) || novoPreco < 0)
        {
            Console.Write("Preço inválido. Digite novamente: ");
        }

        produto.preco = novoPreco;
        Console.WriteLine("Produto alterado com sucesso!");
    }

    private void RemoverProduto()
    {
        Console.Write("Digite a descrição do produto a ser removido: ");
        string descricao = Console.ReadLine();
        Produto produto = produtos.FirstOrDefault(p => p.descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
        if (produto == null)
        {
            Console.WriteLine("Produto não encontrado.");
            return;
        }
        produtos.Remove(produto);
        Console.WriteLine("Produto removido com sucesso!");
    }

    
}
