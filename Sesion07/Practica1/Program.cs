try
{
    string nombre = "Teclado";
    int stock = 3;
    int cantidadVenta = 5;

    if (cantidadVenta > stock)
    {
        throw new StockInsuficienteException(nombre, stock);
    }

    Console.WriteLine("Venta realizada correctamente.");
}
catch (StockInsuficienteException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
