﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdSerna
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }

        }
        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }


        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho= null;
            if(Raiz==null) 
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while(Aux !=null)
                {
                    NodoPadre = Aux;
                    if(Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux=Aux.Derecho;
                    }
                }
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
           
        }
        private clsNodo[] Vector =new clsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i -1);
        }
        public void Eliminar(Int32 Codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, Codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1,fin);
            }
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i]=NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if(NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }


        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if(R.Izquierdo!= null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }
        public void Recorrer(ListBox List)
        {
            List.Items.Clear();
            InOrdenAsc(List, Raiz);
        }
        private void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        private void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(dgv, R.Izquierdo);
            }
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null)
            {
                InOrdenAsc(dgv, R.Derecho);
            }
        }
        public void InOrdenDesc(ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDesc(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Lst,R.Izquierdo);
            }
        }
        public void PreOrden(DataGridView Grilla, clsNodo R)
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if(R.Izquierdo!= null)
            {
                PreOrden(Grilla, R.Izquierdo);
            }
            if(R.Derecho != null)
            {
                PreOrden(Grilla, R.Derecho);
            }
        }
        public void PostOrden(DataGridView Grilla, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                PostOrden(Grilla,R.Izquierdo);
            }
            if(R.Derecho != null)
            {
                PostOrden(Grilla, R.Derecho);

            }
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }


        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();

        }


        //que esto se pase a un treeview
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, NodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, NodoPadre);

        }
       



    }
}
