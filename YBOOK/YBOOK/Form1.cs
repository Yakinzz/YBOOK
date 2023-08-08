using Dapper.Contrib.Extensions;
using MaterialSkin.Controls;
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
using YBOOK.Admin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace YBOOK
{
    public partial class Form_Inicial : Form
    {
        const string cadenaConexion = "Initial Catalog=YBOOK;Data Source=localhost;User=sa;Password=root";
        
        List<Usuario> listaUsuarios = new List<Usuario>();

        public Form_Inicial()
        {
            InitializeComponent();
            
        }


        //Configuro la acción del botón cerrar
        
        private void btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            listaUsuarios = GetAllUsuario();
            Boolean usuarioVerificado = false;

            Usuario usuario = new Usuario();
            for (int i = 0; i < listaUsuarios.Count(); i++)
            {
                usuario = listaUsuarios[i];
                if (txtUsernameLogin.Text.Equals(usuario.Username) && txtPasswordLogin.Text.Equals(usuario.Password))
                {
                    usuarioVerificado = true;
                    break;
                }
            }

            if (usuarioVerificado != false)
            {
                Boolean admin = false;
                List<Rol> roles = new List<Rol>();
                roles = GetAllRoles();
                Rol rol = new Rol();

                for (int i = 0; i < roles.Count(); i++)
                {
                    rol = roles[i];
                    if (rol.Name_Rol1.Equals("Admin") && rol.ID_Usuario1 == usuario.ID1)
                    {
                        admin = true;
                        break;
                    }
                }

                if (admin != false)
                {
                    PaginaPrincipal_Admin formAdmin = new PaginaPrincipal_Admin();
                    formAdmin.Show();
                    Hide();
                }
                else
                {
                    PaginaPrincipal form_PaginaPrincipal = new PaginaPrincipal(listaUsuarios, usuario.Username, cadenaConexion, usuario.ID1);
                    form_PaginaPrincipal.Show();
                    Hide();
                }
            }
        }

        //Configuro la acción del botón para cambiar al formulario de Registro
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            listaUsuarios = GetAllUsuario();

            Registro form = new Registro(listaUsuarios, cadenaConexion);
            form.Show();
            Hide();
        }



        /* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -*/

        public List<Usuario> GetAllUsuario()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Usuario>)db.GetAll<Usuario>();
            }
        }

        
        public List<Rol> GetAllRoles()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Rol>)db.GetAll<Rol>();
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor=Color.RoyalBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void btn_LogIn_MouseHover(object sender, EventArgs e)
        {
            btn_LogIn.BackColor=Color.Black;
            btn_LogIn.ForeColor=Color.White;
            
        }

        private void btn_LogIn_MouseLeave(object sender, EventArgs e)
        {
            btn_LogIn.BackColor = Color.RoyalBlue;
            btn_LogIn.ForeColor = Color.White;
        }
    }
    
}
