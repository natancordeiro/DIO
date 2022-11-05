using aula06.Models;
using Newtonsoft.Json;

// Tipos especiais

// NULOS
bool? desejaReceberEamail = null;

if(desejaReceberEamail.HasValue && desejaReceberEamail.Value)
{
    Console.WriteLine("O usuario deseja receber e-mail.");
}
else
{
    Console.WriteLine("O usuario não deseja receber e-mail.");
}

// TIPOS ANÔNIMOS - Somente leitura
var tipoAnonimo = new { Nome = "Natan", Sobrenome = "Cordeiro", Altura = 1.86 };

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);

// Usando tipos anônimos
string conteudo = File.ReadAllText("Arquivos/vendas.json");
List<VendaJSON> listaVendas = JsonConvert.DeserializeObject<List<VendaJSON>>(conteudo);

var listaAnonimo = listaVendas.Select(x => new { x.Produto, x.Preco});

foreach(var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}
// testando a classe genérica

MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArry(30);

Console.WriteLine(arrayInteiro[0]);
