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
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static double Division(double a, double b)
        {
                return a / b;
        }

        static void Primos()
        {
            int n = 2;
            int total = 1;
            while (total <= 10)
            {
                Boolean esPrimo = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }
                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                n++;
            }
        }
        static double ConversionFaC(double a)
        {
            return (5*(a-32))/9;
        }
        static double ConversionCaF(double a)
        {
            return (9*a)/5+32;
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicación de dos números");
                Console.WriteLine("[4] División de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Conversión de temperatura");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("Ingrese el primer número");
                        double g = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        double h = Convert.ToDouble(Console.ReadLine());
                        if (h == 0)
                        {
                            Console.WriteLine("No se puede dividir entre 0");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------------------------------------------------");
                            Console.WriteLine("La división de {0} y {1} es {2}", g, h, Division(g, h));
                            Console.WriteLine("--------------------------------------------------------------------------------------");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        Console.WriteLine("Escoger:");
                        Console.WriteLine("a. De Farengeith a Celsius");
                        Console.WriteLine("b. De Celsius a Farenheit");
                        Console.WriteLine("Ingrese una opción y presione ENTER");
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                        string opciondos = Console.ReadLine();
                        switch (opciondos){
                            case "a":
                                Console.WriteLine("--------------------------------------------------------------------------------------");
                                Console.WriteLine("Ingrese la temperatura en grados Farenheit");
                                double p = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("La temperatura de {0} F convertido a Celsius es: {1}",p,ConversionFaC(p));
                                Console.ReadKey();
                                break;
                            case "b":
                                Console.WriteLine("--------------------------------------------------------------------------------------");
                                Console.WriteLine("Ingrese la temperatura en grados Celsius");
                                double s = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("La temperatura de {0} C convertido a Farenheit es: {1}",s, ConversionCaF(s));
                                ConversionCaF(s);
                                Console.ReadKey();
                                break;
                        }

                        break;
                }
            } while (!opcion.Equals("0"));
        }
    }
}
