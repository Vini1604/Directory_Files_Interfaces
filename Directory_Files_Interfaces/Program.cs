using System;
using System.IO;

namespace Directory_Files_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho;
            string []conteudoArquivo;
            Console.Write("Digite o camminho desejado: ");
            caminho = Console.ReadLine();

            IRegistro tipoRegistro = new RegistroEmArquivo(caminho);

            var entidades = tipoRegistro.ListarDiretorios();
            foreach (var entidade in entidades)
            {
                Console.WriteLine(entidade);
            }
            
        }
    }
}
