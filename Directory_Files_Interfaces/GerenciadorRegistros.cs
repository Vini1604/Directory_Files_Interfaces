using System;
using System.Collections.Generic;
using System.Text;

namespace Directory_Files_Interfaces
{
    class GerenciadorRegistros
    {
        private IRegistro _tipoRegistro;
        public List<Funcionario> Funcionarios { get; set; }
        public GerenciadorRegistros()
        {

        }
        public GerenciadorRegistros(IRegistro tipoRegistro)
        {
            _tipoRegistro = tipoRegistro;
            Funcionarios = new List<Funcionario>();
        }

        public void ImprimeDiretorios()
        {
            List<string> arquivos = _tipoRegistro.ListarArquivos();

            Console.WriteLine();
            Console.WriteLine("Arquivos encontrados no diretorio: ");
            foreach (string arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
        }

        public void ImprimeFuncionarios()
        {
            Funcionarios = _tipoRegistro.ListarFuncionarios();

            Console.WriteLine();
            if (Funcionarios.Count == 0)
            {
                Console.WriteLine("Nao ha funcionarios a serem listados!!");
            }
            else
            {
                Console.WriteLine("Funcionarios encontrados: ");
                Console.WriteLine();
                Console.WriteLine("Id ".PadRight(10) + " Nome ".PadRight(30) + " Data de Nascimento ".PadRight(30) + " Salario ".PadRight(15));
                foreach (Funcionario funcionario in Funcionarios)
                {
                    Console.WriteLine(funcionario);
                }
            }
        }
    }
}
