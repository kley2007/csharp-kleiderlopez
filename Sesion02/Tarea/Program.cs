using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generamos el numero secreto entre 1 y 100.
            Random aleatorio = new Random();
            int secreto = aleatorio.Next(1, 101);

            // Definimos la cantidad maxima de intentos.
            int intentos = 7;

            // Guardamos si el usuario adivino el numero.
            bool acerto = false;

            Console.WriteLine("=================================");
            Console.WriteLine("       ADIVINA EL NUMERO");
            Console.WriteLine("=================================");
            Console.WriteLine("Debes adivinar un numero entre 1 y 100.");
            Console.WriteLine("Tienes 7 intentos para lograrlo.");

            // Repetimos el juego hasta completar los 7 intentos.
            for (int i = 1; i <= intentos; i++)
            {
                Console.WriteLine($"\nIntento {i} de {intentos}");
                Console.WriteLine("Ingresa tu numero:");

                // Leemos el numero ingresado por el usuario.
                string entrada = Console.ReadLine();

                int numero;

                // Validamos que el dato ingresado sea un numero entero.
                if (!int.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Entrada no valida. Escribe un numero entero.");

                    // Este dato no cuenta como un intento valido.
                    i--;
                    continue;
                }

                if (numero < 1 || numero > 100)
                {
                    Console.WriteLine("El numero debe estar entre 1 y 100.");
                    i--;
                    continue;
                }

                // Comparamos el numero ingresado con el secreto.
                if (numero == secreto)
                {
                    Console.WriteLine($"¡Felicitaciones! Adivinaste en {i} intentos.");
                    acerto = true;
                    break;
                }
                else if (numero < secreto)
                {
                    Console.WriteLine("El numero secreto es mayor.");
                }
                else
                {
                    Console.WriteLine("El numero secreto es menor.");
                }
            }

            // Si no acerto despues de los 7 intentos, revelamos el secreto.
            if (acerto == false)
            {
                Console.WriteLine($"Se acabaron los intentos. El numero secreto era {secreto}.");
            }

            Console.WriteLine("\nGracias por jugar.");
        }
    }
}
