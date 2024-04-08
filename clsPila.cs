using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEstructuraDatos
{
    internal class clsPila
    {
        //campos
        private clsNodo pri;

        //propiedades
        public clsNodo Primero
        { 
            get { return pri; }
            set { pri = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero==null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente=Primero;
                Primero = Nuevo;
            }
        
        }
        public void Eliminar()
        {
            if (Primero!=null)
            {
                Primero=Primero.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla)
        { 
            clsNodo aux= Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            { 
                Grilla.Rows.Add(aux.Codigo,aux.Nombre,aux.Tramite);
                aux= aux.Siguiente;
            }
           
        }
        public void Recorrer(ListBox lista)
        {
            clsNodo Aux = Primero;
            lista.Items.Clear();
            while (Aux != null)
            {
                lista.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }

        }
        public void Recorrer(ComboBox combo)
        {
            clsNodo Aux = Primero;
            combo.Items.Clear();
            while (Aux != null)
            {
                combo.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }

        }
        public void Recorrer()
        {
            clsNodo Aux = Primero;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre,Tramite");
            while (Aux != null)
            {
                AD.Write(Aux.Codigo);
                AD.Write(";");
                AD.Write(Aux.Nombre);
                AD.Write(";");
                AD.WriteLine(Aux.Tramite);
                Aux = Aux.Siguiente;
            }
            AD.Close();

        }
    }
}
