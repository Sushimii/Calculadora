using System;
//Puxando todas bibliotecas basicas
using System.Globalization;
class Program
{
   public static void Main(string[] args)
    {
        // Declaração das váriaveis
        char op;
        double num1, num2;
        string cont;

        do
        {
            // Solicita ao usuário que digite um operador
            Console.Write("ENTRE COM O OPERADOR: +, -, *, /: ".ToString(CultureInfo.InvariantCulture));
            op = char.Parse(Console.ReadLine());

            // Solicita ao usuário que digite o primeiro valor
            Console.Write("ENTRE COM O PRIMEIRO VALOR: ".ToString(CultureInfo.InvariantCulture));
            num1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Solicita ao usuário que digite o segundo valor
            Console.Write("ENTRE COM O SEGUNDO VALOR: ".ToString(CultureInfo.InvariantCulture));
            num2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Executa a operação correspondente ao operador inserido
            switch (op)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}".ToString(CultureInfo.InvariantCulture));
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}".ToString(CultureInfo.InvariantCulture));
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}".ToString(CultureInfo.InvariantCulture));
                    break;
                case '/':
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}".ToString(CultureInfo.InvariantCulture));
                    break;
                default:
                    Console.WriteLine("OPERADOR ERRADO, POR FAVOR INSIRA O OPERADOR CORRETO".ToString(CultureInfo.InvariantCulture));
                    break;
            }

            // Pergunta ao usuário se ele deseja continuar
            Console.Write("Quer continuar (S/N)? ".ToString(CultureInfo.InvariantCulture));
            cont = Console.ReadLine();
           //Função while  com condição ignorando se o caracter é minusculo ou maiusculo
        } while (cont.Equals("S", StringComparison.OrdinalIgnoreCase));

        // Exibe mensagem de encerramento
        Console.WriteLine("OBRIGADO VOLTE SEMPRE :)".ToString(CultureInfo.InvariantCulture));
    }
}
