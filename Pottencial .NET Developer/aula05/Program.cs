using aula05.Models;

// TUPLAS 
(int id, string nome, string sobrenome) tupla = (1, "Natan", "Cordeiro");

Console.WriteLine($"Id: {tupla.id}");
Console.WriteLine($"Nome: {tupla.nome}");
Console.WriteLine($"Sobrenome: {tupla.sobrenome}");

//-----------------------------------------------
// Método retornando uma tupla

LeituraArquivo arquivo = new LeituraArquivo();
arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
//                        Descarte
if (sucesso)
{
    //Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo.");
}
//------------------------------------------------
// IF TERNÁRIO

int numero = 10;
bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));
