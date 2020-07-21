namespace App1.Logica
{
    public class Producto : GeneradorAutomaticoIdentificacion
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Persona Propietario { get; set; }

        public Producto() : base()
        {
        }
    }
}