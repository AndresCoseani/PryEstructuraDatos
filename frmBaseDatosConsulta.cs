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
    public partial class frmBaseDatosConsulta : Form
    {
        public frmBaseDatosConsulta()
        {
            InitializeComponent();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            objBaseDatos.Listar(dgvConsultaBaseDeDatos, txtConsulta.Text);
        }
    }
}
