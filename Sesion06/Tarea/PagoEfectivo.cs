namespace Tarea;

public class PagoEfectivo : IMetodoPago
{
    public string Nombre => "Efectivo";

    public decimal CalcularComision(decimal monto)
    {
        return 0;
    }

    public bool Validar(decimal monto)
    {
        return monto > 0;
    }
}
