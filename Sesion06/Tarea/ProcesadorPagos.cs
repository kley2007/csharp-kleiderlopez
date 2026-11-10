namespace Tarea;

public class ProcesadorPagos
{
    public void Cobrar(IMetodoPago metodo, decimal monto)
    {
        if (!metodo.Validar(monto))
        {
            Console.WriteLine("Pago rechazado.");
            return;
        }

        decimal comision = metodo.CalcularComision(monto);
        decimal total = monto + comision;

        Console.WriteLine($"Método: {metodo.Nombre}");
        Console.WriteLine($"Monto: ${monto:N0}");
        Console.WriteLine($"Comisión: ${comision:N0}");
        Console.WriteLine($"Total: ${total:N0}");
        Console.WriteLine("Pago aprobado.");
    }

    public void Devolver(IMetodoPago metodo, decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("Monto de devolución inválido.");
            return;
        }

        if (metodo is IReembolsable reembolsable)
        {
            reembolsable.Reembolsar(monto);
        }
        else
        {
            Console.WriteLine("Este método no permite reembolsos.");
        }
    }
}

