using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace YBOOK
{

    [Table("Usuarios")]
    public class Usuario
    {
        int UsuarioID;
        string Nombre;
        string Apellidos;
        string Email;
        DateTime FechaNacimiento;
        string Genero;
        string Nacionalidad;
        int telefono;
        string username;
        string password;
        string rol;

        public Usuario()
        {
           
        }
        public Usuario(string nombre,string aplleidos, string email, int telefono, string username, string password, string rol)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Telefono = telefono;
            this.Username = username;
            this.Password = password;
            this.rol = rol;
        }

        public Usuario(int UsuarioiD, string nombre,string apellidos, string email, DateTime fechaNacimiento, string genero, string nacionalidad, int telefono, string username, string password, string rol)
        {
            ID1 = UsuarioiD;
            Nombre1 = nombre;
            Apellidos = apellidos;
            Email1 = email;
            FechaNacimiento1 = fechaNacimiento;
            Genero1 = genero;
            Nacionalidad1 = nacionalidad;
            this.Telefono = telefono;
            this.Username = username;
            this.Password = password;
            this.rol = rol;
        }

        [Key] public int ID1 { get => UsuarioID; set => UsuarioID = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public string Email1 { get => Email; set => Email = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }

    }
}
