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
    public partial class frmBaseDatosMostrarTabla : Form
    {
        public frmBaseDatosMostrarTabla()
        {
            InitializeComponent();

        }
        clsBaseDatos Bd = new clsBaseDatos();
        private void frmBaseDatosMostrarTabla_Load(object sender, EventArgs e)
        {
            //cmbTabla.SelectedIndex = 0;
            Bd.Listar(dgvBase);
          
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
          
            Bd.Listar(cmbTabla.Text, dgvBase);
           
        }
        
        

        
    }
}
