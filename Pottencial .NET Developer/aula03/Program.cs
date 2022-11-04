
// Tratamento de erros
try
{
    // Lendo arquivos do sistema
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro de leitura. Arquivo não encontrado. {ex.Message}");
} 
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui.");
}

