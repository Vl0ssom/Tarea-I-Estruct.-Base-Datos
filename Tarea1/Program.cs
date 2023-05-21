using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo1 = new int[5];
            int[] arreglo2 = new int[5];
            int[] arreglo3 = new int[10];

            Console.WriteLine("Ingrese los valores para el arreglo 1:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Valor {0}: ", i + 1);
                arreglo1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ingrese los valores para el arreglo 2:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Valor {0}: ", i + 1);
                arreglo2[i] = Convert.ToInt32(Console.ReadLine());
            }

                //Combinar arreglos
                Array.Copy(arreglo1, arreglo3, arreglo1.Length);
                Array.Copy(arreglo2, 0, arreglo3, arreglo1.Length, arreglo2.Length);

                // Ordenar el arreglo 3 descendentemente
                Array.Sort(arreglo3);
                Array.Reverse(arreglo3);

                Console.WriteLine("El arreglo 3 ordenado descendentemente es:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arreglo3[i] + " ");
            }

        Console.ReadLine();
        } 
    }
}
