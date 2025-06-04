using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float montoRepartir, p1, p2, p3, p4, m1, m2, m3, m4;
            short e1, e2, e3, e4, edadTotal;
            Console.WriteLine("Ingrese el monto a repartir");
            montoRepartir = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ingrese las edades de cada niña");
            e1 = Convert.ToInt16(Console.ReadLine());
            e2 = Convert.ToInt16(Console.ReadLine());
            e3 = Convert.ToInt16(Console.ReadLine());
            e4 = Convert.ToInt16(Console.ReadLine());

            edadTotal = (short)(e1 + e2 + e3 + e4);
            p1 = (e1 * 100) / edadTotal;
            p2 = (e2 * 100) / edadTotal;
            p3 = (e3 * 100) / edadTotal;
            p4 = (e4 * 100) / edadTotal;
            m1 = (p1 * montoRepartir) / 100;
            m2 = (p2 * montoRepartir) / 100;
            m3 = (p3 * montoRepartir) / 100;
            m4 = (p4 * montoRepartir) / 100;
            Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}", e1, p1, m1);
            Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}", e2, p2, m2);
            Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}", e3, p3, m3);
            Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}", e2, p4, m4);
        }
    }
}
