﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Directory_Files_Interfaces
{
    interface IRegistro
    {
        List<string> ListarArquivos();
        List<Funcionario> ListarFuncionarios();
        void MoverArquivoValido(string caminhoArquivo);
        void MoverArquivoInvalido(string caminhoArquivo);
    }
}
