using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionClase3
{
    class Alumno
    {
        private string nombre;
        private int legajo;

        public void mostrar()
        {
            Console.Write(this.nombre + this.legajo);//sin el this se puede usar igual 
            

        }

        private bool compararme(Alumno alumno)//va a devolver true
        {
            bool respuesta = false;
            if (this.nombre == alumno.nombre && this.legajo == alumno.legajo)
            {
                respuesta = true;
            }
            
            
            return respuesta;
        }

        public static bool comparardosalumnos(Alumno alumnouno, Alumno alumnodos)
        {
            bool respuesta = false;
            if (alumnouno.nombre == alumnodos.nombre && alumnouno.legajo == alumnodos.legajo)
            {
                respuesta = true;
            }

            return respuesta;
        }
        public static void mostraralumno(Alumno alumno)
        {
            Console.Write(alumno.nombre + alumno.legajo);
        }
        //contrustor
        public Alumno(int legajo)
        {

            this.nombre = "lalal";
            this.legajo = legajo;

        }
        public int Getlegajo()
        {



            return this.legajo;
        }
        
        public void Setnombre(string nombre)
        {

            this.nombre = nombre;

        }



    }
}
