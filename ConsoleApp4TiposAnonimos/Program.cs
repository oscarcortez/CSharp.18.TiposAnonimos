using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4TiposAnonimos
{
    class Program
    {       
        /// <summary>
        /// Tipos anonimos son clases sin nombre, no existe el codigo de dicha clase
        /// 
        /// </summary>
        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }
        }
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona() { Nombre = "Raul", Apellido = "Albiol", Edad = 33 },
                new Persona() { Nombre = "Iago", Apellido = "Aspas", Edad = 30 }
            };

            var resultado = personas.Where(a => a.Edad == 30)
                .Select(a => new { NombreCompleto = $"{a.Nombre} {a.Apellido}" }); // este caso devuelve un tipo de resultado distinto a la tabla inicial

            foreach(var res in resultado)
            {
                Console.WriteLine(res.NombreCompleto);
            }

        }

        
    }
}
