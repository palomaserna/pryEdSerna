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
            "FROM LIBRO";
            BaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnProyMultiatributo_Click(object sender, EventArgs e)
        {
           
            String varSQL = "SELECT Titulo, IdIdioma FROM LIBRO";
            BaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT Libro.Titulo, Autor.Nombre " +
            "FROM Libro " +
            "INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
            BaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSelecSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                "FROM LIBRO " +
                "WHERE Precio > 800";
            BaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSelecMultiatributo_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT* FROM LIBRO WHERE Precio > 700 AND IdIdioma > 10";
            BaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnConvolucion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT* FROM(SELECT* FROM Libro WHERE IdIdioma > 5) WHERE IdAutor > 10";
            BaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
           

            String varSQL =
          "SELECT * " +
          "FROM LIBRO " +
          "WHERE IDAUTOR = 2 " +
          "UNION " +
          "SELECT * FROM LIBRO WHERE IDAUTOR = 3";


            BaseDatos.Listar(dgvBaseDatos, varSQL);
          
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL =
          "SELECT * FROM Libro " +
         "WHERE IdAutor > 8 AND IdIdioma > 4";
          
            BaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL =
           "SELECT* FROM Libro WHERE IdIdioma" +
           " NOT IN" +
           "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
             BaseDatos.Listar(dgvBaseDatos, varSQL);

        }

        private void frmBaseDatosOperaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
