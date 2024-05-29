using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ENTIDAD
{
    public class Siguiendo
    {
        //////////// ATRIBUTOS ////////////
        private DateTime fechaFin;
        private DateTime fechaInicio;
        private List<Bodega> bodega;
        private List<Enofilo> enofilo;
        //////////// CONSTRUCTOR ////////////
        public Siguiendo(DateTime fechaFin, DateTime fechaInicio, List<Bodega> bodega, List<Enofilo> enofilo)
        {
            fechaFin = DateTime.Now;
            fechaInicio = DateTime.Now;
            bodega = new List<Bodega>();
            enofilo = new List<Enofilo>();
        }

        //////////// SETS Y GETS ////////////
        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public List<Bodega> Bodega
        {
            get { return bodega; }
            set { bodega = value; }
        }

        public List<Enofilo> Enofilo
        {
            get { return enofilo; }
            set { enofilo = value; }
        }

        //////////// SETS Y GETS ////////////

        //////////// TERMINAN SETS Y GETS ////////////

        //////////// MÉTODOS ////////////
    }
}
