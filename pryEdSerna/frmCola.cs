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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola FilaPersonas=new clsCola();

        private void frmCola_Load(object sender, EventArgs e)
        {
            if (File.Exists("Cola.csv"))
            {
                FilaPersonas.Agregar();
                FilaPersonas.Recorrer();//Grabo archivo
                FilaPersonas.Recorrer(dgvCola);//Muestro en grilla
                FilaPersonas.Recorrer(lstCola);//Muestra en lista

            }
           
           

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona= new clsNodo();
            Persona.Codigo=Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre=txtNombre.Text;
            Persona.Tramite=txtTramite.Text;

            FilaPersonas.Agregar(Persona);

            FilaPersonas.Recorrer();//Grabo archivo
            FilaPersonas.Recorrer(dgvCola);//Muestro en grilla
            FilaPersonas.Recorrer(lstCola);//Muestra en lista

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaPersonas.Primero != null) 
            {
                lblCod.Text = FilaPersonas.Primero.Codigo.ToString();
                lblNom.Text = FilaPersonas.Primero.Nombre;
                lblTra.Text = FilaPersonas.Primero.Tramite;

                FilaPersonas.Eliminar();

                FilaPersonas.Recorrer();//Grabo archivo
                FilaPersonas.Recorrer(dgvCola);//Muestro en grilla
                FilaPersonas.Recorrer(lstCola);//Muestra en lista
            }
            else
            {
                lblCod.Text = "";
                lblNom.Text = "";
                lblTra.Text = "";

            }
            
        }
        private void ValidarDatosA()
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
            ValidarDatosA();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatosA();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatosA();
        }

      
    }
}
