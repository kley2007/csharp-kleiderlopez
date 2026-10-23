
using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string, List<double>> notas = new(StringComparer.OrdinalIgnoreCase);

int opcion;

do
{
    Console.WriteLine("\n GESTOR DE NOTAS");
    Console.WriteLine("1. Registrar aprendiz");
    Console.WriteLine("2. Agregar nota");
    Console.WriteLine("3. Listar aprendices");
    Console.WriteLine("4. Ranking por promedio");
    Console.WriteLine("5. Mejor aprendiz y aprobados");
    Console.WriteLine("6. Eliminar aprendiz");
    Console.WriteLine("7. Salir");
    Console.Write("Elige una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
        opcion = 0;

    switch (opcion)
    {
        case 1:
            Registrar();
            break;
        case 2:
            AgregarNota();
            break;
        case 3:
            Listar();
            break;
        case 4:
            Ranking();
            break;
        case 5:
            Mejor();
            break;
        case 6:
            Eliminar();
            break;
        case 7:
            Console.WriteLine("¡Hasta luego!");
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

} while (opcion != 7);

void Registrar()
{
    Console.Write("Nombre del aprendiz: ");
    string nombre = Console.ReadLine() ?? "";

    if (string.IsNullOrWhiteSpace(nombre))
    {
        Console.WriteLine("El nombre no puede estar vacío.");
        return;
    }

    if (notas.ContainsKey(nombre))
    {
        Console.WriteLine("Ese aprendiz ya está registrado.");
        return;
    }

    notas[nombre] = [];
    Console.WriteLine("Aprendiz registrado.");
}

void AgregarNota()
{
    Console.Write("Nombre del aprendiz: ");
    string nombre = Console.ReadLine() ?? "";

    if (!notas.ContainsKey(nombre))
    {
        Console.WriteLine("Aprendiz no encontrado.");
        return;
    }

    Console.Write("Nota (0 a 5): ");

    if (!double.TryParse(Console.ReadLine(), out double nota) ||
        nota < 0 || nota > 5)
    {
        Console.WriteLine("La nota debe estar entre 0 y 5.");
        return;
    }

    notas[nombre].Add(nota);
    Console.WriteLine("Nota agregada.");
}

void Listar()
{
    foreach (var (nombre, lista) in notas)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine($"{nombre}: Sin notas");
            continue;
        }

        double promedio = lista.Average();
        string juicio = promedio >= 3 ? "A" : "D";

        Console.WriteLine(
            $"{nombre} - {lista.Count} notas - Promedio {promedio:F1} - Juicio {juicio}");
    }
}

void Ranking()
{
    var ranking = notas
        .Where(a => a.Value.Count > 0)
        .OrderByDescending(a => a.Value.Average());

    foreach (var aprendiz in ranking)
    {
        Console.WriteLine(
            $"{aprendiz.Key}: {aprendiz.Value.Average():F1}");
    }
}

void Mejor()
{
    var conNotas = notas.Where(a => a.Value.Count > 0).ToList();

    if (conNotas.Count == 0)
    {
        Console.WriteLine("Todavía no hay notas registradas.");
        return;
    }

    var mejor = conNotas.MaxBy(a => a.Value.Average());
    int aprobados = conNotas.Count(a => a.Value.Average() >= 3);

    Console.WriteLine(
        $"Mejor aprendiz: {mejor.Key} - Promedio {mejor.Value.Average():F1}");
    Console.WriteLine($"Aprendices aprobados: {aprobados}");
}

void Eliminar()
{
    Console.Write("Nombre del aprendiz: ");
    string nombre = Console.ReadLine() ?? "";

    if (notas.Remove(nombre))
        Console.WriteLine("Aprendiz eliminado.");
    else
        Console.WriteLine("Aprendiz no encontrado.");
}



