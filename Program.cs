
using Exercicio_POO_08_ContaBancaria;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        ContaCorrente conta;

        Console.WriteLine("Entre com o número da conta: \n");
        int numeroConta = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o titular da conta: \n");
        string nome = Console.ReadLine();
        Console.WriteLine("Haverá depósito inicial(s / n)? \n");
        char resposta = char.Parse(Console.ReadLine());
        if (resposta == 's' || resposta == 'S')
        {
            Console.WriteLine("Entre com o valor de depósito inicial: \n");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new ContaCorrente(numeroConta, nome, depositoInicial);
        }
        else
        {
            conta = new ContaCorrente(numeroConta, nome);
        }
        Console.WriteLine();
        Console.WriteLine("Dados da conta: \n");
        Console.WriteLine(conta + "\n");

        Console.WriteLine();
        Console.WriteLine("Entre com um valor para depósito: \n");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Depositar(quantia);
        Console.WriteLine("Dados da conta atualizados: \n");
        Console.WriteLine(conta + "\n");

        Console.WriteLine();
        Console.WriteLine("Entre um valor para saque: \n");
        double quantiaSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(quantiaSaque);
        Console.WriteLine("Dados da conta atualizados: \n");
        Console.WriteLine(conta);
    }
}