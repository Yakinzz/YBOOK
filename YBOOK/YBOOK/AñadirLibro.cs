using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YBOOK
{
    public partial class AñadirLibro : Form
    {
        public static string cadenaConexion = null;
        List<Libro> listlibros = new List<Libro>();
        List<Autor> listautores = new List<Autor>();
        public AñadirLibro(string cadenaConexionA)
        {
            InitializeComponent();

            cadenaConexion = cadenaConexionA;
            listlibros = GetAllLibros();

            //Para llenar el combo box con todos los autores
            listautores = GetAllAutores();
            Autor autor = new Autor();
            for (int i = 0; i < listautores.Count(); i++)
            {
                autor = listautores[i];
                cb_Autor.Items.Add(autor.Nombre1 + "_" + autor.Apellidos1);
            }


        }

        private void btn_AñadirLibro_Click(object sender, EventArgs e)
        {

            Libro libro = new Libro();
            Boolean libroRegistrado = false;
            for (int i = 0; i < listlibros.Count(); i++)
            {
                libro = listlibros[i];
                if (libro.Titulo1.Equals(txt_Titulo.Text))
                {
                    libroRegistrado = true;
                    break;
                }
            }

            if (libroRegistrado == false)
            {
                if (!String.IsNullOrEmpty(txt_Titulo.Text))
                {
                    if (!(cb_Autor.Text == ""))
                    {
                        if (!cb_Idioma.Text.Equals(""))
                        {
                            if (!txt_Editorial.Text.Equals(""))
                            {
                                if (!cb_Categoria.Text.Equals(""))
                                {
                                    if (!Numero_Páginas.Value.Equals(""))
                                    {

                                    }
                                    else
                                    {
                                        MessageBox.Show("Tiene que indicar el número de páginas que tiene el libro.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Tiene que seleccionar una categoria.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tiene que indicar una editorial para el libro.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tiene que seleccionar un idioma.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tiene que seleccionar un autor.");
                    }
                }
                else
                {
                    MessageBox.Show("Tiene que indicarnos un título para el libro.");
                }
            }
            
            else
            {
                MessageBox.Show("Este libro ya está registrado con ese nombre.");
            }

        }

        private static void AddAMisLibros(Libro nuevoMiLibro, int idUsuario)
        {

            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"INSERT INTO Libros (Titulo,AutorID,Idioma,Editorial,Categoria,FechaPublicacion,NumeroPaginas) VALUES (" + idUsuario + "," + nuevoMiLibro.ID1 + ")";
                db.Execute(consulta, nuevoMiLibro);
            }
        }

        public List<Libro> GetAllLibros()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Libro>)db.GetAll<Libro>();
            }
        }
        public List<Autor> GetAllAutores()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Autor>)db.GetAll<Autor>();
            }
        }




    }
}
