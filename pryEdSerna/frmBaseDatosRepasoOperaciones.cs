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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos BD = new clsBaseDatos();

        private void frmBaseDatosRepasoOperaciones_Load(object sender, EventArgs e)
        {
            cmbTabla.Items.Add("Proyección Simple");
            cmbTabla.Items.Add("Proyección Multiatributo");
            cmbTabla.Items.Add("Juntar");
            cmbTabla.Items.Add("Selección Simple");
            cmbTabla.Items.Add("Selección Multiatributo");
            cmbTabla.Items.Add("Selección por convolución");

            cmbTabla.Items.Add("Unión");
            cmbTabla.Items.Add("Intersección");
            cmbTabla.Items.Add("Diferencia");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            string operacion = cmbTabla.SelectedItem.ToString();
            string varSQL = "";

            if (operacion == "Proyección Simple")
            {
              //  txtOperacion.Text = "Proyección simple: mostrar todos los campos del libro";
                //varSQL = "SELECT * FROM LIBRO";
                varSQL = "SELECT *" +
                "FROM LIBRO";
            }
            else if (operacion == "Proyección Multiatributo")
            {
                //txtOperacion.Text = "Proyección multiatributo: mostrar Título e IdIdioma";
                //varSQL = "SELECT Titulo, IdIdioma FROM LIBRO";
                varSQL = "SELECT Titulo, IdIdioma FROM LIBRO";
            }
            else if (operacion == "Juntar")
            {
               // txtOperacion.Text = "Juntar: Título del libro y Nombre del autor";
               // varSQL = "SELECT Libro.Titulo, Autor.Nombre " +
                 //        "FROM Libro " +
                   //      "INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
                varSQL = "SELECT Libro.Titulo, Autor.Nombre " +
                "FROM Libro " +
                "INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
            }
            else if (operacion == "Selección Simple")
            {
                // txtOperacion.Text = "Selección simple: mostrar libros con Precio > 800";
                //varSQL = "SELECT * FROM LIBRO WHERE Precio > 800";
                varSQL = "SELECT * " +
                "FROM LIBRO " +
                "WHERE Precio > 800";
            }
            else if (operacion == "Selección Multiatributo")
            {
                // txtOperacion.Text = "Selección multiatributo: Precio > 700 y IdIdioma > 10";
                //varSQL = "SELECT * FROM LIBRO WHERE Precio > 700 AND IdIdioma > 10";
                varSQL = "SELECT* FROM LIBRO WHERE Precio > 700 AND IdIdioma > 10";
            }
            else if (operacion == "Selección por Convolución")
            {
                // txtOperacion.Text = "Convolución: primero IdIdioma > 5 y luego IdAutor > 10";
                //varSQL = "SELECT * FROM (SELECT * FROM Libro WHERE IdIdioma > 5) WHERE IdAutor > 10";
                varSQL = "SELECT* FROM(SELECT* FROM Libro WHERE IdIdioma > 5) WHERE IdAutor > 10";
            }
            else if (operacion == "Unión")
            {
                //txtOperacion.Text = "Unión: libros con IdAutor = 2 o IdAutor = 3";
                //varSQL = "SELECT * FROM LIBRO WHERE IDAUTOR = 2 " +
                //       "UNION " +
                //     "SELECT * FROM LIBRO WHERE IDAUTOR = 3";
                varSQL =
                   "SELECT * " +
                 "FROM LIBRO " +
       "WHERE IDAUTOR = 2 " +
       "UNION " +
       "SELECT * FROM LIBRO WHERE IDAUTOR = 3";
            }
            else if (operacion == "Intersección")
            {
                txtOperacion.Text = "Intersección: libros con IdAutor > 8 y IdIdioma > 4";
                varSQL = "SELECT * FROM Libro WHERE IdAutor > 8 AND IdIdioma > 4";
            }
            else if (operacion == "Diferencia")
            {
                txtOperacion.Text = "Diferencia: libros con IdIdioma no menor a 5";
                varSQL = "SELECT * FROM Libro WHERE IdIdioma NOT IN " +
                         "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            }
            else
            {
                txtOperacion.Text = "Operación no reconocida.";
                dgvConsulta.DataSource = null;
                return;
            }

            BD.Listar(dgvConsulta, varSQL);
        }

    }
    
}

