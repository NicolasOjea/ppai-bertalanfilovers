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
            this.descripcion = descripcion;
            this.porcentajeComposicion = porcentajeComposicion;
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

        public string getDescripcion()
        {
            return this.descripcion;
        }
        public float getPorcentajeComposicion()
        {
            return this.porcentajeComposicion;
        }

        public string getTipoUva()
        {
            return tipoUva.getNombre();
        }
        //////////// TERMINAN SETS Y GETS ////////////

        //////////// MÉTODOS ////////////

    }
}
