using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ListaDoisProgram
{
    internal class Class2
    {
        class Program
        {

            static void Main(string[] args)
            //1. Leia três números entrados pelo usuário e mostre na tela qual deles é o maior.
            {
                int numbPrimeiro;
                int numbSegundo;
                int numbTerceiro;
                int numbMaior;

                Console.Write("Informe o primeiro numero: ");
                numbPrimeiro = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero: ");
                numbSegundo = int.Parse(Console.ReadLine());

                Console.WriteLine("Infoeme o terceiro numero: ");
                numbTerceiro = int.Parse(Console.ReadLine());

                if (numbPrimeiro > numbSegundo)
                {
                    numbMaior = numbPrimeiro;
                }
                else
                {
                    numbMaior = numbSegundo;

                }
                if (numbMaior < numbTerceiro)
                {
                    numbMaior = numbTerceiro;
                }
                else
                {
                    Console.WriteLine("O maior numero entre os três é: " + numbMaior);
                }

                //2.Leia um caractere e informe na tela se ele é um número ou letra.
                {
                    Console.WriteLine("Digite um letra ou numero: ");
                    int numero = 0;
                    char letra;
                    char letraOUnumb;

                    letraOUnumb = char.Parse(Console.ReadLine());
                    if (numero == 1 || numero == 2 || numero == 3 || numero == 4 || numero == 5
                       || numero == 6 || numero == 7 || numero == 8 || numero == 9 || numero == 10)
                    {
                        Console.WriteLine("É numero: " + numero);
                    }
                    else
                    {

                        Console.WriteLine(" É Letra: ");
                    }
                }
                //3.Leia um caractere e informe se ele é vogal ou consoante.
                {
                    //Leia um caractere e informe se ele é vogal ou consoante.
                    char _caracter;
                    bool _evogal = false;

                    string[] _vogais = new string[] { "a", "e", "i", "o", "u" };

                    Console.Write("Informe um caracter: ");
                    char.TryParse(Console.ReadLine(), out _caracter);

                    Console.WriteLine(String.Format("\nCaracter informado: {0}", _caracter.ToString()));
                    Console.WriteLine("Identificando...\n");

                    for (int i = 0; i < _vogais.Length; i++)
                    {
                        if (_vogais[i] == _caracter.ToString())
                        {
                            _evogal = true;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (_evogal)
                    {
                        Console.WriteLine("O caracter informado é uma vogal.");
                    }
                    else
                    {
                        Console.WriteLine("O caracter informado é uma consoante.");
                    }


                    Console.ReadKey();
                }



                //4. Leia um número e mostre na tela se ele é um número primo ou não.
                {
                    // Leia um número e mostre na tela se ele é um número primo ou não.
                    int _numero;
                    Console.Write("Informe um número: ");
                    int.TryParse(Console.ReadLine(), out _numero);

                    if (_numero % 2 == 0)
                    {
                        Console.WriteLine("O número informado é par.");
                    }
                    else
                    {
                        Console.WriteLine("O número informado é impar.");
                    }

                    Console.ReadKey();
                }
                //5. Crie um algoritmo que pergunte ao usuário seu nome e sua idade. Em
                //seguida verifique se a idade é maior ou menor de 18.
                {
                            int idade = 0;

                            // Seção de Comandos, procedimento, funções, operadores, etc... 
                            Console.WriteLine("Digite a sua idade: ");

                            idade = int.Parse(Console.ReadLine());

                            if (idade >= 18)
                            {
                                Console.WriteLine("MAIOR DE IDADE");
                            }
                            else
                            {
                                Console.WriteLine(idade + " anos idade");
                            }


                            Console.Write("CONSIDERADO MENOR DE IDADE");
                        }

                        //6. Crie um algoritmo para fazer o reajuste salarial de um funcionário. Caso ele
                        //receba menos que 1.700, calcule um aumento de 10 %, caso ele receba mais
                        //que 1.700, o ajuste é de 5 %.
                        {
                            double _salario;
                            double _porcentagem;

                            Console.Write("Informe o seu salário atual: ");

                            double.TryParse(Console.ReadLine(), out _salario);


                            if (_salario > 0)
                            {
                                Console.WriteLine(string.Format("Saálrio atual: {0}", _salario));

                                if (_salario <= 1700)
                                {
                                    _porcentagem = (10 * _salario) / 100;
                                }
                                else
                                {
                                    _porcentagem = (5 * _salario) / 100;
                                }

                                _salario = _salario + _porcentagem;

                                Console.WriteLine(string.Format("Salário ajustado é: {0}", _salario));
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("O sálario informado é inválido.");


                            }
                            //7. Elabore um algoritmo que calcule a idade média de 5 alunos.

                        }
                        {
                            Double media = 0;
                            Double idade1 = 0;
                            Double idade2 = 0;
                            Double idade3 = 0;
                            Double idade4 = 0;
                            Double idade5 = 0;
                            Console.WriteLine("Programa que calcula a idade media de cinco alunos");
                            Console.Write("Informe a idade do 1° alunos : ");
                            idade1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe a idade do 2° alunos : ");
                            idade2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe a idade do 3° alunos : ");
                            idade3 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe a idade do 4° alunos : ");
                            idade4 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe a idade do 5° alunos : ");
                            idade5 = Convert.ToDouble(Console.ReadLine());
                            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
                            Console.WriteLine("A ídade média dos alunos é " + media);
                            Console.ReadKey();
                        }
                        //8. Crie um algoritmo que verifique se um número informado é par ou ímpar.
                        {
                            int n = 0;
                            int r = 0;
                            Console.WriteLine("Determina se o número é par ou impar");
                            Console.Write("Informe um número: ");
                            n = Convert.ToInt32(Console.ReadLine());
                            r = n % 2;
                            if (r == 1)
                            {
                                Console.WriteLine("O número informado é impar");
                            }
                            else
                            {
                                Console.WriteLine("O número informado é par");
                            }
                            Console.ReadKey();
                        }
                        //9. Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O
                        //algoritmo deverá ler a idade de 10 pessoas.
                        {
                            int qtde = 0;
                            int idade = 0;
                            Console.WriteLine("Exercício 2 - Verifica maior idade");
                            int i = 0;
                            while (i < 10)
                            {
                                i = i + 1;
                                Console.Write("Informe a idade da pessoa: ");
                                idade = Convert.ToInt32(Console.ReadLine());
                                if (idade >= 18)
                                {
                                    qtde = qtde + 1;
                                }
                            }
                            Console.WriteLine("Existem " + qtde + " pessoas com mais de 18 anos");
                            Console.ReadKey();
                        }
                        //10.Faça um algoritmo que calcule e exiba o salário reajustado de dez
                        //funcionários de acordo com a seguinte regra: Salário até 300, reajuste de
                        //50 %; Salários maiores que 300, reajuste de 30 %.
                        {
                            Double salario = 0;
                            Double salarioNovo = 0;
                            Console.WriteLine("Efetua o reajuste salarial");
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("Informe o salário: ");
                                salario = Convert.ToDouble(Console.ReadLine());
                                if (salario <= 300)
                                { //50%
                                    salarioNovo = salario * 1.50;
                                }
                                else
                                { //30%
                                    salarioNovo = salario + ((salario * 30) / 100);
                                }
                                Console.WriteLine("Salário reajustado: " + salarioNovo);
                            }
                            Console.ReadKey();
                        }
                        {
                            //Faça um algoritmo que leia a altura e a matricula de dez aluno. Mostre a
                            //matricula do aluno mais alto e do aluno mais baixo.
                            String maMatricula;
                            Double maAltura;

                            String meMatricula;
                            Double meAltura;

                            String Matricula;
                            Double Altura;

                            Console.WriteLine("Determina o maior aluno e o menor aluno");
                            Console.Write("Informe a matricula do aluno: ");
                            Matricula = Console.ReadLine();
                            Console.Write("Informe a altura do aluno: ");
                            Altura = Convert.ToDouble(Console.ReadLine());

                            maAltura = Altura;
                            meAltura = Altura;
                            maMatricula = Matricula;
                            meMatricula = Matricula;
                            int i = 1;
                            while (i < 5)
                            {
                                Console.Write("Informe a matricula do aluno: ");
                                Matricula = Console.ReadLine();
                                Console.Write("Informe a altura do aluno: ");
                                Altura = Convert.ToDouble(Console.ReadLine());
                                if (maAltura < Altura)
                                {
                                    maMatricula = Matricula;
                                    maAltura = Altura;
                                }

                                if (meAltura > Altura)
                                {
                                    meMatricula = Matricula;
                                    meAltura = Altura;
                                }
                                i++;
                            }
                            Console.WriteLine("Maior aluno");
                            Console.WriteLine("Matricula: {0}, Altura: {1}", maMatricula, maAltura);
                            Console.WriteLine("Menor aluno");
                            Console.WriteLine("Matricula: {0}, Altura: {1}", meMatricula, meAltura);
                            Console.ReadKey();
                        }
                        //12.Desenvolva um algoritmo que solicite a entrada de um número e calcule se o
                        //número é par ou impar.
                        {

                            // ler um número e dizer se é par ou ímpar
                            int num = 0;


                            Console.WriteLine("Digite um número inteiro positivo: ");
                            num = int.Parse(Console.ReadLine());

                            // resto da divisão de num por 2 é igual a 1?
                            if (num % 2 == 1)
                            {
                                Console.WriteLine("Ímpar...\n");
                            }
                            else
                            {
                                Console.WriteLine("Par...\n");
                            }
                        }
                        //13.Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.
                        {
                        string Nome; //Variável que armazena o nome do Usuário.

                         Console.Write("Informe o seu nome: ");
                        Nome = Console.ReadLine();

                        
                        
                         Console.WriteLine("");
                         Console.WriteLine("");

                         Console.Write("Meu nome é: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Nome);
                        Console.ReadKey();
                }
                        //14.Desenvolva uma calculadora, onde será necessário entrar com a operação, primeiro e segundo valor, exiba o resultado na tela.
                        {
                            double Num1, Num2, Resultado = 0;
                            char Operacao;

                            Console.WriteLine("Entre com a operação-->");
                            Console.WriteLine("+ Adição-------------->");
                            Console.WriteLine("- Subtração----------->");
                            Console.WriteLine("* Multiplicação------->");
                            Console.WriteLine("/ Divisão------------->");
                            Console.WriteLine("-----------------------");

                            Console.WriteLine();

                            Console.Write("Operação: ");

                            char.TryParse(Console.ReadLine(), out Operacao);

                            Console.WriteLine();
                            Console.Write("Informe o primeiro valor: ");
                            double.TryParse(Console.ReadLine(), out Num1);

                            Console.WriteLine();
                            Console.Write("Informe o segundo valor: ");
                            double.TryParse(Console.ReadLine(), out Num2);

                            Console.WriteLine();
                            Console.WriteLine();

                            switch (Operacao)
                            {
                                case '+':
                                    Resultado = Adicao(Num1, Num2);
                                    break;

                                case '-':
                                    Resultado = Subtracao(Num1, Num2);
                                    break;

                                case '*':
                                    Resultado = Multiplicacao(Num1, Num2);
                                    break;

                                case '/':
                                    Resultado = Divisao(Num1, Num2);
                                    break;
                            }

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(string.Format("Resultado: {0}", Resultado));

                            Console.ReadKey();
                        }

                        static Double Adicao(double Num1, double Num2)
                        {
                            return (Num1 + Num2);
                        }

                        static Double Subtracao(double Num1, double Num2)
                        {
                            return (Num1 - Num2);
                        }

                        static Double Multiplicacao(double Num1, double Num2)
                        {
                            return (Num1 * Num2);
                        }

                        static Double Divisao(double Num1, double Num2)
                        {
                            return (Num1 / Num2);
                        }
                        //15.Desenvolva um algoritmo que solicite a entrada da idade de um determinado
                        //usuário, se for menor que 18 anos exiba na cor vermelha “Sem permissão”,
                        //caso seja maior ou igual a 18 anos exiba na cor verde “Permissão
                        //concedida”.
                        {
                            int Idade;
                            Console.Write("Informe a sua idade: ");
                            int.TryParse(Console.ReadLine(), out Idade);

                            if (Idade >= 18)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Acesso permitdo");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Acesso Negado");
                            }
                        }
                        //16.Desenvolva um método que receba por parâmetro o um nome, e retorne a frase “Olá meu nome é: { nome recebido}”.

                        {
                            string Nome;
                            Console.WriteLine("Informe o seu nome: ");

                            Nome = Console.ReadLine();

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.WriteLine(string.Format("Meu nome é: {0}", Nome));

                            Console.ReadKey();

                        }
                        //17.Desenvolva um algoritmo que solicite a entrada de uma frase, após isto  troque todas as letras A ou a por &, porém não utilize o método Replace().
                        {

                            Program p = new Program();
                            string Frase = "Agora eu sou um bom desenvolvedor.";

                            Console.WriteLine(Alterar(Frase));

                            Console.ReadKey();
                        }

                        string Alterar(string Frase)
                        {
                            if (Frase.Trim().Length > 0)
                            {
                                int Total = Frase.Length;
                                int Count = 0;

                                var StringBuilder = new StringBuilder(Frase);

                                while (Count < Total)
                                {
                                    if (StringBuilder[Count] == 'o')
                                    {
                                        StringBuilder[Count] = '&';
                                    }
                                    Count++;
                                }

                                Frase = StringBuilder.ToString();

                                return Frase;
                            }
                            else
                            {
                                return null;
                            }
                            //18.Desenvolva um algoritmo que calcule o reajuste salarial. Se o salário for
                            //abaixo de 1.700 o ajuste é de R$300.00, se maior de R$ 200.00.Para
                            //finalizar, exiba o novo salário na tela.
                            {

                                Program p = new Program();
                                Double Salario;

                                Console.WriteLine("Informe o seu salário, use ponto");

                                Console.WriteLine();

                                Console.Write("Salario: ");
                                double.TryParse(Console.ReadLine(), out Salario);

                                Console.WriteLine();

                                Console.Write("Salário atual: ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(Salario.ToString());


                                Console.ResetColor();
                                Console.WriteLine();

                                Console.WriteLine("\a");

                                Console.Write("Novo salário: ");
                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.Write(CalculaSalario(Salario));

                                Console.ReadKey();
                            }

                            double CalculaSalario(double Salario)
                            {

                                double NovoSalario = 0;

                                if (Salario >= 1700)
                                {
                                    NovoSalario = (Salario + 200);
                                }
                                else
                                {
                                    NovoSalario = (Salario + 300);
                                }

                                return NovoSalario;

                            }
                            //8 - Desenvolva um algoritmo que solicite a entrada de nome, e-mail, telefone e RG de um determinado usuário e grave em um arquivo de texto. Exiba as informações na tela a partir do arquivo de texto gerado.
                            string acao = "";
                            string caminho = "usuario.txt";
                            string nome = "", email = "", telefone = "", rg = "";

                            Console.WriteLine("##########################");
                            Console.WriteLine("##########################");
                            Console.WriteLine("G- Gravar ################");
                            Console.WriteLine("L- Ler ###################");
                            Console.WriteLine("S - Sair #################");
                            Console.WriteLine("##########################");
                            Console.WriteLine("##########################");
                            Console.Write("Digite uma operação: ");

                            acao = Console.ReadLine().ToUpper();
                            Console.WriteLine();

                            while (acao != "S")
                            {

                                if (acao == "G")
                                {
                                    Console.Write("Informe seu nome: ");
                                    nome = Console.ReadLine();

                                    Console.Write("Informe seu e-mail: ");
                                    email = Console.ReadLine();

                                    Console.Write("Informe seu Telefone: ");
                                    telefone = Console.ReadLine();

                                    Console.Write("Informe seu RG: ");
                                    rg = Console.ReadLine();

                                    StreamWriter sw = new StreamWriter(caminho, true);

                                    sw.WriteLine("Nome: " + nome);
                                    sw.WriteLine("E-mail: " + email);
                                    sw.WriteLine("Telefone: " + telefone);
                                    sw.WriteLine("RG: " + rg);
                                    sw.WriteLine("--------------------------------------------------");

                                    sw.Close();
                                }
                                else if (acao == "L")
                                {
                                    StreamReader sr = new StreamReader(caminho);

                                    while (sr.EndOfStream != true)
                                    {
                                        Console.WriteLine(sr.ReadLine());
                                    }

                                    sr.Close();
                                }

                                Console.WriteLine();
                                Console.WriteLine("Pressione uma tecla para continuar...");
                                Console.ReadKey();

                                Console.Clear();
                                Console.WriteLine("##########################");
                                Console.WriteLine("##########################");
                                Console.WriteLine("G- Gravar ################");
                                Console.WriteLine("L- Ler ###################");
                                Console.WriteLine("S - Sair #################");
                                Console.WriteLine("##########################");
                                Console.WriteLine("##########################");
                                Console.Write("Digite uma operação: ");

                                acao = Console.ReadLine().ToUpper();
                                Console.WriteLine();

                            }
                            //20.Desenvolva um algoritmo que calcule o IMC de uma determinada pessoa, e
                            //grave os resultados em um arquivo de texto, onde ao acessar a aplicação
                            //será solicitado se quer fazer um novo cadastro ou consultar os existentes.
                            //Cadastrando um novo calculo de IMC, será necessário informar o nome,
                            //idade, peso e altura. O cálculo do IMC é feito dividindo o peso(em
                            //quilogramas) pela altura(em metros) ao quadrado. Ao gravar em um arquivo
                            //de texto, os dados anteriores deverão ser mantidos.
                            {
                                string a = "";
                                string c = "imc.txt";
                                double peso, altura, imc;
                                string n, resultado = "";
                                int idade;

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("#####################");
                                Console.WriteLine("N - Novo ############");
                                Console.WriteLine("C - Consultar #######");
                                Console.WriteLine("S - Sair#############");
                                Console.WriteLine("#####################");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Informe uma operação: ");
                                Console.ResetColor();

                                a = Console.ReadLine().ToUpper();
                                Console.WriteLine();

                                while (a != "S")
                                {
                                    if (a == "N")
                                    {
                                        Console.Write("Informe o nome: ");
                                        n = Console.ReadLine();

                                        Console.Write("Informe a idade: ");
                                        int.TryParse(Console.ReadLine(), out idade);

                                        Console.Write("Informe o peso: ");
                                        double.TryParse(Console.ReadLine(), out peso);

                                        Console.Write("Informe a altura: ");
                                        double.TryParse(Console.ReadLine(), out altura);

                                        imc = Math.Round((peso / (altura * altura)));

                                        if (imc < 18.5)
                                        {
                                            resultado = "Peso abaixo do normal";
                                        }
                                        else if (imc > 18.5 && imc < 25)
                                        {
                                            resultado = "Peso normal";
                                        }
                                        else if (imc > 25 && imc < 30)
                                        {
                                            resultado = "Sobre peso";
                                        }
                                        else if (imc > 30 && imc < 35)
                                        {
                                            resultado = "Grau de obesidade I";
                                        }
                                        else if (imc > 35 && imc < 40)
                                        {
                                            resultado = "Grau de obesidade II";
                                        }
                                        else if (imc > 40)
                                        {
                                            resultado = "Grau de obesidade III";
                                        }


                                        if (resultado != "" && imc > 0 && altura > 0 && peso > 0 && nome.Trim().Length > 2 && idade > 0)
                                        {


                                            StreamWriter sw = new StreamWriter(c, true);

                                            sw.WriteLine(string.Format("Nome: {0}", n));
                                            sw.WriteLine(string.Format("Idade: {0}", idade));
                                            sw.WriteLine(string.Format("Peso: {0}", peso));
                                            sw.WriteLine(string.Format("Altura: {0}", altura));
                                            sw.WriteLine(string.Format("IMC: {0}", imc));
                                            sw.WriteLine(string.Format("Resultado: {0}", resultado));
                                            sw.WriteLine("------------------------------------------");

                                            sw.Close();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine();
                                            Console.WriteLine("-->Dados inválidos, operação cancelada!!!");
                                            Console.WriteLine();
                                            Console.ResetColor();
                                        }
                                    }
                                    else if (a == "C")
                                    {
                                        StreamReader sr = new StreamReader(c);

                                        while (!sr.EndOfStream)
                                        {
                                            Console.WriteLine(sr.ReadLine());
                                        }

                                        sr.Close();
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Pressione uma tecla para continuar");
                                    Console.ReadKey();


                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("#####################");
                                    Console.WriteLine("N - Novo ############");
                                    Console.WriteLine("C - Consultar #######");
                                    Console.WriteLine("S - Sair#############");
                                    Console.WriteLine("#####################");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("Informe uma operação: ");
                                    Console.ResetColor();

                                    a = Console.ReadLine().ToUpper();
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    




            
     
        
            
            
            
    














