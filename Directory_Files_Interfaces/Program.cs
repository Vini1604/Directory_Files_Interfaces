using System;
using System.IO;

namespace Directory_Files_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho;

            Console.Write("Digite o camminho desejado: ");
            caminho = Console.ReadLine();

            GerenciadorRegistros gerenciador = new GerenciadorRegistros(new RegistroEmArquivo(caminho));

            try
            {
                gerenciador.ImprimeDiretorios();
                gerenciador.ImprimeFuncionarios();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine();
                Console.WriteLine("Diretorio nao encontrado");
            }

            
        }
    }
}
