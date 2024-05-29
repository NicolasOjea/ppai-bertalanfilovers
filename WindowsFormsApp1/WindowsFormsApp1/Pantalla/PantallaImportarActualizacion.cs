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
        public PantallaImportarActualizacion()
        {
            InitializeComponent();
        }

        public void opcionImportarActualizacion()
        {
            this.Show();
            this.habilitarPantalla();
        }

        public void habilitarPantalla()
        {
            gestor.opcionImportarActualizacion();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
