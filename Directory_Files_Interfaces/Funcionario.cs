using System;
using System.Collections.Generic;
using System.Text;

namespace Directory_Files_Interfaces
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; private set; }
        public decimal Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, DateTime dataNascimento, decimal salario)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"{Id,-10} {Nome, -30} {DataNascimento, -30:dd/MM/yyyy} {Salario, -15}";
        }
    }
}
