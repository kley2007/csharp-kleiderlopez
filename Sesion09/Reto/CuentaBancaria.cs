namespace Reto
{
    public class CuentaBancaria
    {
        public string Titular { get; private set; }
        public string Numero { get; private set; }
        public decimal Saldo { get; private set; }

        public CuentaBancaria(string titular, string numero, decimal saldoInicial)
        {
            Titular = titular;
            Numero = numero;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal monto)
        {
            if (monto <= 0 || monto % 10000 != 0)
                throw new ArgumentException("El monto debe ser positivo y múltiplo de $10.000.");

            Saldo += monto;
        }

        public void Retirar(decimal monto)
        {
            if (monto <= 0 || monto % 10000 != 0)
                throw new ArgumentException("El monto debe ser positivo y múltiplo de $10.000.");

            if (monto > Saldo)
                throw new InvalidOperationException("No tienes saldo suficiente para realizar el retiro.");

            Saldo -= monto;
        }
    }
}
