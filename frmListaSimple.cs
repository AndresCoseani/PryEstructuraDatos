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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
            
           
           
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        clsListaSimple Lista= new clsListaSimple();
        private void Agregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Lista.Agregar(ObjNodo);//vinculamos el objeto nodo a la cola
            Lista.Recorrer(dgvGrillaLista);
            Lista.Recorrer(lstListaSimple);
            Lista.Recorrer(cboEliminar);
            Lista.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero!=null)
            {
                Int32 x = Convert.ToInt32(cboEliminar.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvGrillaLista);
                Lista.Recorrer(lstListaSimple);
                Lista.Recorrer(cboEliminar);
                Lista.Recorrer();

            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }
            btnEliminar.Enabled = false;
        }

        private void cboEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEliminar.SelectedIndex == -1)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {

                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
