namespace Reto;

public abstract class Empleado
{
    public string Nombre { get; }
    public string Documento { get; }

    public virtual string Tipo => "Empleado";

    public Empleado(string nombre, string documento)
    {
        Nombre = nombre;
        Documento = documento;
    }

    public abstract decimal CalcularSalario();

    public override string ToString()
    {
        return $"{Nombre} - {Tipo}: ${CalcularSalario():N0}";
    }
}
