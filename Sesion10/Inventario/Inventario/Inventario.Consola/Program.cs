using System.Globalization;
using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

Console.OutputEncoding = System.Text.Encoding.UTF8;
string rutaDatos = Path.Combine(AppContext.BaseDirectory, "inventario.json");
var servicio = new ServicioInventario(new RepositorioJson(rutaDatos));
Console.WriteLine("=== SISTEMA DE INVENTARIO ===");
Console.WriteLine($"Archivo de datos: {rutaDatos}");

bool continuar = true;
while (continuar)
{
    Console.WriteLine("\n1. Registrar producto\n2. Agregar stock\n3. Vender producto\n4. Ver inventario\n5. Ver stock bajo\n6. Buscar producto\n7. Eliminar producto\n0. Salir");
    Console.Write("Selecciona una opción: ");
    string opcion = Console.ReadLine()?.Trim() ?? "";
    try
    {
        switch (opcion)
        {
            case "1": Registrar(); break;
            case "2":
                servicio.AgregarStock(LeerTexto("Código: "), LeerEntero("Cantidad a agregar: "));
                Console.WriteLine("Stock actualizado y guardado."); break;
            case "3":
                servicio.Vender(LeerTexto("Código: "), LeerEntero("Cantidad a vender: "));
                Console.WriteLine("Venta realizada y guardada."); break;
            case "4": Mostrar(servicio.Listar(), "INVENTARIO"); break;
            case "5": Mostrar(servicio.StockBajo(), "STOCK BAJO (MENOS DE 5)"); break;
            case "6": Mostrar(servicio.BuscarPorTexto(LeerTexto("Nombre o código a buscar: ")), "RESULTADOS"); break;
            case "7": Eliminar(); break;
            case "0": continuar = false; Console.WriteLine("¡Hasta pronto!"); break;
            default: Console.WriteLine("Opción inválida."); break;
        }
    }
    catch (StockInsuficienteException ex) { Console.WriteLine($"Error de inventario: {ex.Message}"); }
    catch (ArgumentException ex) { Console.WriteLine($"Dato no válido: {ex.Message}"); }
    catch (IOException ex) { Console.WriteLine($"Error de archivo: {ex.Message}"); }
    catch (Exception ex) { Console.WriteLine($"Error inesperado: {ex.Message}"); }
}

void Registrar()
{
    Console.WriteLine("\n--- REGISTRAR PRODUCTO ---");
    var producto = new Producto(LeerTexto("Código: "), LeerTexto("Nombre: "),
        LeerPrecio("Precio: "), LeerEntero("Stock inicial: "));
    servicio.Agregar(producto);
    Console.WriteLine("Producto registrado y guardado.");
}

void Eliminar()
{
    string codigo = LeerTexto("Código del producto a eliminar: ");
    var producto = servicio.Listar().FirstOrDefault(p =>
        p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));
    if (producto is null) { Console.WriteLine("Producto no encontrado."); return; }
    Console.Write($"¿Eliminar {producto.Nombre}? (s/n): ");
    if ((Console.ReadLine()?.Trim().ToLowerInvariant()) == "s")
    {
        servicio.Eliminar(codigo);
        Console.WriteLine("Producto eliminado.");
    }
    else Console.WriteLine("Eliminación cancelada.");
}

void Mostrar(List<Producto> productos, string titulo)
{
    Console.WriteLine($"\n--- {titulo} ---");
    if (productos.Count == 0) { Console.WriteLine("No hay productos para mostrar."); return; }
    Console.WriteLine("{0,-12} {1,-22} {2,14} {3,8}", "CÓDIGO", "NOMBRE", "PRECIO", "STOCK");
    foreach (var p in productos)
        Console.WriteLine("{0,-12} {1,-22} {2,14:C2} {3,8}", p.Codigo, p.Nombre, p.Precio, p.Stock);
}

string LeerTexto(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        string valor = Console.ReadLine()?.Trim() ?? "";
        if (!string.IsNullOrWhiteSpace(valor)) return valor;
        Console.WriteLine("El campo no puede estar vacío.");
    }
}

int LeerEntero(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0) return valor;
        Console.WriteLine("Escribe un entero mayor que cero.");
    }
}

decimal LeerPrecio(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        string entrada = (Console.ReadLine() ?? "").Trim().Replace(',', '.');
        if (decimal.TryParse(entrada, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal valor) && valor > 0)
            return valor;
        Console.WriteLine("Escribe un precio válido mayor que cero, por ejemplo 15000 o 15000,50.");
    }
}
