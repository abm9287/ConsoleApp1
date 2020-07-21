using System;

namespace App1.Logica
{
    public class GeneradorAutomaticoIdentificacion
    {
        readonly Random random = new Random();

        public int Id { get; set; }

        public GeneradorAutomaticoIdentificacion()
        {
            Id = random.Next();
        }

        public GeneradorAutomaticoIdentificacion(int identificador)
        {
            Id = identificador;
        }

        public GeneradorAutomaticoIdentificacion(string identificadorCadena)
        {
            Id = Convert.ToInt32(identificadorCadena);
        }
    }
}