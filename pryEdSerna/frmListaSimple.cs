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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Lista= new clsListaSimple();

        private void ValidarDatos()
        {
            if(txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            Lista.Agregar(Persona);

            Lista.Recorrer();
            Lista.Recorrer(dgvListaSimple);
            Lista.Recorrer(lstListaSimple);
            Lista.Recorrer(cmbCodigo);


            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            btnAgregar.Enabled=false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          if(Lista.Primero != null)
          {
                Int32 x = Convert.ToInt32(cmbCodigo);
                Lista.Eliminar(x);
                Lista.Recorrer();
                Lista.Recorrer(dgvListaSimple);
                Lista.Recorrer(lstListaSimple);
                Lista.Recorrer(cmbCodigo);
            }
          else
          {
                MessageBox.Show("Eliminado");
               // btnEliminar.Enabled = false;
          }
        }
       
        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {


            if(cmbCodigo.SelectedIndex != -1)
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled=true;
            }
        }
    }
}
