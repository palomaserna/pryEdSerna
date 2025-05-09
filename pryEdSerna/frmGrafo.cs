using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdSerna
{
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }
        clsGrafo Grafo = new clsGrafo();

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            Grafo.CargarCiudades(cmbOrigenCarga);
            Grafo.CargarCiudades(cmbOrigenConsulta);
            Grafo.CargarCiudades(cmbOrigenListar);
            Grafo.CargarCiudades(cmbDestinoCarga);
            Grafo.CargarCiudades(cmbDestinoConsulta);
            Grafo.CargarCiudades(cmbDestinoListar);
            Grafo.MostrarTodo(dgvGrafo);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 x=cmbOrigenCarga.SelectedIndex;
            Int32 y=cmbDestinoCarga.SelectedIndex;
            Decimal p=Convert.ToDecimal(txtPrecio.Text);
            Grafo.Agregar(x, y, p);
            Grafo.MostrarTodo(dgvGrafo);
            MessageBox.Show("Precio Cargado!!");
            txtPrecio.Text = "";
            cmbOrigenCarga.SelectedIndex = 0;
            cmbDestinoCarga.SelectedIndex = 0;
        }
    }
}
