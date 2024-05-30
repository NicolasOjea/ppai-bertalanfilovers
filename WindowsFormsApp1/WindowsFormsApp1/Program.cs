using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ENTIDAD;
using WindowsFormsApp1.Gestor;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine($"Bodega encontrada:");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaInicio());
        }

        public static GestorImportarActualizacion setGestor()
        {
            GestorImportarActualizacion gestor = new GestorImportarActualizacion(crearListabodegas(), crearListaVinos());
            return gestor;
        }
        public static List<Bodega> crearListabodegas()
        {
            List<Bodega> bodegas = init.crearListabodegas();
            return bodegas;
        }
        public static List<Vino> crearListaVinos()
        {
            List<Vino> vinos = init.crearListaVinos();
            foreach(var bodega in vinos)
            {
                Console.WriteLine(bodega.getNombre(),bodega);
            }
            return vinos;
        }
        // Crear 5 bodegas con datos de ejemplo


    }
}
