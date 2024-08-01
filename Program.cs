using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GerenciamentoVeiculos
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
    

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo {Modelo}");
        }
    }

    public class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }

        public Carro(string marca, string modelo, int numeroDePortas) : base(marca, modelo)
        {
            this.NumeroDePortas = numeroDePortas;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Numero de portas é {NumeroDePortas}.");
        }
    }

    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            this.Cilindrada = cilindrada;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"É uma moto, Cilindrada {Cilindrada}");
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo meuCarro = new Carro("Ford", "Fiesta", 4);
            Veiculo minhaMoto = new Moto("Honda", "CG", 160);

            meuCarro.ExibirDetalhes();
            minhaMoto.ExibirDetalhes();
        }
    }
}
