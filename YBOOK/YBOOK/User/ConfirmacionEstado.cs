using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;

namespace YBOOK
{
    public partial class ConfirmacionEstado : Form
    {
        static string cadenaConexion = null;
        Libro libroSeleccionado = new Libro();
        int idUsuario;
        int totalPaginas;
        int paginaActual;
        public ConfirmacionEstado(Libro libroSeleccionadoA, string cadenaConexionA,int idUsuarioA)
        {
            InitializeComponent();
            libroSeleccionado = libroSeleccionadoA;
            cadenaConexion = cadenaConexionA;
            idUsuario = idUsuarioA;

            totalPaginas = libroSeleccionado.NumeroPaginas1;

           

        }
        
        private static void AddAMisLibros(Libro nuevoMiLibro,int idUsuario)
        {
            
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"INSERT INTO MisLibros (ID_Usuario,ID_Libro) VALUES (" + idUsuario + "," + nuevoMiLibro.ID1 + ")";
                db.Execute(consulta, nuevoMiLibro);
            }
        }

        private void cb_Estados_TextChanged(object sender, EventArgs e)
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
            }
        }
    }
}