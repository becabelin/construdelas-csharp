using System;

namespace ConstruDelasConsole
{
    class atividades
    {
        static void Main(string[] args)
        {

            // ATIVIDADE 1
            /** dado os tipos de conversões e os comandos para mostrar e ler os dados na tela,
                faça um programa para caputar três números(int) separados por vírgula, e no final mostre o
                resultado da soma dos mesmos
            **/

            Console.WriteLine("Digite os números separados por ','");

            string numeros = Console.ReadLine();
            var numerosArray = numeros.Split(',');
            int soma = 0;

            foreach (string item in numerosArray) {

                soma += int.Parse(item);
            }

            Console.WriteLine($"A soma dos números é: {soma}");


            // ATIVIDADE 2
            /** faça um programa que leia o nome e o valor do produto digitado, após digitar,
               faça o cálculo de 5% sobre o valor do produto, no final do programa mostre a
               mensagem:
               "O valor calculado foi x% do produto y"
            **/

            Console.WriteLine("Digite o nome do seu produto");
            string nome = Console.ReadLine().ToLower();

            Console.WriteLine("Digite o valor do seu produto");
            var valor = Console.ReadLine();

            var desconto = double.Parse(valor) * 0.05;

            Console.WriteLine("O valor de desconto do seu produto (" + nome +") é de " + desconto);

            //ATIVIDADE 3
            /** faça um programa que solicite 3 números faça a multiplicação dos mesmos e,
                no resultado final, verifique se este número é maior que 10 e menor que 20 ou
                maior que 100 e menor que 200, ou maior quem 1000 e menor que 2000
                caso seja verdadeira a condição, mostre a mensagem = "Sim, é verdade, você achou o número premiado!"
                se não, mostre "Infelizmente você perdeu"
            **/

            Console.WriteLine("Digite o primeiro número");
            var primeironumero = Console.ReadLine();
            Console.WriteLine("Digite o segundo número");
            var segundonumero = Console.ReadLine();
            Console.WriteLine("Digite o terceiro número");
            var terceironumero = Console.ReadLine();

            var multiplicacao = int.Parse(primeironumero) * int.Parse(segundonumero) * int.Parse(terceironumero);

            if (multiplicacao > 10 && multiplicacao < 20)
            {
                Console.WriteLine("Você tirou " + multiplicacao + ". Você achou o número premiado!");
            }
            else if (multiplicacao > 100 && multiplicacao < 200)
            {
                Console.WriteLine("Você tirou " + multiplicacao + ". Você achou o número premiado!");
            }
            else if (multiplicacao > 1000 && multiplicacao < 2000)
            {
                Console.WriteLine("Você tirou " + multiplicacao + ". Você achou o número premiado!");
            }
            else
            {
                Console.WriteLine("Você tirou " + multiplicacao + ". Infelizmente você perdeu.");
            }

            //ATIVIDADE 4
            /** faça um programa que peça para digitar um nome
                caso o nome digitado for Leo mostre "Olá, Leo!"
                caso o nome digitado for Dirceu mostre "Opa, e aí, Dirceu?"
                caso o nome digitado for Thais mostre "Nossa, Thais, que vestido lindo!"
                caso não for nenhum, mostre "Opção inválida."
            **/

            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine().ToLower();

            if (nome == "leo") {
                Console.WriteLine("Olá, Leo!");
            }
            else if (nome == "dirceu")
            {
                Console.WriteLine("Opa, e aí, Dirceu?");
            }
            else if (nome == "thais")
            {
                Console.WriteLine("Nossa, Thais, que vestido lindo!");
            }    
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            /** faça um programa para calcular a tabuada do número que o usuário digitar.
                no programa o usuário vai digitar o número da tabuada e a quantidade de números a
                calcular. o resultado final é para mostrar exemplo X * Y = ZZ para todos os números
            **/

            Console.WriteLine("Digite o número que você quer multiplicar");
            var tabuada = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas vezes você quer calcular?");
            var numerodevezes = int.Parse(Console.ReadLine());

            int inicio = 1;

            while (inicio <= numerodevezes)
            {
                var resultado = tabuada * inicio;
                Console.WriteLine(tabuada + " * " + inicio + " = " + resultado);
                inicio++;
            }

        }

    }
}