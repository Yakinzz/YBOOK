using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBOOK
{

    [Table("Usuarios")]
    public class Usuario
    {
        int UsuarioID;
        string Nombre;
        string Email;
        DateTime FechaNacimiento;
        string Genero;
        string Nacionalidad;
        int telefono;
        string username;
        string password;

        public Usuario()
        {
           
        }

        public Usuario(int UsuarioiD, string nombre, string email, DateTime fechaNacimiento, string genero, string nacionalidad, int telefono, string username, string password)
        {
            ID1 = UsuarioiD;
            Nombre1 = nombre;
            Email1 = email;
            FechaNacimiento1 = fechaNacimiento;
            Genero1 = genero;
            Nacionalidad1 = nacionalidad;
            this.Telefono = telefono;
            this.Username = username;
            this.Password = password;
        }

        [Key] public int ID1 { get => UsuarioID; set => UsuarioID = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Email1 { get => Email; set => Email = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
