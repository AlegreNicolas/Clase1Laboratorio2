using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionClase3
{
    class Auto
    {
        public Rueda ruedauno;
        public Rueda ruedados;
        public Rueda ruedatres;
        public Rueda ruedacuatro;
        private string marca;
        public static string fecha;

        static Auto()
        {
             Auto.fecha= (new DateTime()).ToString();
        }
        public Auto(string marca)
        {
            this.marca = marca;
            Auto.fecha = "oooooo";

        }


    }
}
