using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//para hacer la conexion con la base de datos
using System.Data.Entity;

namespace ProyectoWeb.Models
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Id_Proveedor { get; set; }
        public int No_sirac { get; set;  }
    }

    public class UsuariosDBContext : DbContext
    {
        public DbSet<Usuarios> Users { get; set; }
    }
}