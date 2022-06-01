using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__ConversõesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto o projeto 4");

            double salario = 1200.43;
            // o int é uma variavel de 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int) salario;
            Console.WriteLine(salarioEmInteiro);
            // O long é uma variavel de 64 bits

            long idade = 130000000000000000000;

            short quantidadeProdutos = 15000;

            float altura = 1.76f;

            Console.ReadLine();
        }
    }
}
