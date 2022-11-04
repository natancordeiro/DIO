using aula02.models;
using System.Globalization;

Pessoa p1 = new Pessoa(nome: "Natan", sobrenome: "Cordeiro");
Pessoa p2 = new Pessoa(nome: "Rafaela", sobrenome: "Targino");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

//------------------------------------------------------------------------------
// Valor monetário
decimal valorMonetario = 1528.40M;

// Setando outra localização do sistema
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//                                 Formatação para a moeda padrão do meu sistema
Console.WriteLine($"{valorMonetario:C}");

// Formatando um unico valor 
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// Formatando porcentagem
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

// Formatando numeros
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

// Formatando datas
DateTime data = DateTime.Now;
// Mostrar somenta a Data (dd/MM/yyyy)
Console.WriteLine(data.ToShortDateString());
// Hora
Console.WriteLine(data.ToShortTimeString());

