using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4to_problema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, cantidad, hora, minuto;
            Console.WriteLine("Ingrese la cantidad de examenes A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de examenes B:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de examenes C:");
            C = int.Parse(Console.ReadLine());

            cantidad = (A * 5) + (B * 8) + (C * 6);
            hora = cantidad / 60;
            minuto = cantidad % 60;
            Console.WriteLine("=============================");
            Console.WriteLine("tardara " + hora + " horas y " + minuto + " minutos en finalizar.");
            Console.ReadKey();
        }
    }
}
