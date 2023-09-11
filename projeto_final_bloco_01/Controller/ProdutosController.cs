using projeto_final_bloco_01.Model;
using projeto_final_bloco_01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Controller
{
    public class ProdutosController : IProdutosInterface
    {
        private readonly List<Produtos> listaProdutos = new();
        int codigo = 0;

        public void AtualizarProdutoCodigo(Produtos produtos)
        {
            var BuscarProduto = BuscarNaCollection(produtos.GetCodigo());

            if (BuscarProduto is not null)
            {
                var index = listaProdutos.IndexOf(BuscarProduto);
                listaProdutos[index] = produtos;
            } else
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto {codigo} não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void CadastrarProduto(Produtos produtos)
        {
            listaProdutos.Add(produtos);
            Console.WriteLine($"O produto codigo {produtos.GetCodigo()} foi registrado!");
        }

        public void ListarProdutoCodigo(int codigo)
        {
            var produto = BuscarNaCollection(codigo);
            if (produto is not null)
            {
                produto.Visualizar();
            }
            else
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto {codigo} não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void ListarProdutos()
        {
            foreach (var produtos in listaProdutos)
            {
                produtos.Visualizar();
            }
        }
        public void RemoverProdutoCodigo(int codigo)
        {
            var produto = BuscarNaCollection(codigo);
            if (produto is not null)
            {
                if (listaProdutos.Remove(produto) == true)
                {
                    Console.WriteLine($"O produto codigo: {codigo} foi removido com sucesso!");
                }
            }
            else
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto {codigo} não foi encontrado!");
                Console.ResetColor();
            }
        }
        public int GerarCodigo()
        {
            return ++codigo;
        }
        public void ListarProdutosTags(string tags)
        {
            var ProdutosTags = from produtos in listaProdutos
                                   where produtos.GetTag().Contains(tags)
                                   select produtos;
            ProdutosTags.ToList().ForEach(c => c.Visualizar());
        }
        public Produtos? BuscarNaCollection(int codigo)
        {
            foreach (var produto in listaProdutos)
            {
                if (produto.GetCodigo() == codigo)
                    return produto;
            }
            return null;
        }

    }
}
