using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDatos
{
    public partial class frmEstructuraDeDatos : Form
    {
        public frmEstructuraDeDatos()
        {
            InitializeComponent();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosdelDesarrollador f1 = new frmDatosdelDesarrollador();
            f1.ShowDialog();
        }

        private void EstructuraDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void colaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCola cola = new frmCola();
            cola.ShowDialog();
        }

        private void consultasEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila pila= new frmPila();
            pila.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple ListaS = new frmListaSimple();
            ListaS.ShowDialog();
        }
    }
}
