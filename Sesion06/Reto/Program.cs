using Reto;
using System;
using System.Collections.Generic;
using System.Linq;


List<Empleado> nomina =
[
    new EmpleadoPlanta("Ana Gómez", "1001", 3_200_000m, 6),
    new EmpleadoPlanta("Luis Pérez", "1002", 2_800_000m, 2),
    new EmpleadoPorHoras("Marta Ruiz", "1003", 170, 18_000m),
    new EmpleadoPorHoras("Jorge Díaz", "1004", 120, 18_000m),
    new Contratista("Sofía León", "1005", 4_000_000m)
];

Console.WriteLine("=== NÓMINA DE EMPLEADOS ===");

foreach (Empleado empleado in nomina)
{
    Console.WriteLine(empleado);
}

Console.WriteLine("\nTOTAL DE LA NÓMINA:");
Console.WriteLine($"${nomina.Sum(e => e.CalcularSalario()):N0}");

Empleado mayor = nomina.MaxBy(e => e.CalcularSalario())!;
Console.WriteLine($"\nMAYOR PAGO:\n{mayor}");

Console.WriteLine("\nTOTAL POR TIPO:");

var totales = nomina
    .GroupBy(e => e.Tipo)
    .Select(g => new
    {
        Tipo = g.Key,
        Total = g.Sum(e => e.CalcularSalario())
    });

foreach (var grupo in totales)
{
    Console.WriteLine($"{grupo.Tipo}: ${grupo.Total:N0}");
}
