using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ENTIDAD
{

    public class Vino
    {
        //////////// ATRIBUTOS ////////////
        private int añada;
        private int imagenEtiqueta;
        private string nombre;
        private string notaDeCataBodega;
        private float precioARS;
        private List<Maridaje> maridaje;
        private List<Varietal> varietal;

        //////////// CONSTRUCTOR ////////////
        public Vino(string nombre, string notaDeCataBodega, int añada, int imagenEtiqueta, float precioARS, List<Maridaje> maridaje, List<Varietal> varietal)
        {
            this.añada = añada;
            this.imagenEtiqueta = 0;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.maridaje = new List<Maridaje>();
            this.varietal = new List<Varietal>();
        }

        //////////// SETS Y GETS ////////////
        public int Añada
        {
            get { return añada; }
            set { añada = value; }
        }

        public int ImagenEtiqueta
        {
            get { return imagenEtiqueta; }
            set { imagenEtiqueta = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NotaDeCataBodega
        {
            get { return notaDeCataBodega; }
            set { notaDeCataBodega = value; }
        }

        public float PrecioARS
        {
            get { return precioARS; }
            set { precioARS = value; }
        }

        public List<Maridaje> Maridaje
        {
            get { return maridaje; }
            set { maridaje = value; }
        }

        public List<Varietal> Varietal
        {
            get { return varietal; }
            set { varietal = value; }
        }
        public string getNombre()
        {
            return this.nombre;
        }

        //////////// TERMINAN SETS Y GETS ////////////

        //////////// MÉTODOS ////////////
    }
}
