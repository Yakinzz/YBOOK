using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib.Extensions;

namespace YBOOK
{
    public partial class ConfirmacionEstado : Form
    {
        static string cadenaConexion = null;
        Libro libroSeleccionado = new Libro();
        int idUsuario;
        int totalPaginas;
        int paginaActual;
        Button btn = new Button();
        Button btnn = new Button();
        
        
        public ConfirmacionEstado(Libro libroSeleccionadoA, string cadenaConexionA,int idUsuarioA, Button btnA,Button btnAA)
        {
            InitializeComponent();
            libroSeleccionado = libroSeleccionadoA;
            cadenaConexion = cadenaConexionA;
            idUsuario = idUsuarioA;
            btn = btnA;
            btnn = btnAA;
            
            totalPaginas = libroSeleccionado.NumeroPaginas1;
            
            //Completo los datos en el formulario
            cb_Estados.SelectedIndex = 0;
            txtTotalPaginas.Text = totalPaginas.ToString();

            
            
            
        }
        
        private static void AddAMisLibros(Libro nuevoMiLibro,int idUsuario,string estadoA, int numeroPagina)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"INSERT INTO MisLibros (ID_Usuario,ID_Libro,Estado,NumeroPaginaActual) VALUES ('" + idUsuario + "'," + nuevoMiLibro.ID1 + ",'" + estadoA + "','"+ numeroPagina +"')";
                db.Execute(consulta, nuevoMiLibro);
            }
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (cb_Estados.Text != "")
            {
                if (txtPaginaActual.Text != "")
                {
                    int numeroPagina = int.Parse(txtPaginaActual.Text);
                    
                    if (numeroPagina>=0 && numeroPagina<=totalPaginas)
                    {
                        AddAMisLibros(libroSeleccionado,idUsuario,cb_Estados.Text,numeroPagina);
                        MessageBox.Show("Se añadió a tus libros");
                        btn.Visible = false;
                        btnn.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Página incorrecta. No puede estar fuera del rango de paginas del libro.");
                    }
                }
                else
                {
                    MessageBox.Show("Tienes que indicar el número de pagina en el que te encuentras.");
                }
            }
            else
            {
                MessageBox.Show("Tienes que seleccionar un estado");
            }
        }


        private void btnCancelarForm_Click(object sender, EventArgs e)
        {
           this.Close();
        }


        private void cb_Estados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Estados.Text == "Leyendo")
            {
                label_paginas.Show();
                txtTotalPaginas.Show();
                label_barra.Show();
                txtPaginaActual.Show();
                txtTotalPaginas.Text = totalPaginas.ToString();
                paginaActual = 0;
                txtPaginaActual.Text = paginaActual.ToString();
            }
            else if (cb_Estados.Text == "Deseado")
            {
                label_paginas.Hide();
                txtTotalPaginas.Hide();
                label_barra.Hide();
                txtPaginaActual.Hide();
                paginaActual = 0;
            }
            else if (cb_Estados.Text == "Leido")
            {
                label_paginas.Show();
                txtTotalPaginas.Show();
                label_barra.Show();
                txtPaginaActual.Show();
                paginaActual = totalPaginas;
                txtPaginaActual.Text = paginaActual.ToString();
                txtPaginaActual.Enabled = false;
            }
        }
    }
}