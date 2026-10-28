
using Reto;

List<Producto> inventario =
[
    new("P001", "Portatil", 2800000m, 5),
    new("P002", "Mouse", 45000m, 10),
    new("P003", "Teclado", 120000m, 8)
];

List<LineaVenta> carrito = [];
int opcion;

do
{
    Console.WriteLine("\n=== TIENDA ===");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Agregar stock");
    Console.WriteLine("3. Vender");
    Console.WriteLine("4. Ver carrito");
    Console.WriteLine("5. Ver inventario");
    Console.WriteLine("6. Salir");
    Console.Write("Opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
        opcion = 0;

    try
    {
        if (opcion == 1)
        {
            Console.Write("Código: ");
            string codigo = Console.ReadLine() ?? "";

            if (inventario.Any(p => p.Codigo == codigo.Trim().ToUpper()))
                Console.WriteLine("Ese código ya existe.");
            else
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";

                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine() ?? "");

                Console.Write("Stock inicial: ");
                int stock = int.Parse(Console.ReadLine() ?? "");

                inventario.Add(new Producto(codigo, nombre, precio, stock));
                Console.WriteLine("Producto registrado.");
            }
        }
        else if (opcion == 2)
        {
            Console.Write("Código: ");
            string codigo = Console.ReadLine() ?? "";
            Producto? p = inventario.FirstOrDefault(
                x => x.Codigo == codigo.Trim().ToUpper());

            if (p is null)
                Console.WriteLine("Producto no encontrado.");
            else
            {
                Console.Write("Cantidad para agregar: ");
                int cantidad = int.Parse(Console.ReadLine() ?? "");
                p.AgregarStock(cantidad);
                Console.WriteLine("Stock actualizado.");
            }
        }
        else if (opcion == 3)
        {
            Console.Write("Código: ");
            string codigo = Console.ReadLine() ?? "";
            Producto? p = inventario.FirstOrDefault(
                x => x.Codigo == codigo.Trim().ToUpper());

            if (p is null)
                Console.WriteLine("Producto no encontrado.");
            else
            {
                Console.Write("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine() ?? "");

                if (p.Vender(cantidad))
                {
                    carrito.Add(new LineaVenta(
                        p.Codigo, p.Nombre, cantidad, p.Precio * cantidad));
                    Console.WriteLine("Venta agregada al carrito.");
                }
                else
                    Console.WriteLine("Cantidad inválida o stock insuficiente.");
            }
        }
        else if (opcion == 4)
        {
            foreach (LineaVenta linea in carrito)
                Console.WriteLine($"{linea.Nombre} x{linea.Cantidad}: ${linea.Subtotal:N0}");

            Console.WriteLine($"TOTAL: ${carrito.Sum(l => l.Subtotal):N0}");
        }
        else if (opcion == 5)
        {
            foreach (Producto p in inventario)
                Console.WriteLine(p);
        }
        else if (opcion != 6)
            Console.WriteLine("Opción no válida.");
    }
    catch (FormatException)
    {
        Console.WriteLine("Ingresa un número válido.");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

} while (opcion != 6);

Console.WriteLine("¡Hasta luego!");
