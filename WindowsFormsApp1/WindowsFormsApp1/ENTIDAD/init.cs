using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ENTIDAD
{
    internal class init
    {   
        public static List<Bodega> crearListabodegas()
        {
            List<Bodega> bodegas = new List<Bodega>();
            {
                bodegas.Add(new Bodega("Bodega Central", "Historia rica", "Descripción detallada", 1, new List<float> { 40.7128f, -74.0060f }));
                bodegas.Add(new Bodega("Bodega Sur", "Historia del sur", "Descripción del sur", 2, new List<float> { 34.0522f, -118.2437f }));
                bodegas.Add(new Bodega("Bodega Norte", "Historia del norte", "Descripción del norte", 3, new List<float> { 41.8781f, -87.6298f }));
                bodegas.Add(new Bodega("Bodega Este", "Historia del este", "Descripción del este", 4, new List<float> { 40.7306f, -73.9352f }));
                bodegas.Add(new Bodega("Bodega Oeste", "Historia del oeste", "Descripción del oeste", 5, new List<float> { 34.0522f, -118.2437f }));
            };
            return bodegas;

        }

    }
}
