using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] notas = new double[10];
                int posicion, aprobado, reprobado;
                aprobado = 0;
                reprobado = 0;

                for (int i = 0; i < 10; i++)
                {
                    posicion = i + 1;
                    Console.Write("Ingrese la nota #" + posicion + ": ");
                    notas[i] = double.Parse(Console.ReadLine());

                    if (notas[i] >= 7)
                    {
                        aprobado = aprobado + 1;
                    }
                    else
                    {
                        reprobado = reprobado + 1;
                    }
                }
                Console.WriteLine("Tenemos un total de " + aprobado + " estudiantes aprobados.");
                Console.WriteLine("Tenemos un total de " + reprobado + " estudiantes aprobados.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");
            }
            Console.ReadKey();
        }
    }
}
