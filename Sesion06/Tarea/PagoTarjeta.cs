using System.Linq;

namespace Tarea;

public class PagoTarjeta : IMetodoPago, IReembolsable
{
    private string numero;

    public string Nombre => "Tarjeta";

    public PagoTarjeta(string numero)
    {
        this.numero = numero;
    }

    public decimal CalcularComision(decimal monto)
    {
        return monto * 0.03m;
    }

    public bool Validar(decimal monto)
    {
        return monto > 0 && numero.Length == 16
            && numero.All(char.IsDigit);
    }

    public void Reembolsar(decimal monto)
    {
        Console.WriteLine($"Reembolso a tarjeta: ${monto:N0}");
    }
}

