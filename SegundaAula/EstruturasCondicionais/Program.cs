//Aprendendo as estruturas condicionais
//if simples
    //Exercicio: Imprima no terminal a seguinte mensagem, se hoje for sexta-feira: "Sextouuuu!!!!"
    // string diaDaSemana = "Sexta-feira";

    // if(diaDaSemana == "Sexta-feira"){
    //     Console.WriteLine("Sextouuuu!!!!");
    // }

//if composto
    //Crie um sistema que verifique se o aluno é menor ou maior de idade.
    // int idade = 9;

    // if(idade >= 18){
    //     Console.WriteLine("O aluno é maior de idade");
    // }else{
    //     Console.WriteLine("O aluno é menor de idade");
    // }

//if encadeado 
    // int idade = -9;

    // if(idade >= 18){
    //     Console.WriteLine("O aluno é maior de idade");
    // }else if(idade < 18 && idade > 0){
    //     Console.WriteLine("O aluno é menor de idade");
    // }else{
    //     Console.WriteLine("A idade informada está incorreta");
    // }

    //Switch case
    //Exercicio: Quero que apareça uma mensagem dependendo da opção que o usuário escolher
    //a -> voce escolheu a opção A
    //b -> voce escolheu a opção B
    //c -> voce escolheu a opção C
    char opcao = 'a';

    switch(opcao){
        case 'a':
            Console.WriteLine("voce escolheu a opção A");
            break;
        case 'b':
             Console.WriteLine("voce escolheu a opção B");
        break;
        case 'c':
             Console.WriteLine("voce escolheu a opção C");
        break;
    }
