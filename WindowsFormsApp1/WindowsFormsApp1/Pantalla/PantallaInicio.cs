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
using WindowsFormsApp1.Pantalla;

namespace WindowsFormsApp1
{
    public partial class PantallaInicio : Form
    {
        //////////// ATRIBUTOS ////////////

        public PantallaInicio()
        {
            InitializeComponent();
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario secundario
            Pantalla.PantallaImportarActualizacion form2 = new Pantalla.PantallaImportarActualizacion(Program.setGestor());
            // Mostrar el formulario secundario
            form2.opcionImportarActualizacion(Program.setGestor());
            // Cerrar el formulario principal
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
