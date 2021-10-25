using System;
using System.Collections.Generic;

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
                
                Console.WriteLine("ATIVIDADE 1: Somar n�meros!" +
                "\nDigite os n�meros separados por ','");

            string numeros = Console.ReadLine();
            var numerosArray = numeros.Split(',');
            int soma = 0;

            foreach (string item in numerosArray)
            {

                soma += int.Parse(item);
            }

            Console.WriteLine($"A soma dos n�meros �: {soma}");


            // ATIVIDADE 2
            /** fa�a um programa que leia o nome e o valor do produto digitado, ap�s digitar,
                fa�a o c�lculo de 5% sobre o valor do produto, no final do programa mostre a
                mensagem:
                "O valor calculado foi x% do produto y"
 
           Console.WriteLine("\nATIVIDADE 2: Calcular o desconto de 5% em um produto" +
               "\nDigite o nome do seu produto");
           string nome = Console.ReadLine().ToLower();

           Console.WriteLine("Digite o valor do seu produto");
           var valor = Console.ReadLine();

           var desconto = double.Parse(valor) * 0.05;

           Console.WriteLine("O valor de desconto do seu produto (" + nome + ") � de " + desconto.ToString("#.##"));

           //ATIVIDADE 3
           /** fa�a um programa que solicite 3 n�meros fa�a a multiplica��o dos mesmos e,
               no resultado final, verifique se este n�mero � maior que 10 e menor que 20 ou
               maior que 100 e menor que 200, ou maior quem 1000 e menor que 2000
               caso seja verdadeira a condi��o, mostre a mensagem = "Sim, � verdade, voc� achou o n�mero premiado!"
               se n�o, mostre "Infelizmente voc� perdeu"

            Console.WriteLine("\nATIVIDADE 3: Multiplicar 3 n�meros para tentar tirar o n�mero premiado" +
                "\nDigite o primeiro n�mero");

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

            Console.WriteLine("\nATIVIDADE 4: Colocar Leo, Dirceu ou Thais" +
                "\nDigite o seu nome");
            nome = Console.ReadLine().ToLower();

            if (nome == "leo")
            {
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

            // ATIVIDADE 5
            /** fa�a um programa para calcular a tabuada do n�mero que o usu�rio digitar.
                no programa o usu�rio vai digitar o n�mero da tabuada e a quantidade de n�meros a
                calcular. o resultado final � para mostrar exemplo X * Y = ZZ para todos os n�meros

            Console.WriteLine("\nATIVIDADE 5: Calcular a tabuada de qualquer n�mero em qualquer quantidade" +
                "\nDigite o n�mero que voc� quer multiplicar");
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

            // ATIVIDADE 6
            /** fa�a um programa que solicite o nome de 3 alunos e 4 notas para eles
             * (ou seja, 4 notas para cada um) e calcule a m�dia das notas.
             * no final do programa, mostre um relat�rio da seguinte forma:
             * Aluno: xxx, m�dia: ?, notas: (?,?,?,?), Status: Aprovado ou Reprovado (aprovado m�dia > 5)

            List<dynamic> alunos = new List<dynamic>();

            Console.WriteLine("\nATIVIDADE 6: Pegar os dados de 3 alunos e dizer se foram aprovados");
            int qtd = 3;

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Digite o nome do {i}� aluno(a):");
                nome = Console.ReadLine();

                Console.WriteLine($"Digite a matricula de {nome}:");
                var matricula = Console.ReadLine();

                Console.WriteLine($"Digite as 4 notas de {nome} separados por ','");
                string notas = Console.ReadLine();

                alunos.Add(new
                {
                    Nome = nome,
                    Matricula = matricula,
                    Notas = notas
                });

            }

            foreach (var aluno in alunos)
            {
                double somanotas = 0;
                var notas = aluno.Notas.Split(',');
                foreach (var nota in notas)
                {
                    somanotas += Convert.ToDouble("0" + nota);
                }

                double media = somanotas / notas.Length;
                string status = media > 5 ? "Aprovado" : "Reprovado";

                Console.WriteLine($"Aluno(a): {aluno.Nome}, matr�cula: {aluno.Matricula}, notas: ({string.Join(",", notas)}), m�dia: {media.ToString("#.##")}, status: {status}");
            }

            // ATIVIDADE 7
            /** fa�a um programa para venda de produtos, neste programa
                voc� precisa capturar o nome do produto e o valor, depois
                capturar o nome do comprador, o endere�o do comprador e a quantidade
                de produtos. ap�s capturar as informa��es, gere um objeto de pedido,
                vinculando o usuario ao produto selecionado.
            
                relat�rio final:
                Ol� senhor(a) XXX, o valor total de seu pedido �: R$ XXX e os itens s�o:
                Quantidade XXX, Produto: XXX, Ser� entregue no endere�o XXX

            Console.WriteLine("\nATIVIDADE 7: Programa para venda de produtos");

            Console.WriteLine("Digite o produto que voc� selecionou:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o valor desse produto:");
            var valorProduto = Console.ReadLine();

            Console.WriteLine("Digite a quantidade desse produto:");
            var quantidadeProduto = Console.ReadLine();

            Console.WriteLine("Digite o seu nome:");
            string nomeDoCliente = Console.ReadLine();

            Console.WriteLine("Digite o seu endere�o:");
            string enderecoDoCliente = Console.ReadLine();

            Pedido pedido = new Pedido()
            {
                Produto = new Produto()
                {
                    Nome = nomeProduto,
                    Valor = Convert.ToDouble(valorProduto)
                },
                Cliente = new Cliente()
                {
                    Nome = nomeDoCliente,
                    Endereco = enderecoDoCliente,
                },
                    Quantidade = int.Parse(quantidadeProduto),
                    ValorTotal = int.Parse(quantidadeProduto) * Convert.ToDouble(valorProduto)
             };

            Console.WriteLine($"Ol�, {pedido.Cliente.Nome}, o valor total de seu pedido � de R$ {pedido.ValorTotal.ToString("#.##")}" +
                $"\ne os produtos s�o: {pedido.Produto.Nome}, em quantidade {pedido.Quantidade}, " +
                $"\ncom o pre�o de R$ {pedido.Produto.Valor}. Seu pedido ser� entregue no endere�o {pedido.Cliente.Endereco}.");

            // ATIVIDADE 8
            /** fa�a um programa para venda de produtos, neste programa voc� precisa
                capturar o nome de 5 produtos e o valor dos mesmos. depois de capturar os produtos, capturar o nome e
                endere�o de 5 compradores, e tamb�m a quantidade de produtos.
                ap�s capturar as informa��es gerar 5 pedidos com as informa��es.
 
                relat�rio final:
                Ol�, XXX. O valor total de seu pedido � de R$ XXX
                e os itens s�o XXX em quantidade XXX.
                Seu pedido ser� entregue no endere�o XXX.

               Console.WriteLine("\nATIVIDADE 8: Programa para venda de produtos com 5 clientes");

               List<Pedido> pedidos = new List<Pedido>();
               for (var contador = 0; contador <= 5; contador++)
               {
                   Console.WriteLine("\nDigite o produto que voc� selecionou:");
                   string nomeProduto = Console.ReadLine();

                   Console.WriteLine("\nDigite o valor desse produto:");
                   var valorProduto = Console.ReadLine();

                   Console.WriteLine("\nDigite a quantidade desse produto:");
                   var quantidadeProduto = Console.ReadLine();

                   Console.WriteLine("\nDigite o seu nome:");
                   string nomeDoCliente = Console.ReadLine();

                   Console.WriteLine("\nDigite o seu endere�o:");
                   string enderecoDoCliente = Console.ReadLine();

                   Pedido pedido = new Pedido()
                   {
                       Produto = new Produto()
                       {
                           Nome = nomeProduto,
                           Valor = Convert.ToDouble(valorProduto)
                       },
                       Cliente = new Cliente()
                       {
                           Nome = nomeDoCliente,
                           Endereco = enderecoDoCliente,
                       },
                       Quantidade = int.Parse(quantidadeProduto),
                       ValorTotal = int.Parse(quantidadeProduto) * Convert.ToDouble(valorProduto)
                   };

                   pedidos.Add(pedido);
               }

               foreach (var pedido in pedidos)
               {
                   Console.WriteLine($"\nOl�, {pedido.Cliente.Nome}, o valor total de seu pedido � de R$ {pedido.ValorTotal.ToString("#.##")}" +
                   $"\ne os produtos s�o: {pedido.Produto.Nome}, em quantidade {pedido.Quantidade}, " +
                   $"\ncom o pre�o de R$ {pedido.Produto.Valor}. Seu pedido ser� entregue no endere�o {pedido.Cliente.Endereco}.");

                   Console.WriteLine($"-----------------------------------------");
               }

               // ATIVIDADE 9
               /** Josevaldo � dono de uma cadeia de fast food.
                   fa�a um programa que cadastre os ingredientes de um hamb�rguer,
                   que cadastre um hamb�rguer selecionando os ingredientes
                   e fa�a um pedido para um cliente selecionando os hamb�rgueres.
                 
                   no final do programa, mostre um relat�rio com os clientes e seus pedidos
                   com o detalhe sobre tudo, mostrando os hamb�rgueres e os detalhes do hamb�rguer
                   
                   Ex:
                   Pedido do(a) XXX
                   Ele escolheu os hamburgers
                       - Gold Premium
                         - Salada
                         - Molho
                         - Carne
                         - Picles
                       - Prata Gerge
                         - Salada
                         - Molho
                         - Carne
                         - Gergelim
                   Valor total de R$ 200 reais
                   ------------------------------------------
                   Pedido do(a) YYY
                   Ele escolheu os hamburgers
                       - Cearense
                         - Salada
                         - Molho
                         - Carne de sol
                         - Ovo
                       - Prata Chicken
                         - Salada
                         - Molho
                         - Frango
                         - Queijo
                         - Bacon
                   Valor total de R$ 230 reais
                   **/

        }
    }
}