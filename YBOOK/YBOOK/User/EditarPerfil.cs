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

            dateTimePicker1.Text = usuarioActivo.FechaNacimiento1.ToString();

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

            txtNombre.Text = usuarioActivo.Nombre1;
            txtApellidos.Text = usuarioActivo.Apellidos1;
            txtEmail.Text = usuarioActivo.Email1;
            cbGenero.Text = usuarioActivo.Genero1;
            txtUsername.Text = usuarioActivo.Username;
            cb_Nacionalidad.Text = usuarioActivo.Nacionalidad1;
            dateTimePicker1.Text = usuarioActivo.FechaNacimiento1.ToString();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        public List<Usuario> GetAllUsuarios()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Usuario>)db.GetAll<Usuario>();
            }
        }
    }
}
