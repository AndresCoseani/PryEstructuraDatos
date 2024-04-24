using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEstructuraDatos
{
    internal class clsArbolBinario
    {
        private clsNodo PrimeroNodo;

        public clsNodo Raiz
        {
            get { return PrimeroNodo; }
            set { PrimeroNodo = value;}
        }

        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while(Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }
            }
        }


        public void Recorrer(ComboBox Lista, bool ascendente)
        {
            Lista.Items.Clear();
            if (ascendente)
            {
                InOrdenAsc(Lista, Raiz);
            }
            else
            {
                InOrdenDes(Lista, Raiz);
            }

        }
        private void InOrdenAsc(ComboBox Lst, clsNodo R)
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
        private void InOrdenDes(ComboBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDes(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDes(Lst, R.Izquierdo);
            }
        }

        public void Recorrer(DataGridView Grilla, bool ascendente)
        {
            Grilla.Rows.Clear();
            if (ascendente)
            {
                InOrdenAsc(Grilla, Raiz);
            }
            else
            {
                InOrdenDes(Grilla, Raiz);
            }
           
            //PreOrden(Raiz, Grilla);
            //PostOrden(Raiz, Grilla);

        }
        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Dgv, R.Izquierdo);
            }
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null)
            {
                InOrdenAsc(Dgv, R.Derecho);
            }
        }
        private void InOrdenDes(DataGridView Dgv, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDes(Dgv, R.Derecho);
            }
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null)
            {
                InOrdenDes(Dgv, R.Izquierdo);
            }
        }

        public void PreOrden(clsNodo R, DataGridView Dgv)
        {
            
            Dgv.Rows.Add(Dgv);
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, Dgv);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, Dgv);
            }
        }
        public void PostOrden(clsNodo R, DataGridView Dgv)
        {
            
            if (R.Izquierdo != null)
            {
                PostOrden(R.Izquierdo, Dgv);
            }
            if (R.Derecho != null)
            {
                PostOrden(R.Derecho, Dgv);
            }
            Dgv.Rows.Add(Dgv);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        public void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }
        //public void Recorrer()
        //{
        //   StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
           
        //    InOrdenAsc(AD, Raiz);
        //    AD.Close();
          
        //}
        //private void InOrdenAsc(TextWriter AD, clsNodo R)
        //{
        //    if (R.Izquierdo != null)
        //    {
        //        InOrdenAsc(AD, R.Izquierdo);
        //    }
        //    while (Aux != null)
        //    {
        //        AD.Write(Aux.Codigo);
        //        AD.Write(";");
        //        AD.Write(Aux.Nombre);
        //        AD.Write(";");
        //        AD.WriteLine(Aux.Tramite);
        //        Aux = Aux.Siguiente;
        //    }
        //    if (R.Derecho != null)
        //    {
        //        InOrdenAsc(AD, R.Derecho);
        //    }
        //}
    }
}
