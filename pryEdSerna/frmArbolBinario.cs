using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdSerna
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario Arbol=new clsArbolBinario();

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo aux= new clsNodo();
            aux.Codigo=Convert.ToInt32(txtCodigo.Text);
            aux.Nombre=txtNombre.Text;
            aux.Tramite=txtTramite.Text;
            Arbol.Agregar(aux);
           

            Arbol.Recorrer(cmbCodigo);
            Arbol.Recorrer(dgvArbol);
            Arbol.Recorrer(tvArbol);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();

        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
           
            Arbol.Recorrer(tvArbol);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Arbol.Eliminar(Convert.ToInt32(cmbCodigo.Text));
            cmbCodigo.SelectedIndex = -1;
            if (Arbol.Raiz != null)
            {
                Arbol.Recorrer(tvArbol);
                Arbol.Recorrer(cmbCodigo);
                Arbol.Recorrer(dgvArbol);
            }
            else
            {
                tvArbol.Nodes.Clear();
                dgvArbol.Rows.Clear();
                cmbCodigo.Items.Clear();
            }
            
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

        private void optInO_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.Recorrer(dgvArbol);
           
        }

        private void optPreO_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPre(dgvArbol);
           
        }
        private void optPostO_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPost(dgvArbol);
            
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

      
      
    }
}
