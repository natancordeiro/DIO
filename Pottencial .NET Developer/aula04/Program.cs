
// FILAS
Queue<int> fila = new Queue<int>();

// Adicionar elementos no fim da fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila) 
{
    Console.WriteLine(item);
}

// Remove o primeiro elemento
Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach(int item in fila) 
{
    Console.WriteLine(item);
}
// -------------------------------------------

// PILHAS 
Stack<int> pilha = new Stack<int>();

// Adicionar elementos no fim da fila
pilha.Push(4);
pilha.Push(6);
pilha.Push(2);
pilha.Push(10);

foreach(int item in pilha) 
{
    Console.WriteLine(item);
}

// Remove o elemento do topo
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// -------------------------------------------

// DICIONARIOS - chave, valor
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(KeyValuePair<string, string> item in estados) 
{
    Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
}

Console.WriteLine("-------------");

estados.Remove("BA");

// Alterando valor (não é possivel alterar a chave)
estados["SP"] = "São Paulo - alterado";

foreach(var item in estados) 
{
    Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

// Verificando se há chave
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existente: {chave}");
}
