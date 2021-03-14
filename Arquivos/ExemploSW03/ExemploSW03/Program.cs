using System;
using System.IO;

namespace ExemploSW03
{
    class Program
    {
        static StreamWriter arquivo;

        static void AbreArquivo(string Path)
        {
            arquivo = new StreamWriter(@Path, true);
        }

        static void FechaArquivo()
        {
            arquivo.Close();
        }

        static void GravaDados(string n, char s, int i, Double p, Double a)
        {
            arquivo.WriteLine(n);
            arquivo.WriteLine(s);
            arquivo.WriteLine(i);
            arquivo.WriteLine(p);
            arquivo.WriteLine(a);
        }

        static void Main(string[] args)
        {
            string nome;
            char sexo;
            int idade;
            Double peso, altura;

            // Abrindo arquivo para gravação
            AbreArquivo(@"C:\temp\arq3.txt");

            Console.Write("Nome..: ");
            nome = Console.ReadLine();
            while(nome.ToUpper() != "FIM") 
            {   
                // Lê dados
                Console.Write("Sexo..: ");
                sexo = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Idade.: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                altura = Double.Parse(Console.ReadLine());
                Console.Write("Peso..: ");
                peso = Double.Parse(Console.ReadLine());
                // Grava os dados lidos no arquivo
                GravaDados(nome, sexo, idade, altura, peso);
                // Lê o nome da próxima pessoa
                Console.Write("Nome..: ");
                nome = Console.ReadLine();
            }
            FechaArquivo();
            Console.WriteLine("Dados gravados com sucesso!!!");
            Console.ReadKey();
        }
    }
}
