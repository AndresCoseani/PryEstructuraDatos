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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos ObjBd = new clsBaseDatos();
            String varSQL = "SELECT * FROM Libro";
            switch (cboRepaso.SelectedIndex)
            {
                case 0:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Libros que estan en Ingles, Español y Chino";
                    varSQL = "SELECT * FROM Libro " +
                    "WHERE IdIdioma = 1 " +
                    "UNION " +
                    "SELECT * FROM Libro " +
                    "WHERE IdIdioma = 6 " +
                    "UNION " +
                    "SELECT * FROM Libro " +
                    "WHERE IdIdioma = 9 ";
                    break;

                case 1:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Todos los idiomas que tienen libros";
                    varSQL = "SELECT * FROM Idioma " +
                        "WHERE IdIdioma " +
                        "IN " +
                        "(SELECT  IdIdioma FROM Libro)";
                    break;

                case 2:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Libros que no estan en español";
                    varSQL = "SELECT * FROM Libro " +
                        "WHERE IdIdioma " +
                        "NOT IN " +
                        "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma = 6)";
                    break;

                case 3:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Todos los libros que cuesten menos de $500";
                    varSQL = "SELECT * FROM Libro " +
                        "WHERE PRECIO < 500 ";
                    break;

                case 4:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Libros que hayan sido escritos por el mismo Autor y cuesten mas de $400";
                    varSQL = "SELECT * FROM LIBRO " +
                           "WHERE IDAUTOR= 2 AND PRECIO >= 400";
                    break;

                case 5:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Libros que esten escritos por un IdAutor mayor a 15 y tenga una cantidad mayor a 5";
                    varSQL = "SELECT * FROM (SELECT * FROM Libro L WHERE Cantidad > 5) " +
                        " A WHERE A.IdAutor > 15";
                    break;

                default:
                    break;
            }
            ObjBd.Listar(dgvRepasoBaseDeDatos, varSQL);
        }
    }
}
