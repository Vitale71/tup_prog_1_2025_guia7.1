using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cantMasa, budinesSob, paquetesSob, masaSob;
            int budines, paquetes, cajas;
            Console.WriteLine("Ingrese la cantidad de masa a producir");
            cantMasa = Convert.ToSingle(Console.ReadLine());
            masaSob = cantMasa % 55f;
            budines = (int)((cantMasa - masaSob) / 55);
            budinesSob = budines % 12f;
            paquetes = (int)((budines - budinesSob) / 12);
            paquetesSob = paquetes % 20f;
            cajas = (int)((paquetes - paquetesSob) / 20);
            Console.WriteLine("Se pudo producir una cantidad de budines de {0} con masa sobrante de {1}, La cantidad de paquetes de {2} con {3} budines sobrantes, " +
                "la cantidad de cajas de {4} con la cantidad de {5} paquetes sobrantes", budines, masaSob, paquetes, budinesSob, cajas, paquetesSob);
        }
    }
}