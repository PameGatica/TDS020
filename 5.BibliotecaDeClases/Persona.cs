using System;
using System.Collections.Generic;
using System.Text;

namespace _5.BibliotecaDeClases
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }

        public int Edad()
        {
            int edad = DateTime.Today.Year - FechaNacimiento.Year;

            if (DateTime.Today < FechaNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }
    }


}
