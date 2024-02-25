using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //EJERCICIO: Calcular el area y perimetro de la circulo


                // Definicion de variables y constantes
                double radio, area, peri;

                //Ingreso de datos
                Console.WriteLine("CALCULO DEL ÁREA Y PERIMETRO DEL CIRCULO");
                Console.Write("Ingrese Radio :");
                radio = double.Parse(Console.ReadLine());

                //Calculos

                area = 3.1416 * Math.Pow(radio, 2);
                peri = 2 * Math.PI * radio;

                //mostrar resultados
                Console.WriteLine("AREA      = {0}", area);
                Console.WriteLine("PERIMETRO = {0}", peri);

                Console.ReadKey();
        }
    }
}

   
