namespace Reto;

public class EmpleadoPorHoras : Empleado
{
    private int horas;
    private decimal valorHora;

    public override string Tipo => "Por horas";

    public EmpleadoPorHoras(string nombre, string documento,
        int horas, decimal valorHora)
        : base(nombre, documento)
    {
        this.horas = horas;
        this.valorHora = valorHora;
    }

    public override decimal CalcularSalario()
    {
        if (horas <= 160)
            return horas * valorHora;

        return 160 * valorHora
            + (horas - 160) * valorHora * 1.5m;
    }
}

