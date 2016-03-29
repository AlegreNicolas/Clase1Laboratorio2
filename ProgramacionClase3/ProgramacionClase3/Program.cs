using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionClase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto.fecha = "lalalal";
            int numero;
            numero = 0;
            Alumno unalumno;
            unalumno=new Alumno(666);
            //Alumno nuevo = new Alumno();
            //unalumno.nombre = "Nicolas";
            unalumno.Setnombre("Nicolas");
            unalumno.Getlegajo();
            //Console.WriteLine(unalumno.nombre);
            unalumno.mostrar();
            Auto unauto = new Auto("Fiat");
            Auto unauto2 = new Auto("Fiat");
            Auto unauto3 = new Auto("Fiat");

            Console.ReadKey();

        }
    }
}
