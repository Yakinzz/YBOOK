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
        //Configuro la acción del botón para cambiar al formulario de Registro
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        
        

        private void btn_Entrar_Click(object sender, EventArgs e)
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
            
            if(usuarioVerificado != false)
            {
                PaginaPrincipal form_PaginaPrincipal = new PaginaPrincipal(listaUsuarios,usuario.Username,cadenaConexion,usuario.ID1);
                form_PaginaPrincipal.Show();
                Hide();
            }
        }



        /* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -*/

        public List<Usuario> GetAllUsuario()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Usuario>)db.GetAll<Usuario>();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listaUsuarios = GetAllUsuario();

            Registro form = new Registro(listaUsuarios, cadenaConexion);
            form.Show();
            Hide();
        }
    }
    
}
