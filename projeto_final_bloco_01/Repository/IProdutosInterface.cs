using projeto_final_bloco_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Repository
{
    public interface IProdutosInterface
    {
        public void CadastrarProduto(Produtos produtos);
        public void ListarProdutos();
        public void ListarProdutoCodigo(int codigo);
        public void AtualizarProdutoCodigo(Produtos produtos);
        public void RemoverProdutoCodigo(int codigo);
        //Beta 
        public void ListarProdutosTags(string tags);
    }
}
