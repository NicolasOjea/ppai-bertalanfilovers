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
        private Bodega bodega;
        
        public GestorImportarActualizacion()
        {
            //////////// CONSTRUCTOR ////////////
        }

        public void opcionImportarActualizacion()
        {
            this.buscarBodegasParaActualizar();
        }

        public void buscarBodegasParaActualizar()
        {
            bodega.estaParaActualizar();
        }
        //////////// MÉTODOS ////////////
    }
}
