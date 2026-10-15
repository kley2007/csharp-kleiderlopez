
using System;

// Ejercicio 1: convertir segundos a horas, minutos y segundos.
Console.WriteLine("=== SEGUNDOS A RELOJ ===");

int segundos = 3725;

int horas = segundos / 3600;
int minutos = (segundos % 3600) / 60;
int segundosRestantes = segundos % 60;

Console.WriteLine($"{segundos} segundos equivalen a:");
Console.WriteLine($"{horas} h {minutos} min {segundosRestantes} s");

// Ejercicio 2: convertir grados Celsius a Fahrenheit.
Console.WriteLine("\n=== TEMPERATURA ===");
Console.Write("Ingresa la temperatura en grados Celsius: ");

if (double.TryParse(Console.ReadLine(), out double celsius))
{
    double fahrenheit = celsius * 9 / 5 + 32;
    Console.WriteLine($"{celsius:F1} °C equivalen a {fahrenheit:F1} °F");
}
else
{
    Console.WriteLine("Error: debes ingresar un número válido.");
}

// Ejercicio 3: calcular el promedio de tres notas.
Console.WriteLine("\n=== PROMEDIO DE TRES NOTAS ===");

Console.Write("Ingresa la primera nota: ");
bool nota1Valida = double.TryParse(Console.ReadLine(), out double nota1);

Console.Write("Ingresa la segunda nota: ");
bool nota2Valida = double.TryParse(Console.ReadLine(), out double nota2);

Console.Write("Ingresa la tercera nota: ");
bool nota3Valida = double.TryParse(Console.ReadLine(), out double nota3);

if (nota1Valida && nota2Valida && nota3Valida)
{
    double promedio = (nota1 + nota2 + nota3) / 3;
    Console.WriteLine($"El promedio es: {promedio:F1}");
}
else
{
    Console.WriteLine("Error: todas las notas deben ser números válidos.");
}
