using System;

namespace Porgramacion_Orientada_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.nombre = "Wilson";
            persona.edad = 32;
            persona.genero = 'M';
            persona.fechaNacimiento = new DateTime(1989, 2, 1);
            Console.WriteLine($"Nombre: {persona.nombre}");
            Console.WriteLine($"Edad: {persona.edad}");
            Console.WriteLine($"Genero: {persona.genero}");
            Console.WriteLine($"Fecha Nacimiento : {persona.fechaNacimiento}");
        }
    }

    class Persona
    {
        public string nombre;
        public int edad;
        public char genero;
        public DateTime fechaNacimiento;
    }
}
