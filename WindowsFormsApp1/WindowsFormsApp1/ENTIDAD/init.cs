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
                bodegas.Add(new Bodega("Bodega Central", "Historia rica", "Descripción detallada", 1, new List<float> { 40.7128f, -74.0060f }, DateTime.Now.AddMonths(-1)));
                bodegas.Add(new Bodega("Bodega Sur", "Historia del sur", "Descripción del sur", 2, new List<float> { 34.0522f, -118.2437f }, DateTime.Now.AddMonths(-3)));
                bodegas.Add(new Bodega("Bodega Norte", "Historia del norte", "Descripción del norte", 3, new List<float> { 41.8781f, -87.6298f }, DateTime.Now.AddMonths(-2)));
                bodegas.Add(new Bodega("Bodega Este", "Historia del este", "Descripción del este", 4, new List<float> { 40.7306f, -73.9352f }, DateTime.Now.AddMonths(-3)));
                bodegas.Add(new Bodega("Bodega Oeste", "Historia del oeste", "Descripción del oeste", 1, new List<float> { 34.0522f, -118.2437f }, DateTime.Now.AddMonths(-2)));
            };
            return bodegas;

        }
        public static List<Vino> crearListaVinos() {
            List<Vino> vinos = new List<Vino>();

            List<Maridaje> maridajes = new List<Maridaje>();
            
            maridajes.Add(new Maridaje("Maridaje 1", "Quesos fuertes y curados"));
            maridajes.Add(new Maridaje("Maridaje 2", "Carnes rojas y asadas"));
            maridajes.Add(new Maridaje("Maridaje 3", "Pescados grasos y mariscos"));
            maridajes.Add(new Maridaje("Maridaje 4", "Pastas con salsas de tomate"));
            maridajes.Add(new Maridaje("Maridaje 5", "Postres de chocolate y frutos rojos"));

            List<Maridaje> maridajesVino1 = new List<Maridaje>();
            maridajesVino1.Add(maridajes[1]);
            maridajesVino1.Add(maridajes[3]);
            maridajesVino1.Add(maridajes[2]);

            List<Maridaje> maridajesVino3 = new List<Maridaje>();
            maridajesVino3.Add(maridajes[2]);
            maridajesVino3.Add(maridajes[3]);

            List<Maridaje> maridajesVino2 = new List<Maridaje>();
            maridajesVino2.Add(maridajes[1]);
            maridajesVino2.Add(maridajes[0]);
            maridajesVino2.Add(maridajes[4]);

            List<Varietal> varietales1 = new List<Varietal>();
            varietales1.Add(crearListaVarietal()[2]);
            varietales1.Add(crearListaVarietal()[7]);

            List<Varietal> varietales2 = new List<Varietal>();
            varietales2.Add(crearListaVarietal()[1]);
            varietales2.Add(crearListaVarietal()[6]);

            List<Varietal> varietales3 = new List<Varietal>();
            varietales3.Add(crearListaVarietal()[0]);
            varietales3.Add(crearListaVarietal()[5]);


            foreach (var bodega in crearListabodegas())
            { 
                    vinos.Add(new Vino($"Vino 1 de {bodega.getNombre()}", "Nota de Cata 1", 2020, 1, 500.0f, maridajesVino2, varietales1));
                    vinos.Add(new Vino($"Vino 2 de {bodega.getNombre()}", "Nota de Cata 2", 2021, 2, 600.0f, maridajesVino2, varietales1));
                    vinos.Add(new Vino($"Vino 3 de {bodega.getNombre()}", "Nota de Cata 3", 2022, 3, 700.0f, maridajesVino3, varietales2));
                    vinos.Add(new Vino($"Vino 4 de {bodega.getNombre()}", "Nota de Cata 4", 2023, 4, 800.0f, maridajesVino1, varietales3));
                    vinos.Add(new Vino($"Vino 5 de {bodega.getNombre()}", "Nota de Cata 5", 2024, 5, 900.0f, maridajesVino1, varietales3));
                
            }
            return vinos;
    }
        public static List<TipoUva> crearListaTipoUva()
        {
            List<TipoUva> tiposUva = new List<TipoUva>();
            tiposUva.Add(new TipoUva("Cabernet Sauvignon", "Uva con alta concentración de taninos"));
            tiposUva.Add(new TipoUva("Merlot", "Uva con cuerpo medio y sabores afrutados"));
            tiposUva.Add(new TipoUva("Malbec", "Uva con cuerpo completo y sabores especiados"));
            return tiposUva;
        }

        // Inicialización de Varietales
        public static List<Varietal> crearListaVarietal() {
            List<Varietal> varietales = new List<Varietal>();
            varietales.Add(new Varietal("Varietal 1", 50.0f, crearListaTipoUva()[0]));
            varietales.Add(new Varietal("Varietal 2", 30.0f, crearListaTipoUva()[1]));
            varietales.Add(new Varietal("Varietal 3", 20.0f, crearListaTipoUva()[2]));
            varietales.Add(new Varietal("Varietal 4", 70.0f, crearListaTipoUva()[0]));
            varietales.Add(new Varietal("Varietal 5", 60.0f, crearListaTipoUva()[1]));
            varietales.Add(new Varietal("Varietal 1", 50.0f, crearListaTipoUva()[1]));
            varietales.Add(new Varietal("Varietal 2", 70.0f, crearListaTipoUva()[2]));
            varietales.Add(new Varietal("Varietal 3", 80.0f, crearListaTipoUva()[1]));
            varietales.Add(new Varietal("Varietal 4", 30.0f, crearListaTipoUva()[2]));
            varietales.Add(new Varietal("Varietal 5", 30.0f, crearListaTipoUva()[2]));
            return varietales;
                }


        // Inicialización de Maridajes
    }
}
