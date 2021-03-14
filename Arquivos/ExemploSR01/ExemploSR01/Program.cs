using System;
using System.IO;

namespace ExemploSR01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abrindo arquivo para gravação
            StreamReader arquivo = new StreamReader(@"C:\temp\arq.txt");

            String linha = arquivo.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = arquivo.ReadLine();
            }
            arquivo.Close();
            Console.ReadKey();
        }
    }
}
