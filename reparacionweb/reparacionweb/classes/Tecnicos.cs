using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reparacionweb.classes
{
    public class Tecnicos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string especialidad { get; set; }

        public Tecnicos(int id, int idUsuario, string nombre, string especialidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.especialidad = especialidad;
        }

        public Tecnicos() { }

        public void AgregarTecnico()
        {

        }
        public void ConsultarTecnico()
        {

        }
        public void ModificarTecnico()
        {

        }
        public void BorrarTecnico()
        {

        }
    }

}