using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ENTIDAD
{
    public class Bodega
    {
        //////////// ATRIBUTOS ////////////
        private static List<Bodega> bodegas = new List<Bodega>();
        private List<float> coordenadasUbicacion;
        private string descripcion;
        private string historia;
        private string nombre;
        private int periodoActualizacion;



        public Bodega(string nombre, string historia, string descripcion, int periodoActualizacion, List<float> coordenadasUbicacion)
        {
            coordenadasUbicacion = new List<float>();
            descripcion = string.Empty;
            historia = string.Empty;
            nombre = string.Empty;
            periodoActualizacion = 2;

            bodegas.Add(this);
        }

        //////////// SETS Y GETS ////////////
        public List<float> CoordenadasUbicacion
        {
            get { return coordenadasUbicacion; }
            set { coordenadasUbicacion = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Historia
        {
            get { return historia; }
            set { historia = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int PeriodoActualizacion
        {
            get { return periodoActualizacion; }
            set { periodoActualizacion = value; }
        }


        //////////// TERMINAN SETS Y GETS ////////////

        //////////// MÉTODOS ////////////

        public List<string> ObtenerNombresBodegas()
        {
            List<string> nombres = new List<string>();
            foreach (Bodega bodega in bodegas)
            {
                nombres.Add(bodega.getNombre());
            }
            return nombres;
        }

        public string getNombre()
        {
            return this.nombre;
        }
    }
}
