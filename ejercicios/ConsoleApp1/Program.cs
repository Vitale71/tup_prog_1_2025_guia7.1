using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, aaa, letrasN;
            string letras, letra1, letra2, letra3;
            letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("ingrese el numero completo");
            num = Convert.ToInt32(Console.ReadLine());

            #region calcular letras y numeros
            #endregion

            #region defiinir letras
            int baja = num % 1000;
            int alta = num / 1000;
            alta = alta % (26 * 26 * 26);//opcional para limitarlo si desborda

            char d6 = (char)(alta % 26);
            alta = alta / 26;

            char d5 = (char)(alta % 26);
            alta = alta / 26;

            char d4 = (char)(alta % 26);

            char d3 = (char)(baja % 26);
            baja = baja / 26;

            char d2 = (char)(baja % 26);
            baja = baja / 26;

            char d1 = (char)(baja % 26);

            string patente = "" + d6 + d5 + d4 + d3 + d2 + d1;
            #endregion

            Console.WriteLine("Patente generada: " + patente);
        }
    }
}
