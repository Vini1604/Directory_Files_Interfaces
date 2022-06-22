using System;
using System.Collections.Generic;
using System.IO;

namespace Directory_Files_Interfaces
{
    class RegistroEmArquivo : IRegistro
    {
        public string Caminho { get; set; }
        private List<Funcionario> _funcionarios;
        public RegistroEmArquivo()
        {
            _funcionarios = new List<Funcionario>();
        }

        public RegistroEmArquivo(string caminho)
        {
            Caminho = caminho;
            _funcionarios = new List<Funcionario>();
        }
        public List<string> ListarArquivos()
        {
            List<string> arquivos = new List<string>();
            var arquivosCaminhoCompleto = Directory.EnumerateFiles(Caminho);
            foreach (var arquivo in arquivosCaminhoCompleto)
            {
                arquivos.Add(Path.GetFileName(arquivo));
            }
            return arquivos;

        }

        public List<Funcionario> ListarFuncionarios()
        {
            var arquivosDotNet = Directory.EnumerateFiles(Caminho, "*.IBMDOTNET");
            ExtrairArquivoFuncionarios(arquivosDotNet);
            return _funcionarios;
        }

        public void MoverArquivoInvalido(string caminhoArquivo)
        {
            string nomeArquivo = Path.GetFileName(caminhoArquivo);
            string diretorioError = $"{Caminho}\\ERROR\\{nomeArquivo}";
            File.Move(caminhoArquivo, diretorioError, true);
        }

        public void MoverArquivoValido(string caminhoArquivo)
        {
            string nomeArquivo = Path.GetFileName(caminhoArquivo);
            string diretorioProcessado = $"{Caminho}\\PROCESSADO\\{nomeArquivo}";
            File.Move(caminhoArquivo, diretorioProcessado, true);
            Console.WriteLine();
            Console.WriteLine($"Arquivo {Path.GetFileName(caminhoArquivo)} lido com sucesso!! Movido para a pasta PROCESSADO");
        }

        public void ExtrairArquivoFuncionarios(IEnumerable<string> arquivosDotNet)
        {
            foreach (string arquivo in arquivosDotNet)
            {
                ExtrairFuncionarios(arquivo);
            }
        }

        public void ExtrairFuncionarios(string arquivo)
        {
            try
            {
                using (StreamReader registroFuncionarios = File.OpenText(arquivo))
                {
                    registroFuncionarios.ReadLine();
                    while (!registroFuncionarios.EndOfStream)
                    {

                        string[] registro = registroFuncionarios.ReadLine().Split(";");
                        Funcionario funcionario = GerarFuncionario(registro);
                        _funcionarios.Add(funcionario);
                    }
                }
                MoverArquivoValido(arquivo);
            }

            catch (FormatException e)
            {
                MoverArquivoInvalido(arquivo);
                Console.WriteLine();
                Console.WriteLine($"O arquivo {arquivo} esta danificado: {e.Message} !!! Foi movido para a pasta ERRO");
            }

        }

        public Funcionario GerarFuncionario(string[] registro)
        {
            int id = int.Parse(registro[0]);
            string nome = registro[1];
            DateTime dataNascimento = DateTime.Parse(registro[2]);
            decimal salario = decimal.Parse(registro[3]);
            Funcionario funcionarioExistente = _funcionarios.Find(x => x.Id == id);

            if (funcionarioExistente != null)
            {
                throw new FormatException("Ha registros com mesmo ID");
            }
            else
            {
                return new Funcionario(id, nome, dataNascimento, salario);
            }
        }

    }
}
