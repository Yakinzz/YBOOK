using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;

namespace YBOOK
{
    public partial class NuevoActor : Form
    {
        Boolean fallecido = false;
        public static string cadenaConexion = null;
        public NuevoActor(string cadenaConexionA)
        {
            InitializeComponent();
            cadenaConexion = cadenaConexionA;
            label_FF.Hide();
            dt_FechaFallecimiento.Hide();
        }

        private void check_Fallecido_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Fallecido.Checked != false)
            {
                label_FF.Show();
                dt_FechaFallecimiento.Show();
                fallecido = true;
            }
            else
            {
                label_FF.Hide();
                dt_FechaFallecimiento.Hide();
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CrearAutor_Click(object sender, EventArgs e)
        {
            Autor nuevoAutor = new Autor();
            if (txt_Nombre.Text != "")
            {
                nuevoAutor.Nombre1 = txt_Nombre.Text;
                if (txt_Apellidos.Text != "")
                {
                    nuevoAutor.Apellidos1 = txt_Apellidos.Text;
                    if(cb_Nacionalidad.Text!="")
                    {
                        nuevoAutor.Nacionalidad1 = cb_Nacionalidad.Text;
                        nuevoAutor.FechaNacimiento1 = dt_FechaNacimiento.Value;
                        if (fallecido != false)
                        {
                            nuevoAutor.FechaFallecimiento1 = dt_FechaFallecimiento.Value;
                            using (IDbConnection db = new SqlConnection(cadenaConexion))
                            {
                                MessageBox.Show("Hola 1");
                                var consulta = $@"INSERT INTO Autores (Nombre,Apellidos,Nacionalidad,FechaNacimiento,FechaFallecimiento) VALUES ("+ nuevoAutor.Nombre1 + "," + nuevoAutor.Apellidos1 + "," + nuevoAutor.Nacionalidad1 + ",'"+ nuevoAutor.FechaNacimiento1 +"','"+ nuevoAutor.FechaFallecimiento1 +"')";
                                db.Execute(consulta,nuevoAutor);
                            }
                        }
                        else
                        {
                            nuevoAutor.FechaFallecimiento1 = dt_FechaFallecimiento.Value;
                            using (IDbConnection db = new SqlConnection(cadenaConexion))
                            {
                                MessageBox.Show("Hola 2");
                                var consulta = $@"INSERT INTO Autores (Nombre,Apellidos,Nacionalidad,FechaNacimiento,FechaFallecimiento) VALUES ('" + nuevoAutor.Nombre1 + "'," + nuevoAutor.Apellidos1 + ",'" + nuevoAutor.Nacionalidad1 + "','"+ nuevoAutor.FechaNacimiento1 +"','"+ nuevoAutor.FechaFallecimiento1 +"')";
                                db.Execute(consulta,nuevoAutor);
                            } 
                        }
                    }else{
                        MessageBox.Show("La nacionalidad del autor es obligatoria.");
                    }
                }
                else
                {
                    MessageBox.Show("Los apellidos del autor son obligatorios."); 
                }
            }
            else
            {
                MessageBox.Show("El nombre del autor es obligatorio.");
            }
        }
    }
}