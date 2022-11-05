using System;
// CRIANDO ARRAYS

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

// REDIMENSIONANDO O TAMANHO DO ARRAY
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// COPIANDO VALORES DE UM ARRAY PARA OUTRO
int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

// FOR - PERCORRENDO UM ARRAY
Console.WriteLine("Percorrendo o Array com FOR.");
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}

int contadorForeach = 0;

// FOREACH - PERCORRENDO UM ARRAY
Console.WriteLine("Percorrendo o Array com FOREACH.");
foreach(int valor in arrayInteiros) 
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {arrayInteiros[contadorForeach]}");
    contadorForeach++;
}

// --------------------------------------------------------------------------------------


// TRABALHANDO COM LSITAS

// DECLARANDO UMA LISTA
List<string> listaString = new List<string>();

// ADICIONANDO ELEMENTOS
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");



// PERCORRENDO A LISTA
for(int cont = 0; cont < listaString.Count; cont++)
{
    Console.WriteLine($"Posição Nº {cont} - {listaString[cont]}");
}

int contForeach = 0;
foreach(string item in listaString) 
{
    Console.WriteLine($"Posição Nº {contForeach} - {listaString[contForeach]}");
    contForeach++;
}
