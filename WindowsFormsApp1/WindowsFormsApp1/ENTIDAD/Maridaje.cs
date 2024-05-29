using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ENTIDAD
{
    public class Maridaje
    {
        //////////// ATRIBUTOS ////////////

        private string descripcion;
        private string nombre;
        public Maridaje(string nombre, string descripcion)
        {
            descripcion = string.Empty;
            nombre = string.Empty;
        }

        //////////// SETS Y GETS ////////////
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //////////// TERMINAN SETS Y GETS ////////////

        //////////// MÉTODOS ////////////

    }
}
