using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração das variáveis
        char op;
        double num1, num2;
        string cont;

        do
        {
            // Solicita ao usuário que digite um operador
            Console.Write("ENTRE COM O OPERADOR: +, -, *, /: ");
            op = char.Parse(Console.ReadLine());

            // Solicita ao usuário que digite o primeiro valor
            Console.Write("ENTRE COM O PRIMEIRO VALOR: ");
            num1 = double.Parse(Console.ReadLine());

            // Solicita ao usuário que digite o segundo valor
            Console.Write("ENTRE COM O SEGUNDO VALOR: ");
            num2 = double.Parse(Console.ReadLine());

            // Executa a operação correspondente ao operador inserido
            switch (op)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("OPERADOR ERRADO, POR FAVOR INSIRA O OPERADOR CORRETO");
                    break;
            }

            // Pergunta ao usuário se ele deseja continuar
            Console.Write("Quer continuar (S/N)? ");
            cont = Console.ReadLine();
           //Função while  com condição ignorando se o caracter é minusculo ou maiusculo
        } while (cont.Equals("S", StringComparison.OrdinalIgnoreCase));

        // Exibe mensagem de encerramento
        Console.WriteLine("OBRIGADO VOLTE SEMPRE :)");
    }
}
