﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdSerna
{
    internal class clsListaSimple
    {
        private clsNodo pri;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if(Nuevo.Codigo<=Primero.Codigo)
                {
                    Nuevo.Siguiente= Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while(aux!= null && Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                    }
                    ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }

            }
            
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo ant= Primero;
                clsNodo aux = Primero;
                while(aux.Codigo != Codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                ant.Siguiente = aux.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
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
            StreamWriter AD = new StreamWriter("ListaSimple.csv", false, Encoding.UTF8);
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
        public void Agregar()
        {
            StreamReader AD = new StreamReader("ListaSimple.csv");
            string dato = "";
            dato = AD.ReadLine(); //Titulo
            dato = AD.ReadLine(); //Renglon vacio
            dato = AD.ReadLine(); //Titulos de columna
            dato = AD.ReadLine(); //Primera fila con datos

            while (dato != null)
            {
                clsNodo Persona = new clsNodo();
                string[] datos = dato.Split(';');

                Persona.Codigo = Convert.ToInt32(datos[0]);
                Persona.Nombre = datos[1];
                Persona.Tramite = datos[2];

                Agregar(Persona);
                dato = AD.ReadLine();
            }

            AD.Close();

        }
    }
}
