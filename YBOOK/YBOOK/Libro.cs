using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace YBOOK
{
    [Table("Libros")]
    public class Libro
    {
        int ID;
        string Titulo;
        string Autor;
        string Idioma;
        string Editorial;
        string Categoria;
        DateTime FechaPublicacion;
        int NumeroPaginas;

        public Libro()
        {
           
        }
        public Libro(int iD, string titulo, string autor, string idioma, string editorial, string categoria, DateTime fechaPublicacion, int numeroPaginas)
        {
            ID = iD;
            Titulo = titulo;
            Autor = autor;
            Idioma = idioma;
            Editorial = editorial;
            Categoria = categoria;
            FechaPublicacion = fechaPublicacion;
            NumeroPaginas = numeroPaginas;
        }

        [Key] public int ID1 { get => ID; set => ID = value; }
        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
        public string Idioma1 { get => Idioma; set => Idioma = value; }
        public string Editorial1 { get => Editorial; set => Editorial = value; }
        public string Categoria1 { get => Categoria; set => Categoria = value; }
        public DateTime FechaPublicacion1 { get => FechaPublicacion; set => FechaPublicacion = value; }
        public int NumeroPaginas1 { get => NumeroPaginas; set => NumeroPaginas = value; }
    }
}
