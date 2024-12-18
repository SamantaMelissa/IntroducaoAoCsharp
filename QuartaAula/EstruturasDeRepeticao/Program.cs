//Laços de repetição!!!!!!!!!
// ✅while, ✅do while, for, foreach

//For -> para
//Usado quando sabemos EXATAMENTE quantas vezes o bloco de código será executado.

//Exemplo 01: A mensagem: "Amo minhas férias!" apareça 5 vezes
// for(inicialização; condição; incremento/decremento){}

// for(int contador = 1; contador <=3; contador++){
//     Console.WriteLine($"Amo minhas férias!");
// }

//Exemplo 02: Quero que seja impresso a tabuada do 10:
// 1x10 = 10
// 2x10 = 20
// 3x10 = 30
// for(int numero = 1; numero <= 10; numero++){
//     int resultado = numero * 10;
//     Console.WriteLine($"{numero} x 10 = {resultado}");
// }
// System.Console.WriteLine("---------------------------------------------------");
// for(int numero = 10; numero >= 1; numero--){
//     int resultado = numero * 10;
//     Console.WriteLine($"{numero} x 10 = {resultado}");
// }

//Foreach -> para cada
// coleção de dados -> arrays, listas, dicionários

//foreach(tipodavariavel nomedavariavel in nomedacolecao){}
//foreach(int exemplo in arrayexemplo){}

//Array
// string[] nomes = {"samanta", "ryan", "Ana", "Sodré", "Eduarda", "Gabriel"};

// // Console.WriteLine($"A {nomes[0]} ganhou na Mega");
// // Console.WriteLine($"O {nomes[1]} ganhou na Mega");
// // Console.WriteLine($"A {nomes[2]} ganhou na Mega");

// foreach(string nomeIndividual in nomes){
//     Console.WriteLine($"O(a) {nomeIndividual} ganhará na mega");
// }

//Criar uma lista do supermercado:
List<string> produtos = new List<string> {"Pão", "Bolacha", "Biscoito", "arroz", "macarrão"};

foreach(string produto in produtos){
    Console.WriteLine($"{produto}");
    
}
