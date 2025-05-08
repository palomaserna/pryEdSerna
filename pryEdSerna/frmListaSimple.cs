using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            if (File.Exists("ListaSimple.csv"))
            {
                Lista.Agregar();
                Lista.Recorrer();
                Lista.Recorrer(dgvListaSimple);
                Lista.Recorrer(lstListaSimple);
                Lista.Recorrer(cmbCodigo);
            }
           
           
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
            btnAgregar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.Text != "")
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                Lista.Eliminar(x);
                Lista.Recorrer();
                Lista.Recorrer(dgvListaSimple);
                Lista.Recorrer(lstListaSimple);
                Lista.Recorrer(cmbCodigo);
            }
            else
            {
                MessageBox.Show("Error");
                
            }
        }

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

      
       

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {


            if(cmbCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled=false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
