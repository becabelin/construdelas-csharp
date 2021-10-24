using System;

namespace ConstruDelasConsole
{
    class atividades
    {
        static void Main(string[] args)
        {

            // ATIVIDADE 1
            /* dado os tipos de conversões e os comandos para mostrar e ler os dados na tela,
            * faça um programa para caputar dois números(int), e no final mostre o
            * resultado da soma dos mesmos
            */

            Console.WriteLine("Digite um número");
            var numero1 = Console.ReadLine();

            Console.WriteLine("Digite outro número");
            var numero2 = Console.ReadLine();

            var somanumeros = int.Parse(numero1) + int.Parse(numero2);

            Console.WriteLine("A soma de " + numero1 + " e " + numero2 + " é: " + somanumeros);


            // ATIVIDADE 2
            /* faça um programa que leia o nome e o valor do produto digitado, após digitar,
               faça o cálculo de 5% sobre o valor do produto, no final do programa mostre a
               mensagem:
               "O valor calculado foi x% do produto y"
            */

            Console.WriteLine("Digite o nome do seu produto");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o valor do seu produto");
            var valor = Console.ReadLine();

            var desconto = double.Parse(valor) * 0.05;

            Console.WriteLine("O valor de desconto do seu produto (" + nome +") é de " + desconto);

            //ATIVIDADE 3
            /* faça um programa que solicite 3 números faça a multiplicação dos mesmos e,
             * no resultado final, verifique se este número é maior que 10 e menor que 20 ou
             * maior que 100 e menor que 200, ou maior quem 1000 e menor que 2000
             * caso seja verdadeira a condição, mostre a mensagem = "Sim, é verdade, você achou o número premiado!"
             * se nao, mostre "Infelizmente você perdeu"
            */

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

        }

    }
}