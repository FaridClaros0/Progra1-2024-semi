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
            //  ejercicio de sacar la media aritmetca y la desviacion tipica de una serie de numeros    
            Console.Write("Ingrese los numeros separados por comas: ");
            string serie = Console.ReadLine();
            string[] numeros = serie.Split(',');

            Console.WriteLine("La media aritmetica es: {0}, y la desviacion tipica es: {1}, la media armonica es: {2}",
                 media(numeros), tipica(numeros), armonica(numeros));

            Console.ReadLine();
        }
        static double media(string[] serie)
        {
            double media = 0;
            foreach (string num in serie)
            {
                media += int.Parse(num);
            }
            return media / serie.Length;
        }
        static double tipica(string[] serie)
        {
            double tipica = 0,
                    m = media(serie);
            foreach (string num in serie)
            {
                tipica += Math.Pow(int.Parse(num) - m, 2);
            }
            tipica = Math.Sqrt(tipica / serie.Length);
            return Math.Round(tipica, 2);
        }
        static double armonica(string[] serie)
        {
            double armonica = 0;
            foreach (string num in serie)
            {
                armonica += (1.0 / double.Parse(num));
            }
            armonica = serie.Length / armonica;
            return Math.Round(armonica, 2);
        }
    }
       }
 
