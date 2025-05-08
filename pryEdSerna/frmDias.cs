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
    public partial class frmDias : Form
    {
        public frmDias()
        {
            InitializeComponent();
        }
        ClsArchivo x = new ClsArchivo();
        private void frmDias_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "Días.csv";
            if (File.Exists(x.NombreArchivo)) x.Recorrer(dgvDia);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtDiaSemana.Text == "" && numDia.Value > 31 && numDia.Value < 1)
            {
                MessageBox.Show("Datos incorrectos");
            }
            else
            {
                string Dato = numDia.Value.ToString() + ";" + txtDiaSemana.Text;
                x.Grabar(Dato);
                x.Recorrer(dgvDia);

                MessageBox.Show("Datos cargados exitosamente...", "Proceso exitoso");

                txtDiaSemana.Text = "";

                numDia.Value = numDia.Value + 1;
            }
        }
    }
}
