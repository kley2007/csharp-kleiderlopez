using Tarea;

var ana = new CuentaBancaria("Ana", "001", 100000);
var luis = new CuentaBancaria("Luis", "002", 50000);

ana.Depositar(20000);
Console.WriteLine($"Depósito: ${ana.Saldo:N0}");

Console.WriteLine($"Retiro rechazado: {!ana.Retirar(500000)}");

ana.Transferir(luis, 30000);

Console.WriteLine($"Ana: ${ana.Saldo:N0}");
Console.WriteLine($"Luis: ${luis.Saldo:N0}");
