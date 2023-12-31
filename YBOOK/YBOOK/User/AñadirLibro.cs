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
    public partial class AñadirLibro : Form
    {
        public static string cadenaConexion = null;
        List<Libro> listlibros = new List<Libro>();
        List<Autor> listautores = new List<Autor>();
        int idUsuario;
        Libro libro = new Libro();
        Libro nuevoLibro = new Libro();
        public AñadirLibro(string cadenaConexionA,int id_Usuario)
        {
            InitializeComponent();

            cadenaConexion = cadenaConexionA;
            idUsuario = id_Usuario;
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


            string fechaPublicacion=null;
            Boolean libroRegistrado = false;
            Boolean valido = false;
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
                    nuevoLibro.Titulo1=txt_Titulo.Text;

                    if (!(cb_Autor.Text == ""))
                    {
                        Autor autor = new Autor();
                        string nombre=null;
                        string apellidos=null;
                        for (int i = 0; i < listautores.Count(); i++)
                        {
                            autor = listautores[i];
                            nombre = cb_Autor.Text.Split('_')[0];
                            apellidos = cb_Autor.Text.Split('_')[1];
                            if(autor.Nombre1.Equals(nombre) && autor.Apellidos1.Equals(apellidos))
                            {
                                nuevoLibro.Autor1 = autor.ID1;
                                break;
                            }
                        }

                        if (!cb_Idioma.Text.Equals(""))
                        {
                            nuevoLibro.Idioma1 = cb_Idioma.Text;

                            if (!txt_Editorial.Text.Equals(""))
                            {
                                nuevoLibro.Editorial1 = txt_Editorial.Text;

                                if (!cb_Categoria.Text.Equals(""))
                                {
                                    nuevoLibro.Categoria1 = cb_Categoria.Text;
                                    if (Numero_Páginas.Value != 0)
                                    {
                                        nuevoLibro.NumeroPaginas1 = (int)Numero_Páginas.Value;
                                        DateTime fecha = fecha_Publicacion.Value;
                                        fechaPublicacion = fecha.ToString("yyyy/MM/dd");                                       
                                        valido = true;
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


            //Compruebo que el libro haya pasado todas la validaciones
            if (valido == true)
            {
                
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    var consulta = $@"INSERT INTO Libros (Titulo,AutorID,Idioma,Editorial,Categoria,FechaPublicacion,NumeroPaginas) VALUES ('" + nuevoLibro.Titulo1 + "'," + nuevoLibro.Autor1 + ",'" + nuevoLibro.Idioma1 + "','" + nuevoLibro.Editorial1 + "','" + nuevoLibro.Categoria1 + "','" + fechaPublicacion + "'," + nuevoLibro.NumeroPaginas1 + ")";
                    db.Execute(consulta, nuevoLibro);
                }
                MessageBox.Show("El libro " + txt_Titulo.Text + " se ha agregado correctamente.");
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


        private void btn_AddAutor_Click(object sender, EventArgs e)
        {
            NuevoActor form = new NuevoActor(cadenaConexion);
            form.Show();
        }
    }
}
