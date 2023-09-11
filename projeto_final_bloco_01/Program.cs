namespace projeto_final_bloco_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao, tipo, subcategoria, categoria, codigo;
            string? nome, descricao, memoria, cor, processador, meterial, tags;
            decimal valor;

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


                        break;
                    case 02:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nListar todos os produtos:\n");


                        break;
                    case 03:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nBuscar produto pelo código: \n");


                        break;
                    case 04:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nAtualizar produto pelo código: \n");


                        break;
                    case 05:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nRemover produto: \n");


                        break;
                    case 06:
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nBuscar produto pelas tags: \n");


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