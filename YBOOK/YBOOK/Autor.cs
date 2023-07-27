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
        int ID;
        string Nombre;
        string Apellidos;
        string Nacionalidad;
        string FechaNacimiento;
        string FechaFallecimiento;
        

        public Autor()
        {
            
        }

        public Autor(string nombre, string apellidos, string nacionalidad, string fechaNacimiento, string fechaDefuncion)
        {
            Nombre = nombre;
            Nacionalidad = nacionalidad;
            FechaNacimiento = fechaNacimiento;
            FechaFallecimiento = fechaDefuncion;
            Apellidos = apellidos;
        }

        [Key] public int ID1 { get => ID; set => ID = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }
        public string FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string FechaDefuncion1 { get => FechaFallecimiento; set => FechaFallecimiento = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }


            /*public override string ToString()
            {
                //return "Codigo: " + Codigo + " ,Nombre: " + Nombre + " , CodigoEquipo: " + Codigo + " , Posicion:" + Posicion + " , Edad:" + Edad + " , Goles:" + Goles + " , TA:" + TA + " , TR:" + TR + " , Minutos:" + Minutos + " , Precio Mercado:" + PrecioMercado + " , Dorsal:" + Dorsal + " , Peso:" + Peso;
            }*/
        }
}
