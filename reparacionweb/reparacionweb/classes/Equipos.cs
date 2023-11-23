using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reparacionweb.classes
{
    public class Equipos
    {
        public int id { get; set; }
        public int idUsuarios { get; set; }
        public string tipoEquipo { get; set; }
        public string modelo { get; set; }

        public Equipos(int id, int idUsuarios, string tipoEquipo, string modelo)
        {
            this.id = id;
            this.idUsuarios = idUsuarios;
            this.tipoEquipo = tipoEquipo;
            this.modelo = modelo;
        }

        public Equipos()
        {
        }

        public void AgregarEquipo()
        {

        }
        public void ConsultarEquipo()
        {

        }
        public void ModificarEquipo()
        {

        }
        public void BorrarEquipo()
        {

        }
    }
}