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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YBOOK.User
{
   
    public partial class CambiarPassword : Form
    {
        public static string cadenaConexion = null;
        int idUsuario;
        Usuario usuario = new Usuario();
        Usuario usuarioActivo = new Usuario();
        List<Usuario> usuarios = new List<Usuario>();
        String passwordActual = null;
        public CambiarPassword(string cadenaConexionA, int idUsuario)
        {
            InitializeComponent();
            cadenaConexion = cadenaConexionA;
            
            this.idUsuario = idUsuario;
            
            usuarios = GetAllUsuarios();

            for (int i = 0; i < usuarios.Count(); i++)
            {
                usuario = usuarios[i];
                
                if (usuario.ID1 == idUsuario)
                {
                    usuarioActivo = usuario;
                    break;
                }
            }

            
            passwordActual = usuarioActivo.Password;


        }


        private void btn_CambiarPassword_Click(object sender, EventArgs e)
        {
            string rex_Password = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            Boolean passwordActualCorrecta = false;
            Boolean passwordValida = false;

            if (!txtContraseñaActual.Text.Equals(""))
            {
                if (txtContraseñaActual.Text.Equals(passwordActual))
                {
                    passwordActualCorrecta = true;
                }
                else
                {
                    MessageBox.Show("La contraseña actual no es correcta.");
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual no puede quedar vacia.");
            }



            if (passwordActualCorrecta)
            {
                if (!txtNuevaContraseña.Text.Equals("") && !txtContraseñaNuevaRepetida.Text.Equals(""))
                {
                    if (txtNuevaContraseña.Text.Equals(txtContraseñaNuevaRepetida.Text))
                    {
                        if (Regex.IsMatch(txtNuevaContraseña.Text, rex_Password))
                        {
                            passwordValida=true;
                        }
                        else
                        {
                            MessageBox.Show("La nueva contraseña no tiene el formato correcto.");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Las nuevas contraseñas tienen que ser iguales.");
                    }

                }
                else
                {
                    MessageBox.Show("Las nuevas contraseñas no puede quedar vacias.");
                }
            }

            if (passwordValida)
            {
                using (IDbConnection db = new SqlConnection(cadenaConexion))
                {
                    var consulta = $@"UPDATE Usuarios SET Password= '" + txtNuevaContraseña.Text + "' WHERE UsuarioID='" + idUsuario + "'";
                    db.Execute(consulta);
                    MessageBox.Show("Contraseña actualizada correctamente.");
                    this.Close();
                }
            }
            
            
        }

        public List<Usuario> GetAllUsuarios()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Usuario>)db.GetAll<Usuario>();
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
