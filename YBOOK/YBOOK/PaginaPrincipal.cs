using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace YBOOK
{
    public partial class PaginaPrincipal : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        
        public static string cadenaConexion = null;
        string username = null;
        int id_usuario;
        public PaginaPrincipal(List<Usuario> usuarios,string username, string cadenaConexionA, int id_usuarioA)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.username = username;
            cadenaConexion = cadenaConexionA;
            id_usuario = id_usuarioA;


            txt_UsernamePrueba.Text= username;

            label_NombreSeccion.Text = "BIBLIOTECA";
            this.panelLoader.Controls.Clear();
            Biblioteca formBiblioteca = new Biblioteca(cadenaConexion,id_usuario)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formBiblioteca.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formBiblioteca);
            formBiblioteca.Show();
            btnLibros.Focus();
  
        }

        private void btn_Cerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Application.Exit();
        }



        private void btnLibros_Click(object sender, System.EventArgs e)
        {
            label_NombreSeccion.Text = "BIBLIOTECA";
            this.panelLoader.Controls.Clear();
            Biblioteca formBiblioteca = new Biblioteca(cadenaConexion,id_usuario)
            {
                Dock = DockStyle.Fill, TopLevel = false, TopMost = true
            };
            formBiblioteca.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formBiblioteca);
            formBiblioteca.Show();
        }

        private void btnLibrosUsuario_Click(object sender, EventArgs e)
        {
            label_NombreSeccion.Text = "MIS LIBROS";
            this.panelLoader.Controls.Clear();
            MisLibros formMisLibros = new MisLibros(cadenaConexion,usuarios,id_usuario)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formMisLibros.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formMisLibros);
            formMisLibros.Show();
        }

        private void btnValoracion_Click(object sender, EventArgs e)
        {
            label_NombreSeccion.Text = "VALORACIÓN";
            this.panelLoader.Controls.Clear();
            Valoracion formValoracion = new Valoracion(cadenaConexion, id_usuario)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formValoracion.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formValoracion);
            formValoracion.Show();
        }

       

        private void btnAñadirLibro_Click_1(object sender, EventArgs e)
        {
            label_NombreSeccion.Text = "AÑADIR NUEVO LIBRO";
            this.panelLoader.Controls.Clear();
            AñadirLibro formNuevoLibro = new AñadirLibro(cadenaConexion,id_usuario)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formNuevoLibro.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formNuevoLibro);
            formNuevoLibro.Show();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            label_NombreSeccion.Text = "EDITAR PERFIL";
            this.panelLoader.Controls.Clear();
            EditarPerfil formEditarPerfil = new EditarPerfil(cadenaConexion,id_usuario)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formEditarPerfil.FormBorderStyle = FormBorderStyle.None;
            this.panelLoader.Controls.Add(formEditarPerfil);
            formEditarPerfil.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form_Inicial form = new Form_Inicial();
            form.Show();
            
            Hide();
            MessageBox.Show("Se ha cerrado sesión correctamente.");
        }


        private void btnLibros_MouseMove(object sender, MouseEventArgs e)
        {
            btnLibros.BackColor = Color.RoyalBlue;
            btnLibros.ForeColor = Color.Black;
        }
        private void btnLibros_MouseLeave(object sender, EventArgs e)
        {
            btnLibros.ForeColor = Color.White;
        }


        private void btnLibrosUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnLibrosUsuario.ForeColor = Color.White;
        }

        private void btnLibrosUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            btnLibrosUsuario.BackColor = Color.RoyalBlue;
            btnLibrosUsuario.ForeColor = Color.Black;
        }

        private void btnValoracion_MouseLeave(object sender, EventArgs e)
        {
            btnValoracion.ForeColor = Color.White;
        }

        private void btnValoracion_MouseMove(object sender, MouseEventArgs e)
        {
            btnValoracion.BackColor = Color.RoyalBlue;
            btnValoracion.ForeColor = Color.Black;
        }

        private void btnAñadirLibro_MouseLeave(object sender, EventArgs e)
        {
            btnAñadirLibro.ForeColor = Color.White;
        }

        private void btnAñadirLibro_MouseMove(object sender, MouseEventArgs e)
        {
            btnAñadirLibro.BackColor = Color.RoyalBlue;
            btnAñadirLibro.ForeColor = Color.Black;
        }

        private void btnEditarPerfil_MouseLeave(object sender, EventArgs e)
        {
            btnEditarPerfil.ForeColor = Color.White;
        }

        private void btnEditarPerfil_MouseMove(object sender, MouseEventArgs e)
        {
            btnEditarPerfil.BackColor = Color.RoyalBlue;
            btnEditarPerfil.ForeColor = Color.Black;
        }

        private void btnLogout_MouseMove(object sender, MouseEventArgs e)
        {
            btnLogout.BackColor = Color.RoyalBlue;
            btnLogout.ForeColor = Color.Black;


        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            
            btnLogout.ForeColor = Color.White;
        }

        
    }

    
}
