using System;
using App1.Logica;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");

            var empresa = new Empresa();

            var estudiante = new Persona("Steven", "Chavez")
            {
                Celular = empresa.ConstruirCelular("Samsung")
            };

            estudiante.Automovil = empresa.ConstruirAutomovil("Sandero");
            estudiante.Bicicleta = empresa.ConstruirBicicleta("GT", "Karakoram", 900);

            Console.WriteLine(estudiante.Saludar());
            Console.WriteLine(estudiante.IndicarCelular());
            Console.WriteLine(estudiante.Bicicleta.Frenar());

            Console.WriteLine("Ingresa tu nombre: ");
            var nombre = Console.ReadLine();

            var saludo = estudiante.SaludarPersona(nombre);
            Console.WriteLine(saludo);
            Console.ReadKey();
        }
    }
}