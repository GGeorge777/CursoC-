using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ListaUmProgram
{
    internal class Class1
    {
        class Program
        {
            static void Main(string[] args)
            {
                {
                    // 01. Imprimir a mensagem: “É PRECISO FAZER TODOS OS EXERCÍCIOS PARA APRENDER”
                    {
                        Console.WriteLine("É PRECISO FAZER TODOS OS EXERCÍCIOS PARA APRENDER");
                    }
                    // 02. Imprimir seu nome.
                    {
                        String MeuNome = "Matheus George";
                        Console.WriteLine(MeuNome);
                    }
                    // 03. Criar um algoritmo que imprima o produto(multiplicação) entre 28 e 43.
                    {
                        int numb1 = 28;
                        int numb2 = 43;
                        double mult;
                        mult = numb1 * numb2;
                        Console.WriteLine("O produto da multiplicação é: " + mult);
                    }
                    //04. Criar um algoritmo que imprima a média aritmética entre os números 8, 9 e 7.
                    {
                        int number1 = 8;
                        int number2 = 9;
                        int number3 = 7;
                        double media;
                        media = (number1 + number2 + number3) / 3;
                        Console.WriteLine("A media dos numeros são: " + media);
                    }
                    // 05. Ler um número inteiro e imprimi-lo.
                    {
                        int numero = 0;
                        Console.Write("Digite um número: ");
                        numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Você digitou: {0}", numero);
                    }
                    // 06. Ler dois números inteiros e imprimi-los.
                    {
                        int numero1 = 0;
                        int numero2 = 0;

                        Console.Write("Digite o primerio número: ");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Você digitou: {0}", numero1);

                        Console.Write("Digite o segundo  número: ");
                        numero2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Você digitou: {0}", numero2);
                    }
                    // 07. Ler um número inteiro e imprimir seu sucessor e seu antecessor.
                    {
                        int numero = 0;
                        int sucessor = 0;
                        int antecessor = 0;
                        Console.Write("Digite um Número: ");
                        numero = int.Parse(Console.ReadLine());
                        sucessor = numero + 1;
                        antecessor = numero - 1;
                        Console.WriteLine("O sucessor é: {0}", sucessor);
                        Console.WriteLine("O antecessor é: {0}", antecessor);

                    }
                    {
                        //08. Ler nome, endereço e telefone e imprimi-los.

                        String nome;
                        String endereco;
                        String telefone;

                        Console.WriteLine("Nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite um Nome: " + nome);

                        Console.WriteLine("Endereço: ");
                        endereco = Console.ReadLine();
                        Console.WriteLine("Digite um Endereço: " + endereco);

                        Console.WriteLine("Telefone: ");
                        telefone = Console.ReadLine();
                        Console.WriteLine("Digite um telefone: " + telefone);

                    }
                    {
                        //09. Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecer a mensagem: Soma
                        int parcela1;
                        int parcela2;
                        int total;

                        Console.WriteLine("Primeira parcela: ");
                        parcela1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a primeira parcela: " + parcela1);

                        Console.WriteLine("Segunda  parcela: ");
                        parcela2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a segunda  parcela: " + parcela2);

                        total = parcela1 + parcela2;
                        Console.WriteLine("O resultado da parcela é: " + total);

                    }
                    {
                        //10. Ler dois números inteiros e imprimir o produto.
                        int multiplicando;
                        int multiplicador;
                        int produto;

                        Console.WriteLine(" multiplicando: ");
                        multiplicando = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a primeira multiplicando: " + multiplicando);

                        Console.WriteLine("multiplicador: ");
                        multiplicador = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a segunda  parcela: " + multiplicador);

                        produto = multiplicando * multiplicador;
                        Console.WriteLine("O resultado da parcela é: " + produto);

                    }
                    {
                        //11.Ler um número real (numero com vírgula) e imprimir a terça parte deste número.

                        double x = 0;
                        double resultado = 0;
                        Console.Write("Digite um número: ");
                        x = double.Parse(Console.ReadLine());
                        resultado = x / 3;
                        Console.WriteLine("A terça parte deste número é: {0:#.00}", resultado);

                    }
                    //12. Entrar com dois números reais e imprimir a média aritmética com a mensagem “Média” antes do resultado.

                    {

                        double n1, n2 = 0;
                        double resultado = 0;
                        Console.Write("Digite o primeiro número: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        n2 = double.Parse(Console.ReadLine());
                        resultado = (n1 + n2) / 2;
                        Console.WriteLine("A média é {0}", resultado);


                    }
                    //13.Fazer um algoritmo que possa entrar com o saldo de uma aplicação e imprima o novo saldo, considerando o reajuste de 1%.

                    {
                        double saldo = 0;
                        double reajuste = 0;
                        double juro = 0;
                        Console.Write("Digite o saldo da aplicação: ");
                        saldo = double.Parse(Console.ReadLine());
                        Console.Write("Digite o juro: ");
                        juro = double.Parse(Console.ReadLine());
                        reajuste = saldo * (juro / 100);
                        saldo = saldo + reajuste;
                        Console.WriteLine("Seu novo saldo é {0:#.00}", saldo);

                    }
                    //14. Entrar com as notas da PR1 e PR2 e imprimir a média final.
                    {
                        double PR1, PR2 = 0;
                        double resultado = 0;
                        Console.Write("Digite o primeiro número: ");
                        PR1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        PR2 = double.Parse(Console.ReadLine());
                        resultado = (PR1 + PR2) / 2;
                        Console.WriteLine("A média é {0}", resultado);

                    }

                }
            }
        }
    }
}

