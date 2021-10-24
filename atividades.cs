using System;

namespace ConstruDelasConsole
{
    class atividades
    {
        static void Main(string[] args)
        {

            // ATIVIDADE 1
            /* dado os tipos de convers�es e os comandos para mostrar e ler os dados na tela,
            * fa�a um programa para caputar dois n�meros(int), e no final mostre o
            * resultado da soma dos mesmos
            */

            Console.WriteLine("Digite um n�mero");
            var numero1 = Console.ReadLine();

            Console.WriteLine("Digite outro n�mero");
            var numero2 = Console.ReadLine();

            var somanumeros = int.Parse(numero1) + int.Parse(numero2);

            Console.WriteLine("A soma de " + numero1 + " e " + numero2 + " �: " + somanumeros);


            // ATIVIDADE 2
            /* fa�a um programa que leia o nome e o valor do produto digitado, ap�s digitar,
               fa�a o c�lculo de 5% sobre o valor do produto, no final do programa mostre a
               mensagem:
               "O valor calculado foi x% do produto y"
            */

            Console.WriteLine("Digite o nome do seu produto");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o valor do seu produto");
            var valor = Console.ReadLine();

            var desconto = double.Parse(valor) * 0.05;

            Console.WriteLine("O valor de desconto do seu produto (" + nome +") � de " + desconto);

            //ATIVIDADE 3
            /* fa�a um programa que solicite 3 n�meros fa�a a multiplica��o dos mesmos e,
             * no resultado final, verifique se este n�mero � maior que 10 e menor que 20 ou
             * maior que 100 e menor que 200, ou maior quem 1000 e menor que 2000
             * caso seja verdadeira a condi��o, mostre a mensagem = "Sim, � verdade, voc� achou o n�mero premiado!"
             * se nao, mostre "Infelizmente voc� perdeu"
            */

            Console.WriteLine("Digite o primeiro n�mero");
            var primeironumero = Console.ReadLine();
            Console.WriteLine("Digite o segundo n�mero");
            var segundonumero = Console.ReadLine();
            Console.WriteLine("Digite o terceiro n�mero");
            var terceironumero = Console.ReadLine();

            var multiplicacao = int.Parse(primeironumero) * int.Parse(segundonumero) * int.Parse(terceironumero);

            if (multiplicacao > 10 && multiplicacao < 20)
            {
                Console.WriteLine("Voc� tirou " + multiplicacao + ". Voc� achou o n�mero premiado!");
            }
            else if (multiplicacao > 100 && multiplicacao < 200)
            {
                Console.WriteLine("Voc� tirou " + multiplicacao + ". Voc� achou o n�mero premiado!");
            }
            else if (multiplicacao > 1000 && multiplicacao < 2000)
            {
                Console.WriteLine("Voc� tirou " + multiplicacao + ". Voc� achou o n�mero premiado!");
            }
            else
            {
                Console.WriteLine("Voc� tirou " + multiplicacao + ". Infelizmente voc� perdeu.");
            }

        }

    }
}