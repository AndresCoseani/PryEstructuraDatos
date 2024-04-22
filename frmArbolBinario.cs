﻿using System;
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

        }

        private void rdoInorden_CheckedChanged(object sender, EventArgs e)
        {

        }
        clsArbolBinario Arbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese un código");

            }
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Arbol.Agregar(ObjNodo);//vinculamos el objeto nodo a la cola
           
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            if (rdoInorden.Checked==true)
            {
                Arbol.Recorrer(dgvGrillaLista);
                Arbol.Recorrer(cboEliminar);
                Arbol.Recorrer(tvwArbolBinario);
            }
            if (rdoPreorden.Checked == true)
            {
                Arbol.Recorrer(dgvGrillaLista);
                Arbol.Recorrer(cboEliminar);
                Arbol.Recorrer(tvwArbolBinario);
            }
            if (rdoPostorden.Checked == true)
            {
                Arbol.Recorrer(dgvGrillaLista);
                Arbol.Recorrer(cboEliminar);
                Arbol.Recorrer(tvwArbolBinario);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
