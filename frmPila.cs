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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
           
           
            
        }
        clsPila Pila = new clsPila();
        private void frmPila_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Pila.Agregar(ObjNodo);//vinculamos el objeto nodo a la cola
            Pila.Recorrer(dgvGrillaPila);
            Pila.Recorrer(lstPila);
            Pila.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {
                lblCodigo.Text = Pila.Primero.Codigo.ToString();
                lblNombre.Text = Pila.Primero.Nombre;
                lblTramite.Text = Pila.Primero.Tramite;
                Pila.Eliminar();
                Pila.Recorrer(dgvGrillaPila);
                Pila.Recorrer(lstPila);
                Pila.Recorrer();
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {

                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTramite.Text))
            {

                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }
    }
}
