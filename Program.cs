using System;

namespace Porgramacion_Orientada_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Wilson";
            persona.Edad = 32;
            persona.Genero = 'M';
            persona.FechaNacimiento = new DateTime(1989, 2, 1);
            persona.Dpi = "2240619800101";
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Genero: {persona.Genero}");
            Console.WriteLine($"Fecha Nacimiento : {persona.FechaNacimiento}");
            Console.WriteLine($"DPI: {persona.Dpi}");
            
        }
    }

    class Persona
    {
        string nombre;
        int edad;
        char genero;
        DateTime fechaNacimiento;
        string dpi;

        //Defincion de Propiedades
        //Propiedad que tiene logica incluida
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("Edad Invalida");
                else
                    edad = value;
            }
        }
        //Instruccion de propiedades automaticas
        public string Nombre { get; set; }
        public char Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dpi { get; set; }
        
    }
}
