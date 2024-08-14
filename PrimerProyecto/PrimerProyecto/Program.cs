using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args) {
            // determinar si cada numero de la serie es primo.

            int[] Serie = new int[] { 5, 9, 4, 6, 3, 2,7,11,15,17,21 };
            foreach (int num in Serie)
            {
                int i = 1,
                    n = 0;
                while (i <= num && n<=2){
                    if (num % i == 0){
                        n++;
                    }
                    i++;
                }
                Console.WriteLine("El numero es {0} {1}", num, n<=2 ? "es primo" : "no es primo");
            }
            Console.ReadLine();
        }
    }
}
 
