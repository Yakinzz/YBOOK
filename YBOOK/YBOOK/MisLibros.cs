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
        string cadenaConexion=null;
        Usuario usuarioActivo = new Usuario();

        public MisLibros(string cadenaConexionA,List<Usuario> usuarios, int idUsuario)
        {
            InitializeComponent();
            cadenaConexion = cadenaConexionA;
            this.usuarios = usuarios;
            this.idUsuario = idUsuario;
            dataGridView1.ReadOnly = true;

           
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

            EstadoLibro libroUsuario = new EstadoLibro();

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
                            nombreLibro = libro.Titulo1;
                            double progreso = 0;
                            progreso = (libroUsuario.NumeroPaginaActual1 * 100) / libro.NumeroPaginas1;
                            dataGridView1.Rows.Add(nombreLibro,libroUsuario.Estado1,progreso);
                            
                            break;
                        }
                    }
                    
                }
            }

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;

                string libroSeleccionado = dataGridView1.SelectedCells[0].Value.ToString();

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
                        paginaActual = libroUsuario.NumeroPaginaActual1;
                        break;
                    }
                }

                txtTitulo.Text = libroActual.Titulo1;
                lb_Idioma.Text = libroActual.Idioma1;
                lb_NumeroPaginas.Text = libroActual.NumeroPaginas1.ToString();
                cb_Estado.Text = estadoLibro;

                if (estadoLibro == "Leído" || estadoLibro == "Deseado")
                {
                    numeric_PaginaActual.Hide();
                    label9.Hide();
                }
                else
                {
                    numeric_PaginaActual.Show();
                    label9.Show();
                    numeric_PaginaActual.Value = paginaActual;
                }

            }




        }
        int paginaActual = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string libroSeleccionado = dataGridView1.SelectedCells[0].Value.ToString();

            Libro libro = new Libro();
            Libro libroActual = new Libro();
            for (int i = 0; i < libros.Count(); i++)
            {
                libro = libros[i];
                if (libro.Titulo1.Equals(libroSeleccionado))
                {
                    libroActual=libro;
                    break;
                }
            }

            string estadoLibro = null;
            

            EstadoLibro libroUsuario = new EstadoLibro();
            for (int i = 0; i < librosUsuario.Count(); i++)
            {
                libroUsuario = librosUsuario[i];

                if (libroUsuario.ID_Usuario1 == usuarioActivo.ID1 && libroUsuario.ID_Libro1 == libroActual.ID1)
                {
                    estadoLibro = libroUsuario.Estado1;
                    paginaActual = libroUsuario.NumeroPaginaActual1;
                    break;
                }
            }

            txtTitulo.Text = libroActual.Titulo1;
            lb_Idioma.Text = libroActual.Idioma1;
            lb_NumeroPaginas.Text = libroActual.NumeroPaginas1.ToString();
            cb_Estado.Text = estadoLibro;

            if(estadoLibro=="Leído" || estadoLibro=="Deseado")
            {
                numeric_PaginaActual.Hide();
                label9.Hide();
            }
            else
            {
                numeric_PaginaActual.Show();
                label9.Show();
                numeric_PaginaActual.Value = paginaActual;
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
            if (cb_Estado.Text == "Leído" || cb_Estado.Text == "Deseado")
            {
                numeric_PaginaActual.Hide();
                label9.Hide();
            }
            else
            {
                numeric_PaginaActual.Show();
                label9.Show();
                numeric_PaginaActual.Value = paginaActual;
            }
        }

        private void SelectFirstColumnDefault()
        {
            // Primero, asegúrate de que el DataGridView no tenga ninguna celda seleccionada.
            dataGridView1.ClearSelection();

            // A continuación, verifica si hay alguna fila en el DataGridView.
            if (dataGridView1.Rows.Count > 0)
            {
                // Selecciona la primera celda de la primera columna.
                dataGridView1.Rows[0].Cells[0].Selected = true;
            }
        }
    }
}
