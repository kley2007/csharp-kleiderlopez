namespace Reto;

public class Contratista : Empleado
{
    private decimal valorContrato;

    public override string Tipo => "Contratista";

    public Contratista(string nombre, string documento,
        decimal valorContrato)
        : base(nombre, documento)
    {
        this.valorContrato = valorContrato;
    }

    public override decimal CalcularSalario()
    {
        return valorContrato * 0.90m;
    }
}
