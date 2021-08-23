using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLab01_1
{
   
    class Program
    {
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            Console.WriteLine("Ingrese el primer número");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
            Console.ReadKey();
        }
    }
}
