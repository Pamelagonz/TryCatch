using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    //Mientras no marque error no se sale
    class Program
    {
        static void Main(string[] args)
        {
            int edad = CapturaEdad();
            //Console.WriteLine("Introduzca su edad:");

            Console.WriteLine("Su edad es:{0}", edad);
            Console.ReadKey();
        }

        private static int CapturaEdad()
        {
            Console.WriteLine("Su edad es:");
            try
            {
                return Int16.Parse(Console.ReadLine());
                
            }
            catch (OverflowException e)
            {
                Console.WriteLine("ERROR:Eres una antiguedad.");
                return CapturaEdad();
            }


            catch (FormatException)
            {
                Console.WriteLine("El formato no es valido.");
                return CapturaEdad();
            }
        }
    }
}
