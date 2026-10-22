
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine(" USUARIOS Y FRASES ");

Console.WriteLine("\n1. GENERADOR DE USUARIOS");

Console.Write("Nombre completo: ");
string nombre = Console.ReadLine() ?? "";

Console.Write("Documento: ");
string documento = Console.ReadLine() ?? "";

string usuario = GenerarUsuario(nombre, documento);

Console.WriteLine("Usuario generado: " + usuario);

Console.WriteLine("\n2. ANALIZADOR DE FRASES");

Console.Write("Escribe una frase: ");
string frase = Console.ReadLine() ?? "";

int palabras = ContarPalabras(frase);
string fraseInvertida = InvertirFrase(frase);

Console.WriteLine("Cantidad de palabras: " + palabras);
Console.WriteLine("Frase en orden inverso: " + fraseInvertida);

static string GenerarUsuario(string nombre, string documento)
{
    nombre = nombre.Trim().ToLower();
    nombre = QuitarTildes(nombre);

    string[] partes = nombre.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (partes.Length < 2 || documento.Length < 2)
        return "Datos no válidos";

    string usuario = partes[0][0] + partes[2];
    usuario = usuario.Replace(" ", "");

    string ultimosDigitos = documento.Substring(documento.Length - 2);

    return usuario + ultimosDigitos;
}

static string QuitarTildes(string texto)
{
    texto = texto.Replace("á", "a");
    texto = texto.Replace("é", "e");
    texto = texto.Replace("í", "i");
    texto = texto.Replace("ó", "o");
    texto = texto.Replace("ú", "u");
    texto = texto.Replace("ñ", "n");

    return texto;
}

static int ContarPalabras(string frase)
{
    string[] palabras = frase.Split(
        ' ', StringSplitOptions.RemoveEmptyEntries);

    return palabras.Length;
}

static string InvertirFrase(string frase)
{
    string[] palabras = frase.Split(
        ' ', StringSplitOptions.RemoveEmptyEntries);

    StringBuilder resultado = new StringBuilder();

    for (int i = palabras.Length - 1; i >= 0; i--)
    {
        resultado.Append(palabras[i]);

        if (i > 0)
            resultado.Append(' ');
    }

    return resultado.ToString();
}
