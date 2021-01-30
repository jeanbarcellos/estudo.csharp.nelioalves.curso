using System.Globalization;

namespace Course
{
    class ContaBancaria
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            this.Numero = numero;
            this.Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            this.Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            this.Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            this.Saldo -= quantia + 5.0;
        }

        public override string ToString() => "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

    }
}
