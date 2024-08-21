using Curso_C_;



//ConceitosPOO conceitos = new ConceitosPOO();

// Explicar Orientação a Objetos
//conceitos.ExplicarOrientacaoAObjetos();

// Explicar a diferença entre Programação Estruturada e Orientada a Objetos
//conceitos.DiferencaEntreParadigmas();

// Explicar os Pilares da Orientação a Objetos
//conceitos.ExplicarPilares();
// 1. Criando Objetos (Instanciando a classe Pessoa)

Pessoa pessoa1 = new Pessoa("Alice", 30);
Pessoa pessoa2 = new Pessoa("Bob", 25);

// 2. Usando Métodos de Instância (Métodos não estáticos)
pessoa1.ExibirInformacoes();
pessoa2.ExibirInformacoes();

// 3. Usando Método Estático (Pertence à Classe, não à instância)
Pessoa.ExibirNumeroDePessoas();

// 4. Membros de Instância vs. Membros Estáticos
Console.WriteLine($"Pessoa1: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
Console.WriteLine($"Pessoa2: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
Console.WriteLine($"Número total de pessoas: {Pessoa.NumeroDePessoas}");