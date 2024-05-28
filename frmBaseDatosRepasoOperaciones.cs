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
                        "Libros que esten escritos por un IdAutor mayor a 15 y tenga una cantidad mayor a 5 y menor a 10";
                    varSQL = "SELECT * FROM (SELECT * FROM Libro L WHERE Cantidad > 5 AND Cantidad < 10) " +
                        " A WHERE A.IdAutor > 15";
                    break;

                case 6:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Libros ordenados de forma descendiente por ID";
                    varSQL = "SELECT * FROM Libro " +
                        "ORDER BY IDLIBRO DESC"; 
                    break;

                case 7:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Titulo de los libros";
                    varSQL = "SELECT TITULO FROM Libro ";
                    break;

                case 8:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Titulo de los libros, el numero de autor, de pais y de idioma";
                    varSQL = "SELECT TITULO, IDAUTOR, IDPAIS, IDIDIOMA FROM Libro ";
                    break;
                case 9:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Titulo de los libros, Nombre de autor, Idioma y Precio";
                    varSQL = "SELECT TITULO, A.NOMBRE, L.PRECIO " +
                        "FROM Libro L " +
                        "INNER JOIN AUTOR A ON L.IDAUTOR=A.IDAUTOR ";
                    break;
                case 10:
                    lblCaso.Text = cboRepaso.Text + ": " +
                       "Libros que sean de Reino Unido, Estados Unidos y Alemania";
                    varSQL = "SELECT * FROM Libro " +
                    "WHERE IdPais = 1 " +
                    "UNION " +
                    "SELECT * FROM Libro " +
                    "WHERE IdPais = 4 " +
                    "UNION " +
                    "SELECT * FROM Libro " +
                    "WHERE IdPais = 5 ";
                    break;
                case 11:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Libros que estan en Austria";
                    varSQL = "SELECT * FROM Libro " +
                        "WHERE IdPais " +
                        "IN " +
                        "(SELECT DISTINCT IdPais FROM Pais WHERE IdPais = 15)"; 
                    break;
                case 12:
                    lblCaso.Text = cboRepaso.Text + ": " +
                         "Libros que no estan en Grecia";
                    varSQL = "SELECT * FROM Libro " +
                        "WHERE IdPais " +
                        "NOT IN " +
                        "(SELECT DISTINCT IdPais FROM Pais WHERE IdPais = 42)";
                    break;

                case 13:
                    lblCaso.Text = cboRepaso.Text + ": " +
                          "Todos los Autores con ID menor a 7";
                    varSQL = "SELECT * FROM Libro " +
                        "WHERE IdAutor < 7 ";
                    break;

                case 14:
                    lblCaso.Text = cboRepaso.Text + ": " +
                          "Libros con cantidad mayor a 5 y cuesten menos de $600";
                    varSQL = "SELECT * FROM LIBRO " +
                           "WHERE CANTIDAD > 5 AND PRECIO < 600";
                    break;

                case 15:
                    lblCaso.Text = cboRepaso.Text + ": " +
                          "Libros que esten escritos por el mismo autor y tenga una precio mayor a $200 y menor a $500";
                    varSQL = "SELECT * FROM (SELECT * FROM Libro L WHERE Precio > 200 AND Precio < 500) " +
                        " A WHERE A.IdAutor = 4";
                    break;

                case 16:
                    lblCaso.Text = cboRepaso.Text + ": " +
                           "Libros ordenados de forma ascendiente por ID de autor";
                    varSQL = "SELECT * FROM Libro " +
                        "ORDER BY IDAutor ASC";
                    break;

                case 17:
                    lblCaso.Text = cboRepaso.Text + ": " +
                          "Nombbre de los Autores";
                    varSQL = "SELECT NOMBRE FROM Autor ";
                    break;

                case 18:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Titulo de los libros, Id del pais, Cantidad y Precio ";
                    varSQL = "SELECT TITULO, IDPAIS, CANTIDAD, PRECIO FROM Libro ";
                    break;

                case 19:
                    lblCaso.Text = cboRepaso.Text + ": " +
                        "Titulo de los libros, Idioma y Cantidad";
                    varSQL = "SELECT TITULO, NOMBRE AS IDIOMA, CANTIDAD " +
                        "FROM Libro " +
                        "INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma ";
                    break;

                default:
                    break;
            }
            ObjBd.Listar(dgvRepasoBaseDeDatos, varSQL);
        }
    }
}
