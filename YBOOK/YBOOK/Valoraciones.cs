using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBOOK
{
    [Table("Valoraciones")]
    public class Valoraciones
    {
        int ValoracionID;
        int Puntuacion;
        string Comentario;
        int UsuarioID;
        int LibroID;
        DateTime FechaValoracion;

        public Valoraciones()
        {
            
        }

        public Valoraciones(int valoracionID, int puntuacion, string comentario, int UsuarioiD, int LibroiD, DateTime fechaValoracion)
        {
            ValoracionID = valoracionID;
            Puntuacion = puntuacion;
            Comentario = comentario;
            UsuarioID = UsuarioiD;
            LibroID = LibroiD;
            FechaValoracion = fechaValoracion;
        }

        [Key]public int ValoracionID1 { get => ValoracionID; set => ValoracionID = value; }
        public int Puntucion1 { get => Puntuacion; set => Puntuacion = value; }
        public string Comentario1 { get => Comentario; set => Comentario = value; }
        public int ID_Usuario1 { get => UsuarioID; set => UsuarioID = value; }
        public int ID_Libro1 { get => LibroID; set => LibroID = value; }
        public DateTime FechaValoracion1 { get => FechaValoracion; set => FechaValoracion = value; }
    }
}
