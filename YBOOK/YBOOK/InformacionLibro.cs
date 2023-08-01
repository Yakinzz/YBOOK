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
    public partial class InformacionLibro: Form
    {
        string nombre = null;
        List<Libro> libros = new List<Libro>();
        List<Autor> autores = new List<Autor>();
        public static string cadenaConexion = null;
        public InformacionLibro(string nombre, List<Libro> libros, string cadenaConexionA)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.libros = libros;
            cadenaConexion = cadenaConexionA;

            Libro libro = new Libro();
            
            
            for (int i = 0; i < libros.Count(); i++)
            {
                libro = libros[i];
  
            }

            
            autores = GetAllAutor();
            

            int idAutor = libro.Autor1;
            Autor autor = new Autor();
            for (int i = 0; i < autores.Count(); i++)
            {
                if(idAutor == autores[i].ID1)
                {
                    autor = autores[i];
                    
                }
            }
            MessageBox.Show(autor.FechaNacimiento1);

            txtAutor.Text = autor.Nombre1;

            
            txtTitulo.Text = libro.Titulo1;
            txtIdioma.Text = libro.Idioma1;
            txtEditorial.Text = libro.Editorial1;
            txtCategoria.Text = libro.Categoria1;
            txtFechaPublicacion.Text = libro.FechaPublicacion1.ToString();
            txtNumeroPaginas.Text = libro.NumeroPaginas1.ToString();

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public List<Autor> GetAllAutor()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Autor>)db.GetAll<Autor>();
            }
        }
    }
}
