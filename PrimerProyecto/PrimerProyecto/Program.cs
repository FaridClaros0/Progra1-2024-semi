using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //estructuras de control
            // 1. if. ejercicio de mayoria de edad
            Console.Write("Edad:");
            int edad = int.Parse(Console.ReadLine());

            if (edad <0) {
                Console.WriteLine("Edad incorrecta");
            }
            else if (edad <=2) {
                Console.WriteLine("Eres un bebe");
            }
            else if (edad <12) 
            {
                 Console.WriteLine("Eres un niño");
            } else if (edad <18)
            { 
                Console.WriteLine("Eres un adolescente");
            }
            else if (edad <=65)
            {
                Console.WriteLine("Bienvenido al mundo de las responsabilidades");  
            } else if (edad <=80)
            {
                Console.WriteLine("Eres un adulto mayror");
            } else {
                Console.WriteLine("Larga vida");
            }

            //Pausa.
            Console.ReadLine();

        }
    }
}
