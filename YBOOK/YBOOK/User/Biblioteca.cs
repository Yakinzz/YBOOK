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
    public partial class Biblioteca : Form
    {
        public static string cadenaConexion = null;
        List<Libro> libros = new List<Libro>();
        int idUsuario;

        public Biblioteca(string cadenaConexionA,int idUsuarioA)
        {
            InitializeComponent();
            
            
            cadenaConexion = cadenaConexionA;
            idUsuario = idUsuarioA;
            libros = GetAllLibros();

            // Configurar el FlowLayoutPanel
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown; // Los elementos se agregan de arriba hacia abajo.
            flowLayoutPanel1.WrapContents = true; // Los elementos no se envuelven a la siguiente línea.
            flowLayoutPanel1.AutoScroll = true; // Habilitar desplazamiento automático si se exceden las dimensiones del panel.

            CargarElementosEnFlowLayoutPanel();

          

            Libro libro = new Libro();
            for (int i = 0; i < libros.Count(); i++)
            {
                libro = libros[i];
                
            }
            
        }

        // Aquí vendría el código de conexión a la base de datos y consulta para obtener los datos.

        
        private void CargarElementosEnFlowLayoutPanel()
        {

            // Agregar elementos al FlowLayoutPanel según los datos obtenidos.
           
            Libro libro = new Libro();
            for (int i = 0; i < libros.Count(); i++)
            {
                libro = libros[i];
                Button btn= new Button();
                btn.Text = libro.Titulo1;
                btn.Font = new System.Drawing.Font("Acephimere", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.White;
                btn.BackColor = System.Drawing.Color.RoyalBlue;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor=Color.White;
                btn.Size = new System.Drawing.Size(180, 80);
                btn.Click += BotonDato_Click;
                btn.Image = global::YBOOK.Properties.Resources.biblioteca;
                btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void BotonDato_Click(object sender, System.EventArgs e)
        {
            Button botonClicado = (Button)sender;
            string nombre = botonClicado.Text;
            InformacionLibro form = new InformacionLibro(nombre,libros,cadenaConexion,idUsuario);
            form.Show();
        }



        public List<Libro> GetAllLibros()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                return (List<Libro>)db.GetAll<Libro>();
            }
        }
    }

}
