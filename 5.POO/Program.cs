using _5.BibliotecaDeClases;
using System;


namespace _5.POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Nombre = "Osvaldo";
            p.Apellido = "Caballero";
            p.FechaNacimiento = new DateTime(2013, 5, 14);

            Console.WriteLine("Buenos días, {0}", p);
            Console.WriteLine("Hoy tienes {0} años", p.Edad());

            Persona p2 = new Persona("Monica", "Caballero", new DateTime(1982, 11, 2));
            Console.WriteLine("Buenos días {0}", p2);
            Console.WriteLine("Hoy tienes {0} años", p2.Edad());
        }
    }
}
