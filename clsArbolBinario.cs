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
        //COMBOBOX
        public void RecorrerComboAsc(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenComboAsc(Lista, Raiz);
        }
        private void InOrdenComboAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenComboAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenComboAsc(Lst, R.Derecho);
            }
        }
        //GRILLA
        public void RecorrerGrillaAsc(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenGrillaAsc(Grilla, Raiz);
        }
        private void InOrdenGrillaAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenGrillaAsc(Dgv, R.Izquierdo);
            }
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null)
            {
                InOrdenGrillaAsc(Dgv, R.Derecho);
            }
        }
        //EXCEL
        public void RecorrerAdAsc()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrden.csv", false, Encoding.UTF8);

            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            InOrdenAdAsc(Raiz, AD);
            AD.Close();

        }
        private void InOrdenAdAsc(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                InOrdenAdAsc(R.Izquierdo, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}");
                InOrdenAdAsc(R.Derecho, writer);
            }
        }



        //IN ORDEN DESCENDENTE
        //COMBOBOX
        public void RecorrerInordenComboDes(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenComboDes(Lista, Raiz);
        }
        private void InOrdenComboDes(ComboBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenComboDes(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenComboDes(Lst, R.Izquierdo);
            }
        }
        //GRILLA
        public void RecorrerGrillaDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenGrillaDes(Grilla, Raiz);
        }
        private void InOrdenGrillaDes(DataGridView Dgv, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenGrillaDes(Dgv, R.Derecho);
            }
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null)
            {
                InOrdenGrillaDes(Dgv, R.Izquierdo);
            }
        }
        //AD
        public void RecorrerDes()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrden.csv", false, Encoding.UTF8);

            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            InOrdenDes(Raiz, AD);
            AD.Close();

        }
        private void InOrdenDes(clsNodo R, StreamWriter writer)
        {
            if (R.Derecho != null)
            {
                InOrdenDes(R.Derecho, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}");
                InOrdenDes(R.Izquierdo, writer);
            }
        }
        //PRE ORDEN
        public void RecorrerGrillaPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenGrilla(Raiz, Grilla);
        }

        public void PreOrdenGrilla(clsNodo R, DataGridView Dgv)
        {

            Dgv.Rows.Add(Dgv);
            if (R.Izquierdo != null)
            {
                PreOrdenGrilla(R.Izquierdo, Dgv);
            }
            if (R.Derecho != null)
            {
                PreOrdenGrilla(R.Derecho, Dgv);
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
       
       
        
        public void RecorrerPre()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrden.csv", false, Encoding.UTF8);

            PreOrden(Raiz, AD);
            AD.Close();

        }
        private void PreOrden(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}");
                PreOrden(R.Izquierdo, writer);
                PreOrden(R.Derecho, writer);
            }
        }
        public void RecorrerPost()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrden.csv", false, Encoding.UTF8);

            PostOrden(Raiz, AD);
            AD.Close();

        }
        private void PostOrden(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                
                PostOrden(R.Izquierdo, writer);
                PostOrden(R.Derecho, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}");
            }
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
