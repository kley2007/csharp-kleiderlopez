using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

List<Contacto> contactos =
[
    new("Ana", "3001234567"),
    new("Luis", "3109876543")
];

// Guardar los contactos en JSON
var opciones = new JsonSerializerOptions
{
    WriteIndented = true
};

File.WriteAllText(
    "contactos.json",
    JsonSerializer.Serialize(contactos, opciones)
);

Console.WriteLine("Contactos guardados correctamente.");

// Recuperar los contactos
List<Contacto> recuperados = [];

try
{
    string json = File.ReadAllText("contactos.json");

    recuperados = JsonSerializer.Deserialize<List<Contacto>>(json) ?? [];
}
catch (JsonException)
{
    Console.WriteLine("El archivo está dañado. Empiezo vacío.");
}

// Mostrar los contactos recuperados
Console.WriteLine("\n=== CONTACTOS RECUPERADOS ===");

foreach (var contacto in recuperados)
{
    Console.WriteLine($"{contacto.Nombre}: {contacto.Telefono}");
}

Console.WriteLine($"\nGuardado en: {Path.GetFullPath("contactos.json")}");

record Contacto(string Nombre, string Telefono);
