using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YBOOK
{
    public partial class Registro : Form
    {

        List<Usuario> listaUsuarios = new List<Usuario>();
        string cadenaConexion = null;
        public Registro(List<Usuario> listaUsuarios2,string cadenaConexionA)
        {
            InitializeComponent();

            listaUsuarios = listaUsuarios2;
            cadenaConexion = cadenaConexionA;

        }

        //Configuro la acción del botón para cambiar al formulario de Login
        private void label1_Click(object sender, EventArgs e)
        {
            Form_Inicial form = new Form_Inicial();
            form.Show();
            Hide();
        }

        //Configuro la acción del botón cerrar
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }
        }


        private void btn_Register_Click(object sender, EventArgs e)
        {
            string errores = "";
            int contadorErrores = 0;



            //Valido la caja de texto del nombre con una expresión regular

            string rex_Nombre = @"^[a-zA-Z\s]+$";
            if (!Regex.IsMatch(txtNombre.Text, rex_Nombre))
            {
                errores = errores + "-Nombre no valido.\n";
                contadorErrores++;
            }





            //Valido la caja de texto del email con una expresión regular

            string rex_Email = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(txtEmail.Text, rex_Email))
            {
                contadorErrores++;
                errores = errores + "-Email no valido.\n";
            }





            //Valido que el usuario que haya puesto no esté registrado y si no lo está verifico que lo que se puso en la caja de texto está bien

            Boolean usuarioEncontrado = false;

            Usuario usuario = new Usuario();
            for (int i = 0; i < listaUsuarios.Count(); i++)
            {
                usuario = listaUsuarios[i];
                if (txtUsername.Text.Equals(usuario.Username))
                {
                    usuarioEncontrado = true;
                    break;
                }
            }

            if (usuarioEncontrado == false)
            {
                string rex_Username = @"^[a-zA-Z0-9_]{3,15}$";

                if (!Regex.IsMatch(txtUsername.Text, rex_Username))
                {
                    contadorErrores++;
                    errores = errores + "-Nombre de usuario no valido.\n";
                }
            }
            else
            {
                errores = errores + "-Nombre de usuario ya logueado.\n";
            }




            //Valido la caja de texto de la password con una expresión regular

            string rex_Password = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            if (!Regex.IsMatch(txtPassword.Text, rex_Password))
            {
                contadorErrores++;
                errores = errores + "-Contraseña no valida.\n";
            }




            //Valido la caja de texto del teléfono con una expresión regular

            string rex_Telefono = @"^[0-9]{9}$";
            if (Regex.IsMatch(txtNumeroTelefono.Text, rex_Telefono))
            {
                contadorErrores++;
                errores = errores + "-Número teléfono no valido.\n";
            }







            //Valido que la fecha esté seleccionada



            if (contadorErrores == 0)
            {
                using (var connection = new SqlConnection(cadenaConexion)) // Cambia SqlConnection según tu base de datos
                {
                    string query_NuevoUsuario = "INSERT INTO Usuarios (, Email) VALUES (@Nombre, @Email)";

                    // Ejecutar el INSERT INTO con Dapper
                    connection.Execute(query_NuevoUsuario, usuario);
                }
            }
        }

        

        
    }

        


    
}
