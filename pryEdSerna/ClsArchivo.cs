using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace pryEdSerna
{
    public class ClsArchivo
    {

        public String NombreArchivo = "";

        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo,true);
            AD.WriteLine("Hola");
            AD.Close();
        }
        public void Grabar(String Dato)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo,true);
            AD.WriteLine(Dato);
            AD.Close();
        }
        public void Recorrer(ListBox lista)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            String Dato = "";
            Dato = AD.ReadLine();
            lista.Items.Clear();
            while (Dato != null)
            {
                lista.Items.Add(Dato);
                Dato = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer(DataGridView lista)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            string Dato = "";
            Dato = AD.ReadLine();
            lista.Rows.Clear();
            while (Dato != null)
            {
                lista.Rows.Add(Dato);
                Dato = AD.ReadLine();
            }
            AD.Close();
        }
    }
}