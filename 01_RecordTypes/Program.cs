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

            var enderecoAmigaDaCris = enderecoCris with { Numero = 200 };
            Console.WriteLine(enderecoAmigaDaCris);
        }
    }

    public record Endereco(string Cep, int Numero, string Cidade);
}
