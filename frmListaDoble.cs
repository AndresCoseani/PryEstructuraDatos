using PryEstructuraDatos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PryEstructuraDatos
{
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();

           
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            rdoAscendiente.Checked = true;
        }
      
        
        clsListaDoble ListaDoble = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese un código");
              
            }
           

                int codigo = Convert.ToInt32(txtCodigo.Text);
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = codigo;
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                ListaDoble.Agregar(ObjNodo);//vinculamos el objeto nodo a la cola
                if (rdoAscendiente.Checked == true)
                {
                    ListaDoble.Recorrer(dgvGrillaListaDoble);
                    ListaDoble.Recorrer(lstListaDoble);
                    ListaDoble.Recorrer(cboEliminar);
                    ListaDoble.Recorrer();
                }
                if (rdoDescendiente.Checked == true)
                {
                    ListaDoble.RecorrerDes(dgvGrillaListaDoble);
                    ListaDoble.RecorrerDes(lstListaDoble);
                    ListaDoble.RecorrerDes(cboEliminar);
                    ListaDoble.RecorrerDes();
                }
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaDoble.Primero != null)
            {
                Int32 x = Convert.ToInt32(cboEliminar.Text);
                ListaDoble.Eliminar(x);
                ListaDoble.Recorrer(dgvGrillaListaDoble);
                ListaDoble.Recorrer(lstListaDoble);
                ListaDoble.Recorrer(cboEliminar);
                ListaDoble.Recorrer();

            }
            else
            {
                MessageBox.Show("Seleccione un dato");
            }
          
        }

       
        private void rdoAscendiente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAscendiente.Checked == true)
            {
                ListaDoble.Recorrer(dgvGrillaListaDoble);
                ListaDoble.Recorrer(lstListaDoble);
                ListaDoble.Recorrer(cboEliminar);
                ListaDoble.Recorrer();
            }
        }

        private void rdoDescendiente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDescendiente.Checked == true)
            {
                ListaDoble.RecorrerDes(dgvGrillaListaDoble);
                ListaDoble.RecorrerDes(lstListaDoble);
                ListaDoble.RecorrerDes(cboEliminar);
                ListaDoble.RecorrerDes();
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

        }
    }
}
