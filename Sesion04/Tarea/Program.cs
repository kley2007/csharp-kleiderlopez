
using System;
using System.Collections.Generic;
using System.Linq;

List<Venta> ventas =
[
    new("Portátil", "Medellín", 2, 2800000m),
    new("Mouse", "Bogotá", 10, 45000m),
    new("Teclado", "Cali", 5, 120000m),
    new("Monitor", "Medellín", 3, 750000m),
    new("Mouse", "Medellín", 8, 45000m),
    new("Portátil", "Bogotá", 1, 2800000m),
    new("Diadema", "Cali", 6, 180000m),
    new("Monitor", "Bogotá", 2, 750000m),
    new("Teclado", "Medellín", 4, 120000m),
    new("Diadema", "Bogotá", 3, 180000m),
    new("Portátil", "Cali", 2, 2800000m),
    new("Mouse", "Cali", 12, 45000m)
];

// 1. Total vendido
decimal total = ventas.Sum(v => v.Cantidad * v.PrecioUnitario);
Console.WriteLine($"Total vendido: {total:C0}");

// 2. Promedio por venta
decimal promedio = ventas.Average(v => v.Cantidad * v.PrecioUnitario);
Console.WriteLine($"Promedio por venta: {promedio:C2}");

// 3. Ventas por ciudad
Console.WriteLine("\nVENTAS POR CIUDAD");

var porCiudad = ventas
    .GroupBy(v => v.Ciudad)
    .Select(g => new
    {
        Ciudad = g.Key,
        Total = g.Sum(v => v.Cantidad * v.PrecioUnitario)
    })
    .OrderByDescending(g => g.Total);

foreach (var ciudad in porCiudad)
{
    Console.WriteLine($"{ciudad.Ciudad}: {ciudad.Total:C0}");
}

// 4. Top 3 de productos por ingresos
Console.WriteLine("\nTOP 3 PRODUCTOS POR INGRESOS");

var top3 = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new
    {
        Producto = g.Key,
        Ingresos = g.Sum(v => v.Cantidad * v.PrecioUnitario)
    })
    .OrderByDescending(g => g.Ingresos)
    .Take(3);

foreach (var producto in top3)
{
    Console.WriteLine($"{producto.Producto}: {producto.Ingresos:C0}");
}

// 5. Producto más vendido por unidades
Console.WriteLine("\nPRODUCTO MÁS VENDIDO POR UNIDADES");

var masVendido = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new
    {
        Producto = g.Key,
        Unidades = g.Sum(v => v.Cantidad)
    })
    .OrderByDescending(g => g.Unidades)
    .First();

Console.WriteLine($"{masVendido.Producto}: {masVendido.Unidades} unidades");

record Venta(string Producto, string Ciudad, int Cantidad, decimal PrecioUnitario);

