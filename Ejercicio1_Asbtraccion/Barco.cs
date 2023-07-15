namespace Ejercicio1_Asbtraccion
{
    public class Barco : MedioTransporte
    {
        public override string Arrancar()
        {
            return "Le pego con una botella";
        }

        public override string Detener()
        {
            return "Tiro el ancla";
        }
    }
}
