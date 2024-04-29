using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programacion3.Ejercicios.Entidades.Interfaces;


namespace Programacion3.Ejercicios.Entidades
{
    public abstract class Persona : INombreCompleto
    {
        public string Nombre { get; }
        public string Apellido { get; }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
