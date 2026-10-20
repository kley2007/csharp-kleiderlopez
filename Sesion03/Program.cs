//using System;
//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine(" VALIDADOR DE CONTRASEÑAS. ");

//string contraseña;

//do
//{
//    Console.Write("\nIngresa una contraseña: ");
//    contraseña = Console.ReadLine() ?? "";

//    EvaluarContraseña(contraseña);

//} while (ContarReglas(contraseña) < 4);

//Console.WriteLine("\n¡Contraseña aceptada!");

//static void EvaluarContraseña(string contraseña)
//{
//    bool longitud = contraseña.Length >= 8;
//    bool mayuscula = contraseña.Any(char.IsUpper);
//    bool minuscula = contraseña.Any(char.IsLower);
//    bool numero = contraseña.Any(char.IsDigit);
//    bool especial = contraseña.Any(c => !char.IsLetterOrDigit(c)
//                                        && !char.IsWhiteSpace(c));
//    bool sinEspacios = !contraseña.Any(char.IsWhiteSpace);

//    int puntos = 0;

//    Console.WriteLine($"\nContraseña: {contraseña}");
//    MostrarRegla(longitud, "Mínimo 8 caracteres");
//    MostrarRegla(mayuscula, "Minimo una mayúscula");
//    MostrarRegla(minuscula, "Minimo una minúscula");
//    MostrarRegla(numero, "un número");
//    MostrarRegla(especial, "Un carácter especial");
//    MostrarRegla(sinEspacios, "Sin espacios");

//    if (longitud) puntos++;
//    if (mayuscula) puntos++;
//    if (minuscula) puntos++;
//    if (numero) puntos++;
//    if (especial) puntos++;
//    if (sinEspacios) puntos++;

//    string nivel = puntos >= 6 ? "Fuerte" :
//                   puntos >= 4 ? "Media" : "Débil";

//    Console.WriteLine($"Nivel: {nivel} ({puntos}/6)");
//}

//static void MostrarRegla(bool cumple, string regla)
//{
//    string simbolo = cumple ? "\u2713" : "X";
//    Console.WriteLine($"{simbolo} {regla}");
//}

//static int ContarReglas(string contraseña)
//{
//    int puntos = 0;

//    if (contraseña.Length >= 8) puntos++;
//    if (contraseña.Any(char.IsUpper)) puntos++;
//    if (contraseña.Any(char.IsLower)) puntos++;
//    if (contraseña.Any(char.IsDigit)) puntos++;
//    if (contraseña.Any(c => !char.IsLetterOrDigit(c)
//                            && !char.IsWhiteSpace(c))) puntos++;
//    if (!contraseña.Any(char.IsWhiteSpace)) puntos++;

//    return puntos;
//}


using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("VALIDADOR DE CONTRASEÑAS.");
string contraseña;

do
{
    Console.Write("Ingresa una contraseña: ");
    contraseña = Console.ReadLine() ?? "";

    Evaluar(contraseña);

} while (Contar(contraseña) < 6 ||
         contraseña.ToLower().Contains("1234") ||
         contraseña.ToLower().Contains("clave"));

Console.WriteLine("¡Contraseña aceptada!");

static void Evaluar(string contraseña)
{
    bool mayuscula = false, minuscula = false;
    bool numero = false, especial = false, espacios = true;

    foreach (char c in contraseña)
    {
        if (char.IsUpper(c)) mayuscula = true;
        if (char.IsLower(c)) minuscula = true;
        if (char.IsDigit(c)) numero = true;
        if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
            especial = true;
        if (char.IsWhiteSpace(c)) espacios = false;
    }

    bool[] reglas = { contraseña.Length >= 8, mayuscula,
        minuscula, numero, especial, espacios };

    string[] nombres = { "Mínimo 8 caracteres", "Una mayúscula",
        "Una minúscula", "Un número", "Un carácter especial",
        "Sin espacios" };

    int puntos = 0;

    for (int i = 0; i < reglas.Length; i++)
    {
        Console.WriteLine($"{(reglas[i] ? "\u2713" : "X")} {nombres[i]}");
        if (reglas[i]) puntos++;
    }

    string nivel = puntos == 6 ? "Fuerte" :
                   puntos >= 4 ? "Media" : "Débil";

    Console.WriteLine($"Nivel: {nivel} ({puntos}/6)");
    Console.WriteLine($"{(!contraseña.ToLower().Contains("1234") ? "\u2713" : "X")} No contiene 1234");
    Console.WriteLine($"{(!contraseña.ToLower().Contains("clave") ? "\u2713" : "X")} No contiene clave");
}

static int Contar(string contraseña)
{
    int puntos = 0;
    bool mayuscula = false, minuscula = false;
    bool numero = false, especial = false, espacios = true;

    foreach (char c in contraseña)
    {
        if (char.IsUpper(c)) mayuscula = true;
        if (char.IsLower(c)) minuscula = true;
        if (char.IsDigit(c)) numero = true;
        if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
            especial = true;
        if (char.IsWhiteSpace(c)) espacios = false;
    }

    if (contraseña.Length >= 8) puntos++;
    if (mayuscula) puntos++;
    if (minuscula) puntos++;
    if (numero) puntos++;
    if (especial) puntos++;
    if (espacios) puntos++;

    return puntos;
}
