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
        public void Recorrer(DataGridView Grilla)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            String Dato = "";
            Dato = AD.ReadLine();
            Grilla.Rows.Clear();
            while (Dato != null)
            {
                Grilla.Rows.Add(Dato.Split(';'));
                Dato = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer(ComboBox cmb)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            String Dato = "";
            Dato = AD.ReadLine();
            cmb.Items.Clear();

            while (Dato != null)
            {
                cmb.Items.Add(Dato);
                Dato = AD.ReadLine();


            }
            AD.Close();

        }
    }
}