using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class SaudeCosmeticosConsumiveis : Produtos
    {
        private int subcategoria;

        public SaudeCosmeticosConsumiveis()
        {
        }

        public SaudeCosmeticosConsumiveis(string nome, decimal valor, string? descricao, int categoria, int codigo, string? tags, int subcategoria) : 
            base(nome, valor, descricao, categoria, codigo, tags)
        {
            this.subcategoria = subcategoria;
        }

        public int GetSubcategoria() { return this.subcategoria; }
        public void SetSubcategoria(int subcategoria) { this.subcategoria = subcategoria; }

        public override void Visualizar()
        {

            string subcategoria = string.Empty;
            switch (this.subcategoria)
            {
                case 1:
                    subcategoria = "Perfumes";
                    break;
                case 2:
                    subcategoria = "Cuidado da Pele";
                    break;
                case 3:
                    subcategoria = "Medicamentos";
                    break;
                case 4:
                    subcategoria = "Consumíveis";
                    break;
            }
            base.Visualizar();
            Console.WriteLine($"Subcategoria: {subcategoria}                   ");
            Console.WriteLine("************************************************");

        }
    }
}
