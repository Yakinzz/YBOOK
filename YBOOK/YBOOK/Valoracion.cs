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


            //Se cargan todos los libros en el combobox----------------------------------------------
            Libro libro = new Libro();
            for (int i = 0; i < listlibros.Count(); i++)
            {
                libro = listlibros[i];
                cb_libros.Items.Add(libro.Titulo1);
            }


            //Si tiene algún elemento el combobox, selecciono el primero-------------------------
            if(cb_libros.Items.Count > 0)
            {
                cb_libros.SelectedIndex = 0;
            }
            else
            {
                cb_libros.SelectedIndex = 1;
                nombreLibroSeleccionado = cb_libros.SelectedItem.ToString();
            }

            
            


        }
        private void cb_libros_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                
                MessageBox.Show(v.ID_Libro1.ToString() +" -- "+ v.ID_Usuario1);
                    if(idLibroSeleccionado==v.ID_Libro1 && idUsuario == v.ID_Usuario1)
                    {

                        encontrado = true;
                        MessageBox.Show("Encontrado");
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
                //Puntuacion
                lbPuntuacion.Visible = true;
                txtPuntuacion.Visible = true;
                txtPuntuacion.Text = v.Puntucion1.ToString();
                //Comentario
                lbComentario.Visible = true;
                txtComentario.Visible = true;
                txtComentario.Text = v.Comentario1;
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

        
    }
}
