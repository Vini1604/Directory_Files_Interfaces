using System;
using System.Collections.Generic;
using System.IO;

namespace Directory_Files_Interfaces
{
    class RegistroEmArquivo : IRegistro
    {
        public string Caminho { get; set; }
        public RegistroEmArquivo()
        {

        }

        public RegistroEmArquivo(string caminho)
        {
            Caminho = caminho;
        }
        public List<string> ListarDiretorios()
        {
            List<string> entidades = new List<string>();
            var arquivosEpastas = Directory.EnumerateFileSystemEntries(Caminho);
            foreach (var entidade in arquivosEpastas)
            {
                entidades.Add(entidade.Remove(0, Caminho.Length));
            }

            return entidades;
        }

        public List<Funcionario> ListarFuncionarios()
        {
            throw new NotImplementedException();
        }

        public void MoverArquivoInvalido(string caminhoArquivo)
        {
            throw new NotImplementedException();
        }

        public void MoverArquivoValido(string caminhoArquivo)
        {
            throw new NotImplementedException();
        }

    }
}
