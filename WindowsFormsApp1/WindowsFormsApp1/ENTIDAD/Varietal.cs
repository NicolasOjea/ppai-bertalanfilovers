using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ENTIDAD
{
    public class Varietal
    {
        //////////// ATRIBUTOS ////////////
        private string descripcion;
        private float porcentajeComposicion;
        private TipoUva tipoUva;

        //////////// CONSTRUCTOR ////////////
        public Varietal(string descripcion, float porcentajeComposicion, TipoUva tipoUva)
        {
            descripcion = string.Empty;
            porcentajeComposicion = 0.0f;
            this.tipoUva = tipoUva;
        }

        //////////// SETS Y GETS ////////////
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public float PorcentajeComposicion
        {
            get { return porcentajeComposicion; }
            set { porcentajeComposicion = value; }
        }

        public TipoUva TipoUva
        {
            get { return tipoUva; }
            set { tipoUva = value; }
        }

        //////////// TERMINAN SETS Y GETS ////////////

        //////////// MÉTODOS ////////////

    }
}
