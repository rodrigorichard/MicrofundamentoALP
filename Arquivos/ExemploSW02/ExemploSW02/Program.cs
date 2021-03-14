using System;
using System.IO;

namespace ExemploSW02
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

        static void GravaDados(string nome, char sexo, int idade, Double peso, Double altura)
        {
            arquivo.WriteLine(nome);
            arquivo.WriteLine(sexo);
            arquivo.WriteLine(idade);
            arquivo.WriteLine(peso);
            arquivo.WriteLine(altura);
        }

        static void Main(string[] args)
        {
            // Abrindo arquivo para gravação
            AbreArquivo(@"C:\temp\arq2.txt");
            // Gravando dados do João da Silva (nome, sexo, idade, peso, altura)
            GravaDados("João da Silva", 'M', 45, 85, 1.78);

            // Gravando dados do Maria José (nome, idade, peso, altura)
            GravaDados("Maria José", 'F', 53, 72, 1.69);

            // Gravando dados do Carlos Eudardo (nome, idade, peso, altura)
            GravaDados("Carlos Eduardo", 'M', 28, 81, 1.83);

            FechaArquivo();
        }
    }
}
