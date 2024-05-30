using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ENTIDAD;
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
            Console.WriteLine($"Bodega seleccionada1");
            this.gestor = gestor;
        }

        public void opcionImportarActualizacion(GestorImportarActualizacion gestor)
        {
            this.Show();
            this.habilitarPantalla(gestor);
        }

        public void habilitarPantalla(GestorImportarActualizacion gestor)
        {
            gestor.opcionImportarActualizacion(this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void mostrarBodegasParaActualizar(List<string> bodegasEncontradas)
        {
            // Mostrar bodegas encontradas en ListBox
            foreach (string nombreBodega in bodegasEncontradas)
            {
                if(nombreBodega != "")
                {
                    lstBodegas.Items.Add(nombreBodega);
                }
            }
            solicitarSeleccion();
        }
        public void solicitarSeleccion()
        {
            lblSeleccionarBodega.Visible = true;
        }

        private void lstBodegas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreBodegaSeleccionada = "";
            if (lstBodegas.SelectedIndex != -1)
            {
                nombreBodegaSeleccionada = lstBodegas.SelectedItem.ToString();
            }
            tomarSeleccionBodega(nombreBodegaSeleccionada);
        }
        public void tomarSeleccionBodega(string nombreBodega)
        {
            lblSeleccionarBodega.Text = nombreBodega;
            gestor.tomarSeleccionBodega(nombreBodega);
        }
    }
}
