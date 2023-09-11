using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class ProdutosparaCasaMoveis : Produtos
    {

        private string? cor;
        private int subcategoria;
        private string? material;

        public ProdutosparaCasaMoveis()
        {
        }
        public ProdutosparaCasaMoveis(string nome, decimal valor, string? descricao, int categoria, int codigo, string? tags, string? cor, int subcategoria, string? material) : 
            base(nome, valor, descricao, categoria, codigo, tags)
        {
            this.cor = cor;
            this.subcategoria = subcategoria;
            this.material = material;
        }

        public string? GetCor() { return this.cor; }
        public void SetCor(string? cor) { this.cor = cor; }
        //
        public int GetSubcategoria() { return this.subcategoria; }
        public void SetSubcategoria(int subcategoria) { this.subcategoria = subcategoria; }
        //
        public string? GetMaterial() { return this.material; }
        public void SetMaterial(string material) { this.material = material; }
        //

        public override void Visualizar()
        {

            string subcategoria = string.Empty;
            switch (this.subcategoria)
            {
                case 1:
                    subcategoria = "Cozinha";
                    break;
                case 2:
                    subcategoria = "Cama & Banho";
                    break;
                case 3:
                    subcategoria = "Móveis";
                    break;
            }
            base.Visualizar();
            Console.WriteLine($"Cor: {this.cor}                                ");
            Console.WriteLine($"Subcategoria: {subcategoria}                   ");
            Console.WriteLine($"Material: {this.material}                      ");
        }


    }
}
