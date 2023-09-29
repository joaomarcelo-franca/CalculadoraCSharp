using System;
namespace CalculadoraNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo a Aplicacao de uma Calculadora");
            Console.WriteLine("Escolha uma operacao: Adicao; Subtracao; Multiplicacao; Divisao");
            Console.WriteLine("Se deseja Sair da aplicacao, Escreva Sair");
            string opcao;
            opcao = Console.ReadLine();

            if (opcao == "Sair" ||  opcao == "sair")
            {
                Console.WriteLine("Obrigado por utilizar nossa aplicacao");
                Environment.Exit(0);
            }

            Console.WriteLine("Informe os dois numeros a serem calculados");
            int num1, num2;
            double resultado;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            char a1 = "A"[0];
            char a2 = "a"[0];

            char s1 = "S"[0];
            char s2 = "s"[0];

            char m1 = "M"[0];
            char m2 = "m"[0];

            char d1 = "D"[0];
            char d2 = "d"[0];

            if (opcao[0] == a1 || opcao[0] == a2)
            {
                resultado = num1 + num2;
                Console.WriteLine("O Resultado da Adicao entre os numeros e " + resultado);
            }
            else if (opcao[0] == s1 || opcao[0] == s2)
            {
                resultado = num1 - num2;
                Console.WriteLine("O Resultado da Subtracao entre os numeros e " + resultado);
            }
            else if (opcao[0] == m1 || opcao[0] == m2)
            {
                resultado = num1 * num2;
                Console.WriteLine("O Resultado da Multiplicacao entre os numeros e " + resultado);

            }
            else if (opcao[0] == d1 || opcao[0] == d2)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Informe outro numero, Erro: Divisao por zero");
                    Main(args);
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine("O Resultado da Divisao entre os numeros e " + resultado);
                }
            } else
            {
                Console.WriteLine("Error: Operacao Invalida");
            }
            Main(args);
        }
    }
}