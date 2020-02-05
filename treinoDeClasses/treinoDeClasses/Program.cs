using System;
using System.Globalization;

namespace treinoDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos sua casa possui?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string vetor = Console.ReadLine();
            string[] v = vetor.Split(' ');
            string v1 = v[0];
            int v2 = int.Parse (v[1]);
            double v3 = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3.ToString("F2", CultureInfo.InvariantCulture));
        
        
        }
    }
}