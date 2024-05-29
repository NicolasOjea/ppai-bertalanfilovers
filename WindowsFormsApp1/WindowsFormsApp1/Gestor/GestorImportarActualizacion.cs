using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ENTIDAD;

namespace WindowsFormsApp1.Gestor
{
    public class GestorImportarActualizacion
    {
        //////////// ATRIBUTOS ////////////
        private List<Bodega> bodegaList = new List<Bodega>();
        public GestorImportarActualizacion(List<Bodega> bodegas)
        {
            //////////// CONSTRUCTOR ////////////
            this.bodegaList = bodegas;
        }

        public void opcionImportarActualizacion()
        {
            this.buscarBodegasParaActualizar();
        }

        public List<string> buscarBodegasParaActualizar()
        {
            List<string> bodegasEncontradas = new List<string>();

            foreach (Bodega bodega in bodegaList)
            {
                bodegasEncontradas.Add(bodega.estaParaActualizar());
            }
            return bodegasEncontradas;
        }
        //////////// MÉTODOS ////////////
    }
}
