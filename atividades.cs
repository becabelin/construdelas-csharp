using System;
using System.Collections.Generic;

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

            Console.WriteLine("ATIVIDADE 1: Somar números!" +
                "\nDigite os números separados por ','");

            string numeros = Console.ReadLine();
            var numerosArray = numeros.Split(',');
            int soma = 0;

            foreach (string item in numerosArray)
            {

                soma += int.Parse(item);
            }

            Console.WriteLine($"A soma dos números é: {soma}");


            // ATIVIDADE 2
            /** faça um programa que leia o nome e o valor do produto digitado, após digitar,
               faça o cálculo de 5% sobre o valor do produto, no final do programa mostre a
               mensagem:
               "O valor calculado foi x% do produto y"
            **/

            Console.WriteLine("ATIVIDADE 2: Calcular o desconto de 5% em um produto" +
                "\nDigite o nome do seu produto");
            string nome = Console.ReadLine().ToLower();

            Console.WriteLine("Digite o valor do seu produto");
            var valor = Console.ReadLine();

            var desconto = double.Parse(valor) * 0.05;

            Console.WriteLine("O valor de desconto do seu produto (" + nome + ") é de " + desconto);

            //ATIVIDADE 3
            /** faça um programa que solicite 3 números faça a multiplicação dos mesmos e,
                no resultado final, verifique se este número é maior que 10 e menor que 20 ou
                maior que 100 e menor que 200, ou maior quem 1000 e menor que 2000
                caso seja verdadeira a condição, mostre a mensagem = "Sim, é verdade, você achou o número premiado!"
                se não, mostre "Infelizmente você perdeu"
            **/

            Console.WriteLine("ATIVIDADE 3: Multiplicar 3 números para tentar tirar o número premiado" +
                "\nDigite o primeiro número");
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

            Console.WriteLine("ATIVIDADE 4: Colocar o nome certo para sair uma frase" +
                "\nDigite o seu nome");
            nome = Console.ReadLine().ToLower();

            if (nome == "leo")
            {
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

            // ATIVIDADE 5
            /** faça um programa para calcular a tabuada do número que o usuário digitar.
                no programa o usuário vai digitar o número da tabuada e a quantidade de números a
                calcular. o resultado final é para mostrar exemplo X * Y = ZZ para todos os números
            **/

            Console.WriteLine("ATIVIDADE 5: Calcular a tabuada de qualquer número em qualquer quantidade" +
                "\nDigite o número que você quer multiplicar");
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

            // ATIVIDADE 6
            /** faça um programa que solicite o nome de 3 alunos e 4 notas para eles
             * (ou seja, 4 notas para cada um) e calcule a média das notas.
             * no final do programa, mostre um relatório da seguinte forma:
             * Aluno: xxx, média: ?, notas: (?,?,?,?), Status: Aprovado ou Reprovado (aprovado média > 5)
            **/

            List<string> nomesAlunos = new List<string>();
            List<string> notasDosAlunos = new List<string>();
            List<string> matriculaDosAlunos = new List<string>();

            int qtd = 3;

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"ATIVIDADE 6: Pegar os dados de 3 alunos e dizer se foram aprovados" +
                    $"\nDigite o nome do {i}º aluno(a):");
                nomesAlunos.Add(Console.ReadLine());
                var nomeAluno = nomesAlunos[i - 1];

                Console.WriteLine($"Digite a matricula do(a) {nomeAluno}:");
                matriculaDosAlunos.Add(Console.ReadLine());

                Console.WriteLine($"Digite as 4 notas do aluno(a) {nomeAluno} separados por ','");
                string notas = Console.ReadLine();

                notasDosAlunos.Add(notas);
            }

            for (int i = 0; i < qtd; i++)
            {
                double somanotas = 0;
                var notasSeparadasPorVirgula = notasDosAlunos[i];
                var notas = notasSeparadasPorVirgula.Split(',');
                foreach (var nota in notas)
                {
                    somanotas += Convert.ToDouble("0" + nota);
                }

                double media = somanotas / notas.Length;
                string status = media > 5 ? "Aprovado" : "Reprovado";

                Console.WriteLine($"Aluno(a): {nomesAlunos[i]}, matrícula: {matriculaDosAlunos[i]}, notas: ({string.Join(",", notas)}), média: {media.ToString("#.##")}, status: {status}");
            }

        }

    }
}