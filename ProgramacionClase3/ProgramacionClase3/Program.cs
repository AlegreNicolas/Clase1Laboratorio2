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
            Console.ReadKey();

        }
    }
}
