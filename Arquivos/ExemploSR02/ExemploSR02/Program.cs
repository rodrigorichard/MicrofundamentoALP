using System;
using System.IO;

namespace ExemploSR02
{
    class Program
    {
        static Double IMC(Double P, Double A)
        {
            return P / Math.Pow(A, 2);
        }
        static void Main(string[] args)
        {
            // Abrindo arquivo para gravação
            StreamReader arquivo = new StreamReader(@"C:\temp\arq.txt");
            string nome;
            char sexo;
            int idade;
            Double peso, altura;

            nome = arquivo.ReadLine();
            while (nome != null)
            {
                sexo = char.Parse(arquivo.ReadLine());
                idade = int.Parse(arquivo.ReadLine());
                peso = Double.Parse(arquivo.ReadLine());
                altura = Double.Parse(arquivo.ReadLine());

                Console.WriteLine($"Nome..: {nome}");
                Console.WriteLine($"Sexo..: {sexo}");
                Console.WriteLine($"Idade.: {idade}");
                Console.WriteLine($"Peso..: {peso}");
                Console.WriteLine($"Altura: {altura}");
                Console.WriteLine($"IMC..: {IMC(peso, altura):0.00}\n");
                nome = arquivo.ReadLine();
            }
            arquivo.Close();
            Console.ReadKey();
        }
    }
}
