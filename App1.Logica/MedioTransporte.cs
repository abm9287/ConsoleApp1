namespace App1.Logica
{
    public abstract class MedioTransporte : Producto
    {
        public MedioTransporte() : base()
        {
        }

        public string Acelerar()
        {
            return "está acelerando";
        }

        public string Frenar()
        {
            return "está frenando";
        }
    }
}