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

        private void btnBorrarCarga_Click(object sender, EventArgs e)
        {
            Grafo.BorrarTodo();
            Grafo.MostrarTodo(dgvGrafo);
            MessageBox.Show("Datos eliminados");
            txtPrecio.Text = "";
            cmbOrigenCarga.SelectedIndex = 0;
            cmbDestinoCarga.SelectedIndex = 0;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int f=cmbOrigenConsulta.SelectedIndex;
            int c=cmbDestinoConsulta.SelectedIndex;
            decimal precio= Grafo.Consultar(f, c);
            MessageBox.Show($"El precio de {cmbOrigenConsulta.Text} a {cmbDestinoConsulta.Text} es de {precio}");
            txtPrecio.Text = "";
            cmbOrigenCarga.SelectedIndex = 0;
            cmbDestinoCarga.SelectedIndex = 0;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int f = cmbOrigenConsulta.SelectedIndex;
            int c = cmbDestinoConsulta.SelectedIndex;
            Grafo.Eliminar(f, c);
            MessageBox.Show($"Se elimino el viaje de {cmbOrigenConsulta.Text} a {cmbDestinoConsulta.Text}");
            txtPrecio.Text = "";
            cmbOrigenCarga.SelectedIndex = 0;
            cmbDestinoCarga.SelectedIndex = 0;
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            int f=cmbOrigenListar.SelectedIndex;
            Grafo.MostrarDestinos(f, dgvGrafo);
        }

        private void btnOrigenes_Click(object sender, EventArgs e)
        {
            int c=cmbDestinoListar.SelectedIndex;
            Grafo.MostrarOrigenes(c, dgvGrafo);
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            Grafo.MostrarTodo(dgvGrafo);
        }
    }
}
