using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usodetrypass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "uso de try parse";
            string dato;
            Console.WriteLine("Ingrese su edad");
            dato = Console.ReadLine();
            int numero;
            numero = int.Parse(dato);
        }
    }
}
