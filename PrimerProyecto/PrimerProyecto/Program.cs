﻿using System;
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
            //ejercicio de obtener la nota final de la materia de Programacion I.
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine()); //8

            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine()); //9

            Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine()); //7

            // 8*30%= 2.4
            // 9*30%= 2.7
            // 7*40%= 2.8
            //C1    = 7.9

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            //segundo computo

            Console.Write("Lab1: ");
            double lab12 = double.Parse(Console.ReadLine()); //8

            Console.Write("Lab2: ");
            double lab22 = double.Parse(Console.ReadLine()); //9

            Console.Write("Parcial 2: ");
            double parcial2 = double.Parse(Console.ReadLine()); //7


            double c2 = lab12 * 30 / 100 + lab22 * 30 / 100 + parcial2 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0}", c2);

            //tercer computo

            Console.Write("Lab1: ");
            double lab13 = double.Parse(Console.ReadLine()); 

            Console.Write("Lab2: ");
            double lab23 = double.Parse(Console.ReadLine()); 

            Console.Write("Parcial 2: ");
            double parcial3 = double.Parse(Console.ReadLine()); 


            double c3 = lab12 * 30 / 100 + lab22 * 30 / 100 + parcial2 * 40 / 100;
            Console.WriteLine("La nota de C3 es: {0}", c3);

            //nota final

            double f1 = (c1 + c2 + c3) / 3;
            Console.Write("La nota final es: {}", f1);
            //Pausa.
            Console.ReadLine();

        }
    }
}
