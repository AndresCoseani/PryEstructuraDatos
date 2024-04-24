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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEquilibrar.Enabled = false;
        }

        private void rdoInorden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInorden.Checked == true)
            {
                Arbol.Recorrer(dgvGrillaLista, true);
                Arbol.Recorrer(cboEliminar, true);
            }
        }
        clsArbolBinario Arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Arbol.Agregar(ObjNodo);//vinculamos el objeto nodo a la cola
           
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            if (rdoInorden.Checked == true)
            {
                Arbol.Recorrer(dgvGrillaLista, true);
                Arbol.Recorrer(cboEliminar, true);
            }
            if (rdoInordendes.Checked == true)
            {
                Arbol.Recorrer(dgvGrillaLista, false);
                Arbol.Recorrer(cboEliminar, false);
            }
            if (rdoPreorden.Checked == true)
            {
                Arbol.Recorrer(dgvGrillaLista, true);
                Arbol.Recorrer(tvwArbolBinario);
            }
            if (rdoPostorden.Checked == true)
            {
                Arbol.Recorrer(dgvGrillaLista, true);

            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            
        }

        private void rdoPreorden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPreorden.Checked == true)
            {
                Arbol.Recorrer(dgvGrillaLista, true);
                Arbol.Recorrer(tvwArbolBinario);
            }
          
        }

        private void rdoPostorden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPostorden.Checked==true)
            {
                Arbol.Recorrer(dgvGrillaLista, true);
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

        private void rdoInordendes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInordendes.Checked)
            {
                Arbol.Recorrer(dgvGrillaLista, false);
                Arbol.Recorrer(cboEliminar, false);
            }

        }
    }
}
