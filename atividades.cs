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
 
           Console.WriteLine("\nATIVIDADE 2: Calcular o desconto de 5% em um produto" +
               "\nDigite o nome do seu produto");
           string nome = Console.ReadLine().ToLower();

           Console.WriteLine("Digite o valor do seu produto");
           var valor = Console.ReadLine();

           var desconto = double.Parse(valor) * 0.05;

           Console.WriteLine("O valor de desconto do seu produto (" + nome + ") é de " + desconto.ToString("#.##"));

           //ATIVIDADE 3
           /** faça um programa que solicite 3 números faça a multiplicação dos mesmos e,
               no resultado final, verifique se este número é maior que 10 e menor que 20 ou
               maior que 100 e menor que 200, ou maior quem 1000 e menor que 2000
               caso seja verdadeira a condição, mostre a mensagem = "Sim, é verdade, você achou o número premiado!"
               se não, mostre "Infelizmente você perdeu"

            Console.WriteLine("\nATIVIDADE 3: Multiplicar 3 números para tentar tirar o número premiado" +
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

            Console.WriteLine("\nATIVIDADE 4: Colocar Leo, Dirceu ou Thais" +
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

            Console.WriteLine("\nATIVIDADE 5: Calcular a tabuada de qualquer número em qualquer quantidade" +
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

            List<dynamic> alunos = new List<dynamic>();

            Console.WriteLine("\nATIVIDADE 6: Pegar os dados de 3 alunos e dizer se foram aprovados");
            int qtd = 3;

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Digite o nome do {i}º aluno(a):");
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

                Console.WriteLine($"Aluno(a): {aluno.Nome}, matrícula: {aluno.Matricula}, notas: ({string.Join(",", notas)}), média: {media.ToString("#.##")}, status: {status}");
            }

            // ATIVIDADE 7
            /** faça um programa para venda de produtos, neste programa
                você precisa capturar o nome do produto e o valor, depois
                capturar o nome do comprador, o endereço do comprador e a quantidade
                de produtos. após capturar as informações, gere um objeto de pedido,
                vinculando o usuario ao produto selecionado.
            
                relatório final:
                Olá senhor(a) XXX, o valor total de seu pedido é: R$ XXX e os itens são:
                Quantidade XXX, Produto: XXX, Será entregue no endereço XXX

            Console.WriteLine("\nATIVIDADE 7: Programa para venda de produtos");

            Console.WriteLine("Digite o produto que você selecionou:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o valor desse produto:");
            var valorProduto = Console.ReadLine();

            Console.WriteLine("Digite a quantidade desse produto:");
            var quantidadeProduto = Console.ReadLine();

            Console.WriteLine("Digite o seu nome:");
            string nomeDoCliente = Console.ReadLine();

            Console.WriteLine("Digite o seu endereço:");
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

            Console.WriteLine($"Olá, {pedido.Cliente.Nome}, o valor total de seu pedido é de R$ {pedido.ValorTotal.ToString("#.##")}" +
                $"\ne os produtos são: {pedido.Produto.Nome}, em quantidade {pedido.Quantidade}, " +
                $"\ncom o preço de R$ {pedido.Produto.Valor}. Seu pedido será entregue no endereço {pedido.Cliente.Endereco}.");

            // ATIVIDADE 8
            /** faça um programa para venda de produtos, neste programa você precisa
                capturar o nome de 5 produtos e o valor dos mesmos. depois de capturar os produtos, capturar o nome e
                endereço de 5 compradores, e também a quantidade de produtos.
                após capturar as informações gerar 5 pedidos com as informações.
 
                relatório final:
                Olá, XXX. O valor total de seu pedido é de R$ XXX
                e os itens são XXX em quantidade XXX.
                Seu pedido será entregue no endereço XXX.

               Console.WriteLine("\nATIVIDADE 8: Programa para venda de produtos com 5 clientes");

               List<Pedido> pedidos = new List<Pedido>();
               for (var contador = 0; contador <= 5; contador++)
               {
                   Console.WriteLine("\nDigite o produto que você selecionou:");
                   string nomeProduto = Console.ReadLine();

                   Console.WriteLine("\nDigite o valor desse produto:");
                   var valorProduto = Console.ReadLine();

                   Console.WriteLine("\nDigite a quantidade desse produto:");
                   var quantidadeProduto = Console.ReadLine();

                   Console.WriteLine("\nDigite o seu nome:");
                   string nomeDoCliente = Console.ReadLine();

                   Console.WriteLine("\nDigite o seu endereço:");
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
                   Console.WriteLine($"\nOlá, {pedido.Cliente.Nome}, o valor total de seu pedido é de R$ {pedido.ValorTotal.ToString("#.##")}" +
                   $"\ne os produtos são: {pedido.Produto.Nome}, em quantidade {pedido.Quantidade}, " +
                   $"\ncom o preço de R$ {pedido.Produto.Valor}. Seu pedido será entregue no endereço {pedido.Cliente.Endereco}.");

                   Console.WriteLine($"-----------------------------------------");
               }

               // ATIVIDADE 9
               /** Josevaldo é dono de uma cadeia de fast food.
                   faça um programa que cadastre os ingredientes de um hambúrguer,
                   que cadastre um hambúrguer selecionando os ingredientes
                   e faça um pedido para um cliente selecionando os hambúrgueres.
                 
                   no final do programa, mostre um relatório com os clientes e seus pedidos
                   com o detalhe sobre tudo, mostrando os hambúrgueres e os detalhes do hambúrguer
                   
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