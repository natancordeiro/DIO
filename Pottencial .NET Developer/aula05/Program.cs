using aula05.Models;
using Newtonsoft.Json;

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

//-------------------------------------------------
// Converter para JSON 

// Passando a data atual do momento da venda
DateTime dataAtual = DateTime.Now;

List<Vendas> listaVendas = new List<Vendas>();

Vendas v1 = new Vendas(1, "Material de escritório", 25.00M, dataAtual);
Vendas v2 = new Vendas(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);

// Deserializando JSON

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<VendaJSON> listaVenda = JsonConvert.DeserializeObject<List<VendaJSON>>(conteudoArquivo);

foreach(VendaJSON item in listaVenda)
{
    Console.WriteLine($"Id: {item.Id}, Produto: {item.Produto}," +
            $"Preço: {item.Preco}, Data: {item.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}
