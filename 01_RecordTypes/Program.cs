using System;

namespace _01_RecordTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var enderecoAna = new Endereco("95360000", 100, "Paraí");
            Console.WriteLine(enderecoAna);

            var enderecoCris = new Endereco("95360000", 100, "Paraí");
            Console.WriteLine(enderecoCris);

            var enderecosIguais = enderecoAna.Equals(enderecoCris);
            Console.WriteLine("Os endereços são {0}", enderecosIguais ? "iguais" : "diferentes");

            var enderecoAmigaDaCris = enderecoCris.ComNumero(200);
            Console.WriteLine(enderecoAmigaDaCris);
        }
    }

    public class Endereco : IEquatable<Endereco>
    {
        public Endereco(string cep, int numero, string cidade)
        {
            this.Cep = cep;
            this.Numero = numero;
            this.Cidade = cidade;
        }

        public string Cep { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }

        public Endereco ComNumero(int numero) => new Endereco(this.Cep, numero, this.Cidade);

        public bool Equals(Endereco other)
        {
            if (other is null)
            {
                return false;
            }

            return this.Cep == other.Cep
                && this.Numero == other.Numero
                && this.Cidade == other.Cidade;
        }

        public override string ToString()
        {
            return $"Cep: {this.Cep}, Numero: {this.Numero}, Cidade: {this.Cidade}";
        }
    }
}
