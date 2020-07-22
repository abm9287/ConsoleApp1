using System;

namespace App1.Logica
{
    public class Empresa : GeneradorAutomaticoIdentificacion
    {
        public string Nombre { get; set; }

        public Empresa() : base()
        { }

        public Empresa(int id) : base(id)
        { }

        public Empresa(string id) : base(id)
        { }

        public Celular ConstruirCelular(string modelo)
        {
            return new Celular()
            {
                Marca = Nombre,
                Modelo = modelo
            };
        }

        public Bicicleta ConstruirBicicleta(string marca, string modelo, int precio)
        {
            return new Bicicleta { Marca = marca, Modelo = modelo, Precio = precio };
        }

        public Automovil ConstruirAutomovil(string modelo)
        {
            return new Automovil()
            {
                Marca = Nombre,
                Modelo = modelo
            };
        }
    }
}
