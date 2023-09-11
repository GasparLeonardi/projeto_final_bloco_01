using projeto_final_bloco_01.Controller;
using projeto_final_bloco_01.Model;

namespace projeto_final_bloco_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao, tipo, subcategoria, categoria, codigo;
            string? nome, descricao, memoria, cor, processador, material, tags;
            decimal valor;

            ProdutosController produtos = new();

            Tecnologia p1 = new Tecnologia("iPhone 12", 4000, "Um dos smartphones iOS mais avançados e completos que existem em circulação.", 1, produtos.GerarCodigo(), "iphone celular camera boa", "128 GB", "Preto", "A15 Bionic");
            produtos.CadastrarProduto(p1);

            while (true)
            {

                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("************************************************");
                Console.WriteLine("                                                ");
                Console.WriteLine("           Kitanda do Seu Zé e-Commerce         ");
                Console.WriteLine("                                                ");
                Console.WriteLine("************************************************");
                Console.WriteLine("                                                ");
                Console.WriteLine("  1 - Cadastrar Produto                         ");
                Console.WriteLine("  2 - Listar todas os Produtos                  ");
                Console.WriteLine("  3 - Buscar Produto pelo Código                ");
                Console.WriteLine("  4 - Atualizar Produto pelo Código             ");
                Console.WriteLine("  5 - Apagar Produto                            ");
                Console.WriteLine("  6 - Buscar produtos pelas tags (Beta)         ");
                Console.WriteLine("  7 - Sair                                      ");
                Console.WriteLine("************************************************");
                Console.WriteLine("                                                ");
                Console.WriteLine("Entre com a opção desejada:                     ");
                Console.WriteLine("                                                ");


                //Tratamento de exceção para impedir a digitação de strings
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um valor inteiro entre 1 e 7.");
                    opcao = 0;
                }

                Console.ResetColor();
                //Console.Clear();

                if (opcao == 7)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("****************************************************");
                    Console.WriteLine("Kitanda do Seu Zé e-Commerce, abraços!              ");
                    Console.WriteLine("****************************************************\n\n");

                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                Console.ResetColor();
                Console.Clear();

                switch (opcao)
                {
                    case 01:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nCadastrar um novo produto:\n");

                        Console.WriteLine("Digite o nome do produto:\n");
                        nome = Console.ReadLine();

                        Console.WriteLine("Digite o valor do produto: \n");
                        valor = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Digite a descrição do produto:\n");
                        descricao = Console.ReadLine();

                        Console.WriteLine("Digite uma ou mais tags para o produto: \n");
                        tags = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("Digite a categoria do produto: (1 - Tecnologia, 2 - Casa e Móveis, 3 - Saúde, Cosméticos e Consumíveis");
                            categoria = Convert.ToInt32(Console.ReadLine());
                        } while (categoria != 1 && categoria != 3);

                        switch (categoria)
                        {
                            case 1:
                                Console.WriteLine("Digite a memoria do aparelho(ex: 128 GB): ");
                                memoria = (Console.ReadLine());

                                Console.WriteLine("Digite a cor do aparelho(ex: Branco): ");
                                cor = (Console.ReadLine());

                                Console.WriteLine("Digite o processador do aparelho(ex: Snapdragon 888): ");
                                processador = (Console.ReadLine());

                                produtos.CadastrarProduto(new Tecnologia(nome, valor, descricao, categoria, produtos.GerarCodigo(), tags, memoria, cor, processador));
                                break;
                            case 2:

                                Console.WriteLine("Digite a cor do produto(ex: Branco): ");
                                cor = (Console.ReadLine());

                                Console.WriteLine("Digite a subcategoria do produto: (1 - Cozinha, 2 - Cama & Banho, 3 - Móveis)");
                                subcategoria = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Digite o material do produto(ex: Couro): ");
                                material = (Console.ReadLine());

                                produtos.CadastrarProduto(new ProdutosparaCasaMoveis(nome, valor, descricao, categoria, produtos.GerarCodigo(), tags, cor, subcategoria, material));
                                break;
                            case 3:
                                Console.WriteLine("Digite a subcategoria do produto: (1 - Perfumes, 2 - Cuidado da Pele, 3 - Medicamentos, 4 - Consumíveis)");
                                subcategoria = Convert.ToInt32(Console.ReadLine());

                                produtos.CadastrarProduto(new SaudeCosmeticosConsumiveis( nome, valor, descricao, categoria, produtos.GerarCodigo(), tags, subcategoria));
                                break;
                        }
                        break;
                    case 02:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nListar todos os produtos:\n");

                        produtos.ListarProdutos();

                        Console.ResetColor();

                        break;
                    case 03:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nBuscar produto pelo código: \n");

                        Console.WriteLine("Digite o codigo do produto: \n");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        produtos.ListarProdutoCodigo(codigo);

                        break;
                    case 04:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nAtualizar produto pelo código: \n");

                        codigo = Convert.ToInt32(Console.ReadLine());

                        var produto = produtos.BuscarNaCollection(codigo);
                        if (produto is not null)
                        {
                            Console.WriteLine("Digite o nome do produto:\n");
                            nome = Console.ReadLine();

                            Console.WriteLine("Digite o valor do produto: \n");
                            valor = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Digite a descrição do produto:\n");
                            descricao = Console.ReadLine();

                            Console.WriteLine("Digite uma ou mais tags para o produto: \n");
                            tags = Console.ReadLine();

                            do
                            {
                                Console.WriteLine("Digite a categoria do produto: (1 - Tecnologia, 2 - Casa e Móveis, 3 - Saúde, Cosméticos e Consumíveis");
                                categoria = Convert.ToInt32(Console.ReadLine());
                            } while (categoria != 1 && categoria != 3);

                            switch (categoria)
                            {
                                case 1:
                                    Console.WriteLine("Digite a memoria do aparelho(ex: 128 GB): ");
                                    memoria = (Console.ReadLine());

                                    Console.WriteLine("Digite a cor do aparelho(ex: Branco): ");
                                    cor = (Console.ReadLine());

                                    Console.WriteLine("Digite o processador do aparelho(ex: Snapdragon 888): ");
                                    processador = (Console.ReadLine());

                                    produtos.AtualizarProdutoCodigo(new Tecnologia(nome, valor, descricao, categoria, codigo, tags, memoria, cor, processador));
                                    break;
                                case 2:

                                    Console.WriteLine("Digite a cor do produto(ex: Branco): ");
                                    cor = (Console.ReadLine());

                                    Console.WriteLine("Digite a subcategoria do produto: (1 - Cozinha, 2 - Cama & Banho, 3 - Móveis)");
                                    subcategoria = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Digite o material do produto(ex: Couro): ");
                                    material = (Console.ReadLine());

                                    produtos.AtualizarProdutoCodigo(new ProdutosparaCasaMoveis(nome, valor, descricao, categoria, codigo, tags, cor, subcategoria, material));
                                    break;
                                case 3:
                                    Console.WriteLine("Digite a subcategoria do produto: (1 - Perfumes, 2 - Cuidado da Pele, 3 - Medicamentos, 4 - Consumíveis)");
                                    subcategoria = Convert.ToInt32(Console.ReadLine());

                                    produtos.AtualizarProdutoCodigo(new SaudeCosmeticosConsumiveis(nome, valor, descricao, categoria, codigo, tags, subcategoria));
                                    break;
                            }
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"O produto {codigo} não foi encontrado!");
                            Console.ResetColor();
                        }
                        break;
                    case 05:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nRemover produto: \n");

                        Console.WriteLine("Digite o codigo do produto: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        produtos.RemoverProdutoCodigo(codigo);

                        break;
                    case 06:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nBuscar produto pelas tags: \n");

                        Console.WriteLine("Digite uma tag: ");
                        tags = Console.ReadLine();
                        tags ??= string.Empty;

                        produtos.ListarProdutosTags(tags);


                        break;
                    default:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\nOpção Inválida\n");
                        break;
                }
            }
        }
        static void Sobre()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("                                                    ");
            Console.WriteLine(" Projeto desenvolvido por Gaspar Lima Leonardi      ");
            Console.WriteLine(" e-mail: gasparlleonardi@gmail.com                  ");
            Console.WriteLine(" Github: github.com/GasparLeonardi                  ");
            Console.WriteLine("                                                    ");
            Console.WriteLine("****************************************************");
        }
    }
}