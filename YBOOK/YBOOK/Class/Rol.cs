using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBOOK
{
    [Table("Roles")]
    public class Rol
    {
        int ID_Rol;
        string Name_Rol;
        int ID_Usuario;

        public Rol()
        {
            
        }

        public Rol(int iD_Rol, string name_Rol, int iD_Usuario)
        {
            ID_Rol1 = iD_Rol;
            Name_Rol1 = name_Rol;
            ID_Usuario1 = iD_Usuario;
        }

        [Key]public int ID_Rol1 { get => ID_Rol; set => ID_Rol = value; }
        public string Name_Rol1 { get => Name_Rol; set => Name_Rol = value; }
        public int ID_Usuario1 { get => ID_Usuario; set => ID_Usuario = value; }
    }


}
