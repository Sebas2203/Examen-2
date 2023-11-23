using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reparacionweb.classes
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }

        public Usuario(int id, string nombre, string correo, int telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
        }

        public Usuario() { }

        public void AgregarUsuario()
        {

        }
        public void ConsultarUsuario()
        {

        }
        public void ModificarUsuario()
        {

        }
        public void BorrarUsuario()
        {

        }
    }
}