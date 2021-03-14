using System;
using System.IO;

namespace ExemploSW01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abrindo arquivo para gravação
            StreamWriter arquivo = new StreamWriter(@"C:\temp\arq.txt", true);
            // Gravando dados do João da Silva (nome, sexo, idade, peso, altura)
            arquivo.WriteLine("João da Silva");
            arquivo.WriteLine('M');
            arquivo.WriteLine(45);
            arquivo.WriteLine(85);
            arquivo.WriteLine(1.78);

            // Gravando dados do Maria José (nome, idade, peso, altura)
            arquivo.WriteLine("Maria José");
            arquivo.WriteLine('F');
            arquivo.WriteLine(53);
            arquivo.WriteLine(72);
            arquivo.WriteLine(1.69);

            // Gravando dados do Carlos Eudardo (nome, idade, peso, altura)
            arquivo.WriteLine("Carlos Eduardo");
            arquivo.WriteLine('M');
            arquivo.WriteLine(28);
            arquivo.WriteLine(81);
            arquivo.WriteLine(1.83);

            arquivo.Close();
        }
    }
}
