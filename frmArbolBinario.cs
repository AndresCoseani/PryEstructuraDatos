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
            
        }

        private void rdoInorden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerAscGrilla(dgvGrillaArbol);
            Arbol.RecorrerAscCombo(cboEliminar);
            Arbol.RecorrerInOrdenAscAD();
        }
        clsArbolBinario Arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Arbol.Agregar(ObjNodo);//vinculamos el objeto nodo a la cola
            Arbol.RecorrerAscGrilla(dgvGrillaArbol);
            Arbol.RecorrerTree(tvwArbolBinario);
            Arbol.RecorrerAscCombo(cboEliminar);
           
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            
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
            Arbol.RecorrerPreOrdenGrilla(dgvGrillaArbol);
            Arbol.RecorrerTree(tvwArbolBinario);
            Arbol.RecorrerPreOrdenAD();
        }

        private void rdoPostorden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPostOrdenGrilla(dgvGrillaArbol);
            Arbol.RecorrerPostOrdenAD();
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
            Arbol.RecorrerDescGrilla(dgvGrillaArbol);
            Arbol.RecorrerComboDesc(cboEliminar);
            Arbol.RecorrerInOrdenDescAD();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboEliminar.SelectedIndex != -1)
            {
                Int32 x = Convert.ToInt32(cboEliminar.Text);
                Arbol.Eliminar(x);
                Arbol.RecorrerAscGrilla(dgvGrillaArbol);
                Arbol.RecorrerTree(tvwArbolBinario);
                Arbol.RecorrerAscCombo(cboEliminar);
                Arbol.RecorrerInOrdenAscAD();
            }
            else
            {
                MessageBox.Show("Seleccione un dato");
            }
        }

        private void dgvGrillaArbol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.RecorrerAscGrilla(dgvGrillaArbol);
            Arbol.RecorrerTree(tvwArbolBinario);
            Arbol.RecorrerAscCombo(cboEliminar);
            Arbol.RecorrerInOrdenAscAD();
            
        }
    }
}
