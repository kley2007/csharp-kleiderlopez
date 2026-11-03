using Tarea;

ProcesadorPagos procesador = new();

IMetodoPago efectivo = new PagoEfectivo();
IMetodoPago tarjeta = new PagoTarjeta("1234567890123456");
IMetodoPago billetera = new PagoBilletera();

Console.WriteLine("=== SISTEMA DE PAGOS ===");

Console.WriteLine("\n--- PAGO EN EFECTIVO ---");
procesador.Cobrar(efectivo, 100_000m);

Console.WriteLine("\n--- PAGO CON TARJETA ---");
procesador.Cobrar(tarjeta, 200_000m);

Console.WriteLine("\n--- PAGO CON BILLETERA ---");
procesador.Cobrar(billetera, 300_000m);

Console.WriteLine("\n--- TARJETA INVÁLIDA ---");
IMetodoPago tarjetaInvalida = new PagoTarjeta("12345");
procesador.Cobrar(tarjetaInvalida, 100_000m);

Console.WriteLine("\n--- BILLETERA SUPERIOR AL LÍMITE ---");
procesador.Cobrar(billetera, 3_000_000m);

Console.WriteLine("\n--- DEVOLUCIONES ---");
procesador.Devolver(efectivo, 100_000m);
procesador.Devolver(tarjeta, 50_000m);
procesador.Devolver(billetera, 75_000m);
