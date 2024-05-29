using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Gestor;

namespace WindowsFormsApp1.Pantalla
{
    public partial class PantallaImportarActualizacion : Form
    {

        //////////// ATRIBUTOS ////////////
        private GestorImportarActualizacion gestor = null;
        public PantallaImportarActualizacion(GestorImportarActualizacion gestor)
        {
            InitializeComponent();
            this.gestor = gestor;

            MostrarBodegasEncontradas();
        }

        public void opcionImportarActualizacion(GestorImportarActualizacion gestor)
        {
            this.Show();
            this.habilitarPantalla(gestor);
        }

        public void habilitarPantalla(GestorImportarActualizacion gestor)
        {
            gestor.opcionImportarActualizacion();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void MostrarBodegasEncontradas()
        {
            List<string> bodegasEncontradas = gestor.buscarBodegasParaActualizar();

            // Mostrar bodegas encontradas en ListBox
            foreach (string nombreBodega in bodegasEncontradas)
            {
                lstBodegas.Items.Add(nombreBodega);
            }
        }
        private void lstBodegas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBodegas.SelectedIndex != -1)
            {
                string nombreBodegaSeleccionada = lstBodegas.SelectedItem.ToString();
                // Aquí puedes hacer lo que necesites con la bodega seleccionada
                Console.WriteLine($"Bodega seleccionada: {nombreBodegaSeleccionada}");
            }
        }
    }
}
