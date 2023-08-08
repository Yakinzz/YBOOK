using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBOOK
{
    [Table("MisLibros")]
    public class EstadoLibro
    {
        int ID;
        int ID_Usuario;
        int ID_Libro;
        string Estado;
        int NumeroPaginaActual;

        public EstadoLibro()
        {
            
        }

        public EstadoLibro(int iD, int iD_Usuario, int iD_Libro, string estado, int numeroPaginaActual)
        {
            ID = iD;
            ID_Usuario = iD_Usuario;
            ID_Libro = iD_Libro;
            Estado = estado;
            NumeroPaginaActual = numeroPaginaActual;
        }

        [Key]public int ID1 { get => ID; set => ID = value; }
        public int ID_Usuario1 { get => ID_Usuario; set => ID_Usuario = value; }
        public int ID_Libro1 { get => ID_Libro; set => ID_Libro = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public int NumeroPaginaActual1 { get => NumeroPaginaActual; set => NumeroPaginaActual = value; }
    }
}
