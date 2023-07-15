namespace Ejercicio1_Asbtraccion
{
    public class Avion : MedioTransporte
    {
        public override string Arrancar()
        {
            return "Despego";
        }

        public override string Detener()
        {
            return "Aterrizo";
        }
    }
}
