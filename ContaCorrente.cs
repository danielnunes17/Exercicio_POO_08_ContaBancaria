using System.Globalization;

namespace Exercicio_POO_08_ContaBancaria
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public double? Saldo { get; set; }

        public ContaCorrente(int numero, string? titular = null, double? saldo = null)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(double quantia) => Saldo += quantia;
        public void Saque(double quantia) => Saldo -= quantia;

        public override string ToString() => "Conta: " + Numero +
            ", " + "Titular: " + Titular + ", " +
            "Saldo: R$" + Saldo?.ToString("F2", CultureInfo.InvariantCulture);
    }
}
