
using System;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("========================================");
Console.WriteLine("          MI TARJETA PERSONAL");
Console.WriteLine("========================================");
Console.ResetColor();

// Pedimos los cuatro datos requeridos.
Console.Write("¿Cómo te llamas? ");
string nombre = Console.ReadLine() ?? "";
nombre = string.IsNullOrWhiteSpace(nombre) ? "Invitado" : nombre;

Console.Write("¿Cuál es tu programa de formación? ");
string programa = Console.ReadLine() ?? "";
programa = string.IsNullOrWhiteSpace(programa) ? "ADSO" : programa;

Console.Write("¿Cuál es tu número de ficha? ");
string ficha = Console.ReadLine() ?? "";
ficha = string.IsNullOrWhiteSpace(ficha) ? "Sin registrar" : ficha;

Console.Write("Escribe una frase que te represente: ");
string frase = Console.ReadLine() ?? "";
frase = string.IsNullOrWhiteSpace(frase) ? "Siempre aprendiendo" : frase;

// Mostramos la tarjeta con bordes.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("+--------------------------------------+");
Console.WriteLine("|          MI TARJETA PERSONAL         |");
Console.WriteLine("+--------------------------------------+");
Console.ResetColor();

Console.WriteLine($"| Nombre: {nombre}");
Console.WriteLine($"| Programa: {programa}");
Console.WriteLine($"| Ficha: {ficha}");
Console.WriteLine($"| Frase: {frase}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+--------------------------------------+");
Console.ResetColor();

// Mensaje final en amarillo.
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("¡Gracias por conocer mi tarjeta!");
Console.ResetColor();
