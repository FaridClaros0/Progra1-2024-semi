using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores_LABII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("\n \n *** MENU ***");
                Console.WriteLine("1. Conversor de monedas");
                Console.WriteLine("2. Conversor de masas");
                Console.WriteLine("3. Conversor de Volumen");
                Console.WriteLine("4. Conversor de Almacenamiento");
                Console.WriteLine("5. Conversor de Tiempo");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Opcion : ");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        monedas();
                        break;
                    case 2:
                        masas();
                        break;
                    case 3:
                        volumen();
                        break;
                    case 4:
                        almacenamiento();
                        break;
                    case 5:
                        tiempo();
                        break;
                    case 6:
                        continuar = "n";
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta \n\n");
                        break;
                }
            }
        }
    }
}
