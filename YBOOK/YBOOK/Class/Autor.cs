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
        string FechaNacimiento;
        string FechaFallecimiento;
        

        public Autor()
        {
            
        }

        public Autor(int AutoriD, string nombre, string apellidos, string nacionalidad, string fechaNacimiento, string fechaDefuncion)
        {
            AutorID = AutoriD;
            Nombre = nombre;
            Nacionalidad = nacionalidad;
            FechaNacimiento = fechaNacimiento;
            FechaFallecimiento = fechaDefuncion;
            Apellidos = apellidos;
        }

        [Key] public int ID1 { get => AutorID; set => AutorID = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
        public string FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string FechaDefuncion1 { get => FechaFallecimiento; set => FechaFallecimiento = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }


            
        }
}
