using System;
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
