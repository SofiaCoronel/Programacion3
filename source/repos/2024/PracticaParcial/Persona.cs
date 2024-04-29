using PracticaParcial.Ejercicios.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial.Ejercicios.Entidades
{
    public abstract class Persona : INombreCompleto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";  // Combine properties with string interpolation

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
