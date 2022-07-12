﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosockeet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Edad: ");
            string edadtx = Console.ReadLine().Trim();
            int edad = -1;
            bool esValido = Int32.TryParse(edadtx, out edad);

            if (!esValido) //if (!esValido) es decir If (esvalido == true) 
            {
                Console.WriteLine("Ingrese bien la edad");
            }
            else
            {
                Console.WriteLine("Su nombre es {0} y su edad es {1}", nombre, edad);
            }

            Console.ReadKey();
        }
    }
}
