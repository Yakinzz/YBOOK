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
    public partial class InformacionLibro: Form
    {
        string nombre = null;
        List<Libro> libros = new List<Libro>();
        List<Autor> autores = new List<Autor>();
        List<Usuario> usuarios = new List<Usuario>();
        List<EstadoLibro> librosUsuario = new List<EstadoLibro>();
        public static string cadenaConexion = null;
        int idUsuario;
        EstadoLibro libroUsuario = new EstadoLibro();
        Usuario usuario = new Usuario();
        Usuario usuarioActivo = new Usuario();
        Libro libroSeleccionado = new Libro();
        public InformacionLibro(string nombre, List<Libro> librosA, string cadenaConexionA,int idUsuarioA)
        {
            InitializeComponent();
            
            this.nombre = nombre;
            libros = librosA;
            cadenaConexion = cadenaConexionA;
            idUsuario = idUsuarioA;

            usuarios = GetAllUsuarios();
            


            for (int i = 0; i < usuarios.Count(); i++)
            {
                usuario = usuarios[i];
                if (usuario.ID1 == idUsuario)
                {
                    usuarioActivo = usuarios[i];
                    break;
                }
            }


            


            Libro libro = new Libro();
            

            for (int i = 0; i < libros.Count(); i++)
            {
                libro = libros[i];
                if (libro.Titulo1.Equals(nombre))
                {
                    libroSeleccionado = libro;
                    break;
                }
            }

            librosUsuario = GetAllMisLibros();

            

            Boolean libroObtenido = false;
            
            for (int i = 0; i < librosUsuario.Count(); i++)
            {
                libroUsuario = librosUsuario[i];
                
                if (libroUsuario.ID_Usuario1 == usuarioActivo.ID1 && libroUsuario.ID_Libro1 == libroSeleccionado.ID1)
                {
                    libroObtenido = true;
                    break;
                }
            }

            if(libroObtenido != false)
            {
                btnFavorito.Visible = false;
                btnNoFavorito.Visible = true;
                lb_addmislibros.Visible = false;
                lb_eliminatemislibros.Visible = true;
            }
            else
            {
                btnFavorito.Visible = true;
                btnNoFavorito.Visible = false;
                lb_addmislibros.Visible = true;
                lb_eliminatemislibros.Visible = false;
            }

            


            autores = GetAllAutor();    

            string idAutor = libro.Autor1.ToString();

            Autor autor = new Autor();
            for (int i = 0; i < autores.Count(); i++)
            {
                autor = autores[i];

                if (idAutor.Equals(autor.ID1.ToString()))
                {
                    break;
                }
            }
    
            
            txtTitulo.Text = libroSeleccionado.Titulo1;
            txtAutor.Text = autor.Nombre1; //Se llama a la clase autor para obtener el nombre de la consulta realizada en este docuemnto
            txtIdioma.Text = libroSeleccionado.Idioma1;
            txtEditorial.Text = libroSeleccionado.Editorial1;
            txtCategoria.Text = libroSeleccionado.Categoria1;
            txtFechaPublicacion.Text = libroSeleccionado.FechaPublicacion1.ToString();
            txtNumeroPaginas.Text = libroSeleccionado.NumeroPaginas1.ToString();

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNoFavorito_Click(object sender, EventArgs e)
        {
            BorrarDeMisLibros(libroUsuario);
            btnFavorito.Visible = true;
            btnNoFavorito.Visible = false;
            lb_addmislibros.Visible = true;
            lb_eliminatemislibros.Visible = false;
            MessageBox.Show("Se ha eliminado el libro de tu biblioteca");
        }
        private void btnFavorito_Click(object sender, EventArgs e)
        {
            AddAMisLibros(libroSeleccionado,usuarioActivo.ID1);
            btnFavorito.Visible = false;
            btnNoFavorito.Visible = true;
            lb_addmislibros.Visible = false;
            lb_eliminatemislibros.Visible = true;
            MessageBox.Show("Se añadió el libro a tu biblioteca");
        }

        private static void BorrarDeMisLibros(EstadoLibro estadolibro)
        {
            using(IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"DELETE MisLibros WHERE ID_Usuario="+estadolibro.ID_Usuario1+" AND ID_Libro="+estadolibro.ID_Libro1+"";
                db.Execute(consulta, estadolibro);
            }
        }
        private static void AddAMisLibros(Libro nuevoMiLibro,int idUsuario)
        {
            
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"INSERT INTO MisLibros (ID_Usuario,ID_Libro) VALUES (" + idUsuario + "," + nuevoMiLibro.ID1 + ")";
                db.Execute(consulta, nuevoMiLibro);
            }
        }

        public List<Autor> GetAllAutor()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Autor>)db.GetAll<Autor>();
            }
        }

        public List<Usuario> GetAllUsuarios()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Usuario>)db.GetAll<Usuario>();
            }
        }

        public List<EstadoLibro> GetAllMisLibros()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<EstadoLibro>)db.GetAll<EstadoLibro>();
            }
        }


        
    }
}
