namespace App1.Logica
{
    public class Bicicleta : MedioTransporte
    {
        public float Precio { get; set; }

        public Bicicleta() : base()
        {
        }

        public new string Frenar()
        {
            return $"La bicicleta {Id} {Marca} {Modelo} {base.Frenar()}";
        }
    }
}