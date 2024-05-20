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
    public partial class frmBaseDeDatosOperaciones : Form
    {
        public frmBaseDeDatosOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void btnProSimple_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT TITULO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDeDatosOperaciones, VarSQL);
            
        }

        private void btnProMulti_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT TITULO, AÑO, PRECIO " +
                "FROM LIBRO " +
                "ORDER BY TITULO ASC";
            objBaseDatos.Listar(dgvBaseDeDatosOperaciones, VarSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT L.TITULO, L.CANTIDAD, L.PRECIO, A.NOMBRE " +
               "FROM LIBRO L " +
               "INNER JOIN AUTOR A ON L.IDAUTOR = A.IDAUTOR " +
               "ORDER BY L.TITULO ASC";
            objBaseDatos.Listar(dgvBaseDeDatosOperaciones, VarSQL);
        }

        private void btnSelecSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO, PRECIO " +
                "FROM LIBRO " +
                "WHERE PRECIO < 500 " +
                "ORDER BY PRECIO ASC";
            objBaseDatos.Listar(dgvBaseDeDatosOperaciones, varSQL);
        }

        private void btnSelecMulti_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT TITULO, AÑO, PRECIO, IDIDIOMA " +
               "FROM LIBRO " +
               "WHERE IDIDIOMA = 6 AND PRECIO < 600 " +
               "ORDER BY TITULO ASC";

            objBaseDatos.Listar(dgvBaseDeDatosOperaciones, VarSQL);
        }

        private void btnSelecConvulcion_Click(object sender, EventArgs e)
        {
            //proyecta todo de libro, donde ididioma sea mayor a 5 y menos a 15 y aparte idautor sea mayor a 10 y menor a 25
            String VarSQL = "SELECT * FROM (SELECT * FROM Libro L WHERE L.IdIdioma > 5 AND L.IdIdioma < 15) " +
                " A WHERE A.IdAutor > 10 AND A.IdAutor < 25";
            objBaseDatos.Listar(dgvBaseDeDatosOperaciones, VarSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * FROM Libro " +
                "WHERE IdIdioma = 2 " +
                "UNION " +
                "SELECT * FROM Libro " +
                "WHERE IdIdioma = 3 " +
                "UNION " +
                "SELECT * FROM Libro " +
                "WHERE IdIdioma = 5 " +
                "ORDER BY IdIdioma ASC";
            objBaseDatos.Listar(dgvBaseDeDatosOperaciones, VarSQL);
        }

        private void btnInteseccion_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * FROM Libro " +
                "WHERE IdAutor " +
                "IN " +//en mysql se usa intersect pero en access es IN
                "(SELECT DISTINCT IdAutor FROM Libro " +
                "WHERE IdAutor <= 5) ";
                
                

                objBaseDatos.Listar(dgvBaseDeDatosOperaciones, VarSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * FROM Libro " +
                "WHERE IdAutor " +
                "NOT IN " +
                "(SELECT DISTINCT IdAutor FROM Libro " +
                "WHERE IdAutor <= 5) ";//proyecta todo menos las que no tenga el idautor  <= a 5
            objBaseDatos.Listar(dgvBaseDeDatosOperaciones, VarSQL);
        }
    }
}
