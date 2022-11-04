using aula02.models;

Pessoa p1 = new Pessoa(nome: "Natan", sobrenome: "Cordeiro");
Pessoa p2 = new Pessoa(nome: "Rafaela", sobrenome: "Targino");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
