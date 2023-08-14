using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBOOK
{
    [Table("Autores")]
    public class Autor
    {
        int AutorID;
        string Nombre;
        string Apellidos;
        string Nacionalidad;
        DateTime FechaNacimiento;
        DateTime FechaFallecimiento;
        
        public Autor()
        {
            
        }

        public Autor(int AutoriD, string nombre, string apellidos, string nacionalidad, DateTime fechaNacimiento, DateTime fechaFallecimiento)
        {
            AutorID = AutoriD;
            Nombre = nombre;
            Apellidos = apellidos;
            Nacionalidad = nacionalidad;
            FechaNacimiento = fechaNacimiento;
            FechaFallecimiento = fechaFallecimiento;
            
        }

        [Key] public int ID1 { get => AutorID; set => AutorID = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public DateTime FechaFallecimiento1 { get => FechaFallecimiento; set => FechaFallecimiento = value; }
    }
}
