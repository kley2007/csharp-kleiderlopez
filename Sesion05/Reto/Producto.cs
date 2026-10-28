
namespace Reto;

public class Producto
{
    private string _nombre = "";
    private decimal _precio;
    private int _stock;

    public string Codigo { get; private set; }

    public string Nombre
    {
        get => _nombre;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");

            _nombre = value.Trim();
        }
    }

    public decimal Precio
    {
        get => _precio;
        private set
        {
            if (value <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");

            _precio = value;
        }
    }

    public int Stock
    {
        get => _stock;
        private set
        {
            if (value < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            _stock = value;
        }
    }

    public Producto(string codigo, string nombre, decimal precio, int stock)
    {
        if (string.IsNullOrWhiteSpace(codigo))
            throw new ArgumentException("El código es obligatorio.");

        Codigo = codigo.Trim().ToUpper();
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }

    public void AgregarStock(int cantidad)
    {
        if (cantidad <= 0)
            throw new ArgumentException("La cantidad debe ser mayor que cero.");

        Stock += cantidad;
    }

    public bool Vender(int cantidad)
    {
        if (cantidad <= 0 || cantidad > Stock)
            return false;

        Stock -= cantidad;
        return true;
    }

    public override string ToString()
    {
        return $"{Codigo} - {Nombre} | ${Precio:N0} | Stock: {Stock}";
    }
}

