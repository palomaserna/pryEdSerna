using System;
using System.Collections;
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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble ListaDoble=new clsListaDoble();
        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            if (File.Exists("ListaDoble.csv"))
            {
                ListaDoble.Agregar();
                Opts();

            }
           
           

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ListaDoble.Agregar(Persona);
            Opts();


            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            btnAgregar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmbCodigo.Text;
            ListaDoble.Eliminar(x);

            Opts();
           
        }

       
        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
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
            if (cmbCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }
        public void Opts()
        {
            if(optAscendete.Checked)
            {
                ListaDoble.RecorrerAs(dgvLDoble);
                ListaDoble.RecorrerAs(dgvLDoble);
                ListaDoble.Recorrer();
                ListaDoble.Recorrer(lstLDoble);
                ListaDoble.Recorrer(cmbCodigo);
            }
            else 
            {
                ListaDoble.RecorrerDs(dgvLDoble);
                ListaDoble.RecorrerD();
                ListaDoble.RecorrerDs(dgvLDoble);
                ListaDoble.RecorrerD(cmbCodigo);
                ListaDoble.RecorrerD(lstLDoble);
            }
        }
        
       
    }
}
