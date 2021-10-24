using System;

namespace ConstruDelasConsole
{
    class atividades
    {
        static void Main(string[] args)
        {

            // ATIVIDADE 1
            /** dado os tipos de convers�es e os comandos para mostrar e ler os dados na tela,
                fa�a um programa para caputar tr�s n�meros(int) separados por v�rgula, e no final mostre o
                resultado da soma dos mesmos
            **/

            Console.WriteLine("Digite os n�meros separados por ','");

            string numeros = Console.ReadLine();
            var numerosArray = numeros.Split(',');
            int soma = 0;

            foreach (string item in numerosArray) {

                soma += int.Parse(item);
            }

            Console.WriteLine($"A soma dos n�meros �: {soma}");


            // ATIVIDADE 2
            /** fa�a um programa que leia o nome e o valor do produto digitado, ap�s digitar,
               fa�a o c�lculo de 5% sobre o valor do produto, no final do programa mostre a
               mensagem:
               "O valor calculado foi x% do produto y"
            **/

            Console.WriteLine("Digite o nome do seu produto");
            string nome = Console.ReadLine().ToLower();

            Console.WriteLine("Digite o valor do seu produto");
            var valor = Console.ReadLine();

            var desconto = double.Parse(valor) * 0.05;

            Console.WriteLine("O valor de desconto do seu produto (" + nome +") � de " + desconto);

            //ATIVIDADE 3
            /** fa�a um programa que solicite 3 n�meros fa�a a multiplica��o dos mesmos e,
                no resultado final, verifique se este n�mero � maior que 10 e menor que 20 ou
                maior que 100 e menor que 200, ou maior quem 1000 e menor que 2000
                caso seja verdadeira a condi��o, mostre a mensagem = "Sim, � verdade, voc� achou o n�mero premiado!"
                se n�o, mostre "Infelizmente voc� perdeu"
            **/

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

            //ATIVIDADE 4
            /** fa�a um programa que pe�a para digitar um nome
                caso o nome digitado for Leo mostre "Ol�, Leo!"
                caso o nome digitado for Dirceu mostre "Opa, e a�, Dirceu?"
                caso o nome digitado for Thais mostre "Nossa, Thais, que vestido lindo!"
                caso n�o for nenhum, mostre "Op��o inv�lida."
            **/

            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine().ToLower();

            if (nome == "leo") {
                Console.WriteLine("Ol�, Leo!");
            }
            else if (nome == "dirceu")
            {
                Console.WriteLine("Opa, e a�, Dirceu?");
            }
            else if (nome == "thais")
            {
                Console.WriteLine("Nossa, Thais, que vestido lindo!");
            }    
            else
            {
                Console.WriteLine("Op��o inv�lida.");
            }

            /** fa�a um programa para calcular a tabuada do n�mero que o usu�rio digitar.
                no programa o usu�rio vai digitar o n�mero da tabuada e a quantidade de n�meros a
                calcular. o resultado final � para mostrar exemplo X * Y = ZZ para todos os n�meros
            **/

            Console.WriteLine("Digite o n�mero que voc� quer multiplicar");
            var tabuada = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas vezes voc� quer calcular?");
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