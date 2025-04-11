using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdSerna
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;

            }
            else
            {
                if(nuevo.Codigo < Primero.Codigo)
                {
                    Primero.Anterior = nuevo;
                    nuevo.Siguiente = Primero;
                    Primero = nuevo;
                }
                else
                {
                    if(nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = nuevo;
                        nuevo.Anterior = Ultimo;
                        Ultimo= nuevo;
                    }
                    else
                    {
                        clsNodo ant = Primero;
                        clsNodo aux = Primero;
                        while(aux.Codigo < nuevo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;

                        }
                        nuevo.Anterior= ant;
                        nuevo.Siguiente= aux;
                        aux.Anterior = nuevo;
                        ant.Siguiente = nuevo;

                    }
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if(Primero.Codigo==Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if(Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while(aux.Codigo != Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        aux = aux.Siguiente;
                        ant.Siguiente = aux;
                        aux.Anterior = ant;
                    }
                }
            }
        }


        public void RecorrerAs(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while(aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux= aux.Siguiente;
            }
        }
        public void RecorrerDs(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                //Combo.Items.Add(aux.Nombre);
                Combo.Items.Add(aux.Codigo.ToString());
                aux = aux.Siguiente;
            }
        }


        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}
