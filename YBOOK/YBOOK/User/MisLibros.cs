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
    public partial class MisLibros : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        List<Libro> libros = new List<Libro>();
        List<EstadoLibro> librosUsuario = new List<EstadoLibro>();
        int idUsuario;
        string cadenaConexion = null;
        Usuario usuarioActivo = new Usuario();
        EstadoLibro libroUsuario = new EstadoLibro();
        int progreso = 0;
        int paginaActual = 0;
        public MisLibros(string cadenaConexionA, List<Usuario> usuarios, int idUsuario)
        {
            InitializeComponent();
            cadenaConexion = cadenaConexionA;
            this.usuarios = usuarios;
            this.idUsuario = idUsuario;
            


            Usuario usuario = new Usuario();


            for (int i = 0; i < usuarios.Count(); i++)
            {
                usuario = usuarios[i];
                if (usuario.ID1 == idUsuario)
                {
                    usuarioActivo = usuarios[i];
                    break;
                }
            }

            librosUsuario = GetAllMisLibros();
            libros = GetAllLibros();

            

            List<string> listdelibros = new List<string>();

            string nombreLibro = null;
            

            for (int i = 0; i < librosUsuario.Count(); i++)
            {
                libroUsuario = librosUsuario[i];


                if (libroUsuario.ID_Usuario1 == usuarioActivo.ID1)
                {
                    Libro libro = new Libro();

                    for (int j = 0; j < libros.Count(); j++)
                    {
                        libro = libros[j];
                        if (libro.ID1.Equals(libroUsuario.ID_Libro1))
                        {
                            listdelibros.Add(libro.Titulo1);
                            progreso = (libroUsuario.NumeroPaginaActual1 * 100) / libro.NumeroPaginas1;
                            break;
                        }
                    }

                }
            }

            listBox1.DataSource=listdelibros;



            
            if (listBox1.Items.Count > 0)
            {
                string libroSeleccionado = listBox1.SelectedItem.ToString();

                Libro libro = new Libro();
                Libro libroActual = new Libro();
                for (int i = 0; i < libros.Count(); i++)
                {
                    libro = libros[i];
                    if (libro.Titulo1.Equals(libroSeleccionado))
                    {
                        libroActual = libro;
                        break;
                    }
                }

                string estadoLibro = null;
                int paginaActual = 0;

                EstadoLibro libroUsuarioo = new EstadoLibro();
                for (int i = 0; i < librosUsuario.Count(); i++)
                {
                    libroUsuarioo = librosUsuario[i];

                    if (libroUsuarioo.ID_Usuario1 == usuarioActivo.ID1 && libroUsuarioo.ID_Libro1 == libroActual.ID1)
                    {
                        estadoLibro = libroUsuarioo.Estado1;
                        paginaActual = libroUsuarioo.NumeroPaginaActual1;
                        break;
                    }
                }

                txtTitulo.Text = libroActual.Titulo1;
                txt_Idioma.Text = libroActual.Idioma1;
                txt_paginasTotales.Text = libroActual.NumeroPaginas1.ToString();
                cb_Estado.Text = estadoLibro;
                progressBar1.Value = progreso;


                if (estadoLibro == "Leyendo")
                {
                    label9.Show();
                    numeric_PaginaActual.Show();
                    numeric_PaginaActual.Value = paginaActual;
                    progressBar1.Value = progreso;
                    
                }else if (estadoLibro == "Deseado")
                {
                    numeric_PaginaActual.Hide();
                    label9.Hide();
                    progressBar1.Hide();
                    lb_progreso.Hide();
                }
                else
                {
                    numeric_PaginaActual.Hide();
                    label9.Hide();
                    progressBar1.Value = 100;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string libroSeleccionado = listBox1.SelectedItem.ToString();

            Libro libro = new Libro();
            Libro libroActual = new Libro();
            for (int i = 0; i < libros.Count(); i++)
            {
                libro = libros[i];
                if (libro.Titulo1.Equals(libroSeleccionado))
                {
                    libroActual = libro;
                    break;
                }
            }

            string estadoLibro = null;
            

            EstadoLibro libroUsuarioo = new EstadoLibro();
            for (int i = 0; i < librosUsuario.Count(); i++)
            {
                libroUsuarioo = librosUsuario[i];

                if (libroUsuarioo.ID_Usuario1 == usuarioActivo.ID1 && libroUsuarioo.ID_Libro1 == libroActual.ID1)
                {
                    estadoLibro = libroUsuarioo.Estado1;
                    paginaActual = libroUsuarioo.NumeroPaginaActual1;
                    break;
                }
            }

            txtTitulo.Text = libroActual.Titulo1;
            txt_Idioma.Text = libroActual.Idioma1;
            txt_paginasTotales.Text = libroActual.NumeroPaginas1.ToString();
            cb_Estado.Text = estadoLibro;

            if (estadoLibro == "Leyendo")
            {
                label9.Show();
                numeric_PaginaActual.Show();
                numeric_PaginaActual.Value = paginaActual;
                progressBar1.Value = progreso;

            }
            else if (estadoLibro == "Deseado")
            {
                numeric_PaginaActual.Hide();
                label9.Hide();
                progressBar1.Hide();
                lb_progreso.Hide();
            }
            else if (estadoLibro == "Leido")
            {
                numeric_PaginaActual.Hide();
                label9.Hide();
                progressBar1.Hide();
                lb_progreso.Show();
                progressBar1.Value = 100;
            }
        }




        public List<EstadoLibro> GetAllMisLibros()
            {
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    return (List<EstadoLibro>)db.GetAll<EstadoLibro>();
                }
            }
            public List<Libro> GetAllLibros()
            {
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    return (List<Libro>)db.GetAll<Libro>();
                }
            }



            private void cb_Estado_SelectedIndexChanged(object sender, EventArgs e)
            { 
                if (cb_Estado.Text == "Leyendo")
                {
                    label9.Show();
                    numeric_PaginaActual.Show();
                    numeric_PaginaActual.Value = paginaActual;
                    progressBar1.Value = progreso;
                }
                else if (cb_Estado.Text == "Deseado")
                {
                    numeric_PaginaActual.Hide();
                    label9.Hide();
                    progressBar1.Hide();
                    lb_progreso.Hide();
                }
                else
                {
                    numeric_PaginaActual.Hide();
                    label9.Hide();
                    lb_progreso.Show();
                    progressBar1.Show();
                    progressBar1.Value = 100;
                
                }
            }

        
    }
    

        
    
}
