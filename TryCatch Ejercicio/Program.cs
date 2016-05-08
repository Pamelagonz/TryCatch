using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad=0;
            Console.WriteLine("Introduzca su edad:");
            
                edad = CapturaEdad(edad);
            
            

            Console.WriteLine("Su edad es:{0}", edad);
            Console.ReadKey();
        }

        private static int CapturaEdad(int edad)
        {
            try
            {
                edad = Int16.Parse(Console.ReadLine());
                return edad;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("ERROR:Eres una antiguedad.", Int16.MaxValue);
                return CapturaEdad(edad);
            }


            catch (FormatException)
            {
                Console.WriteLine("El formato no es valido.");
                return CapturaEdad(edad);
            }
        }
    }
}
