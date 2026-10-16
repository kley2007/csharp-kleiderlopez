using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 500000;

            bool acceso = false;

            for (int intento = 1; intento <= 3; intento++)
            {
                Console.WriteLine("Ingrese su PIN:");
                string pin = Console.ReadLine();

                if (pin == "1234")
                {
                    Console.WriteLine("Ingresaste al cajero correctamente.");
                    acceso = true;
                    break;
                }
                else
                {
                    Console.WriteLine("PIN incorrecto");
                }
            }

            if (acceso == false)
            {
                Console.WriteLine("tarjeta bloqueada");
                return;
            }

            int opc = 0;

            do
            {
                Console.WriteLine("Bienvenido al menu del cajero.");
                Console.WriteLine("Opciones para realizar:\n1. Consultar\n2. Depositar\n3. Retirar\n4 Salir");
                Console.WriteLine("ingrese la operacion que desea realizar:");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"su saldo inicial es de: 500.000");
                        break;

                    case 2:
                        Console.WriteLine("Cuanto dinero desea depositar?");
                        string entradaDeposito = Console.ReadLine();
                        decimal deposito;

                        if (decimal.TryParse(entradaDeposito, out deposito) && deposito > 0)
                        {
                            saldo = saldo + deposito;

                            Console.WriteLine($"Deposito exitoso. Su nuevo saldo es: $ {saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un valor valido mayor que cero.");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Cuanto desea retirar?");
                        decimal retiro = Convert.ToDecimal(Console.ReadLine());

                        if (retiro > 0)
                        {
                            if (retiro % 10000 == 0)
                            {
                                if (retiro <= saldo)
                                {
                                    saldo = saldo - retiro;

                                    Console.WriteLine($"Su retiro ha sido exitoso. Su nuevo saldo es: $ {saldo}");
                                }
                                else
                                {
                                    Console.WriteLine("Saldo insuficiente.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Solo puede retirar multiplos de $10.000.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El retiro debe ser mayor a 0.");
                        }

                        break;
                
                        

                    case 4:
                        Console.WriteLine("Gracias por usar mi cajero.");
                        break;
                }
            } while (opc != 4);


        }
    }
}
