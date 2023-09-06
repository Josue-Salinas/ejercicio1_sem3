using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_sem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int distancia,precio_caja;
            string tipo_fruta;
            Console.Write("TIPOS DE FRUTA:");
            Console.WriteLine("\tNaranja Fresa Mango");
            Console.WriteLine("Ingrese el tipo de fruta:");
            tipo_fruta = Console.ReadLine();
            Console.WriteLine("Ingrese la distancia en kilómetros: ");
            distancia = int.Parse(Console.ReadLine());
            switch (tipo_fruta)
            {
                case "Naranja":
                    if (distancia < 30)
                    {
                        precio_caja = 2;
                    }
                    else
                    {
                        precio_caja = 4;
                    }
                    break;
                case "Fresa":
                    if (distancia< 30)
                    {
                        precio_caja = 6;
                    }
                    else
                    {
                        precio_caja = 9;
                    }
                    break;
                case "Mango":
                    if (distancia < 30)
                    {
                        precio_caja = 3;
                    }
                    else
                    {
                        precio_caja = 5;
                    }
                    break;
                default:
                    Console.WriteLine("EL tipo de fruta no es válido.");
                    return;
            }
            Console.WriteLine("El costo por caja de frutas es: S/"+precio_caja);
            Console.ReadKey();
        }
    }
}
