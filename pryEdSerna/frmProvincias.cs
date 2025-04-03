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
using System.IO;

namespace pryEdSerna
{
    public partial class frmProvincias : Form
    {
        public frmProvincias()
        {
            InitializeComponent();
        }
        ClsArchivo x=new ClsArchivo();

        private void frmProvincias_Load(object sender, EventArgs e)
        {
            ControlarTxt();
            txtCodigo.Select();
            x.NombreArchivo = "Provincias.txt";
            if (File.Exists(x.NombreArchivo)) x.Recorrer(dgvProvincias);
            //x.Recorrer(dgvProvincias);
        }

        private void btnGrabarP_Click(object sender, EventArgs e)
        {
            String Datos = "";
            Datos=txtCodigo.Text + ";" + txtProvincias.Text;    
            x.Grabar(Datos);
            x.Recorrer(dgvProvincias);
            MessageBox.Show("Dato grabado exitosamente...", "Proceso Exitoso");
            txtProvincias.Text = "";
            txtCodigo.Text = "";
            txtCodigo.Select();
        }

        private void txtProvincias_TextChanged(object sender, EventArgs e)
        {
            ControlarTxt();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ControlarTxt();
        }
        private void ControlarTxt()
        {
            if(txtCodigo.Text != "" && txtProvincias.Text != "")
            {
                btnGrabarP.Enabled = true;
            }
            else
            {
                btnGrabarP.Enabled = false;
            }
        }
    }
}
