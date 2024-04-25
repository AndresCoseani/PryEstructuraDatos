using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PryEstructuraDatos
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

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero==null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo<Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero= Nuevo; 
                }
                else
                {
                    if (Nuevo.Codigo>Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo < Nuevo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente= Aux;
                        Aux.Anterior= Nuevo;
                        Nuevo.Anterior = Ant;
                    }
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo== Codigo && Ultimo==Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo==Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo== Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo < Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Aux.Siguiente;
                        Aux = Aux.Siguiente;
                        Aux.Anterior = Ant;
                    }
                }

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
                combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }

        }
        public void Recorrer()
        {
            clsNodo Aux = Primero;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
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


        //DESCENDIENTE
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }

        }
        public void RecorrerDes(ListBox lista)
        {
            clsNodo Aux = Ultimo;
            lista.Items.Clear();
            while (Aux != null)
            {
                lista.Items.Add(Aux.Codigo);
                Aux = Aux.Anterior;
            }

        }
        public void RecorrerDes(ComboBox combo)
        {
            clsNodo Aux = Ultimo;
            combo.Items.Clear();
            while (Aux != null)
            {
                combo.Items.Add(Aux.Codigo);
                Aux = Aux.Anterior;
            }

        }
        public void RecorrerDes()
        {
            clsNodo Aux = Ultimo;
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
                Aux = Aux.Anterior;
            }
            AD.Close();

        }
    }
}
