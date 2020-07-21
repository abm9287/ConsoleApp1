using System;

namespace App1.Logica
{
    public class Persona : GeneradorAutomaticoIdentificacion
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private Celular celular;
        public Celular Celular
        {
            get { return celular; }
            set
            {
                celular = value;
                celular.Propietario = this;
            }
        }

        private Automovil automovil;
        public Automovil Automovil
        {
            get { return automovil; }
            set
            {
                automovil = value;
                automovil.Propietario = this;
            }
        }

        private Bicicleta bicicleta;
        public Bicicleta Bicicleta
        {
            get { return bicicleta; }
            set
            {
                bicicleta = value;
                bicicleta.Propietario = this;
            }
        }

        public string SaludarPersona(string nombre)
        {
            return $"Hola {nombre} soy {Nombre}";
        }

        public Persona(string nombre, string apellido) : base()
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Saludar()
        {
            return $"Hola, me llamo {Nombre} {Apellido} es un placer.";
        }

        public string IndicarCelular()
        {
            return $"Tengo un {Celular.Modelo} y su id es {Celular.Id}";
        }
    }
}