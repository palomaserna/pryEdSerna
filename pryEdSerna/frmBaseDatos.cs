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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos BaseDatos=new clsBaseDatos();
        private void btnProySimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT *" +
            "FROM LIBRO" +
            "WHERE IDLIBRO > 10";

            BaseDatos.Listar(dgvBaseDatos, varSQL);

        }

        private void btnProyMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO" +
            "FROM LIBRO" +
            "ORDER BY TITULO ASC";

            BaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
          /*  String varSQL = "SELECT *" +
            "FROM LIBRO" +
            "WHERE IDAUTOR=2" +
            "UNION" +
             "WHERE IDAUTOR=5" +
            "UNION" +


           */// BaseDatos.Listar(dgvBaseDatos, varSQL);
        }
    }
}
