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
using Dapper;

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
                lbLibro.Visible = false;
                txtLibro.Visible = false;
                label1.Visible= false;
                MessageBox.Show("No tienes libros añadidos para valorar.");
                
            }
            else
            {
                cb_libros.SelectedIndex = 0;
                nombreLibroSeleccionado = cb_libros.SelectedItem.ToString();
            }
        }
        
        int idLibroSeleccionado = 0;
        private void cb_libros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLibro.Text = "";
            tb_Puntuacion.Value=0;
            txtLibro.Text = "";
            txtComentario.Text = "";

            Libro libro = new Libro();
            
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
            //Libro
            lbLibro.Visible=true;
            txtLibro.Visible = true;
            txtLibro.Text=cb_libros.Text;
            txtLibro.Enabled = false;
            /*Más información del libro*/
            txtEditorial.Text = libro.Editorial1;
            txtEditorial.Enabled = false;
            txtCategoria.Text = libro.Categoria1;
            txtCategoria.Enabled = false;
            txtIdioma.Text = libro.Idioma1;
            txtIdioma.Enabled = false;
            
            //Autor
            autores = GetAllAutores();

            Autor autor1 = new Autor();
            for (int i = 0; i < autores.Count(); i++)
            {
                autor1 = autores[i];
                if (autor1.ID1 == libro.Autor1)
                {
                    txtNombreAutor.Text = autor1.Nombre1;
                    txtNombreAutor.Enabled = false;
                    txtApellidos.Text = autor1.Apellidos1;
                    txtApellidos.Enabled = false;
                    txtNacionalidad.Text = autor1.Nacionalidad1;
                    txtNacionalidad.Enabled = false;
                    break;
                }
            }
            
            
            if (encontrado != false)
            {
                btn_AddValoracion.Visible=false;
                btn_EliminarValoracion.Visible = true;
                
                //Puntuacion
                lbPuntuacion.Visible = true;
                tb_Puntuacion.Visible = true;
                tb_Puntuacion.Value = v.Puntucion1;
                
                //Comentario
                lbComentario.Visible = true;
                txtComentario.Visible = true;
                txtComentario.Text = v.Comentario1;
            }
            else
            {
                btn_AddValoracion.Visible = true;
                btn_EliminarValoracion.Visible = false;
                
                //Puntuacion
                lbPuntuacion.Visible = true;
                tb_Puntuacion.Visible = true;
                
                //Comentario
                lbComentario.Visible = true;
                txtComentario.Visible = true;
            }
        }
        
        private void btn_AddValoracion_Click(object sender, EventArgs e)
        {
            if(txtComentario.Text!="")
            {
                Valoraciones nuevaValoracion = new Valoraciones();
                nuevaValoracion.ID_Libro1 = idLibroSeleccionado;
                nuevaValoracion.ID_Usuario1 = idUsuario;
                nuevaValoracion.Comentario1 = txtComentario.Text;
                nuevaValoracion.Puntucion1 = tb_Puntuacion.Value;
                nuevaValoracion.FechaValoracion1=DateTime.Today;
                
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    var consulta = $@"INSERT INTO Valoraciones (Puntuacion,Comentario,UsuarioID,LibroID,FechaValoracion) VALUES ('"+ nuevaValoracion.Puntucion1 + "','" + nuevaValoracion.Comentario1 + "','" + nuevaValoracion.ID_Usuario1 + "','"+ nuevaValoracion.ID_Libro1 +"','"+ nuevaValoracion.FechaValoracion1 +"')";
                    db.Execute(consulta,nuevaValoracion);
                    MessageBox.Show("Valoración para el libro: " + txtLibro.Text + " guardada con una puntuación de: " +nuevaValoracion.Puntucion1);
                    this.Close();
                }
            }else
            {
                MessageBox.Show("No puedes añadir una valoración con el comentario vacío.");
            }
                
        }
        private void btn_EliminarValoracion_Click(object sender, EventArgs e)
        {
            Valoraciones nuevaValoracion = new Valoraciones();
            nuevaValoracion.ID_Libro1 = idLibroSeleccionado;
            nuevaValoracion.ID_Usuario1 = idUsuario;
            
            using(IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"DELETE Valoraciones WHERE ID_Usuario="+nuevaValoracion.ID_Usuario1+" AND ID_Libro="+nuevaValoracion.ID_Libro1+"";
                db.Execute(consulta, nuevaValoracion);
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
