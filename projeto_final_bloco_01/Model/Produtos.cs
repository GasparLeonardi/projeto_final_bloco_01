using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public abstract class Produtos
    {
        //Atributos
        private string nome = string.Empty;
        private decimal valor;
        private string? descricao;
        private int categoria;
        private int codigo;
        private string? tags;

        //Metodo construtor
        protected Produtos(string nome, decimal valor, string? descricao, int categoria, int codigo, string? tags)
        {
            this.nome = nome;
            this.valor = valor;
            this.descricao = descricao;
            this.categoria = categoria;
            this.codigo = codigo;
            this.tags = tags;
        }

        //Polimorfismo de sobrecarga
        public Produtos() { }

        //Metodos Get e Set
        public string GetNome() { return nome; }
        public void SetNome(string nome) { this.nome = nome; }
        //
        //
        public decimal GetValor() { return valor; }
        public void SetValor(decimal valor) { this.valor = valor; }
        //
        //
        public string? GetDescricao() { return descricao; }
        public void SetDescricao(string descricao) { this.descricao = descricao; }
        //
        //
        public int GetCategoria() { return categoria; }
        public void SetCategoria(int categoria) { this.categoria = categoria; }
        //
        //
        public int GetCodigo() { return codigo; }
        public void SetCodigo(int codigo) { this.codigo = codigo; }

        public string? GetTag() { return tags; }
        public void SetTag(string tags) {  this.tags = tags; }

        public virtual void Visualizar()
        {
            string categoria = string.Empty;

            switch (this.categoria)
            {
                case 1:
                    categoria = "Tecnologia";
                    break;
                case 2:
                    categoria = "Casa & Móveis";
                    break;
                case 3:
                    categoria = "Saúde/Cosméticos";
                    break;
            }
            Console.WriteLine("************************************************");
            Console.WriteLine(" Dados do Produto                               ");
            Console.WriteLine("************************************************");
            Console.WriteLine($"Nome do produto: {this.nome}                   ");
            Console.WriteLine($"Categoria: {categoria}                         ");
            Console.WriteLine($"Valor: {(this.valor).ToString("C")}            ");
            Console.WriteLine($"Codigo: {codigo}                               ");
            Console.WriteLine($"Descrição: {this.descricao}                    ");
            Console.WriteLine($"Tags: {this.tags}                              ");
        }
    }
}
