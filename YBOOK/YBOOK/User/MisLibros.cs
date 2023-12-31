﻿using Dapper;
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
        Libro libroActual = new Libro();
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
                
                if (cb_Estado.Text == "Leyendo")
                {
                    label9.Show();
                    txtPaginaActual.Show();
                    txtPaginaActual.Text = paginaActual.ToString();
                    progressBar1.Show();
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = libroActual.NumeroPaginas1;
                    progressBar1.Value = paginaActual;
                }
                else if (cb_Estado.Text == "Deseado")
                {
                    txtPaginaActual.Hide();
                    label9.Hide();
                    progressBar1.Hide();
                    lb_progreso.Hide();
                }
                else
                {
                    txtPaginaActual.Hide();
                    label9.Hide();
                    progressBar1.Show();
                    progressBar1.Value = 100;
                }
            }
        }
        /*----------  Se controla cuando se selecciona un nuevo libro en el listBox  ----------*/
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string libroSeleccionado = listBox1.SelectedItem.ToString();

            Libro libro = new Libro();
            
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
                txtPaginaActual.Show();
                txtPaginaActual.Text = paginaActual.ToString();
                progressBar1.Value = progreso;

            }
            else if (estadoLibro == "Deseado")
            {
                txtPaginaActual.Hide();
                label9.Hide();
                progressBar1.Hide();
                lb_progreso.Hide();
            }
            else if (estadoLibro == "Leido")
            {
                txtPaginaActual.Hide();
                label9.Hide();
                progressBar1.Hide();
                lb_progreso.Show();
                progressBar1.Value = 100;
            }
        }
        /*----------  Se controla la acción de cambiar el estado del libro  ----------*/
        private void cb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Estado.Text == "Leyendo")
            {
                label9.Show();
                txtPaginaActual.Show();
                txtPaginaActual.Text = "0";
                progressBar1.Show();
                progressBar1.Value = 0;
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    var consulta = $@"UPDATE MisLibros SET Estado='" + cb_Estado.Text + "',NumeroPaginaActual="+txtPaginaActual.Text+" WHERE ID_Usuario=" + idUsuario + " AND ID_Libro=" + libroActual.ID1 + "";
                    db.Execute(consulta, libroActual);
                }

            }
            else if (cb_Estado.Text == "Deseado")
            {
                txtPaginaActual.Hide();
                label9.Hide();
                progressBar1.Hide();
                lb_progreso.Hide();
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    var consulta = $@"UPDATE MisLibros SET Estado='" + cb_Estado.Text + "',NumeroPaginaActual=0 WHERE ID_Usuario=" + idUsuario + " AND ID_Libro=" + libroActual.ID1 + "";
                    db.Execute(consulta, libroActual);
                }

            }
            else
            {
                txtPaginaActual.Hide();
                label9.Hide();
                lb_progreso.Show();
                progressBar1.Show();
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 100;
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    var consulta = $@"UPDATE MisLibros SET Estado='" + cb_Estado.Text + "',NumeroPaginaActual="+libroActual.NumeroPaginas1+" WHERE ID_Usuario=" + idUsuario + " AND ID_Libro=" + libroActual.ID1 + "";
                    db.Execute(consulta, libroActual);
                }

            }

            
        }
        /*----------  Controlo cuando modifico el valor de la pagina actual  ----------*/
        private void txtPaginaActual_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPaginaActual.Text != "")
            {
                int numeroPaginasTotales = int.Parse(txt_paginasTotales.Text);
                int paginaActual = int.Parse(txtPaginaActual.Text);
                if (paginaActual >= 0 && paginaActual < numeroPaginasTotales)
                {
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = numeroPaginasTotales;
                    progressBar1.Value = paginaActual;

                    using (IDbConnection db = new SqlConnection(cadenaConexion))
                    {
                        var consulta = $@"UPDATE MisLibros SET NumeroPaginaActual="+paginaActual+" WHERE ID_Usuario=" + idUsuario + " AND ID_Libro=" + libroActual.ID1 + "";
                        db.Execute(consulta, libroActual);
                    }
                }
                else
                {
                    MessageBox.Show("El número de página actual no es válido");
                }
            }
            else
            {
                //MessageBox.Show("La página actual es obligatoria si lo estás leyendo.");
            }
            
        }
            
        
        /*----------  Métodos donde se realizan las consultas a la BBDD  ----------*/
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
    }
}
