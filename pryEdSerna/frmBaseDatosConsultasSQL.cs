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
    public partial class frmBaseDatosConsultasSQL : Form
    {
        public frmBaseDatosConsultasSQL()
        {
            InitializeComponent();
        }

        private void frmBaseDatosConsultasSQL_Load(object sender, EventArgs e)
        {
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos BaseDatos = new clsBaseDatos();
            BaseDatos.Listar(dgvConsulta, txtConsulta.Text);
        }
    }
}
