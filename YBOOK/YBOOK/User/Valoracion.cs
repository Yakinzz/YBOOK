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
    public partial class Valoracion : Form
    {
        string cadenaConexion = null;
        List<Valoraciones> listvaloraciones = new List<Valoraciones>();
        List<Usuario> listusuarios = new List<Usuario>();
        List<Libro> listlibros = new List<Libro>();
        List<Autor> autores = new List<Autor>();
        List<EstadoLibro> listEstadoslibros = new List<EstadoLibro>();
        int idUsuario = 0;
        string nombreLibroSeleccionado = null;
        


        public Valoracion(string cadenaConexion,int idUsuario)
        {
            InitializeComponent();
            this.cadenaConexion = cadenaConexion;
            this.idUsuario = idUsuario;

            listvaloraciones = GetAllValoraciones();
            listusuarios = GetAllUsuarios();
            listlibros = GetAllLibros();
            listEstadoslibros = GetAllEstadoLibros();


            //Se cargan todos los libros en el combobox----------------------------------------------

            Libro libro = new Libro();
            EstadoLibro misLibros = new EstadoLibro();

            for (int j = 0; j < listEstadoslibros.Count(); j++)
            {
                misLibros = listEstadoslibros[j];
                for (int i = 0; i < listlibros.Count(); i++)
                {
                    libro = listlibros[i];
                    if (misLibros.ID_Libro1 == libro.ID1)
                    {
                        cb_libros.Items.Add(libro.Titulo1);
                    }
                    
                }
            }
            


            //Si tiene algún elemento el combobox, selecciono el primero-------------------------
            if(cb_libros.Items.Count == 0)
            {
                MessageBox.Show("No tienes libros añadidos para valorar.");
            }
            else
            {
                cb_libros.SelectedIndex = 0;
                nombreLibroSeleccionado = cb_libros.SelectedItem.ToString();
            }

            
            


        }
        private void cb_libros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLibro.Text = "";
            tb_Puntuacion.Value=0;
            txtLibro.Text = "";
            txtComentario.Text = "";

            Libro libro = new Libro();
            int idLibroSeleccionado = 0;
            for (int i = 0; i < listlibros.Count(); i++)
            {
                libro = listlibros[i];
                if (libro.Titulo1 == cb_libros.Text)
                {
                    idLibroSeleccionado = libro.ID1;
                    break;
                }
            }

            Boolean encontrado=false;
            Valoraciones v = new Valoraciones();
            for (int i = 0; i < listvaloraciones.Count(); i++)
            {
                v = listvaloraciones[i];
                if(idLibroSeleccionado==v.ID_Libro1 && idUsuario == v.ID_Usuario1)
                {
                    encontrado = true;                     
                    break;
                }      
            }

            if (encontrado != false)
            {
                btn_Cancelar.Visible=false;
                btn_AddValoracion.Visible=false;
                btn_EliminarValoracion.Visible = true;
                
                //Libro
                lbLibro.Visible=true;
                txtLibro.Visible = true;
                txtLibro.Text=cb_libros.Text;
                /*Más información del libro*/
                txtEditorial.Text = libro.Editorial1;
                txtCategoria.Text = libro.Categoria1;
                txtIdioma.Text = libro.Idioma1;


                //Puntuacion
                lbPuntuacion.Visible = true;
                tb_Puntuacion.Visible = true;
                tb_Puntuacion.Value = v.Puntucion1;


                //Comentario
                lbComentario.Visible = true;
                txtComentario.Visible = true;
                txtComentario.Text = v.Comentario1;


                //Autor
                autores = GetAllAutores();

                Autor a = new Autor();
                for (int i = 0; i < autores.Count(); i++)
                {
                    a = autores[i];
                    if (a.ID1 == libro.Autor1)
                    {
                        txtNombreAutor.Text = a.Nombre1;
                        txtApellidos.Text = a.Apellidos1;
                        txtNacionalidad.Text = a.Nacionalidad1;
                        break;
                    }
                }


            }
            else
            {
                btn_Cancelar.Visible = false;
                btn_AddValoracion.Visible = true;
                btn_EliminarValoracion.Visible = false;
            }
        }

        

        public List<Valoraciones> GetAllValoraciones()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Valoraciones>)db.GetAll<Valoraciones>();
            }
        }
        public List<EstadoLibro> GetAllEstadoLibros()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<EstadoLibro>)db.GetAll<EstadoLibro>();
            }
        }
        public List<Usuario> GetAllUsuarios()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Usuario>)db.GetAll<Usuario>();
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
