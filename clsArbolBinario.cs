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
            set { PrimeroNodo = value; }
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
                while (Aux != null)
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

        //IN ORDEN ASCENDENTE

        public void RecorrerAscGrilla(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderAscGrilla(Grilla, Raiz);
        }
        public void InOrderAscGrilla(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrderAscGrilla(dgv, R.Izquierdo);
            }

            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null)
            {
                InOrderAscGrilla(dgv, R.Derecho);
            }
        }

        public void RecorrerAscCombo(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrderAscCombo(Lista, Raiz);
        }
        public void InOrderAscCombo(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrderAscCombo(Lst, R.Izquierdo);
            }

            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrderAscCombo(Lst, R.Derecho);
            }
        }

        public void RecorrerInOrdenAscAD()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            RecorrerInOrdenAscAD(Raiz, AD);
            AD.Close();
        }

        private void RecorrerInOrdenAscAD(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                RecorrerInOrdenAscAD(R.Izquierdo, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
                RecorrerInOrdenAscAD(R.Derecho, writer);
            }
        }


        //IN ORDEN DESCENDENTE

        public void RecorrerDescGrilla(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderDescGrilla(Grilla, Raiz);
        }
        public void InOrderDescGrilla(DataGridView dgv, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrderDescGrilla(dgv, R.Derecho);
            }

            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null)
            {
                InOrderDescGrilla(dgv, R.Izquierdo);
            }
        }
        public void RecorrerComboDesc(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrderDescCombo(Lista, Raiz);
        }
        public void InOrderDescCombo(ComboBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrderDescCombo(Lst, R.Derecho);
            }

            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrderDescCombo(Lst, R.Izquierdo);
            }
        }
        public void RecorrerInOrdenDescAD()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrdenDesc.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            InOrdenDescAD(Raiz, AD);
            AD.Close();
        }

        private void InOrdenDescAD(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                InOrdenDescAD(R.Derecho, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
               InOrdenDescAD(R.Izquierdo, writer);
            }
        }

        //PRE ORDEN
        public void RecorrerTree(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrdenTree(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        public void PreOrdenTree(clsNodo R, TreeNode NodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            NodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null)
            {
                PreOrdenTree(R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrdenTree(R.Derecho, NodoPadre);
            }
        }

        public void RecorrerPreOrdenGrilla(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenGrilla(Grilla, Raiz);
        }
        public void PreOrdenGrilla(DataGridView dgv, clsNodo R)
        {
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null)
            {
                PreOrdenGrilla(dgv, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrdenGrilla(dgv, R.Derecho);
            }
        }
        public void RecorrerPreOrdenAD()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioPreOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            PreOrdenAD(Raiz, AD);
            AD.Close();
        }

        private void PreOrdenAD(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
                PreOrdenAD(R.Izquierdo, writer);
                PreOrdenAD(R.Derecho, writer);
            }
        }

        //POST ORDEN
        public void RecorrerPostOrdenGrilla(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrdenGrilla(Grilla, Raiz);
        }
        public void PostOrdenGrilla(DataGridView dgv, clsNodo R)
        {

            if (R.Izquierdo != null)
            {
                PreOrdenGrilla(dgv, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrdenGrilla(dgv, R.Derecho);
            }
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void RecorrerPostOrdenAD()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioPostOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            PostOrdenAD(Raiz, AD);
            AD.Close();
        }

        private void PostOrdenAD(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                PostOrdenAD(R.Izquierdo, writer);
                PostOrdenAD(R.Derecho, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
            }
        }

        //ELIMINAR
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
        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }
        public void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }


    }
}
