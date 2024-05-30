using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ENTIDAD;
using WindowsFormsApp1.Pantalla;

namespace WindowsFormsApp1.Gestor
{
    public class GestorImportarActualizacion
    {
        //////////// ATRIBUTOS ////////////
        private List<Bodega> bodegaList = new List<Bodega>();
        private PantallaImportarActualizacion pantalla = null;
        public GestorImportarActualizacion(List<Bodega> bodegas, List<Vino> vinos)
        {
            //////////// CONSTRUCTOR ////////////
            this.bodegaList = bodegas;
        }

        //////////// MÉTODOS ////////////
        public void setPantalla(PantallaImportarActualizacion pantalla)  // Relaciona al gestor con la pantalla
        {
            this.pantalla = pantalla;
        }
        public void opcionImportarActualizacion(PantallaImportarActualizacion pantalla)
        {
            setPantalla(pantalla);
            buscarBodegasParaActualizar();
        }

        public void buscarBodegasParaActualizar()
        {
            List<string> bodegasEncontradas = new List<string>();
            foreach (Bodega bodega in bodegaList)
            {
                bodegasEncontradas.Add(bodega.estaParaActualizar());
            }
            pantalla.mostrarBodegasParaActualizar(bodegasEncontradas);
        }

        public void tomarSeleccionBodega(string seleccionBodega)
        {
            obtenerActualizacionDeVinosBodegas();
        }

        public void obtenerActualizacionDeVinosBodegas()
        {
            obtenerActualizacionDeVinosBodegas();

        }

        public void actualizarDatosDeVinoBodega()
        {

        }

        public void actualizarFechaActualizacion()
        {
        }

        public void buscarMaridaje()
        {
        }

        public void buscarTipoUva()
        {
        }

        public void crearVinos()
        {
        }

        public void enviarNotificaciones()
        {
        }
    }
}
