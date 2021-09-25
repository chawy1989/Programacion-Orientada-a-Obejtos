using System;

namespace Porgramacion_Orientada_a_Objetos
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Wilson Celada";
            persona.Edad = 32;
            persona.Genero = 'M';
            persona.FechaNacimiento = new DateTime(1989, 2, 1);
            persona.Dpi = "2240629800101";
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Genero {persona.Genero}"); 
            Console.WriteLine($" Nacimiento: {persona.FechaNacimiento}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"DPI: {persona.Dpi}");
        }
        
    class Persona
        {
            string nombre;
            int edad;
            char genero;
            DateTime fechaNacimiento;
            string dpi;
            public int Edad { get => edad; set => edad = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public char Genero { get => genero; set => genero = value; }
            public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
            public string Dpi { get => dpi; set => dpi = value; }

        }

        

    }
}
