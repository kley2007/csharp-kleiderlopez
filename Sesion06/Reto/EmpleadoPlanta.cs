namespace Reto;

public class EmpleadoPlanta : Empleado
{
    private decimal salario;
    private int antiguedad;

    public override string Tipo => "Planta";

    public EmpleadoPlanta(string nombre, string documento,
        decimal salario, int antiguedad)
        : base(nombre, documento)
    {
        this.salario = salario;
        this.antiguedad = antiguedad;
    }

    public override decimal CalcularSalario()
    {
        if (antiguedad >= 5)
            return salario * 1.05m;

        return salario;
    }
}

