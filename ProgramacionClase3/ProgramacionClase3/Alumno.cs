using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionClase3
{
    class Alumno
    {
        public string nombre;

        public void mostrar()
        {
            Console.Write(this.nombre+legajo);//sin el this se puede usar igual 
            

        }
        public int legajo;

        public bool compararme(Alumno alumno)//va a devolver true
        {
            bool respuesta = false;
            if (this.nombre == alumno.nombre && this.legajo == alumno.legajo)
            {
                respuesta = true;
            }
            
            
            return respuesta;
        }

    }
}
