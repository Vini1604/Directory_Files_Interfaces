# Diretorios, Arquivos e Interfaces

## Enunciado

1 - Criar um programa para solicitar o usuário um diretório e listar no console TODOS os arquivos do diretório informado.

Ex: C:\temp

****************** Arquivos do Diretório ********************  
arquivoA.txt  
arquivoB.txt  
arquivoC.txt  
dadosA.IBMDOTNET  
dadosB.IBMDOTNET  
dadosC.IBMDOTNET  

2 - Criar um arquivo Ex: dados.IBMDOTNET que vai conter o seguinte conteúdo:

Estrutura do arquivo: Id = inteiro, nome completo = literal, data nascimento = tipo DATA, salario = decimal

id;nome completo;data nascimento;salario
1;jefte goes;10/04/1991;10000.00
2;bruna;10/04/1991;20000.00
3;enzo;10/04/1991;10000.00

3 - Criar uma classe Funcionario baseada no layout acima

No MESMO programa, caso exista na pasta informada pelo usuário um arquivo com a extensão .IBMDOTNET o mesmo DEVE ser lido e armazenado em List<Funcionario>.

4 - Imprimir na tela os dados a partir do List<Funcionario>, com o seguinte layout  
Id             Nome             Data de nascimento           Salario

5 - Depois que o arquivo for lido o arquivo dados.IBMDOTNET, mover para pasta PROCESSADOS, em caso de qualquer ERRO (try catch), mover para pasta ERROR e excluir o arquivo original.
 - Um exemplo de erro seria a data inválida

6 - Criar uma Interface para encapsular todos os métodos que interagem com arquivos e implementar sua respectiva classe.

List<string> ListarDiretorios();
List<Funcionario> ListaFuncionarios();
void MoverArquivoSucesso();
void MoverArquivoErro();

Dicas (Sugestão):  
1 - Usar o Directory  
2 - Usar o FileStream/StreamReader e MinhaVariavelString.Split(";") para transformar uma string em um array de strings  
