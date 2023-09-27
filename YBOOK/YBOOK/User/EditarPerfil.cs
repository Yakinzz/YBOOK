using Dapper;
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
using YBOOK.User;

namespace YBOOK
{
    public partial class EditarPerfil : Form
    {
        public static string cadenaConexion = null;
        int idUsuario;
        List<Usuario> usuarios = new List<Usuario>();
        Usuario usuario = new Usuario();
        Usuario usuarioActivo = new Usuario();
        public EditarPerfil(string cadenaConexionA, int idUsuario)
        {
            InitializeComponent();
            cadenaConexion = cadenaConexionA;
            this.idUsuario = idUsuario; 
            usuarios=GetAllUsuarios();

            for (int i = 0; i < usuarios.Count(); i++)
            {
                usuario = usuarios[i];
                if (usuario.ID1 == idUsuario)
                {
                    usuarioActivo = usuarios[i];
                    break;
                }
            }

            txtNombre.Text = usuarioActivo.Nombre1;
            txtApellidos.Text = usuarioActivo.Apellidos1;
            txtEmail.Text= usuarioActivo.Email1;
            cbGenero.Text=usuarioActivo.Genero1;
            txtUsername.Text = usuarioActivo.Username;
            cb_Nacionalidad.Text = usuarioActivo.Nacionalidad1;

            //dateTimePicker1.Text = usuarioActivo.FechaNacimiento1.ToString();

        }

        private void btn_EditarDatos_Click(object sender, EventArgs e)
        {
            btn_Actualizar.Visible=true;
            btn_Actualizar.Enabled = true;
            btn_Canelar.Visible = true;
            btn_Canelar.Enabled = true;

            btn_EditarDatos.Visible = false;
            btn_EditarDatos.Enabled = false;

            txtNombre.Enabled = true;           
            txtApellidos.Enabled = true;           
            txtEmail.Enabled = true;           
            cbGenero.Enabled = true;           
            txtUsername.Enabled = true;           
            cb_Nacionalidad.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void btn_Canelar_Click(object sender, EventArgs e)
        {
            btn_Actualizar.Visible = false;
            btn_Actualizar.Enabled = false;
            btn_Canelar.Visible = false;
            btn_Canelar.Enabled = false;

            btn_EditarDatos.Visible = true;
            btn_EditarDatos.Enabled = true;

            txtNombre.Enabled = false;           
            txtApellidos.Enabled = false;           
            txtEmail.Enabled = false;            
            cbGenero.Enabled = false;            
            txtUsername.Enabled = false;         
            cb_Nacionalidad.Enabled = false;
            dateTimePicker1.Enabled = false;

            List<Usuario> usuariosActualizados = new List<Usuario>();
            usuariosActualizados = GetAllUsuarios();
            Usuario usuarioActualizado = new Usuario();
            Usuario usuarioActualizado2 = new Usuario();

            for (int i = 0; i < usuariosActualizados.Count(); i++)
            {
                usuarioActualizado = usuariosActualizados[i];
                if (usuarioActualizado.ID1 == idUsuario)
                {
                    usuarioActualizado2 = usuariosActualizados[i];
                    break;
                }
            }

            txtNombre.Text = usuarioActualizado2.Nombre1;
            txtApellidos.Text = usuarioActualizado2.Apellidos1;
            txtEmail.Text = usuarioActualizado2.Email1;
            cbGenero.Text = usuarioActualizado2.Genero1;
            txtUsername.Text = usuarioActualizado2.Username;
            cb_Nacionalidad.Text = usuarioActualizado2.Nacionalidad1;
            //dateTimePicker1.Text = usuarioActualizado2.FechaNacimiento1.ToString();

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            String usernameEditado = null;
            Usuario usuarioCompobacion=new Usuario();
            Boolean usernameIgual = false;
            if (!String.IsNullOrEmpty(txtNombre.Text))
            {
                if (!String.IsNullOrEmpty(txtApellidos.Text))
                {
                    if (!String.IsNullOrEmpty(cbGenero.Text))
                    {
                        if (!String.IsNullOrEmpty(cb_Nacionalidad.Text))
                        {
                            if (!String.IsNullOrEmpty(txtUsername.Text))
                            {
                                if(txtUsername.Text == usuarioActivo.Username)
                                {
                                    usernameEditado = usuarioActivo.Username;
                                    using (IDbConnection db = new SqlConnection(cadenaConexion))
                                    {
                                        var consulta = $@"UPDATE Usuarios SET Nombre= '" + txtNombre.Text + "',Apellidos='" + txtApellidos.Text + "',Email='" + txtEmail.Text + "',Genero='" + cbGenero.Text + "',FechaNacimiento='" + dateTimePicker1.Value + "',Username='" + usernameEditado + "',Nacionalidad='" + cb_Nacionalidad.Text + "' WHERE UsuarioID='" + idUsuario + "'";
                                        db.Execute(consulta);
                                        MessageBox.Show("Datos del usuario actualizados correctamente.");

                                        btn_Actualizar.Visible = false;
                                        btn_Actualizar.Enabled = false;
                                        btn_Canelar.Visible = false;
                                        btn_Canelar.Enabled = false;

                                        btn_EditarDatos.Visible = true;
                                        btn_EditarDatos.Enabled = true;

                                        txtNombre.Enabled = false;
                                        txtApellidos.Enabled = false;
                                        txtEmail.Enabled = false;
                                        cbGenero.Enabled = false;
                                        txtUsername.Enabled = false;
                                        cb_Nacionalidad.Enabled = false;
                                        dateTimePicker1.Enabled = false;

                                        List<Usuario> usuariosActualizados = new List<Usuario>();
                                        usuariosActualizados=GetAllUsuarios();
                                        Usuario usuarioActualizado= new Usuario();
                                        Usuario usuarioActualizado2 = new Usuario();

                                        for (int i = 0; i < usuariosActualizados.Count(); i++)
                                        {
                                            usuarioActualizado = usuariosActualizados[i];
                                            if (usuarioActualizado.ID1 == idUsuario)
                                            {
                                                usuarioActualizado2 = usuariosActualizados[i];
                                                break;
                                            }
                                        }

                                        txtNombre.Text = usuarioActualizado2.Nombre1;
                                        txtApellidos.Text = usuarioActualizado2.Apellidos1;
                                        txtEmail.Text = usuarioActualizado2.Email1;
                                        cbGenero.Text = usuarioActualizado2.Genero1;
                                        txtUsername.Text = usuarioActualizado2.Username;
                                        cb_Nacionalidad.Text = usuarioActualizado2.Nacionalidad1;
                                        dateTimePicker1.Text = usuarioActualizado2.FechaNacimiento1.ToString();

                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < usuarios.Count(); i++)
                                    {
                                        usuarioCompobacion = usuarios[i];
                                        if (usuarioCompobacion.Username.Equals(txtUsername.Text))
                                        {
                                            usernameIgual = true;
                                            break;
                                        }
                                     
                                    }

                                    if (!usernameIgual)
                                    {
                                        using (IDbConnection db = new SqlConnection(cadenaConexion))
                                        {
                                            var consulta = $@"UPDATE Usuarios SET Nombre= '" + txtNombre.Text + "',Apellidos='" + txtApellidos.Text + "',Email='" + txtEmail.Text + "',Genero='" + cbGenero.Text + "',FechaNacimiento='" + dateTimePicker1.Value + "',Username='" + txtUsername.Text + "',Nacionalidad='" + cb_Nacionalidad.Text + "' WHERE UsuarioID='" + idUsuario + "'";
                                            db.Execute(consulta);
                                            MessageBox.Show("Datos del usuario actualizados correctamente.");

                                            btn_Actualizar.Visible = false;
                                            btn_Actualizar.Enabled = false;
                                            btn_Canelar.Visible = false;
                                            btn_Canelar.Enabled = false;

                                            btn_EditarDatos.Visible = true;
                                            btn_EditarDatos.Enabled = true;

                                            txtNombre.Enabled = false;
                                            txtApellidos.Enabled = false;
                                            txtEmail.Enabled = false;
                                            cbGenero.Enabled = false;
                                            txtUsername.Enabled = false;
                                            cb_Nacionalidad.Enabled = false;
                                            dateTimePicker1.Enabled = false;

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Este username ya está registrado.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("El username no puede quedar vacio.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La nacionalidad no puede quedar vacia.");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("El genero no puede quedar vacio.");
                    }
                }
                else
                {
                    MessageBox.Show("El apellido no puede quedar vacio.");
                }
            }
            else
            {
                MessageBox.Show("El nombre no puede quedar vacio.");
            }
        }

        public List<Usuario> GetAllUsuarios()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Usuario>)db.GetAll<Usuario>();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarPassword form = new CambiarPassword(cadenaConexion,idUsuario);
            form.Show();
        }
    }
}
