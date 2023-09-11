using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class Tecnologia : Produtos
    {

        string? memoria, cor, processador;
        public Tecnologia()
        {
        }

        public Tecnologia(string nome, decimal valor, string? descricao, int categoria, int codigo, string? tags, string? memoria, string? cor, string? processador) : 
            base(nome, valor, descricao, categoria, codigo, tags)
        {
            this.memoria = memoria;
            this.cor = cor;
            this.processador = processador;
        }

        public string? GetMemoria() { return memoria; }
        public void SetMemoria(string memoria) { this.memoria = memoria; }
        //
        public string? GetCor() { return cor; }
        public void SetCor(string cor) { this.cor = cor; }
        //
        public string? GetProcessador() { return processador; }
        public void SetProcessador(string processador) { this.processador = processador; }
        //

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Memória interna: {this.memoria}                ");
            Console.WriteLine($"Cor: {this.cor}                                ");
            Console.WriteLine($"Processador: {this.processador}                ");
        }
    }
}
