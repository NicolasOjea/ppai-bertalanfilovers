using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ENTIDAD
{
    public class Enofilo
    {
        //////////// ATRIBUTOS ////////////
        private int imagenPerfil;
        private string apellido;
        private string nombre;
        private List<Vino> vino;
        private List<Siguiendo> siguiendo;

        //////////// CONSTRUCTOR ////////////
        public Enofilo(string nombre, string apellido, int imagenPerfil, List<Vino> vino, List<Siguiendo> siguiendo)
        {
            imagenPerfil = 0;
            apellido = string.Empty;
            nombre = string.Empty;
            vino = new List<Vino>();
            siguiendo = new List<Siguiendo>();
        }

        //////////// SETS Y GETS ////////////
        public int ImagenPerfil
        {
            get { return imagenPerfil; }
            set { imagenPerfil = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public List<Vino> Vino
        {
            get { return vino; }
            set { vino = value; }
        }

        public List<Siguiendo> Siguiendo
        {
            get { return siguiendo; }
            set { siguiendo = value; }
        }

        //////////// TERMINAN SETS Y GETS ////////////

        //////////// MÉTODOS ////////////
    }
}
