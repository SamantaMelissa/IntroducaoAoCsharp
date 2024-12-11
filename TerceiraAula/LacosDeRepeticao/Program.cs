//Estruturas de repetição são usadas para executar um bloco de código várias vezes, enquanto uma condição for verdadeira.
//While -> Enquanto a condicao for verdadeira, o laço se repete.
    // Estrutura:
    // while(condicao){

    // }

//--------------------------------------------------------------------------------------------

//Quero que meu sistema imprima uma mensagem de boas vindas 5 vezes
// int quantidade = 1;

// //imprima 5 vezes
// while (quantidade <= 100){
//     Console.WriteLine("Seja bem-vindo(a)!");
//     // quantidade = quantidade + 1;
//     quantidade++;
// }

//--------------------------------------------------------------------------------------------

//Quero que meu usário informe a senha de acesso até que ela seja correta
// string senha = "";

// while(senha != "123456"){
//     Console.WriteLine("Informe a senha correta:");
//     senha = Console.ReadLine();
// }

// Console.WriteLine($"Bem vindo(a) ao sistema!");

//--------------------------------------------------------------------------------------------

//Do While -> Fazer e depois verificar a condicao

//O sistema aceita apenas numeros maiores que 0, caso o número seja menor que 0, pergunte o numero ao usuário novamente
    // int numero;

    // do{
    //     Console.WriteLine($"Digite um numero maior que 0:");
    //     numero = int.Parse(Console.ReadLine());
    // }while(numero < 0);

    // Console.WriteLine($"Você informou um número valido. O número informado foi: {numero}");
    
//--------------------------------------------------------------------------------------------

int opcao;

do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Consultar");
    Console.WriteLine("3 - Sair");
    
    Console.Write("Escolha uma opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Opção Cadastrar selecionada.");
            break;
        case 2:
            Console.WriteLine("Opção Consultar selecionada.");
            break;
        case 3:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.WriteLine(); // Linha em branco para formatação
} while (opcao != 3);
