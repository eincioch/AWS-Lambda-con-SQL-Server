using System;
using System.Collections.Generic;
using System.Text;

namespace AWS.EVSoft.Dominio.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
    }

    public class PersonaData {

        public static IList<Persona> Personas { get; set; }

        static PersonaData() {
            Personas = new List<Persona>();
            Personas.Add(new Persona { Id = 1, Apellido = "Incio Chapilliquen", Nombre = "Enrique" });
            Personas.Add(new Persona { Id = 2, Apellido = "Alfaro Moron", Nombre = "David" });
            Personas.Add(new Persona { Id = 3, Apellido = "Lopez Quiroz", Nombre = "Jose" });
        }
        
    }
}
