using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ENTIDAD;

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
            
            
        
        
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaInicio());
        }
        public static List<Bodega> bodegas()
        {
            List<Bodega> bodegas = new List<Bodega>();
     
            bodegas.Add(new Bodega("Bodega Central", "Historia rica", "Descripción detallada", 1, new List<float> { 40.7128f, -74.0060f }));
            bodegas.Add(new Bodega("Bodega Sur", "Historia del sur", "Descripción del sur", 2, new List<float> { 34.0522f, -118.2437f }));
            bodegas.Add(new Bodega("Bodega Norte", "Historia del norte", "Descripción del norte", 3, new List<float> { 41.8781f, -87.6298f }));
            bodegas.Add(new Bodega("Bodega Este", "Historia del este", "Descripción del este", 4, new List<float> { 40.7306f, -73.9352f }));
            bodegas.Add(new Bodega("Bodega Oeste", "Historia del oeste", "Descripción del oeste", 5, new List<float> { 34.0522f, -118.2437f }));

            return bodegas;
        
        }
            // Crear 5 bodegas con datos de ejemplo
            
        
    }
}
